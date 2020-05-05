using System;
using System.Collections.Generic;

namespace First_Unique_Character_in_a_String
{
    /*
     * 
     * Given a string, find the first non-repeating character in it and return it's index. 
     * If it doesn't exist, return -1. 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqChar("aadadaadc"));
        }
        public static int FirstUniqChar(string s)
        {
            int pos = -1;
            int length = s.Length;
            
            if (length == 1)
                pos = 0;
            else if(string.IsNullOrEmpty(s))
            {
                pos = -1;
            }
            else
            {
                HashSet<char> container = new HashSet<char>();
                for (int i = 0; i < length; i++)
                {
                    if (!container.Contains(s[i]) && !s.Substring(i+1).Contains(s[i]))
                    {
                        pos = s.IndexOf(s[i]);
                        break;
                    }
                    else
                    {
                        container.Add(s[i]);
                    }
                }
            }
            return pos;
        }
    }
}
