// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Satrni kiriting: ");
//         string satr = Console.ReadLine(); // Foydalanuvchi satrni kiritadi
//         string teskari = "";

//         for (int i = satr.Length - 1; i >= 0; i--)
//         {
//             teskari += satr[i]; // Satrni teskari o'qib teskari o'zgaruvchiga qo'shamiz
//         }

//         if (satr == teskari)
//         {
//             Console.WriteLine("Palindrom"); // Agar bir xil bo'lsa, palindrom
//         }
//         else
//         {
//             Console.WriteLine("Palindrom emas"); // Aks holda, palindrom emas
//         }
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Selsiyusdagi temperaturani kiriting: ");
//         double selsiy = Convert.ToDouble(Console.ReadLine()); // Foydalanuvchi Selsiyusni kiritadi

//         double fahrenheit = (selsiy * 9 / 5) + 32; // Fahrenheitga aylantirish
//         double kelvin = selsiy + 273.15; // Kelvin ga aylantirish

//         Console.WriteLine("Selsiyus: " + selsiy);
//         Console.WriteLine("Fahrenheit: " + fahrenheit);
//         Console.WriteLine("Kelvin: " + kelvin);
//     }
// }

// using System;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Sonlarni kiriting (vergul bilan ajrating): ");
//         string input = Console.ReadLine(); // Foydalanuvchi sonlarni kiritadi
//         int[] sonlar = input.Split(',').Select(int.Parse).ToArray(); // Kiritilgan sonlar massivga aylanadi

//         Array.Sort(sonlar); // Tartiblangan qator
//         Console.WriteLine("Tartiblangan qator: " + string.Join(", ", sonlar));

//         Array.Reverse(sonlar); // Teskari tartiblangan qator
//         Console.WriteLine("Teskari tartiblangan qator: " + string.Join(", ", sonlar));
//     }
// }

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Matn kiriting: ");
//         string matn = Console.ReadLine(); // Foydalanuvchi matnni kiritadi

//         Dictionary<char, int> simvolSanash = new Dictionary<char, int>();

//         foreach (char simvol in matn)
//         {
//             if (simvolSanash.ContainsKey(simvol))
//             {
//                 simvolSanash[simvol]++; // Agar simvol mavjud bo'lsa, sanagani oshiramiz
//             }
//             else
//             {
//                 simvolSanash[simvol] = 1; // Agar yangi simvol bo'lsa, 1 ga tenglashamiz
//             }
//         }

//         foreach (var element in simvolSanash)
//         {
//             Console.WriteLine("'" + element.Key + "': " + element.Value + " marta");
//         }
//     }
// }
