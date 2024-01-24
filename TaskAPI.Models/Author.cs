using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public required string AuthorName { get; set; } 
        public string AddressNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public ICollection<Todo> Todos { get; set; } = new List<Todo>();
    }
}
