using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            char temp = Week2.Puzzle2(5, new char[] { });
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
        public static string Puzzle5(string input)
        {
            string result = "";
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
                result += counter.ToString();
            }
            return result;
        }
        public static int Puzzle6(int input)
        {
            return input * input;
        }
        public static int Puzzle7(params int[] args)
        {
            int result = 0;
            for (int i = 0; i < args.Length; i++)
            {
                result += args[i];
            }
            return result;
        }
        public static int Puzzle8(params int[] args)
        {
            int result = 0;
            for (int i = 0; i < args.Length; i++)
            {
                result += args[i];
            }
            return result;
        }
        public static int Puzzle9(params int[] args)
        {
            int result = 0;
            for (int i = 0; i < args.Length; i++)
            {
                foreach (var i1 in args)
                {
                    if (result < i1) result = i1;
                }
                
            }
            return result;
        }
        public static int Puzzle10(int input)
        {
            return input * -1;
        }


    }

    public class Week2
    {
        public static char Puzzle1(params object[] args)
        {
            try
            {
                return Char.Parse(args[args.Length - int.Parse(args[0].ToString()) - 1].ToString());
            }
            catch
            {
                return char.Parse(args[args.Length - 1].ToString());
            }
        }

        public static char Puzzle2(params object[] args)
        {
            try
            {
                //http://stackoverflow.com/questions/6438015/c-sharp-object-to-array
                object anArray = args[1];
                IEnumerable enumerable = anArray as IEnumerable;
                string temp = "";
                if (enumerable != null)
                {
                    foreach (object element in enumerable)
                    {
                        temp += element;
                    }
                }
                if (temp == "") return '\0';
                return temp[int.Parse(args[0].ToString())];

            }
            
            catch (IndexOutOfRangeException)
            {
                //http://stackoverflow.com/questions/6438015/c-sharp-object-to-array
                object anArray = args[1];
                IEnumerable enumerable = anArray as IEnumerable;
                string temp = "";
                if (enumerable != null)
                {
                    foreach (object element in enumerable)
                    {
                        temp += element;
                    }
                }
                char last = temp[temp.Length - 1];
                return last;
            }
            catch (FormatException)
            {
                return '\0';
            }



        }
    }
}
