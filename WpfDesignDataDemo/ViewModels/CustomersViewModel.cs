using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDesignDataDemo.DbServices;
using WpfDesignDataDemo.IServices;
using WpfDesignDataDemo.Models;

namespace WpfDesignDataDemo.ViewModels
{
    public class CustomersViewModel : BaseViewModel
    {
        public Customers Customers { get; set; }

        private readonly ICustomersService customersService;

        public CustomersViewModel()
            : this(new DbCustomersService())
        {

        }

        public CustomersViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;

            Load();
        }

        private void Load()
        {
            Customers = customersService.Get();
        }
    }
}
