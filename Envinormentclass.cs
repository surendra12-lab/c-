
using System;

static class hello
{ 
    public static void showenvinormentDetails()
    {
        // priting drives in a machine
        foreach(string s in Environment.GetLogicalDrives())
        {
            Console.WriteLine("drives is {0}", s);
        }
        Console.WriteLine(Environment.OSVersion);
        Console.WriteLine(Environment.ProcessorCount);
        Console.WriteLine(Environment.Version);
        Console.WriteLine(Environment.ExitCode);
        Console.WriteLine(Environment.Is64BitOperatingSystem);
        Console.WriteLine(Environment.MachineName);
        Console.WriteLine(Environment.NewLine);
        //Console.WriteLine(Environment.ProcessId) in version 10.0 it is applicable
        Console.WriteLine(Environment.SystemDirectory);
        Console.WriteLine(Environment.UserName);
        Console.WriteLine(Environment.CurrentManagedThreadId);
        Console.WriteLine(Environment.HasShutdownStarted);
        Console.WriteLine(Environment.WorkingSet);
        Console.WriteLine(Environment.UserDomainName);
        Console.WriteLine(Environment.TickCount);
        Console.WriteLine(Environment.UserInteractive);
        String desk_path=Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        Console.WriteLine(desk_path);

        Console.WriteLine(Environment.GetEnvironmentVariable("path"));
        Console.WriteLine(Environment.GetCommandLineArgs());
        Environment.FailFast("critical error");

        //Console.WriteLine(Environment.ExpandEnvironmentVariables);used to extend path like %temp%

    }
}


class main
{
     public static void Main(String[] args)
    {
        hello.showenvinormentDetails();
       // Console.WriteLine(Environment.StackTrace);
    }


}
