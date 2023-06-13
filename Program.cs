using System;
using System.Timers;
using Video_2_a_8;

namespace Videos
{

    class Ejecucion
    {
        static void Main(string[] args)
        {

            //  La Prueba1 o Video1 fue solo la introduccion

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("VIDEO 2 y 3 =\n");
            Prueba2y3_HolaMundo_y_Comentarios obj3 = new Prueba2y3_HolaMundo_y_Comentarios();
            obj3.InicioCurso();

            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();

            //

            Console.Clear();

            //

            Console.WriteLine("VIDEO 4 =\n");
            Prueba4_TiposDatos obj4 = new Prueba4_TiposDatos();
            obj4.TiposDatos();

            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();


            //

            Console.Clear();

            //

            Console.WriteLine("VIDEO 5 =\n");
            Prueba5_OperadoresAritmeticos obj5 = new Prueba5_OperadoresAritmeticos();
            obj5.CalculadoraRustica();

            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();


            //

            Console.Clear();

            //

            Console.WriteLine("VIDEO 6 =\n");
            Prueba6_OperadorAsignacion_DeclaracionImplicita_ConversionImplicita_y_Explicitas obj6 = new Prueba6_OperadorAsignacion_DeclaracionImplicita_ConversionImplicita_y_Explicitas();
            obj6.Declaraciones();

            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();


            //

            Console.Clear();

            //

            Console.WriteLine("VIDEO 7 =\n");
            Prueba7_Conversion_Texto_a_Numero obj7 = new Prueba7_Conversion_Texto_a_Numero();
            obj7.Conversiones();

            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();


            //

            Console.Clear();

            //

            Console.WriteLine("VIDEO 8 =\n");
            Prueba8_Definicion_y_Uso_Constantes obj8 = new Prueba8_Definicion_y_Uso_Constantes();
            obj8.Constantes();

            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
