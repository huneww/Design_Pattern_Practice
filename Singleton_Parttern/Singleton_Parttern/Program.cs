namespace Singleton_Parttern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test.Instance.testInt);
            Test.Instance.testInt++;
            Console.WriteLine(Test.Instance.testInt);
        }
    }
}