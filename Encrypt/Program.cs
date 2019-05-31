using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");

            string text = Console.ReadLine();

            using (var file = File.CreateText("Hashed Text.txt"))
            {
                file.WriteLine(DataEncrypter.HashString(text) + " - " + text);
            }
        }
    }
}
