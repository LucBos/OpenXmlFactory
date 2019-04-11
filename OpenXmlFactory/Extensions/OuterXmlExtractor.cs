namespace OpenXmlFactory
{
    using System;

    /// <summary>
    /// Extracts elements from outer XML.
    /// </summary>
    public class OuterXmlExtractor : IOuterXmlExtractor
    {
        /// <summary>
        /// Extracts the tag name from the given <paramref name="outerXml"/>.
        /// </summary>
        /// <param name="outerXml">The outer XML to extract from.</param>
        /// <returns>A string containing the tag name.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="outerXml"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="outerXml"/> does not contain a valid tag name.</exception>
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

        /// <summary>
        /// Extracts the namespace from the given <paramref name="outerXml"/>.
        /// </summary>
        /// <param name="outerXml">The outer XML to extract from.</param>
        /// <returns>A string containing the namespace.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="outerXml"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="outerXml"/> does not contain a valid namespace.</exception>
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

            // the < sign is on index 0 so we skip that
            const int startIndex = 1;
            return outerXml.Substring(startIndex, endIndex - 1);
        }
    }
}