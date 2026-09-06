using System;
using System.Collections.Generic;
using System.Text;

namespace adv03
{
    internal static class HashSetHelper
    {
        public static void printHashSet<T>(this HashSet<T> hashSet)
        {
            if (hashSet is not null && hashSet.Count > 0)
            {
                foreach (T val in hashSet)
                {
                    Console.Write($"- {val}");
                }
                Console.WriteLine();
            }
        }
        public static void printQueue<T>(this Queue<T> queue)
        {
            if (queue is not null && queue.Count > 0)
            {
                foreach (T val in queue)
                {
                    Console.WriteLine($"{val}");
                }
            }
        }
    }
}
