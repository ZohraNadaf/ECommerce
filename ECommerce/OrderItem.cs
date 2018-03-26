using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    /// <summary>
    /// Represents an abstract class OrderItem with an abstract method GetOrderTotal
    /// 
    /// </summary>
    abstract class OrderItem
    {
        protected Item item;
        protected int quantity;

        /// <summary>
        /// Item
        /// </summary>
        public Item Item
        {
            get
            {
                return item;
            }
        }
        /// <summary>
        /// Quantity
        /// </summary>
        public int Quantity
        {
            get
            {
                return quantity;
            }
        }

        /// <summary>
        /// Abstract method to calculate the total
        /// </summary>
        public abstract float CalculateTotal();
    }
}
