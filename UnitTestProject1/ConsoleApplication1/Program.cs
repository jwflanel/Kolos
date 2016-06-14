using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {


        public static void Main(string[] args)
        {
            int[] array = { 0, 1, 0, 1, 1 };
            int passed = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if(array[j] == 1)
                        {
                            if (i < j)
                            {
                                passed++;
                            }
                        }
                    }
                }

                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();

            Console.WriteLine(passed);
            Console.ReadKey();
        }
    }
}
