using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Работа_с_файловой_подсистемой
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("D:\\startup.txt", Console.ReadLine());
            File.AppendAllText("D:\\startup.txt","\n" + DateTime.Now.ToString());

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("space.bin", FileMode.OpenOrCreate), Console.ReadLine());

        }
    }
}
