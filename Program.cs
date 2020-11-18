using System;
using System.Collections.Generic;
using System.IO;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

namespace HackerRank_Challenges
{

    class FibonacciSolution
    {

        public static int Fibonacci(int n)
        {

            //Código Utilizado
            int f1 = 0;
            int f2 = 1;
            int F = f1 + f2;

            for (int i = 3; i <= n; i++)
            {

                f1 = f2;
                f2 = F;
                F = f1 + f2;
            }

            return F;
            //fim do código
        }
        //codigo default do hackerrank
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }
    }



    class ArrayDsSolution
    {
        //my code
        static int[] reverseArray(int[] a)
        {

            for (int i = 0; i < a.Length / 2; i++)
            {
                int tmp = a[i]; // store the value in a temporary variable
                a[i] = a[a.Length - i - 1];
                a[a.Length - i - 1] = tmp;
            }
            return a;
        //end
        }
        //default hackerrank's code
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] res = reverseArray(arr);

            textWriter.WriteLine(string.Join(" ", res));

            textWriter.Flush();
            textWriter.Close();
        }
    }
    
    class LeftRotationSolution
    {
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            int len = arr.Count;
            List<int> rotation = new List<int>(arr);

            for (int i = 0; i < len; i++)
            {
                int nIndex = (i + (len - d)) % len;
                rotation[nIndex] = arr[i];
            }
            return rotation;

        }

    }

    class DiagonalDifferenceSolution
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int lenght = arr[0].Count();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < lenght; i++)
            {
                leftSum += arr[i][0 + i];// capture the values of left to right sum in each iteration of loop
                rightSum += arr[i][lenght - i - 1];// capture the values of right to left sum
            }
            return Math.Abs(leftSum - rightSum); // math.abs returns the absolut value
        }
    }
 
    class FindTheMedianSolution
    {
        static int findMedian(int[] arr)
        {

            Array.Sort(arr);
            // int[] sortedArr = BubbleSort(arr);
            int indexMidian = arr.Length / 2;
            int result = arr[indexMidian];

            return result;
        }
    }

    class MarsExplorationSolution
    {

    }
}

    
    
    
    


