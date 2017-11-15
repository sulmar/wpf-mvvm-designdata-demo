using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDesignDataDemo.Models
{
    public class Order : Base
    {
        public int Id { get; set; }

        public Customer Customer { get; set; }
    }
}
