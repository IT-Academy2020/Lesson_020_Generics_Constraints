using System;

// Обмеження параметрів типу

namespace GenericsConstraints
{
    class Base { }
    class Derived : Base { }

    // where T: Base - Аргумент типу повинен бути або бути похідним від зазначеного базового класу.
    class MyClass<T> where T : Base
    {
    }

    class Program
    {
        static void Main()
        {
            MyClass<Base> mc1 = new MyClass<Base>();

            MyClass<Derived> mc2 = new MyClass<Derived>();

            // MyClass <string> mc3 = new MyClass <string> (); // Помилка.

            // Delay.
            Console.ReadKey();
        }
    }
}