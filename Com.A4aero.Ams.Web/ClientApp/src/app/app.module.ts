import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AddBusinessEntityComponent } from './components/add-business-entity/add-business-entity.component';
import { EditBusinessEntityComponent } from './components/edit-business-entity/edit-business-entity.component';
import { ListBusinessEntityComponent } from './components/list-business-entity/list-business-entity.component';
import { AddMarkupPlanComponent } from './components/markup-plan/add-markup-plan/add-markup-plan.component';
import { EditMarkupPlanComponent } from './components/markup-plan/edit-markup-plan/edit-markup-plan.component';
import { ListMarkupPlanComponent } from './components/markup-plan/list-markup-plan/list-markup-plan.component';
import { UrlService } from './services/url.service';
import { BaseService } from './services/base.service';
import { MarkupPlanService } from './services/markup-plan.service';
import { BusinessEntityService } from './services/business-entity.service';
import { SidebarComponent } from './components/sidebar/sidebar.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    AddBusinessEntityComponent,
    EditBusinessEntityComponent,
    ListBusinessEntityComponent,
    AddMarkupPlanComponent,
    EditMarkupPlanComponent,
    ListMarkupPlanComponent,
    SidebarComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      {path:'add-business-entity',component:AddBusinessEntityComponent},
      {path:'edit-business-entity',component:EditBusinessEntityComponent},
      {path:'list-business-entity',component:ListBusinessEntityComponent},
      {path:'add-markup-plan',component:AddMarkupPlanComponent},
      {path:'edit-markup-plan',component:EditMarkupPlanComponent},
      {path:'list-markup-plan',component:ListMarkupPlanComponent}
    ])
  ],
  providers: [
    UrlService,
    BaseService,
    MarkupPlanService,
    BusinessEntityService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
