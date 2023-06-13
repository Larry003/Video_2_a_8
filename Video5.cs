using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_2_a_8
{
    internal class Prueba5_OperadoresAritmeticos
    {
        public void CalculadoraRustica()
        {
            Console.WriteLine("                                          OPERADORES");
            Console.WriteLine();

            int a = 10;
            int b = 5;

            Console.WriteLine("Este es el valor a: " + a);
            Console.WriteLine("Este es el valor b: " + b);

            Console.WriteLine();

            int Suma = a + b;
            int Resta = a - b;
            int Division = a / b;
            int Multiplicacion = a * b;

            Console.WriteLine("Esto es una SUMA: " + Suma);
            Console.WriteLine("Esto es una RESTA: " + Resta);
            Console.WriteLine("Esto es una MULTIPLICACION: " + Multiplicacion);
            Console.WriteLine("Esto es una DIVISION: " + Division);

            Console.WriteLine("\n~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  ~ ~ \n");

            int c = 5;
            float d = 4;

            Console.WriteLine("Este es el valor c: " + c);
            Console.WriteLine("Este es el valor d: " + d);
            Console.WriteLine();
            Console.WriteLine("Esto es un RESIDUO ( % ): " + (c % d));

            Console.WriteLine("\n~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  ~ ~ \n");

            string Hola = "Esto es un SALUDO";

            Console.WriteLine("# Para APRECIARLO se tiene que ver en el codigo, pero son las formas de UNIR VALORES con STRINGS");
            Console.WriteLine();
            Console.WriteLine("CONCETENACION =");
            Console.WriteLine("Esto es un ejemplo, se usa el SIGNO SUMA(+): " + Hola + " CONCATENADO");
            Console.WriteLine();

            Console.WriteLine("INTERPOLACION =");
            Console.WriteLine($"Esto es un ejemplo, se usa el SIGNO DINERO($): {Hola}  INTERPOLADO");

            Console.WriteLine("\n~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  ~ ~ \n");

            Console.WriteLine("                                        INCREMENTO y DECREMENTO\n");

            int edad1 = 18;
            int edad2 = 18;
            int edad3 = 18;
            int edad4 = 18;

            // edad++ -> Tambien se puede poner asi el INCREMENTO 
            // edad-- -> Tambien se puede poner asi el INCREMENTO 

            // La VARIABLE "edad" la pongo 4 veces, porque el codigo va de ARRIBA a ABAJO y se tomaria como base el valor anterior a el otro

            Console.WriteLine("Este es el valor base de la edad: " + edad1 + "\n");

            Console.WriteLine("Esto es la edad con INCREMENTO (dentro del codigo de lectura) : " + (++edad1) + ", esto porque se suma 1.");

            Console.WriteLine($"Esto es la edad con DECREMENTO (dentro del codigo de lectura): {--edad2}, esto porque se resta 1. \n");

            Console.WriteLine("Esto es un INCREMETNO ESPECIFICO (dentro del codigo de lectura): " + (edad3 += 5) + ", esto porque se usa '+=' 5. ");

            Console.WriteLine($"Esto es un DECREMENTO ESPECIFICO (dentro del codigo de lectura): {edad4 -= 5}, esto porque se usa '-=' 5. ");

        }
    }

    /*NOTAS VIDEO 5
    
    * OPERADORES ARITMETICOS
        * SUMA              =   +    = VALORES NUMERICOS o CONCATENAR (unir) STRINGS
        * RESTA             =   -    = VALORES NUMERICOS
        * MULTIPLICACION    =   *    = VALORES NUMERICOS
        * DIVISION          =   /    = VALORES NUMERICOS
        * RESIDUO o MODULO  =   %    = Devolver el RESTANTE de un DIVISION

    * OPERADORES de INCREMENTO = Sumar una unidad a un valor numerioco
    * OPERADORES de DECREMENTO = Restar una unidad a un valor numerioco

    * OPERADORES de INCREMENTO ESPECIFICO =     +=    = DESPUES se pone el NUMERO que tendra que incrementar ( ej. +=5 )
    * OPERADORES de DECREMENTO ESPECIFICO =     -=    = DESPUES se pone el NUMERO que tendra que decrementar ( ej. -=5 )
    
    * CONCATENACION [ + ] = 
        * Console + Punto(.) + WriteLine + ( + Comillas (") + TEXTO + Comillas (") + CONCATENACION (+) + NOMBRE VARIABLE + ) 

    * INTERPOLACION [ $ ] =
        * Console + Punto(.) + WriteLine + ( + INTERPOLACION + Comillas (") + TEXTO + Corchete [ { ] + NOMBRE VARIABLE + Corchete [ } ] + Comillas (") +)
     */
}
