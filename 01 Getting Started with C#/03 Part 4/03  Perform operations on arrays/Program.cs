// string[] pallets = { "B14", "A11", "B12", "A13" };

// // SORT
// Console.WriteLine("Sorted...");
// Array.Sort(pallets);

// foreach (var pallet in pallets)
// {
//     Console.WriteLine("--" + pallet);
// }

// Console.WriteLine("");

// // REVERSE
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);

// foreach (var pallet in pallets)
// {
//     Console.WriteLine("--" + pallet);
// }


// string[] pallets = { "B14", "A11", "B12", "A13" };

// // CLEAR
// Console.WriteLine("Before: " + pallets[0]);
// Array.Clear(pallets, 0, 2);
// Console.WriteLine("After: " + pallets[0]);

// Console.WriteLine("Clearing 2 ... count: " + pallets.Length);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine("-- " + pallet);
// }

// Console.WriteLine("");

// // RESIZE the array to add more elements
// Array.Resize(ref pallets, 6);
// Console.WriteLine("Resizing 6 ... count: " + pallets.Length);

// pallets[4] = "CO1";
// pallets[5] = "CO2";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine("-- " + pallet);
// }

// // RESIZE the array to add more elements
// Array.Resize(ref pallets, 3);
// Console.WriteLine("Resizing 3 ... count: " + pallets.Length);

// foreach (var pallet in pallets)
// {
//     Console.WriteLine("-- " + pallet);
// }



// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }


// Reverse words in a sentence challenge
// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] stringArray = pangram.Split(" ");

// string myString = "";

// foreach (var item in stringArray)
// {
//     char[] charArray = item.ToCharArray();
//     Array.Reverse(charArray);
//     string result = new string(charArray);
//     myString += result + " ";
// }

// Console.WriteLine(myString);



// Parse a string of orders, sort the orders and tag possible errors
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderStreamArray = orderStream.Split(",");
Array.Sort(orderStreamArray);

for (int i = 0; i < orderStreamArray.Length; i++)
{
    if (orderStreamArray[i].Length != 4)
    {
        orderStreamArray[i] = orderStreamArray[i] + "\t - Error";
    }

    Console.WriteLine(orderStreamArray[i]);
}