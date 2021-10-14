using System;

namespace TheCaesarCipher
{
    class Program
    {
        static string alphabet = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

        static void Main()
        {
            int Shift;                                                 // сдвиг и его клон. 
            int Shift0;
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
        Back:                                                          // Метка goto (И снова простите за goto)
            Console.WriteLine("Введите сдвиг строки");                 // проверка на корректность сдвига
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

                if (indexOfChar == -1)                               // проверка на символы, котоыре не могут быть изменены шифром
                {
                    Console.Write(s);
                }
                else if (Shift >= 0)                                 //если сдвиг положительный
                {
                    Shift0 = Shift % 26;
                    indexOfChar += Shift0;
                    Console.Write(alphabet[indexOfChar]);
                }
                else                                                 //если отрицательный
                {
                    Shift0 = Shift * -1; 
                    Shift0 = Shift0 % 26;
                    indexOfChar = 26 +indexOfChar - Shift0;
                    Console.Write(alphabet[indexOfChar]);

                }
            }
        }
    }
}