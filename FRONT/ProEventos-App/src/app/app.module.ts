import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import{ HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventosComponent } from './componets/eventos/eventos.component';
import { PalestrantesComponent } from './componets/palestrantes/palestrantes.component';
import { NavComponent } from './shared/nav/nav.component';


import { CollapseModule } from 'ngx-bootstrap/collapse';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { EventoService } from './services/evento.service';
import { DataTimeFornatPipe } from './helpers/DataTimeFornat.pipe';
import { ModalModule } from 'ngx-bootstrap/modal';
import { ToastrModule } from 'ngx-toastr';
import { NgxSpinnerModule } from 'ngx-spinner';
import { PerfilComponent } from './componets/user/perfil/perfil.component';
import { DashboardComponent } from './componets/dashboard/dashboard.component';
import { ContatosComponent } from './componets/contatos/contatos.component';
import { TituloComponent } from './shared/titulo/titulo.component';
import { EventoDetalheComponent } from './componets/eventos/evento-detalhe/evento-detalhe.component';
import { EventoListaComponent } from './componets/eventos/evento-lista/evento-lista.component';
import { UserComponent } from './componets/user/user.component';
import { LoginComponent } from './componets/user/login/login.component';
import { RegistrarComponent } from './componets/user/registrar/registrar.component';

@NgModule({
  declarations: [
    AppComponent,
    EventosComponent,
      PalestrantesComponent,
      PerfilComponent,
      DashboardComponent,
      ContatosComponent,
      TituloComponent,
      NavComponent,
      DataTimeFornatPipe,
      EventoDetalheComponent,
      EventoListaComponent,
      UserComponent,
      LoginComponent,
      RegistrarComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    CollapseModule.forRoot(),
    TooltipModule.forRoot(),
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    ToastrModule.forRoot(
      {
        timeOut: 5000,
        positionClass: 'toast-bottom-right',
        preventDuplicates: true,
        progressBar: true
      }
    ),
    NgxSpinnerModule

  ],
  providers: [
    EventoService
  ],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class AppModule { }
