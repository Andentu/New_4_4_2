namespace New_4_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;
            Console.WriteLine("Enter your name: ");
            anketa.name =  Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            anketa.age = int.Parse(Console.ReadLine());
        }
    }
}