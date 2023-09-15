﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Lastname { get; set; }

        public ICollection<ItemAuthor> ItemAuthors { get; set; }

    }
}
