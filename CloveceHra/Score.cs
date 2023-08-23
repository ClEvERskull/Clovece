using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clovece
{
    [Serializable]
    public class Score
    {
        public int Id { get; set; }

        public string Player { get; set; }

        public int Points { get; set; }
    }
}

