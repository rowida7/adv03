using System.Collections.ObjectModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace adv03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            //1.Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            List<int> collection = new() {85, 92, 78, 95, 88, 70, 100, 65 };
            //2.Print the collection, Count, first and last grade
            Console.WriteLine($"Count:{collection.Count} - First Element:{collection[0]} - Last Element:{collection[^1]}");
            //3.Sort the grades ascending, then print
            Console.WriteLine("--- After Sorting ---");
            collection.Sort();
            Console.WriteLine($"Count:{collection.Count} - First Element:{collection[0]} - Last Element:{collection[^1]}");
            //4.Get the first grade above 90
            Console.WriteLine("--- Ubove 90 ---");
            List<int> gradesUbove90 = collection.FindAll(n => n > 90);
            foreach (int n in gradesUbove90)
                Console.WriteLine(n);
            //5.Get all grades below 75(failing grades)
            Console.WriteLine("--- Below 75 ---");
            List<int> failingGrades = collection.FindAll(n => n < 75);
            foreach (int n in failingGrades)
                Console.WriteLine(n);
            //6.Remove all failing grades(below 75)
            collection.RemoveAll(n => n < 75);
            //7.Check if any grade equals 100
            Console.WriteLine("--- Is There an Item = 100 ---");
            bool result = collection.Contains(100);
            Console.WriteLine(result);
            //8.Create a List<string> where each grade becomes "Grade: X
            Console.WriteLine("--- Grade: X ---");
            List<string> stringList = collection.ConvertAll(n => $"Grade: {n}");
            foreach (string s in stringList)
                Console.WriteLine(s);
            #endregion
        }
    }
}
