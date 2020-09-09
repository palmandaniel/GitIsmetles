using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIsmetles
{
    class Program
    {
        static int EmberNyer(int gep, int ember)
        {
            if (gep == 0 && ember == 1 || gep == 1 && ember == 2 || gep == 2 && ember == 0)
            {
                return 2;
            }
            else if (gep == ember)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        static void Main(string[] args)
        {
            Random veletlen = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };

            int gepValasz = veletlen.Next(0, 3);


            //Console.WriteLine("Gép választása: {0}", lehetoseg[gepValasz]);

            int jatekosValasz;
            Console.WriteLine("Kő(0), Papír(1), Olló(2)");
            Console.WriteLine("Válassz: ");
            jatekosValasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosValasz]);
            Console.WriteLine("Gép választása: {0}", lehetoseg[gepValasz]);


            Console.WriteLine("Gép: {0} --- Játékos: {1}", lehetoseg[gepValasz], lehetoseg[jatekosValasz]);

            switch (EmberNyer(gepValasz, jatekosValasz))
            {
                case 0:
                    Console.WriteLine("Döntetlen");

                    break;
                case 1:
                    Console.WriteLine("Gép nyert");
                    break;
                case 2:
                    Console.WriteLine("Játékos nyert");
                    break;


            }

            Console.ReadKey();
        }
    }
}
