namespace OpenXmlFactory
{
    using System;
    using System.Collections.Generic;
    using DocumentFormat.OpenXml;

    internal static class NamespaceIdMap
    {
        private static readonly string[] NamespaceList =
        {
            string.Empty,
            "http://www.w3.org/XML/1998/namespace",
            "http://schemas.openxmlformats.org/package/2006/metadata/core-properties",
            "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties",
            "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties",
            "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes",
            "http://purl.org/dc/elements/1.1/",
            "http://purl.org/dc/terms/",
            "http://schemas.openxmlformats.org/officeDocument/2006/characteristics",
            "http://schemas.openxmlformats.org/officeDocument/2006/bibliography",
            "http://schemas.openxmlformats.org/drawingml/2006/main",
            "http://schemas.openxmlformats.org/drawingml/2006/chart",
            "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing",
            "http://schemas.openxmlformats.org/drawingml/2006/compatibility",
            "http://schemas.openxmlformats.org/drawingml/2006/diagram",
            "http://schemas.openxmlformats.org/drawingml/2006/lockedCanvas",
            "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing",
            "http://schemas.openxmlformats.org/drawingml/2006/picture",
            "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing",
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships",
            "http://schemas.openxmlformats.org/officeDocument/2006/customXml",
            "http://schemas.openxmlformats.org/officeDocument/2006/math",
            "http://schemas.openxmlformats.org/spreadsheetml/2006/main",
            "http://schemas.openxmlformats.org/wordprocessingml/2006/main",
            "http://schemas.openxmlformats.org/presentationml/2006/main",
            "http://schemas.openxmlformats.org/schemaLibrary/2006/main",
            "urn:schemas-microsoft-com:vml",
            "urn:schemas-microsoft-com:office:office",
            "urn:schemas-microsoft-com:office:word",
            "urn:schemas-microsoft-com:office:excel",
            "urn:schemas-microsoft-com:office:powerpoint",
            "http://schemas.openxmlformats.org/markup-compatibility/2006",
            "http://schemas.microsoft.com/office/excel/2006/main",
            "http://schemas.microsoft.com/office/word/2006/wordml",
            "http://schemas.microsoft.com/office/2006/01/customui",
            "http://schemas.microsoft.com/office/2006/activeX",
            "http://schemas.microsoft.com/office/2006/coverPageProps",
            "http://schemas.microsoft.com/office/2006/customDocumentInformationPanel",
            "http://schemas.microsoft.com/office/2006/metadata/contentType",
            "http://schemas.microsoft.com/office/2006/metadata/customXsn",
            "http://schemas.microsoft.com/office/2006/metadata/longProperties",
            "http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes",
            "http://www.w3.org/2001/XMLSchema",
            "http://www.w3.org/2003/InkML",
            "http://www.w3.org/2003/04/emma",
            "http://schemas.microsoft.com/ink/2010/main",
            "http://schemas.microsoft.com/office/drawing/2007/8/2/chart",
            "http://schemas.microsoft.com/office/drawing/2010/chartDrawing",
            "http://schemas.microsoft.com/office/drawing/2010/main",
            "http://schemas.microsoft.com/office/powerpoint/2010/main",
            "http://schemas.microsoft.com/office/drawing/2010/picture",
            "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing",
            "http://schemas.microsoft.com/office/word/2010/wordml",
            "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main",
            "http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing",
            "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac",
            "http://schemas.microsoft.com/office/drawing/2008/diagram",
            "http://schemas.microsoft.com/office/2009/07/customui",
            "http://schemas.microsoft.com/office/drawing/2010/diagram",
            "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas",
            "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup",
            "http://schemas.microsoft.com/office/word/2010/wordprocessingShape",
            "http://schemas.microsoft.com/office/drawing/2010/slicer",
            "http://schemas.microsoft.com/office/drawing/2010/compatibility",
            "http://schemas.microsoft.com/office/drawing/2012/chart",
            "http://schemas.microsoft.com/office/drawing/2012/chartStyle",
            "http://schemas.microsoft.com/office/webextensions/webextension/2010/11",
            "http://schemas.microsoft.com/office/drawing/2012/main",
            "http://schemas.microsoft.com/office/powerpoint/2012/main",
            "http://schemas.microsoft.com/office/word/2012/wordml",
            "http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11",
            "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main",
            "http://schemas.microsoft.com/office/spreadsheetml/2011/1/ac",
            "http://schemas.microsoft.com/office/thememl/2012/main",
            "http://schemas.microsoft.com/office/spreadsheetml/2010/11/ac",
            "http://schemas.microsoft.com/office/word/2012/wordprocessingDrawing",
            "http://schemas.microsoft.com/office/powerpoint/2012/roamingSettings",
            "http://schemas.microsoft.com/office/drawing/2012/timeslicer"
        };

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

        private static readonly HashSet<string> O12NamespaceSet = new HashSet<string>()
        {
            "http://www.w3.org/XML/1998/namespace",
            "http://schemas.openxmlformats.org/package/2006/metadata/core-properties",
            "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties",
            "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties",
            "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes",
            "http://purl.org/dc/elements/1.1/",
            "http://purl.org/dc/terms/",
            "http://schemas.openxmlformats.org/officeDocument/2006/characteristics",
            "http://schemas.openxmlformats.org/officeDocument/2006/bibliography",
            "http://schemas.openxmlformats.org/drawingml/2006/main",
            "http://schemas.openxmlformats.org/drawingml/2006/chart",
            "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing",
            "http://schemas.openxmlformats.org/drawingml/2006/compatibility",
            "http://schemas.openxmlformats.org/drawingml/2006/diagram",
            "http://schemas.openxmlformats.org/drawingml/2006/lockedCanvas",
            "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing",
            "http://schemas.openxmlformats.org/drawingml/2006/picture",
            "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing",
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships",
            "http://schemas.openxmlformats.org/officeDocument/2006/customXml",
            "http://schemas.openxmlformats.org/officeDocument/2006/math",
            "http://schemas.openxmlformats.org/spreadsheetml/2006/main",
            "http://schemas.openxmlformats.org/wordprocessingml/2006/main",
            "http://schemas.openxmlformats.org/presentationml/2006/main",
            "http://schemas.openxmlformats.org/schemaLibrary/2006/main",
            "urn:schemas-microsoft-com:vml",
            "urn:schemas-microsoft-com:office:office",
            "urn:schemas-microsoft-com:office:word",
            "urn:schemas-microsoft-com:office:excel",
            "urn:schemas-microsoft-com:office:powerpoint",
            "http://schemas.openxmlformats.org/markup-compatibility/2006",
            "http://schemas.microsoft.com/office/excel/2006/main",
            "http://schemas.microsoft.com/office/word/2006/wordml",
            "http://schemas.microsoft.com/office/2006/01/customui",
            "http://schemas.microsoft.com/office/2006/activeX",
            "http://schemas.microsoft.com/office/2006/coverPageProps",
            "http://schemas.microsoft.com/office/2006/customDocumentInformationPanel",
            "http://schemas.microsoft.com/office/2006/metadata/contentType",
            "http://schemas.microsoft.com/office/2006/metadata/customXsn",
            "http://schemas.microsoft.com/office/2006/metadata/longProperties",
            "http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes",
            "http://www.w3.org/2001/XMLSchema",
            "http://schemas.microsoft.com/office/drawing/2008/diagram",
            "http://www.w3.org/2003/InkML",
            "http://www.w3.org/2003/04/emma",
            "http://schemas.microsoft.com/ink/2010/main"
        };

        private static readonly HashSet<string> O14NamespaceSet = new HashSet<string>()
        {
            "http://schemas.microsoft.com/office/drawing/2007/8/2/chart",
            "http://schemas.microsoft.com/office/drawing/2010/chartDrawing",
            "http://schemas.microsoft.com/office/drawing/2010/main",
            "http://schemas.microsoft.com/office/powerpoint/2010/main",
            "http://schemas.microsoft.com/office/drawing/2010/picture",
            "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing",
            "http://schemas.microsoft.com/office/word/2010/wordml",
            "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main",
            "http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing",
            "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac",
            "http://schemas.microsoft.com/office/2009/07/customui",
            "http://schemas.microsoft.com/office/drawing/2010/diagram",
            "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas",
            "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup",
            "http://schemas.microsoft.com/office/word/2010/wordprocessingShape",
            "http://schemas.microsoft.com/office/drawing/2010/slicer",
            "http://schemas.microsoft.com/office/drawing/2010/compatibility"
        };

        private static readonly HashSet<string> O15NamespaceSet = new HashSet<string>()
        {
            "http://schemas.microsoft.com/office/drawing/2012/chart",
            "http://schemas.microsoft.com/office/drawing/2012/chartStyle",
            "http://schemas.microsoft.com/office/webextensions/webextension/2010/11",
            "http://schemas.microsoft.com/office/drawing/2012/main",
            "http://schemas.microsoft.com/office/powerpoint/2012/main",
            "http://schemas.microsoft.com/office/word/2012/wordml",
            "http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11",
            "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main",
            "http://schemas.microsoft.com/office/spreadsheetml/2011/1/ac",
            "http://schemas.microsoft.com/office/thememl/2012/main",
            "http://schemas.microsoft.com/office/spreadsheetml/2010/11/ac",
            "http://schemas.microsoft.com/office/word/2012/wordprocessingDrawing",
            "http://schemas.microsoft.com/office/powerpoint/2012/roamingSettings",
            "http://schemas.microsoft.com/office/drawing/2012/timeslicer"
        };

        static NamespaceIdMap()
        {
        }

        public static int Count => NamespaceList.Length;

        public static bool IsInFileFormat(string ns, FileFormatVersions format)
        {
            if (format == FileFormatVersions.Office2007)
            {
                return O12NamespaceSet.Contains(ns);
            }
            else if (format == FileFormatVersions.Office2010)
            {
                return O14NamespaceSet.Contains(ns);
            }
            else if (format == FileFormatVersions.Office2013)
            {
                return O15NamespaceSet.Contains(ns);
            }

            throw new NotImplementedException();
        }

        public static byte GetNamespaceId(string namespaceUri)
        {
            if (namespaceUri == null)
            {
                throw new ArgumentNullException(nameof(namespaceUri));
            }

            int num = Array.IndexOf(NamespaceList, namespaceUri);

            if (num >= 0)
            {
                return Convert.ToByte(num);
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public static bool TryGetNamespaceId(string namespaceUri, out byte id)
        {
            if (namespaceUri == null)
            {
                throw new ArgumentNullException(nameof(namespaceUri));
            }

            int num = Array.IndexOf(NamespaceList, namespaceUri);

            if (num >= 0 && num <= byte.MaxValue)
            {
                id = Convert.ToByte(num);
                return true;
            }
            else
            {
                id = byte.MaxValue;
                return false;
            }
        }

        public static string GetNamespaceUri(byte namespaceId) => NamespaceList[namespaceId];

        public static string GetNamespaceUri(string prefix)
        {
            if (prefix == null)
            {
                throw new ArgumentNullException(nameof(prefix));
            }

            int index = Array.IndexOf(NamespacePrefixList, prefix);

            return index >= 0
                ? NamespaceList[index]
                : null;
        }

        public static string GetNamespacePrefix(byte namespaceId) => NamespacePrefixList[namespaceId];
    }
}