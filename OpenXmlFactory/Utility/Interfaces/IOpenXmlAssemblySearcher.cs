using System;
using System.Collections.Generic;

namespace OpenXmlFactory
{
    public interface IOpenXmlAssemblySearcher
    {
        IEnumerable<Type> GetAllSubclassesOfOpenXmlElement();
    }
}