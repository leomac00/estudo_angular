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
  errorMessage: string = "";
  observeAll(): Observable<IBook[]> {
    return this.http.get<IBook[]>(this.booksUrl);
  }
  observeById(id: number): Observable<IBook> {
    return this.http.get<IBook>(this.booksUrl + id);
  }
  register(bookInfo: string): void {
    this.http.post(this.booksUrl, bookInfo).subscribe(
      (res) => {
        alert("The book was registered successfully");
        this.router.navigate(["/myBookList"]);
      },
      (error) => {
        this.errorMessage = this.handleErrorMessage(error);
        alert(this.errorMessage);
        console.log(error);
      }
    );
  }
  update(id: number, bookInfo: string): void {
    this.http.put(this.booksUrl + id, bookInfo).subscribe(
      (res) => {
        alert("The book was updated successfully");
        this.router.navigate(["/myBookList"]);
      },
      (error) => {
        this.errorMessage = this.handleErrorMessage(error);
        alert(this.errorMessage);
        console.log(error);
      }
    );
  }
  delete(id: number): void {
    this.http.delete(this.booksUrl + id).subscribe(
      (res) => {
        alert("The book was deleted successfully!");
        window.location.reload();
      },
      (error) => {
        this.errorMessage = this.handleErrorMessage(error);
        alert(this.errorMessage);
        console.log(error);
      }
    );
  }
  handleErrorMessage(error: any): string {
    let errors = Object.entries(error.error.errors);
    let formattedMessage =
      "There was an error while processing the request.\nPlease review information submitted:\n";
    errors.forEach((errorItem) => {
      formattedMessage += "- " + errorItem[1] + "\n";
    });
    return formattedMessage;
  }
}
