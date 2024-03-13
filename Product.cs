using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StroyModern
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public string Article { get; set; }
        public int Quantity { get; set; }
        public int Type { get; set; }

        public Product() { }

        public Product(int id, string title, decimal cost, string article, int quantity, int type)
        {
            Id = id;
            Title = title;
            Cost = cost;
            Article = article;
            Quantity = quantity;
            Type = type;
        }
    }
}
