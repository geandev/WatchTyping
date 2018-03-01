import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { PaperComponent } from './components/paper/paper.component';
import { JoinComponent } from './components/join/join.component';
import { AppRouteModule } from "./app.route";


@NgModule({
  declarations: [
    AppComponent,
    PaperComponent,
    JoinComponent
  ],
  imports: [
    AppRouteModule,
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
