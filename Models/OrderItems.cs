using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_Lab5.Models
{
    public class OrderItems
    {
        public int orderID { get; set; }

        public string productName { get; set; }

        public DateTime dateOrderPlaced { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("Customer")]
        public int CustomerFK { get; set; }
    }
}
