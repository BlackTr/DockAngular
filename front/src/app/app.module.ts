import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent }  from './app.component';
import {AppConfig} from "./app-config";
import {HttpModule} from "@angular/http";

@NgModule({
  imports: [
      BrowserModule,
      HttpModule
  ],
  declarations: [ AppComponent ],
  bootstrap: [ AppComponent ],
  providers: [
      {provide: AppConfig, useClass: AppConfig},
  ]
})
export class AppModule { }
