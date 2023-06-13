using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_2_a_8
{
    internal class Prueba4_TiposDatos
    {
        public void TiposDatos()
        {
            int NumerosEnteros = 10;                                   // INT      = 32 bits
            long NumerosEnterosLargos = 10000;                         // LONG     = 64 bits

            // float NumerosDecimales 1.55 ;                           // FLOAT    = 32 bits
            // double NumerosDecimalesLargos = 5.55;                   // DOUBLE   = 64 bits
            // decimal NumerosDecimalesExtraLargos = 0.5555555555;     // DECIMAL  = 128 bits

            char Letra = 'A';                                          // CHAR     = 16 bits
            string Palabra = "Palabra";                                // STRING   = 16 bits * CARACTER

            bool ValorVerdadero = true;                                // BOOL     = 8 bits
            bool ValorFalso = false;                                   // BOOL     = 8 bits

            Console.WriteLine("                                           TIPOS DE DATOS");
            Console.WriteLine();

            Console.WriteLine("Esto es un ejemplo de NUMERO ENTERO (INT): " + NumerosEnteros);
            Console.WriteLine("Esto es un ejemplo de NUMERO ENETERO LARGO (LONG): " + NumerosEnterosLargos);

            Console.WriteLine("Esto es un ejemplo de NUMERO DECIMAL (FLOAT): 1.55F   <- Se pone F para indicar que es FLOAT");
            Console.WriteLine("Esto es un ejemplo de NUMERO DECIMAL LARGO (DOUBLE): 1.55555");

            Console.WriteLine("Esto es un ejemplo de una LETRA (STRING): " + Letra);
            Console.WriteLine("Esto es un ejemplo de un TEXTO (CHAR):  " + Palabra);

            Console.WriteLine("Esto es un ejemplo de BOOLEANO TRUE: " + ValorVerdadero);
            Console.WriteLine("Esto es un ejemplo de BOLLEANO FLASE: " + ValorFalso);

            Console.WriteLine("\n~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  ~ ~ \n");

            Console.WriteLine("                                         VARIABLE 'VAR' ");
            Console.WriteLine();

            Console.WriteLine("Los siguiente que se vara es la VARIABLE tipo VAR, la cual se declara de que tipo es al momento de darle un VALOR");
            Console.WriteLine("Puede ser INT, FLOAT, STRING, CHAR o BOOL segun lo encuentre la maquina (ejecucion)\n");

            var VariableDeterminada_Valor1 = 25;
            var VariableDeterminada_Valor2 = 25.50;
            var VariableDeterminada_Valor3 = "String";
            var VariableDeterminada_Valor4 = 'A';

            Console.WriteLine("Esta es una VARIABLE decalrada como VAR y el copilador le asigna de que TIPO de VARIABLE es: " + VariableDeterminada_Valor1 + " <- INT");
            Console.WriteLine("Esta es una VARIABLE decalrada como VAR y el copilador le asigna de que TIPO de VARIABLE es: " + VariableDeterminada_Valor2 + " <- FLOAT");
            Console.WriteLine("Esta es una VARIABLE decalrada como VAR y el copilador le asigna de que TIPO de VARIABLE es: " + VariableDeterminada_Valor3 + " <- STRING");
            Console.WriteLine("Esta es una VARIABLE decalrada como VAR y el copilador le asigna de que TIPO de VARIABLE es: " + VariableDeterminada_Valor4 + " <- CHAR");

        }
    }

    /* NOTAS VIDEO 4
     
    * BITS = Espacio ocupado en la MEMORIA RAM del ordenador

     * VARIABLES - Declaracion e Iniciaclizacion =
        * Espacios en la memoria (RAM) del ordenador que se ocupa para almacenar VALORES que pueden cambiar 
          durante la ejecucion del programa
     
     * TIPOS DE DATOS:
       * Por VALOR
            * Primitivos =
                         * Enteros      -> Con SIGNO y SIN SIGNO
                         * Reales       -> FLOAT , DOUBLE y DECIMAL
                         * Booleanos    -> TRUE y FALSE
            * Estrucutras
            * Enumerados
            
            * VAR = El COPILADOR decidira que TIPO de VARIABLE es       
       * Por REFERENCIA
       
       * FLUJO DE EJECUCION de ARRIBA a ABAJO
       
       * En C# NO se puede cambiar el TIPO de VALOR dentro del codigo (si es int siempre va a ser int)

     */
}
