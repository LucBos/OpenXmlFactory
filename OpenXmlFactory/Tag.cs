using System;
using System.Xml.Serialization;

namespace OpenXmlFactory
{
    [Serializable]
    public class Tag
    {
        public string Name { get; set; }
        public string Namespace { get; set; }
        public string TypeName { get; set; }

        [XmlIgnore]
        public Type Type { get; set; }

        public override string ToString()
        {
            return string.Format("{0}:{1}", Namespace, Name);
        }
    }
}