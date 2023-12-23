using System.Collections.Generic;

namespace kata_text_processing
{
    public record ProcessedText(Dictionary<int, string> TopTenWords, int NumberOfWords)
    {
        public Dictionary<int, string> TopTenWords { get; } = TopTenWords;
        public int NumberOfWords { get; } = NumberOfWords;
    }
}