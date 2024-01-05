using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ARR = new int[] { 1, 7, 9, 45 };
            string[] arr2 = new string[] { "Str", "alex", "moh" };
            string[] arr3 = new string[] { "the", "fox", "over", "lazy", "dog" };

            /********************************************/
            //fruits[1] = "Banana"
            //fruits[0] = "Tomato"
            /********************************************/
            string[] food = new string[] { "test", "test", "test", "test", "test" };
            string[] sport = new string[] { "test", "test", "test" };
            string[] movie = new string[] { "test", "test", "test", "test" };
            Console.WriteLine("Fav Food");
            foreach (string f in food)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("Fav Sport");
            foreach (string r in sport)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("Fav Movies");
            foreach (string m in movie)
            {
                Console.WriteLine(m);
            }
            /********************************************/
            Console.WriteLine("Input three numbers separated by comma : ");
            string s = Console.ReadLine();
            string[] str = s.Split(',');
            int[] arrStr = str.Select(int.Parse).ToArray();
            long sum = 0;
            foreach (int f in arrStr)
            {
                sum += f;
            }
            Console.WriteLine("Sum of all numbers in the array is : " + sum);
            /********************************************/
            //sum of odd numbers is from 1 to 100 == numbers of odd numbers is 50 so the summation will be 50^2
            string displayOddNumbers = "";
            for (int i = 1; i <= 100; i += 2)
            {
                displayOddNumbers += i + " ";
            }
            Console.WriteLine(displayOddNumbers);
            Console.WriteLine(Math.Pow(100 / 2, 2));
            /********************************************/
            int n = 3;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (j >= n)
                        Console.Write("* ");
                    else
                        Console.Write(" ");
                }
                n--;
                Console.WriteLine();
            }
            /********************************************/

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            /********************************************/
            int num = 1,r=4;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j >= r)
                        Console.Write(num++ + " ");
                    else
                        Console.Write(" ");
                }
                r--;
                Console.WriteLine();
            }
        }
    }
}
