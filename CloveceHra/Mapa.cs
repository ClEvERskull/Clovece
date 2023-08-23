using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Clovece
{
    class Mapa
    {                //Mam triedu Player, vztvorim tu jej inštanciu, čiže niečo ako objekt tej triedy že existuje.
        private int x;
        private int y;
        private bool inserted;

        public void Draw()
        {
            for (x = 0; x <= 10; x++)
            {
                for(y = 0; y <= 10; y++)
                {
                    inserted = false;
                    for (int i = 0; i < 16; i++)
                    {


                        if ((x == Player.Instance.Hrac_x[i]) && (y == Player.Instance.Hrac_y[i]) && (!inserted))   //potom volám funkcie triedy(void, int, string) ako nazov_treidy.funkcia...cize ju zavolam ako player.Hrac_x
                        {
                            if (Player.Instance.Farba[i].Equals("zelena"))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else if (Player.Instance.Farba[i].Equals("cervena"))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else if (Player.Instance.Farba[i].Equals("modra"))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else if (Player.Instance.Farba[i].Equals("zlta"))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }

                            Console.Write("+ ");
                            inserted = true;
                        }

                    }

                    if (!inserted)
                    {
                        //Vykresli mapu
                        if (x == 0 || x == 1 || x == 2 || x == 3 || x == 7 || x == 8 || x == 9 || x == 10)
                        {
                            if (x == 0 && y == 6)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("O ");
                            }
                            else if ((y == 5 && x == 1) || (y == 5 && x == 2) || (y == 5 && x == 3))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("O ");
                            }

                            else if ((y == 5 && x == 7) || (y == 5 && x == 8) || (y == 5 && x == 9))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("O ");
                            }

                            else if (x == 10 && y == 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("O ");
                            }
                            else if (y == 4 || y == 5 || y == 6)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("O ");
                            }
                            else if ((x == 0 && (y == 0 || y == 1)) || (x == 1 && (y == 0 || y == 1)))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("O ");
                            }
                            else if ((x == 0 && (y == 9 || y == 10)) || (x == 1 && (y == 9 || y == 10)))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("O ");
                            }
                            else if ((x == 9 && (y == 0 || y == 1)) || (x == 10 && (y == 0 || y == 1)))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("O ");
                            }
                            else if ((x == 9 && (y == 9 || y == 10)) || (x == 10 && (y == 9 || y == 10)))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("O ");
                            }
                            else
                            {
                                Console.Write("  ");
                            }

                        }

                        else if (x == 4 || x == 6)
                        {
                            if (x == 4 && y == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("O ");
                            }

                            else if (x == 6 && y == 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("O ");
                            }

                            else if (x == 4 && y == 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("O ");
                            }
                            else if (x == 6 && y == 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("O ");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("O ");
                            }
                        }



                        else if (x == 5)
                        {
                            if (y == 1 || y == 2 || y == 3 || y == 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("O ");
                            }

                            else if (y == 6 || y == 7 || y == 8 || y == 9)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("O ");
                            }

                            else if (y == 0 || y == 10)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("O ");
                            }

                            else
                                Console.Write("  ");
                        }
                    }

                    Console.ResetColor();
                    
                }

                Console.WriteLine();
            }




        }
        
        
    }
}
