using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Vocabulary.Interface;

namespace Vocabulary.Klasses
{
    [DataContract]
    class MyVocabulary : IVocabularu
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public Dictionary<string, List<string>> Vocabulary { get; set; }
        public MyVocabulary()
        {
            this.name = "none";
            Vocabulary = new Dictionary<string, List<string>>();
        }
        public MyVocabulary(string name)
        {
            this.name = name;
            Vocabulary = new Dictionary<string, List<string>>();
        }
        public List<string> this[string word]
        {
            get
            {
                try
                {
                    return Vocabulary[word];
                }
                catch (Exception)
                {
                    throw new Exception($"Cлово \"{word}\" не знайдено в словнику");
                }
            }
        }
        public void AddWord(string word, string translate)
        {
            try
            {
                List<string> tmp = new List<string>();
                tmp.Add(translate);
                Vocabulary.Add(word, tmp);
                View.Write($"Слово \"{word}\" добавлено");
            }
            catch (Exception)
            {
                View.Write($"Слово \"{word}\" уже iснує, добавляєм переклад");
                AddTranslate(word, translate);
            }
        }
        public void AddTranslate(string word, string translate)
        {
            try
            {
                int tmp = Vocabulary[word].FindIndex(w => w == translate);
                if (tmp == -1)
                {
                    Vocabulary[word].Add(translate);
                    View.Write($"Переклад {word} --> {translate} добавлено");
                }
                else
                    View.Write($"Переклад {word} --> {translate} уже iснує");
            }
            catch (Exception)
            {
                View.Write($"Cлово \"{word}\" не знайдено в словнику");
            }
        }
        public void ChangeTranslate(string word, string oldTranslate, string newTranslate)
        {
            try
            {
                int tmp = Vocabulary[word].FindIndex(w => w == oldTranslate);
                if (tmp == -1)
                {
                    View.Write($"Переклад \"{word}\" --> \"{oldTranslate}\" не знайдено");
                    return;
                }
                Vocabulary[word][tmp] = newTranslate;
                View.Write($"Переклад змiнено \"{word}\" --> \"{newTranslate}\" ");
            }
            catch (Exception ex)
            {
                View.Write(ex.Message);
            }

        }
        public void DelWord(string word)
        {
            if (!Vocabulary.Remove(word))
                View.Write($"Cлово \"{word}\" не знайдено в словнику");
            else View.Write($"Cлово \"{word}\" видалено");
        }
        public void DelTranslate(string word, string translate)
        {
            try
            {
                if (Vocabulary[word].Count > 1)
                {
                    if (Vocabulary[word].Remove(translate))
                        View.Write($"Переклад \"{word}\" --> \"{translate}\" видалено");
                    else
                        View.Write($"Переклад \"{word}\" --> \"{translate}\" не iснує");
                }
                else View.Write($"У слова \"{word}\" залишився, остайнiй переклад");
            }
            catch (Exception)
            {
                View.Write($"Cлово {word} не знайдено в словнику");
            }
        }
        public void FindWord(string word)
        {
            try
            {
                List<string> tmp = Vocabulary[word];
                View.Write(word, tmp);
            }
            catch (Exception)
            {
                View.Write($"Слова \"{word}\" не знайдено");
                View.Write();
            }
        }
        public void FindContainsWord(string word)
        {
            var tmp = Vocabulary.Select(v => v).Where(v => v.Key.Contains(word));
            foreach (var item in tmp)
            {
               View.Write(item.Key, item.Value);
            }
        }


    }
}
