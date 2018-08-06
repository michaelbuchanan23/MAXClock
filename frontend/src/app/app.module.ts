import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { MenuItemComponent } from './menu-item/menu-item.component';
import { AppRoutingModule } from './app-routing.module';
import { ClassListComponent } from './class/class-list/class-list.component';
import { ClassDetailComponent } from './class/class-detail/class-detail.component';


@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    MenuItemComponent,
    ClassListComponent,
    ClassDetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
