namespace OpenXmlFactory
{
    using System;
    using System.Linq;
    using System.Reflection;
    using DocumentFormat.OpenXml;

    /// <summary>
    /// Constructs <see cref="OpenXmlElement"/> instances from XML using relfection.
    /// </summary>
    public class OpenXmlElementByReflectionBuilder : IOpenXmlElementByReflectionBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlElement"/> class of a given type from specified XML.
        /// </summary>
        /// <param name="type">The type of element to construct.</param>
        /// <param name="outerXml">The XML which defines the element.</param>
        /// <returns>A <see cref="OpenXmlElement"/> constructed from the XML.</returns>
        public OpenXmlElement ConstructType(Type type, string outerXml)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            var constructorWithOuterXml = GetOuterXmlConstructor(type);

            if (constructorWithOuterXml != null)
            {
                return constructorWithOuterXml.Invoke(new object[] { outerXml }) as OpenXmlElement;
            }

            var defaultConstructor = GetDefaultConstructor(type);
            return defaultConstructor.Invoke(null) as OpenXmlElement;
        }

        private ConstructorInfo GetOuterXmlConstructor(Type type)
        {
            var constructors = type.GetConstructors();

            var constructorWithOuterXml =
                constructors.FirstOrDefault(
                    constructorInfo =>
                    constructorInfo.GetParameters().Any(parameterInfo => parameterInfo.Name.Equals("outerXml", StringComparison.OrdinalIgnoreCase)));

            return constructorWithOuterXml;
        }

        private ConstructorInfo GetDefaultConstructor(Type type)
        {
            return type
                .GetConstructors()
                .FirstOrDefault();
        }
    }
}