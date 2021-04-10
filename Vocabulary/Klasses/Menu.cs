using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary.Klasses
{
    class Menu
    {
        private static event Action<int> menu;
        private static MyVocabulary vocabulary = null;
        private static string path = null;
        private static string word, translateWord, newTranslateWord;
        private static void OvnerMenu()
        {
            //Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);
            View.OwnerMenu();
            while (true)
            {
                Console.SetCursorPosition(40, 15);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.D1:
                        path = "English-Ukrainian.xml";
                        vocabulary = SerializeVocabularu.LoadVocab(path);
                        SecondMenu(path, vocabulary);
                        break;
                    case ConsoleKey.D2:
                        path = "Ukrainian-English.xml";
                        vocabulary = SerializeVocabularu.LoadVocab(path);
                        SecondMenu(path, vocabulary);
                        break;
                    case ConsoleKey.NumPad1:
                        path = "English-Ukrainian.xml";
                        vocabulary = SerializeVocabularu.LoadVocab(path);
                        SecondMenu(path, vocabulary);
                        break;
                    case ConsoleKey.NumPad2:
                        path = "Ukrainian-English.xml";
                        vocabulary = SerializeVocabularu.LoadVocab(path);
                        SecondMenu(path, vocabulary);
                        break;
                    default:
                        break;
                }
            }
        }
        private static void SecondMenu(string path, MyVocabulary vocabulary)
        {
            View.SecondMenu();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(40, 1);
            Console.Write(vocabulary.name);

            while (true)
            {
                Console.SetCursorPosition(40, 20);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        SerializeVocabularu.WriteVocab(path, vocabulary);
                        View.OwnerMenu();
                        return;
                    case ConsoleKey.D1:
                        menu(1);
                        break;
                    case ConsoleKey.D2:
                        menu(2);
                        break;
                    case ConsoleKey.D3:
                        menu(3);
                        break;
                    case ConsoleKey.D4:
                        menu(4);
                        break;
                    case ConsoleKey.D5:
                        menu(5);
                        break;
                    case ConsoleKey.D6:
                        menu(6);
                        break;
                    case ConsoleKey.D7:
                        menu(7);
                        break;
                    case ConsoleKey.D8:
                        break;
                    case ConsoleKey.D9:
                        break;
                    case ConsoleKey.NumPad1:
                        menu(1);
                        break;
                    case ConsoleKey.NumPad2:
                        menu(2);
                        break;
                    case ConsoleKey.NumPad3:
                        menu(3);
                        break;
                    case ConsoleKey.NumPad4:
                        menu(4);
                        break;
                    case ConsoleKey.NumPad5:
                        menu(5);
                        break;
                    case ConsoleKey.NumPad6:
                        menu(6);
                        break;
                    case ConsoleKey.NumPad7:
                        menu(7);
                        break;
                    case ConsoleKey.NumPad8:
                        break;
                    case ConsoleKey.NumPad9:
                        break;
                    default:
                        break;
                }
            }
        }
        public static void Start()
        {
            menu += AddWord;
            menu += AddTranslate;
            menu += ChangeTranslate;
            menu += DelWord;
            menu += DelTranslate;
            menu += FindWord;
            menu += FindContainsWord;
            OvnerMenu();
        }
        private static void AddWord(int num)
        {
            if (num != 1) return;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(40, 2);
            Console.Write("Введiть слово: "); word = Console.ReadLine();
            Console.SetCursorPosition(40, 3);
            Console.Write("Введiть переклад: "); translateWord = Console.ReadLine();
            vocabulary.AddWord(word, translateWord);
            View.ClearSmallMenu();
        }
        private static void AddTranslate(int num)
        {
            if (num != 2) return;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(40, 2);
            Console.Write("Введiть слово: "); word = Console.ReadLine();
            Console.SetCursorPosition(40, 3);
            Console.Write("Введiть переклад: "); translateWord = Console.ReadLine();
            vocabulary.AddTranslate(word, translateWord);
            View.ClearSmallMenu();
        }
        private static void ChangeTranslate(int num)
        {
            if (num != 3) return;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(40, 2);
            Console.Write("Введiть слово: "); word = Console.ReadLine();
            Console.SetCursorPosition(40, 3);
            Console.Write("Введiть переклад: "); translateWord = Console.ReadLine();
            Console.SetCursorPosition(40, 4);
            Console.Write("Введiть новий переклад: "); newTranslateWord = Console.ReadLine();
            vocabulary.ChangeTranslate(word, translateWord, newTranslateWord);
            View.ClearSmallMenu();
        }
        private static void DelWord(int num)
        {
            if (num != 4) return;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(40, 2);
            Console.Write("Введiть слово: "); word = Console.ReadLine();
            vocabulary.DelWord(word);
            View.ClearSmallMenu();
        }
        private static void DelTranslate(int num)
        {
            if (num != 5) return;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(40, 2);
            Console.Write("Введiть слово: "); word = Console.ReadLine();
            Console.SetCursorPosition(40, 3);
            Console.Write("Введiть переклад: "); translateWord = Console.ReadLine();
            vocabulary.DelTranslate(word, translateWord);
            View.ClearSmallMenu();
        }
        private static void FindWord(int num)
        {
            if (num != 6) return;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(40, 2);
            Console.Write("Введiть слово: "); word = Console.ReadLine();
            vocabulary.FindContainsWord(word);
            View.ClearSmallMenu();
        }
        private static void FindContainsWord(int num)
        {
            if (num != 7) return;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(40, 2);
            Console.Write("Введiть слово: "); word = Console.ReadLine();
            vocabulary.FindWord(word);
            View.ClearSmallMenu();
        }

    }

}
