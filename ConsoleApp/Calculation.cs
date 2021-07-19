using System;
using System.Collections.Generic;  
using System.Linq;

namespace ConsoleApp
{
    class Calculation
    {
        public void Calc()
        {
            // display title
            Console.WriteLine("Console Calculator in C#");
            Console.WriteLine("------------------------");

            // initialize local fields 
            Props props = new Props();
            int result = props.Result;
            int input1 = props.Input1;
            int input2 = props.Input2;
           // props.GetItem = new List<int>(){result};
            var lists = props.ListHistory;
           

                // choose action
                Console.WriteLine("Choose the operation to be performed from the following list, and press Enter");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");
                Console.WriteLine("Press 5 to Square");
                // check if input is number or not
                int operation;
                string input = Console.ReadLine();
                // convert the input from string to number
                //tryparse(boolean) - convert string to char 
                while(!Int32.TryParse(input, out operation) || operation < 1 || operation > 5 )
                { //if not a number
                    Console.WriteLine("Kindly enter input 1-5");
                    input = Console.ReadLine();
                } //else if a number
                operation = Convert.ToInt32(input);
                // type first number
                Console.WriteLine("Type the first number, and then press Enter");
                //check if input1 is a number or not
                string num1 = Console.ReadLine();
                while (!Int32.TryParse(num1, out input1))
                {
                    //if not a number
                    Console.WriteLine("Kindly enter a number");
                    num1 = Console.ReadLine();
                }
                input1 = Convert.ToInt32(num1);
                // type second number
                Console.WriteLine("Type the second number, and then press Enter");
                //check if input1 is a number or not
                string num2 = Console.ReadLine();
                while (!Int32.TryParse(num2, out input2))
                {
                    //if not a number
                    Console.WriteLine("Kindly enter a number");
                    num2 = Console.ReadLine();
                }
                input2 = Convert.ToInt32(num2);
                            
                // actions
                if(operation == 1){
                    Actions add = new Actions();
                    result = add.Addition(input1, input2);
                    Console.WriteLine($"The result of {input1} + {input2}: {result}");
                    lists.Add(result);
                }

                if (operation == 2)
                {
                    Actions subtract = new Actions();
                    result = subtract.Subtraction(input1, input2);
                    Console.WriteLine($"The result of {input1} - {input2}: {result}");
                    lists.Add(result);
                }

                if (operation == 3)
                {
                    Actions multiply = new Actions();
                    result = multiply.Multiplication(input1, input2);
                    Console.WriteLine($"The result of {input1} x {input2}: {result}");
                    lists.Add(result);
                }

                if (operation == 4)
                {
                    Actions divide = new Actions();
                    result = divide.Division(input1, input2);
                    Console.WriteLine($"The result of {input1} ÷ {input2}: {result}");
                    lists.Add(result);
                }

                if (operation == 5)
                {
                    Actions square = new Actions();
                    int result1 = square.Square1(input1);
                    int result2 = square.Square2(input2);
                    Console.WriteLine($"The result of the square of {input1} and {input2} is {result1} and {result2} respectively");
                    lists.Add(result1);
                    lists.Add(result2);
                }
            
            Choice choice = new Choice();
            choice.Choose();

            Console.WriteLine("Press any key to exit the process");
            Console.ReadKey();
        }
    }
}