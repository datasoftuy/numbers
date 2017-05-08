using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Num
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;


            Console.WriteLine("Ingrese numero1");
            num1=Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Ingrese numero 2 distsssinto de  0 ");
            num2 = Convert.ToDouble(Console.ReadLine());
            

            if (num2 == 0)
            {
                Console.WriteLine("El numero debe de ser 0 ");
            }
            else
                
                Console.WriteLine("El resultado es :"  + (num1 / num2 ));

            Console.ReadLine();
        
        
        
        }
    }
}
