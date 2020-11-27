using System;

namespace Console_Application_Example_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // reverse a string
            string s = string.Empty;
            s = Console.ReadLine();
            char[] arr = s.ToCharArray();
            //Array.Reverse(arr); // Reverse a string without using loop
            //Console.WriteLine(arr);
            //using loop instead of .Reverse
            char[] lenghtarr = new char[s.Length];
            string slen = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                slen += arr[i];
            }
            Console.WriteLine(slen); 
            //Console.ReadLine();
            //Palindrome or not
            if (s == slen)
            {
                Console.WriteLine("Palindrome String");

            }
            else
            {
                Console.WriteLine("Not Palindrome String");

            }
            //Now, enter a string and count the number of capital letters, small letters, digits, spaces and special characters
            int number = 0;
            int capital = 0;
            int small = 0;
            int space = 0;
            int specialchar = 0;
            char[] charcount = s.ToCharArray();
            for (int j = 0; j < s.Length; j++)
            {
                if (charcount[j] >= 48 && charcount[j] <= 58)
                {
                    number += 1;
                }
                else if (charcount[j] >= 65 && charcount[j] <= 90)
                {
                    capital += 1;
                }
                else if (charcount[j] >= 97 && charcount[j] <= 122)
                {
                    small += 1;
                }
                else if (charcount[j] == 32)
                {
                    space += 1;
                }
            }
            Console.WriteLine(number);
            Console.WriteLine(capital);
            Console.WriteLine(small);
            Console.WriteLine(space);
            Console.ReadLine();
        }
    }
}
