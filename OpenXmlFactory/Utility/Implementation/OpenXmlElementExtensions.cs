namespace OpenXmlFactory
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Extension methods for OpenXML elements.
    /// </summary>
    public static class OpenXmlElementExtensions
    {
        private const string TagNameFieldname = "tagName";
        private const string TagNsIdFieldName = "tagNsId";

        /// <summary>
        /// Checks if the given <paramref name="type"/> contains a tagName property.
        /// </summary>
        /// <param name="type">The type to check.</param>
        /// <returns>true if the <paramref name="type"/> contains a tagName property; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="type"/> is null.</exception>
        public static bool ContainsTagName(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            var theField = type.GetField(TagNameFieldname, BindingFlags.Static | BindingFlags.NonPublic);
            return theField != null;
        }

        /// <summary>
        /// Checks if the given <paramref name="type"/> contains a tagNsId property.
        /// </summary>
        /// <param name="type">The type to check.</param>
        /// <returns>true if the <paramref name="type"/> contains a tagNsId property; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="type"/> is null.</exception>
        public static bool ContainsNdId(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            var theField = type.GetField(TagNsIdFieldName, BindingFlags.Static | BindingFlags.NonPublic);
            return theField != null;
        }

        /// <summary>
        /// Gets the value of the tagName property from the type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The value of the tagName property.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="type"/> is null.</exception>
        public static string GetTagName(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            var theField = type.GetField(TagNameFieldname, BindingFlags.Static | BindingFlags.NonPublic);

            // TODO: There is no null check here, so we are assuming the property exists?
            return (string)theField.GetValue(null);
        }

        /// <summary>
        /// Gets the value of the tagNsId property from the type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The value of the tagNsId property.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="type"/> is null.</exception>
        public static byte GetNsId(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            var theField = type.GetField(TagNsIdFieldName, BindingFlags.Static | BindingFlags.NonPublic);

            // TODO: There is no null check here, so we are assuming the property exists?
            return (byte)theField.GetValue(null);
        }
    }
}