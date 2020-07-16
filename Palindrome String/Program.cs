using System;

namespace Palindrome_String
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo userAnswer;
            bool caseSensitive = false;

            do
            {
                Console.Clear();

                Console.Write("Do you want to Enable the Case Sentitive? [Y or N] ");
                userAnswer = Console.ReadKey();
                if(userAnswer.Key == ConsoleKey.Y)
                {
                    caseSensitive = true;
                    Console.WriteLine("\n\nCase Sensitive > Enabled\n");
                }
                else
                {
                    caseSensitive = false;
                    Console.WriteLine("\n\nCase Sensitive > Disabled\n");
                }
                
                Console.Write("Insert a string: ");
                string userString = Console.ReadLine();

                if(caseSensitive)
                    Console.WriteLine("\n\n\t{0}\n\n", IsPalindrome(userString));
                else
                    Console.WriteLine("\n\n\t{0}\n\n", IsPalindrome(userString.ToLower()));

                Console.Write("Do you want to test another string? [Y or N] ");
                userAnswer = Console.ReadKey();

            } while (userAnswer.Key == ConsoleKey.Y);
        }

        static public string IsPalindrome(string s)
        {
            if (s.Length > 1)
            {
                int loverIndex = 0;
                int upperIndex = s.Length - 1;

                while (loverIndex < upperIndex)
                {
                    if (s[loverIndex] == s[upperIndex])
                    {
                        loverIndex++;
                        upperIndex--;
                    }
                    else
                        return string.Format("The string {0} is not Palindrome.", s);
                }
                return string.Format("The string {0} is Palindrome.", s);
            }
            else
                return string.Format("The string must be more than 1 character long.");
        }
    }
}