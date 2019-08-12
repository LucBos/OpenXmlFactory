namespace OpenXmlFactory
{
    using System;

    /// <summary>
    /// Converts OpenXml types to <see cref="Tag"/> objects.
    /// </summary>
    public class TagConverter : ITagConverter
    {
        /// <summary>
        /// Returns a new <see cref="Tag"/> instance for the given <see cref="Type"/>.
        /// </summary>
        /// <param name="type">The type of Open XML element.</param>
        /// <returns>A new <see cref="Tag"/> instance for the given <see cref="Type"/>.</returns>
        public Tag ConvertToTag(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            var tag = new Tag
            {
                Name = type.GetTagName(),
                Namespace = NamespaceIdMap.GetNamespacePrefix(type.GetNsId()),
                Type = type,
                TypeName = type.ToString()
            };

            return tag;
        }
    }
}