using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OpenXmlFactory
{
    public class OpenXmlTagExtractor
    {
        private readonly ITagConverter _tagConverter;
        private readonly IOpenXmlAssemblySearcher _openXmlAssemblySearcher;

        public OpenXmlTagExtractor()
            : this(new TagConverter(), new OpenXmlAssemblySearcher())
        {

        }

        public OpenXmlTagExtractor(ITagConverter tagConverter, IOpenXmlAssemblySearcher openXmlAssemblySearcher)
        {
            _tagConverter = tagConverter;
            _openXmlAssemblySearcher = openXmlAssemblySearcher;
        }

        public List<Tag> GetTagNamesByType()
        {
            var allTypes = _openXmlAssemblySearcher.GetAllSubclassesOfOpenXmlElement();

            return allTypes.Select(type => _tagConverter.ConvertToTag(type)).ToList();
        }
    }
}
