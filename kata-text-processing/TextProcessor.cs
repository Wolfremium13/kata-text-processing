using System;
using System.Collections.Generic;
using System.Linq;

namespace kata_text_processing
{
    public class TextProcessor
    {
        private string _text;

        public TextProcessor(string givenText)
        {
            _text = givenText;
        }

        public ProcessedText Analyze()
        {
            var numberOfWords = GetNumberOfWords();
            var repeatedWords = GetRepeatedWords();
            var topTenWords = GetTopTenWords(repeatedWords);
            return new ProcessedText(topTenWords, numberOfWords);
        }

        private int GetNumberOfWords()
        {
            return _text.Split(' ').Length;
        }

        private static Dictionary<int, string> GetTopTenWords(Dictionary<string, int> repeatedWords)
        {
            var topTenWords = new Dictionary<int, string>();
            var topTenWordsCount = 0;
            var sortedRepeatedWords = repeatedWords.OrderByDescending(x => x.Value);
            foreach (var word in sortedRepeatedWords)
            {
                if (topTenWordsCount == 10)
                {
                    break;
                }

                topTenWords.Add(topTenWordsCount + 1, word.Key);
                topTenWordsCount++;
            }

            return topTenWords;
        }

        private Dictionary<string, int> GetRepeatedWords()
        {
            var words = _text.Split(' ');
            var repeatedWords = new Dictionary<string, int>();
            foreach (var word in words)
            {
                var cleanedWord = word.Replace(",", "").Replace(".", "").ToLower();
                if (repeatedWords.ContainsKey(cleanedWord))
                {
                    repeatedWords[cleanedWord]++;
                }
                else
                {
                    repeatedWords.Add(cleanedWord, 1);
                }
            }

            return repeatedWords;
        }
    }
}