using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> S = new List<float>();
            List<float> M = new List<float>();
            List<float> L = new List<float>();
            float bemenet;
            do
            {                
                Console.WriteLine("Add meg a csomag súlyát: ");
                bemenet = float.Parse(Console.ReadLine());
                if (bemenet > 0 && bemenet <= 5) { S.Add(bemenet); }
                else if (bemenet > 5 && bemenet <= 15) { M.Add(bemenet); }
                else if (bemenet > 15 && bemenet <= 30) { L.Add(bemenet); }
                else { Console.WriteLine("Csomag elutasítva!"); }                ;
            }
            while (bemenet != 0);

            Console.WriteLine($"S mennyisége: {S.Count}");
            Console.WriteLine($"M mennyisége: {M.Count}");
            Console.WriteLine($"L mennyisége: {L.Count}");
        }
    }
}