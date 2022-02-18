import { Evento } from "./Evento";
import { RedesSocial } from "./RedesSocial";

export interface Palestrante{
    id: number;
    nome: string;
    miniCurriculo: string;
    imagemURL: string; 
    telefone: string; 
    email: string;
    redesSociais: RedesSocial[];
    palestranteEvento: Evento[];

}