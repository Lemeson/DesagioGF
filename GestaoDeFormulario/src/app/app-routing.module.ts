import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientesComponent } from './clientes/clientes.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { PerfilComponent } from './perfil/perfil.component';

const routes: Routes = [
 { path: '', redirectTo: 'dashboard', pathMatch:'full'}, //quando nao tiver nada vai pro dashboard
 { path: 'clientes', component: ClientesComponent},
 { path: 'dashboard', component: DashboardComponent},
 { path: 'perfil', component: PerfilComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
