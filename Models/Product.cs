using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image{ get; set; }
        public int Price { get; set; }
        public int Availability { get; set; } = 1;

        public Product(int id, string name, string description, string image, int price, int availability)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Price = price;
            Availability = availability;
        }
        public Product()
        {

        }
    }
}
