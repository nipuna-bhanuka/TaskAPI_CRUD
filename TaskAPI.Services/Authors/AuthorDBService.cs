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

        public List<Author> AllAuthors(string job, string search )
        {
            if(string.IsNullOrWhiteSpace(job) && string.IsNullOrEmpty(search))
            {
                return AllAuthors();
            }

            var authorCollection = _dbContext.Authors as IQueryable<Author>;

            if (!string.IsNullOrWhiteSpace(job))
            {
                job = job.Trim();
                authorCollection = authorCollection.Where(j => j.JobRole == job);
            }

            if (!string.IsNullOrEmpty(search))
            {
                search = search.Trim();
                authorCollection = authorCollection.Where(s =>
                        s.AuthorName.Contains(search) || s.City.Contains(search)
                        );
            }

            return authorCollection.ToList();
        }

        public Author GetAuthorById(int id)
        {
            return _dbContext.Authors.Find(id);
        }

    }
}
