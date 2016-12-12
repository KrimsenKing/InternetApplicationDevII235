using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class Categories
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public Categories() { }

        public Categories(int id, string name, int position)
        {
            Id = id;
            Name = name;
            Position = position;
        }
    }
}
