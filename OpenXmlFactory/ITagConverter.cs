namespace OpenXmlFactory
{
    using System;

    public interface ITagConverter
    {
        Tag ConvertToTag(Type type);
    }
}