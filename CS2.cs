using System;
//Espacio de nombres
namespace Name
{
    

}namespace CS2
{
    //Clase Principal

    class Program
    {
        static void Main(string[] args)
        {
            
            //Función Principal
            //Sesión 5: Tipos de datos
            //Sintaxis para declarar variables
            // tipo de dato identificcador_variable;            
            //1. Entero
            int a;
            //2. Cadena de texto
            string s;
            //3.1 Flotantes (precision sencilla)
            float f;
            //3.2 Flotante (presicion doble)
            double d;
            //4. Booleano (lógico)
            bool b;
            // Inicializaciones
            a = 5;
            s = "Exactas";
            f = 8.5F;
            d = 9.5;
            b = true;
            //Palabra reservada: Identificador especial 
            //
            //
            Console.WriteLine($"Entero: {a}");
            Console.WriteLine($"Flotente (presicion sencilla): {f}");
            Console.WriteLine($"Flotente (presicion doble): {d}");
            Console.WriteLine($"Cadena de texto: {s}");
            Console.WriteLine($"Booleano: {b}");
        }
   }
} 