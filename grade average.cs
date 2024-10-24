using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Leer tres calificaciones y calcular el promedio. 
 * Si el promedio es igual o superior a siete, 
 * imprimir un mensaje indicando que el alumno ha aprobado. */

namespace Itla2daParteModulo1
{
    internal class Average_Calculator
    {
        /* To create a Funtion we use public/private + the methods + Name of the Funtion + (declare type of variables) */
        public static void Average_Calculation(int A, int B, int C)
        {
            int Califications = A + B + C;
            int Average = Califications / 3;
            {
                if (Average >= 70)
                {
                    Console.WriteLine("El Alumno ha aprobado");
                }
                else
                {
                    Console.WriteLine("El alumno ha reprobado la materia");
                }
            }

        }

    }
}