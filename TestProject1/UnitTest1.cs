using ConsoleApp1;

namespace TestProject1
{
    public class TestsForLabNum1
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 1, 11, 6, 0, 4 })]
        public void TestOfSortingWithoutNegative(int[] value)
        {
            int[] result = Testing.SortArray(value);
            Assert.That(result, Is.EqualTo(new int[] { 0, 1, 4, 6, 11 }));
        }

        [TestCase(new int[] { 1, -1, 6, -10, 4 })]
        public void TestOfSortingWithNegative(int[] value)
        {
            int[] result = Testing.SortArray(value);
            Assert.That(result, Is.EqualTo(new int[] { -10, -1, 1, 4, 6 }));
        }

        [TestCase(new int[] { -100, -1, -6, -10, -4 })]
        public void TestOfSortingOnlyNegative(int[] value)
        {
            int[] result = Testing.SortArray(value);
            Assert.That(result, Is.EqualTo(new int[] { -100, -10, -6, -4, -1 }));
        }

        [TestCase(new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2 })]
        public void TestOfSortingSameValues(int[] value)
        {
            int[] result = Testing.SortArray(value);
            Assert.That(result, Is.EqualTo(new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2 }));
        }

        [TestCase(new int[] { 1, 11, 6, 0, 4, -1, 122, 4, -44 })]
        public void TestOfSortingAdditional(int[] value)
        {
            int[] result = Testing.SortArray(value);
            Assert.That(result, Is.EqualTo(new int[] { -44, -1, 0, 1, 4, 4, 6, 11, 122 }));
        }

        [TestCase(new int[] { })]
        public void TestOfSortingException(int[] array)
        {
            Assert.That(() => Testing.SortArray(array), Throws.TypeOf<ArgumentNullException>());
        }

        [TestCase("avava")]
        [TestCase("FF")]
        [TestCase("dgh $$ ## $$ hgd")]
        [TestCase("Racecar")]
        public void TestOfPalindromePositive(string check)
        {
            Assert.That(Testing.IsPalindrome(check), Is.True);
        }

        [TestCase("avava2")]
        [TestCase("FF GG")]
        [TestCase("dgh $$ ## $ hgd")]
        [TestCase("Racecal")]
        public void TestOfPalindromeNegative(string check)
        {
            Assert.That(Testing.IsPalindrome(check), Is.False);
        }

        [TestCase("")]
        public void TestOfPalindromeException(string check)
        {
            Assert.That(() => Testing.IsPalindrome(check), Throws.TypeOf<ArgumentException>());
        }

        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(5, 120)]
        public void TestOfFactorial(int value, long answer)
        {
            Assert.That(Testing.Factorial(value), Is.EqualTo(answer));
        }

        [TestCase(-2)]
        [TestCase(-1337)]
        [TestCase(25)]
        public void TestOfFactorialException(int value)
        {
            Assert.That(() => Testing.Factorial(value), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(5, 5)]
        [TestCase(9, 34)]
        public void TestOfFibonacci(int value, int answer)
        {
            Assert.That(Testing.Fibonacci(value), Is.EqualTo(answer));
        }

        [TestCase(-2)]
        [TestCase(-1337)]
        [TestCase(96)]
        public void TestOfFibonacciException(int value)
        {
            Assert.That(() => Testing.Fibonacci(value), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase("jkf 31jh 4h12h3 12 ##", "4h12h", true)]
        [TestCase("  ffds###ffsa ", "ds##", true)]
        [TestCase("basase 123 123", "312", false)]
        [TestCase(",.hfa3123", "hf ", false)]
        [TestCase("gahd  a123", "  ", true)]
        public void TestOfSubstring(string str, string subStr, bool answer)
        {
            Assert.That(Testing.Substring(str, subStr), Is.EqualTo(answer));
        }

        [TestCase("", " asd")]
        [TestCase("sdasd", "")]
        public void TestOfSubstringException(string str, string subStr)
        {
            Assert.That(() => Testing.Substring(str, subStr), Throws.TypeOf<ArgumentNullException>());
        }

        [TestCase(1, false)]
        [TestCase(5, true)]
        [TestCase(6, false)]
        [TestCase(97, true)]
        [TestCase(222, false)]
        public void TestOfIsPrime(int value, bool answer)
        {
            Assert.That(Testing.IsPrime(value), Is.EqualTo(answer));
        }

        [TestCase(0)]
        [TestCase(-12)]
        public void TestOfIsPrimeException(int value)
        {
            Assert.That(() => Testing.IsPrime(value), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(12, 21)]
        [TestCase(120, 21)]
        [TestCase(-1230, -321)]
        [TestCase(1000000092, 0)]
        [TestCase(1920037010, 107300291)]
        [TestCase(-43222, -22234)]
        [TestCase(0, 0)]
        public void TestOfReverseInt(int value, int answer)
        {
            Assert.That(Testing.ReverseInt(value), Is.EqualTo(answer));
        }

        [TestCase(105, "CV")]
        [TestCase(600, "DC")]
        [TestCase(2538, "MMDXXXVIII")]
        [TestCase(16, "XVI")]
        [TestCase(49, "XLIX")]
        [TestCase(444, "CDXLIV")]
        [TestCase(6, "VI")]
        [TestCase(5, "V")]
        [TestCase(4, "IV")]
        [TestCase(1, "I")]
        public void TestOfToRoman(int value, string answer)
        {
            Assert.That(Testing.ToRoman(value), Is.EqualTo(answer));
        }

        [TestCase(3999)]
        [TestCase(-1000)]
        [TestCase(0)]
        public void TestOfToRomanException(int value)
        {
            Assert.That(() => Testing.ToRoman(value), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}