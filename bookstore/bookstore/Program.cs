using bookstore.Books;
using bookstore.Inventorys;
namespace bookstore
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            var inventory = new Inventory();
            try
            {
                var b1 = new PaperBook("id1", "Book1", 2019, 75d, 15, true);
                var b2 = new Ebook("id2", "Book2", 2005, 33, "pdf");
                var b3 = new PaperBook("id3", "Book3", 1970, 83, 2, true);
                var b4 = new Demo("id4", "Book1", 2019);
                inventory.Add(b1);
                inventory.Add(b2);
                inventory.Add(b3);
                inventory.Add(b4);
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Removing Outdated Books from 20 years or more");
                var outdated_books = inventory.Remove(20);
                Console.WriteLine("\nOutdated Books");
                Console.WriteLine("-------------------");
                foreach (var b in outdated_books)
                {
                    Console.WriteLine(b);
                }
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Purchasing Book1, available stock: {b1.Stock}, required quantity: 4");
                inventory.Buy("id1", 4, "abdulrahman@gmail.com", "4ali - giza");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Purchasing Book2, already removed because it's outdated.");
                inventory.Buy("id2", 4, "abdulrahman@gmail.com", "4ali - giza");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Purchasing Book4, it's a demo, not for sale.");
                inventory.Buy("id4", 4, "abdulrahman@gmail.com", "4ali - giza");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Purchasing Book1, available stock: {b1.Stock}, required quantity: 12");
                inventory.Buy("id1", 12, "abdulrahman@gmail.com", "4ali - giza");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
