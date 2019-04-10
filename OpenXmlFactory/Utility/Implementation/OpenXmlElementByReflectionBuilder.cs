namespace OpenXmlFactory
{
    using System;
    using System.Linq;
    using System.Reflection;
    using DocumentFormat.OpenXml;

    public class OpenXmlElementByReflectionBuilder : IOpenXmlElementByReflectionBuilder
    {
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

        public ConstructorInfo GetOuterXmlConstructor(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

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