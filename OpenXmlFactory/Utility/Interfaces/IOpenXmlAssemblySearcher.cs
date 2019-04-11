namespace OpenXmlFactory
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Searches an assembly for Open XML elements.
    /// </summary>
    public interface IOpenXmlAssemblySearcher
    {
        /// <summary>
        /// Returns a list of Open XML element types.
        /// </summary>
        /// <returns>A <see cref="IEnumerable{Type}"/> containing all Open XML elements.</returns>
        IEnumerable<Type> GetAllSubclassesOfOpenXmlElement();
    }
}