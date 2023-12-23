using System;
using System.Collections.Generic;
using System.Linq;

namespace kata_text_processing
{
    public class TextProcessor
    {
        private readonly string _text;

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
            return repeatedWords
                .OrderByDescending(repeatedWord => repeatedWord.Value)
                .Take(10)
                .Select((word, rank) => new { Index = rank + 1, Word = word.Key })
                .ToDictionary(rankedWord => rankedWord.Index, x => x.Word);
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