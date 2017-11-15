using System;
using System.Text;
using System.Threading.Tasks;

namespace WpfDesignDataDemo.Models
{
    public class Order : Base
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public Customer Customer { get; set; }

        public OrderDetails OrderDetails { get; set; }

        public decimal TotalAmount => OrderDetails.TotalAmount;
    }
}
