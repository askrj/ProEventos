import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Evento } from "../models/Evento";


@Injectable({
    providedIn: 'root'
})
export class EventoService{
    baseURL = 'https://localhost:5001/api/evento';
    constructor(private htt: HttpClient){ }

    public getEvento(): Observable<Evento[]>{
        return this.htt.get<Evento[]>(this.baseURL);
    }

    public getEventoByTema(tema: string): Observable<Evento[]>{
        return this.htt.get<Evento[]>(`${this.baseURL}/${tema}/tema`);
    }

    public getEventoById(id: number): Observable<Evento>{
        return this.htt.get<Evento>(`${this.baseURL}/${id}`);
    }
}
