using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeropositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese un numero para determinar si es positivo o no");
            int num = Convert.ToInt16(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("EL numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }
            Console.ReadKey();
        }
    }
}
