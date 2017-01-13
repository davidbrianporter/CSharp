using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypting_Files
{
    class Program
    {
        static void Main(string[] args)
        {   
            ReadFile();
            Console.WriteLine("Press enter to encrypt the file");
            Console.ReadLine();

            EncryptFile(@"C:\Files\ml.txt");

            Console.WriteLine("Press enter to decrypt the file");
            Console.Read();

            DecryptFile(@"C:\Files\ml.txt");
        }

        public static void ReadFile()
        {
            int counter = 0;
            string line;

            //Read the file and display it line by line
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Files\ml.txt");
            while ((line = file.ReadLine()) != null)
                Console.WriteLine(line);
            counter++;

            file.Close();

        }

        public static void EncryptFile(string x)
        {
            File.Encrypt(x);
        }

        public static void DecryptFile(string x)
        {
            File.Decrypt(x);
        }
    }
}