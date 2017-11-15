using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDesignDataDemo.IServices;
using WpfDesignDataDemo.Models;

namespace WpfDesignDataDemo.DbServices
{
    public class DbCustomersService : ICustomersService
    {
        private readonly Customers customers;

        public DbCustomersService()
        {
            customers = new Customers
            {
                new Customer { Id = 1, FirstName = "John", LastName = "Smith" },
                new Customer { Id = 2, FirstName = "Ann", LastName = "Smith" },
                new Customer { Id = 3, FirstName = "David", LastName = "Smith" },
            };
        }

        public Customers Get() => customers;

        public Customer Get(int id) => customers.SingleOrDefault(c => c.Id == id);
    }
}
