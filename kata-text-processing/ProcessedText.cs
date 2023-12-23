using System;
using System.Collections.Generic;

namespace kata_text_processing
{
    public class ProcessedText
    {
        private Dictionary<int, string> _topTenWords;

        public ProcessedText(Dictionary<int, string> topTenWords)
        {
            _topTenWords = topTenWords;
        }

        public IEnumerable<KeyValuePair<int, string>> GetTopTenWords()
        {
            return _topTenWords;
        }

        public int GetNumberOfWords()
        {
            return 0;
        }
    }
}