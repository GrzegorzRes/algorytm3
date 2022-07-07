using System;

namespace algorytm3 
{
    internal class Program
    {
        static int Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Bad input");
                return -1;
            }

            var stringOfNumbers = args[0];

            if (CheckIsStrobogramm(stringOfNumbers))
            {
                Console.Write("Liczba jest strobogramatyczna ");

                if (CheckIsPrime(stringOfNumbers))
                {
                    Console.WriteLine("oraz pierwsza");
                }
            }
            else
            {
                Console.WriteLine("Liczba nie jest strobogramatyczna");
            }

            return 0;
        }

        private static bool CheckIsPrime(string stringOfNumbers)
        {
            int number = int.Parse(stringOfNumbers);
            return Enumerable.Range(2,stringOfNumbers.Length-1).All(num => number % num != 0);
        }

        private static bool CheckIsStrobogramm(string stringOfNumbers)
        {
            Dictionary<char, char> strobogramm = new Dictionary<char, char>() { { '0', '0' }, { '1', '1' }, { '6', '9' }, { '8', '8' }, { '9', '6' } };

            var lenghtString = stringOfNumbers.Length-1;
            for (int i = 0; i < stringOfNumbers.Length; i++)
            {
                if (!strobogramm.ContainsKey(stringOfNumbers[i]) || strobogramm[stringOfNumbers[i]] != stringOfNumbers[lenghtString - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}