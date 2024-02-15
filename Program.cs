using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khgi


{
    internal class Program
    {
        static void Main(string[] args)

        {

            int o = 0;
            int e = 1;
         

            Console.WriteLine("Numero");
            
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Resultado");

            for (int i = 0; i < n; i++)
            {

                int t = o;


                o = e;


                e = t + o;


                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
        
    }
}
