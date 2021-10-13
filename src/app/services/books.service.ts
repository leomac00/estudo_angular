import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { IBook } from "../data/ibook";
import { Observable } from "rxjs";
import { Router } from "@angular/router";

@Injectable({
  providedIn: "root",
})
export class BooksService {
  constructor(private http: HttpClient, private router: Router) {}
  booksUrl: string = "https://localhost:5001/api/books/";
  defaultErrorMessage: string =
    "There was an error while processing the request.\nPlease review information submitted.";
  getAllBooks(): Observable<IBook[]> {
    let response = this.http.get<IBook[]>(this.booksUrl);
    return response;
  }
  getBookById(id: number): Observable<IBook> {
    let response: Observable<IBook> = this.http.get<IBook>(this.booksUrl + id);
    return response;
  }
  registerBook(bookInfo: string): void {
    this.http.post(this.booksUrl, bookInfo).subscribe(
      (res) => {
        alert("The book was registered successfully");
        this.router.navigate(["/myBookList"]);
      },
      (error) => {
        alert(this.defaultErrorMessage);
        console.log(error);
      }
    );
  }
  updateBook(id: number, bookInfo: string): void {
    this.http.patch(this.booksUrl + id, bookInfo).subscribe(
      (res) => {
        alert("The book was updated successfully");
        this.router.navigate(["/myBookList"]);
      },
      (error) => {
        alert(this.defaultErrorMessage);
        console.log(error);
      }
    );
  }
  deleteBook(id: number): void {
    this.http.delete(this.booksUrl + id).subscribe(
      (res) => {
        alert("The book was deleted successfully!");
        window.location.reload();
      },
      (error) => {
        alert(this.defaultErrorMessage);
        console.log(error);
      }
    );
  }
}