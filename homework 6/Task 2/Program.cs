using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task_2
{
    internal class Program
    {
        static void StartTask(int count)
        {
            Console.WriteLine($"--------------------{count}--------------------");
        }
        static void Main(string[] args)
        {
            /*
             * 
             * 
             * 
             * წინაზეც გვქონდა ეს დავალება და იქ ჩაშენებული მეთოდის გამოუყენებლად გავაკეთე, აქ 
             * ძირითადად ჩაშენებულით.
             * 
             * 
             * 
             */

            #region Task 1
            StartTask(1);
            {
                // get string
                Console.Write("Enter String: ");
                string str = Console.ReadLine();

                int strLength = 0;

                // calculate str length
                foreach (char c in str)
                {
                    strLength++;
                }

                // log result
                Console.WriteLine($"String \"{str}\" Length Is: {strLength}");
            }
            #endregion

            #region Task 2
            StartTask(2);
            {
                // get string
                Console.Write("Enter String: ");
                string str = Console.ReadLine();

                // calculate word count
                int wordCount = str.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Length;

                // log result
                Console.WriteLine($"Wordd Count In String \"{str}\" Is: {wordCount}");
            }
            #endregion

            #region Task 3
            StartTask(3);
            {
                // get input
                Console.Write("Enter Text: ");
                char[] text = Console.ReadLine().ToCharArray();

                // parameters to track down
                int letterCount = 0;
                int digitCount = 0;
                int specialSymbolCount = 0;

                // loop text characters
                for (int i = 0; i < text.Length; i++)
                {
                    // emty space does not fit in any parameter, so quit checking if its found
                    if (text[i] == ' ')
                        continue;

                    // look in wich parameter current char fits in depending on its value (check using ansi codes)
                    /* Ansi Table */
                    // A - 65; Z - 90;
                    // a - 97; z - 122;
                    // 0 - 48; 9 - 57;

                    // check if current char is letter
                    if ((text[i] >= 65 && text[i] <= 90)
                        ||
                        (text[i] >= 97 && text[i] <= 122))
                    {
                        letterCount++;
                    }
                    // check if current char is number (digit)
                    else if (text[i] >= 48 && text[i] <= 57)
                    {
                        digitCount++;
                    }
                    // if current chart is not digit and letter, its special character
                    else
                    {
                        specialSymbolCount++;
                    }
                }

                // log result
                Console.WriteLine($"Letter: {letterCount}; Digit: {digitCount}; Special Symbol: {specialSymbolCount};");
            }
            #endregion

            #region Task 4
            StartTask(4);
            {
                // get string
                Console.Write("Enter Text: ");
                string str = Console.ReadLine();

                // figure out if its palindrom or not
                string reversed = new string(str.Reverse().ToArray());
                bool isPalindrome = str.Equals(reversed);

                // log result
                Console.WriteLine($"String \"{str}\" is {(isPalindrome ? "" : "Not ")}Palindrome");
            }
            #endregion

            #region Task 5
            StartTask(5);
            {
                // get user input
                Console.Write("Enter Text: ");
                string text = Console.ReadLine();

                // save sorted strings here
                char[] sortedTextArr = text.ToCharArray();
                char[] reversedSortedTextArr = text.ToCharArray();

                // bubble sort
                for (byte i = 0; i < sortedTextArr.Length; i++)
                {
                    for (byte j = 0; j < sortedTextArr.Length - i; j++)
                    {
                        if (sortedTextArr[i] < sortedTextArr[j])
                        {
                            char temp = sortedTextArr[i];
                            sortedTextArr[i] = sortedTextArr[j];
                            sortedTextArr[j] = temp;
                        }
                    }
                }

                // reverse bubble sort
                for (byte i = 0; i < reversedSortedTextArr.Length; i++)
                {
                    for (byte j = 0; j < reversedSortedTextArr.Length - i; j++)
                    {
                        if (reversedSortedTextArr[i] > sortedTextArr[j])
                        {
                            char temp = reversedSortedTextArr[i];
                            reversedSortedTextArr[i] = reversedSortedTextArr[j];
                            reversedSortedTextArr[j] = temp;
                        }
                    }
                }

                // log result
                Console.WriteLine($"Text Sorted Is: {new string(sortedTextArr)}");
                Console.WriteLine($"Text Reversed Sorted Is: {new string(reversedSortedTextArr)}");
            }
            #endregion

            #region Task 6
            StartTask(6);
            {
                // get input
                Console.Write("Enter Text: ");
                char[] text = Console.ReadLine().ToCharArray();

                // loop text characters
                for (int i = 0; i < text.Length; i++)
                {
                    // translate upper case chars into lower case and lower case into upper!
                    if (char.IsUpper(text[i]))
                        text[i] = char.ToLower(text[i]);
                    else
                        text[i] = char.ToUpper(text[i]);
                }

                // log result
                Console.WriteLine($"Updated String: \"{new string(text)}\"");
            }
            #endregion

            #region Task 7
            StartTask(7);
            {
                // correct sign in params
                const string correct_username = "abcd";
                const string correct_password = "1234";

                // track if user signed in or not
                bool userSignedIn = false;

                // user have 3 tries
                for (byte i = 0; i < 3; i++)
                {
                    // get input
                    Console.WriteLine("----- Sign In -----");
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();

                    // check result
                    if (username == correct_username && password == correct_password)
                    {
                        // store result
                        userSignedIn = true;

                        // break loop
                        break;
                    }
                }

                // log result
                switch (userSignedIn)
                {
                    case false:
                        Console.WriteLine("Username Or Password You Have Entered Is Wrong.");
                        break;
                    case true:
                        Console.WriteLine("You Have Logged In Successfully.");
                        break;
                }
            }
        }
        #endregion
    }
}