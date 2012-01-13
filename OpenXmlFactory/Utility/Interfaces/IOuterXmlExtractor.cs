namespace OpenXmlFactory
{
    public interface IOuterXmlExtractor
    {
        string ExtractTagName(string outerXml);
        string ExtractNamespace(string outerXml);
    }
}