using System;

// Обмеження параметрів типу

namespace GenericsConstraints
{
    interface IInterface {/* ... */}
    interface IInterface<U> {/* ... */}

    class Derived : IInterface, IInterface<object> {/* ... */}

    // where T: IInterface, IInterface <object> - Аргумент типу повинен бути інтерфейсом або реалізовувати даний інтерфейс.
    // Можна встановити кілька обмежень інтерфейсів.
    // Універсальний  інтерфейс також може бути обмеженням.
    class MyClass<T> where T : IInterface, IInterface<object> {/* ... */}

    class MyClass2<T> where T : IInterface {/* ... */}

    class MyClass3<T> where T : IInterface<object> {/* ... */}


    class Program
    {
        static void Main()
        {
            // Як аргумент типу підходить Derived, тому що, він реалізовується від обох інтерфейсів.
            MyClass<Derived> my1 = new MyClass<Derived>();
            // MyClass <IInterface> my1 = new MyClass <IInterface> (); // Помилка.
            // MyClass <IInterface <object >> my1 = new MyClass <IInterface <object >> (); // Помилка.

            MyClass2<IInterface> my2 = new MyClass2<IInterface>();
            MyClass2<Derived> my3 = new MyClass2<Derived>();

            MyClass3<IInterface<object>> my4 = new MyClass3<IInterface<object>>();
            MyClass3<Derived> my5 = new MyClass3<Derived>();

            // Delay.
            Console.ReadKey();
        }
    }
}