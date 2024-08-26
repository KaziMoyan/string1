using System;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

public class MyClass
{
    public static void Main(string[] args)
    {
        // string text = "hello everyone I am Moyeen ";
        // Console.WriteLine($"Length of string: {text.Length}");
        // Console.WriteLine($"First character of string: {text[0]}");

        // bool isEmpty = string.IsNullOrEmpty(text);
        // Console.WriteLine($"String is empty: {isEmpty}");

        // string insertedText = text.Insert(0, "hi ");
        // Console.WriteLine($"Inserted Text: {insertedText}");

        // // Correct Split usage with space delimiter
        // var words = text.Split(' ');

        // // Joining with space for demonstration
        // Console.WriteLine($"Joined Words: {string.Join(" ", words)}");
        
        // // Correct the foreach loop variable type to `string`
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        // // Correct usage of Remove to demonstrate removing characters starting at index 4
        // string removeText = text.Remove(4);
        // Console.WriteLine($"Removed Text (starting at index 4): {removeText}");

        // // Replace text example corrected - using Replace instead of Remove
        // string replacedText = text.Replace("Moyeen", "John");
        // Console.WriteLine($"Replaced Text: {replacedText}");

        // bool isMoyeen = text.Contains("Moyeen");
        // Console.WriteLine($"Contains 'Moyeen': {isMoyeen}");

        // string reversedString = new string(text.Reverse().ToArray());
        // Console.WriteLine($"Reversed String: {reversedString}");

        // string upper = text.ToUpper();
        // Console.WriteLine($"Upper Case: {upper}");

        // string lower = text.ToLower();
        // Console.WriteLine($"Lower Case: {lower}");

        // string trimStr = text.Trim();
        // Console.WriteLine($"Trimmed String: {trimStr}");

        // string subsStr = text.Substring(7);
        // Console.WriteLine($"Substring (from index 7): {subsStr}");

        // string subsStr2 = text.Substring(6, 5);
//         // Console.WriteLine($"Substring (from index 6, length 5): {subsStr2}");
// string input = "Hello 123 world";

//         int vowelCount = input.Count(c => "aeiouAEIOU".Contains(c));
//         int consonantCount = input.Count(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c));
//         int digitCount = input.Count(char.IsDigit);
//         int specialCharacterCount = input.Count(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));
//         int whiteSpaceCount = input.Count(char.IsWhiteSpace);

//         // Corrected the Split method to split by spaces and removed empty entries
//         int wordCount = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

//         Console.WriteLine($"Vowels: {vowelCount}");
//         Console.WriteLine($"Consonants: {consonantCount}");
//         Console.WriteLine($"Number of digits: {digitCount}");
//         Console.WriteLine($"Number of special characters: {specialCharacterCount}");
//         Console.WriteLine($"Number of white spaces: {whiteSpaceCount}");
//         Console.WriteLine($"Number of words: {wordCount}");
int[] oarray = { 1, 2, 34, 5 };
        int[] moarray = oarray;  // moarray references the same array as oarray

        Console.WriteLine($"Original array before modification:");
        PrintArray(oarray);

        // Demonstrating that oarray and moarray are the same by modifying moarray
        moarray[0] = 100;

        Console.WriteLine($"Original array after modification:");
        PrintArray(oarray);

        Console.WriteLine($"Modified array:");
        PrintArray(moarray);
    }

    public static void PrintArray(int[] numbers)
    {
        foreach (var item in numbers)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}
