namespace Lambda_Expression
{
    // They also work like Anonymous Expression
    // Lambda Expression can be used instead of Anonymous function as they are faster in writing
    // Two type of Lamba
    // 1. Statment Lambda does not return value implicitly
    // 2. Expression Lambda return value implicitly
    //    AND No curly braces

    public delegate int MyDelegate(int num);
    class Program
    {

        static void Main(string[] args)
        {
            //MyDelegate myDelegate =  (num) =>
            //{
            //    num += 5;
            //    Console.WriteLine(num);
            //};

            MyDelegate myDelegate = (num) => num * num;

            Console.WriteLine(myDelegate.Invoke(10));
            Console.WriteLine("Hello, World!");
        }
    }
}