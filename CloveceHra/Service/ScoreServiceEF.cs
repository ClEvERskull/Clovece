using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clovece;

namespace Clovece.Service
{
    public class ScoreServiceEF : IScoreService
    {
        public void AddScore(Score score)
        {
            using (var context = new CloveceDbContext())
            {
                context.Scores.Add(score);
                context.SaveChanges();
            }
        }

        public IList<Score> GetTopScores()
        {
            using (var context = new CloveceDbContext())
            {
                return (from s in context.Scores
                        orderby s.Points
                            descending
                        select s).Take(5).ToList();
            }
        }

        public void ClearScores()
        {
            using (var context = new CloveceDbContext())
            {
                context.Database.ExecuteSqlRaw("DELETE FROM Scores");
            }
        }
    }
}

