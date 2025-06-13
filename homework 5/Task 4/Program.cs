using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void StartTask(short taskNum)
        {
            Console.WriteLine($"-------------------- {taskNum} ---------------------");
        }

        static void Main(string[] args)
        {
            #region SubTask 2
            StartTask(2);
            {
                // get input
                Console.Write("Enter Text: ");
                char[] text = Console.ReadLine().ToCharArray();

                // track words in text
                int wordCount = 0;

                // track if current character is in word
                bool inWord = false;

                // loop text characters
                for (int i = 0; i < text.Length; i++)
                {
                    // if current character is whitespace, we are not in word
                    if (text[i] == ' ')
                    {
                        inWord = false;
                    }
                    // if current character is not whitespace and inWord is false, we are now in word, so 
                    // increase founded word count
                    else if (!inWord)
                    {
                        inWord = true;
                        wordCount++;
                    }
                }

                // log word count
                Console.WriteLine($"Word Found In Text: {wordCount}");
            }
            #endregion

            #region SubTask 3
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

            #region SubTask 4
            StartTask(4);
            {
                // get user input
                Console.Write("Enter Text: ");
                string text = Console.ReadLine();

                // reverse string
                string reverseText = "";
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reverseText += text[i];
                }

                // check and store if text is palindrom
                bool isPalindrom = text == reverseText;

                // log result
                Console.WriteLine($"Text \"{text}\" " + (isPalindrom ? "Is " : "Is Not ") +
                    "Palindrom");
            }
            #endregion

            #region SubTask 5
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

            #region SubTask 6
            StartTask(6);
            {
                // get user input
                Console.Write("Enter Text: ");
                char[] textArr = Console.ReadLine().ToCharArray();

                /* Ansi Table */
                // A - 65; Z - 90
                // a - 97; z - 122

                // calculate offset to lower to upper case ansi code (or reverse)
                short offset = 97 - 65;

                // loop text characters
                for (int i = 0; i < textArr.Length; i++)
                {
                    // check if char is lower or upper case 
                    if (textArr[i] >= 65 && textArr[i] <= 90)
                    {
                        // calculate and store lower case char
                        textArr[i] = (char)(textArr[i] + offset);
                    }
                    else if (textArr[i] >= 97 && textArr[i] <= 122)
                    {
                        // calculate and store upper case char
                        textArr[i] = (char)(textArr[i] - offset);
                    }
                }

                // convert char array into string
                string text = new string(textArr);

                // log result
                Console.WriteLine($"Updated String: {text}");
            }
            #endregion

            #region SubTask 7
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
