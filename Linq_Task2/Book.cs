using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Task2
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public int AuthorId { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} title:{Title} Pages:{Pages} Author: {AuthorId}";
        }
    }
}
