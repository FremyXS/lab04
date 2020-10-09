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
            List<string> xxx = new List<string>();
            List<string> yyy = new List<string>();
            

            int WordIt = 0;
            foreach (string i in Words)
                WordIt++;

            int Kol;
            for (int i = 0; i < WordIt; i++)
            {
                string[] MassiveWords = Words[i].ToLower().Trim().Split(' ', ',');
                Kol = 0;
                foreach (string n in MassiveWords)
                    Kol++;

                if (Kol > 1)
                {
                    for (int t = 0; t < Kol - 1; t++)
                    {
                        xxx.Add(MassiveWords[t]);
                        yyy.Add(MassiveWords[t + 1]);
                    }
                }
            }
            int KolXandY = 0;
            foreach (string i in xxx)
                KolXandY++;

            List<string> NewXXX = new List<string>();
            List<string> NewYYY = new List<string>();
            int KolXXX = 0;
            int KolYYY = 0;
            foreach (string i in xxx)
                KolXXX++;
            foreach (string i in yyy)
                KolYYY++;

            for (int i = 0; i < KolXXX; i++)
            {
                if (xxx[i] != "")
                    NewXXX.Add(xxx[i]);
            }
            for (int i = 0; i < KolYYY; i++)
            {
                if (yyy[i] != "")
                    NewYYY.Add(yyy[i]);
            }

            Dictionary<string, string> DictWords = new Dictionary<string, string>();
            for (int i = 0; i < KolXandY; i++)
            {
                DictWords.Add(NewXXX[i], NewYYY[i]);
            }

            foreach (KeyValuePair<string, string> keyValue in DictWords)
            {
                Console.WriteLine(keyValue.Key + " : " + keyValue.Value);
            }
        }
        


    }
}
