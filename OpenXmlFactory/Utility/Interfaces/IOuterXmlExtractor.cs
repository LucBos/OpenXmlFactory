namespace OpenXmlFactory
{
    /// <summary>
    /// Extracts elements from outer XML.
    /// </summary>
    public interface IOuterXmlExtractor
    {
        /// <summary>
        /// Extracts the tag name from the given <paramref name="outerXml"/>.
        /// </summary>
        /// <param name="outerXml">The outer XML to extract from.</param>
        /// <returns>A string containing the tag name.</returns>
        string ExtractTagName(string outerXml);

        /// <summary>
        /// Extracts the namespace from the given <paramref name="outerXml"/>.
        /// </summary>
        /// <param name="outerXml">The outer XML to extract from.</param>
        /// <returns>A string containing the namespace.</returns>
        string ExtractNamespace(string outerXml);
    }
}