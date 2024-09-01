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
                    //Checking balance
                    case 1:
                        Console.WriteLine($"Your balance is: {balance}");
                        break;
                    //Deposit amount then added to reflect new balance
                    case 2:
                        Console.Write("Enter deposit amount: ");
                        deposit = Convert.ToDouble(Console.ReadLine());
                        balance = deposit + balance;
                        Console.WriteLine("Deposit successful");
                        break;
                    //Withdraw amount then subtracted to reflect new balance
                    case 3:
                        Console.Write("Enter withdraw amount: ");
                        withdraw = Convert.ToDouble(Console.ReadLine());
                        balance = balance - withdraw;
                        Console.WriteLine("Withdraw successful");
                        break;
                }
            } while (userInput != 4); //Condition provided to exit program by typing 4 as prompted by program
        }
    }
}
