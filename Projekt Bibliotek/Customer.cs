using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Bibliotek
{
    class Customer
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string FavouriteGenre { get; set; }

        public int LoanID { get; set; }

        public Customer(string aName, int aAge, string aFavouriteGenre, int aloanID)
        {
            this.Name = aName;
            this.Age = aAge;
            this.FavouriteGenre = aFavouriteGenre;
            this.LoanID = aloanID;
        }

        public void loanBook(Book BookObj)
        {
            Console.WriteLine($"{this.Name} har lånat {BookObj.Name} och deras låne id är {this.LoanID}");
        }

        public void getsHelp(Employee employeeObj)
        {
            Console.WriteLine($"{this.Name} har frågat {employeeObj.Name} om hjälp att hitta en bok från {this.FavouriteGenre} genren");
        }
    }
}
