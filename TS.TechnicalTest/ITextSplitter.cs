using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TS.TechnicalTest
{
    public interface ITextSplitter
    {
        string[] SplitintoSentences(string text);
        string[] SplitIntoWords(string sentences);
    }
}