using System;
using System.Collections;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass2 mc = new MyClass2("it's me");
            Console.WriteLine(mc.MyProperty);
            Console.WriteLine(mc.MyMethod());
        }
    }


    /// <summary>
    /// test me
    /// </summary>
    public interface IMyClass : IEnumerable
    {
        string MyMethod();
        string MyProperty { get; }
    }


    public class MyClass2 : IMyClass
    {
        private string myProperty = string.Empty;
        public MyClass2(string myProperty)
        {
            this.myProperty = myProperty;
        }
        public string MyProperty { get => this.myProperty; }

        public IEnumerator GetEnumerator() => throw new NotImplementedException();

        public string MyMethod() => "Hello!";
    }

}
