using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSuperbowlNamer
{
    // public class TranslateEngine
    // {
        // public method that does math
        // Recursion Example
        // public string DoWork(int numToTranslate)
        //{
            // if ((numToTranslate < 0) || (numToTranslate > 3999)) throw new ArgumentOutOfRangeException("please enter a value betwheen 1 and 3999");
            // if (numToTranslate < 1) return string.Empty;
            // if (numToTranslate >= 1000) return "M" + DoWork(numToTranslate - 1000);
            // if (numToTranslate >= 900) return "CM" + DoWork(numToTranslate - 900);
            // if (numToTranslate >= 500) return "D" + DoWork(numToTranslate - 500);
            // if (numToTranslate >= 400) return "CD" + DoWork(numToTranslate - 400);
            // if (numToTranslate >= 100) return "C" + DoWork(numToTranslate - 100);
            // if (numToTranslate >= 90) return "XC" + DoWork(numToTranslate - 90);
            // if (numToTranslate >= 50) return "L" + DoWork(numToTranslate - 50);
            // if (numToTranslate >= 40) return "XL" + DoWork(numToTranslate - 40);
            // if (numToTranslate >= 10) return "X" + DoWork(numToTranslate - 10);
            // if (numToTranslate >= 9) return "IX" + DoWork(numToTranslate - 9);
            // if (numToTranslate >= 5) return "V" + DoWork(numToTranslate - 5);
            // if (numToTranslate >= 4) return "IV" + DoWork(numToTranslate - 4);
            // if (numToTranslate >= 1) return "I" + DoWork(numToTranslate - 1);
            // throw new ArgumentOutOfRangeException("error");
        //}

    //}


    public class TranslateEngine
    {
        public string DoWork(int input)
        {
            // Create a dictionary made up of int and string
            Dictionary<int, string> RomanNumerals = new Dictionary<int, string>();
            RomanNumerals.Add(1000, "M");
            RomanNumerals.Add(900, "CM");
            RomanNumerals.Add(500, "D");
            RomanNumerals.Add(400, "CD");
            RomanNumerals.Add(100, "C");
            RomanNumerals.Add(90, "XC");
            RomanNumerals.Add(50, "L");
            RomanNumerals.Add(40, "XL");
            RomanNumerals.Add(10, "X");
            RomanNumerals.Add(9, "IX");
            RomanNumerals.Add(5, "V");
            RomanNumerals.Add(4, "IV");
            RomanNumerals.Add(1, "I");

            // use int parse change the string parameter to an int and save as int to loop over
            // int number = int.Parse(input);
            // empty string builder 
            var thestring = new StringBuilder();
            // while value passed in is greater than 0 
            // while (input > 0)
            // foreach loop in the dictionary
            {
                foreach (var num in RomanNumerals)
                {
                   while (input >= num.Key)
                    {
                        thestring.Append(num.Value);
                        input -= num.Key;
                    }
                    // return thestring.ToString();
                }
                // return thestring.ToString();
            }
            return thestring.ToString();
        // if the number we passed in is greater than or equal to the key in the dictionary / int
        // add/ append its pair to the string builder we created up aboce
        // subtract -= from the number we're checking and add it to the string? 
        // return the string
       //  return thestring.ToString();
        }
    }
}
