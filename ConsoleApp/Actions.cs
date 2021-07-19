using System;

namespace ConsoleApp
{
    class Actions
    {
        public int Addition (int input1, int input2)
        {
            int result = input1 + input2;
            return result;
        }

        public int Subtraction(int input1, int input2)
        {
            int result = input1 - input2;
            return result;
        }

        public int Multiplication(int input1, int input2)
        {
            int result = input1 * input2;
            return result;
        }

        public int Division (int input1, int input2)
        {
            while(input1 == 0 || input2 == 0)
            {
                Console.WriteLine("Kindly enter the first number as a non zero number");
                input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kindly enter the second number as a non zero number");
                input2 = Convert.ToInt32(Console.ReadLine());
            }
            int result = input1 / input2;
            return result;
        }

        public int Square1 (int input1)
        {
            int result = input1 * input1;
            return result;
        }

        public int Square2 (int input2)
        {
            int result = input2 * input2;
            return result;
        }
    }
}