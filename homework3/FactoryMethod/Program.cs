using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorymethod
{
    public abstract class AuthCar
    {
        /// 输出制造了什么汽车
        public abstract void CreatorCar();
    }

    /// 派生类-橘黄色轿车
    public class _OriangeCar : AuthCar
    {
        public override void CreatorCar()
        {
            Console.WriteLine("生产了橘黄色轿车!");
        }
    }

    /// 派生类-黑色轿车
    public class _BlackCar : AuthCar
    {
        public override void CreatorCar()
        {
            Console.WriteLine("生产了黑色轿车");
        }
    }

    /// 工厂类
    public abstract class FactoryCreator
    {
        /// 获取汽车对象
        public abstract AuthCar _AuthCar();
    }

    /// 得到黑色汽车实例
    public class BlackCarFactoryMethod : FactoryCreator
    {
        public override AuthCar _AuthCar()
        {
            return new _BlackCar();
        }
    }

    /// 得到橘黄色汽车实例
    public class OriangeFactoryMethod : FactoryCreator
    {
        public override AuthCar _AuthCar()
        {
            return new _OriangeCar();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FactoryCreator BlackCarfactoryCreator = new BlackCarFactoryMethod();
            BlackCarfactoryCreator._AuthCar().CreatorCar();
            FactoryCreator OriangefactoryCreator = new OriangeFactoryMethod();
            OriangefactoryCreator._AuthCar().CreatorCar();

            Console.ReadKey();
        }
    }
}
