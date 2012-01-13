using System;
using System.Reflection;

namespace OpenXmlFactory
{
    public static class OpenXmlElementExtensions
    {
        private const string TagNameFieldname = "tagName";
        private const string TagNsIdFieldName = "tagNsId";

        public static bool ContainsTagName(this Type type)
        {
            var theField = type.GetField(TagNameFieldname, BindingFlags.Static | BindingFlags.NonPublic);
            return theField != null;
        }

        public static bool ContainsNdId(this Type type)
        {
            var theField = type.GetField(TagNsIdFieldName, BindingFlags.Static | BindingFlags.NonPublic);
            return theField != null;
        }

        public static string GetTagName(this Type type)
        {
            var theField = type.GetField(TagNameFieldname, BindingFlags.Static | BindingFlags.NonPublic);
            return (string)theField.GetValue(null);
        }

        public static Byte GetNsId(this Type type)
        {
            var theField = type.GetField(TagNsIdFieldName, BindingFlags.Static | BindingFlags.NonPublic);
            return (Byte)theField.GetValue(null);
        }
    }
}