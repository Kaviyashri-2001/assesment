using System;
using System.IO;
using System.IO.Enumeration;
using System.Xml.Linq;

class program
{
    public static void Main(string[] args)
    {
        FileStream fs = new FileStream(@"C:\Users\STS778-KAVIYASHRI TV\Desktop\web\Assessment4_kaviya\question1.txt file", FileMode.OpenOrCreate);
        //StreamWriter
        StreamWriter c = new StreamWriter(fs);
        c.WriteLine("File handling sample prgm");
        c.WriteLine("It is here stream writer and reader has been created");
        c.WriteLine("It is Inside the exception handling block");
        c.Close();//closing Stream Writer
        fs.Close();
        Console.WriteLine("Writer has been closed\n");

        try
        {
            FileStream f = new FileStream(@"C:\Users\STS778-KAVIYASHRI TV\Desktop\web\Assessment4_kaviya\question1.txt file", FileMode.Open);
            //StreamReader
            StreamReader sr = new StreamReader(f);
            Console.WriteLine("Reader has been executing:");
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
            sr.Close();
            f.Close();
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Reader has been closed\n");
        }
    }
}