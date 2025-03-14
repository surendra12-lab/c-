using System;

class formatting
{ 
    public static void formatfun()
    {
        Console.WriteLine("number is {0:c}", 99999);
        Console.WriteLine("number is {0:d4}", 99999);
        Console.WriteLine("number is {0:e3}", 99999);
        Console.WriteLine("number is {0:f4}", 99999);
        Console.WriteLine("number is {0:g}", 99999);
        Console.WriteLine("number is {0:n}", 99999);
        Console.WriteLine("number is {0:x}", 99999);
        Console.WriteLine("number is {0:X}", 99999);


    }
}
class main
{ 
    public static void Main(String[] args)
    {
        formatting.formatfun();
    }
}

