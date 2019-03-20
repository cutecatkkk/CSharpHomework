using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    class OrderService
    {
        private static List<Order> OrderList = new List<Order>();
        static void Main(string[] args)
        {


            int choice = 0;//记录用户指令
            int ordercount = 0;//记录订单编号

            while (choice != 6)
            {
                Console.Clear();
                Console.WriteLine("1.添加订单  2.查询订单  3.删除订单 4.修改订单 5.显示当前已有订单 6.退出操作");
                Console.WriteLine("请选择要进行的操作：");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        AddOrder(ordercount++);
                        break;

                    case 2:
                        SearchOrder();
                        break;

                    case 3:
                        DeleteOrder();
                        break;

                    case 4:
                        Revise();
                        break;

                    case 5:
                        foreach (Order temp in OrderList) // 遍历订单
                        {
                            temp.Printinf();
                        }
                        Console.ReadLine();
                        break;



                    default:
                        Console.WriteLine("请按指示进行输入:");
                        Console.ReadLine();
                        break;


                }


            }



        }

        //添加订单
        public static void AddOrder(int count)
        {

            //string name; string need;
            string name; string product;
            Console.WriteLine("请输入顾客名，商品名:");
            Console.Write("顾客名:"); name = Console.ReadLine();
            Console.Write("商品名:"); product = Console.ReadLine();
            Order temp = new Order(count, name, product);

            Console.WriteLine("请确定物品数量:");
            int goodnum; int.TryParse((Console.ReadLine()), out goodnum);
            while ((goodnum--) > 0)
            {

                temp.AddGoods();
            }
            OrderList.Add(temp);

        }

        //查询订单
        public static void SearchOrder()
        {

            Console.WriteLine("1.订单编号查询 2.商品名查询 3.顾客名查询\n" + "请选择查询方式:");
            string TempInput;//记录顾客输入
            int TempNum;
            int.TryParse((Console.ReadLine()), out TempNum);

            switch (TempNum)
            {
                case 1:
                    Console.WriteLine("订单编号:");
                    TempInput = Console.ReadLine();
                    int num; int.TryParse(TempInput, out num);//读取订单编号

                    int tempnum; bool numhas = false;
                    for (int i = OrderList.Count - 1; i >= 0; i--)
                    {
                        tempnum = OrderList[i].backnum();
                        if (tempnum == num)         //订单编号匹配
                        {
                            OrderList[i].Printinf(); OrderList[i].PrintGoods();
                            numhas = true; break;
                        }//打印信息

                    }
                    if (numhas == false) Console.WriteLine("没有该编号订单！");
                    break;

                case 2:
                    Console.WriteLine("商品名:");
                    TempInput = Console.ReadLine();//读取订单编号

                    string temproduct; bool producthas = false;
                    for (int i = OrderList.Count - 1; i >= 0; i--)
                    {
                        temproduct = OrderList[i].backproduct();
                        if (temproduct == TempInput)//订单编号匹配
                        {
                            OrderList[i].Printinf(); OrderList[i].PrintGoods();
                            producthas = true; break;
                        }//打印信息

                    }
                    if (producthas == false) Console.WriteLine("没有该商品名订单！");
                    break;

                case 3:
                    Console.WriteLine("顾客名:");
                    TempInput = Console.ReadLine();//读取订单编号

                    string tempcustomer; bool namehas = false;
                    for (int i = OrderList.Count - 1; i >= 0; i--)
                    {
                        tempcustomer = OrderList[i].backcustomer();
                        if (tempcustomer == TempInput)//订单编号匹配
                        {
                            OrderList[i].Printinf(); OrderList[i].PrintGoods();
                            namehas = true; break;
                        }//打印信息
                    }
                    if (namehas == false) Console.WriteLine("没有该顾客订单！");
                    break;

                default:
                    Console.WriteLine("错误输入");

                    break;
            }
            Console.ReadLine();
        }

        //删除订单
        public static void DeleteOrder()
        {
            Console.WriteLine("请输入待删除订单编号:");
            int count;//记录待删除的订单号
            int.TryParse(Console.ReadLine(), out count);
            int tempnum;//存储每个订单的编号
            bool has = false;
            for (int i = OrderList.Count - 1; i >= 0; i--)
            {
                tempnum = OrderList[i].backnum();
                if (tempnum == count)
                { OrderList.Remove(OrderList[i]); has = true; break; }
            }
            if (has == false) Console.WriteLine("没有该编号订单！");

        }

        //修改订单
        public static void Revise()
        {
            Console.WriteLine("请输入订单编号:");
            int num; int.TryParse((Console.ReadLine()), out num);

            int tempnum; bool has = false; int index = 0;
            for (int i = OrderList.Count - 1; i >= 0; i--)
            {
                tempnum = OrderList[i].backnum();
                if (tempnum == num)//订单编号匹配
                { index = i; has = true; break; }//匹配下标
            }
            if (has == false) Console.WriteLine("没有该编号订单！");
            else
            {
                OrderList[index].Printinf(); OrderList[index].PrintGoods();

                int choice = 0;
                while (choice != 4)
                {
                    Console.WriteLine("1.添加物品 2.删除物品 3.修改数量 4.退出修改");
                    int.TryParse((Console.ReadLine()), out choice);

                    switch (choice)
                    {
                        case 1:
                            OrderList[index].AddGoods();
                            break;
                        case 2:
                            OrderList[index].DeleteGoods();
                            break;
                        case 3:
                            OrderList[index].RemoveGoods();
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("请输入正确指令！");
                            break;

                    }
                }
            }


        }

    }

    internal class Order
    {
    }
}
