using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        /// <summary>
        /// Method counts passing cars by comparing elements of array
        /// </summary>
        public static int PassingCars()
        {
            int[] carArray = { 0, 1, 0, 1, 1 };
            int carPassed = 0;

            for (int i = 0; i < carArray.Length; i++)
            {
                if (carArray[i] == 0)
                {
                    for (int j = 0; j < carArray.Length; j++)
                    {
                        if (carArray[j] == 1)
                        {
                            if (i < j)
                            {
                                carPassed++;
                            }
                        }
                    }
                }
                Console.Write(carArray[i] + ", ");

            }
            Console.WriteLine(carPassed);
            return carPassed;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine();
            PassingCars();

            Console.ReadKey();
        }
    }
}
