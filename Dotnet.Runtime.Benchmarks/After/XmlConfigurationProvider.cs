// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using Microsoft.Extensions.Configuration;

namespace Dotnet.Runtime.Benchmarks.After
{
    /// <summary>
    /// Represents an XML file as an <see cref="IConfigurationSource"/>.
    /// </summary>
    public class XmlConfigurationProvider : FileConfigurationProvider
    {
        /// <summary>
        /// Initializes a new instance with the specified source.
        /// </summary>
        /// <param name="source">The source settings.</param>
        public XmlConfigurationProvider(XmlConfigurationSource source) : base(source) { }

        internal XmlDocumentDecryptor Decryptor { get; set; } = XmlDocumentDecryptor.Instance;

        /// <summary>
        /// Loads the XML data from a stream.
        /// </summary>
        /// <param name="stream">The stream to read.</param>
        public override void Load(Stream stream)
        {
            Data = XmlStreamConfigurationProvider.Read(stream, Decryptor);
        }
    }
}
