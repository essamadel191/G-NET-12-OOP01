using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary
{
    public class Books
    {
        public string? BookName { get; set; }
        public string? Author { get; set; }

        public override string ToString()
        {
            return $"Book Name: {BookName}, Author: {Author}";
        }
    }
}
