using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*单例模式确保一个类只有一个实例,并提供一个全局访问点*/

namespace Singleton
{
    public class Singleton
    {
        //为了运行效率采用懒汉模式
        private static Singleton uniqueinstance;
        //为了实现多线程下的线程安全，使用互斥锁
        private static readonly object locker = new object();
        private Singleton()
        { }

        public static Singleton creatinstance()
        {
            //使用双重检测同步延迟加载去创建单例
            if (uniqueinstance == null)
            {
                lock (locker)
                {
                    if (uniqueinstance == null)
                    {
                        uniqueinstance = new Singleton();
                    }
                }
            }
            return uniqueinstance;
        }

        public void write()
        {
            Console.WriteLine("hello");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singleton a = Singleton.creatinstance();
            a.write();
            //创建b的时候因为uniqueinstance不为空，所以跳过了实例creatinstance，返回了和a一样的creatinstance
            Singleton b = Singleton.creatinstance();
            b.write();
            Console.ReadKey();
        }
    }
}
