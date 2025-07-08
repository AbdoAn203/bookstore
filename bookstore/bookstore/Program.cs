using bookstore.Books;

namespace bookstore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var b1 = new PaperBook("id1334", "Book1", 2019, 75d, 15, true);
                Console.WriteLine(b1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
