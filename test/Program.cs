using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Дана символьная строка. Определить длину самой длинной подстроки из подряд стоящих букв «а».
//Использовал вспомогательную строку

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aaaaaasdaaaasddfiuaaaaaoiuoijohaaihoh";
            char ch = 'a';

            //формируем вспомогательную строку "aaaaa aaa aaaa a "

            string additionalString = "";

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == ch && str[i - 1] == ch)
                {
                    additionalString += ch;
                }
                else
                {
                    if (!additionalString.EndsWith(" "))
                    {
                        additionalString += " ";    
                    }
                }
            }

            //Сплит
            string[] words = additionalString.Split(' ');

            List<string> list = new List<string>();
            list.AddRange(words);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "")
                {
                    list.RemoveAt(i);
                }
            }

            int max = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length > max)
                {
                    max = list[i].Length;
                }
            }

            int result = max + 1;

            Console.ReadLine();
        }
    }
}