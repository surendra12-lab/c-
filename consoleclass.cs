class hello
{ 
    public static void consolefunctions()
    {
        System.Console.Beep();
        System.Console.BackgroundColor = System.ConsoleColor.Green;
        System.Console.WriteLine("hai");
        System.Console.ForegroundColor = System.ConsoleColor.Blue;
        System.Console.BufferHeight = 10000;
        System.Console.BufferWidth = 1000;
        System.Console.WriteLine(System.Console.Title);
        System.Console.Title = "raju";
        System.Console.WriteLine(System.Console.Title);
        System.Console.WindowHeight = 600;
        System.Console.WindowLeft = 0;
        System.Console.WindowTop = 0;
        System.Console.WindowWidth = 500;
        System.Console.Clear();
        string b=System.Console.ReadLine();
       int a= System.Console.Read();
        System.Console.WriteLine("{0},{1}", b, a);
        System.Console.ReadKey();
    }
}
class main
{
    public static void Main(string[] args)
    {
        hello.consolefunctions();
    }
}
