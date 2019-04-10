namespace OpenXmlFactory
{
    using System;
    using System.Reflection;
    using DocumentFormat.OpenXml;

    public interface IOpenXmlElementByReflectionBuilder
    {
        OpenXmlElement ConstructType(Type type, string outerXml);

        ConstructorInfo GetOuterXmlConstructor(Type type);
    }
}