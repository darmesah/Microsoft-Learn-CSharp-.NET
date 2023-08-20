// // do-while statement to break when a certain random number is generated
// Random random = new Random();
// int value;

// do
// {
//     value = random.Next(1, 11);
//     Console.WriteLine(value);
// } while (value != 7);



// // while statement that iterates only while a random number is greater than some value
// Random random = new Random();
// int value = random.Next(1, 11);

// while (value >= 5)
// {
//     Console.WriteLine(value);
//     value = random.Next(1, 11);
// }

// Console.WriteLine($"Last number: {value}");



// continue statement to step directly to the Boolean expression
// Random random = new Random();
// int value = random.Next(1, 11);

// do
// {
//     value = random.Next(1, 11);

//     // This makes sure the code ignores values greater than 7 (it won't even print them to the console)
//     if (value >= 8) continue;

//     Console.WriteLine(value);
// } while (value != 7);




// // Role playing game battle challenge
// int heroHealth = 10;
// int monsterHealth = 10;

// Random random = new Random();
// int attack;

// do
// {
//     attack = random.Next(1, 11);
//     monsterHealth -= attack;
//     Console.WriteLine($"Monster lost {attack} health, remaining health is {monsterHealth}");

//     if (monsterHealth <= 0) continue;

//     attack = random.Next(1, 11);
//     heroHealth -= attack;
//     Console.WriteLine($"Hero lost {attack} health, remaining health is {heroHealth}");


// } while (heroHealth > 0 && monsterHealth > 0);

// Console.WriteLine($"Game ends with monster at {monsterHealth} and hero at {heroHealth}.");
// if (heroHealth > monsterHealth)
// {
//     Console.WriteLine("Hero Wins!");
// }
// else
// {
//     Console.WriteLine("Monster Wins!");
// }



// // Code project 1 - Manage user input
// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNumber = false;


// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         valueEntered = readResult;
//     }

//     validNumber = int.TryParse(valueEntered, out numValue);

//     if (validNumber == true)
//     {
//         if (numValue <= 5 || numValue >= 10)
//         {
//             validNumber = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
// } while (validNumber == false);

// Console.WriteLine($"Your input value ({numValue}) has been accepted");




// Code project 2 - write code that validates string input

// SOLUTION 1
// string? readResult;

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// readResult = Console.ReadLine();

// while (readResult?.Trim().ToLower() != "administrator" && readResult?.Trim().ToLower() != "manager" && readResult?.Trim().ToLower() != "user")
// {
//     Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");

//     readResult = Console.ReadLine()?.Trim().ToLower();
// }

// Console.WriteLine($"Your input value {readResult} has been accepted.");


// SOLUTION 2
// string? readResult;
// string roleName = "";
// bool validEntry = false;

// do
// {                
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         roleName = readResult.Trim();
//     }

//     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
//     {
//         validEntry = true;
//     }
//     else
//     {
//         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
//     }

// } while (validEntry == false);

// Console.WriteLine($"Your input value ({roleName}) has been accepted.");




// Code project 3
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {
        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}