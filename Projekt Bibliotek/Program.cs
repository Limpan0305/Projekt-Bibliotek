using System;

namespace Projekt_Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Library Bibliotek = new Library("Gothenburg State Library");

            Customer Customer1 = new Customer("Berit", 80, "Skräck", 1111);
            Customer Customer2 = new Customer("Bengt", 60, "Äventyrsroman", 2222);
            Customer Customer3 = new Customer("Bosse", 70, "Novell", 3333);
            Customer Customer4 = new Customer("Britta", 90, "Religiös", 4444);

            Bibliotek.Customers.Add(Customer1);
            Bibliotek.Customers.Add(Customer2);
            Bibliotek.Customers.Add(Customer3);
            Bibliotek.Customers.Add(Customer4);

            Book Book1 = new Book(1, "Bibeln", 1868, "Religiös", "okänd");
            Book Book2 = new Book(2, "Vita tänder", 476, "Roman", "Zadie Smith");
            Book Book3 = new Book(3, "Främlingen", 114, "Kriminalare", "Albert Kamus");
            Book Book4 = new Book(4, "Röda rummet", 269, "Fiktion", "August Strindberg");

            Bibliotek.Books.Add(Book1);
            Bibliotek.Books.Add(Book2);
            Bibliotek.Books.Add(Book3);
            Bibliotek.Books.Add(Book4);

            Employee Employee1 = new Employee(1, "Anna", 25, 27000, "Cashier");
            Employee Employee2 = new Employee(2, "Anders", 48, 39000, "Boss");
            Employee Employee3 = new Employee(3, "Astrid", 19, 25000, "Cashier");
            Employee Employee4 = new Employee(4, "Angelica", 36, 33000, "Senior Cashier");

            Bibliotek.Employees.Add(Employee1);
            Bibliotek.Employees.Add(Employee2);
            Bibliotek.Employees.Add(Employee3);
            Bibliotek.Employees.Add(Employee4);

            Console.WriteLine(Book1.Pages);
            Console.WriteLine(Customer1.FavouriteGenre); 
            Console.WriteLine(Employee1.Salary);
            Console.WriteLine(Bibliotek.Name);
            Book1.loanedOut(Customer1);
            Employee1.HelpCustomer(Customer1);
            Employee2.raiseSalary(Employee4);

        }
    }
}
