using System;
using System.IO;
using System.IO.Enumeration;
using System.Xml.Linq;

class program
{
    public static void Main(string[] args)
    {
        FileStream fs = new FileStream(@"C:\Users\STS778-KAVIYASHRI TV\Desktop\web\Assessment4_kaviya\question2.txt file", FileMode.OpenOrCreate);
        //StreamWriter
        BinaryWriter c = new BinaryWriter(fs);
        c.Write(78);
        c.Write(45.5);
        c.Write(true);
        c.Write("This is kaviya shri");
        c.Close();//closing binary Writer
        fs.Close();
        Console.WriteLine("Writer has been closed\n");
        FileStream f = new FileStream(@"C:\Users\STS778-KAVIYASHRI TV\Desktop\web\Assessment4_kaviya\question2.txt file", FileMode.Open);
        //binaryReader
        BinaryReader sr = new BinaryReader(f);
        Console.WriteLine("Reader has been executing:");
        Console.WriteLine("Integer Value : " + sr.ReadInt32 ());
        Console.WriteLine("Double Value : " +sr.ReadDouble());
        Console.WriteLine("Boolean Value : " + sr.ReadBoolean());
        Console.WriteLine("String value :"+sr.ReadString());
        sr.Close();
        f.Close();

    }
  
}