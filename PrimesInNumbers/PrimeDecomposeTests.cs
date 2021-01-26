using NUnit.Framework;

namespace PrimesInNumbers
{
	public class PrimeDecomposeTests
	{
		[Test]
		public void One()
		{
			var primes = new PrimeDecompose();
			var allPrimes = primes.Factors(1);
			Assert.That(allPrimes, Is.EqualTo("(1)"));
		}

		[Test]
		public void Four()
		{
			var primes = new PrimeDecompose();
			Assert.That(primes.Factors(4), Is.EqualTo("(2**2)"));
		}

		[Test]
		public void PrimeNumbersShouldBeSingleNumber()
		{
			var primes = new PrimeDecompose();
			Assert.That(primes.Factors(5), Is.EqualTo("(5)"));
		}

		[Test]
		public void CompositeNumber()
		{
			var primes = new PrimeDecompose();
			Assert.That(primes.Factors(22), Is.EqualTo("(2)(11)"));
		}

		[Test]
		public void LargeNumber()
		{
			var primes = new PrimeDecompose();
			Assert.That(primes.Factors(86240), Is.EqualTo("(2**5)(5)(7**2)(11)"));
		}
	}
}