using System;
using System.Collections.Generic;

// Словники (ключ / значення)

namespace DictionaryWork
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(0, "Нуль");
            dictionary.Add(1, "Один");
            dictionary.Add(2, "Два");
            dictionary.Add(3, "Три");

            Console.WriteLine(dictionary.ContainsValue("Нуль"));

            for (int i = 0; i < dictionary.Count; i++)
                Console.WriteLine(dictionary[i]);

            // Delay.
            Console.ReadKey();
        }
    }
}