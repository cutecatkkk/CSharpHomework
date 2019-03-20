using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_manage
{

    class OrderDetail
    {
        public class GoodOrder
        {
            private string name;
            private string price;
            private int num;

            public GoodOrder(string name, string price, int num)
            {
                this.name = name;
                this.price = price;
                this.num = num;
            }
            public string Backname()
            {
                return name;
            }
            public string Backprice()
            {
                return price;
            }
            public int Backnum()
            {
                return num;
            }
        }
        public List<GoodOrder> GoodList = new List<GoodOrder>();
        public void Print()
        {
            string name, price; int num;
            foreach (GoodOrder temp in GoodList)

            {
                name = temp.Backname(); price = temp.Backprice(); num = temp.Backnum();
                Console.WriteLine(name + "\t" + price + "\t" + num);
            }
        }

    }
}