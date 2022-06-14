using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreCartWinForms.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quanity { get; set; }
        public decimal Price { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
    }
}
