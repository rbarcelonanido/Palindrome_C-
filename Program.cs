﻿using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a line of text:\n");
        string input = Console.ReadLine();

        // Filter out any characters that are not alphanumeric and transform the text to lowercase
        string cleanInput = RemoveNonAlphanumeric(input).ToLower();

        // Establish a queue for storing characters
        Queue charQueue = new Queue();

        // Place every character from the input string into the queue
        foreach (char c in cleanInput)
        {
            charQueue.Enqueue(c);
        }

        // Remove characters from the queue and compare them with the original string to verify if it's a palindrome
        bool isPalindrome = true;
        for (int i = cleanInput.Length - 1; i >= 0; i--)
        {
            if ((char)charQueue.Dequeue() != cleanInput[i])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("\nThe text you entered is a palindrome.");
        }
        else
        {
            Console.WriteLine("\nThe text you entered is not a palindrome.");
        }
    }

    // Function to remove non-alphanumeric characters from the input string
    static string RemoveNonAlphanumeric(string input)
    {
        string result = "";
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                result += c;
            }
        }
        return result;
    }
}
