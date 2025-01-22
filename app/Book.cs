using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class Book : Libraryltem
    {
        public string genre { get; set; }

        public Book(string title, string author, int publication_date, bool available, string genre)
            : base(title, author, publication_date, available)
        {
            this.genre = genre;
        }

        public override void checkout()
        {
            if (available)
            {
                available = false;
                Console.WriteLine($"{title} has been checked out.");
            }
            else
            {
                Console.WriteLine($"{title} is not available.");
            }
        }

        public override void returnItem()
        {
            available = true;
            Console.WriteLine($"{title} has been returned.");
        }
    }
}