using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = Week1.Puzzle4("abab");
            Console.WriteLine(temp);
            Console.ReadLine();
        }


    }

    public class Week1
    {
        public static string Puzzle1(string input)
        {
            string result="";
            if (input != null)
            {
                for (int i = input.Length; i != 0; i--)
                {
                    result += input[i-1];
                }
            }
            return result;
        }
        public static int Puzzle2(string input)
        {
            int result=0;
            //string[] alphabet = new string[] {"a", "b", "c"};
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            if (input == null) return result;
            foreach (char i in input)
            {
                int counter = 97;
                foreach (char c in alphabet)
                {
                    if (i == c)
                        break;
                    counter++;
                }
                result += counter;
            }
            return result;
        }
        //int result = 0;
        //    if (input == null) return result;
        //    return result;
        public static string Puzzle3(string input)
        {
            int shift = 3;
            string result="";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            if (input == null) return result;
            foreach (char i in input)
            {
                int letter = 0;
                foreach (char c in alphabet)
                {
                    if (i == c)
                    {
                        try
                        {
                            result += alphabet[letter + shift];
                        }
                        catch
                        {
                            result += alphabet[letter - 26 + shift];
                        }
                        
                    }
                    letter++;
                }
            }
            return result;
        }
        public static string Puzzle4(string input)
        {
            string result = "";
            if (input == null) return result;
            foreach (char c in input)
            {
                bool unique = true;
                foreach (char c1 in result)
                {
                    if (c1 == c) unique = false;
                    //result = result.Remove(result.Length - 1);
                }
                if(unique) result+= c;

            }
            return result;
        }
        //public static int Puzzle5(string input)
        //{

        //}
        //public static int Puzzle6(string input)
        //{

        //}
        //public static int Puzzle7(string input)
        //{

        //}
        //public static int Puzzle8(string input)
        //{

        //}
        //public static int Puzzle9(string input)
        //{

        //}
        //public static int Puzzle10(string input)
        //{

        //}


    }
}
