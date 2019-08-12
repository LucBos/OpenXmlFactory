namespace OpenXmlFactory.Tests
{
    using Shouldly;
    using Xunit;

    public class OpenXmlTagExtractorTests
    {
        [Fact]
        public void GetTagNamesByType()
        {
            var extractor = new OpenXmlTagExtractor();
            var tags = extractor.GetTagNamesByType();

            tags.Count.ShouldBe(3440);
            tags.ShouldContain(e => e.Name == "p" && e.Namespace == "w");
        }
    }
}
