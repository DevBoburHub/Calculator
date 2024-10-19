// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Daqiqalar sonini kiriting: ");
//         int daqiqa = Convert.ToInt32(Console.ReadLine()); // Foydalanuvchi daqiqani kiritadi

//         int soat = daqiqa / 60; // Soatlar soni
//         int qoldiqDaqiqa = daqiqa % 60; // Qolgan daqiqalar

//         Console.WriteLine("Vaqt: " + soat + ":" + qoldiqDaqiqa); // Soat:daqiqa formatida natija chiqariladi
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Yoshingizni kiriting: ");
//         int yosh = Convert.ToInt32(Console.ReadLine()); // Foydalanuvchidan yoshni olamiz

//         string toifa = ""; // Yosh toifasi uchun o'zgaruvchi

//         if (yosh >= 0 && yosh <= 12) toifa = "Bola";
//         if (yosh >= 13 && yosh <= 19) toifa = "O'smir";
//         if (yosh >= 20 && yosh <= 59) toifa = "Katta";
//         if (yosh >= 60) toifa = "Katta yoshli";

//         Console.WriteLine("Yosh toifasi: " + toifa); // Toifani chiqaramiz
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Birinchi bahoni kiriting: ");
//         int baho1 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Ikkinchi bahoni kiriting: ");
//         int baho2 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Uchinchi bahoni kiriting: ");
//         int baho3 = Convert.ToInt32(Console.ReadLine());

//         double ortacha = (baho1 + baho2 + baho3) / 3.0; // Uch bahoning o'rtacha qiymati hisoblanadi

//         string natija = ortacha >= 80 ? "A'lo" : ortacha >= 60 ? "Yaxshi" : ortacha >= 40 ? "Qoniqarli" : "Qoniqarsiz";
//         Console.WriteLine("Natija: " + natija); // O'rtacha baho asosida natijani chiqaradi
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Random tasodifiy = new Random(); 
//         int sirliSon = tasodifiy.Next(1, 101); // 1 dan 100 gacha tasodifiy son yaratish

//         Console.WriteLine("1 dan 100 gacha bo'lgan sonni topishga harakat qiling!");

//         bool topildi = false;
//         int urinish = 0;
//         while (!topildi)
//         {
//             Console.Write("Taxminingizni kiriting: ");
//             int foydalanuvchiSon = Convert.ToInt32(Console.ReadLine());
//             urinish++;

//             string natija = foydalanuvchiSon == sirliSon ? "To'g'ri! Siz " + urinish + " urinishda topdingiz." : 
//                            foydalanuvchiSon > sirliSon ? "Kichikroq son kiriting." : "Kattaroq son kiriting.";
//             Console.WriteLine(natija);

//             topildi = foydalanuvchiSon == sirliSon; // Agar foydalanuvchi to'g'ri topgan bo'lsa, while loop tugaydi
//         }
//     }
// }
