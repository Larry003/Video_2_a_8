using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_2_a_8
{
    internal class Prueba6_OperadorAsignacion_DeclaracionImplicita_ConversionImplicita_y_Explicitas
    {
        public void Declaraciones()
        {
            int EdadPersona1;
            int EdadPersona2;
            int EdadPersona3;
            int EdadPersona4;

            EdadPersona1 = EdadPersona2 = EdadPersona3 = EdadPersona4 = 18;

            Console.WriteLine("Este es el valor de la Persona 1: " + EdadPersona1);
            Console.WriteLine("Este es el valor de la Persona 2: " + EdadPersona2);
            Console.WriteLine("Este es el valor de la Persona 3: " + EdadPersona3);
            Console.WriteLine("Este es el valor de la Persona 4: " + EdadPersona4 + "\n");

            Console.WriteLine("Son iguales porque los valores son los mismos con ayuda del operador igual (=)");

            Console.WriteLine("\n~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  ~ ~ \n");

            Console.WriteLine("                                             CONVERSIONES EXPLICITA / CASTING \n");

            Console.WriteLine("Son aquellas conversiones de TIPOS DE VALOR que ocurren al momento de pasar de un TIPO DE VALOR de una VARIABLE a OTRA VARIABLE");

            Console.WriteLine("Ejemplo con TEMPERATURA:\n");

            double TemperaturaMexico = 29.5;
            int TemperaturaCancun;

            TemperaturaCancun = (int)TemperaturaMexico;

            Console.WriteLine("Temperatura en Mexico: 29.5  <- Valor decicidido como DOUBLE");
            Console.WriteLine("Temperatura en Cancun: ##    <- Valor NO DECIDIDIDO en el codigo\n");

            Console.WriteLine("La NOMENCLATURA es:\n");
            Console.WriteLine("VARIABLE a la que SE LE PASA + IGUAL A (=) + ( + TIPO de VARIABLE A CONVERTIR + ) + VARIABLE que CONTIENE el VALOR NECESARIO , ej →");
            Console.WriteLine("→ TemperaturaCancun = (int) TemperaturaMexico     <- De 29.5 PASA a 29\n");

            Console.WriteLine("* La perdida de 0.5 (29.5->29) se debe a que lo omite/ignora. A esto se le llama PERDIDA de INFORMACION o PRECISION\n");

            Console.WriteLine("Y asi queda de Temperatura de Mexico: " + TemperaturaMexico + " <<---- Temperatura de Cancun: " + TemperaturaCancun + "\n");

            Console.WriteLine("\n~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  ~ ~ \n");

            Console.WriteLine("                                                 CONVERSIONES EXPLICITAS\n");

            int HabitantesCdmx2020 = 10000000;
            long HabitantesCdmx2023 = HabitantesCdmx2020;

            Console.WriteLine("El VALOR de CDMX en 2020 es de " + HabitantesCdmx2020 + "y el VALOR de CDMX en 2023 fue de " + HabitantesCdmx2023 + "\n");

            Console.WriteLine("↑  Esto se debe a que 1ero se declara la VARIABLE con VALOR y despues se crea OTRA VARIABLE (en este caso DECLARADO con OTRO TIPO DE VALOR)\n");

            Console.WriteLine("La NOMENCLATURA es:\n");
            Console.WriteLine("TIPO DE DATO + VARIABLE a la que SE LE PASA + IGUAL A (=) + VARIABLE que CONTIENE el VALOR NECESARIO, ej →");
            Console.WriteLine("→ long HabitantesCdmx2023 = HabitantesCdmx2020   <- VALOR = VALOR");


        }


    }

    /*NOTAS VIDEO 6
     
    * CASTING:
                * Al momento de DECLARAR VALORES IGUALES a distintas VARIABLES se debe usar el OPERADOR IGUAL (=)
                * Se utiliza para convertir una VARIABLE a OTRO TIPO DE DATO en otra VARIABLE
    
    * IMPLICITA:
                * Se utiliza cuando el TIPO DE DATO es el mismo en AMBAS VARIABLES
                * Solo se utiliza un IGUAL A (=) para pasar los VALORES
     */
}
