﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	internal class Math
	{
		public static long CalculateFactorial(int n)
		{
			if (n == 0 || n == 1)
				return 1;
			long result = 1;
			for (int i = 2; i <= n; i++)
				result *= i;
			return result;
		}
	}
}
