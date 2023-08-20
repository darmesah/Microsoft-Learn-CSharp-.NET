// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }


// // BREAK STATEMENT
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }



// // Loop through each element of an array

// string[] names = { "Alex", "Eddie", "David", "Michael" };

// // Forward
// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
// }

// Console.WriteLine();

// // Backward
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }


// Variable assignment/reassignment in looping an array
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David") names[i] = "Sammy";

// }


for (int i = 1; i <= 100; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
    {
        Console.WriteLine(i + " - FizzBuzz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i + " - Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i + " - Fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
