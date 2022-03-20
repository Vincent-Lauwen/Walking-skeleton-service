using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kwetter.Models
{
    public class Tweet
    {
        public int Id { get; private set; }
        public string Content { get; private set; }
        public DateTime PublishDate { get; private set; }
        public int LikeAmount { get; private set; }

        public Tweet(int id, string content, DateTime publishDate, int likeAmount)
        {
            Id = id;
            Content = content;
            PublishDate = publishDate;
            LikeAmount = likeAmount;
        }
    }
}
