using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIsmetles
{
    class Program
    {
        static void Main(string[] args)
        {
            Random veletlen = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };

            int gepValasz = veletlen.Next(0, 3);

            Console.WriteLine("Gép választása: {0}", lehetoseg[gepValasz]);

            int jatekosValasz;
            Console.WriteLine("Kő(0), Papír(1), Olló(2)");
            Console.WriteLine("Válassz: ");
            jatekosValasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosValasz]);

            Console.ReadKey();
        }
    }
}
