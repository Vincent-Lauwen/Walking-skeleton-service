using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kwetter.IRepositories;
using Kwetter.Models;

namespace Kwetter.Repositories
{
    public class TweetRepo : ITweetRepo
    {
        public List<Tweet> GetAll()
        {
            List<Tweet> tweets = new List<Tweet>();
            tweets.Add(new Tweet(1 ,"My New Tweet", DateTime.Today, 0));
            tweets.Add(new Tweet(2, "Second Tweet", DateTime.Today, 4));

            return tweets;
        }

        public Tweet GetById(int id)
        {
            List<Tweet> tweets = new List<Tweet>();
            tweets.Add(new Tweet(1, "My New Tweet", DateTime.Today, 0));
            tweets.Add(new Tweet(2, "Second Tweet", DateTime.Today, 4));

            return tweets.Find(tag => tag.Id == id);
        }
    }
}
