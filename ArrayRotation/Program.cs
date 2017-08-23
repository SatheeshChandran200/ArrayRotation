using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 0;
            int rotationCount = 1;
            string[] tokens_n = Console.ReadLine().Split(' ');
            arrayLength = Convert.ToInt32(tokens_n[0]);
            rotationCount = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] inputArray = Array.ConvertAll(a_temp, Int32.Parse);
            int[] outputArray = new int[inputArray.Length];
            for(int i = 0; i < inputArray.Length; i++)
            {
                int new_index = (i + rotationCount) % inputArray.Length;
                outputArray[i] = inputArray[new_index];
            }
            //for(int j=0; j < rotationCount; j++)
            //{
            //    inputArray = RotateArray(inputArray);
            //}
            StringBuilder sb = new StringBuilder();
            for(int x = 0; x < inputArray.Length; x++)
            {
                sb.Append(outputArray[x]);
                sb.Append(' ');
            }
            Console.WriteLine(sb.ToString().TrimEnd(' '));
            Console.ReadLine();
        }

        public static int[] RotateArray(int[] input)
        {
            int[] outputArray = new int[input.Length];
            outputArray[input.Length - 1] = input[0];
            for(int i = 0; i < input.Length - 1; i++)
            {
                outputArray[i] = input[i + 1];
            }
            return outputArray;
        }
    }
}
