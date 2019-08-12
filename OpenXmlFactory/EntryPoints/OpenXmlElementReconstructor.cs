namespace OpenXmlFactory
{
    using System;
    using System.Linq;
    using DocumentFormat.OpenXml;

    /// <summary>
    /// Reconstructs <see cref="OpenXmlElement"/> objects from the outer XML.
    /// </summary>
    public class OpenXmlElementReconstructor
    {
        private readonly IOuterXmlExtractor outerXmlExtractor;
        private readonly IOpenXmlElementByReflectionBuilder reflectionBuilder;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlElementReconstructor"/> class.
        /// </summary>
        public OpenXmlElementReconstructor()
            : this(new OuterXmlExtractor(), new OpenXmlElementByReflectionBuilder())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlElementReconstructor"/> class with a specified <see cref="IOuterXmlExtractor"/> and <see cref="IOpenXmlElementByReflectionBuilder"/>.
        /// </summary>
        /// <param name="outerXmlExtractor">To extract the information from the OpenXml.</param>
        /// <param name="reflectionBuilder">To construct the <see cref="OpenXmlElement"/> objects.</param>
        public OpenXmlElementReconstructor(IOuterXmlExtractor outerXmlExtractor, IOpenXmlElementByReflectionBuilder reflectionBuilder)
        {
            this.outerXmlExtractor = outerXmlExtractor;
            this.reflectionBuilder = reflectionBuilder;
        }

        /// <summary>
        /// Reconstructs an <see cref="OpenXmlElement"/> object from the specified XML.
        /// </summary>
        /// <param name="outerXml">The XML which defines the element.</param>
        /// <returns>
        /// An <see cref="OpenXmlElement"/> represented by the specified XML.
        /// Or a <see cref="OpenXmlUnknownElement"/> if the element is unknown.
        /// </returns>
        public OpenXmlElement Reconstruct(string outerXml)
        {
            var ns = outerXmlExtractor.ExtractNamespace(outerXml);
            var tagName = outerXmlExtractor.ExtractTagName(outerXml);

            var type = GetTypeOfTag(ns, tagName);

            if (type == null)
            {
                return new OpenXmlUnknownElement("unknown");
            }

            var element = reflectionBuilder.ConstructType(type, outerXml);

            return element;
        }

        private static Type GetTypeOfTag(string ns, string tagName)
        {
            var tagNamesByType = new OpenXmlTagExtractor().GetTagNamesByType();
            var tag = tagNamesByType.FirstOrDefault(x => x.Namespace.Equals(ns, StringComparison.OrdinalIgnoreCase) && x.Name.Equals(tagName, StringComparison.OrdinalIgnoreCase));

            if (tag != null)
            {
                return typeof(OpenXmlElement).Assembly.GetType(tag.TypeName);
            }

            return null;
        }
    }
}
