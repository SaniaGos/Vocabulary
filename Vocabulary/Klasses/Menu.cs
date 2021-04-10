using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary.Klasses
{
    class Menu
    {

        public static void OvnerMenu()
        {
            MyVocabulary vocabulary = null;
            string path = null;
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
            string word, translateWord, newTranslateWord;
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
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        Console.SetCursorPosition(40, 3);
                        Console.Write("Введiть переклад: "); translateWord = Console.ReadLine();
                        vocabulary.AddWord(word, translateWord);
                        View.ClearMainMenu();
                        break;
                    case ConsoleKey.D2:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        Console.SetCursorPosition(40, 3);
                        Console.Write("Введiть переклад: "); translateWord = Console.ReadLine();
                        vocabulary.AddTranslate(word, translateWord);
                        View.ClearMainMenu();
                        break;
                    case ConsoleKey.D3:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        Console.SetCursorPosition(40, 3);
                        Console.Write("Введiть переклад: "); translateWord = Console.ReadLine();
                        Console.SetCursorPosition(40, 3);
                        Console.Write("Введiть новий переклад: "); newTranslateWord = Console.ReadLine();
                        vocabulary.ChangeTranslate(word, translateWord, newTranslateWord);
                        View.ClearMainMenu();
                        break;
                    case ConsoleKey.D4:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        vocabulary.DelWord(word);
                        View.ClearMainMenu();
                        break;
                    case ConsoleKey.D5:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        Console.SetCursorPosition(40, 3);
                        Console.Write("Введiть переклад: "); translateWord = Console.ReadLine();
                        vocabulary.DelTranslate(word, translateWord);
                        View.ClearMainMenu();
                        break;
                    case ConsoleKey.D6:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        vocabulary.FindContainsWord(word);
                        View.ClearMainMenu();
                        break;
                    case ConsoleKey.D7:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        vocabulary.FindWord(word);
                        View.ClearMainMenu();
                        break;
                    case ConsoleKey.D8:
                        break;
                    case ConsoleKey.D9:
                        break;
                    case ConsoleKey.NumPad1:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        Console.SetCursorPosition(40, 3);
                        Console.Write("Введiть переклад: "); translateWord = Console.ReadLine();
                        vocabulary.AddWord(word, translateWord);
                        View.ClearMainMenu();
                        break;
                    case ConsoleKey.NumPad2:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        Console.SetCursorPosition(40, 3);
                        Console.Write("Введiть переклад: "); translateWord = Console.ReadLine();
                        vocabulary.AddTranslate(word, translateWord);
                        View.ClearMainMenu();
                        break;
                    case ConsoleKey.NumPad3:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        Console.SetCursorPosition(40, 3);
                        Console.Write("Введiть переклад: "); translateWord = Console.ReadLine();
                        Console.SetCursorPosition(40, 3);
                        Console.Write("Введiть новий переклад: "); newTranslateWord = Console.ReadLine();
                        vocabulary.ChangeTranslate(word, translateWord, newTranslateWord);
                        View.ClearMainMenu();
                        break;
                    case ConsoleKey.NumPad4:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        vocabulary.DelWord(word);
                        View.ClearMainMenu();
                        break;
                    case ConsoleKey.NumPad5:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        Console.SetCursorPosition(40, 3);
                        Console.Write("Введiть переклад: "); translateWord = Console.ReadLine();
                        vocabulary.DelTranslate(word, translateWord);
                        View.ClearMainMenu();
                        break;
                    case ConsoleKey.NumPad6:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        vocabulary.FindContainsWord(word);
                        View.ClearMainMenu();
                        break;
                    case ConsoleKey.NumPad7:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(40, 2);
                        Console.Write("Введiть слово: "); word = Console.ReadLine();
                        vocabulary.FindWord(word);
                        View.ClearMainMenu();
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

    }

}
