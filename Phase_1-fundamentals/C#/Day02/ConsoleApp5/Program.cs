namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_5 Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

                Console.Write("Enter your char: ");
                char ch = char.Parse(Console.ReadLine());
                char[] vowelStr = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' }
                ;
                foreach (char i in vowelStr)
                {
                    if (ch == i)
                    {
                        Console.WriteLine("Vowel");
                        return;
                    }
                }
                Console.WriteLine("Consonant");
                
            #endregion
        }
    }
}
