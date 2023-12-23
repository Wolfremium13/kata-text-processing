using System;
using System.Collections.Generic;

namespace kata_text_processing
{
    public class ProcessedText
    {
        private readonly Dictionary<int, string> _topTenWords;
        private readonly int _repeatedWordsCount;

        public ProcessedText(Dictionary<int, string> topTenWords, int repeatedWordsCount)
        {
            _topTenWords = topTenWords;
            _repeatedWordsCount = repeatedWordsCount;
        }

        public IEnumerable<KeyValuePair<int, string>> GetTopTenWords()
        {
            return _topTenWords;
        }

        public int GetNumberOfWords()
        {
            return _repeatedWordsCount;
        }
    }
}