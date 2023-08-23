using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clovece.Service;

namespace Clovece
{
    public class Vypocty
    {
        private string[] hraci;


        public string[] Hraci

        {
            get { return hraci; }
            set { hraci = value; }
        }
        public static readonly IScoreService scoreService = new ScoreServiceEF();


        public void vypocet(string farba, int pohyb, int id)
        {
            Player.Instance.Pozicia[id] = Player.Instance.Pozicia[id] + pohyb;
            checkWin(farba);
            vybitie(farba, Player.Instance.Hrac_x[id], Player.Instance.Hrac_y[id], id);

            if (Player.Instance.Pozicia[id] < 44)
            {
                Player.Instance.Hrac_x[id] = Player.Instance.x(farba, Player.Instance.Pozicia[id]);
                Player.Instance.Hrac_y[id] = Player.Instance.y(farba, Player.Instance.Pozicia[id]);
            }

        }

        public void hrac(int pocet)
        {
            int j = 0;
            for (int i = 0; i < pocet; i++)
            {
                if (hraci[i].Equals("zelena"))
                {
                    for (j = 0; j < 4; j++)
                    {
                        Player.Instance.Farba[j] = "zelena";
                        Player.Instance.Hrac_x[j] = Player.Instance.dx(hraci[i], j);
                        Player.Instance.Hrac_y[j] = Player.Instance.dy(hraci[i], j);
                    }
                }

                else if (hraci[i].Equals("cervena"))
                {
                    for (j = 4; j < 8; j++)
                    {
                        Player.Instance.Farba[j] = "cervena";
                        Player.Instance.Hrac_x[j] = Player.Instance.dx(hraci[i], j);
                        Player.Instance.Hrac_y[j] = Player.Instance.dy(hraci[i], j);
                    }

                }
                else if (hraci[i].Equals("modra"))
                {
                    for (j = 8; j < 12; j++)
                    {
                        Player.Instance.Farba[j] = "modra";
                        Player.Instance.Hrac_x[j] = Player.Instance.dx(hraci[i], j);
                        Player.Instance.Hrac_y[j] = Player.Instance.dy(hraci[i], j);
                    }
                }
                else if (hraci[i].Equals("zlta"))
                {
                    for (j = 12; j < 16; j++)
                    {
                        Player.Instance.Farba[j] = "zlta";
                        Player.Instance.Hrac_x[j] = Player.Instance.dx(hraci[i], j);
                        Player.Instance.Hrac_y[j] = Player.Instance.dy(hraci[i], j);
                    }
                }

            }
        }


        public void checkWin(string farba)
        {
            UI ui = new UI();

            int cislo = 0, j = 0;
            string meno = Player.Instance.Name[0];

            if (farba.Equals("zelena"))
            {
                for (j = 0; j < 4; j++)
                {
                    cislo += Player.Instance.Pozicia[j];
                }
                meno = Player.Instance.Name[0];
            }

            else if (farba.Equals("cervena"))
            {
                for (j = 4; j < 8; j++)
                {
                    cislo += Player.Instance.Pozicia[j];
                }
                meno = Player.Instance.Name[4];

            }
            else if (farba.Equals("modra"))
            {
                for (j = 8; j < 12; j++)
                {
                    cislo += Player.Instance.Pozicia[j];
                }
                meno = Player.Instance.Name[8];
            }
            else if (farba.Equals("zlta"))
            {
                for (j = 12; j < 16; j++)
                {
                    cislo += Player.Instance.Pozicia[j];
                }
                meno = Player.Instance.Name[12];
            }

            if (cislo == 166)
            {
                Player.Instance.GameWon = true;
                ui.win(farba, meno);
            }
        }


        public bool domcek(string farba)
        {
            int j = 0, pocitadlo = 0;

            if (farba == "zelena")
            {
                for (j = 0; j < 4; j++)
                {
                    if (Player.Instance.Hrac_x[j] == Player.Instance.dx(farba, j) && Player.Instance.Hrac_y[j] == Player.Instance.dy(farba, j))
                    {
                        Player.Instance.Is_out[j] = false;
                        pocitadlo++;
                    }
                    else
                    {
                        Player.Instance.Is_out[j] = true;
                    }
                }
            }



            else if (farba == "cervena")
            {
                for (j = 4; j < 8; j++)
                {
                    if (Player.Instance.Hrac_x[j] == Player.Instance.dx(farba, j) && Player.Instance.Hrac_y[j] == Player.Instance.dy(farba, j))
                    {
                        Player.Instance.Is_out[j] = false;
                        pocitadlo++;
                    }
                    else
                    {
                        Player.Instance.Is_out[j] = true;
                    }
                }

            }


            else if (farba == "modra")
            {
                for (j = 8; j < 12; j++)
                {
                    if (Player.Instance.Hrac_x[j] == Player.Instance.dx(farba, j) && Player.Instance.Hrac_y[j] == Player.Instance.dy(farba, j))
                    {
                        Player.Instance.Is_out[j] = false;
                        pocitadlo++;
                    }
                    else
                    {
                        Player.Instance.Is_out[j] = true;
                    }
                }
            }


            else if (farba == "zlta")
            {
                for (j = 12; j < 16; j++)
                {
                    if (Player.Instance.Hrac_x[j] == Player.Instance.dx(farba, j) && Player.Instance.Hrac_y[j] == Player.Instance.dy(farba, j))
                    {
                        Player.Instance.Is_out[j] = false;
                        pocitadlo++;
                    }
                    else
                    {
                        Player.Instance.Is_out[j] = true;
                    }
                }
            }


            if (pocitadlo > 0)
                return true;
            else
                return false;
        }


        public bool jeVon(string farba)
        {

            int j = 0, pocitadlo = 0;


            if (farba == "zelena")
            {
                for (j = 0; j < 4; j++)
                {
                    if (Player.Instance.Hrac_x[j] == Player.Instance.dx(farba, j) && Player.Instance.Hrac_y[j] == Player.Instance.dy(farba, j))
                    {
                        Player.Instance.Is_out[j] = false;
                        pocitadlo++;
                    }
                    else
                    {
                        Player.Instance.Is_out[j] = true;
                    }
                }
            }



            else if (farba == "cervena")
            {
                for (j = 4; j < 8; j++)
                {
                    if (Player.Instance.Hrac_x[j] == Player.Instance.dx(farba, j) && Player.Instance.Hrac_y[j] == Player.Instance.dy(farba, j))
                    {
                        Player.Instance.Is_out[j] = false;
                        pocitadlo++;
                    }
                    else
                    {
                        Player.Instance.Is_out[j] = true;
                    }
                }

            }


            else if (farba == "modra")
            {
                for (j = 8; j < 12; j++)
                {
                    if (Player.Instance.Hrac_x[j] == Player.Instance.dx(farba, j) && Player.Instance.Hrac_y[j] == Player.Instance.dy(farba, j))
                    {
                        Player.Instance.Is_out[j] = false;
                        pocitadlo++;
                    }
                    else
                    {
                        Player.Instance.Is_out[j] = true;
                    }
                }
            }


            else if (farba == "zlta")
            {
                for (j = 12; j < 16; j++)
                {
                    if (Player.Instance.Hrac_x[j] == Player.Instance.dx(farba, j) && Player.Instance.Hrac_y[j] == Player.Instance.dy(farba, j))
                    {
                        Player.Instance.Is_out[j] = false;
                        pocitadlo++;
                    }
                    else
                    {
                        Player.Instance.Is_out[j] = true;
                    }
                }
            }


            if(pocitadlo == 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        public void vybitie(string farba, int x, int y, int id)
        {
            int i = 0, kod = 0;
            switch (farba)
            {
                case "zelena":
                    kod = 0;
                    break;

                case "cervena":
                    kod = 1;
                    break;

                case "modra":
                    kod = 2;
                    break;

                case "zlta":
                    kod = 3;
                    break;
            }

            for (i = 0; i < 16; i++)
            {
                if (x == Player.Instance.Hrac_x[i] && y == Player.Instance.Hrac_y[i] && kod != (i / 4))
                {
                    int cislo = i / 4;

                    switch (cislo)
                    {
                        case 0:
                            Player.Instance.Hrac_x[i] = Player.Instance.dx("zelena", i);
                            Player.Instance.Hrac_y[i] = Player.Instance.dy("zelena", i);
                            break;

                        case 1:
                            Player.Instance.Hrac_x[i] = Player.Instance.dx("cervena", i);
                            Player.Instance.Hrac_y[i] = Player.Instance.dy("cervena", i);
                            break;

                        case 2:
                            Player.Instance.Hrac_x[i] = Player.Instance.dx("modra", i);
                            Player.Instance.Hrac_y[i] = Player.Instance.dy("modra", i);
                            break;

                        case 3:
                            Player.Instance.Hrac_x[i] = Player.Instance.dx("zlta", i);
                            Player.Instance.Hrac_y[i] = Player.Instance.dy("zlta", i);
                            break;
                    }

                    Player.Instance.Pozicia[i] = 0;
                    Score score = new Score();
                    score.Points += 1;
                    score.Id = id;
                    score.Player = Player.Instance.Name[id];
                    scoreService.AddScore(score);
                }
            }
        }


        public void PridajMeno(string meno, string farba)
        {
            switch (farba)
            {
                case "zelena":
                    for(int i = 0; i < 4; i++)
                    {
                        Player.Instance.Name[i] = meno;
                    }
                    break;

                case "cervena":
                    for (int i = 4; i < 8; i++)
                    {
                        Player.Instance.Name[i] = meno;
                    }
                    break;

                case "modra":
                    for (int i = 8; i < 12; i++)
                    {
                        Player.Instance.Name[i] = meno;
                    }
                    break;

                case "zlta":
                    for (int i = 12; i < 16; i++)
                    {
                        Player.Instance.Name[i] = meno;
                    }
                    break;
            }
        }
        
        
         
    }
}
