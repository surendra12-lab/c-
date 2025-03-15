class members
{
    public static void prim_members()
    {
        //members of numeric datatypes.
        System.Console.WriteLine("{0}",int.MaxValue);
        System.Console.WriteLine("{0}", int.MinValue);
        System.Console.WriteLine("{0}", float.MaxValue);
        System.Console.WriteLine("{0}", float.MinValue);
        System.Console.WriteLine("{0}", double.MaxValue);
        System.Console.WriteLine("{0}", double.MinValue);
        System.Console.WriteLine("{0}", double.Epsilon);
        System.Console.WriteLine("{0}", double.PositiveInfinity);
        System.Console.WriteLine("{0}", double.NegativeInfinity);
        //members of system.Boolean
        System.Console.WriteLine("{0}", bool.TrueString);
        System.Console.WriteLine("{0}", bool.FalseString);
        //members of System.Char
        System.Console.WriteLine("{0}", char.IsDigit('5'));
        System.Console.WriteLine("{0}", char.IsLetter('h'));
        System.Console.WriteLine("{0}", char.IsWhiteSpace("hello ",5));// indexing from zero position
        System.Console.WriteLine("{0}", char.IsPunctuation('?'));
        //parse and tryparse
        bool b = bool.Parse("True");
       int i = int.Parse("23");
       double d = double.Parse("23.456");
       c = char.Parse("h");
       String k1=Console.ReadLine();
      int.TryParse(k1, out int k);
       Console.WriteLine(k);

    }
}
class main
{
    public static void Main(string[] args)
    {
        members.prim_members();
    }
}
