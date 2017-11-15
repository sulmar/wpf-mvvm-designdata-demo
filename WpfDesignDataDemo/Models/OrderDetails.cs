using System.Collections.Generic;
using System.Linq;

namespace WpfDesignDataDemo.Models
{
    public class OrderDetails : List<OrderDetail>
    {
        public decimal TotalAmount => this.Sum(od => od.Amount);
    }
}
