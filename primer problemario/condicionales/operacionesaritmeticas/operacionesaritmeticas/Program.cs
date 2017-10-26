using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacionesaritmeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int num1 = Convert.ToInt16(Console.ReadLine());


            if (num1 > 0)
            {
                Console.WriteLine("Ingrese el segundo numero");
                int num2 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("La suma es :" + (num1 + num2));
                Console.WriteLine("Lamultiplicacion es :" + (num1 * num2));
                Console.WriteLine("La division es :" + (num1 / num2));

            }
            else
            {
                Console.Write("No se admiten numeros negativos");
               
            }
            Console.ReadKey();
        }
    }
}
