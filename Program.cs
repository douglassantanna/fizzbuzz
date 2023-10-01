// See https://aka.ms/new-console-template for more information
using System.Text;

Console.Clear();

RemoveBracketsFromString();
// string word = "douglas";
// bool result = IsPalindrome(word);

// if (result)
// {
//     Console.WriteLine($"{word} is a palindrome.");
// }
// else
// {
//     Console.WriteLine($"{word} is not a palindrome.");
// }

void RemoveBracketsFromString()
{
    var word = "[myWord]";
    Console.WriteLine($"word with brackets: {word}");
    var wordWithoutBrackets = word.Replace("[", "").Replace("]", "");

    Console.WriteLine($"word without brackets: {wordWithoutBrackets}");
}

bool IsPalindrome(string str)
{
    int start = 0;
    int end = str.Length - 1;

    while (start < end)
    {
        if (str[start] != str[end])
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}

void FizzBuzz()
{
    for (int i = 1; i <= 100; i++)
    {
        var response = "";
        if (i % 3 == 0 && i % 5 == 0)
        {
            response += "FizzBuzz";
            Console.WriteLine($"{i} - {response}");
        }
        else if (i % 3 == 0)
        {
            response += "Fizz";
            Console.WriteLine($"{i} - {response}");
        }
        else if (i % 5 == 0)
        {
            response += "Buzz";
            Console.WriteLine($"{i} - {response}");
        }
        else
        {
            response += i.ToString();
            Console.WriteLine($"{i}");
        }
    }
}

void DateFizzBuzz()
{
    for (int day = 1; day <= 30; day++)
    {
        bool fizz = day % 3 == 0;
        bool buzz = day % 5 == 0;

        if (fizz && buzz)
        {
            Console.WriteLine($"{day}: FizzBuzz");
        }
        else if (fizz)
        {
            Console.WriteLine($"{day}: Fizz");
        }
        else if (buzz)
        {
            Console.WriteLine($"{day}: Buzz");
        }
        else
        {
            Console.WriteLine($"{day}: ");
        }
    }
}

void StringReverseWithLinq()
{
    string originalString = "Hello, world!";
    string reversedString = new string(originalString.Reverse().ToArray());

    Console.WriteLine("Original String: " + originalString);
    Console.WriteLine("Reversed String: " + reversedString);
}

void StringReverseWithStringBuilder()
{
    string originalString = "Hello, world!";
    StringBuilder sb = new StringBuilder();

    for (int i = originalString.Length - 1; i >= 0; i--)
    {
        sb.Append(originalString[i]);
    }

    string reversedString = sb.ToString();

    Console.WriteLine("Original String: " + originalString);
    Console.WriteLine("Reversed String: " + reversedString);
}