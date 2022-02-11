using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Bibliotek
{
    class Library
    {
        public string Name { get; set; }
        public Library(string aName)
        {
            this.Name = aName;
        }
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Employee> Employees { get; set; } = new List<Employee>();

    }
}
