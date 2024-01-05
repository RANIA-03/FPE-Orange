using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers");
            int x;
            long sum = 0;
            for(int i=0; i<10; i++)
            {
                sum += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The sum of 10 no is : " + sum);
            Console.WriteLine("The average us : "+(sum/10));
            /********************************************/

            Console.WriteLine("Enter number of TERMS");
            int numOfTerms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered "+numOfTerms+" now enter each number and i will display the cube of the number : ");
            for(int i=0; i<numOfTerms; i++)
            {
                int term = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number is : " + term + " and cube of the " + term + " is :" + (Math.Pow(term, 3));
            }
            /********************************************/
            int[] years =  new int[] { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            int[] yearsGreaterThan1950 = getYears(years);

            Console.WriteLine("Years greater than 1950:");
            foreach (int year in yearsGreaterThan1950)
            {
                Console.WriteLine(year);
            }
            /********************************************/


        }
        public static int[] getYears(int[] arr)
        {
            int count = 0;
            foreach (int year in arr)
            {
                if (year > 1950)
                {
                    count++;
                }
            }
            int[] myArr = new int[count];
            int i = 0;
            foreach (int year in arr)
            {
                if (year > 1950)
                {
                    myArr[i] = year;
                    i++;
                }
            }
            return myArr;
        }
        public static int ageInDays(int years)
        {
            return years * 356;
        }
        public static int FarmerTotalLegs(int chickens, int cows, int pigs)
        {
            if (AreWholeNumbers(chickens, cows, pigs))
            {
                return (chickens * 2) + (cows * 4) + (pigs * 4);
            }
            else
            {
                Console.WriteLine("Please provide whole numbers for the number of animals.");
                return -1;
            }
        }
        private static bool AreWholeNumbers(params int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 1 != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static string Login(string username, string password)
        {
            string[] users = { "rania03", "sara00", "aya98" };
            string[] pass = { "P@ssw0rd", "PassS00", "A98Pass" };
            for (int i = 0; i < users.Length; i++)
                if (username == users[i] && password == pass[i])
                    return "Success login";
            return "Failed"; 
        }
        public static long powOfNumber(int num, int pow)
        {
            long result = 1;
            for(int i = 1;i <= pow; i++)
            {
                result *= num;
            }
            return result;
        }
        public static string leapYear(int year)
        {
            if (year >= 1900 && year <= 2024)
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    return "Leap year";
                }
                else
                {
                    return "Not a leap year";
                }
            }
            else
            {
                return "Year out of range (1900-2024)";
            }
        }
        public static bool isPrime(int num)
        {
            if (num <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        public static int numOfWords(string s)
        {
            string[] str = s.Split(' ');
            int[] arrStr = str.Select(int.Parse).ToArray();
            return arrStr.Length;
        }
    }
}
