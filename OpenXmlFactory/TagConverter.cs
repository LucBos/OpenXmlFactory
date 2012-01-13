using System;

namespace OpenXmlFactory
{
    public interface ITagConverter
    {
        Tag ConvertToTag(Type type);
    }

    public class TagConverter : ITagConverter
    {
        public Tag ConvertToTag(Type type)
        {
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