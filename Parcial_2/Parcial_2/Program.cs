using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Parcial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0;

            Console.WriteLine("Presione 1 si desea multiplicar dos valores ingresados");
            Console.WriteLine("Presione 2 si desea dividir dos valores ingresados");
            Console.WriteLine("Presione 3 si desea ingresar 5 nombres");
            Console.WriteLine("Presione 4 si desea ingresar 5 edades");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                Class1 obj = new Class1();
                obj.multiplicar();
                break;

                case 2:
                Class2 obj1 = new Class2();
                obj1.dividir();
                break;

                case 3:
                Class3 obj2 = new Class3();
                obj2.nombre();
                break;

                case 4:
                Class4 obj3 = new Class4();
                obj3.edad();
                break;
            }

           
        }
    }
}
