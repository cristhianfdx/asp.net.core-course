﻿using System;
using System.Collections.Generic;


namespace App2.Models
{
    public class Escuela : ObjetoEscuelaBase
    {
        public int AnhoDeCreacion { get; set; }

        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public string Direccion { get; set; }

        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, int anho) => (Nombre, AnhoDeCreacion) = (nombre, anho);

        public Escuela(string nombre, int anho,
                       TiposEscuela tipo,
                       string pais = "", string ciudad = "") : base()
        {
            (Nombre, AnhoDeCreacion) = (nombre, anho);
            Pais = pais;
            Ciudad = ciudad;
        }

        public Escuela()
        {

        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad:{Ciudad}";
        }        
    }
}
