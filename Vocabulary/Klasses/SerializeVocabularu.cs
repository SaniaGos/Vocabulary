using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;


namespace Vocabulary.Klasses
{
    class SerializeVocabularu
    {
        public static void WriteVocab(string path, MyVocabulary voc)
        {
            using (XmlTextWriter serializer = new XmlTextWriter(path, Encoding.UTF8))
            {
                serializer.Formatting = Formatting.Indented;
                XmlDictionaryWriter writer = XmlDictionaryWriter.CreateDictionaryWriter(serializer);
                DataContractSerializer ser = new DataContractSerializer(typeof(MyVocabulary));
                ser.WriteObject(writer, voc);
                writer.Close();
            }
        }
        public static MyVocabulary LoadVocab(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            if (fs.Length < 50)
            {
                fs.Close();
                WriteVocab(path, new MyVocabulary());
            }
            else fs.Close();
            MyVocabulary vocabulary = null;
            using (fs = new FileStream(path, FileMode.Open))
            {
                XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, Encoding.UTF8, new XmlDictionaryReaderQuotas(), null);
                DataContractSerializer ser = new DataContractSerializer(typeof(MyVocabulary));
                vocabulary = (MyVocabulary)ser.ReadObject(reader);
            }
            return vocabulary;
        }
    }
}
