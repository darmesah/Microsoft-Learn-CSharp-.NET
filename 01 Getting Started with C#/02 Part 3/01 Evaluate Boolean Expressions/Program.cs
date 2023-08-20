// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");4


// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");


// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);


// Logical Negotiation(!expression)

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// These two lines of code will create the same output

// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));



// Implement the conditional (tenary) operator
// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


// Random coin = new Random();
// string result = coin.Next(1, 3) == 1 ? "heads" : "tails";
// Console.WriteLine(result);


string permission = "Manager";
int level = 56;


if (permission.Contains("Admin"))
{
    Console.WriteLine(level > 55 ? "Welcome, Super Admin user" : "Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine(level > 20 ? "Contact an Admin for access." : "You do not have sufficient priviledges.");
}
else
{
    Console.WriteLine("You do not have sufficient priviledges.");
}