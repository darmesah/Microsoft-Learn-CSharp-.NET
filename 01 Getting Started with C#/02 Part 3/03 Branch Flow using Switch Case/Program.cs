// string fruit = "pawpaw";

// switch (fruit)
// {
//     case "apple":
//         Console.WriteLine("App will display information for apple");
//         break;

//     case "banana":
//         Console.WriteLine("App will display information for banana");
//         break;

//     case "cherry":
//         Console.WriteLine("App will display information for cherry");
//         break;

//     default:
//         Console.WriteLine("Input fruit does not exist");
//         break;
// }


// SWITCH STATEMENT

// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title;

// switch (employeeLevel)
// {
//     case 100:
//         title = "Junior Associate";
//         break;

//     case 200:
//         title = "Senior Associate";
//         break;

//     case 300:
//         title = "Manager";
//         break;

//     case 400:
//         title = "Senior Manager";
//         break;

//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}"); 


// SWITCH EXPRESSION

// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title;

// title = employeeLevel switch
// {
//     100 => "Junior Associate",
//     200 => "Senior Associate",
//     300 => "Manager",
//     400 => "Senior Manager",
//     _ => "Associate",
// };

// Console.WriteLine($"{employeeName}, {title}");


// Working with multiple labels

// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title;

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;

//     case 300:
//         title = "Manager";
//         break;

//     case 400:
//         title = "Senior Manager";
//         break;

//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");,


// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title;

// title = employeeLevel switch
// {
//     100 or 200 => "Senior Associate",
//     300 => "Manager",
//     400 => "Senior Manager",
//     _ => "Associate",
// };

// Console.WriteLine($"{employeeName}, {title}");



// CONVERSION FROM IF-ELSE TO SWITCH STATEMENT

// // SKU = Stock Keeping Unit. 
// // SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } else if (product[0] == "02")
// {
//     type = "T-Shirt";
// } else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }

// Console.WriteLine($"Product: {size} {color} {type}");

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

for (int i = 0; i < product.Length; i++)
{
    if (i == 0)
    {
        switch (product[i])
        {
            case "01":
                type = "Sweat shirt";
                break;

            case "02":
                type = "T-Shirt";
                break;

            case "03":
                type = "Sweat pants";
                break;


            default:
                type = "Other";
                break;
        }
    }
    else if (i == 1)
    {
        color = product[i] switch
        {
            "BL" => "Black",
            "MN" => "Maroon",
            _ => "White",
        };
    }
    else if (i == 2)
    {
        size = product[i] switch
        {
            "M" => "Medium",
            "L" => "Large",
            _ => "One Size Fits All",
        };
    }
}

Console.WriteLine($"Product: {size} {color} {type}");