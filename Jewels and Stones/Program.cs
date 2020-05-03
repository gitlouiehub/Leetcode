using System;

namespace Jewels_and_Stones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumJewelsInStones("bcd", "cbs"));
        }

        public static int NumJewelsInStones(string J, string S)
        {
            int count = 0;
            if (S.Length <= 50 & J.Length <= 50)
            {
                for (int i = 0; i < J.Length; i++)
                {
                    string s = J.Substring(i, 1);
                    while (S.Contains(J.Substring(i, 1)))
                    {
                        count++;
                        S = S.Remove(S.IndexOf(s), 1);
                    }
                }
            }
            else
            {
                count = 0;
            }
            return count;
        }
    }
}
