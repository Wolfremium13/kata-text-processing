using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace kata_text_processing
{
    public class TextProcessorShould
    {
        [Fact]
        public void count_the_top_ten_words_ranked_by_frequency()
        {
            var givenText =
                "Hello, this is an example for you to practice. You should grab this text and make it as your test case.";
            var textProcessor = new TextProcessor(givenText);

            var processedText = textProcessor.analyze();

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
            Assert.Equal(expectedTopTenWords, processedText.GetTopTenWords());
        }
        
        [Fact]
        public void count_the_number_of_words()
        {
            var givenText =
                "Hello, this is an example for you to practice. You should grab this text and make it as your test case. This is an example for you to practice. You should grab this text and make it as your test case.";
            var textProcessor = new TextProcessor(givenText);

            var processedText = textProcessor.analyze();
            
            Assert.Equal(21, processedText.GetNumberOfWords());
        }
    }
}