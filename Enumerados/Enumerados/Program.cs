﻿using System;

namespace Enumerados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Dias.Lunes);
            //Console.WriteLine((int)NumeroDia.Lunes);
            Console.WriteLine(Enum.Format(typeof(Dias)));
        }

        enum Dias
        {
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado,
            Domingo

        }

        enum NumeroDia
        {
            Lunes = 2,
            Martes = 3,
            Miercoles = 4,
            Jueves = 5,
            Viernes = 6,
            Sabado = 7,
            Domingo = 1
        }

    }

    
}
