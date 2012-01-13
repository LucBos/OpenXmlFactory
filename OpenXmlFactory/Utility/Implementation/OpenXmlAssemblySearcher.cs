using System;
using System.Collections.Generic;
using System.Linq;
using DocumentFormat.OpenXml;

namespace OpenXmlFactory
{
    public class OpenXmlAssemblySearcher : IOpenXmlAssemblySearcher
    {

        public IEnumerable<Type> GetAllSubclassesOfOpenXmlElement()
        {
            var parentClass = typeof(OpenXmlElement);
            var assembly = parentClass.Assembly;
            return assembly.GetTypes().Where(x => x.IsSubclassOf(parentClass) && OpenXmlElementExtensions.ContainsTagName(x) && OpenXmlElementExtensions.ContainsNdId(x));
        }
    }
}