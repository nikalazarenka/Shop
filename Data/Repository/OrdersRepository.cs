using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly ShopCart shopCart;
        private readonly AppDbContext appDbContext;
        public OrdersRepository(AppDbContext appDbContext, ShopCart shopCart)
        {
            this.appDbContext = appDbContext;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDbContext.Order.Add(order);
            appDbContext.SaveChanges();

            var items = shopCart.listShopItems;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    ClothesId = el.Clothes.Id,
                    OrderId = order.Id,
                    Price = el.Clothes.Price
                };

                appDbContext.OrderDetail.Add(orderDetail);
            }

            appDbContext.SaveChanges();
        }
    }
}
