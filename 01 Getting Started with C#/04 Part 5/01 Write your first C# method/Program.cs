﻿// SayHello();

// void SayHello()
// {
//     Console.WriteLine("Hello");
// }



// int[] a = { 1, 2, 3, 4, 5 };

// Console.WriteLine("Content of Array");
// PrintArray();

// void PrintArray()
// {
//     foreach (int item in a)
//     {
//         Console.Write($"{item} ");
//     }
// }



// // Method execution
// Console.WriteLine("Before calling a method");
// SayHello();
// Console.WriteLine("After Calling a method");

// void SayHello()
// {
//     Console.WriteLine("Hello World!");
// }



// Console.WriteLine("Generating random numbers:");
// GenerateRandomNumbers();

// void GenerateRandomNumbers()
// {
//     Random random = new Random();

//     for (int i = 0; i < 6; i++)
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }

//     Console.WriteLine();
// }




// // Create reusable methods
// using System;

// int[] times = { 800, 1200, 1600, 2000 };
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();

// Console.WriteLine();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//     AdjustTimes();
// }
// else
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();

// Console.WriteLine();

// void DisplayTimes()
// /* Format and display medicine times */

// {
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
// }

// void AdjustTimes()
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++)
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }




// // Exercise - Build code with methods
// string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
// string[] address;
// bool validLength = false;
// bool validZeroes = true;
// bool validRange = false;

// foreach (string ip in ipv4Input)
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);


//     ValidateLength();
//     ValidateZeroes();
//     ValidateRange();

//     if (validLength && validZeroes && validRange)
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     }
//     else
//     {
//         Console.WriteLine($"{ip} is not a valid IPv4 address");
//     }

// }

// // Validation Methods 
// void ValidateLength()
// {
//     validLength = address.Length == 4;
// }

// void ValidateZeroes()
// {
//     foreach (string number in address)
//     {
//         if (number.Length > 1 && number.StartsWith("0"))
//         {
//             validZeroes = false;
//             return;
//         }
//     }

// }

// void ValidateRange()
// {
//     foreach (string number in address)
//     {
//         if (int.Parse(number) >= 0 && int.Parse(number) <= 255)
//         {
//             validRange = true;
//         }
//         else
//         {
//             validRange = false;
//             return;
//         }
//     }
// }




// // Complete the challenge to create a reusable method
// Random random = new Random();
// int luck = random.Next(100);

// string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
// string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
// string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
// string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

// FortuneTeller();
// Console.WriteLine("\n\n");
// FortuneTeller();

// void FortuneTeller()
// {
//     int luck = random.Next(100);
//     Console.WriteLine("A fortune teller whispers the following words:");

//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));

//     for (int i = 0; i < 4; i++)
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
// }