// using System.Security.Cryptography.X509Certificates;

// List<string> Mevaho = [];
// Mevaho.AddRange("seb", "banan", "aplesin", "seb");
// var a = Mevaho.Count();
// // Console.WriteLine(a);
// // foreach (var item in fruits)
// // {
// //     Console.WriteLine(item+" ");
// // }
// Mevaho.Remove("banan");
// var b = Mevaho.Any(a => a == "seb");
// // Console.WriteLine(b);
// // Mevaho.Clear();
// List<string> fruits = new List<string>(Mevaho);
// fruits.Insert(0, "angur");
// // Console.WriteLine(fruits[2]);
// var f = fruits.Any();
// Console.WriteLine(!f);
// fruits.Sort();
// fruits.Reverse();
// List<string> sabzavot = new List<string>(){"bodiring","sabzi"};
// fruits.AddRange(sabzavot);
// var g = fruits.FindIndex(x=>x=="seb");
// System.Console.WriteLine(g);
// fruits.RemoveAll(a=>a.Length>3);

// foreach (var item in fruits)
// {
//     Console.WriteLine(item + " ");
// }


//           Home task 



// task 1
// List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
// int sum=0;
// foreach(int number in numbers)
// {
//     sum+=number;
// }
// System.Console.WriteLine(sum);

// task 2
// List<string> words = new List<string> { "hello", "world", "!" };

// string concat = string.Concat(words);

// Console.WriteLine("The concatenated string is: " + concat);

// task 3
// List<DateTime> dates = new List<DateTime>
// {
//     new DateTime(2025, 10, 1),
//     new DateTime(2022, 8, 15),
//     new DateTime(2021, 4, 28)
// };
// dates.Sort();
// Console.WriteLine("The sorted dates are:");
// foreach (DateTime date in dates)
// {
//     Console.WriteLine(date.ToShortDateString());
// }


// task 4
// List<double> numbers = new List<double> { 3.5, 2.7, 6.9, 1.2 };

// double average = numbers.Average();

// Console.WriteLine(average);

// task 5
// List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

// List<int> evenNumbers = numbers.FindAll(number => number % 2 == 0);

// Console.WriteLine("The filtered numbers are:");

// foreach (int number in evenNumbers)
// {
//     Console.WriteLine(number);
// }


// task 6
// List<bool> values = new List<bool> { true, true, true };

// bool allTrue = values.All(value => value == true);

// Console.WriteLine("Are all the values in the list true? " + allTrue);

// task 7
// List<string> items = new List<string>{ "apple", "banana", "cherry" };
// items.Remove("banana");
// Console.WriteLine("List after removal:");
// foreach (var item in items)
// {
//     Console.WriteLine(item);
// }

// task 8
// List<string> items = new List<string>{ "apple", "banana", "cherry" };
// bool found=items.Contains("banana");
// Console.WriteLine("Is the element found? " + found);

// task 9
// List<int> numbers = new List<int>();
// numbers.Add(10);
// Console.WriteLine("All numbers in the list:");
// foreach (var number in numbers)
// {
//     Console.WriteLine(number);
// }

// task 10
// List<int> numbers = new List<int>();
// Random random = new Random();
// for (int i = 0; i < 10; i++)
// {
//     numbers.Add(random.Next(1, 10));
// }

// Console.WriteLine("Random numbers in the list:");

// foreach (var number in numbers)
// {
//     Console.WriteLine(number);
// }