using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary.Interface
{
    interface IVocabularu
    {
        void AddWord(string word, string translate);
        void AddTranslate(string word, string translate);
        void ChangeTranslate(string word, string oldTranslate, string newTranslate);
        void DelWord(string word);
        void DelTranslate(string word, string translate);
        void FindWord(string word);
        void FindContainsWord(string word);
    }
}
