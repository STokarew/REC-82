using System;
using System.Text;

namespace REC_82
{
    class Program
    {
        static StringBuilder codeOfCaesar(string originalString, int key)
        {
            String[] ABC = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
            StringBuilder encryptedString = new StringBuilder("");
            originalString = originalString.ToUpper();
            for (int i = 0; i < originalString.Length; i++)
            {
                string result = originalString[i].ToString();
                if (result == " ")
                {
                    encryptedString.Insert(encryptedString.Length, result);
                }
                else
                {
                    for (int j = 0; j < ABC.Length; j++)
                    {
                        if (result == ABC[j])
                        {
                            encryptedString.Insert(encryptedString.Length, ABC[(ABC.Length + j + key) % ABC.Length]);
                            break;
                        }
                    }
                }
                
            }
            return encryptedString;
        }

        static StringBuilder uncodeOfCaesar(string encryptedString, int key)
        {
            String[] ABC = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
            StringBuilder decryptedString = new StringBuilder("");
            for (int i = 0; i < encryptedString.Length; i++)
            {
                string result = encryptedString[i].ToString();
                if (result == " ")
                {
                    decryptedString.Insert(decryptedString.Length, result);
                }
                else
                {
                    for (int j = 0; j < ABC.Length; j++)
                    {
                        if (result == ABC[j])
                        {
                            decryptedString.Insert(decryptedString.Length, ABC[(ABC.Length + j - key) % ABC.Length]);
                            break;
                        }
                    }
                }
                
            }
            return decryptedString;
        }


        static void Main(string[] args)
        {
            Console.Write("Введите строку для шифра: ");
            string originalString = Console.ReadLine();
            Console.Write("Введите ключ: ");
            int key = int.Parse(Console.ReadLine());
            originalString =codeOfCaesar(originalString, key).ToString();
            Console.WriteLine(originalString);
            originalString = uncodeOfCaesar(originalString, key).ToString();
            Console.Write(originalString);
            Console.ReadKey();
        }
    }
}
