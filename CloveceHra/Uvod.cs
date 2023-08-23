using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clovece
{
    class Uvod
    {
        private int pocet;
        public int Pocet
        {
            get { return pocet; }
            set { pocet = value; }
        }

        private string[] zvolene;


        public int zaciname()
        {
            Vypocty vypocty = new Vypocty();
            string vstup, farba, vystup, meno;
            vystup = "Vitajte v hre Človeče nehnevaj sa!";
            Console.SetCursorPosition((Console.WindowWidth - vystup.Length) / 2, Console.CursorTop);
            Console.WriteLine(vystup);
            Console.WriteLine("Na úvod Vás požiadame zadať pár vstupných údajov.");
            Console.WriteLine("Napíšte číselne počet hráčov v rozmedzí 2 až 4");
            vstup = Console.ReadLine();

            while (vstup != "2" && vstup != "3" && vstup != "4")
            {
                Console.WriteLine("Ospravedlňujem sa, nastala chýba. Zadajte vstup prosím ešte raz");
                vstup = Console.ReadLine();
                pocet = int.Parse(vstup);
            }
            pocet = int.Parse(vstup);
            vypocty.Hraci = new string[pocet];
            zvolene = new string[pocet];
            
          
            for(int i = 0; i < pocet; i++)
            {
                do
                {
                    Console.WriteLine("Prosím zadajte farbu " + (i + 1) + "." + " hráča.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("POUŽITEĽNÉ : cervena, modra, zelena, zlta ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("POUŽITÉ: ");
                    for(int j = 0; j < (pocet - 1); j++)
                    {
                        Console.Write(zvolene[j] + " ");
                    }

                    Console.WriteLine();
                    Console.ResetColor();
                    farba = Console.ReadLine();

                    foreach (string x in zvolene)
                    {
                        if (zvolene.Contains(farba))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Farba už bola použitá !!!");
                            farba = "a";
                            Console.ResetColor();
                        }
                    }

                } while (farba != "cervena" && farba != "modra" && farba != "zelena" && farba != "zlta");

                Console.WriteLine("Prosím zadajte meno " + (i + 1) + "." + " hráča.");
                meno = Console.ReadLine();

                vypocty.PridajMeno(meno, farba);

                vypocty.Hraci[i] = string.Copy(farba);
                zvolene[i] = string.Copy(farba);
                Player.Instance.Poradie[i] = String.Copy(farba);
            }


            vypocty.hrac(pocet);
            for (int i = 0; i < pocet; i++)
            {

                switch (zvolene[i])
                {
                    case "zelena":
                        vypocty.vypocet(zvolene[i], 0, 0);
                        break;

                    case "cervena":
                        vypocty.vypocet(zvolene[i], 0, 4);
                        break;

                    case "modra":
                        vypocty.vypocet(zvolene[i], 0, 8);
                        break;

                    case "zlta":
                        vypocty.vypocet(zvolene[i], 0, 12);
                        break;
                }
            }
            Console.Clear();
            return pocet;
        }
    }
}
