using System;
using System.Security;

namespace SE1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Proyecto en C#
            //2. Sintaxis
            // Tipo_de_dato identificador_variable;
            bool a = true; 
            int c;
            //3.  Interpolación
            //Coombinación de datos dentro de una cadena
            a = true;
            c = 10;
            Console.WriteLine($"Booleano: {a}");
            Console.WriteLine($"Número: {c}");
            //4. Incrementos y decrementos
            int m = 0;
            int n = -1;
            m += 1;
            n -= 3;
            m -= 5;
            n += 9;
            //5. Operador resto (módulo)
            int residuo = 40 % 16;
            Console.WriteLine($"Residuo: {residuo}");
            //6. Operadores aritméticos
            double operación = 0;
            operación = ((30 + 8 -2) /2)* -1 ;
            Console.WriteLine($"Operaación: {operación}");
            
        }

    }
}