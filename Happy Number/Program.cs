using System;

namespace Happy_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsHappy(1111111));
        }

        public static bool IsHappy(int n)
        {
            const int HAPPY_NUMBER = 1;
            bool isHappy = false;
            int sum = 0; // extracts first digit
            int extractMostRightDigit = n;
            int postExtraction = n;

            while (postExtraction != 0)
            {

                extractMostRightDigit %= 10;
                sum += (int)Math.Pow(extractMostRightDigit, 2);

                Console.WriteLine(sum);
                postExtraction /= 10;
                extractMostRightDigit = postExtraction;

                if (postExtraction == 0)
                {
                    extractMostRightDigit = sum;
                    postExtraction = sum;
                    sum = 0;
                    if (postExtraction == HAPPY_NUMBER)
                    {
                        isHappy = true;
                        break;
                    }
                    else if (postExtraction != HAPPY_NUMBER)
                    {
                        isHappy = false;
                        break;
                    }
                }

            }
            return isHappy;
        }
    }
}
