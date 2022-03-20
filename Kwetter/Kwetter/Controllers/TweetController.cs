using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kwetter.Models;
using Kwetter.IRepositories;

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
        [HttpGet]
        public IEnumerable<List<Tweet>> Get()
        {
            yield return tweetRepo.GetAll();
        }

        // GET api/<TweetController>/5
        [HttpGet("{id}")]
        public IEnumerable<Tweet> Get(int id)
        {
            yield return tweetRepo.GetById(id);
        }

        // POST api/<TweetController>
        [HttpPost]
        public void Post([FromBody] Tweet value)
        {
        }

        // PUT api/<TweetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Tweet value)
        {
        }

        // DELETE api/<TweetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
