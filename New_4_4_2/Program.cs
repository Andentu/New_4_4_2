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
            anketa.age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Your name is {0}", anketa.name);
            Console.WriteLine("Your age is {0}", anketa.age);
            Console.ReadKey();
 
        
        }

    }
}