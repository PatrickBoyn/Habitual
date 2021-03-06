import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';
import {HttpClientModule} from "@angular/common/http";
import { LoginComponent } from './login/login.component';
import {FormsModule} from "@angular/forms";
import {AuthService} from "./_services/auth.service";

@NgModule({
  declarations: [
    AppComponent,
    ValueComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    AuthService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
