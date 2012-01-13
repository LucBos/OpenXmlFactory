using System;
using System.Linq;
using DocumentFormat.OpenXml;

namespace OpenXmlFactory
{
    public class OpenXmlElementReconstructor
    {
        private readonly IOuterXmlExtractor _outerXmlExtractor;
        private readonly IOpenXmlElementByReflectionBuilder _reflectionBuilder;

        public OpenXmlElementReconstructor()
            : this(new OuterXmlExtractor(), new OpenXmlElementByReflectionBuilder())
        {

        }

        public OpenXmlElementReconstructor(IOuterXmlExtractor outerXmlExtractor, IOpenXmlElementByReflectionBuilder reflectionBuilder)
        {
            _outerXmlExtractor = outerXmlExtractor;
            _reflectionBuilder = reflectionBuilder;
        }

        public OpenXmlElement Reconstruct(string outerXml)
        {
            var ns = _outerXmlExtractor.ExtractNamespace(outerXml);
            var tagName = _outerXmlExtractor.ExtractTagName(outerXml);

            var type = GetTypeOfTag(ns, tagName);

            if (type == null)
                return new OpenXmlUnknownElement("unknown");

            var element = _reflectionBuilder.ConstructType(type, outerXml);

            return element;
        }

        private Type GetTypeOfTag(string ns, string tagName)
        {
            var tagNamesByType = new OpenXmlTagExtractor().GetTagNamesByType();
            var tag = tagNamesByType.FirstOrDefault(x => x.Namespace.Equals(ns) && x.Name.Equals(tagName));

            if (tag != null)
            {
                return typeof (OpenXmlElement).Assembly.GetType(tag.TypeName);
            }

            return null;
        }
    }
}
