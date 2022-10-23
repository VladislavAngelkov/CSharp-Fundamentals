using System;
using System.Text;
using System.Linq;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            if (number == 0 || bigNumber == "0")
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder result = new StringBuilder();

            int rest = 0;

            for (int i = bigNumber.Length-1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNumber[i].ToString());

                int currentResult = currentDigit * number + rest;

                int lastDigit = currentResult % 10;

                rest = currentResult / 10;

                result.Append(lastDigit);
            }

            if (rest!=0)
            {
                result.Append(rest);
            }

            StringBuilder finalResult = new StringBuilder();

            for (int i = result.Length-1; i >= 0; i--)
            {
                finalResult.Append(result[i]);
            }

            Console.WriteLine(finalResult);
        }
    }
}
