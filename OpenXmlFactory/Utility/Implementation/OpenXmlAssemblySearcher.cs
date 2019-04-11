namespace OpenXmlFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DocumentFormat.OpenXml;

    /// <summary>
    /// Searches an assembly for Open XML elements.
    /// </summary>
    public class OpenXmlAssemblySearcher : IOpenXmlAssemblySearcher
    {
        /// <summary>
        /// Returns a list of Open XML element types.
        /// </summary>
        /// <returns>A <see cref="IEnumerable{Type}"/> containing all Open XML elements.</returns>
        public IEnumerable<Type> GetAllSubclassesOfOpenXmlElement()
        {
            var parentClass = typeof(OpenXmlElement);
            var assembly = parentClass.Assembly;
            return assembly
                .GetTypes()
                .Where(x => x.IsSubclassOf(parentClass))
                .Where(x => OpenXmlElementExtensions.ContainsTagName(x))
                .Where(x => OpenXmlElementExtensions.ContainsNdId(x));
        }
    }
}