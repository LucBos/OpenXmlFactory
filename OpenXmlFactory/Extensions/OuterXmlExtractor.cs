namespace OpenXmlFactory
{
    using System;

    public class OuterXmlExtractor : IOuterXmlExtractor
    {
        public string ExtractTagName(string outerXml)
        {
            if (outerXml == null)
            {
                throw new ArgumentNullException(nameof(outerXml));
            }

            int startIndex = outerXml.IndexOf(':');
            int endIndex = outerXml.IndexOf(' ');

            if (startIndex < 0 || endIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(outerXml));
            }

            return outerXml.Substring(startIndex + 1, endIndex - startIndex - 1);
        }

        public string ExtractNamespace(string outerXml)
        {
            if (outerXml == null)
            {
                throw new ArgumentNullException(nameof(outerXml));
            }

            var endIndex = outerXml.IndexOf(':');

            if (endIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(outerXml));
            }

            const int startIndex = 1; // the < sign is on index 0 so we skip that
            return outerXml.Substring(startIndex, endIndex - 1);
        }
    }
}