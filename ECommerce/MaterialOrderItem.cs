using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    /// <summary>
    /// Sub Class Material Order type extends the abstract base class OrderItem
    /// </summary>
    class MaterialOrderItem : OrderItem
    {
        private float tax;
        /// <summary>
        /// Tax
        /// </summary>
        public float Tax
        {
            get
            {
                return tax;
            }
        }

        /// <summary>
        /// Method to calculate the total for material type order item
        /// </summary>
        public override float CalculateTotal()
        {
            return (item.Price * Quantity) + (Tax/100);
        }

        /// <summary>
        /// Constructor, creates a material order item
        /// </summary>
        /// <param name="item">Item</param>
        /// <param name="quantity">Quantity of the item</param>
        /// <param name="tax">Tax applied on the item in (%)</param>
        public MaterialOrderItem(Item item, int quantity, float tax)
        {
            this.item = item;
            this.quantity = quantity;
            this.tax = tax;
        }

    }
}
