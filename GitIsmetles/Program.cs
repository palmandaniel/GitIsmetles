using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIsmetles
{
    class Program
    {
        static string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };
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

        static int JatekosValasztas()
        {
            Console.WriteLine("Kő(0), Papír(1), Olló(2)");
            Console.WriteLine("Válassz: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int GepValasztas()
        {
            Random veletlen = new Random();
            return veletlen.Next(0, 3);
        }
        static void EredmenyKiiras(int gep, int ember)
        {
            Console.WriteLine("Gép: {0} --- Játékos: {1}", lehetoseg[gep], lehetoseg[ember]);

            switch (EmberNyer(gep, ember))
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
        }
        static void Main(string[] args)
        {
            
            int jatekosValasz = JatekosValasztas();
            int gepValasz = GepValasztas();

            EredmenyKiiras(gepValasz, jatekosValasz);
            Console.ReadKey();
        }
    }
}
