using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//Домашнее задание 6.1. Написать программу, которая вычисляет число гласных и согласных букв в файле.
class Program
{
    static void Main()
    {
        string file = @"C:\Users\user\source\repos\21.09.23\задание 6.1.\1дзинфабез (1).txt";

        try
        {
            List<char> chars = ReadFile(file);
            int vowels = CntV(chars);
            int consonants = CntC(chars);

            Console.WriteLine("кол-во гласных: {0}", vowels);
            Console.WriteLine("кол-во согласных: {1}", consonants);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static List<char> ReadFile(string file)
    {
        List<char> chars = new List<char>();

        using (StreamReader l = new StreamReader(file))
        {
            while (!l.EndOfStream)
            {
                string line = l.ReadLine();
                foreach (char i in line)
                {
                    chars.Add(i);
                }
            }
        }

        return chars;
    }
    /// <summary>
    /// для подсчёта гласных
    /// </summary>
    /// <param name="chars"></param>
    /// <returns></returns>
    static int CntV(List<char> chars)
    {
        int cnt = 0;
        string v = "aeiouаеёиоуыэюя";

        foreach (char i in chars)
        {
            if (v.Contains(char.ToLower(i)))
            {
                cnt++;
            }
        }

        return cnt;
    }
    /// <summary>
    /// для подсчёта согласных
    /// </summary>
    /// <param name="chars"></param>
    /// <returns></returns>
    static int CntC(List<char> chars)
    {
        int cnt = 0;
        string c = "bcdfghjklmnpqrstvwxyzбвгджзклмнпрстфхцчшщ";

        foreach (char i in chars)
        {
            if (c.Contains(char.ToLower(i)))
            {
                cnt++;
            }
        }

        return cnt;
    }
}
