using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mrsProject.Models
{

    public class Genre
    { 
        public Int32 GenreID { get; set; }

        public string GenreName { get; set; }

        public List<Book> Books { get; set; }
    
    }
}