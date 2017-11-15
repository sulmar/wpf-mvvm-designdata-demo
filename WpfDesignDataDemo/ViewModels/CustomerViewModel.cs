using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDesignDataDemo.Models;

namespace WpfDesignDataDemo.ViewModels
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }

        public CustomerViewModel()
        {
            Customer = new Customer { Id = 1, FirstName = "John", LastName = "Smith" };
        }
    }
}
