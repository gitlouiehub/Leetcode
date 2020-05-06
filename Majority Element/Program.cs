using System;
using System.Collections.Generic;
namespace Majority_Element
{
    /**
     * Given an array of size n, find the majority element. 
     * The majority element is the element that appears more than ⌊ n/2 ⌋ times.
     * You may assume that the array is non-empty and the majority element always exist in the array.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MajorityElement(new int[] { 3, 2, 3 }));
        }

        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> container = new Dictionary<int, int>();
            int[,] x = new int[1, 2];
            x[0, 0] = nums[0];
            x[0, 1] = 1;

            foreach (int item in nums)
            {
                if (!container.ContainsKey(item))
                {
                    container.Add(item, 1);
                }
                else
                {
                    container[item]++;
                    if (container[item] > x[0,1])
                    {
                        x[0, 1] = container[item];
                        x[0,0] = item;
                    }
                }
            }
            return x[0,0];
        }
    }
}
