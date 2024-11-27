using CsvHelper;
using Microsoft.Extensions.Logging;
using System.Formats.Asn1;
using System.Globalization;

namespace My_Project
{
    public class DataContext : IDataContext
    {
        public List<Customer> Customers { get ; set; }
        public List<Driver> Drivers { get ; set; }


        public DataContext()
        {

            Customers = new List<Customer>
            {
                new Customer(1,"Sara", "rabi akiva", "bney-brak", "058329005"),
                new Customer(2,"rina", "akiva", "bney-brak", "058329005")
            };

            Drivers = new List<Driver>
            {
                 new Driver(1, "Sara", "beer-sheva"),
                 new Driver(2, "Yael", "tel-aviv")
            };
        }
    }

}
