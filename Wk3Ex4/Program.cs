using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration
            double balance = 1000;
            double depositAmount = 0;
            double withdrawalAmount = 0;
            int menuChoice = 0;
            bool running = true;

            while (running) //while loop that runs untill running is turned to false
            {
                Console.WriteLine("ATM Menu: "); //print menu
                Console.WriteLine("1. Check Balance"); //option to check balance
                Console.WriteLine("2. Deposit"); //option to deposit
                Console.WriteLine("3. Withdraw"); //option to withdraw
                Console.WriteLine("4. Exit"); //option to exit

                menuChoice = Convert.ToInt32(Console.ReadLine()); //converts the choice inputted by user to be used in the switch statement

                switch (menuChoice) //switch statment using the menuChoice variable
                {
                    case 1:
                        Console.WriteLine($"Your balance is: {balance, 2}"); //prints out the balance 
                        break; //break from switch if user inputted a 1
                    case 2:
                        Console.WriteLine("Enter a deposit amount: "); //asks user for deposit amount
                        depositAmount = Convert.ToDouble(Console.ReadLine()); //stores input from user 
                        balance += depositAmount; //calculate the new balance
                        Console.WriteLine($"Deposit Successful. Your balance is now {balance ,2}"); //print out balance after new calculation
                        break; //break from switch if user inputted a 2
                    case 3:
                        Console.WriteLine("Enter a withdrawal amount: "); //ask user for withdrawal amount
                        withdrawalAmount = Convert.ToDouble(Console.ReadLine()); //stores input from user
                        balance -= withdrawalAmount; //calculate the new balance
                        Console.WriteLine($"Deposit Successful. Your balance is now {balance ,2}"); //print out balance after new calculation
                        break; //break from switch if user inputted a 3
                    case 4:
                        running = false; //changes running to false to break out of the while loop
                        break; //break from switch if user inputted a 4

                }
            }
        }
    }
}
