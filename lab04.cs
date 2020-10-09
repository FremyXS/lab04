using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security;

namespace lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();

            List <string> PerehodMexhClass = new List<string>();

            SentencesParserTask p1 = new SentencesParserTask();
            p1.ListSentence(text, ref PerehodMexhClass);
            
            
            Console.WriteLine("---------------------------------------------------------------------------------------");
            
            FrequencyAnalysisTask p2 = new FrequencyAnalysisTask();
            p2.DictSentence(PerehodMexhClass);

        }
    }

    class SentencesParserTask
    {
        public void ListSentence(string text, ref List<string> Sentence)
        {

            Sentence.AddRange(text.Trim().ToLower().Split('.', '!', '?', ';', ':', '(', ')'));

            int KolSentence = 0;
            foreach (string i in Sentence)
                KolSentence++;
            List<string> Words = new List<string>();
            for (int i = 0; i < KolSentence; i++)
                Words.AddRange(Sentence[i].Trim().Split(' ', ','));

            int WordsIt = 0;
            foreach (string i in Words)
                WordsIt++;

            List<string> NewListWords = new List<string>();
            for (int i = 0; i < WordsIt; i++)
            {
                if (Words[i] != "")
                    NewListWords.Add(Words[i]);
            }

            foreach (string i in NewListWords)
                Console.WriteLine(i);     
        }
    }
    class FrequencyAnalysisTask
    {
        public void DictSentence(List <string> Words) 
        {
            int WordIt = 0;
            foreach (string i in Words)
                WordIt++;



            for (int i = 0; i < WordIt; i++)
            {
                if 
            }

            Dictionary<string, string> DictWords = new Dictionary<string, string>();           
        }
        


    }
}
