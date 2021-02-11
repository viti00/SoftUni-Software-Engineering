using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int crypt = 0;
            string cryptedText = "";
            foreach (var ch in text)
            {
                crypt = (int)ch + 3;
                cryptedText += Convert.ToChar(crypt);
            }
            Console.WriteLine(cryptedText);
        }
    }
}
