using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryCatalog catalog = new LibraryCatalog();

            Book book1 = new Book("Getting rich is not difficult!(Làm giàu không khó!)", "Nguyen Hieu Kien", 2024 , true, "Fiction");
            DVD dvd1 = new DVD("Vlog: A normal day of a dev (Vlog: Một ngày bình thường của dev)", "Kn45nb (Kiên)", 2023, true, 999);

            catalog.addItem(book1);
            catalog.addItem(dvd1);

            Console.WriteLine("Library Catalog:");
            catalog.findItem("");

            Console.WriteLine("\nChecking out 'The Great Gatsby':");
            book1.checkout();

            Console.WriteLine("\nLibrary Catalog:");
            catalog.findItem("");

            Console.WriteLine("\nReturning 'The Great Gatsby':");
            book1.returnItem();

            Console.WriteLine("\nLibrary Catalog:");
            catalog.findItem("");
        }
    }
}
