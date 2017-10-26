using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayordosnumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese el primer numero ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero ");
            int num2 = Convert.ToInt16(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("El numero mayor es " + num1);
            }
            else 
            if (num2 > num1)
            {
                Console.WriteLine("El numero mayor es " + num2);
            }else
                if (num1 == num2)
            {
                Console.WriteLine("Los numeros son iguales.");
            }
            Console.ReadKey();
        }
    }
}
