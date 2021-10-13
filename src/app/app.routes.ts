import { Routes } from "@angular/router";
import { EditBookComponent } from "./components/pages/edit-book/edit-book.component";
import { HomeComponent } from "./components/pages/home/home.component";
import { MyBookListComponent } from "./components/pages/my-book-list/my-book-list.component";
import { RegisterBookComponent } from "./components/pages/register-book/register-book.component";

export const rootRouterConfig: Routes = [
  { path: "", redirectTo: "/home", pathMatch: "full" },
  { path: "home", redirectTo: "/home", pathMatch: "full" },
  { path: "home", component: HomeComponent },
  { path: "myBookList", component: MyBookListComponent },
  { path: "editBook/:id", component: EditBookComponent },
  { path: "registerBook", component: RegisterBookComponent },
];
