using System;
//Espacio de Nombres
namespace CS4
{
    //Clase Principal
    class Program
    {
        static void Main(string[] args)
        {
            //Bloque de instrucciones
            //Sesión 8: Estructuras selctivas: dobles y multiples
            //1. Estructura selectiva doble (instrucción if-else)
            //Declaración e inicializacion
            bool foco = false; // A la variable "foco", se e asigna, inicialmente, false
            if (foco == true) //  si la el valor de la variable "foco" es true, entonces...
            {
                Console.WriteLine("el foco esta encendido."); //...impresión del estado del foco: encendido.
            }
            else //En caso contrario, entonces...
            {
                Console.WriteLine("el foco esta apagado"); // imprensión del estado del foco: apagado.
            }
            // 2.Estructura selectiva múltipole (instrucción if-else, if-else)
            //Declaración e inicialización
            int salón = 331; // a la variable "salón", se le asigna, inicialmente, 331.
            if (salón == 331) //Si el valor de la variable "salón" es 331, entonces...
            {
                Console.WriteLine("Exactas"); //Impresión de especialidad: "Exactas".
            }
            else if (salón == 332 || salón == 333) // Si no es igual a 331, pero sí a 332 entonces...
            {
                Console.WriteLine("Administrativas"); // Impresión de especialidad: "Administrativas".
            }
            else if (salón == 333)  // Si no es igual a 331 o 332, pero si a 333, entonces...
            {
                Console.WriteLine("Administrativas");// Impresión de especialidad: "Administrativos"
            }
            else if (salón == 334) // Si no es igual a 331, 332 o 333, pero si a 334, entonces... 
            {
                Console.WriteLine("Humanidades");// impresión de especialidad: "Humanidades".
            }
            else if (salón ==  335) // Si no es igual a 331, 332, 333 o 334, pero sí a 335, entonces... 
            {
                Console.WriteLine("Biológicas");// impresión de especialidad: "Biologicas"
            }
            else // en cualquier otro caso, entonces...
            {
                Console.WriteLine("¡Salón no registrado!"); //... impresión "Salón no registrado!
            }

        }// Termino de la función principal
    }// Termino de la clase principal
}// Termino de espacio de nombres
