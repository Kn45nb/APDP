using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class LibraryCatalog
    {
        private List<Libraryltem> items;

        public LibraryCatalog()
        {
            items = new List<Libraryltem>();
        }

        public void addItem(Libraryltem item)
        {
            items.Add(item);
        }

        public void findItem(string search)
        {
            var foundItems = items.Where(item => item.title.Contains(search, StringComparison.OrdinalIgnoreCase) || item.author.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundItems.Any())
            {
                foreach (var item in foundItems)
                {
                    Console.WriteLine($"Title: {item.title}, Author: {item.author}, Available: {item.available}");
                }
            }
            else
            {
                Console.WriteLine("No items found.");
            }
        }
    }
}