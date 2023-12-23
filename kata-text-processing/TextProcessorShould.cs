using System.Collections.Generic;
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
                { 1, "you" },
                { 2, "this" },
                { 3, "your" },
                { 4, "to" },
                { 5, "text" },
                { 6, "test" },
                { 7, "should" },
                { 8, "practice" },
                { 9, "make" },
                { 10, "it" }
            };
            Assert.Equal(processedText.GetTopTenWords(), expectedTopTenWords);
        }
    }
}