import { Component, Input, OnInit } from "@angular/core";
import { IBook } from "src/app/data/ibook";
import { BooksService } from "src/app/services/books.service";

@Component({
  selector: "book-card",
  templateUrl: "./book-card.component.html",
  styles: [],
})
export class BookCardComponent implements OnInit {
  @Input() book!: IBook;
  constructor(private BooksService: BooksService) {}

  delete(id: number): void {
    this.BooksService.delete(id);
  }
  ngOnInit(): void {}
}
