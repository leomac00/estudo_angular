import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormGroup } from "@angular/forms";
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
    this.BooksService.getBookById(this.id).subscribe((book) => {
      this.book = book;
    });
    //build form
    this.form = this.formBuilder.group({
      title: null,
      author: null,
      description: null,
      cover: null,
      status: null,
      liked: null,
    });
  }
  onSubmit(): void {
    this.BooksService.updateBook(this.id, this.form.value);
  }
}
