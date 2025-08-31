namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BaseClass baseClass = new BaseClass();
            baseClass.ShowMessage();

            MiddleClass obj = new MiddleClass();
            obj.ShowMessage();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.ShowMessage();

        }
    }
}
