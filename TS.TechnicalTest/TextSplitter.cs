using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TS.TechnicalTest
{
    public class TextSplitter : ITextSplitter
    {
        public string[] SplitintoSentences(string text){
            return text.Split(new[]{'.','?','!'}, StringSplitOptions.RemoveEmptyEntries);
        }
        public string[] SplitIntoWords(string sentence){
            return sentence.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
        }
        
    }
}