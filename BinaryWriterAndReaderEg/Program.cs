using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryWriterAndReaderEg
{
    class Program
    {
        
        static void BinaryWriteFile()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(@"d:\binfile.txt", FileMode.Create)))
            {
                
                bw.Write(6);
                bw.Write("hello");
                bw.Write(7.5);
                bw.Write(false);
                 
            }
            
        }
        static void BinaryReadFile()
        {
           
            using (BinaryReader br = new BinaryReader(File.Open(@"d:\binfile.txt", FileMode.Open)))
            {
                Console.WriteLine("Integer Value : " + br.ReadInt32());
                Console.WriteLine("String Value : " + br.ReadString());
                Console.WriteLine("Double Value : " + br.ReadDouble());
                Console.WriteLine("Boolean Value : " + br.ReadBoolean());
            }
        }
        static void Main(string[] args)
        {
            BinaryWriteFile();
            BinaryReadFile();
            Console.ReadLine();
        }
    }
}

