namespace OpenXmlFactory
{
    using System;
    using System.Collections.Generic;

    public interface IOpenXmlAssemblySearcher
    {
        IEnumerable<Type> GetAllSubclassesOfOpenXmlElement();
    }
}