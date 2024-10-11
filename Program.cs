// using System;

// Console.Write("Birinchi raqamni kiriting: ");
// double numb1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Ikkinchi raqanni kiriting: ");
// double numb2 = Convert.ToDouble(Console.ReadLine());

// double result = numb1 + numb2;
// Console.WriteLine("Natija:  " + result);

// using System;

// Console.Write("N sonini kiriting: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int sum = N * (N + 1) / 2;

// Console.WriteLine("1 dan " + N + " gacha bo'lgan sonlar yig'indisi: " + sum);

// using System;

// Console.Write("Raqam kiriting: ");
// int number = Convert.ToInt32(Console.ReadLine());

// string result = (number % 2 == 0) ? "Juft" : "Toq";

// Console.WriteLine(result);

// using  System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Son kiriting: ");
//         int son = Convert.ToInt32(Console.ReadLine());
//         int i = 2;
//         string xabar = "Tub";

//         for (; i * i <= son; i++)
//             if (son % i == 0)
//                 xabar = "Tub emas";

//         Console.WriteLine(xabar);
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Son kiriting: ");
//         int son = Convert.ToInt32(Console.ReadLine());
//         string boluvchilar = "";

//         for (int i = 2; i <= 10; i++)
//             if (son % i == 0)
//                 boluvchilar += i + " ";

//         Console.WriteLine("Bo'luvchilari: " + boluvchilar);
//     }
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Son kiriting: ");
//         int son = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Daraja kiriting: ");
//         int daraja = Convert.ToInt32(Console.ReadLine());

//         int natija = 1;
//         for (int i = 0; i < daraja; i++)
//             natija *= son;

//         Console.WriteLine("Natija: " + natija);
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] harajatlar = { 150, 230, 80, 120 };
//         int yigindi = 0;

//         for (int i = 0; i < harajatlar.Length; i++)
//             yigindi += harajatlar[i];

//         Console.WriteLine("Yig'indi: " + yigindi);
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Son kiriting: ");
//         int son = Convert.ToInt32(Console.ReadLine());
//         string sonStr = son.ToString();
//         int uzunlik = sonStr.Length;
//         int yigindi = 0;

//         for (int i = 0; i < uzunlik; i++)
//             yigindi += (int)Math.Pow(Convert.ToInt32(sonStr[i].ToString()), uzunlik);

//         Console.WriteLine(son == yigindi ? son + " Armstrong son" : son + " Armstrong son emas");
//     }
// }

using System;

class Program
{
    static void Main()
    {
        Console.Write("Son kiriting: ");
        int son = Convert.ToInt32(Console.ReadLine());
        int boluvchilar = 0;

        for (int i = 1; i <= son; i++)
            if (son % i == 0)
                boluvchilar++;

        Console.WriteLine("Sifatli bo'luvchilar soni: " + boluvchilar);
    }
}









