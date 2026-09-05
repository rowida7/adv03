using System.Collections.ObjectModel;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace adv03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            ////1.Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> collection = new() {85, 92, 78, 95, 88, 70, 100, 65 };
            ////2.Print the collection, Count, first and last grade
            //Console.WriteLine($"Count:{collection.Count} - First Element:{collection[0]} - Last Element:{collection[^1]}");
            ////3.Sort the grades ascending, then print
            //Console.WriteLine("--- After Sorting ---");
            //collection.Sort();
            //Console.WriteLine($"Count:{collection.Count} - First Element:{collection[0]} - Last Element:{collection[^1]}");
            ////4.Get the first grade above 90
            //Console.WriteLine("--- Ubove 90 ---");
            //List<int> gradesUbove90 = collection.FindAll(n => n > 90);
            //foreach (int n in gradesUbove90)
            //    Console.WriteLine(n);
            ////5.Get all grades below 75(failing grades)
            //Console.WriteLine("--- Below 75 ---");
            //List<int> failingGrades = collection.FindAll(n => n < 75);
            //foreach (int n in failingGrades)
            //    Console.WriteLine(n);
            ////6.Remove all failing grades(below 75)
            //collection.RemoveAll(n => n < 75);
            ////7.Check if any grade equals 100
            //Console.WriteLine("--- Is There an Item = 100 ---");
            //bool result = collection.Contains(100);
            //Console.WriteLine(result);
            ////8.Create a List<string> where each grade becomes "Grade: X
            //Console.WriteLine("--- Grade: X ---");
            //List<string> stringList = collection.ConvertAll(n => $"Grade: {n}");
            //foreach (string s in stringList)
            //    Console.WriteLine(s);
            #endregion

            #region Exercise 2: Leaderboard
            //Create a leaderboard that automatically sorts players by score.
            //1.Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"
            
            Dictionary<int, string> leaderboard = new()
            {
                {500, "Ahmed"},
                {200, "Sara"},
                {800, "ALi"},
                {350, "Mona"}
            };
            //2.Print all entries(they should be sorted by score automatically)
            Console.WriteLine("--- Dictionary ---");
            foreach (KeyValuePair<int, string> player in leaderboard)
                Console.WriteLine($"{player.Key} = {player.Value}");
            //3.Access the first key and first value
            Console.WriteLine("--- First Key and Value ---");
            Console.WriteLine($"Key:{leaderboard.Keys.First()} - Value:{leaderboard.Values.First()}");
            //4.Check if score 500 exists
            Console.WriteLine($"Score 500 Exists? {leaderboard.ContainsKey(500)}");
            //5.Safely get the player with score 999
            Console.WriteLine("--- Player 999 ---");
            bool player999 = leaderboard.TryGetValue(999, out string? value);
            if (player999)
                Console.WriteLine(value);
            else
                Console.WriteLine("Doesn't Exist");
            //6.Remove the player with score 200 and print the updated list
            Console.WriteLine("--- After Removing Score 200 ---");
            leaderboard.Remove(200);
            foreach (KeyValuePair<int, string> player in leaderboard)
                Console.WriteLine($"{player.Key} = {player.Value}");

            #endregion
        }
    }
}
