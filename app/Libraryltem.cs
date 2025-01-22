using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public abstract class Libraryltem
    {
        public string title { get; set; }
        public string author { get; set; }
        public int publication_date { get; set; }
        public bool available { get; set; }

        public Libraryltem(string title, string author, int publication_date, bool available)
        {
            this.title = title;
            this.author = author;
            this.publication_date = publication_date;
            this.available = available;
        }

        public abstract void checkout();
        public abstract void returnItem();
    }
}