namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sum of Natural Numbers 

            //int SumNumbers(int num)
            //{
            //    if (num <= 1) return num;
            //    return num + SumNumbers(num - 1);
            //}

            //Console.Write($"Enter your number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int result = SumNumbers(number);
            //Console.WriteLine($"The Sum is : {result}");

            #endregion

            #region Product of Natural Numbers 

            //int ProductNumbers(int num)
            //{
            //    if (num <= 1) return 1;
            //    return num * ProductNumbers(num - 1);
            //}
            //Console.Write($"Enter your number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int result = ProductNumbers(number);
            //Console.WriteLine($"The Factorial is : {result}");

            #endregion

            #region Place Order

            //void PlaceOrder(string productName, int quantity = 1, string customer = "Guest", bool expressDelivery = false)
            //{
            //    Console.WriteLine($"Product: {productName} | Quantity: {quantity} | Customer: {customer} | Express Delivery: {expressDelivery}");
            //}


            //PlaceOrder("Laptop");
            //PlaceOrder("Keyboard", 5);
            //PlaceOrder(productName: "Monitor", customer: "Alice", expressDelivery: true, quantity: 2);

            #endregion

            #region Discounted Order

            //void PlaceOrder(string productName, int quantity = 1, string customer = "Guest", bool expressDelivery = false, double discount = 0)
            //{
            //    double pricePerProduct = 100;
            //    double total = quantity * pricePerProduct;
            //    if (discount > 0)
            //    {
            //        double discountedTotal = total * (1 - discount);
            //        Console.WriteLine($"Product: {productName} | Quantity: {quantity} | Customer: {customer} | Express Delivery: {expressDelivery} | Discount: {discount * 100}% | Total Price: ${discountedTotal}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Product: {productName} | Quantity: {quantity} | Customer: {customer} | Express Delivery: {expressDelivery}");
            //    }
            //}

            //PlaceOrder("Tablet", 2, "Bob", true, 0.1);

            #endregion

            #region Extension Method – Reverse String 

            //string message = "hello";
            //Console.WriteLine(message.ReverseText());

            #endregion

            #region Extension Method – Character Count

            //string message = "Hello";
            //Console.WriteLine($"The Count Characters of \"{message}\" is : {message.CountCharacters()}");

            #endregion

            #region Extension Method – IsEven

            //int x = 7;
            //int y = 8;

            //Console.WriteLine($"The {x} is Even : {x.IsEven()}");
            //Console.WriteLine($"The {y} is Even : {y.IsEven()}");

            #endregion

            #region Extension Method – IsPrime

            //int x = 7;
            //int y = 8;
            //Console.WriteLine($"The Number {x} is prime : {x.IsPrime()}");
            //Console.WriteLine($"The Number {y} is prime : {y.IsPrime()}");

            #endregion

            #region Records

            //Product p1 = new Product(1, "Laptop", 1500);
            //Product p2 = new Product(1, "Laptop", 1500);
            //Console.WriteLine($"The Product is Equles ? {p1 == p2}");

            #endregion

            #region Record with Deconstruction

            //var p1 = new Product(1, "Laptop", 1500);
            //var (id, name, price) = p1;

            //Console.WriteLine($"Id: {id}, Name: {name}, Price: {price}");

            #endregion

        }
    }
}
