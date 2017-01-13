using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password to be hashed... ");
            string pw = Console.ReadLine();
            Console.WriteLine();

            HashData hd = new HashData();
            Console.WriteLine("The has value for " + pw + " is: ");
            string pwh = hd.CreateHash(pw);

            Console.WriteLine(pwh);
        }
    }

    public class HashData
    {
        public string CreateHash(string input)
        {
            HashAlgorithm sha = SHA256.Create();
            byte[] hashData = sha.ComputeHash(Encoding.Default.GetBytes(input));
            return Convert.ToBase64String(hashData);
        }


    }
}