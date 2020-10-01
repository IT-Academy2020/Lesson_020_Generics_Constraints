using System;

// Обмеження параметрів типу

namespace GenericsConstraints
{
    interface IInterface {/* ... */}
    interface IInterface<U> : IInterface {/* ... */}

    class Derived : IInterface, IInterface<object> {/* ... */}

    class Derived2 : IInterface<object> {/* ... */}

    // where T: IInterface, IInterface <object> - Аргумент типу повинен бути або реалізовувати зазначений інтерфейс.
    // Можна встановити кілька обмежень інтерфейсів. Обмеженням також може бути універсальним інтерфейсом.

    class MyClass<T> where T : IInterface, IInterface<object> {/* ... */}

    class MyClass2<T> where T : IInterface<object> {/* ... */}


    class Program
    {
        static void Main()
        {
            // Як аргумент типу підходить Derived, тому що, він реалізовується від обох інтерфейсів.
            MyClass<Derived> my1 = new MyClass<Derived>();
            // MyClass <IInterface> my1 = new MyClass <IInterface> (); // Помилка.

            // Аргумент типу підходить, тому що, IInterface <object> реалізовується від IInterface
            MyClass<IInterface<object>> my2 = new MyClass<IInterface<object>>();

            MyClass2<Derived> my3 = new MyClass2<Derived>();
            MyClass2<Derived2> my4 = new MyClass2<Derived2>();
            MyClass2<IInterface<object>> my5 = new MyClass2<IInterface<object>>();

            // Delay.
            Console.ReadKey();
        }
    }
}