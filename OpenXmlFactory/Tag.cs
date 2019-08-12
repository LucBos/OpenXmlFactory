namespace OpenXmlFactory
{
    using System;
    using System.Globalization;
    using System.Xml.Serialization;

    /// <summary>
    /// Represents a tag which defines an Open XML element.
    /// </summary>
    // TODO: Why does this need to be serializable?
    [Serializable]
    public class Tag
    {
        /// <summary>
        /// Gets or sets the tag name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or sets the name of the type.
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the source type of the tag.
        /// </summary>
        [XmlIgnore]
        public Type Type { get; set; }

        /// <summary>
        /// Creates and returns a string representation of the current tag.
        /// </summary>
        /// <returns>A string representation of the current tag.</returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}:{1}", Namespace, Name);
        }
    }
}