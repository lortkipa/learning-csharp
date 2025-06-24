using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get input
            Console.Write("Enter String: ");
            string str = Console.ReadLine();

            Console.Write("Enter Shift (Negative Number For Left Shift): ");
            short shift = Convert.ToInt16(Console.ReadLine());

            // calculate result
            string encrypted = EnchryptString(str, shift);
            string decrypted = DecryptString(encrypted, shift);

            // log result
            Console.WriteLine($"Enchrpyted String: \"{encrypted}\"");
            Console.WriteLine($"Descrypted String: \"{decrypted}\"");
        }

        static string EnchryptString(string str, int shift)
        {
            char[] cipheredStr = new char[str.Length];

            // shift characters
            const short letterCount = 26;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    //cipheredStr[i] = (char)(str[i] + shift); // თავიდან ეს ვსაცე მაგრამ თუკი str[i] არის მაგალითად Z, shiftის მიმატებით გადაცდება ანბანის ასოებს და რაღაც სხვა სიმბოლო იქნება
                    char offset = char.IsUpper(str[i]) ? 'A' : 'a';
                    cipheredStr[i] = (char)(((str[i] - offset + shift + letterCount) % letterCount) + offset);
                }
                else
                {
                    cipheredStr[i] = str[i];
                }
            }

            return new string(cipheredStr);
        }

        static string DecryptString(string str, int shift)
        {
            // logic is to reverse result
            return EnchryptString(str, -shift);
        }
    }
}
