namespace OpenXmlFactory
{
    using System;

    public class TagConverter : ITagConverter
    {
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