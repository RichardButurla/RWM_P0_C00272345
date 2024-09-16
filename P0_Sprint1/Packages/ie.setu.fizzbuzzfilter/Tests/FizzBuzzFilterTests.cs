using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class FizzBuzzFilterTest
    {
        [Test]
        public void FizzBuzzFilterSimple()
        {
            int[] input = { 4, 3, 6, 30, 10, 12 };
            int[] output = FizzBuzzFilter.fizzBuzzReplace(input);
            int[] expected = { 4, 3, 3, 0, 5, 3 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
