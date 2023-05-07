using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

//编写一个抽象类HotDrink,它有方法 Drink(),AddMilk()和 AddSugar(),以及属性Milk和Sugar。
//一个接口ICup,它有方法Refill()和Wash(),以及属性Color和Volume。
//派生于 HotDrink的类CupOfCoffee,支持ICup接口,还有一个属性BeanType。
//派生于HotDrink的类CupOfTea支持ICup接口,还有一个属性LeafType。
//编写入口测试程序,接受上述范例的两个杯子对象中的一个,作为一个参数。
//可以为它传送的任何杯子对象调用AddMilk()、Drink()和Wash()方法。
namespace HotDrink                                               //抽象类HotDrink
{
    public abstract class HotDrink
    {

        private double milk, suger;
        public abstract  void Drink();


        public abstract void AddMilk();


        public abstract void AddSuger();
      

        public double Milk
        {
            get {  return milk; }
            set { milk = value; }
        }

        public double Suger
        {
            get { return suger; }
            set { suger = value; }
        }

    }

    interface ICup                                                     //接口ICup
    {  
        void Refill();
        void Wash();
        string Color
        {
            get;
            set;
        }
        string Volume
        {
            get;
            set;
        }
    }

    public class CupOfCoffee : HotDrink, ICup                              //类CupOfCoffee
    {
        public override void Drink() 
        {
            Console.WriteLine("喝咖啡。");
            Milk = 0;
            Suger = 0;
        }
        public override void AddMilk()
        { 
            Milk = 0.1;
            Console.WriteLine("加0.1升牛奶");
        }
        public override void AddSuger() 
        {
            Suger = 2;
            Console.WriteLine("加2克糖");
        }
        public void Wash() 
        {
            Console.WriteLine("清洗中...");
            Console.WriteLine(".........");
            Console.WriteLine("清洗完毕！");
        }
        public void Refill() { }

        public string Color 
        { 
            get { return Color; }
            set { Color = value;}
        }
        public string Volume 
        { 
            get { return Volume; }
            set { Volume = value;}
        }

        public string BeanType
        {
            get { return BeanType; }
            set { BeanType = value;}
        } 
    }

    public class CupOfTea : HotDrink, ICup                                //类CupOfTea
    {
        public override void Drink() 
        {
            Console.WriteLine("品茶。");
        }
        public override void AddMilk() 
        {
            Console.WriteLine("无奶");
            Milk = 0;
        }
        public override void AddSuger() 
        {
            Suger = 0;
            Console.WriteLine("无糖");
        }
        public void Wash() { }
        public void Refill() { }
        public string Color { 
            get { return Color; }
            set { Color = value;}       
        }
        public string Volume { 
            get { return Volume; }
            set { Volume = value;}
        }
        public string LeafType
        {
            get { return LeafType; }
            set { LeafType = value;}
        }
    }

    public class test                                                  //调试
    {
        static void Main(string[] args)
        {
            CupOfCoffee coffee = new CupOfCoffee();
            coffee.AddMilk();
            coffee.AddSuger();
            Console.WriteLine("当前咖啡含奶量" + coffee.Milk + "升");
            Console.WriteLine("当前咖啡含糖量" + coffee.Suger + "克");
            coffee.Drink();
            Console.WriteLine("当前咖啡含奶量" + coffee.Milk + "升");
            Console.WriteLine("当前咖啡含糖量" + coffee.Suger + "克");
            coffee.Wash();
        }
    }
}
