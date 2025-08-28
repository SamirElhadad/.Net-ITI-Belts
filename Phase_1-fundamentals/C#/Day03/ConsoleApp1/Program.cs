namespace ConsoleApp1
{
    internal class Program
    {
        #region Enum Of Task_1

        enum PizzaSize
        {
            Small = 1,
            Medium,
            Large
        }
        enum PizzaPrice
        {
            Small = 10,
            Medium = 12,
            Large = 15
        }

        #endregion


        static void Main(string[] args)
        {
            #region Task_1 Pizza Order System (Enum)

            Console.WriteLine("Select Pizza Size: ");
            Console.WriteLine("1) Small: ");
            Console.WriteLine("2) Medium: ");
            Console.WriteLine("3) Large: ");
            Console.Write("Enter Your Fav Size : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice >= 1 && choice <= 3)
            {
                PizzaSize size = (PizzaSize)choice;
                PizzaPrice price = (PizzaPrice)Enum.Parse(typeof(PizzaPrice), size.ToString());

                Console.WriteLine($"You have selected {size} Pizza. and The Price is : ${(int)price}");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }


            #endregion

        }
    }
}
