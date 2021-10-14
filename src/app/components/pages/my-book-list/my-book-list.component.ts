import { Component, OnInit } from "@angular/core";
import { IBook } from "src/app/data/ibook";
import { BooksService } from "src/app/services/books.service";

@Component({
  selector: "app-my-book-list",
  templateUrl: "./my-book-list.component.html",
  styles: [],
})
export class MyBookListComponent implements OnInit {
  constructor(private BooksService: BooksService) {}
  public books!: IBook[];
  ngOnInit(): void {
    this.BooksService.observeAll().subscribe(
      (books) => {
        this.books = books;
      },
      (error) => console.log(error)
    );
  }
}
