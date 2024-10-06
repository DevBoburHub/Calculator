using System;

System.Console.WriteLine("Type 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type 3rd number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type 4th number: ");
int fourthNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type 5th number: ");
int fifthNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type 6th number: ");
int sixthNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"1st number greater than 2nd number:  {firstNumber > secondNumber}");

System.Console.WriteLine($"2nd number less than 3rd number:  {secondNumber < thirdNumber}");

System.Console.WriteLine($"4th number greater than or equal to 5th number:  {fourthNumber >= fifthNumber}");

System.Console.WriteLine($"5th number less than or equal to 6th number:  {fifthNumber <= sixthNumber}");




