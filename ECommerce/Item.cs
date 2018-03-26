using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    /// <summary>
    /// Represents a part or service that can be sold.
    ///
    /// Care should be taken to ensure that this class is immutable
    /// since it is sent to other systems for processing that should
    /// not be able to change it in any way.
    /// </summary>
    class Item
    {
        /// <summary>
        /// Key
        /// </summary>
        public int Key { get; private set; }
        /// <summary>
        /// Name of the item
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Price for the item
        /// </summary>
        public float Price { get; private set; }
        /// <summary>
        /// Constructor, creates an item
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="name">Name of item</param>
        /// <param name="price">Price</param>
        public Item(int key, string name, float price)
        {
            Key = key;
            Name = name;
            Price = price;
        }
    }
}
