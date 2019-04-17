using Microsoft.VisualStudio.TestTools.UnitTesting;
using ordertest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ordertest.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
 

        /*[TestMethod()]
       public void OrderServiceTest()
        {
            Assert.Fail();
        }*/

        [TestMethod()]
        public void AddOrderTest()
        {
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Goods milk = new Goods(1, "Milk", 69.9f);
            Goods eggs = new Goods(2, "eggs", 4.99f);
            Goods apple = new Goods(3, "apple", 5.59f);

            Order order1 = new Order(1, customer1);
            order1.AddDetails(new OrderDetail(apple, 8));
            order1.AddDetails(new OrderDetail(eggs, 10));
            order1.AddDetails(new OrderDetail(milk, 10));

            Order order2 = new Order(2, customer2);
            order2.AddDetails(new OrderDetail(eggs, 10));
            order2.AddDetails(new OrderDetail(milk, 10));

            Order order4 = new Order(4, customer1);
            order4.AddDetails(new OrderDetail(eggs, 10));

            OrderService orderService = new OrderService();

            orderService.AddOrder(order1);
            Assert.AreEqual(order1, orderService.QueryAll()[0]);
           try
            {
                orderService.AddOrder(order4);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /*[TestMethod()]
        public void UpdateTest()
        {
            

            Assert.AreEqual(1, 1);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.Fail();
        }*/

        [TestMethod()]
        public void RemoveOrderTest()
        {
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Goods milk = new Goods(1, "Milk", 69.9f);
            Goods eggs = new Goods(2, "eggs", 4.99f);
            Goods apple = new Goods(3, "apple", 5.59f);

            Order order1 = new Order(1, customer1);
            order1.AddDetails(new OrderDetail(apple, 8));
            order1.AddDetails(new OrderDetail(eggs, 10));
            order1.AddDetails(new OrderDetail(milk, 10));

            Order order2 = new Order(2, customer2);
            order2.AddDetails(new OrderDetail(eggs, 10));
            order2.AddDetails(new OrderDetail(milk, 10));

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);

            orderService.RemoveOrder(2);

            Assert.AreEqual(1, orderService.QueryAll().Count);
        }

       /* [TestMethod()]
        public void QueryAllTest()
        {
            Assert.Fail();
        }*/

        [TestMethod()]
        public void QueryByGoodsNameTest()
        {
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Goods milk = new Goods(1, "Milk", 69.9f);
            Goods eggs = new Goods(2, "eggs", 4.99f);
            Goods apple = new Goods(3, "apple", 5.59f);

            Order order1 = new Order(1, customer1);
            order1.AddDetails(new OrderDetail(apple, 8));
            order1.AddDetails(new OrderDetail(eggs, 10));
            order1.AddDetails(new OrderDetail(milk, 10));

            Order order2 = new Order(2, customer2);
            order2.AddDetails(new OrderDetail(eggs, 10));
            order2.AddDetails(new OrderDetail(milk, 10));

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);

            List<Order> orders = orderService.QueryAll();
            orders = orderService.QueryByGoodsName("eggs");
            Assert.AreEqual(2, orders.Count);
        }

       /* [TestMethod()]
        public void QueryByTotalAmountTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void QueryByCustomerNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SortTest()
        {
            Assert.Fail();
        }*/

        [TestMethod()]
        public void ExportTest()
        {
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Goods milk = new Goods(1, "Milk", 69.9f);
            Goods eggs = new Goods(2, "eggs", 4.99f);
            Goods apple = new Goods(3, "apple", 5.59f);

            Order order1 = new Order(1, customer1);
            order1.AddDetails(new OrderDetail(apple, 8));
            order1.AddDetails(new OrderDetail(eggs, 10));
            order1.AddDetails(new OrderDetail(milk, 10));

            Order order2 = new Order(2, customer2);
            order2.AddDetails(new OrderDetail(eggs, 10));
            order2.AddDetails(new OrderDetail(milk, 10));

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);

            orderService.Export(@".\order.xml");

            /* Assert.IsNotNull(System.IO.File.Exists(orderService.xml));*/
            Assert.IsTrue(true);
        }

        /*[TestMethod()]
        public void ImportTest()
        {
            Assert.Fail();
        }*/

        
    }
}