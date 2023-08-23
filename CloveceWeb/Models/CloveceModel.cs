using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clovece;
using CloveceWeb.Data;

namespace CloveceWeb.Models
{
    [Serializable]
    public class CloveceModel
    {

        public string Message { get; set; }


        public int Hodnota { get; set; }

        public int Pocet { get; set; }
        public int PocitadloLudi { get; set; }

        public int[,] pole { get; set; }

        public GameData data { get; set; }
}
}
