using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public class AuthorDBService : IAuthorRepository
    {
        private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();

        public List<Author> AllAuthors()
        {
            return _dbContext.Authors.ToList();
        }

        public Author GetAuthorById(int id)
        {
            return _dbContext.Authors.Find(id);
        }

    }
}
