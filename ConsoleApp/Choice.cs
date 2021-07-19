using System;
using System.Collections.Generic;  
using System.Linq;

namespace ConsoleApp
{
    public class Choice
    {
        public void Choose ()
        {

            Props props = new Props();
            int result = props.Result;
            var list = props.ListHistory;
           
             // choose between quit and see history
            Console.WriteLine("Do you want to see the history, do another calculation or quit?");
            Console.WriteLine("Press 1 for History");
            Console.WriteLine("Press 2 for Calculation");
            Console.WriteLine("Press 3 for Quit");

            int choice;            
            string choiceInput = Console.ReadLine();
            while(!Int32.TryParse(choiceInput, out choice) || choice < 1 || choice > 3 )
            { //if not a number or 1 or 2
                Console.WriteLine("Kindly enter input 1 or 2");
                choiceInput = Console.ReadLine();
            } //else if a 1 or 2
            choice = Convert.ToInt32(choiceInput);

            // if history is selected
            if (choice == 1)
            {
 
                int data = result;

                foreach (var res in list)
                {
                    data = res;
                }

                Console.WriteLine(data);
            }

            if(choice == 2)
            {
                Calculation calc = new Calculation();
                calc.Calc();
            }
        }
    }
}