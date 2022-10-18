using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();

            class1.DoSomething = Show;

            void Show(bool isOk) => Console.WriteLine($"{isOk}");

            class2.Clac(class1.Pow, 5, 6);

            class1.DoSomething?.Invoke(class2.Result(class2.powResult));
        }
    }
}
