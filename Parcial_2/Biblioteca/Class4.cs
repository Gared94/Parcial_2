using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Class4
    {
        int condicion=1,edades;
        public void edad()
        {
            do
            {
                Console.WriteLine("ingrese edad");
                edades = int.Parse(Console.ReadLine());
                

                Console.WriteLine("la edad ingresada es "+edades);
                Console.ReadKey();
                condicion = condicion + 1;
            }
            while (condicion <= 5);
        }
    }
}
