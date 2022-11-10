using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model
{
    public class Store
    {
        private List<StoreItem> _storeItems = new();
        public IEnumerable<Book> Books { get { return (IEnumerable<Book>)_storeItems; } }
        public void Add(Book book, int quantity)
        {
            _storeItems.Add(new StoreItem { Book = book, Quantity = quantity});
        }

        public int BookCount()
        {
            int count = 0;
            foreach (var book in _storeItems)
            {
                count += book.Quantity;
            }
            return count;
        }
    }
}
