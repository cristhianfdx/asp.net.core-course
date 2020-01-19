using System;

//Operador Ternario
//Boolean Expression ? First Statement : Second Statement

namespace OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x = 20, y = 10;
            int resultado = 0;

            if (x>y)
            {
                resultado = x;
            }else if(x<y){
                resultado = y;
            }

            Console.WriteLine(resultado);*/

            int x = 20, y = 10;

            var resultado = x > y ? x : y;

            Console.WriteLine(resultado);


        }
    }
}
