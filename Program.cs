using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Text.Encodings.Web;
using System.Timers;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
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
            ////Create a leaderboard that automatically sorts players by score.
            ////1.Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"

            //Dictionary<int, string> leaderboard = new()
            //{
            //    {500, "Ahmed"},
            //    {200, "Sara"},
            //    {800, "ALi"},
            //    {350, "Mona"}
            //};
            ////2.Print all entries(they should be sorted by score automatically)
            //Console.WriteLine("--- Dictionary ---");
            //foreach (KeyValuePair<int, string> player in leaderboard)
            //    Console.WriteLine($"{player.Key} = {player.Value}");
            ////3.Access the first key and first value
            //Console.WriteLine("--- First Key and Value ---");
            //Console.WriteLine($"Key:{leaderboard.Keys.First()} - Value:{leaderboard.Values.First()}");
            ////4.Check if score 500 exists
            //Console.WriteLine($"Score 500 Exists? {leaderboard.ContainsKey(500)}");
            ////5.Safely get the player with score 999
            //Console.WriteLine("--- Player 999 ---");
            //bool player999 = leaderboard.TryGetValue(999, out string? value);
            //if (player999)
            //    Console.WriteLine(value);
            //else
            //    Console.WriteLine("Doesn't Exist");
            ////6.Remove the player with score 200 and print the updated list
            //Console.WriteLine("--- After Removing Score 200 ---");
            //leaderboard.Remove(200);
            //foreach (KeyValuePair<int, string> player in leaderboard)
            //    Console.WriteLine($"{player.Key} = {player.Value}");

            #endregion

            #region Exercise 3: Phone Book
            ////Build a phone book application.
            ////1.Create a Collection with 4 contacts(name → phone number)
            //Dictionary<string, string> phoneBook = new(4);
            ////2.Add a new contact using [] syntax (add or update)
            //phoneBook["Ali"] = "0109988004";
            //phoneBook["Ahmed"] = "0100558004";
            ////3.Try adding a duplicate using .Add() — catch the exception and print the error
            //Console.WriteLine("--- Catch The Exception ---");
            //try
            //{
            //    phoneBook.Add("Ali", "0109988004");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ////4.Try adding a duplicate using .TryAdd() — print whether it succeeded
            //Console.WriteLine("--- TryAdd() ---");
            //if (phoneBook.TryAdd("Ali", "0109988704"))
            //    Console.WriteLine("Added Successfully");
            //else
            //    Console.WriteLine("Failed to Add");
            ////5.Search for a contact that doesn’t exist
            //Console.WriteLine("--- contact that doesn’t exist ---");
            //Console.WriteLine(phoneBook.ContainsValue("Mohsen"));
            ////6.Get a contact with a fallback of "Not Found"
            //Console.WriteLine("--- Not Found Contact ---");
            //if (phoneBook.TryGetValue("Alaa", out string? value))
            //    Console.WriteLine("Found Successfully");
            //else
            //    Console.WriteLine("Not Found");
            ////7.Print all Keys on one line, then all Values on another line
            //Console.WriteLine("Keys:");
            //foreach (string key in phoneBook.Keys)
            //    Console.Write($"- {key}");

            //Console.WriteLine("Vlaues:");
            //foreach (string val in phoneBook.Values)
            //    Console.WriteLine($"- {val}");
            #endregion

            #region Exercise 4: Unique Email Validator
            ////Use Collection to manage unique email addresses.
            ////1.Create a HashSet<string> with a case -insensitive comparer: new
            ////HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            ////2.Add these emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com",
            ////"Sara@Test.Com"
            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");
            ////3.Print Count — how many are actually stored? Explain why.
            //Console.WriteLine($"Count: {emails.Count}"); //becuz it is case insensitive 
            ////4.Create two sets: Set A = { 1, 2, 3, 4, 5 } and Set B = { 4,5,6,7,8}
            //HashSet<int> A = new() { 1, 2, 3, 4, 5 };
            //HashSet<int> B = new() { 4, 5, 6, 7, 8 };
            //5.Print the result of: UnionWith, IntersectWith, ExceptWith
            //Console.Write($"UnionWith:");
            //A.UnionWith(B);
            //A.printHashSet<int>();

            //Console.Write($"IntersectWith:"); 
            //A.IntersectWith(B);
            //A.printHashSet<int>();

            //Console.Write($"ExceptWith:");
            //A.ExceptWith(B);
            //A.printHashSet<int>();
            ////6.Use IsSubsetOf to check if { 1,2} is a subset of Set A
            //HashSet<int> smallSet = new() { 1, 2 };
            //if (smallSet.IsSubsetOf(A))
            //    Console.WriteLine("{ 1,2} is a subset of Set A");
            //else
            //    Console.WriteLine("{ 1,2} is NOT a subset of Set A");
            #endregion

            #region Exercise 5: Print Queue Simulator
            ////Simulate a printer queue
            ////Create a Queue<string> and enqueue 5 documents: "Report.pdf", "Invoice.pdf",
            ////"Letter.docx", "Resume.pdf", "Photo.jpg"
            //Queue<string> documents = new();
            //documents.Enqueue("Report.pdf");
            //documents.Enqueue("Invoice.pdf");
            //documents.Enqueue("Letter.docx");
            //documents.Enqueue("Resume.pdf");
            //documents.Enqueue("Photo.jpg");
            ////1.Print the queue contents and Count
            //Console.WriteLine("--- Print Queue ---");
            //documents.printQueue();
            ////2.Use Peek to see which document will print next(without removing)
            //Console.WriteLine($"Peek:{documents.Peek()}");
            ////3.Process the queue: Dequeue each document and print "Printing: [name]"
            //while(documents.Count>0)
            //{ 
            //    string x = documents.Dequeue();
            //    Console.WriteLine($"Printing: {x}");
            //}
            ////4.Try TryDequeue on the now-empty queue — what happens?
            //bool res = documents.TryDequeue(out string? result);
            //Console.WriteLine($"Can I Dequeue:{res} --- Value:{result??"null"}");
            ////it tries to dequeue empty queue and return true/return the value in the out if worked
            ////and false/return default value if not
            #endregion

            #region Exercise 6: Browser History (Undo)
            //Simulate browser back / forward
            //Create a Stack<string> for browser history
            Stack<string> history = new();
            //1.Push 5 URLs: "google.com", "github.com", "stackoverflow.com", "youtube.com",
            //"claude.ai"
            history.Push("google.com");
            history.Push("github.com");
            history.Push("stackoverflow.com");
            history.Push("youtube.com");
            history.Push("claude.ai");
            //2.Use Peek to see the current page(top of stack)
            Console.WriteLine($"Peek: {history.Peek()}");
            Console.WriteLine($"-------------");
            //3.Press "back" 3 times using Pop — print each page you leave
            for (int i = 0; i < 3; i++)
            {
                string x = history.Pop();
                Console.WriteLine(x);
            }
            Console.WriteLine($"-------------");
            //4.Print the current page after going back
            Console.WriteLine($"Current Page: {history.Peek()}");
            //5.Try TryPop on an empty stack — what happens?
            bool res = history.TryPop(out string? result);
            Console.WriteLine($"Can I Pop:{res} --- Value:{result ?? "null"}");
            //it tries to pop empty stack and return true/return the value in the out if worked
            //and false/return default value if not
            #endregion
        }
    }
}
