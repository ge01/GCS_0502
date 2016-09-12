using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0502
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////
            //This program allows the user to enter an account's starting//
            //balance and the number of months that the account will be  //
            //left to earn interest.  The program calculates the         //
            //account's balance at the end of the time period. The       //
            //accounts monthly interest rate is 0.005, and the interest  // 
            //is compounded monthly.                                     //
            ///////////////////////////////////////////////////////////////

            // Constant for the monthly interest rate.
            const decimal INTEREST_RATE = 0.005m;

            // Local variables
            decimal balance;    // The account balance
            int months;         // The number of months
            int count = 1;      // Loop counter, initialized with 1

            // Get the starting balance.
            Console.Write("Enter the starting balance: ");
            balance = decimal.Parse(Console.ReadLine());

            // Get the number of months
            Console.Write("Enter the number of months: ");
            months = int.Parse(Console.ReadLine());

            // The following loop calculates the ending balance.
            while (count <= months)
            {
                // Add this month's interest to the balance.
                balance = balance + (INTEREST_RATE * balance);

                // Display this month's ending balance.
                Console.WriteLine("The ending balance " +
                    "for month " + count + " is " +
                    balance.ToString("c"));

                // Add one to the loop counter
                count = count + 1;
            }

            // Display the ending balance.
            Console.WriteLine("Ending Balance: " +
                balance.ToString("c"));
            Console.ReadLine();
        }
    }
}

//Enter the starting balance: 1000
//Enter the number of months: 8
//The ending balance for month 1 is $1,005.00
//The ending balance for month 2 is $1,010.03
//The ending balance for month 3 is $1,015.08
//The ending balance for month 4 is $1,020.15
//The ending balance for month 5 is $1,025.25
//The ending balance for month 6 is $1,030.38
//The ending balance for month 7 is $1,035.53
//The ending balance for month 8 is $1,040.71
//Ending Balance: $1,040.71
