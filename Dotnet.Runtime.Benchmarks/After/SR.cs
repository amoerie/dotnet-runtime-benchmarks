namespace Dotnet.Runtime.Benchmarks.After
{
    public static class SR
    {
        /// <summary>File path must be a non-empty string.</summary>
        internal static string Error_InvalidFilePath => @"File path must be a non-empty string.";
        /// <summary>A duplicate key '{0}' was found.{1}</summary>
        internal static string Error_KeyIsDuplicated => "A duplicate key '{0}' was found.{1}";
        /// <summary>XML namespaces are not supported.{0}</summary>
        internal static string Error_NamespaceIsNotSupported => @"XML namespaces are not supported.{0}";
        /// <summary>Unsupported node type '{0}' was found.{1}</summary>
        internal static string Error_UnsupportedNodeType => @"Unsupported node type '{0}' was found.{1}";
        /// <summary>Line {0}, position {1}.</summary>
        internal static string Msg_LineInfo => @"Line {0}, position {1}.";

        internal static string Format(string message, object p1) => string.Format(message, p1);
        internal static string Format(string message, object p1, object p2) => string.Format(message, p1, p2);
    }
}