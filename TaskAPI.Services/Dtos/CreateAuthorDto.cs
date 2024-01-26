﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Dtos
{
    public class CreateAuthorDto
    {
        public required string AuthorName { get; set; }
        public string AddressNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string JobRole { get; set; }
        public ICollection<CreateTodoDto> Todos { get; set; } = new List<CreateTodoDto>();
    }
}
