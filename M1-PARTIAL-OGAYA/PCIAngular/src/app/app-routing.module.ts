import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ShowPartsComponent } from './pctable/show-parts/show-parts.component';
import { AddEditPartsComponent } from './pctable/add-edit-parts/add-edit-parts.component';

const routes: Routes = [
  {path: 'showparts', component: ShowPartsComponent},
  {path: 'addeditparts', component: AddEditPartsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
