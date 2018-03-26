//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Diagnostics;

//namespace ECommerce
//{
//    /// <summary>
//    /// Tester class to test the ECommerce application
//    /// </summary>
//    class Tester
//    {
//        /// <summary>
//        /// Main driver method to test
//        /// </summary>
//        static void Main(string[] args)
//        {
//            //Creating items
//            Item item1 = new Item(1, "zohra", 10);
//            Item item2 = new Item(2, "nadaf", 12);
//            ServiceOrderItem sc = new ServiceOrderItem(item1, 2); //creating service type order type
//            MaterialOrderItem mc = new MaterialOrderItem(item1, 1, 15); //creating material type order type
//            IList<OrderItem> orderItems = new List<OrderItem>(); // creating list of orderItems
//            orderItems.Add(sc);
//            orderItems.Add(mc); // adding both the items created to the list or orderItems
//            Order or = new Order(orderItems); // creating the order
//            Debug.WriteLine("Order total " + or.OrderTotal); // calculating the total order of both the items - output: 30 (rounding off to the nearest penny)

//            List<Item> itemList = new List<Item>(); //creating a list of items to sort by name

//            itemList.Add(item1);
//            itemList.Add(item2); // adding both the items to the itemList
//            Order or1 = new Order(itemList); //creating the order
//            foreach (Item it in itemList)
//            {
//                Debug.WriteLine("item  " + it.Name); // sorted list of items on name
//            }
        
//        }
//    }
//}
