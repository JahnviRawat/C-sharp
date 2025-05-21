using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day2
{
    internal class SecondDay
    {
        public static void commonArrayValues()
        {
            int[] teamA = { 45, 78, 45, 34, 65, 89 };
            int[] teamB = { 78, 8, 4, 9, 65, 3, 7, 34 };

            for (int i = 0; i < teamA.Length; i++)
            {
                for (int j = 0; j < teamB.Length; j++)
                {
                    if (teamA[i] == teamB[j])
                    {
                        Console.WriteLine(teamA[i]);
                    }
                }
            }
        }

        public static void multiDimensionalArray()
        {
            int[,] arr = new int[3, 3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, 0];
            }
            Console.WriteLine(sum);
        }

        public static void getData()
        {
            Object[] myObjects = new object[5];
            myObjects[0] = "hello";
            myObjects[1] = 123;
            myObjects[2] = 123.4;
            myObjects[3] = null;
            myObjects[4] = "Mphasis";

            for (int i = 0; i < myObjects.Length; i++)
            {
                if (myObjects[i] is string)
                {
                    Console.WriteLine(myObjects[i]);
                }
            }
        }

        public static void stringMethods()
        {
            String[] s = { "Srilanka", "Singapore", "India", "Sweden", "Canada" };
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].StartsWith("S") && s[i].Length > 7)
                {
                    Console.WriteLine(s[i].ToUpper());
                }
            }
        }

        public static void countEvenAndOdd(params int[] arr)
        {
            int countEven = 0;
            int countOdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }

            Console.WriteLine($"Count of even numbers is: {countEven}");
            Console.WriteLine($"Count of Odd numbers is: {countOdd}");
        }

        public static void duplicateNumber(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
        }


        public static void mergeTwoArrays()
        {
            int[] arr = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };

            int[] arr3 = new int[arr.Length + arr2.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr3[i] = arr[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[i + arr.Length] = arr2[i];
            }

            foreach (int i in arr3) Console.Write(i);
        }

        public static void displayArray(int[] arr, bool reverse = false)
        {
            //foreach (int i in arr) Console.WriteLine(i);
            if (reverse == true)
            {
                Array.Reverse(arr);
                foreach (int i in arr) Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("Reverse value is false");
            }
        }

        public static void addMatrix()
        {
            int[,] matrix = {
                {1,2 },
                {3,4 }
            };

            int[,] matrix2 = {
                {5,6 },
                {7,8 }
            };


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] += matrix2[i,j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void sumOfEachRow()
        {
            int[,] matrix = {
                {1,2 ,3},
                {4,5,6},
                {7,8,9 }
            };

            
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int sum = 0;
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
            }
            
            //Console.WriteLine(sum);
        }

        public static void printDiagonal()
        {
            int[,] matrix = {
                {1,2 ,3},
                {4,5,6},
                {7,8,9 }
            };

            for(int i = 0;i < matrix.GetLength(1); i++)
            {
                Console.WriteLine(matrix[i,i]);
            }
        }

        public static void avgOfRowJagged()
        {
            int[][] scores = new int[][] {
                new int[] { 80, 90 },
                new int[] { 70, 85, 90 },
                new int[] { 100 }
            };

            foreach (var i in scores) {
                int sum = 0;
                int avg = 1;
                foreach (var j in i) {
                    sum += j;
                    avg = sum / i.Length;
                }
                Console.WriteLine(avg);
            }


        }

        public static string longestString(string[] str)
        {
            int longLen = 0;
            string str1="";
            for (int i = 0;i<str.Length ; i++) { 
                if(str[i].Length > longLen)
                {
                    longLen = str[i].Length;
                    str1 = str[i];
                }
            }
            return str1;
        }

        public static void joinStrings()
        {
            string[] parts = { "2025", "05", "03" };
            string str = parts[0];
            for (int i = 1; i < parts.Length; i++)
            {
                str += "-"+parts[i]; 
            }
            Console.WriteLine(str);
        }

        public static void replaceWord()
        {
            string[] techs = {
                "I love Java",
                "Java is versatile",
                "Python is cool"
            };

            foreach(string word in techs) Console.WriteLine(word);

            for (int i = 0; i < techs.Length; i++)
            {
                if (techs[i].Contains("Java"))
                {
                    techs[i]= techs[i].Replace("Java", "c#");

                }
            }

            foreach(string word in techs) Console.WriteLine(word);
        }
    }
}
