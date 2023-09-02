﻿// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

// // int first = 2;
// // string second = "4";
// // string result = first + second;
// // Console.WriteLine(result);



// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");


// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");


// // Convert a string to an int using the Parse() helper method

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);


// // Convert a string to a int using the Convert class
// string first = "5";
// string second = "7";
// int result = Convert.ToInt32(first) * Convert.ToInt32(second);
// Console.WriteLine(result);


// // Compare casting and converting a decimal into an int
// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);



// // Examine the TryParse() method
// string value = "100";
// int result = 0;

// if (int.TryParse(value, out result))
// {
//     Console.WriteLine("Mesurement: " + result);
// }
// else
// {
//     Console.WriteLine("Unable to report the mesurement");
// }

// Console.WriteLine($"Measurement (w/ offset): {50 + result}");



// // Exercise - Complete a challenge to combine string array values as strings and as integers

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// string message = "";
// decimal total = 0m;

// foreach (var value in values)
// {
//     if (decimal.TryParse(value, out decimal num))
//     {
//         total += num;
//     }
//     else
//     {
//         message += value;
//     }
// }

// Console.WriteLine("Message: " + message);
// Console.WriteLine("Total: " + total);



// Exercise - Complete a challenge to output math operations as specific number types
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
