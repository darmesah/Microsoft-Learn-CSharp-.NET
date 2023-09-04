// // Composite Formatting
// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);



// // string interpolation
// string first = "Hello";
// string second = "World";

// Console.WriteLine($"{first} {second}!");



// // Formatting currency
// decimal price = 123.45m;
// int discount = 50;

// Console.WriteLine($"Price: {price:C} (Save {discount:C})");



// // Formatting numbers
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N3} units");



// // Formatting percentages
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");



// // Combining formatting approaches
// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), salePrice);

// yourDiscount += $"A discount of {((price - salePrice) / price):P2}!";

// Console.WriteLine(yourDiscount);




// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");



// // Formatting strings by adding whitespace before or after
// string input = "Pad this";
// Console.WriteLine(input.PadLeft(10));
// Console.WriteLine(input.PadRight(20));

// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));



// string paymentId = "769";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// string formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);




// Complete a challenge to apply string interpolation to a form letter
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
string comparisonMessage = $"Dear {customerName},\n";

comparisonMessage += $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n";

comparisonMessage += $"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n\n";

comparisonMessage += $"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n\n";

comparisonMessage += "Here's a quick comparison:\n\n";

comparisonMessage += $"{currentProduct,-20} {currentReturn:P}    {currentProfit:C}\n";
comparisonMessage += $"{newProduct,-20} {newReturn:P}    {newProfit:C}";

Console.WriteLine(comparisonMessage);