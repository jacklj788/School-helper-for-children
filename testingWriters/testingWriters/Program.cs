using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingWriters
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamWriter writer = new StreamWriter("UserData.txt"))
            {
                writer.WriteLine("hadso");
            }

            string line;
            using (StreamReader reader = new StreamReader("UserData.txt"))
            {
                line = reader.ReadLine();
            }
            Console.WriteLine(line);

        }
    }
}
