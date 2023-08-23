using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clovece;

namespace Clovece.Service
{
    public interface IScoreService
    {
        void AddScore(Score score);

        IList<Score> GetTopScores();

        void ClearScores();
    }
}

