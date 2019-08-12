namespace OpenXmlFactory
{
    using System;

    /// <summary>
    /// Converts OpenXML types to <see cref="Tag"/> objects.
    /// </summary>
    public interface ITagConverter
    {
        /// <summary>
        /// Returns a <see cref="Tag"/> instance from the given <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>A <see cref="Tag"/> instance from the given <paramref name="type"/>.</returns>
        Tag ConvertToTag(Type type);
    }
}