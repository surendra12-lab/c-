using System;

class newoperator
{
    public static void datatype()
    {
        bool b = new bool();
        System.Boolean b2 = true;
        float f=new float();
        int i=new int();
        DateTime dt=new DateTime();
        int i1 = default;
        // in .net 10 version only it support
        //bool b1 = new();
        //int i2=new();
        //double d=new();
       // DateTime dt2 = new();

        System.Console.WriteLine("{0},{1},{2},{3},{4}",b,b2,f,dt,i1);
    }
}
class main
{
    public static void Main(String[] args)
    {
        newoperator.datatype();
    }
}
