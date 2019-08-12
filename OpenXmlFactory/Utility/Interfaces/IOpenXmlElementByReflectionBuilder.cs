namespace OpenXmlFactory
{
    using System;
    using DocumentFormat.OpenXml;

    /// <summary>
    /// Constructs <see cref="OpenXmlElement"/> instances from XML.
    /// </summary>
    public interface IOpenXmlElementByReflectionBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlElement"/> class of a given type from specified XML.
        /// </summary>
        /// <param name="type">The type of element to construct.</param>
        /// <param name="outerXml">The XML which defines the element.</param>
        /// <returns>A <see cref="OpenXmlElement"/> constructed from the XML.</returns>
        OpenXmlElement ConstructType(Type type, string outerXml);
    }
}