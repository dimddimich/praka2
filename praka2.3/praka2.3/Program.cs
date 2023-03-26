using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praka2_3
{
    internal class programma // 3 задание
    {
        class CesarChifr
        {
            public char[] message;
            public int key;
            private char[] alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            public string Encrypt()
            {
                int number_symbol;
                int bias;
                string result;
                for (int i = 0; i < message.Length; i++)
                {
                    int m;
                    for (m = 0; m < alphabet.Length; m++)
                    {
                        if (message[i] == alphabet[m])
                        {
                            break;
                        }
                    }
                    if (m < 33)
                    {
                        number_symbol = m;
                        bias = number_symbol + key;
                        if (bias > 32)
                        {
                            bias = bias - 33;
                        }
                        message[i] = alphabet[bias];
                    }
                }
                result = new string(message);
                return result;
            }
            public string Decipher()
            {
                int number_symbol;
                int bias;
                string result;
                for (int i = 0; i < message.Length; i++)
                {
                    int m;
                    for (m = 0; m < alphabet.Length; m++)
                    {
                        if (message[i] == alphabet[m])
                        {
                            break;
                        }
                    }
                    if (m < 33)
                    {
                        number_symbol = m;
                        bias = number_symbol + (33 - key);



                        if (bias > 32)
                        {
                            bias = bias - 33;
                        }
                        message[i] = alphabet[bias];
                    }
                }
                result = new string(message);
                return result;
            }
        }


        class Program
        {
            static void Main()
            {
                CesarChifr cesar = new CesarChifr();
                Console.WriteLine("Используется нижний регистр русского языка");
                Console.Write("Текст на русском: ");
                string m = Convert.ToString(Console.ReadLine());
                m = m.ToLower();
                char[] message = m.ToCharArray();
                cesar.message = message;
                Console.Write("Введите ключ: ");
                cesar.key = Convert.ToInt32(Console.ReadLine());
                string result = cesar.Encrypt();
                Console.WriteLine("Зашифрованный текст: " + result);
                result = cesar.Decipher();
                Console.WriteLine("Расшифрованный текст: " + result);
                Console.ReadKey(true);
            }
        }
    }
}

