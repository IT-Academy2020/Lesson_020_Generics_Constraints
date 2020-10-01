using System;

// Обмеження параметрів типу - "naked"

namespace GenericsConstraints
{
    // Аргумент типу, що надається в якості T, повинен збігатися з аргументом, що надаються в якості U, або бути похідним від нього.
    // Це називається обмеженням типу "Naked".

    class MyClass<T, R, U> where T : U
    {
    }

    class Program
    {
        static void Main()
        {
            MyClass<int, Object, int> my1 = new MyClass<int, Object, int>();

            MyClass<string, Object, string> my2 = new MyClass<string, Object, string>();

            // Не збігаються перший і третій аргументи типів - T і U (string і int).
            // MyClass <string, Object, int> my2 = new MyClass <string, Object, int> (); // ПОМИЛКА!

            // Delay.
            Console.ReadKey();
        }
    }
}