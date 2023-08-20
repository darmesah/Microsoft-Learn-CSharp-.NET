// string firstname = "Bob";
// int widgetPurchased = 7;
// // Testing a change to the message.
// // int widgetsSold = 7;
// // Console.WriteLine($"{firstname} sold {widgetsSold} widgets.");
// Console.WriteLine($"{firstname} sold {widgetPurchased} widgets.");


// Random random = new Random();
// string[] orderIDs = new string[5];
// // Loop through each blank orderID
// for (int i = 0; i < orderIDs.Length; i++)
// {
//     // Get a random value that equates to ASCII letters A through E
//     int prefixValue = random.Next(65, 70);
//     // Convert the random value into char, then a string
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     // Create a random number, pad with zeroes
//     string suffix = random.Next(1, 1000).ToString("000");
//     // Combine the prefix and suffix together, then assign to current orderID
//     orderIDs[i] = prefix + suffix;
// }

// // Print out each orderID
// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

string str = "The quick brown fox jumps over the lazy dog.";

// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);

int letterCount = 0;
// count the o's
foreach (char i in charMessage)
{
    if (i == 'o')
    {
        letterCount++;
    }
}

// convert it back to a string
string new_message = new String(charMessage);

// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {letterCount} times.");