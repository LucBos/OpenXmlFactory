using System;

namespace OpenXmlFactory
{
    public class OuterXmlExtractor : IOuterXmlExtractor
    {
        public string ExtractTagName(string outerXml)
        {
            var startIndex = outerXml.IndexOf(':');
            var endIndex = outerXml.IndexOf(' ');

            if (startIndex < 0 || endIndex < 0)
                throw new ArgumentException("Invalid outerxml");

            return outerXml.Substring(startIndex + 1, endIndex - startIndex - 1);
        }

        public string ExtractNamespace(string outerXml)
        {
            var endIndex = outerXml.IndexOf(':');

            if (endIndex < 0)
                throw new ArgumentException("Invalid outerxml");

            const int startIndex = 1; // the < sign is on index 0 so we skip that
            return outerXml.Substring(startIndex, endIndex - 1);
        }
    }
}