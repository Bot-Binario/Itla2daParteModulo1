/*Leer tres calificaciones y calcular el promedio. 
 * Si el promedio es igual o superior a siete, 
 * imprimir un mensaje indicando que el alumno ha aprobado. */

using Itla2daParteModulo1;
using System;

namespace Showing_Average 
{
 class Program 
    
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Ingrese la primera calificación: ");
            int.TryParse(Console.ReadLine(), out int First_Calification);

            Console.WriteLine("Ingrese la segunda calificación: ");
            int.TryParse(Console.ReadLine(), out int Second_Calification);

            Console.WriteLine("ingrese la tercera calificación: ");
            int.TryParse(Console.ReadLine(), out int Third_Calification);

            {
                Average_Calculator.Average_Calculation(First_Calification, Second_Calification, Third_Calification);    
            }
          
        }
    } 
}
    


