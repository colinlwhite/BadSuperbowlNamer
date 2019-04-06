using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSuperbowlNamer
{
    public class TranslateEngine
    {
        // public method that does math
        // Recursion Example
        public string DoWork(int numToTranslate)
        {
            if ((numToTranslate < 0) || (numToTranslate > 3999)) throw new ArgumentOutOfRangeException("please enter a value betwheen 1 and 3999");
            if (numToTranslate < 1) return string.Empty;
            if (numToTranslate >= 1000) return "M" + DoWork(numToTranslate - 1000);
            if (numToTranslate >= 900) return "CM" + DoWork(numToTranslate - 900);
            if (numToTranslate >= 500) return "D" + DoWork(numToTranslate - 500);
            if (numToTranslate >= 400) return "CD" + DoWork(numToTranslate - 400);
            if (numToTranslate >= 100) return "C" + DoWork(numToTranslate - 100);
            if (numToTranslate >= 90) return "XC" + DoWork(numToTranslate - 90);
            if (numToTranslate >= 50) return "L" + DoWork(numToTranslate - 50);
            if (numToTranslate >= 40) return "XL" + DoWork(numToTranslate - 40);
            if (numToTranslate >= 10) return "X" + DoWork(numToTranslate - 10);
            if (numToTranslate >= 9) return "IX" + DoWork(numToTranslate - 9);
            if (numToTranslate >= 5) return "V" + DoWork(numToTranslate - 5);
            if (numToTranslate >= 4) return "IV" + DoWork(numToTranslate - 4);
            if (numToTranslate >= 1) return "I" + DoWork(numToTranslate - 1);
            throw new ArgumentOutOfRangeException("error");
        }

    }
}
