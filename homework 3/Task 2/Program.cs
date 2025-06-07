using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get user day of birth
            Console.Write("Enter Your Day Of Birth: ");
            byte day = Convert.ToByte(Console.ReadLine());

            // get user month of birth
            Console.Write("Enter Your Month Of Birth (In English): ");
            string month = Console.ReadLine();

            // store users zodiac here
            string zodiac = "";

            // figure out zodiac
            switch (month.ToLower())
            {
                case "january":
                    if (day <= 19)
                        zodiac = "Capricorn";
                    else
                        zodiac = "Aquarius";
                    break;
                case "february":
                    if (day <= 18)
                        zodiac = "Aquarius";
                    else
                        zodiac = "Pisces";
                    break;
                case "march":
                    if (day <= 20)
                        zodiac = "Pisces";
                    else
                        zodiac = "Aries";
                    break;
                case "april":
                    if (day <= 19)
                        zodiac = "Aries";
                    else
                        zodiac = "Taurus";
                    break;
                case "may":
                    if (day <= 20)
                        zodiac = "Taurus";
                    else
                        zodiac = "Gemini";
                    break;
                case "june":
                    if (day <= 20)
                        zodiac = "Gemini";
                    else
                        zodiac = "Cancer";
                    break;
                case "july":
                    if (day <= 22)
                        zodiac = "Cancer";
                    else
                        zodiac = "Leo";
                    break;
                case "august":
                    if (day <= 22)
                        zodiac = "Leo";
                    else
                        zodiac = "Virgo";
                    break;
                case "september":
                    if (day <= 22)
                        zodiac = "Virgo";
                    else
                        zodiac = "Libra";
                    break;
                case "october":
                    if (day <= 22)
                        zodiac = "Libra";
                    else
                        zodiac = "Scorpio";
                    break;
                case "november":
                    if (day <= 21)
                        zodiac = "Scorpio";
                    else
                        zodiac = "Sagittarius";
                    break;
                case "december":
                    if (day <= 21)
                        zodiac = "Sagittarius";
                    else
                        zodiac = "Capricorn";
                    break;
                default:
                    // log error
                    Console.WriteLine("[ERROR]: \"" + month + "\" Is Not Valid Month!");

                    // exit the program
                    return;
                    break;
            }

            // log zodiac sign
            Console.WriteLine(day + " " + month + " Is " + zodiac + ".");
        }
    }
}
