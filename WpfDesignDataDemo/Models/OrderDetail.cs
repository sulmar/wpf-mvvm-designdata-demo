using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDesignDataDemo.Models
{
    public class OrderDetail : Base
    {
        public int Id { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Amount => Quantity * UnitPrice;

    }


}
