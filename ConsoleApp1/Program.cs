using System;
using System.Linq;

namespace ConsoleApp1
{
    public static class Testing
    {
        public static int[] SortArray(int[] array)
        {
            if (array.Length == 0)
                throw new ArgumentNullException(nameof(array), "Массив не может быть пустым.");

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
                }
            }
            return array;
        }

        public static bool IsPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new ArgumentException("Строка не может быть null или пустой.");

            string reversed = new string(str.ToCharArray().Reverse().ToArray());
            return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        public static long Factorial(int n)
        {
            if (n < 0 || n >= 25)
                throw new ArgumentOutOfRangeException(nameof(n), "Число не может быть отрицательным или больше 25.");

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int Fibonacci(int n)
        {
            if (n < 0 || n >= 96)
                throw new ArgumentOutOfRangeException(nameof(n), "Число не может быть отрицательным или больше 96.");

            if (n == 0) return 0;
            if (n == 1) return 1;

            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        public static bool Substring(string str, string subStr)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(subStr))
                throw new ArgumentNullException("Строка и подстрока не могут быть null.");

            return str.IndexOf(subStr, StringComparison.Ordinal) >= 0;
        }

        public static bool IsPrime(int number)
        {
            if (number < 1) throw new ArgumentOutOfRangeException("Введите корректное число!");
            else if (number == 1) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public static int ReverseInt(int x)
        {
            long reversed = 0;
            int sign = x < 0 ? -1 : 1;
            x = Math.Abs(x);

            while (x > 0)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }

            reversed *= sign;

            if (reversed < int.MinValue || reversed > int.MaxValue)
                return 0;

            return (int)reversed;
        }

        public static string ToRoman(int num)
        {
            if (num <= 0 || num > 2999)
                throw new ArgumentOutOfRangeException(nameof(num), "Число должно быть в диапазоне от 1 до 2999.");

            string[] thousands = { "", "M", "MM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            return thousands[num / 1000] + hundreds[(num % 1000) / 100] + tens[(num % 100) / 10] + ones[num % 10];
        }
    }
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1: ");
            int[] array = new int[] { 1, -1, 4, 2, -3 };
            Console.WriteLine("Неотсортированный массив: " + string.Join(", ", array));
            Testing.SortArray(array);
            Console.WriteLine("Отсортированный массив: " + string.Join(", ", array) + "\n");

            Console.WriteLine("2:");
            Console.WriteLine("racecar");
            Console.WriteLine("Палиндром: " + Testing.IsPalindrome("racecar") + "\n");

            Console.WriteLine("3:");
            Console.WriteLine("Факториал 5: " + Testing.Factorial(5) + "\n");

            Console.WriteLine("4:");
            Console.WriteLine("9-е число Фибоначчи: " + Testing.Fibonacci(9) + "\n");

            Console.WriteLine("5:");
            Console.WriteLine("Наличие подстроки '1' в 'petr1 the best': " + Testing.Substring("petr1 the best", "1") + "\n");

            Console.WriteLine("6:");
            Console.WriteLine("Число 7 простое: " + Testing.IsPrime(7) + "\n");

            Console.WriteLine("7:");
            Console.WriteLine("Число -1230 с обратными цифрами: " + Testing.ReverseInt(-1230) + "\n");

            Console.WriteLine("8: ");
            Console.WriteLine("Число 1899 в римских: " + Testing.ToRoman(1899) + "\n");
        }
    }
}