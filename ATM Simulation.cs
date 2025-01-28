//ATM Simulation
using System;

class ATM
{
    // Predefined PIN and initial balance
    private static string currentPin = "4040";
    private static double balance = 10000;

    // Main function to start the ATM process
    static void Main()
    {
        // Prompt the user to enter PIN
        Console.WriteLine("Enter the pin:");
        string enteredPin = Console.ReadLine();

        // Validate PIN
        if (ValidatePin(enteredPin))
        {
            // PIN is correct, proceed with ATM options
            bool continueSession = true;
            while (continueSession)
            {
                // Display menu
                Console.WriteLine("1. To check balance");
                Console.WriteLine("2. To withdraw money");
                Console.WriteLine("3. To deposit money");
                Console.WriteLine("4. To change the pin");
                Console.WriteLine("Enter your choice:");
                
                int choice;
                bool isValidChoice = int.TryParse(Console.ReadLine(), out choice);

                if (!isValidChoice || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Please select correct option");
                    continue;
                }

                // Handle each option
                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        WithdrawMoney();
                        break;
                    case 3:
                        DepositMoney();
                        break;
                    case 4:
                        ChangePin();
                        break;
                }

                // Ask if the user wants to continue the session
                Console.WriteLine("Do you want to perform another transaction? (yes/no)");
                string continueResponse = Console.ReadLine();
                continueSession = continueResponse.ToLower() == "yes";
            }
        }
        else
        {
            Console.WriteLine("Incorrect PIN. Access denied.");
        }
    }

    // Validate the entered PIN
    static bool ValidatePin(string enteredPin)
    {
        return enteredPin == currentPin;
    }

    // Check current balance
    static void CheckBalance()
    {
        Console.WriteLine($"The current balance in your account is {balance}");
    }

    // Withdraw money
    static void WithdrawMoney()
    {
        Console.WriteLine("Enter the amount to withdraw:");
        double withdrawAmount;
        
        bool isValidWithdraw = double.TryParse(Console.ReadLine(), out withdrawAmount);
        if (!isValidWithdraw || withdrawAmount <= 0 || withdrawAmount % 100 != 0)
        {
            Console.WriteLine("Invalid amount. Please enter a multiple of 100.");
            return;
        }

        if (withdrawAmount > balance)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else
        {
            balance -= withdrawAmount;
            Console.WriteLine($"Please collect the cash: {withdrawAmount}");
            Console.WriteLine($"The current balance is now: {balance}");
        }
    }

    // Deposit money
    static void DepositMoney()
    {
        Console.WriteLine("Enter the amount to be deposited:");
        double depositAmount;

        bool isValidDeposit = double.TryParse(Console.ReadLine(), out depositAmount);
        if (isValidDeposit && depositAmount > 0)
        {
            balance += depositAmount;
            Console.WriteLine($"The current balance in the account is {balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Change PIN
    static void ChangePin()
    {
        Console.WriteLine("Want to change your pin? Enter your previous pin:");
        string oldPin = Console.ReadLine();

        if (oldPin == currentPin)
        {
            Console.WriteLine("Enter your new pin:");
            string newPin = Console.ReadLine();
            currentPin = newPin;
            Console.WriteLine("Your pin is changed.");
        }
        else
        {
            Console.WriteLine("Incorrect pin. PIN change failed.");
        }
    }
}
