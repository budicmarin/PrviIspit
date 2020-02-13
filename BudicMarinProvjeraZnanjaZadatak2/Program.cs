using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudicMarinProvjeraZnanjaZadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi tri dvoznamenkasta broja odvojena zarezom");
            string unos = Console.ReadLine();
            string[] unosArray = unos.Split(',');
            int prviBroj = Convert.ToInt32(unosArray[0]);
            int drugiBroj= Convert.ToInt32(unosArray[1]);
            int treciBroj= Convert.ToInt32(unosArray[2]);
            int najveci = prviBroj;
            if (najveci < drugiBroj) najveci = drugiBroj;
            if (najveci < treciBroj) najveci = treciBroj;
            Console.WriteLine("Najveci broj je {0}",najveci);
            Console.ReadKey();
        }
    }
}
