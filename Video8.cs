using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_2_a_8
{
    internal class Prueba8_Definicion_y_Uso_Constantes
    {
        public void Constantes()
        {
            Console.WriteLine("                                                 CONSTANTES\n");

            Console.WriteLine("* CONSTANTE: Espacio de memoria dende se almacena un valor que NO se puede cambiar a lo largo de la ejecucion del programa.");
            Console.WriteLine("* VARIABLE: Espacio de memoria donde se almacena un valor que puede ser cambiado a lo largo de la ejecucion del programa.\n");

            const int Constante = 18;
            float Producto;

            Console.WriteLine("La constante en este caso es el IVA al: " + Constante + "% y ahora se ingresara el precio del prdocuto al cual se le sumara el IVA.");
            Console.WriteLine("Precio: ");
            Producto = int.Parse(Console.ReadLine());

            float Total = Constante * Producto / 100;
            float ProductoFinal = Total + Producto;

            Console.WriteLine("El total del producto con todo e IVA es de: $" + ProductoFinal + " pesos MXN");
        }

        /* USO DE MATH se tiene que utilizar por el momento en el apartado MAIN 
         
            public void Math()
            {
                Console.WriteLine("                                                  MATH\n");
        
                Console.WriteLine("El empleo de la libreria MATH te perimte utilizar funciones matematicas mas complejas (no solo: +, -, *, /)");
                Console.WriteLine("El ejemplo sera con el Area de un circulo usando MATH y CONSTANTES:\n");

                const double Pi = 3.1416;

                Console.WriteLine("Ingresa el radio del circulo en cuestion:");
                double Radio = double.Parse(Console.ReadLine());
                double Area = Math.Pow(Radio, 2) * Pi;

                Console.WriteLine($"El AREA del CIRCULO es: {Area} ");
            }
        */

    }

    /*NOTAS VIDEO 8
    
            * Las CONSTANTES NO SE PUEDEN CAMBIAR A LO LARGO DEL CODIGO        
            * Las CONSTANTES se tienen que declarar junto al TIPO de DATO que es la VARIABLE 

     */
}
