using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order_manage;

namespace Order_manage
{
    class Order
    {
        private int num;
        private string customer;
        private string product;
        private OrderDetail Detail = new OrderDetail();

        public Order(int num, string customer, string product)
        {
            this.num = num;
            this.customer = customer;
            this.product = product;
        }

        //打印订单基本信息
        public void Printinf()
        {
            Console.WriteLine("订单号:" + num);
            Console.WriteLine("顾客名:" + customer);
            Console.WriteLine("商品名:" + product);
        }

        //返回订单基本信息
        public int backnum()
        {
            return num;
        }
        public string backcustomer()
        {
            return customer;
        }

        public string backproduct()
        {
            return product;
        }

        //打印订单详细信息
        public void PrintGoods()
        {
            Console.WriteLine("商品名\t价格\t数量");
            Detail.Print();
        }

        //添加物品
        public void AddGoods()
        {
            string goods; string price; int num;
            Random rd = new Random();
            price = rd.Next(1, 100).ToString();
            Console.WriteLine("请输入物品名，数量:");
            Console.Write("物品名:"); goods = Console.ReadLine();
            Console.Write("数量:"); int.TryParse((Console.ReadLine()), out num);
            OrderDetail.GoodOrder tempgood = new OrderDetail.GoodOrder(goods, price, num);
            Detail.GoodList.Add(tempgood);
        }
        //删除物品
        public void DeleteGoods()
        {
            //OrderDetail.GoodOrder tempgood = new OrderDetail.GoodOrder(goods, num);
            string gooddelete;
            string tempgood; bool has = false;
            Console.WriteLine("请输入物品名:");
            Console.Write("物品名:"); gooddelete = Console.ReadLine();

            for (int i = Detail.GoodList.Count - 1; i >= 0; i--)
            {
                tempgood = Detail.GoodList[i].Backname();
                if (tempgood == gooddelete)//物品名匹配
                { Detail.GoodList.Remove(Detail.GoodList[i]); has = true; }//删除物品

            }
            if (has == false) Console.WriteLine("订单内没有该物品！");
        }
        //修改物品订购
        public void RemoveGoods()
        {
            string goodremove; int num;
            Console.WriteLine("请输入物品名，修改数量:");
            Console.Write("商品名:"); goodremove = Console.ReadLine();
            Console.Write("数量:"); int.TryParse((Console.ReadLine()), out num);

            string goodname; bool has = false;
            for (int i = Detail.GoodList.Count - 1; i >= 0; i--)
            {
                goodname = Detail.GoodList[i].Backname();
                if (goodname == goodremove)//物品名匹配
                {
                    string price = Detail.GoodList[i].Backprice();
                    OrderDetail.GoodOrder tempgood = new OrderDetail.GoodOrder(goodremove, price, num);
                    Detail.GoodList[i] = tempgood; has = true;
                }//修改物品

            }
            if (has == false) Console.WriteLine("订单内没有该物品！");
        }

    }
}

