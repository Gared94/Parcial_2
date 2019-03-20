using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Class1
    {

        int num1, num2;
        public void multiplicar()
        {

            Console.WriteLine("Ingrese dos numeros enteros para multiplicar");
            Console.WriteLine("Ingrese valor 1");
            num1 = int.Parse(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0");
                Console.ReadKey();
            }
            else if(num1 != 0){
                Console.WriteLine("Ingrese valor 2");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("El producto de los numero ingresados es: "+ (num1*num2));
                Console.ReadKey();
            }
            
        }
    }

 
}
