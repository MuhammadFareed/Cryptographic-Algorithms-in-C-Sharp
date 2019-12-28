using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyAlphabetic_Cipher_Algorithm
{
    public class EnctyptionAndDecryption
    {
        Dictionary<char, char> m1 = new Dictionary<char, char>()
        {
            {'a','a'},
            {'b','s'},
            {'c','d'},
            {'d','f'},
            {'e','g'},
            {'f','h'},
            {'g','j'},
            {'h','k'},
            {'i','l'},
            {'j','p'},
            {'k','o'},
            {'l','i'},
            {'m','u'},
            {'n','y'},
            {'o','t'},
            {'p','r'},
            {'q','e'},
            {'r','w'},
            {'s','q'},
            {'t','z'},
            {'u','x'},
            {'v','c'},
            {'w','v'},
            {'x','b'},
            {'y','n'},
            {'z','m'},
            {'*','*'},
            {' ',' '},
            {',',','},
            {'.','.'},
            {'!','!'},
            {';',';'}
        };
        Dictionary<char, char> m2 = new Dictionary<char, char>()
        {
            {'a','q'},
            {'b','a'},
            {'c','z'},
            {'d','w'},
            {'e','s'},
            {'f','x'},
            {'g','e'},
            {'h','d'},
            {'i','c'},
            {'j','r'},
            {'k','f'},
            {'l','v'},
            {'m','t'},
            {'n','g'},
            {'o','b'},
            {'p','y'},
            {'q','h'},
            {'r','n'},
            {'s','u'},
            {'t','p'},
            {'u','j'},
            {'v','m'},
            {'w','i'},
            {'x','k'},
            {'y','o'},
            {'z','l'},
            {'*','*'},
            {' ',' '},
            {',',','},
            {'.','.'},
            {'!','!'},
            {';',';'}
        };
        Dictionary<char, char> m3 = new Dictionary<char, char>()
        {
            {'a','z'},
            {'b','x'},
            {'c','c'},
            {'d','v'},
            {'e','b'},
            {'f','n'},
            {'g','m'},
            {'h','k'},
            {'i','i'},
            {'j','o'},
            {'k','p'},
            {'l','l'},
            {'m','u'},
            {'n','j'},
            {'o','h'},
            {'p','y'},
            {'q','t'},
            {'r','g'},
            {'s','f'},
            {'t','r'},
            {'u','e'},
            {'v','d'},
            {'w','s'},
            {'x','w'},
            {'y','q'},
            {'z','a'},
            {'*','*'},
            {' ',' '},
            {',',','},
            {'.','.'},
            {'!','!'},
            {';',';'}
        };
        public string makingCipher(string pt)
        {
            string cipheredText = "";
            for (int i = 0; i < pt.Length ; i++)
            {
                cipheredText += m1[pt[i]];
                i += 1;
                cipheredText += m2[pt[i]];
                i += 1;
                cipheredText += m3[pt[i]];
            }
            return cipheredText;
        }
        public string makingDeCipher(string ct)
        {
            string decipheredText = "";
            for (int i = 0; i < ct.Length; i++)
            {
                decipheredText += (m1.FirstOrDefault(x => x.Value == ct[i]).Key);
                i += 1;
                decipheredText += (m2.FirstOrDefault(x => x.Value == ct[i]).Key);
                i += 1;
                decipheredText += (m3.FirstOrDefault(x => x.Value == ct[i]).Key);
            }

            return decipheredText;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EnctyptionAndDecryption ed = new EnctyptionAndDecryption();

            Console.Write("Enter your plain text : ");
            string plainText = Console.ReadLine();
            plainText = plainText.ToLower();
            
            int lenthForPlainText = plainText.Length;
            if (lenthForPlainText % 3 == 1)
                plainText += "**";
            else if (lenthForPlainText % 3 == 2)
                plainText += "*";
    
            string cipherText = ed.makingCipher(plainText);
            Console.Write("\nEncrypted data : " );

            for (int i = 0; i < lenthForPlainText; i++)
            {
                Console.Write(cipherText[i]);
            }

            string deCipherText = ed.makingDeCipher(cipherText);
            Console.Write("\n\nDecrypted data : " );

            for (int i = 0; i < lenthForPlainText; i++)
            {
                Console.Write(deCipherText[i]);
            }
           
            Console.ReadKey();
        }
    }
}
