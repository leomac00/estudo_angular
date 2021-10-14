import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormControl, FormGroup } from "@angular/forms";
import { ActivatedRoute } from "@angular/router";
import { IBook } from "src/app/data/ibook";
import { BooksService } from "src/app/services/books.service";

@Component({
  selector: "app-edit-book",
  templateUrl: "./edit-book.component.html",
  styles: [],
})
export class EditBookComponent implements OnInit {
  constructor(
    private BooksService: BooksService,
    private route: ActivatedRoute,
    private formBuilder: FormBuilder
  ) {}
  public book!: IBook;
  public form!: FormGroup;
  public id: number = this.route.snapshot.params["id"];
  ngOnInit(): void {
    //Get book from API
    this.BooksService.observeById(this.id).subscribe((book) => {
      this.book = book;
    });
    //build form
    this.form = this.formBuilder.group({
      title: null,
      author: null,
      description: null,
      cover: null,
      status: null,
      liked: new FormControl(false),
    });
  }
  onSubmit(): void {
    this.BooksService.update(this.id, this.form.value);
  }
}
