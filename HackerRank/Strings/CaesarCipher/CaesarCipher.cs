using System;
using System.Text;

namespace CaesarCipher
{
    class CaesarCipher
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    result.Append(alphabet[(s[i] - 'a' + k) % 26]);
                }
                else if(s[i] >='A' && s[i] <='Z')
                {
                    result.Append(capitalLetters[(s[i] - 'A' + k) % 26]);
                }
                else
                {
                    result.Append(s[i]);
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
