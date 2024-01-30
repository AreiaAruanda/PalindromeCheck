using System;
using System.ComponentModel.Design;

Console.Write("Please enter a word: ");
string word = Console.ReadLine();
word= word.ToLower();

bool palindromecheck = false;

for(int i = 0; i < word.Length; i++)
    {
    if (word[i]!= word[word.Length - 1 - i])
    {
        palindromecheck = false;
        break;
    }
    else if(word[i] == word[word.Length - 1 - i])
    {
        palindromecheck = true;
    }
    }

if (palindromecheck)
{
    Console.WriteLine($"'{word}' is a palindrome.");
}
else if (!palindromecheck)
{
    Console.WriteLine($"'{word}' is not a palindrome.");
}


    