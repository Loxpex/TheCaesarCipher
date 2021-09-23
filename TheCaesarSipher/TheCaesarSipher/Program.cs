using System;

namespace TheCaesarCipher
{
    class Program
    {
        static string alphabet = "abcdefghijklmnopqrstuvwxyz";
        static void Main()
        {
            int Shift;
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


            char[] words = text.ToCharArray();
            foreach (char s in words)
            {
                int indexOfChar = alphabet.IndexOf(s);

                if (indexOfChar == -1)
                {
                    Console.Write(" ");
                }
                else if (indexOfChar + Shift < 26)
                {
                    indexOfChar += Shift;
                    Console.Write(alphabet[indexOfChar]);
                }
                else
                {
                    indexOfChar = indexOfChar + Shift - 26;
                    Console.Write(alphabet[indexOfChar]);

                }
            }
        }
    }
}