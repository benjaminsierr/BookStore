using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem (Book book, int qty)
        {
            //pull first matching book id
            CartLine line = Lines
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }
        //remove line from cart
        public virtual void RemoveLine(Book book) =>
                Lines.RemoveAll(x => x.Book.BookId == book.BookId);
        //clear cart
        public virtual void Clear() => Lines.Clear();
        //compute cart sum
        public double ComputeTotalSum() => Lines.Sum(e => e.Book.Price * e.Quantity);
        

        //define attributes for Cartline class
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }


        }
    }
}
