using System;

namespace Ransom_Note
{
    /**
     * Given an      ransom note string and another string containing letters from all the magazines, write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false. 
    Each letter in the magazine string can only be used once in your ransom note. 
Note:
You may assume that both strings contain only lowercase letters. 

     * */
    // canConstruct("a", "b") -> false
    // canConstruct("aa", "ab") -> false
    // canConstruct("aabb", "aab") -> true

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanConstruct("fffbfg", "effjffggbffjdgbjjhhdegh"));
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            bool canConstruct = false;
            int count = 0;
            foreach (char ch in ransomNote.ToCharArray())
            {
                if (magazine.Contains(ch))
                {
                    count++;
                    magazine = magazine.Remove(magazine.IndexOf(ch), 1);
                }
            }
            if (count == ransomNote.Length)
            {
                canConstruct = true;
            }
            else
            {
                canConstruct = false;
            }
            return canConstruct;
        }
    }
}
