using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WorkingWithFiles
{
    // If you need to reference the files that are used for the tests, they are located in the
    // Solution Explorer inside the folder 'TextFiles'.

    public static class WorkingWithFiles
    {
        // 1- Write a method that reads a text file and returns the number of words. Ex. The file
        // contains, "The dog ran away from home." The method should return "6" the number of words
        // contained in the file. Return "0" for the word count if the file is empty.
        // .Trim() might be useful in this situation.
        public static int WordCount(string fileName)
        {
            string[] strWords;
            StreamReader strRead = new StreamReader(fileName);
            int intWords = 0;
            while(strRead.Peek() != -1)
            {
                strWords = strRead.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                intWords += strWords.Length;
            }
            return intWords;
        }

        // 2- Write a method that reads a text file and returns the longest word in the file. Ex.
        // The file contains, "The dog named Maximus ran away from home." The method should return
        // "Maximus" the longest word contained in the file. Return "File is Empty" if the file is empty.
        // .Trim() might be useful in this situation.
        public static string LongestWord(string fileName)
        {
            string strMax = "";
            string[] strWords;
            StreamReader strRead = new StreamReader(fileName);
            while(strRead.Peek() != -1)
            {
                strWords = strRead.ReadLine().Split(' ');
                foreach (string str in strWords)
                {
                    if (str.Length > strMax.Length)
                    {
                        strMax = str;
                    }
                }
            }
            
            if (strMax == "")
            {
                return "File is Empty";
            }
            else
            {
                return strMax;
            }
        }
    }

    public static class Program
    {
        public static void Main()
        {

        }
    }
}
