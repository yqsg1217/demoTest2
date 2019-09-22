using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例1
            //Class1 o1 = new Class1();
            //Class1 o2 = new Class1();
            //int a = Class1.Count;
            //实例2
            //ClassB o = new ConsoleApplication1.ClassB();
            //o.MethodA();

            //实例3
            //int i1 = 10;
            //int i2 = 20;
            //string str = "str";


            //Class1 c = new Class1();
            //Class1.Add(i1);
            //Class1.AddWithRef(ref i2);
            //Class1.Add(c.i);
            //Class1.StringConvert(str);
            //Class1.StringConvert(c);

            //Console.WriteLine(i1);
            //Console.WriteLine(i2);
            //Console.WriteLine(c.i);
            //Console.WriteLine(str);
            //Console.WriteLine(c.str);

            //实例4
            //A a = new B();
            //a.Fun();

            //实例5
            //A2 a = new ConsoleApplication1.A2();
            //B2 b = new ConsoleApplication1.B2();
            //a.Fun2(b);
            //b.Fun2(a);

            //实例6
            //B3 b = new B3();
            //b.PrintFileds();

            //实例7
            Console.WriteLine("x={0},y={1}", A4.X, B4.Y);

            //Cat cat = new ConsoleApplication1.Cat();
            //Mouse mouse = new ConsoleApplication1.Mouse();
            //Master mater = new ConsoleApplication1.Master();
            //cat.Calling += new EventHandler(mouse.Escape);
            //cat.Calling += new EventHandler(mater.Wakend);
            //cat.Call();

            //  Console.WriteLine("请输入一个正数");
            // int n = int.Parse(Console.ReadLine());
            //  Console.WriteLine("{0}的阶乘1*2*3....*{1}={2}", n, n, Fn(n));


            //Console.WriteLine("结果是:" + Fns(n));

            //Cats cats = new ConsoleApplication1.Cats();
            //cats.CustomerEvent += new Mouses().RRR;
            //cats.CustomerEvent += new Masters().YYY;
            //cats.Call();
            //ss();
        }

        /// <summary>
        /// 1*2*3*4*5*..................m
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double Fn(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Fn(n - 1);
            }
        }

        /// <summary>
        /// 1,1,2,3,5,8,13,21,34......第30位数是多少
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fns(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fns(n - 1) + Fns(n - 2);
            }
        }

        /// <summary>
        /// 以下表达式的值，写出您想到的一种或几种实现方法：1 - 2 + 3 - 4 +……+m
        /// </summary>
        public static void ss()
        {
            int Num = 10;
            int Sum = 0;
            for (int i = 0; i < Num + 1; i++)
            {
                if ((i % 2) == 1)
                {
                    Sum += i;
                }
                else
                {
                    Sum = Sum - i;
                }
            }
            System.Console.WriteLine(Sum.ToString());
            System.Console.ReadLine();
        }
    }


    //猫类
    public sealed class Cat
    {
        public event EventHandler Calling;
        public void Call()
        {
            Console.WriteLine("猫开始叫了......");
            if (Calling != null)
            {
                Calling(this, EventArgs.Empty);
            }
        }
    }

    public sealed class Mouse
    {
        public void Escape(object sender, EventArgs e)
        {
            Console.WriteLine("老鼠逃跑了......");
        }
    }

    public sealed class Master
    {
        public void Wakend(object sender, EventArgs e)
        {
            Console.WriteLine("主人惊醒了...");
        }
    }

    public interface IFile
    {
        int A();

        void disFile();
    }

    #region 实例1
    //public class Class1
    //{
    //    public static int Count = 0;
    //    static Class1()
    //    {
    //        Count++;
    //    }
    //    public Class1()
    //    {
    //        Count++;
    //    }
    //}
    #endregion

    #region 实例2
    public abstract class BaseClass
    {
        public virtual void MethodA()
        {
            Console.WriteLine("BaseClass");
        }

        public virtual void MethodB()
        {

        }
    }

    public class ClassA : BaseClass
    {
        public new void MethodA()
        {
            Console.WriteLine("ClassA");
        }

        public override void MethodB()
        {

        }
    }

    public class ClassB : ClassA
    {
        new public void MethodB()
        {

        }
    }
    //#endregion
    #endregion

    #region 实例3
    public class Class1
    {
        public string str = "Class1.str";
        public int i = 0;
        public static void StringConvert(string str)
        {
            str = "string beijing converted";
        }

        public static void StringConvert(Class1 c)
        {
            c.str = "string beijing converted.";
        }

        public static void Add(int i)
        {
            i++;
        }

        public static void AddWithRef(ref int i)
        {
            i++;
        }
    }
    #endregion

    #region 实例4
    public abstract class A
    {
        public A()
        {
            Console.WriteLine("A");
        }

        public virtual void Fun()
        {
            Console.WriteLine("A.Fun()");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine("B");
        }

        public override void Fun()
        {
            Console.WriteLine("B.Fun()");
        }
    }
    #endregion

    #region 实例5
    ///一个函数的执行必须在一个具体的对象中实现，如果函数明确告诉是哪个对象，则在该对象下执行；如果没有，则在默认的对象下执行
    public class A2
    {
        public virtual void Fun1(int i)
        {
            Console.WriteLine(i);
        }

        public void Fun2(A2 a)
        {
            a.Fun1(1);
            Fun1(5);
        }
    }

    public class B2 : A2
    {
        public override void Fun1(int i)
        {
            base.Fun1(i + 1);
        }
    }
    #endregion

    #region 实例6
    public class A3
    {
        public A3()
        {
            PrintFileds();
        }
        public virtual void PrintFileds() { }
    }

    public class B3 : A3
    {
        int x = 4;
        int y;
        public B3()
        {
            y = -1;
        }
        public override void PrintFileds()
        {
            x += 1;
            Console.WriteLine("x={0},y={1}", x, y);
            y += 1;
        }
    }
    #endregion

    #region 实例7
    public class A4
    {
        public static int X;
        static A4()
        {
            X = B4.Y + 1;
        }
    }
    public class B4
    {
        public static int Y = A4.X + 1;
        static B4() { }
    }
    #endregion
}

