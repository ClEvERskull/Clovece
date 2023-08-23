using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloveceWeb.Data
{
    [Serializable]
    public class GameData
    {

        public string[] farbaHraca { get; set; }

        public string[] Farba { get; set; }

        public int[] Hrac_x { get; set; }
        public int[] Hrac_y { get; set; }

        public int[] Pozicia { get; set; }

    }
}
