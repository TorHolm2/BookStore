using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model
{
    public class Book
    {
        public Book(string Title, string Author, string ISBN, int Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
            this.Price = Price;
        }

        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }

        [Range(0,9999, ErrorMessage = "Price is wrong")]
        public int Price { get; }
    }
}
