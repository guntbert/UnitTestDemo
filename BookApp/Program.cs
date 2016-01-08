
namespace BookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Title = "A title";
            b.Author = "Mr. ABC";
            b.Price = 10M;
            b.SaveBook();
        }
    }
}
