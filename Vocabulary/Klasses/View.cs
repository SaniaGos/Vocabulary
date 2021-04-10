using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary.Klasses
{
    class View
    {
        static int row = 1;
        private static void CleanMenu()
        {
            Console.SetCursorPosition(40, 0);
            for (int i = 0; i < 22; i++)
            {
                Console.CursorLeft = 40;
                for (int j = 0; j < 35; j++)
                {
                    Console.Write(' ');
                }
                Console.CursorTop += 1;
            }
        }
        private static void CleanInformation()
        {
            Console.SetCursorPosition(0, 1);
            for (int i = 0; i < 20; i++)
            {
                Console.CursorLeft = 0;
                for (int j = 0; j < 40; j++)
                {
                    Console.Write(' ');
                }
                Console.CursorTop += 1;
            }
        }
        public static void Write()
        {
            if (row >= 20)
            {
                CleanInformation();
                row = 1;
                return;
            }
            row++;
        }
        public static void Write(string str)
        {
            if (row >= 20)
            {
                CleanInformation();
                row = 1;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(1, row);
            Console.Write(str);
            row++;
        }
        public static void Write(string word, List<string> arr)
        {
            Write($"Слово: \"{word}\"");
            foreach (string item in arr)
            {
                Write($"Переклад: \"{item}\"");
            }
            Write();
        }
        public static void ClearMainMenu()
        {
            Console.SetCursorPosition(40, 2);
            for (int i = 0; i < 6; i++)
            {
                Console.CursorLeft = 40;
                for (int j = 0; j < 35; j++)
                {
                    Console.Write(' ');
                }
                Console.CursorTop += 1;
            }
        }
        public static void OwnerMenu()
        {
            CleanMenu();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(50, 10); Console.Write("Меню");
            Console.SetCursorPosition(40, 11); Console.Write("1.Англо-Український словник");
            Console.SetCursorPosition(40, 12); Console.Write("2.Українсько-Англiйський словник");
            Console.SetCursorPosition(40, 13); Console.Write("Esc.Вийти з програми");
            Console.SetCursorPosition(40, 14); Console.Write("Зробiть свiй вибiр");
        }
        public static void SecondMenu()
        {
            CleanMenu();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(50, 10); Console.Write("Меню");
            Console.SetCursorPosition(40, 11); Console.Write("1.Добавити слово з перекладом");
            Console.SetCursorPosition(40, 12); Console.Write("2.Добавити переклад");
            Console.SetCursorPosition(40, 13); Console.Write("3.Змiнити переклад");
            Console.SetCursorPosition(40, 14); Console.Write("4.Видалити слово");
            Console.SetCursorPosition(40, 15); Console.Write("5.Видалити переклад");
            Console.SetCursorPosition(40, 16); Console.Write("6.Подивитися схожi слова");
            Console.SetCursorPosition(40, 17); Console.Write("7.Подивитися слово");
            Console.SetCursorPosition(40, 18); Console.Write("Esc.Попереднє меню");
            Console.SetCursorPosition(40, 19); Console.Write("To Continue press any key");
        }
    }
}
