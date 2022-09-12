using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairingExcercise
{
    public class SortedStringArray
    {
         
        
        public SortedStringArray()
        { }

        public string SortedStrings(string inputStr)
        {
            inputStr = "how are you";
            string[] words = inputStr.Split(' ');
            Array.Sort(words);
            /// to get last charcher of string
            /// //
            /// word[0][word.length-1];
            string outputArr = String.Join(" ",words);
            //Console.WriteLine(outputArr);
            return outputArr;        
        }
    }
}
