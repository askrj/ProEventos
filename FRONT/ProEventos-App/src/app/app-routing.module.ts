import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EventosComponent } from './componets/eventos/eventos.component';
import { DashboardComponent } from './componets/dashboard/dashboard.component';
import { PalestrantesComponent } from './componets/palestrantes/palestrantes.component';
import { ContatosComponent } from './componets/contatos/contatos.component';
import { PerfilComponent } from './componets/user/perfil/perfil.component';
import { EventoDetalheComponent } from './componets/eventos/evento-detalhe/evento-detalhe.component';
import { EventoListaComponent } from './componets/eventos/evento-lista/evento-lista.component';
import { UserComponent } from './componets/user/user.component';
import { LoginComponent } from './componets/user/login/login.component';
import { RegistrarComponent } from './componets/user/registrar/registrar.component';

const routes: Routes = [
  {
     path: 'user', component: UserComponent,
     children: [
         {path: 'login', component: LoginComponent},
         {path: 'registrar', component: RegistrarComponent },
     ]
  },
  {path: 'eventos', redirectTo: 'eventos/lista'},
  {
    path: 'eventos', component: EventosComponent,
    children: [
      {path: 'detalhe/:id', component: EventoDetalheComponent},
      {path: 'detalhe', component: EventoDetalheComponent},
      {path: 'lista', component: EventoListaComponent},
    ]},
  {path: 'dashboard', component: DashboardComponent},
  {path: 'palestrantes', component: PalestrantesComponent},
  {path: 'contatos', component: ContatosComponent},
  {path: 'user/perfil', component: PerfilComponent},
  {path: '', redirectTo: 'dashboard', pathMatch: 'full'},
  {path: '**', redirectTo: 'dashboard', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
