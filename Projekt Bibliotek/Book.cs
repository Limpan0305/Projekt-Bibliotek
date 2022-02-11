using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Bibliotek
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }
        public string Writer { get; set; }

        public Book(int aId, string aName, int aPages, string aGenre, string aWriter)
        {
            this.Id = aId;
            this.Name = aName;
            this.Pages = aPages;
            this.Genre = aGenre;
            this.Writer = aWriter;
        }

        public void loanedOut(Customer CustomerObj)
        {
            CustomerObj.loanBook(this);
        }
    }
}
