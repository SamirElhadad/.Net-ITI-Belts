namespace ConsoleApp1
{
    internal class Program
    {
        #region Enum Of Task_1

            //enum PizzaSize
            //{
            //    Small = 1,
            //    Medium,
            //    Large
            //}
            //enum PizzaPrice
            //{
            //    Small = 10,
            //    Medium = 12,
            //    Large = 15
            //}

        #endregion

        #region Enum of Task_2

            //enum operation
            //{
            //    Deposit = 1,
            //    Withdraw
            //}

        #endregion
        static void Main(string[] args)
        {
            #region Task_1 Pizza Order System (Enum)

            //Console.WriteLine("Select Pizza Size: ");
            //Console.WriteLine("1) Small: ");
            //Console.WriteLine("2) Medium: ");
            //Console.WriteLine("3) Large: ");
            //Console.Write("Enter Your Fav Size : ");

            //int choice = Convert.ToInt32(Console.ReadLine());

            //if (choice >= 1 && choice <= 3)
            //{
            //    PizzaSize size = (PizzaSize)choice;
            //    PizzaPrice price = (PizzaPrice)Enum.Parse(typeof(PizzaPrice), size.ToString());

            //    Console.WriteLine($"You have selected {size} Pizza. and The Price is : ${(int)price}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Choice");
            //}


            #endregion

            #region Task_2 Encapsulation + Validation

                //BankAccount account = new BankAccount();

                //Console.Write("Enter Your Balance: ");
                //decimal initialBalance = Convert.ToDecimal(Console.ReadLine());
                //account.Balance = initialBalance;
                //if (account.Balance < 0)
                //{
                //    Console.WriteLine("Error: Balance cannot be negative");
                //    return;
                //}
                //Console.WriteLine("Select Operation: ");
                //Console.WriteLine("1) Deposit: ");
                //Console.WriteLine("2) Withdraw: ");

                //Console.Write("Enter Your Choice : ");
                //int choice = Convert.ToInt32(Console.ReadLine());
                //if (choice < 1 || choice > 2)
                //{
                //    Console.WriteLine("Invalid Choice");
                //    return;
                //}

                //Console.Write("Enter Amount : ");
                //decimal amount = Convert.ToDecimal(Console.ReadLine());
                //if (amount <= 0)
                //{
                //    Console.WriteLine("Error: Balance cannot be negative");
                //    return;
                //}

                //operation op = (operation)choice;
                //switch (op)
                //{
                //    case operation.Deposit:
                //        account.Deposit(amount);
                //        Console.WriteLine($"Deposited: ${amount}, New Balance: ${account.Balance}");
                //        break;
                //    case operation.Withdraw:
                //        if (amount > account.Balance)
                //        {
                //            Console.WriteLine("Error: Insufficient funds");
                //            return;
                //        }
                //        account.Withdraw(amount);
                //        Console.WriteLine($"Withdrew: ${amount}, New Balance: ${account.Balance}");
                //        break;
                //}


            #endregion

            #region Task_3 Automatic Property

            //    Student student = new Student();

            //    Console.Write("Enter Your Id: ");
            //    int id = Convert.ToInt32(Console.ReadLine());
            //    student.Id = id;

            //    Console.Write("Enter Your Full Name: ");
            //    string name = Console.ReadLine();
            //    student.FullName = name;

            //    Console.Write("Enter Your Grade: ");
            //    double grade = Convert.ToDouble(Console.ReadLine());
            //    student.Grade = grade;

            //student.DisplayInfo();

            #endregion
        }
    }
}
