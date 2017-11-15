using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDesignDataDemo.Models;

namespace WpfDesignDataDemo.IServices
{
    public interface ICustomersService
    {
        Customers Get();

        Customer Get(int id);
    }
}
