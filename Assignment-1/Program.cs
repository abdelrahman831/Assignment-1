
using System;
using System.Numerics;

class Assignment1{


    static void Main(string[] args)
    {
        #region Enter a number and print it
        // Write a program that allows the user to enter a number then print it.

        //Console.WriteLine("Enter a number and i will print it");
        //int inputNumber = Int32.Parse(Console.ReadLine());
        //Console.WriteLine("The number you typed is: " + inputNumber);

        #endregion

        #region String to integer with non-numeric characters
        // Write a C# program that converts a string to an integer, but the string contains non-numeric characters.
        // And mention what will happen.

        //string toConvert = "123f";
        //int convertedString = Int32.Parse(toConvert);
        //Console.WriteLine(convertedString);
        //
        // in this case a format exception will occur, if we do not handle it with try and catch

        #endregion

        #region Arithmetic operation with floating-point numbers
        // Write a C# program that performs a simple arithmetic operation with floating-point numbers.
        // And mention what will happen.

        //float num1 = 2.345f;
        //float num2 = 3.2456f;
        //float sum = num1 + num2;
        //Console.WriteLine("The sum between " + num1 + " and " + num2 + " is" + sum);


        #endregion

        #region Extract a substring
        // Write a C# program that extracts a substring from a given string.

        //Console.Write("Enter a string: ");
        //string inputString = Console.ReadLine();
        //Console.WriteLine("Insert start index");
        //int userInputStartIndex = int.Parse(Console.ReadLine());
        //userInputStartIndex = userInputStartIndex - 1;
        //Random ran = new Random();
        //int len = ran.Next(inputString.Length -1);
        //
        //if (inputString.Length > 0 && userInputStartIndex < inputString.Length && userInputStartIndex + len < inputString.Length)
        //{
        //    Console.WriteLine($"This is an example of a substring of the given string {inputString}: {inputString.Substring(userInputStartIndex-1,len)}");
        //}
        //else
        //{
        //    Console.WriteLine("Please provide better data");
        //}



        #endregion

        #region Assigning value type variables
        // Write a C# program that assigns one value type variable to another and modifies the value of one variable.
        // And mention what will happen.

        //int a = 10;
        //int b = a;
        //
        //// if we modify a we will modify a only a will be modified, but if we modifty b we will modify only b
        //a = 13;
        //Console.WriteLine($"a:{a}, b:{b}");
        //b = 4;
        //Console.WriteLine($"a:{a}, b:{b}");

        #endregion

        #region Assigning reference type variables
        // Write a C# program that assigns one reference type variable to another and modifies the object through one variable.
        // And mention what will happen.


        #endregion

        #region Concatenate two strings
        // Write a C# program that takes two string variables and prints them as one variable.
        //string inputStrOne = Console.ReadLine();
        //string inputStrTwo = Console.ReadLine();
        //
        //string MergedStrings = inputStrOne + inputStrTwo;
        //
        //Console.WriteLine($"Merged Strings: {MergedStrings}");
        #endregion

        #region Calculate simple interest
        // Write a program that calculates the simple interest given the principal amount, rate of interest, and time.
        // The formula for simple interest is Interest = (principal * rate * time) / 100.
        //Console.Write("Enter the principal amount: ");
        //double principal = double.Parse(Console.ReadLine());
        //
        //Console.Write("Enter the rate of interest (in %): ");
        //double rate = double.Parse(Console.ReadLine());
        //
        //Console.Write("Enter the time (in years): ");
        //double time = double.Parse(Console.ReadLine());
        //
        //double simpleInterest = (principal * rate * time) / 100;
        //Console.WriteLine($"The calculated Simple Interest is: {simpleInterest}");
        #endregion

        #region Calculate BMI
        // Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters.
        // The formula for BMI is BMI = (Weight) / (Height * Height).
        //Console.Write("Enter your weight in kilograms: ");
        //double weight = double.Parse(Console.ReadLine());
        //
        //Console.Write("Enter your height in meters: ");
        //double height = double.Parse(Console.ReadLine());
        //
        //double bmi = weight / (height * height);
        //Console.WriteLine($"Your Body Mass Index (BMI) is: {bmi:F2}");
        //
        //// Optional BMI categorization
        //if (bmi < 18.5)
        //{
        //    Console.WriteLine("You are underweight.");
        //}
        //else if (bmi >= 18.5 && bmi <= 24.9)
        //{
        //    Console.WriteLine("You have a normal weight.");
        //}
        //else if (bmi >= 25 && bmi <= 29.9)
        //{
        //    Console.WriteLine("You are overweight.");
        //}
        //else
        //{
        //    Console.WriteLine("You are obese.");
        //}
        #endregion

        #region Check temperature with ternary operator
        // Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good.
        // Assign the result in a variable then display the result.
        // Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot",
        // and anything else is "Just Good".

        //Console.Write("Enter the temperature in degrees: ");
        //int temperature = int.Parse(Console.ReadLine());
        //
        //string result = temperature < 10 ? "Just Cold" :
        //                temperature > 30 ? "Just Hot" : "Just Good";
        //
        //Console.WriteLine($"The temperature is: {result}");
        #endregion

        #region Display date in various formats
        // Write a program that takes the date from the user and displays it in various formats using string interpolation.
        // Ex:
        // Today's date: 20, 11, 2001
        // Today's date: 20 / 11 / 2001
        // Today's date: 20 - 11 - 2001

        //Console.Write("Enter a date (dd/MM/yyyy): ");
        //DateTime userDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        //
        //Console.WriteLine($"Today's date: {userDate:dd, MM, yyyy}");
        //Console.WriteLine($"Today's date: {userDate:dd / MM / yyyy}");
        //Console.WriteLine($"Today's date: {userDate:dd - MM - yyyy}");
        #endregion

    }

}