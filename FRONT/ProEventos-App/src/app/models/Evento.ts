import { Lote } from "./Lote";
import { Palestrante } from "./Palestrante";
import { RedesSocial } from "./RedesSocial";

export interface Evento{
     id: number;
     local: string;
     dataEvento?: Date; 
     tema: string;
     qtdPessoas: number; 
     imagemURL: string; 
     telefone: string; 
     email: string;
     lote: Lote[];
     redeSocial: RedesSocial[];
     palestranteEvento: Palestrante[];

}