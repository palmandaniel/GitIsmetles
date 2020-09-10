﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIsmetles
{
    class Program
    {
        static int gepNyer = 0;
        static int jatekosNyer = 0;
        static int menet = 0;

        static string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };
        static int EmberNyer(int gep, int ember)
        {
            if (gep == 0 && ember == 1 || gep == 1 && ember == 2 || gep == 2 && ember == 0)
            {
                jatekosNyer++;
                return 2; //jatekos nyer
            }
            else if (gep == ember)
            {
                return 0; //dontetlen
            }
            else
            {
                gepNyer++;
                return 1; //gep nyer
            }
        }

        static int JatekosValasztas()
        {
            Console.WriteLine("Kő(0), Papír(1), Olló(2)");
            Console.Write("Válassz: ");
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
            bool tovabb = true;
            
            while (tovabb)
            {
                menet++;

                int jatekosValasz = JatekosValasztas();

                int gepValasz = GepValasztas();

                EredmenyKiiras(gepValasz, jatekosValasz);

                tovabb = AkarJatszani();
            }

            StatisztikaKiiras();
            
            Console.ReadKey();
        }

        private static void StatisztikaKiiras()
        {
            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("Menetek száma: {0}" +
                "\tJátékos győzelmének száma: {1} " +
                "\tGép győzelmének száma: {2}",menet, jatekosNyer, gepNyer);
        }

        private static bool AkarJatszani()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Tovább? [i/n]");
            string valasz = Console.ReadLine().ToLower();
            Console.WriteLine("\n*******************************************************************************");
            if (valasz == "i")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
