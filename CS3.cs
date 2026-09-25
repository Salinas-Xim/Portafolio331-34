using System;

namespace CS3
{
    //Espacio de nombres
    class Program
    //Clase principal
    {
        //Función Principal (Main)
        static void Main(string[] args)
        {
            //Sesión 6: Operadores
            //Declaración e inicialización
            double a = 0;
            double b = 1;
            double resultado = 0;
            //1. Operadores aritméticos
            //a. Suma: +
            resultado = a + b;
            Console.WriteLine($"Suma: {resultado}");
            //b. Resta: -
            resultado = a - b;
            Console.WriteLine($"Resta: {resultado}");
            //c.Multiplicación: *
            resultado = a * b;
            Console.WriteLine($"Multiplicación: {resultado}");
            //d.División: /
            resultado = a / b;
            Console.WriteLine($"División: {resultado}");
            //e. Resto (módulo): %
            resultado = a % b;
            Console.WriteLine($"Resuduo: {resultado}");
            
            //Incrementos y decrementos
            //resultado = resultado + 9;
            resultado += 9;
            Console.WriteLine($"Resultado: {resultado}");
            /*
            2. Operadores comparativos
            a. Igualdad: ==
            b. Diferencia: !=
            c. Menor que: <
            d. Mayor que: >
            e. Menor o igual que: <= 
            f. Mayor o igual que: >=
            */
            // Sesión 7: Operadores comparativos
            bool m = false;
            m = 4 == 10;
            Console.WriteLine($"Igualdad: {m}");
            m = 5 != 5;
            Console.WriteLine($"Diferencia: {m}");
            m = 5 > 4;
            Console.WriteLine($"Mayor que: {m}");
            m = 7 < 9;
            Console.WriteLine($"Menor que: {m}");
            //Menor o igual que
            //1. Escribir una expresión que dé como resultado true.
            m = 2 <= 2;
            Console.WriteLine($"menor o igual que: {m}");
            //Mayor o igual que
            //2. Escribir una expresión que dé como resultado false.
            m = 7 >= 3;
            Console.WriteLine($"mayor o igual que: {m}");
            //3. Operadores lógicos
            //a. Y (AND): &&
            //b. O (OR): ||
            bool e = false; //Entrada 1
            bool f = true ; //Entrada 2
            bool d = false; // Resultado
            d =  e && f;
            Console.WriteLine($"Y: {d}");
            d = e || f;
            Console.WriteLine($"O: {d}");
        }//Termino de la funcion principal
    }//Termino de la clase Principal
}//Termino del espacio de nombres