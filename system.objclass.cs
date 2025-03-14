class objclass
{
    public static void objectt()
    {
        System.Console.WriteLine(12.GetHashCode());
        System.Console.WriteLine(12.ToString());
        System.Console.WriteLine(12.Equals(12));
        System.Console.WriteLine(12.GetType());
    }
}
class main
{
    public static void Main(string[] args)
    {
        objclass.objectt();
    }
}
