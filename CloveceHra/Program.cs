using Clovece;
using Clovece.Service;
using System;

namespace CloveceHra
{
    class Program
    {

        public static void Main(String[] Args)
        {
            string farba;
            int pocet = 0, n = 0;
            Player.Instance.GameWon = false;
            Uvod uvod = new Uvod();
            UI ui = new UI();
            Vypocty vypocet = new Vypocty();
            pocet = uvod.zaciname();
            while (!Player.Instance.GameWon)
            {
                farba = Player.Instance.Poradie[n];
                ui.ui(farba);

                if (n < pocet - 1)
                {
                    n++;
                }
                else
                {
                    n = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
