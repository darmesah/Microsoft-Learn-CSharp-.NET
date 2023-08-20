// bool flag = true;
// int value = 10;

// if (flag)
// {
//     int value2 = 2;
//     value += value2;
//     Console.WriteLine($"Inside of the code block: {value}");
// }
// Console.WriteLine($"Outside of the code block: {value}");


// bool flag = true;
// if (flag)
// {
//     Console.WriteLine(flag);
// }

// bool flag = true;
// if (flag)
//     Console.WriteLine(flag); 

// bool flag = true;
// if (flag) Console.WriteLine(flag);


using System;

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");