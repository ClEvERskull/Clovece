using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clovece.Service;

namespace Clovece
{
    class UI
    {

        private int hod = 0, pohyb = 0, postava = 0, i = 0, j = 0;
        private string vstup;
        public static readonly IScoreService scoreService = new ScoreServiceEF();

        public void ui(string farba)
        {
            pohyb = 0;
            postava = 0;
            Mapa mapa = new Mapa();
            Kocka kocka = new Kocka();
            Vypocty vypocet = new Vypocty();
            
                mapa.Draw();
                //Console.SetCursorPosition(32, 0);
                //Console.WriteLine(uvod.Hraci[0]);
                Console.WriteLine("Na ťahu je hráč s farbou : " + farba);
                hod = kocka.hod();
                Console.WriteLine("Padlo mu číslo : " + hod);
                pohyb += hod;
                while (hod == 6)
                {
                    if (vypocet.domcek(farba))
                    {
                        Console.WriteLine("V domčeku ešte máte postavičku. Prajete si pridať túto postavičku do hry? [a/n]");
                        vstup = Console.ReadLine();
                        if (vstup.Equals("a"))
                        {
                        do
                        {
                            Console.WriteLine("Vyberte figurku: ");
                            vstup = Console.ReadLine();
                            postava = int.Parse(vstup);

                            switch (farba)
                            {
                                case "zelena":
                                    postava = postava - 1;
                                    break;

                                case "cervena":
                                    postava += 3;
                                    break;

                                case "modra":
                                    postava += 7;
                                    break;

                                case "zlta":
                                    postava += 11;
                                    break;
                            }

                            vypocet.vypocet(farba, 0, postava);
                        } while (Player.Instance.Is_out[postava]);
                            Console.Clear();
                            pohyb -= 6;
                        }
                    }
                    hod = kocka.hod();
                    pohyb += hod;
                    Console.WriteLine("Hráč hodil znova a padlo mu číslo : " + hod);
                }

                switch (farba)
                {
                    case "zelena":
                        i = 0;
                        j = 4;
                        break;

                    case "cervena":
                        i = 4;
                        j = 8;
                        break;

                    case "modra":
                        i = 8;
                        j = 12;
                        break;

                    case "zlta":
                        i = 12;
                        j = 16;
                        break;
                }

            do
            {
                Console.WriteLine("Vyberte si figurku pre pohyb : ");


                vstup = Console.ReadLine();

                while(vstup != "1" && vstup != "2" && vstup != "3" && vstup != "4")
                {
                    Console.WriteLine("Zadany vstup nie je spravny, zadajte znova : ");


                    vstup = Console.ReadLine();
                }


                postava = int.Parse(vstup);

                switch (farba)
                {
                    case "zelena":
                        postava -= 1;
                        break;

                    case "cervena":
                        postava += 3;
                        break;

                    case "modra":
                        postava += 7;
                        break;

                    case "zlta":
                        postava += 11;
                        break;
                }

                vypocet.vypocet(farba, pohyb, postava);
            } while (vypocet.domcek(farba) && !Player.Instance.Is_out[postava]);
                Console.Clear();
        }

        public void win(string farba, string meno)
        {
            Console.Clear();
            Console.WriteLine("Vyhral hráč s farbou : " + farba + " a menom : " + meno);

            Console.Clear();
            Console.WriteLine("Top scores:");
            
            foreach (var score in scoreService.GetTopScores())
            {
                Console.WriteLine("{0} {1}", score.Player, score.Points);
            }

        }
    }
}

