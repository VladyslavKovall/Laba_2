using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Завдання 1
        Console.WriteLine("Завдання 1:");
        Random rand = new Random();
        int N = 20; 
        List<int> collection1 = new List<int>();
        for (int i = 0; i < N; i++)
        {
            collection1.Add(rand.Next(1, 26));
        }

        Console.WriteLine("Початкова колекція: " + string.Join(", ", collection1));
        collection1 = collection1.Where(x => !(x >= 10 && x < 20)).ToList();

        Console.WriteLine("Колекція після видалення чисел, що починаються на 1: " + string.Join(", ", collection1));

        Console.WriteLine("\n--------------------------\n");

        // Завдання 2
        Console.WriteLine("Завдання 2:");
        N = 20; 
        int X = 10; 
        List<int> collection2 = new List<int>();
        for (int i = 0; i < N; i++)
        {
            collection2.Add(rand.Next(10, 100));
        }

        Console.WriteLine("Початкова колекція: " + string.Join(", ", collection2));
        for (int i = 0; i < collection2.Count; i++)
        {
            int sum = collection2[i] / 10 + collection2[i] % 10;
            if (sum == X)
            {
                collection2.Insert(i, -1);
                break;
            }
        }

        Console.WriteLine("Колекція після вставки -1: " + string.Join(", ", collection2));

        Console.WriteLine("\n--------------------------\n");

        // Завдання 3
        Console.WriteLine("Завдання 3:");
        N = 10; 
        List<int> collectionA = new List<int>();
        List<int> collectionB = new List<int>();
        List<int> collectionC = new List<int>();
        for (int i = 0; i < N; i++)
        {
            collectionA.Add(rand.Next(1, 11));
            collectionB.Add(rand.Next(1, 11));
        }

        Console.WriteLine("Колекція A: " + string.Join(", ", collectionA));
        Console.WriteLine("Колекція B: " + string.Join(", ", collectionB));
        for (int i = 0; i < N; i++)
        {
            if ((collectionA[i] % 2 == 0 && collectionB[i] % 2 == 0) || (collectionA[i] % 2 != 0 && collectionB[i] % 2 != 0))
            {
                collectionC.Add(1);
            }
            else
            {
                collectionC.Add(-1);
            }
        }

        Console.WriteLine("Колекція C: " + string.Join(", ", collectionC));
    }
}
