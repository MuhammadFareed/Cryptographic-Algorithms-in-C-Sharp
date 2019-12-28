using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceaser_Cipher_Algorithm
{
    public class EncryptionAndDecryption
    {
        public char cipher(char alphabet, int key)
        {
            if(!char.IsLetter(alphabet))
            {
                return alphabet;
            }
            char check = char.IsUpper(alphabet) ? 'A' : 'a';
            return (char)((((alphabet + key) - check) % 26) + check);
        }

        public string makingCipher(string input, int key)
        {
            string output = string.Empty;
            foreach(char alph in input)
            {
                output += cipher(alph, key);
            }
            return output;
        }
        public string makingDecipher(string input, int key)
        {
            return makingCipher(input, (26 - key));
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            EncryptionAndDecryption endAndDec = new EncryptionAndDecryption();
            Console.Write("Enter a plain text : ");
            string plainText = Console.ReadLine();
            Console.Write("\nEnter the key : ");
            int key = int.Parse(Console.ReadLine());

            Console.Write("\nEncrypted Text : ");
            string cipherText = endAndDec.makingCipher(plainText, key);
            Console.WriteLine(cipherText);

            Console.Write("\nDecrypted Text : ");
            string simpleText = endAndDec.makingDecipher(cipherText, key);
            Console.WriteLine(simpleText);

            Console.ReadKey();
        }
    }
}
