using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class BasketManager
    {
        //naming convention
        //syntax
        public void Add(Product product) 
        {
            Console.WriteLine("Tebrikler, Sepete eklendi! : " + product.Name);
        }
        public void Add2(string productName,string discription, int price, int stock)
        {
            Console.WriteLine("Tebrikler, Sepete eklendi! : " + productName);

        }

    }
}
