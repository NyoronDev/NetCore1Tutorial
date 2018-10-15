using Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a message that you want to encrypt: ");
            var message = Console.ReadLine();

            Console.WriteLine("Enter a password: ");
            var password = Console.ReadLine();

            var cryptoText = Protector.Encrypt(message, password);
            Console.WriteLine($"Encrypted text: {cryptoText}");

            var clearText = Protector.Decrypt(cryptoText, password);
            Console.WriteLine($"Decrypted text: {clearText}");

            Console.ReadLine();
        }
    }
}