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

    }
}
class main
{
    public static void Main(string[] args)
    {
        members.prim_members();
    }
}
