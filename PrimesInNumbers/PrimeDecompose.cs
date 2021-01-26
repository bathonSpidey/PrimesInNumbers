using System;

namespace PrimesInNumbers
{
	public class PrimeDecompose
	{
		public string Factors(int number)
		{
			var isPrime = CheckPrimeNumber(number);
			var result = "";
			if (number < 4 || isPrime)
				return $"({number})";
			return BreakIntoPrimes(number, result);
		}

		private static string BreakIntoPrimes(int number, string result)
		{
			for (var index = 2; index <= number; index++)
			{
				var count = 0;
				while (number % index == 0)
				{
					number /= index;
					count++;
				}
				result = FormatResult(count, result, index);
			}
			return result;
		}

		private static string FormatResult(int count, string result, int index)
		{
			if (count == 1)
				result += $"({index})";
			else if (count > 1)
				result += $"({index}**{count})";
			return result;
		}

		private static bool CheckPrimeNumber(int number)
		{
			var limit = Math.Ceiling(Math.Sqrt(number));
			for (var index = 2; index <= limit; index++)
				if (number % index == 0)
					return false;
			return true;
		}
	}
}