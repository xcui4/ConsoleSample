using System;

namespace BullsAndCows
{
    public class Program
    {

        static void Main(string[] args)
        {
            var nums = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            KnuthShuffle(ref nums);
            var chosenNum = new int[4];
            Array.Copy(nums, chosenNum, 4);

            Console.WriteLine("Your Guess ?");
            while (!game(Console.ReadLine(), chosenNum))
            {
                Console.WriteLine("Your next Guess ?");
            }

            Console.ReadKey();
        }

        public static void KnuthShuffle<T>(ref T[] array)
        {
            var random = new System.Random();
            for (var i = 0; i < array.Length; i++)
            {
                var j = random.Next(array.Length);
                var temp = array[i]; array[i] = array[j]; array[j] = temp;
            }
        }

        public static bool game(string guess, int[] num)
        {
            var guessed = guess.ToCharArray();
            var bullsCount = 0;
            var cowsCount = 0;

            if (InvalidLengthChars(guessed)) return false;

            if (ContainsInvalidChars(guessed)) return false;


            bullsCount = Parse(num, bullsCount, guessed, ref cowsCount);
        

            if (bullsCount == 4)
            {
                Console.WriteLine("Congratulations! You have won!");
                return true;
            }
            Console.WriteLine("Your Score is {0} bulls and {1} cows", bullsCount, cowsCount);
            return false;
        }

        private static int Parse(int[] num, int bullsCount, char[] guessed, ref int cowsCount)
        {
            for (var i = 0; i < 4; i++)
            {
                var curguess = (int) char.GetNumericValue(guessed[i]);

                if (curguess == num[i])
                {
                    bullsCount++;
                }
                else
                {
                    cowsCount = CalculateCowsCount(num, cowsCount, curguess);
                }
            }
            return bullsCount;
        }

        private static bool InvalidLengthChars(char[] guessed)
        {
            if (guessed.Length != 4)
            {
                Console.WriteLine("Not a valid guess.");
                return true;
            }
            return false;
        }

        private static bool ContainsInvalidChars(char[] guessed)
        {
            for (var i = 0; i < 4; i++)
            {
                var curguess = (int) char.GetNumericValue(guessed[i]);
                if (curguess < 1 || curguess > 9)
                {
                    Console.WriteLine("Digit must be ge greater 0 and lower 10.");
                    return true;
                }
            }
            return false;
        }

        private static int CalculateCowsCount(int[] num, int cowsCount, int curguess)
        {
            for (var j = 0; j < 4; j++)
            {
                if (curguess == num[j])
                    cowsCount++;
            }
            return cowsCount;
        }
    }
}
