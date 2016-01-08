using System;

namespace BookApp
{
    public class Book
    {
        public string Title { get; set; }
        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public decimal Price { get; set; }

        public void UpdatePriceByPercent(decimal percentChange)
        {
            Price = Price*percentChange;
        }

        public void SaveBook()
        {
            //verify that price is within our bound
            if (Price < 0M)
            {
                throw new ArgumentOutOfRangeException("Negative number not allowed");
            }
            if (Price > 90M)
            {
                throw new ArgumentOutOfRangeException("Negative number not allowed");
            }
        }
    }
}
