// using System;

// int x = 13;
// string str = "teLefOn";

// string result = x > str.Length ? str.ToUpper() : str.ToLower();

// System.Console.WriteLine(result);

// using System;

// int x = 15;
// int y = 10;

//  string result;

//         if (x > y)
//         {
//             result = "x is greater than y";
//         }
//         else if (x < y)
//         {
//             result = "x is less than y";
//         }
//         else if (x == y)
//         {
//             result = "x is equal to y";
//         }
//         else
//         {
//             result = "x and y are not comparable";
//         }

//         Console.WriteLine(result); // Output: x is greater than y
    
// using System;

// class Program
// {
//     static void Main()
//     {
//         int x = 15;
//         int y = 10;

//         string result = (x > y)
//             ? "x is greater than y"
//             : (x < y)
//                 ? "x is less than y"
//                 : (x == y)
//                     ? "x is equal to y"
//                     : "x and y are not comparable";

//         Console.WriteLine(result); // Output: x is greater than y
//     }
// }

// using System;

//         Console.Write("Hafta kunini kiriting (o'zbek tilida): ");
//         string haftaKuni = Console.ReadLine();

//         string englishDay = haftaKuni switch
//         {
//             "dushanba" => "Monday",
//             "seshanba" => "Tuesday",
//             "chorshanba" => "Wednesday",
//             "payshanba" => "Thursday",
//             "juma" => "Friday",
//             "shanba" => "Saturday",
//             "yakshanba" => "Sunday",
//             _ => "Not a valid day"
//         };

//         Console.WriteLine($"Ingliz tilida: {englishDay}");