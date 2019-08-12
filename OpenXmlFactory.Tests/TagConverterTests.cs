namespace OpenXmlFactory.Tests
{
    using Shouldly;
    using Xunit;

    public class TagConverterTests
    {
        [Fact]
        public void ConvertToTag()
        {
            ITagConverter converter = new TagConverter();

            var type = typeof(DocumentFormat.OpenXml.Wordprocessing.Paragraph);
            var tag = converter.ConvertToTag(type);

            tag.Name.ShouldBe("p");
            tag.Namespace.ShouldBe("w");
            tag.Type.ShouldBe(type);
            tag.TypeName.ShouldBe("DocumentFormat.OpenXml.Wordprocessing.Paragraph");
        }
    }
}
