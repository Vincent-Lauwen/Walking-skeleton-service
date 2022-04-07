using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingSkeletonService.Models;
using WalkingSkeletonService.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kwetter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetController : ControllerBase
    {
        private ITweetRepo tweetRepo;
        public TweetController(ITweetRepo tweetRepo)
        {
            this.tweetRepo = tweetRepo;
        }

        // GET: api/<TweetController>
        [HttpGet("tweets")]
        public IEnumerable<List<Tweet>> Get()
        {
            yield return tweetRepo.GetAll();
        }
    }
}
