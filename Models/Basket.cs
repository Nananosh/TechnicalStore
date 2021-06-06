using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalStore.Models
{
    public class Basket
    {
        public int Profile_Id { get; set; }
        public int Product_Id { get; set; }
        public Basket( int prof, int prod)
        {
            Profile_Id = prof;
            Product_Id = prod;

        }
        public Basket()
        {

        }
        
    }
}
