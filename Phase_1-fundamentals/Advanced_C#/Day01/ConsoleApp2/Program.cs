namespace ConsoleApp2
{
     
    public class Program
    {
        static void UpdatePrice(ref Product product , double newPrice )
        {
            product.Price = newPrice;
            
        }
        static void Main(string[] args)
        {
            //var product1 = new Product { Name = "Laptop", Price = 1500.00};
            //var product2 = new Product { Name = "Phone" , Price = 8000.00 };
            //var product3 = new Product { Name = "Tablet", Price = 6000.00 };

            Box<Product> box1 = new Box<Product> { Item = new Product { Name = "Laptop", Price = 1500.00 } };
            Box<Product> box2 = new Box<Product> { Item = new Product { Name = "Phone", Price = 8000.00 } };
            Box<Product> box3 = new Box<Product> { Item = new Product { Name = "Tablet", Price = 6000.00 } };

            Console.WriteLine("===> All Products <===");
            box1.ShowInfo();
            box2.ShowInfo();
            box3.ShowInfo();

            Product temp = box1.Item;
            UpdatePrice(ref temp, 2000.00);
            box1.Item = temp;

            Console.WriteLine("\n===> After Price Update <===");
            box1.ShowInfo();

           
            List<Product> products = new List<Product> { box1.Item , box2.Item, box3.Item };

            var expensiveProducts = products.Where(p => p.Price > 7000);

            Console.WriteLine("\n===> Expensive Products (> 7000) <===");
            foreach (var p in expensiveProducts)
            {
                Console.WriteLine($"{p.Name} ==> {p.Price}");
            }

        }
    }
}
