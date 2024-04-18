using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TS.TechnicalTest
{
    public class SentenceAnalyzer : ITextAnalyzer
    {
        private readonly ITextSplitter _textSplitter;

        public SentenceAnalyzer(ITextSplitter textSpliter)
        {
            _textSplitter = textSpliter;
        }
    

        public (string sentence,int wordCount) FindLongestSentence(string text)
        {

            var sentences = _textSplitter.SplitintoSentences(text);

            string longestSentence = string.Empty;
            int maxWordCount = 0;

            foreach (var sentence in sentences)
            {
                var words = _textSplitter.SplitIntoWords(sentence);
                var wordCount = words.Length;

                if(wordCount > maxWordCount){
                    maxWordCount = wordCount;
                    longestSentence = sentence;
                }
            }

            return(longestSentence,maxWordCount);
        }

    }
}