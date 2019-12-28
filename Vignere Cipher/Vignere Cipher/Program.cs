using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vignere_Cipher
{
    class Program
    {
        private static int Check(int i, int j)
        {
            return (i % j + j) % j;
        }
        private static string Cipher(string input, string key, bool encipher)
        {
            for (int i = 0; i < key.Length; ++i)
                if (!char.IsLetter(key[i]))
                    return null;

            string output = string.Empty;
            int nonAlphaCharCount = 0;

            for (int i = 0; i < input.Length; ++i)
            {
                if (char.IsLetter(input[i]))
                {
                    bool cIsUpper = char.IsUpper(input[i]);
                    char offset = cIsUpper ? 'A' : 'a';
                    int keyIndex = (i - nonAlphaCharCount) % key.Length;
                    int k = (cIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;
                    k = encipher ? k : -k;
                    char ch = (char)((Check(((input[i] + k) - offset), 26)) + offset);
                    output += ch;
                }
                else
                {
                    output += input[i];
                    ++nonAlphaCharCount;
                }
            }

            return output;
        }

        public static string Encipher(string input, string key)
        {
            return Cipher(input, key, true);
        }

        public static string Decipher(string input, string key)
        {
            return Cipher(input, key, false);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your plain text : ");
            string plainText = Console.ReadLine();
            Console.Write("\nEnter your key : ");
            string key = Console.ReadLine();

            string cipherText = Encipher(plainText, key);
            Console.Write("\n\nEncrypted Data : " + cipherText);

            string deCipherText = Decipher(cipherText, key);
            Console.WriteLine("\n\nDecrypted Data : " + deCipherText);


            Console.ReadKey();
        }
    }
}
