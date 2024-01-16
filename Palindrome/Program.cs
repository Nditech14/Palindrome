using System;
using System.Runtime.InteropServices;
namespace CheckPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This program indicate whether a palindrome or not:");
            string word = Console.ReadLine();
            if(IsPalindrome(word))
            {
                Console.WriteLine($"{word} is a palindrome");
            }else
            {
                Console.WriteLine($"{word} is not a palindrome");
            }
        }
        public static bool IsPalindrome(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            var rev = new string(chars);
            return input.Equals(rev, StringComparison.OrdinalIgnoreCase);
        }
    }
}