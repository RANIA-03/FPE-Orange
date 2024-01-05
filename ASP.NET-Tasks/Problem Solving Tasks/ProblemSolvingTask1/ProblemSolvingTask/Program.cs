using System.Diagnostics.Metrics;

namespace ProblemSolvingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minutes so i will converts it to seconds : ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(minutes + " minutes is " + (minutes * 60) + " seconds");
            /****************************************/
        }
        public static int incrementNum(int num)
        {
            return ++num;
        }
        public static int printFirstNumInArray(int[] arr)
        {
            return arr[0];
        }
        public static double areaOfTriangle(double basee, double height)
        {
            return basee * height * 0.5;
        }
        public static int[] evenNumEvenIndex(int[] arr)
        {
            string s = "";
            for (int i = 0; i < arr.Length; i += 2)
                if (arr[i] % 2 == 0)
                    s += arr[i] + ",";
            if (s[s.Length - 1] == ',')
                s = s.Remove(s.Length - 1, 1);
            string[] str = s.Split(',');
            int[] myArr = str.Select(int.Parse).ToArray();
            return myArr;
        }
        public static string[] evenIndexOddLength(string[] arr)
        {
            string s = "";
            for (int i = 0; i < arr.Length; i += 2)
                if (arr[i].Length % 2 != 0)
                    s += arr[i] + ",";
            if (s[s.Length - 1] == ',')
                s = s.Remove(s.Length - 1, 1);
            string[] str = s.Split(',');
            string[] myArr = str.ToArray();
            return myArr;
        }
        public static long[] powerElementIndex(int[] arr)
        {
            long[] myArr = new long[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                myArr[i] = (long)(Math.Pow(arr[i], i));
            return myArr;
        }
        public static long multiplication2(long a, long b)
        {
            return a * b;
        }
        public static long muti2(long a, long b)
        {
            long result = 1;
            for (long i = a; i <= b; i++)
            {
                result *= i;
            }
            return result;
        }
        public static double aveArray(int[] arr)
        {
            double result = 0;
            foreach (int i in arr)
            {
                result *= i;
            }
            return result / arr.Length;
        }
    }
}
