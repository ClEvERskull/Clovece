using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clovece
{
    public class Kocka
    {
        private int steny;
        private Random random;


        //Zadefinujeme si kocku
        public Kocka()
        {
            steny = 6;
            random = new Random();
        }


        //Poziadame o nahodne cislo
        public int hod()
        {
            return random.Next(1, steny + 1);
        }
    }
}
