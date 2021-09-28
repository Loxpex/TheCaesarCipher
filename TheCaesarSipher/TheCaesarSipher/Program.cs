using System;

namespace TheCaesarCipher
{
    class Program
    {
        static string alphabet = "abcdefghijklmnopqrstuvwxyz";
        static void Main()
        {
            int Shift;
            int Shift0;
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
        Back:
            Console.WriteLine("Введите сдвиг строки");
            try
            {
                Shift = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели не число");
                Console.ReadKey();
                Console.Clear();
                goto Back;
            }
            Shift0 = Shift; 

            char[] words = text.ToCharArray();
            foreach (char s in words)
            {
                int indexOfChar = alphabet.IndexOf(s);

                if (indexOfChar == -1)
                {
                    Console.Write(" ");
                }
                else if (Shift >= 0)
                {
                    Shift0 = Shift % 26;
                    indexOfChar += Shift0;
                    Console.Write(alphabet[indexOfChar]);
                }
                else
                {
                    Shift0 = Shift * -1; 
                    Shift0 = Shift0 % 26;
                    indexOfChar = 26 - indexOfChar - Shift0;
                    Console.Write(alphabet[indexOfChar]);

                }
            }
        }
    }
}