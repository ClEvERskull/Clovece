using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clovece;
using Clovece.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CloveceWeb.APIControllers
{
    [Produces("application/json")]
    [Route("api/Score")]
    public class ScoreController : Controller
    {
        private IScoreService scoreService = new ScoreServiceEF();

        // GET: api/Score
        [HttpGet]
        public IEnumerable<Score> Get()
        {
            return scoreService.GetTopScores();
        }

        // POST: api/Score
        [HttpPost]
        public void Post([FromBody]Score score)
        {
            scoreService.AddScore(score);
        }
    }

}