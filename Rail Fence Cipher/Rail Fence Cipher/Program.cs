using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rail_Fence_Cipher
{
    public class Cipher
    {
        public string makingCipher(string text)
        {
            string odd = "";
            string even = "";
            for(int i = 0 ; i < text.Length ; i++)
            {
                if(i%2 != 0)
                {
                    odd += text[i];
                }
                else
                {
                    even = even + text[i];
                }
            }
            return (even + odd);
        }

        public string makingDecipher(string deCipherText)
        {
            string oddPosition = "";
            string evenPosition = "";
            string originalText = "";
            int j = 0;
            for (j=0 ; j < (deCipherText.Length)/2; j ++)
            {
                evenPosition += deCipherText[j];
            }

            for ( ; j <deCipherText.Length ; j ++)
            {
                oddPosition += deCipherText[j];
            }

            for (int k = 0; k < (deCipherText.Length)/2 ; k++ )
            {
                originalText += evenPosition[k];
                originalText += oddPosition[k];
            }

                return originalText;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cipher c = new Cipher();

            Console.Write("Enter a plain text : ");

            string plainText = Console.ReadLine();
            string cipherText = c.makingCipher(plainText);
            Console.Write("\nEncrypted Text : " + cipherText);

            
            string deCipherText = c.makingDecipher(cipherText);
            Console.Write("\nDecrypted Text : " + deCipherText);

            Console.ReadKey();
        }
    }
}
