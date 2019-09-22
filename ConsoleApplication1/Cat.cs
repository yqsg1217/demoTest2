using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Cats
    {
        public delegate void CustomerEventHandler(object sender, EventArgs e);//声明一个关于事件的委托
        public event CustomerEventHandler CustomerEvent;//声明一个事件

        /// <summary>
        /// 引发事件的方法
        /// </summary>
        public void Call()
        {
            Console.WriteLine("猫开始叫了......");
            if (this.CustomerEvent != null)
            {
                CustomerEvent(this, new EventArgs());
            }
        }
    }
}
