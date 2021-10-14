import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormControl, FormGroup } from "@angular/forms";
import { ActivatedRoute } from "@angular/router";
import { IBook } from "src/app/data/ibook";
import { BooksService } from "src/app/services/books.service";

@Component({
  selector: "app-register-book",
  templateUrl: "./register-book.component.html",
  styles: [],
})
export class RegisterBookComponent implements OnInit {
  constructor(
    private BooksService: BooksService,
    private formBuilder: FormBuilder
  ) {}
  public form!: FormGroup;
  ngOnInit(): void {
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
    this.BooksService.register(this.form.value);
  }
}
