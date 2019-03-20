using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alarmClock
{
    //事件发送者
    class TimeEvent
    {
        //声明事件委托
        public delegate void AlarmEventHandler(Object sender, EventArgs e);
        //声明事件
        public event AlarmEventHandler Alarm;
        //引发事件函数
        public void OnAlarm()
        {
            if (this.Alarm != null)
            {
                Console.WriteLine("10s过去啦");
                this.Alarm(this, new EventArgs()); //闹钟响起
            }
        }
    }

    //事件接收者
    class Host
    {
        //事件处理程序
        void HostHandleAlarm(object sender, EventArgs e)
        {
            Console.WriteLine("闹钟响起");
        }
        //注册事件处理程序
        public Host(TimeEvent timeEvent)
        {
            timeEvent.Alarm += new TimeEvent.AlarmEventHandler(HostHandleAlarm);
        }
    }

    //触发事件
    class Program
    {
        static void Main(string[] args)
        {
            TimeEvent timeEvent = new TimeEvent();
            Host host = new Host(timeEvent);

            //获取当前电脑时间
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            //10s后闹钟响起
            DateTime Alarmtime = currentTime.AddSeconds(10);

            while (currentTime < Alarmtime)
            {
                Console.WriteLine("当前时间：" + currentTime);
                System.Threading.Thread.Sleep(1000);
                currentTime = currentTime.AddSeconds(1);
            }

            timeEvent.OnAlarm();
            Console.ReadLine();
        }
    }
}
