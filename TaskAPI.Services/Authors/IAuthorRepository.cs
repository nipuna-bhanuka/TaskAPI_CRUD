﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public interface IAuthorRepository
    {
        public List<Author> AllAuthors();
        public List<Author> AllAuthors(string job, string search);
        public Author GetAuthorById(int id);
        public Author AddAuthor(Author author);
        public void UpdateAuthor(Author author);
        public void DeleteAuthor(Author author);
    }
}
