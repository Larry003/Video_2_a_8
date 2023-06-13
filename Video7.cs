using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_2_a_8
{
    internal class Prueba7_Conversion_Texto_a_Numero
    {
        public void Conversiones()
        {
            Console.WriteLine("                                                 CONVERSION TEXTO A NUMERO\n");

            Console.WriteLine("ESTE ES EL CONVERSOR MAS COMUN:\n");
            Console.WriteLine("Se pasa de un TIPO DE VALOR NO STRING (numero) a STRING\n");
            Console.WriteLine("→ Esto se debe a que al momento en que los USUARIOS escriben algo es de forma STRING y se debe pasar al TIPO DEE VALOR REQUERIDO por el PROGRAMA");

            Console.WriteLine("La NOMENCLATURA es:\n");
            Console.WriteLine("* YA DECLARA LA VARIBALE donde se ALMACENARA el VALOR INTRODUCIDO con ANTERIRORIDAD → ");
            Console.WriteLine("NOMBRE VARIABLE + IGUAL A (=) + TIPO DE DATO + 'PARSE' + (Console.Readline)\n");

            Console.WriteLine("* APENAS se VA a DECLARA LA VARIBALE donde se ALMACENARA el VALOR INTRODUCIDO → ");
            Console.WriteLine("TIPO DE DATO + NOMBRE VARIABLE + IGUAL A (=) + TIPO DE DATO + 'PARSE' + (Console.Readline)\n");

            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////\n");

            Console.WriteLine("                                                  EJEMPLOS DE PROGRAMAS=");

            Console.WriteLine("SUMA BASICA con ENTEROS=");
            Console.WriteLine("Introduce un numero entero (a):");
            int Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce un numero entero (b): ");
            int Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El RESULTADO de la SUMA es: " + (Num1 + Num2));


            Console.WriteLine("\nRESTA BASICA con FLOTANTES=");
            Console.WriteLine("Introduce un numero decimal (a): ");
            float Num3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce un numero decimal (b): ");
            float Num4 = float.Parse(Console.ReadLine());

            Console.WriteLine("El RESULTADO de la RESTA es: " + (Num3 - Num4));

        }
    }

    /*NOTAS VIDEO 7

    * SIEMPRE PONER EL TIPO DE DATO AL QUE SE QUIERE PASAR DE LA SIGUIENTE MANERA:
        * TIPO DATO + PUNTO (.) + PARSE + (Console.Readline()) 

   */
}
