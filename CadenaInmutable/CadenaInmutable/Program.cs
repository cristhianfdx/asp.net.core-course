using System;
using System.Text;

//Un String es inmutable es que no puede cambiar una vez creada.
//StringBuilder es un objeto dinamico que permite expandia el numero de caracteres de la cadena

namespace CadenaInmutable
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = "Hola mundo";
            cadena1 = "Hola mundo!!";
            Console.WriteLine(cadena1);

            StringBuilder sb = new StringBuilder("Hola mundo", 50);
            Console.WriteLine(sb);
            sb.Append(" Esto es c#");
            Console.WriteLine(sb);

            //Metodos
            /*
             * Append / AppendLine -> agregar una cadena a la actual
             * AppendFormat -> formatea la cadena de entrada en un formato específico
             * Insert -> Inserta la cadena en un lugar especifico ej sb.Insert(5," C#");
             * Remove -> Elimina la cadena en el indice especificado
             * Replace -> Reemplaza una cadena por otra
             * ToString -> Convertir un string a StringBuilder
             */

        }
    }
}
