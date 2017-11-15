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
    public class CustomerViewModel : BaseViewModel
    {
        public Customer Customer { get; set; }

        private readonly ICustomersService customersService;

        public CustomerViewModel()
                : this(new DbCustomersService())
        {
        }

        public CustomerViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;

            Load();
        }

        private void Load()
        {
            Customer = customersService.Get(1);
        }
    }
}
