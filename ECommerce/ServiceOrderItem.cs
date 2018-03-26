using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    /// <summary>
    /// Sub Class Service Order type extends the abstract base class OrderItem
    /// </summary>
    class ServiceOrderItem : OrderItem
    {
        /// <summary>
        /// Method to calculate the total for service type order item
        /// </summary>
        public override float CalculateTotal()
        {
            return (item.Price * Quantity);
        }

        /// <summary>
        /// Constructor, creates a service type order item
        /// </summary>
        /// <param name="item">Item</param>
        /// <param name="quantity">Quantity of the item</param>
        public ServiceOrderItem(Item item, int quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }
    }
}
