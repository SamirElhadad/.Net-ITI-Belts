namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Draw();
            circle.Move();
            circle.Resize();


            Rectangle rectangle = new Rectangle();
            rectangle.Draw();
            rectangle.Move();
            rectangle.Resize();
        }
    }
}
