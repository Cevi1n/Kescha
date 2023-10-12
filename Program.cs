using System;

System.Console.Write("Enter your name: ");
string name = System.Console.ReadLine();
string greeting = $"Hello, {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Enter your age: ");
string ageAstring = Console.ReadLine();
System.Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAstring);
System.Console.WriteLine($"Successfully converted! {age}");
int Keshage = 3;
int AgeDifference = age - Keshage;
System.Console.WriteLine($"The difference between your and Kescha's age isa {AgeDifference}");

