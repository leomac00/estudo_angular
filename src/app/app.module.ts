import { APP_BASE_HREF } from "@angular/common";
import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";

import { AppComponent } from "./app.component";
import { rootRouterConfig } from "./app.routes";
import { NavbarComponent } from "./components/navbar/navbar.component";
import { HomeComponent } from "./components/pages/home/home.component";
import { BookCardComponent } from "./components/book-card/book-card.component";
import { MyBookListComponent } from "./components/pages/my-book-list/my-book-list.component";
import { BooksService } from "./services/books.service";
import { HttpClientModule } from "@angular/common/http";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { EditBookComponent } from "./components/pages/edit-book/edit-book.component";
import { RegisterBookComponent } from './components/pages/register-book/register-book.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    BookCardComponent,
    MyBookListComponent,
    EditBookComponent,
    RegisterBookComponent,
  ],
  imports: [
    BrowserModule,
    [RouterModule.forRoot(rootRouterConfig, { useHash: false })],
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
  ],
  providers: [BooksService, { provide: APP_BASE_HREF, useValue: "/" }],
  bootstrap: [AppComponent],
})
export class AppModule {}
