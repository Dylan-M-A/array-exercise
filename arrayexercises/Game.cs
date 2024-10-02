using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayexercises
{
    internal class Game
    {
        public void Run()
        {
            //all the function that will be used
            int[] ints = GetValues();

            PrintArray(ints);
            PrintReverse(ints);
            PrintSum(ints);
            PrintHighest(ints);
            PrintLowest(ints);
        }
        //if im not tought how to do something i cant figure out how to do it on my own
        int[] GetValues()
        {
            //Int32.Parse()
            Console.WriteLine("Enter parameters for the function with a space in between each parameter: "); String stringParameters = Console.ReadLine();
            String[] parametersStringArray = stringParameters.Split(' ');
            int[] parametersArray = new int[parametersStringArray.Length];

            for (int i = 0; i < parametersStringArray.Length; i++)
            {
                int tmp;
                if (int.TryParse(parametersStringArray[i], out tmp))
                    parametersArray[i] = tmp;

            }
            Console.Read();
            Console.Clear();
            return parametersArray;
        }
        //creating the way the numbers will be printed out
        int[] PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Printed Numbers: ");
            Console.WriteLine(array);
            return array;
        }
        //showing the sum of all the numbers together
        int PrintSum(int[] array)
        {
            int sum = array.Sum();

            // output = 6
            Console.WriteLine("Sum of the Numbers: ");
            Console.WriteLine(sum);
            return sum;
        }
        //printing the highest used number
        int PrintHighest(int[] array)
        {
            int i;
            int highestNum = array[0];

            for (i = 1; i < array.Length; i++)
            {
                if (array[i] > highestNum)
                {
                    highestNum = array[i];
                }
            }
            Console.WriteLine("Highest Number: ");
            Console.WriteLine(highestNum);
            return highestNum;
        }
        //printing out the lowest used number
        int PrintLowest(int[] array)
        {
            int i;
            int lowestNum = array[0];

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] < lowestNum)
                {
                    lowestNum = array[i];
                }
            }
            Console.WriteLine("Lowest Number: ");
            Console.WriteLine(lowestNum);
            return lowestNum;
        }
        //printing out the order of the numbers in reverse
        int[] PrintReverse(int[] array)
        {
            Console.WriteLine("Before");
            PrintArray(array);
            Console.WriteLine("After");
            PrintArray(array.Reverse().ToArray());
            return null;
        }
    }
}
