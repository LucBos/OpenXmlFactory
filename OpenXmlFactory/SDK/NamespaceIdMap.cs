namespace OpenXmlFactory
{
    /// <summary>
    /// Contains all the namespace information.
    /// </summary>
    internal static class NamespaceIdMap
    {
        private static readonly string[] NamespacePrefixList =
        {
            string.Empty,
            "xml",
            "cp",
            "ap",
            "op",
            "vt",
            "dc",
            "dcterms",
            "ac",
            "b",
            "a",
            "c",
            "cdr",
            "comp",
            "dgm",
            "lc",
            "wp",
            "pic",
            "xdr",
            "r",
            "ds",
            "m",
            "x",
            "w",
            "p",
            "sl",
            "v",
            "o",
            "w10",
            "xvml",
            "pvml",
            "mc",
            "xne",
            "wne",
            "mso",
            "ax",
            "cppr",
            "cdip",
            "ct",
            "ntns",
            "lp",
            "ma",
            "xsd",
            "inkml",
            "emma",
            "msink",
            "c14",
            "cdr14",
            "a14",
            "p14",
            "pic14",
            "wp14",
            "w14",
            "x14",
            "xdr14",
            "x14ac",
            "dsp",
            "mso14",
            "dgm14",
            "wpc",
            "wpg",
            "wps",
            "sle",
            "com14",
            "c15",
            "cs",
            "we",
            "a15",
            "p15",
            "w15",
            "wetp",
            "x15",
            "x12ac",
            "thm15",
            "x15ac",
            "wp15",
            "pRoam",
            "tsle"
        };

        static NamespaceIdMap()
        {
        }

        /// <summary>
        /// Gets the default namespace prefix for the specified namespace identifier.
        /// </summary>
        /// <param name="namespaceId">The namespace URI to locate.</param>
        /// <returns>The namrspace prefix.</returns>
        public static string GetNamespacePrefix(byte namespaceId) => NamespacePrefixList[namespaceId];
    }
}