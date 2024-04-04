using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class Student
    {

        int ID;
        string name;
        int age;
        int Class;

        public void setid(int Id,string name,int age,int classes)
        {
           this.ID = Id;
            this.name=name;
            this.age=age;
            this.Class=classes;
        }


        public void getid()
        {
            Console.WriteLine("your ID is :{0}", this.ID);
                Console.WriteLine("your name is :{0}",this.name);
            Console.WriteLine("Your age is :{0}",this.age);
            Console.WriteLine("your class is :{0}",this.Class);

        }


        static void Main(string[] args)
        {
           
        Student Ibrahim = new Student();

            Ibrahim.setid(101,"Ibrahim",22,12);
            Student Ibrahim1 = new Student();

            Ibrahim.setid(101, "Ibrahim", 22, 12);

            Ibrahim.getid();

            Console.ReadLine();
        }
    }
}
