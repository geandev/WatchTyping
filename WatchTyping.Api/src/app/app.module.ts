import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { PaperComponent } from './components/paper/paper.component';
import { JoinComponent } from './components/join/join.component';


@NgModule({
  declarations: [
    AppComponent,
    PaperComponent,
    JoinComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
