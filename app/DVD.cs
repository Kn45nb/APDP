using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class DVD : Libraryltem
    {
        public int runtime { get; set; }

        public DVD(string title, string author, int publication_date, bool available, int runtime)
            : base(title, author, publication_date, available)
        {
            this.runtime = runtime;
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