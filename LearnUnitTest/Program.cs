using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello";
            UpdateString(hello);
            Console.WriteLine(hello);
            MyClass myClass = new MyClass() { MyProperty = "fuck" };
            UpdateString(myClass);
            Console.WriteLine(myClass.MyProperty);
        }

        private static void UpdateString(MyClass myClass)
        {
            myClass.MyProperty += " you";
        }

        private static void UpdateString(string hello)
        {
            hello = hello + " you";
        }
    }

    public class MyClass
    {
        public string MyProperty { get; set; }
    }
}
