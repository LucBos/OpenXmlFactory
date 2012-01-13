using System;
using System.Linq;
using System.Reflection;
using DocumentFormat.OpenXml;

namespace OpenXmlFactory
{
    class OpenXmlElementByReflectionBuilder : IOpenXmlElementByReflectionBuilder
    {

        public OpenXmlElement ConstructType(Type t, string outerXml)
        {
            var constructorWithOuterXml = GetOuterXmlConstructor(t);

            if (constructorWithOuterXml != null)
            {
                return constructorWithOuterXml.Invoke(new object[] { outerXml }) as OpenXmlElement;
            }

            var defaultConstructor = GetDefaultConstructor(t);
            return defaultConstructor.Invoke(new object[] { }) as OpenXmlElement;

        }

        private ConstructorInfo GetDefaultConstructor(Type type)
        {
            return type.GetConstructors().FirstOrDefault();
        }

        public ConstructorInfo GetOuterXmlConstructor(Type t)
        {
            var constructors = t.GetConstructors();

            var constructorWithOuterXml =
                constructors.FirstOrDefault(
                    constructorInfo =>
                    constructorInfo.GetParameters().Any(parameterInfo => parameterInfo.Name.Equals("outerXml")));
            return constructorWithOuterXml;
        }
    }
}