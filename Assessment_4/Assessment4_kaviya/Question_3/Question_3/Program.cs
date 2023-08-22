using System;
using System.IO;
using System.IO.Enumeration;
using System.Xml.Linq;

class program
{
    public static void Main(string[] args)
    {
        //DirecroryInfo
        DirectoryInfo mydir = new DirectoryInfo(@"C:\Users\Public");
 
        foreach (DirectoryInfo d in mydir.GetDirectories())
        {
            Console.WriteLine(d.FullName);
           
        }
        DateTime time = File.GetCreationTime(@"C:\Users\Public");
        Console.WriteLine("The public directory is created on :" + time);

    }
}