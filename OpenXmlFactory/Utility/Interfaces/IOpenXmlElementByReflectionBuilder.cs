using System;
using System.Reflection;
using DocumentFormat.OpenXml;

namespace OpenXmlFactory
{
    public interface IOpenXmlElementByReflectionBuilder
    {
        OpenXmlElement ConstructType(Type t, string outerXml);
        ConstructorInfo GetOuterXmlConstructor(Type t);
    }
}