using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2_E4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Iniatilize variables to hold values and allow for multiple iterations of program
            int userInput = 0;
            double balance = 1000;
            double deposit = 0;
            double withdraw = 0;
            do //Go through config once as long as the number 4 is not written to exit
            {
                //Display the user with options
                Console.WriteLine("ATM Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                //Prompts user for input on options above
                Console.Write("Choose an option: ");
                //Converts user input to variable/integer and stores in memory
                userInput = Convert.ToInt32(Console.ReadLine());
                //Depending on user input will determine case
                switch (userInput)
                {
                    //Checking balance program
                    case 1:
                        //Writes out balance
                        Console.WriteLine($"Your balance is: {balance}");
                        break;
                    //Deposit program
                    case 2:
                        //Prompts user how much for deposit
                        Console.Write("Enter deposit amount: ");
                        //Converts input to double variable
                        deposit = Convert.ToDouble(Console.ReadLine());
                        //Calculate new balance by adding deposit to balance
                        balance = deposit + balance; 
                        //Shows user that deposit was successful
                        Console.WriteLine("Deposit successful");
                        break;
                    //Withdraw program
                    case 3:
                        //Prompts user how much for withdraw
                        Console.Write("Enter withdraw amount: ");
                        //Converts input to double variable
                        withdraw = Convert.ToDouble(Console.ReadLine());
                        //Calculate new balance by subtracting withdraw from balance
                        balance = balance - withdraw; 
                        //Shows user that withdraw was successful
                        Console.WriteLine("Withdraw successful");
                        break;
                }
            } while (userInput != 4); //Condition provided to exit program by typing 4 as prompted by program
        }
    }
}
