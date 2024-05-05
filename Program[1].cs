using System; 
using System.Collections.Generic;

class Program {
    static int amount;
    static List<string> transactionHistory = new List<string>();

    static void Main() {
        Console.WriteLine("                U L A  A L H A I D A       ");
		Console.WriteLine("");
		Console.WriteLine("                   BANKING SYSTEM      ");
		Console.WriteLine("           Single Responsibility Principle     ");
		Console.WriteLine("");
		
		Console.WriteLine("Options:");
    	Console.WriteLine("");
        Console.WriteLine("[1]Inquiry, [2] Deposit, [3] Withdraw, [4] Print Statement ");
     
        var selection = Console.ReadLine();

        switch (int.Parse(selection)) {
            case 1:
                Console.Clear();
                Console.WriteLine("Inquiry");
                BalanceInquiry();
                break;

            case 2:
                Console.Clear();
                Console.WriteLine("Deposit");
                DepositAmount();
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("Withdraw");
                WithDraw();
                break;

            case 4:
                Console.Clear();
                Console.WriteLine("Account Statement");
                PrintStatement();
                break;

            default:
                Console.WriteLine("Invalid input, please try again.");
                Console.Clear();
                Main();
                break;
        }
    }

    static void DepositAmount() {
        Console.WriteLine("");
        Console.Write("Enter the amount to deposit: ");
        int deposit = int.Parse(Console.ReadLine());
        amount += deposit;
        Console.WriteLine("||T R A N S A C T I O N  S U C C E S S||");
        Console.WriteLine("");
        transactionHistory.Add($"Deposit: +{deposit}");
        AskForAnotherTransaction();
    }

    static void BalanceInquiry() {
        Console.WriteLine("");
        Console.Write("Your current balance is: ");
        Console.WriteLine(amount);
        Console.WriteLine("");
        transactionHistory.Add($"Balance Inquiry");
        AskForAnotherTransaction();
    }

    static void WithDraw() {
        Console.WriteLine("");
        Console.Write("Enter the amount to withdraw: ");
        int withdraw = int.Parse(Console.ReadLine());
        if (withdraw <= amount) {
            amount -= withdraw;
            Console.WriteLine("||T R A N S A C T I O N  S U C C E S S||");
            Console.WriteLine("");
            transactionHistory.Add($"Withdrawal: -{withdraw}");
        } else {
            Console.WriteLine("||S H O R T  F U N D S||");
            Console.WriteLine("");
            transactionHistory.Add($"Withdrawal Failed: Short funds");
        }
        AskForAnotherTransaction();
    }

    static void PrintStatement() {
        Console.WriteLine("");
        Console.WriteLine("||T R A N S A C T I O N  H I S T O R Y||");
        foreach (var transaction in transactionHistory) {
            Console.WriteLine(transaction);
        }
        Console.WriteLine("");
        AskForAnotherTransaction();
    }

    static void AskForAnotherTransaction() {
        Console.WriteLine("Do you want another transaction?");
		Console.WriteLine("[1] Y E S & [0] N O ");
        int input = int.Parse(Console.ReadLine());

        if (input == 1) {
            Console.Clear();
            Main();
        } else if (input == 0) {
            Console.Clear();
            Console.WriteLine("        T R A N S A C T I O N  E N D E E D...     ");
        } else {
            Console.Clear();
            Console.WriteLine("Invalid input, please try again.");
AskForAnotherTransaction();
        }
    }
}
