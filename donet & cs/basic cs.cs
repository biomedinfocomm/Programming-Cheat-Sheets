//----------Uninstall .Net sdk----------
# delete the dotnet folder under /usr/local/share/dotnet
1. cd /usr/local/share/dotnet && ls
2. sudo rm -rf dotnet

# delete the dotnet reference file at /etc/paths.d/dotnet
1. cd /etc/paths.d && ls
2. sudo rm dotnet

//-----------Add----------
 Console.WriteLine(2 + 2);

 4

 int num = 2;
            num++;
            Console.WriteLine(num);

3

//----------Calculator----------
// Simple
            // Prompt user for number
            Console.WriteLine("Enter a number: ");
            // Convert into integer
            int num1 = Convert.ToInt32(Console.ReadLine());
            // Prompt user for number
            Console.WriteLine("Enter a number: ");
            // Convert into integer
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Print total
            Console.WriteLine(num1 + num2);

Enter a number: 
100
Enter a number: 
1212
1312

// intermediate
using System;

namespace goodcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print prompt to enter numbers
            Console.WriteLine("Enter a number: ");
            // Use Console.ReadLine will return string and need to convert
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a operator: ");
            string op = Console.ReadLine();

            // Print prompt to enter numbers
            Console.WriteLine("Enter a number: ");
            // Use Console.ReadLine will return string and need to convert
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Figure what user entered
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }else if(op == "-")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}

Enter a number: 
10
Enter a operator: 
+
Enter a number: 
100
110

//----------Convert----------

            // Convert string into numbers
            int num = Convert.ToInt32("20");
            Console.WriteLine(num + 10);

30

//----------Print new line----------
Console.Write("Hello World") //Same line

Hello World!

Console.WriteLine("Hello\nWorld!"); //New Line

Hello
World!

//----------Print user input----------
            Console.Write("Enter your name: ");
            string name = Console.ReadLine(); // Pause and wait for user input, take the text and store in variable
            Console.Write("Enter your age: ");
            string age = Console.ReadLine(); 
            Console.WriteLine("Hi " + name + " your age is " + age);

Hi George your age is 10


//----------Print string store in variable----------
 string app = "My Learning App";
            Console.WriteLine(app);

My Learning App

//----------Convert string into upper case----------
//ToUpper, ToLower
string app = "My Learning App";
            Console.WriteLine(app.ToUpper());

MY LEARNING APP

//----------Check string word----------
// return true or false
string app = "My Learning App";
            Console.WriteLine(app.Contains("App"));

//----------Check character position---------
 string app = "My Learning App";
            Console.WriteLine(app[1]);

y

//----------Extract character----------
string app = "My Learning App";
            Console.WriteLine(app.Substring(0,2));

My

//----------Check index position-----------
string app = "My Learning App";
            Console.WriteLine(app.IndexOf("App"));

12

//----------Add extension----------
visual studio > extension
view > Manage NuGet Packages

//----------Create variables----------
// Store name
string vaccineName = "Pfizer";

// Store age
int noDose; // Declare variable
noDose = 1; // Assign value

// Add + to concatenate (append) value to text
Console.WriteLine("I have taken " + vaccineName);

// Replace age with variable
Console.WriteLine("This is my " + noDose + " dose.");

//----------Arrays---------
// Array index starts at 0
// Index
            // Create arrays store in luckyNumber container
            int[] luckyNumbers = {1,24,55,4,6,890};

            // Specify the index to access
            Console.WriteLine( luckyNumbers[4]);

6

// Update
            // // Create arrays of intergers and store in luckyNumber container
            int[] luckyNumbers = {1,24,55,4,6,890};

            // Specify the index to update
            luckyNumbers[2] = 20;
            Console.WriteLine(luckyNumbers[2]);
        }

20

//----------Methods---------
using System;

namespace methodscs
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            Console.WriteLine("Hello World!");
        }

        // void return 
        static void SayHi()
        {
            Console.WriteLine("Hello user");
        }
    }
}

Hello user
Hello World!

// String
using System;

namespace methodscs
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Milk", 21);
            SayHi("Cheese", 10);
            Console.WriteLine("Hello World!");
        }

        // void return 
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " your age is " + age);
        }
    }
}

Hello Milk your age is 21
Hello Cheese your age is 10
Hello World!

//----------Return----------
using System;

namespace returncs
{
    class Program
    {
        // Return method into caller
        static void Main(string[] args)
        {
            Console.WriteLine(cube(5));
            Console.WriteLine("Hello World!");
        }

        // Create method and return integer
        // num is number pass in
        static int cube(int num)
        {
            int result = num * num * num;
            return result; // Return value back to method
        }
    }
}

125
Hello World!

//----------if----------
using System;

namespace ifcs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFemale = true;
            bool isStudent = false;

            if (isFemale && isStudent)
            {
                Console.WriteLine("You are a female student.");
            }
            else if (isFemale && !isStudent)
            {
                Console.WriteLine("You are not a female student.");

            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}

You are not a female student.

// Compare

using System;

namespace ifcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(98, 89));

        }
        static int GetMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }

    }
}

98

using System;

namespace ifcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(98, 89, 989));

        }
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;

            }
            return result;
        }

    }
}

989

//----------Switch----------
using System;

namespace switchcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(0));
            // Switch is a special if and check statements
            Console.WriteLine("Hello World!");
        }
        static string GetDay(int dayNum) // Take number and convert into string
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    dayName = "Error";
                    break;

            }

            return dayName;
        }
    }
}

Sunday
Hello World!

//----------While---------
using System;

namespace whilecs
{
    class Program
    {
        static void Main(string[] args)
        {
            // While execute codes if condition is true
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++; // Add 1 into index
            }
        }

    }
}

1
2
3
4
5

//----------Do while---------
using System;

namespace whilecs
{
    class Program
    {
        static void Main(string[] args)
        {
            // While execute codes if condition is true
            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++; // Add 1 into index
            } while (index <= 5);
        }

    }
}

6

//----------Guessing game----------
using System;

namespace guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a variable
            string secretWord = "Mcdonald";
            string guess = "";

            // While to keep guessing
            while(guess != secretWord)
            {
                Console.WriteLine("Enter guess: ");
                guess = Console.ReadLine(); // Read input and store in guess variable

            }

            Console.WriteLine("Correct!"); // Print correct answer
            
        }
    }
}

Enter guess: 
aaa
Enter guess: 
Mcdonald
Correct!

// Limit guess
using System;

namespace guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a variable
            string secretWord = "Mcdonald";
            string guess = "";
            int guessCount = 0;
            // Guess limit
            int guessLimit = 3;
            bool outofGuesses = false;

            // While to keep guessing
            while(guess != secretWord && !outofGuesses)
            {
                // Allow user to guess if still have guesses
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter guess: ");
                    guess = Console.ReadLine(); // Read input and store in guess variable
                    guessCount++;

                }
                else
                {
                    outofGuesses = true;

                }
              
            }
            if(outofGuesses){
                Console.WriteLine("Incorrect");

            }
            else
            {
                Console.WriteLine("Correct!");

            }
                


        }
    }
}

wwww
Enter guess: 
wss
Enter guess: 
ass
Incorrect

//----------For----------
for(initialse; loop condition; executed every go through for loop)
// While and For loop same meaning below
using System;

namespace forcs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Track iterate of variable 
            int i = 1;
            while(i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            for(int i =1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}

1
2
3
4
5

// For loop with array
using System;

namespace forcs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array loop through and print 
            int[] luckyNumbers = { 1, 2, 33, 4, 5, 78 };
      
            for(int i =0; i < luckyNumbers.Length; i++) // luckyNumber.Length means how many elements inside array
            {
                Console.WriteLine(luckyNumbers[i]); // First time loop through is luckyNumber[0]...

            }
           
        }
    }
}


2
33
4
5
78