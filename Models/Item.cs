using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<ItemAuthor> ItemAuthors { get; set; }
        public ICollection<ItemPublisher> ItemPublishers { get; set; }
        public ICollection<ItemGenre> ItemGenres { get; set; }
    }
}
