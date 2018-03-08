using System;
using System.Linq;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool canContinue = true;

            Console.WriteLine("Please enter a number");
            string userInputOne = Console.ReadLine();

            Console.WriteLine("Please enter a second number");
            string userInputSecond = Console.ReadLine();

            int result1;
            bool canParse1 = Int32.TryParse(userInputOne, out result1);

            int result2;
            bool canParse2 = Int32.TryParse(userInputSecond, out result2);

            if (canParse1 == false || canParse2 == false)
            {
                canContinue = false;
            }

            if (canContinue)
            {

                char[] firstCharArray = userInputOne.ToCharArray();
                char[] secondCharArray = userInputSecond.ToCharArray();

                int[] firstSequence = firstCharArray.Select(c => Convert.ToInt32(c.ToString())).ToArray();
                int[] secondSequence = secondCharArray.Select(c => Convert.ToInt32(c.ToString())).ToArray();


                if (firstSequence.Length != secondSequence.Length)
                {
                    canContinue = false;
                }

                if (canContinue)
                {
                    int sum1 = 0;
                    int sum2 = 0;

                    for (int index1 = 0; index1 < firstSequence.Length; index1++)
                    {
                        for (int index2 = 0; index2 < secondSequence.Length; index2++)
                        {
                            if (sum1 == 0)
                            {
                                if (index1 == index2)
                                {
                                    sum1 = firstSequence[index1] + secondSequence[index2];
                                    break;
                                }
                            }
                            else
                            {
                                if (index1 == index2)
                                {
                                    sum2 = firstSequence[index1] + secondSequence[index2];
                                }
                            }
                        }
                    }
                    if (sum1 == sum2)
                    {
                        Console.WriteLine("YAY");
                    }
                    else
                    {
                        Console.Write("Kuss Ahmar");
                    }
                }
                else
                {
                    Console.WriteLine("You did not enter the same number length");
                }
            }
            else
            {
                Console.WriteLine("You did not enter integers");
            }

            Console.ReadLine();
        }
    }
}
