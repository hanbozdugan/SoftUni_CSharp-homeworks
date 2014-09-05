using System;
class StringObjects
{
    static void Main()
    {
        string word1 = "Hello";
        string word2 = "World";
        object greeting = word1 + " " + word2;
        string castedGreeting = (string)greeting;
        Console.WriteLine("Print all variables:\n string word1 = {0}\n string word2 = {1}\n object greeting = {2}\n string castedGreeting = {3}", word1, word2, greeting, castedGreeting);
    }
}
