using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCoAuthServer.Core.Models;

namespace UdemyAuthServer.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string UserId { get; set; }

        public bool isOfferable { get; set; }

        public int offerRate { get; set; }
        public int offeredPrice { get; set; }
        public string Brand { get; set; }
        public string ProductColor { get; set; }
        //kullanım durumu
        public string UsageState { get; set; }

        public string Image { get; set; }
       public Category Category { get; set; } 
        public int CategoryId { get; set; }

    }
}
