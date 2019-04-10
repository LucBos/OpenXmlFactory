namespace OpenXmlFactory
{
    using System;
    using System.Reflection;

    public static class OpenXmlElementExtensions
    {
        private const string TagNameFieldname = "tagName";
        private const string TagNsIdFieldName = "tagNsId";

        public static bool ContainsTagName(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            var theField = type.GetField(TagNameFieldname, BindingFlags.Static | BindingFlags.NonPublic);
            return theField != null;
        }

        public static bool ContainsNdId(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            var theField = type.GetField(TagNsIdFieldName, BindingFlags.Static | BindingFlags.NonPublic);
            return theField != null;
        }

        public static string GetTagName(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            var theField = type.GetField(TagNameFieldname, BindingFlags.Static | BindingFlags.NonPublic);
            return (string)theField.GetValue(null);
        }

        public static byte GetNsId(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            var theField = type.GetField(TagNsIdFieldName, BindingFlags.Static | BindingFlags.NonPublic);
            return (byte)theField.GetValue(null);
        }
    }
}