using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSuperbowlNamer
{
    public class TranslateEngine
    {
        // public method that does math
        public string DoWork(string numToTranslate)
        {
            // Console.WriteLine("Does this fix it?");
            if (numToTranslate == "1")
            {
                var firstTest = "I";
                return firstTest; 

            } else
            {
                var errorMessage = "It didn't work!";
                return errorMessage;
            }
        }

    }
}
