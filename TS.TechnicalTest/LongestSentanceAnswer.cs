using System;
namespace TS.TechnicalTest
{
    class Progra
        {
            static void Main(string[] args)
            {
                var textSplitter = new TextSplitter();
                var analyzer = new SentenceAnalyzer(textSplitter);
                var (sentence, wordCount) = analyzer.FindLongestSentence("We test coders. Give us a try?");
                Console.WriteLine($"The sentence with the most words is: \"{sentence.Trim()}\" with {wordCount} words.");
            }
        }
}