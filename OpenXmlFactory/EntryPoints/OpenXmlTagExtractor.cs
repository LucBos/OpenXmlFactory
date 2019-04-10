namespace OpenXmlFactory
{
    using System.Collections.Generic;
    using System.Linq;

    public class OpenXmlTagExtractor
    {
        private readonly ITagConverter tagConverter;
        private readonly IOpenXmlAssemblySearcher openXmlAssemblySearcher;

        public OpenXmlTagExtractor()
            : this(new TagConverter(), new OpenXmlAssemblySearcher())
        {
        }

        public OpenXmlTagExtractor(ITagConverter tagConverter, IOpenXmlAssemblySearcher openXmlAssemblySearcher)
        {
            this.tagConverter = tagConverter;
            this.openXmlAssemblySearcher = openXmlAssemblySearcher;
        }

        public List<Tag> GetTagNamesByType()
        {
            var allTypes = openXmlAssemblySearcher.GetAllSubclassesOfOpenXmlElement();

            return allTypes
                .Select(type => tagConverter.ConvertToTag(type))
                .ToList();
        }
    }
}
