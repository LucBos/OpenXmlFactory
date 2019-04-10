namespace OpenXmlFactory
{
    using System;
    using System.Linq;
    using DocumentFormat.OpenXml;

    public class OpenXmlElementReconstructor
    {
        private readonly IOuterXmlExtractor outerXmlExtractor;
        private readonly IOpenXmlElementByReflectionBuilder reflectionBuilder;

        public OpenXmlElementReconstructor()
            : this(new OuterXmlExtractor(), new OpenXmlElementByReflectionBuilder())
        {
        }

        public OpenXmlElementReconstructor(IOuterXmlExtractor outerXmlExtractor, IOpenXmlElementByReflectionBuilder reflectionBuilder)
        {
            this.outerXmlExtractor = outerXmlExtractor;
            this.reflectionBuilder = reflectionBuilder;
        }

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
