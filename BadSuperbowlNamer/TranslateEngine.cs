using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 // Ctrl + E, V duplicates a line if nothing is selected
 // Line Delete Ctrl+Shift+L

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
            // Create a dictionary made up of int and string key value pairs to store the romnan numnerals and their values
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

            // creating an empty string builder to store the roman numerals
            var thestring = new StringBuilder();

            // Loop through the dictionary
            {
                // For each key value pair in the dictionary 
                foreach (var num in RomanNumerals)
                {
                   // while the number I passed in is "greater than" or "equal to" the int key in the dictionary 
                   while (input >= num.Key)
                    {
                        // Add the value or roman numerals to the string we set above
                        thestring.Append(num.Value);
                        // And subtract which int key that it's on in the dictionary 
                        input -= num.Key;
                    }
                }
            }
            return thestring.ToString();
        }
    }
}
