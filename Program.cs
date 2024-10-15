using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        Console.Write("Введите сдвиг для шифра Цезаря: ");
        if (int.TryParse(Console.ReadLine(), out int shift))
        {
            string encryptedString = EncryptCaesar(inputString, shift);
            Console.WriteLine($"Зашифрованная строка: {encryptedString}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод сдвига.");
        }
    }

    static string EncryptCaesar(string text, int shift)
    {
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsLetter(chars[i]))
            {
                bool isUpper = char.IsUpper(chars[i]);
                char baseChar = isUpper ? 'A' : 'a';
                chars[i] = (char)((chars[i] - baseChar + shift) % 26 + baseChar);
            }
        }
        return new string(chars);
    }
}