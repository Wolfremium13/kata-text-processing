using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace kata_text_processing
{
    public class TextProcessorShould
    {
        private const string GivenText =
            "Hello, this is an example for you to practice. You should grab this text and make it as your test case.";
        
        [Fact]
        public void count_the_top_ten_words_ranked_by_frequency()
        {
            var textProcessor = new TextProcessor(GivenText);

            var processedText = textProcessor.Analyze();

            var expectedTopTenWords = new Dictionary<int, string>()
            {
                { 1, "this" },
                { 2, "you" },
                { 3, "hello" },
                { 4, "is" },
                { 5, "an" },
                { 6, "example" },
                { 7, "for" },
                { 8, "to" },
                { 9, "practice" },
                { 10, "should" }
            };
            Assert.Equal(expectedTopTenWords, processedText.TopTenWords);
        }

        [Fact]
        public void count_the_number_of_words()
        {
            var textProcessor = new TextProcessor(GivenText);

            var processedText = textProcessor.Analyze();

            Assert.Equal(21, processedText.NumberOfWords);
        }
    }
}