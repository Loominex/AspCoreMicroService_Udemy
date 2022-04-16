using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.Api.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();
        public decimal TotalPrice { get {

                decimal totalPrice = 0;
                foreach (var item in Items)
                {
                    totalPrice += item.Price;
                }
                return totalPrice;
            } }
        public ShoppingCart(string userName)
        {
            this.UserName = userName;
        }
    }
}
