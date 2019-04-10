namespace OpenXmlFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DocumentFormat.OpenXml;

    public class OpenXmlAssemblySearcher : IOpenXmlAssemblySearcher
    {
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