using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LYA1_Sintaxis1
{
    public class Lenguaje : Sintaxis
    {
        public Lenguaje()
        {
        }
        public Lenguaje(string nombre) : base(nombre)
        {
        }
        //Numero -> D+ (.D+)?
        //Librerias -> (#include<identificador(.h)?> Librerias)?
        public void Libreria()
        {
            if (getContenido() == "#")
            {
                match("#");
                match("include");
                match("<");
                match(Tipos.Identificador);
                if (getContenido() == ".")
                {
                    match(".");
                    match("h");
                }
                match(">");  // nextToken
                Libreria();
            }
        }
        //Programa  -> Librerias? Variables? Main
        //Librerias -> #include<identificador(.h)?> Librerias?
        //Variables -> tipo_dato Lista_identificadores; Variables?
        //Lista_identificadores -> identificador (,Lista_identificadores)?
        //Bloque de instrucciones -> {lista de intrucciones?}
        //ListaInstrucciones -> Instruccion ListaInstrucciones?
        //Instruccion -> Printf | Scanf | If | While | do while | For | Switch | Asignacion
        //Asignacion -> identificador = cadena | Expresion;
        //While -> while(Condicion) bloque de instrucciones | instruccion
        //Do -> do bloque de instrucciones | intruccion while(Condicion)
        //For -> for(Asignacion Condicion; Incremento) Bloque de instruccones | Intruccion 
        //Incremento -> Identificador ++ | --
        //Condicion -> Expresion operador relacional Expresion
        //If -> if(Condicion) bloque de instrucciones (else bloque de instrucciones)?
        //Printf -> printf(cadena);
        //Scanf -> scanf(cadena);
        //Main      -> void main() Bloque de instrucciones
        //Expresion -> Termino MasTermino
        //MasTermino -> (OperadorTermino Termino)?
        //Termino -> Factor PorFactor
        //PorFactor -> (OperadorFactor Factor)?
        //Factor -> numero | identificador | (Expresion)
    }
}