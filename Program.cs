using System;

namespace GivenNfindAB
{
    class Program
    {
        public static int N;
        public static int A;
        public static int B;
        public int ZeroA = 0;
        public int ZeroB = 0;
        public bool FoundZeroA;
        public bool FoundZeroB;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter N from 2 to 500000: ");
                N = Convert.ToInt32(Console.ReadLine());

                while (N >= 500000)
                {
                    Console.WriteLine("Cant be more or equal than 500000 - Enter N again: ");
                    N = Convert.ToInt32(Console.ReadLine());
                }

                while (N <= 2)
                {
                    Console.WriteLine("Cant be less or equal to 2 Enter N again: ");
                    N = Convert.ToInt32(Console.ReadLine());
                }

                Program zeroForB = new Program();
                zeroForB.ABcheck();

                Console.WriteLine("{0} A: " + A + "{0} B: " + B, Environment.NewLine);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong - program terminated.");
                Console.ReadLine();
            }
        }
        public int GetNumber()
        {
            Random findNumber = new Random();
            int number = findNumber.Next(1, N);

            return number;
        }
        public void CheckIfThereIsZeroInA()
        {
            Program findRandomNumber = new Program();
            findRandomNumber.GetNumber();

            do
            {
                A = N - findRandomNumber.GetNumber();
                FoundZeroA = A.ToString().Contains(ZeroA.ToString());
            } while (FoundZeroA);
        }
        public void ABcheck()
        {
            do
            {
                Program zeroForA = new Program();
                zeroForA.CheckIfThereIsZeroInA();

                B = N - A;
                FoundZeroB = B.ToString().Contains(ZeroB.ToString());
            } while (FoundZeroB);
        }
    }
}
    

