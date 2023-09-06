using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class ItemAuthor
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
