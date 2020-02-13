using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudicMarinProvjeraZnanjaZadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi rijec ");
            string rijec = Console.ReadLine();

            string temp = " ";
            for (int i = rijec.Length-1; i >= 0; i--)
            {


                if (i == 0)
                {
                    Console.WriteLine(rijec.Substring(i));
                }
                else
                {
                    
                    Console.WriteLine(temp.PadRight(i)+rijec.Substring(i));
                }
                
            }
            Console.ReadKey();
        }
    }
}
