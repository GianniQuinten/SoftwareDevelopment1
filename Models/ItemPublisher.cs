using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class ItemPublisher
    {
        public int Id { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
