using System;
using System.Net.Mail;

class hello
{ 
    public static void string_fun(string s1,string s2)
    {
        int len = s1.Length;
        // str.equals and str.compareto are all case sensitive so we need to check them by changing both of them into upper case 
        int b = s1.CompareTo(s2);
        bool b1 = s1.Contains(s2);
        bool eq=s1.Equals(s2);
        string s3 = s1.Insert(len,s2);
        string s4=s1.PadLeft(len, ' ');
        string s5 = s1.PadRight(len, ' ');
        string[] s66 = s1.Split('e');
        string strim=s1.Trim();
        System.Console.WriteLine(" len is {0}",len);
        System.Console.WriteLine(".contains() {0}",b1);
        System.Console.WriteLine(".compareTo() {0}", b);
        System.Console.WriteLine(".Equals() {0}", eq);
        System.Console.WriteLine(".insert() {0}", s3);
        System.Console.WriteLine(".padleft() {0}", s4);
        System.Console.WriteLine(".padright() {0}", s5);
        System.Console.WriteLine(" {0}", strim);

        foreach(string i in  s66)
        {
            System.Console.WriteLine(i);  
        }
        //concatnation in string
        System.Console.WriteLine("ENTER STRING 1");
        string c1=Console.ReadLine();
        System.Console.WriteLine("enter string 2 ");
        string c2=Console.ReadLine();
        string c3 = c1+c2;
        string c4 = string.Concat(c1, c2);
        Console.WriteLine(c3);
        Console.WriteLine(c4);
        // string interpolation 
        int age = 24;
        string name = "surendra";
        string greet = $"my name is {name} and my age is {age}";//string interpolation.
       Console.WriteLine(greet);
        //we can use string functions in {} for example
        string greet1=$"my name is {name.ToUpper()} and my age is {age}";
        Console.WriteLine(greet1);
        
        //string comparision enumaration(used to check equality of two strings without changing their case


    }

}
class main
{
    public static  void Main(string[] args)
    {
        hello.string_fun("hello", "surendra");
    }
}
