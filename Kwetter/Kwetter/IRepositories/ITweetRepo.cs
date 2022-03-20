using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kwetter.Models;

namespace Kwetter.IRepositories
{
    public interface ITweetRepo
    {
        List<Tweet> GetAll();
        Tweet GetById(int id);
    }
}
