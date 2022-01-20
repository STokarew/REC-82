using System;
using System.Text;

namespace REC_82
{
    class Program
    {
        static StringBuilder codeOfCaesar(string originalString, int key)
        {
            String[] ABC = { "А", "а", "Б", "б", "В", "в", "Г", "г", "Д", "д", "Е", "е", "Ё", "ё", "Ж", "ж", "З", "з", "И", "и", "Й", "й", "К", "к", "Л", "л", "М", "м", "Н", "н", "О", "о", "П", "п", "Р", "р", "С", "с", "Т", "т", "У", "у", "Ф", "ф", "Х", "х", "Ц", "ц", "Ч", "ч", "Ш", "ш", "Щ", "щ", "Ъ", "ъ", "Ы", "ы", "Ь", "ь", "Э", "э", "Ю", "ю", "Я","я", };
            StringBuilder encryptedString = new StringBuilder("");
           // originalString = originalString.ToUpper();
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
            StringBuilder decryptedString = new StringBuilder("");
            key = -key;
            decryptedString = codeOfCaesar(encryptedString, key);
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
