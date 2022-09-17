using static System.Console;
using System.Collections.Generic;

namespace Homework_Strings
{
    internal class Program
    {
        public static string removeCharIndex(string myString, int num)
        {
           
            return myString.Remove(num, 1);
        }
        public static string SwapFistAndLastChar(string str)
        {
            return str.Substring(str.Length - 1, 1) + str.Substring(1, str.Length-2) + str.Substring(0, 1);
        }
        public static string FistChar(string str)
        {
            return str.Substring(0, 1) + str.Substring(0, str.Length) + str.Substring(0, 1);
        }
        public static string ToLowerStr(string str)
        {
            return str.ToLower();
        }

        public static string LongestWord(string str)
        {

            var words = str.Split(" ");
            string longestWord = "";

            foreach (string word in words)
            {
                if(word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
               
            }
            return longestWord;
        }

        public static string ReverseWordsSentence(string str)
        {
            List<string> words = new List<string>(str.Split(" "));
            List<string> revWords = new List<string>();

            for(int i = words.Count-1; i >= 0; i--)
            {
                revWords.Add(words.ElementAt(i));
            }
            string reverseSentance = string.Join(" ", revWords);
            return reverseSentance;
        }

        public static string LastFourChar(string str)
        {
            return str.Substring(str.Length - 4)+ str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4);
        }
        public static bool MatchFirstWord(string str, string firstWord)
        {
            string [] newStr = str.Split(" ");

            if(firstWord != newStr[0])
            {
                return false;
            }
            return true;

        }
        public static void CheckHP()
        {
            string str = "PHP Tutorial";
            WriteLine(str.Substring(1,2)=="HP" ? str.Remove(1,2):str);
        }

        public static void ChekFirstTwoLetters()
        {
            string str = "PHP";
            if (str[0] == 'P' && str[1] == 'H')
            {
                WriteLine(str);
            }
        }
        public static bool CheckForW()
        {
            string str = "w3resource";
            if(str[0] == 'w' || str[1] == 'w' || str[2] == 'w')
            {
                return true;
            }
            return false;
        }
        public static string FirstFourCharToUpper()
        {
            string str = "w3r";
            str = str.Substring(0,3).ToUpper();
            return str;
        }
        public static void OddChar()
        {
            string myStr = "w3resource";
            string newStr = string.Empty;
            for (int i = 0; i < myStr.Length; i++)
            {
                if (i % 2 ==0)
                {
                    newStr += myStr[i];
                }               
            }
            Console.WriteLine(newStr);
        }
        static void Main(string[] args)
        {
            WriteLine(removeCharIndex("w3resource", 1));
            WriteLine(removeCharIndex("w3resource", 9));

            WriteLine(removeCharIndex("w3resource", 7));

            WriteLine(SwapFistAndLastChar("w3resource"));
            WriteLine(SwapFistAndLastChar("Python"));

            WriteLine(FistChar("The quick brown fox jumps over the lazy dog."));

            WriteLine(ToLowerStr("WRITE A C# SHARP PROGRAM TO DISPLAY THE FOLLOWING PATTERN USING THE ALPHABET"));
            
            WriteLine(LongestWord("Write a C# Sharp Program to display the following pattern using the alphabet."));
            
            WriteLine(ReverseWordsSentence("Display the pattern like pyramid using the alphabet."));

            WriteLine(LastFourChar("The quick brown fox jumps over the lazy dog."));

            WriteLine(MatchFirstWord("Hello how are you?", "Hello"));

            CheckHP();
            ChekFirstTwoLetters();
            WriteLine(CheckForW());
            WriteLine(FirstFourCharToUpper());
            OddChar();
        }
    }
}