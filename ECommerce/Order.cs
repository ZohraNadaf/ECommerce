using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    /// <summary>
    /// Represents an Order that contains a collection of items.
    ///
    /// Care should be taken to ensure that this class is immutable
    /// since it is sent to other systems for processing that should
    /// not be able to change it in any way.
    /// </summary>
    class Order
    {
        private IList<OrderItem> orderItems;
        private float orderTotal;
        private List<Item> items;
        /// <summary>
        /// Total order cost after the tax has been applied
        /// </summary>
        public float OrderTotal
        {
            get
            {
                //throw new NotImplementedException();
                foreach (OrderItem item in orderItems)
                {
                    orderTotal += item.CalculateTotal();
                }
                return Convert.ToSingle(Math.Round((double)orderTotal));
            }
        }
        /// <summary>
        /// All items sorted by name (case-insensitive)
        /// </summary>
        public IReadOnlyList<Item> Items
        {
            get
            {
                //throw new NotImplementedException();
                items.Sort(
                    delegate (Item p1, Item p2)
                    {
                        return p1.Name.CompareTo(p2.Name);
                    }
                );

                return items;
            }
        }
        /// <summary>
        /// Constructor, creates an order
        /// </summary>
        /// <param name="orderItems">Array of order items to include in order</param>
        public Order(IList<OrderItem> orderItems)
        {
            this.orderItems = orderItems;
        }

        /// <summary>
        /// Constructor, creates an order
        /// </summary>
        /// <param name="items">Array of items to include in order to sort by name</param>
        public Order(List<Item> items)
        {
            this.items = items;
        }
    }
}