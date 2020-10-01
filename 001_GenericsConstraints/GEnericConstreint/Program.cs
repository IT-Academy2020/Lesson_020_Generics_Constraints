using System;

// Обмеження параметрів типу.

namespace GenericsConstraints
{
    // where T: class - Аргумент типу повинен мати reference тип, це також може бути будь-який клас, інтерфейс, делегат або масив.
    class MyClass1<T> where T : class
    {
        public T variable;
    }

    // where T: struct - Аргумент типу повинен мати value тип. Допускається зазначення будь-якого value типу, крім Nullable.
    class MyClass2<T> where T : struct
    {
        public T variable;
    }

    class Program
    {
        static void Main()
        {
            MyClass1<string> instance1 = new MyClass1<string>();
            // MyClass1 <int> instance1 = new MyClass1 <int> (); // Помилка. int - value тип.

            MyClass2<int> instance2 = new MyClass2<int>();
            // MyClass2 <string> instance2 = new MyClass2 <string> (); // Помилка. string - reference тип.

            // Delay.
            Console.ReadKey();
        }
    }
}