using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Class2
    {
        int val1, val2;
        public void dividir()
        {

            Console.WriteLine("Ingrese dos numeros enteros para dividir");
            Console.WriteLine("Ingrese valor 1");
            val1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese valor 2");
            val2 = int.Parse(Console.ReadLine());

            if (val2 != 0)
            {
                Console.WriteLine("La division de los dos valores es "+(val1/val2));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
                Console.ReadKey();
            }

        }

    }
}
