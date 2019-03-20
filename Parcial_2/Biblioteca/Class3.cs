using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Class3
    {
        int i;
        string[] nombres = new string[5];
        public void nombre()
        {
            for (i = 0; i < 5;i++ ) {
                Console.WriteLine("ingrese el nombre "+(i+1));
                nombres[i] = Console.ReadLine();
               
            }
            Console.WriteLine("");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("El nombre es "+ (i+1)+ " "+ nombres[i]);
                Console.ReadKey();
               

            }
            
            
        }
    }
}
