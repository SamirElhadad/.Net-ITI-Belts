using ConsoleApp1;

namespace ConsoleApp2
{
    internal class Program
    {
        #region Enum of Task_2

        enum operation
        {
            Deposit = 1,
            Withdraw
        }

        #endregion
        static void Main(string[] args)
        {
            #region Task_2 Encapsulation + Validation

                BankAccount account = new BankAccount();

                Console.Write("Enter Your Balance: ");
                decimal initialBalance = Convert.ToDecimal(Console.ReadLine());
                account.Balance = initialBalance;
                if (account.Balance < 0)
                {
                    Console.WriteLine("Error: Balance cannot be negative");
                    return;
                }
                Console.WriteLine("Select Operation: ");
                Console.WriteLine("1) Deposit: ");
                Console.WriteLine("2) Withdraw: ");

                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    Console.WriteLine("Invalid Choice");
                    return;
                }

                Console.Write("Enter Amount : ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                if (amount <= 0)
                {
                    Console.WriteLine("Error: Balance cannot be negative");
                    return;
                }

                operation op = (operation)choice;
                switch (op)
                {
                    case operation.Deposit:
                        account.Deposit(amount);
                        Console.WriteLine($"Deposited: ${amount}, New Balance: ${account.Balance}");
                        break;
                    case operation.Withdraw:
                        if (amount > account.Balance)
                        {
                            Console.WriteLine("Error: Insufficient funds");
                            return;
                        }
                        account.Withdraw(amount);
                        Console.WriteLine($"Withdrew: ${amount}, New Balance: ${account.Balance}");
                        break;
                }
            #endregion
        }
    }
}
