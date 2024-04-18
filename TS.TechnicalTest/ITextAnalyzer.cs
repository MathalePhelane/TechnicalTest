using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TS.TechnicalTest
{
    public interface ITextAnalyzer
    {
        (string sentence,int wordCount) FindLongestSentence(string text);
    }
}