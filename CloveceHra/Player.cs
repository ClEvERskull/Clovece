using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clovece
{
    public class Player
    {
        private int[] hrac_x;           //vsimni si ze je vytvorena aj privatna premenna kde ju vlastne vytvaram aby existovala
        private int[] hrac_y;
        private string[] farba;
        private bool gameWon;
        private bool[] is_out;
        private string[] poradie;
        private int[] pozicia;
        private string[] name;

        public int[] Hrac_x                 //hrac_x odkazuje na premennu kde je ulozena hodnota
        {
            get { return hrac_x; }
            set { hrac_x = value; }
        }


        public int[] Hrac_y
        {
            get { return hrac_y; }
            set { hrac_y = value; }
        }
        

        public string[] Farba
        {
            get { return farba; }
            set { farba = value; }
        }
        
        public bool GameWon
        {
            get { return gameWon; }
            set { gameWon = value; }
        }


        public bool[] Is_out
        {
            get { return is_out; }
            set { is_out = value; }
        }

        public string[] Poradie
        {
            get { return poradie; }
            set { poradie = value; }
        }

        public int[] Pozicia
        {
            get { return pozicia; }
            set { pozicia = value; }
        }

        public string[] Name
        {
            get { return name; }
            set { name = value; }
        }


        private Player()
        {
            pozicia = new int[16];
            poradie = new string[4];
            name = new string[16];
            is_out = new bool[16];
            hrac_x = new int[16];
            hrac_y = new int[16];   
            farba = new string[16];
            for(int i = 0; i < 4; i++)
            {
                farba[i] = "zelena";
            }
            for (int i = 4; i < 8; i++)
            {
                farba[i] = "cervena";
            }
            for (int i = 8; i < 12; i++)
            {
                farba[i] = "modra";
            }
            for (int i = 12; i < 16; i++)
            {
                farba[i] = "zlta";
            }
        }

        public static readonly Player Instance = new Player();

        int[] zelena_x = new int[] { 0, 1, 2, 3, 4, 4, 4, 4, 4, 5, 6, 6, 6, 6, 6, 7, 8, 9, 10, 10, 10, 9, 8, 7, 6, 6, 6, 6, 6, 5, 4, 4, 4, 4, 4, 3, 2, 1, 0, 0, 1, 2, 3, 4};
        int[] zelena_y = new int[] { 6, 6, 6, 6, 6, 7, 8, 9, 10, 10, 10, 9, 8, 7, 6, 6, 6, 6, 6, 5, 4, 4, 4, 4, 4, 3, 2, 1, 0, 0, 0, 1, 2, 3, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5};
        int[] zedx = new int[] { 0, 0, 1, 1};
        int[] zedy = new int[] { 9, 10, 9, 10};



        int[] cervena_x = new int[] {6, 6, 6, 6, 6, 7, 8, 9, 10, 10, 10, 9, 8, 7, 6, 6, 6, 6, 6, 5, 4, 4, 4, 4, 4, 3, 2, 1, 0, 0, 0, 1, 2, 3, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5};
        int[] cervena_y = new int[] {10, 9, 8, 7, 6, 6, 6, 6, 6, 5, 4, 4, 4, 4, 4, 3, 2, 1, 0, 0, 0, 1, 2, 3, 4, 4, 4, 4, 4, 5, 6, 6, 6, 6, 6, 7, 8, 9, 10, 10, 9, 8, 7, 6};
        int[] cdx = new int[] { 9, 9, 10, 10};
        int[] cdy= new int[] { 9, 10, 9, 10};


        int[] modra_x = new int[] { 10, 9, 8, 7, 6, 6, 6, 6, 6, 5, 4, 4, 4, 4, 4, 3, 2, 1, 0, 0, 0, 1, 2, 3, 4, 4, 4, 4, 4, 5, 6, 6, 6, 6, 6, 7, 8, 9, 10, 10, 9, 8, 7, 6};
        int[] modra_y = new int[] {4, 4, 4, 4, 4, 3, 2, 1, 0, 0, 0, 1, 2, 3, 4, 4, 4, 4, 4, 5, 6, 6, 6, 6, 6, 7, 8, 9, 10, 10, 10, 9, 8, 7, 6, 6, 6, 6, 6, 5, 5, 5, 5, 5};
        int[] mdx = new int[] { 9, 9, 10, 10};
        int[] mdy = new int[] { 0, 1, 0, 1};


        int[] zlta_x = new int[] {4, 4, 4, 4, 4, 3, 2, 1, 0, 0, 0, 1, 2, 3, 4, 4, 4, 4, 4, 5, 6, 6, 6, 6, 6, 7, 8, 9, 10, 10, 10, 9, 8, 7, 6, 6, 6, 6, 6, 5, 5, 5, 5, 5};
        int[] zlta_y = new int[] {0, 1, 2, 3, 4, 4, 4, 4, 4, 5, 6, 6, 6, 6, 6, 7, 8, 9, 10, 10, 10, 9, 8, 7, 6, 6, 6, 6, 6, 5, 4, 4, 4, 4, 4, 3, 2, 1, 0, 0, 1, 2, 3, 4};
        int[] zldx = new int[] { 0, 0, 1, 1};
        int[] zldy = new int[] { 0, 1, 0, 1};

       

        public int x (string farba, int cislo)
        {

            if (farba.Equals("cervena"))
            {
                return cervena_x[cislo];
            }
            else if (farba.Equals("zelena"))
            {
                return zelena_x[cislo];
            }
            else if (farba.Equals("modra"))
            {
                return modra_x[cislo];
            }
            else if (farba.Equals("zlta"))
            {
                return zlta_x[cislo];
            }


            return '0';

        }

        public int y(string farba, int cislo)
        {
            if (farba.Equals("cervena"))
            {
                return cervena_y[cislo];
            }
            else if (farba.Equals("zelena"))
            {
                return zelena_y[cislo];
            }
            else if (farba.Equals("modra"))
            {
                return modra_y[cislo];
            }
            else if (farba.Equals("zlta"))
            {
                return zlta_y[cislo];
            }


            return '0';
        }


        public int dx(string name, int id)
        {
            if (name.Equals("cervena"))
            {
                return cdx[id - 4];
            }
            else if (name.Equals("zelena"))
            {
                return zedx[id];
            }
            else if (name.Equals("modra"))
            {
                return mdx[id - 8];
            }
            else if (name.Equals("zlta"))
            {
                return zldx[id - 12];
            }

            return '0';
        }

        public int dy(string farba, int id)
        {
            if (farba.Equals("cervena"))
            {
                return cdy[id - 4];
            }
            else if (farba.Equals("zelena"))
            {
                return zedy[id];
            }
            else if (farba.Equals("modra"))
            {
                return mdy[id - 8];
            }
            else if (farba.Equals("zlta"))
            {
                return zldy[id - 12];
            }

            return '0';
        }
    }
}
