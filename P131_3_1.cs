using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P131_3_1
{
    class Student
    {
        private int id;
        private string _class;
        private string name;
        private string sex;
        private int age;

        public  Student(int id,string _class,string name,string sex,int age)
        {
            this.id = id;
            this._class = _class;
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
        //public int Id                           
        //{
        //    get { return id; }
        //}

        //public int GradeNum 
        //{   
        //    get {  return gradeNum; } 
        //}


        //public string Sex
        //{
        //    get { return sex; }
        //}

        //public int Age
        //{
        //    get { return age; }
        //    set
        //    {
        //        age = value;
        //    }
        //}

        //public string Info
        //{
        //    get { return id + " - " + name + " - " + gradeNum + " - " + sex + " - " + age; }
        //}

        public int getId() { return id; }  
        public string getClass() {  return _class; }
        public void  setAge(int age) { this.age=age; }    
        public string getSex() { return sex; } 
        public int getAge() { return age;}
        public string getName() { return name; }
    }
    class test
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "计科", "张三", "男", 22);
            Console.WriteLine(s1.getName()+"的年龄是"+s1.getAge());
            Console.WriteLine(s1.getName());
            Console.WriteLine(s1.getClass());
            Console.WriteLine(s1.getAge());
            Console.WriteLine(s1.getSex());
            Console.WriteLine(s1.getId());
            s1.setAge(20);
            Console.WriteLine(s1.getAge());
        }
    }
}
