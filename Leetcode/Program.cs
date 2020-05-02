using System;
using System.Text;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SingleNumber(new int[] { 4, 1, 2, 1, 2 }));

        }
        public static int SingleNumber(int[] nums)
        {


            int temp = 0;
            int counter = 0; // 
            for (int j = 0; j < nums.Length; j++) // iterate the length of the whole array
            {
                // swap element to be tested at position it to the beginning
                temp = nums[0]; // 
                nums[0] = nums[j]; //
                nums[j] = temp;
                for (int i = 1; i < nums.Length; i++) // test the first element with the rest of the array
                {
                    if (nums[0] == nums[i]) // if we find a number equal to each other, 
                    {
                        // swap back to it's original array
                        temp = nums[j]; 
                        nums[j] = nums[0]; //
                        nums[0] = temp;
                        counter = 0;
                        break; // out of inner loop
                    }
                    counter++;
                }
                if (counter == nums.Length) // if the counter equals the length then that element passed
                {
                    break; // out of outer loop
                }
            }
            
            return nums[0];
        }

    }
}
