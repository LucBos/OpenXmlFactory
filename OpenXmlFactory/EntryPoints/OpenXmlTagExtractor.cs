namespace OpenXmlFactory
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Extracts the <see cref="Tag"/> objects from an assesmly.
    /// </summary>
    public class OpenXmlTagExtractor
    {
        private readonly ITagConverter tagConverter;
        private readonly IOpenXmlAssemblySearcher openXmlAssemblySearcher;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlTagExtractor"/> class.
        /// </summary>
        public OpenXmlTagExtractor()
            : this(new TagConverter(), new OpenXmlAssemblySearcher())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlTagExtractor"/> class with a specified <see cref="ITagConverter"/> and <see cref="IOpenXmlAssemblySearcher"/>.
        /// </summary>
        /// <param name="tagConverter">To convert the OpenXML elements to <see cref="Tag"/> objects.</param>
        /// <param name="openXmlAssemblySearcher">To search the assessbly for OpenXML elements.</param>
        public OpenXmlTagExtractor(ITagConverter tagConverter, IOpenXmlAssemblySearcher openXmlAssemblySearcher)
        {
            this.tagConverter = tagConverter;
            this.openXmlAssemblySearcher = openXmlAssemblySearcher;
        }

        /// <summary>
        /// Searches the assembly for available OpenXML elements and returns a <see cref="List{Tag}" /> for all elements.
        /// </summary>
        /// <returns>A <see cref="List{Tag}"/> for all available elements.</returns>
        public List<Tag> GetTagNamesByType()
        {
            var allTypes = openXmlAssemblySearcher.GetAllSubclassesOfOpenXmlElement();

            return allTypes
                .Select(type => tagConverter.ConvertToTag(type))
                .ToList();
        }
    }
}
