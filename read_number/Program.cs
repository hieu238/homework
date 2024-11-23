using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number (0-999):");
        int number = int.Parse(Console.ReadLine());

        if(number < 0 || number > 999)
        {
            Console.WriteLine("Invalid number");
        }
        else
        {
            Console.WriteLine(NumberToWords(number));
        }
    }

    static string NumberToWords(int number)
    {
        if(number == 0)
        {
            return "Zero";
        }

        string words = "";
        if(number >= 100)
        {
            int hundreds = number / 100;
            number %= 100;
            words += GetOnes(hundreds) + "hundred";
            if(number > 0)
            {
                words += "and";
            }
        }

        if(number >= 20)
        {
            int tens = number / 10;
            number %= 10;
            words += GetTens(tens);
            if (number > 0)
            {
                words += " " + GetOnes(number);
            }
        }
        else if (number >= 10)
        {
            words += GetTeens(number);
        }
        else if(number > 0)
        {
            words += GetOnes(number);
        }
        return words;
        
    }

    static string GetOnes(int number)
    {
        switch(number)
        {
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "";
        }
    }
    static string GetTeens(int number)
    {
        switch(number)
        {
            case 10: return "ten";
            case 11: return "eleven";
            case 12: return "twelve";
            case 13: return "thirteen";
            case 14: return "fourteen";
            case 15: return "fifteen";
            case 16: return "sixteen";
            case 17: return "seventeen";
            case 18: return "eighteen";
            case 19: return "nineteen";
            default: return "";
        }
    }

    static string GetTens(int number)
    {
        switch(number)
        {
            case 2: return "twenty";
            case 3: return "thirty";
            case 4: return "fourty";
            case 5: return "fifty";
            case 6: return "sixty";
            case 7: return "seventy";
            case 8: return "eighty";
            case 9: return "ninety";
            default: return "";
        }
    }
}