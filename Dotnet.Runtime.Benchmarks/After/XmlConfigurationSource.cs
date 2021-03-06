// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.Configuration;

namespace Dotnet.Runtime.Benchmarks.After
{
    /// <summary>
    /// An XML file based <see cref="FileConfigurationSource"/>.
    /// </summary>
    public class XmlConfigurationSource : FileConfigurationSource
    {
        /// <summary>
        /// Builds the <see cref="XmlConfigurationProvider"/> for this source.
        /// </summary>
        /// <param name="builder">The <see cref="IConfigurationBuilder"/>.</param>
        /// <returns>A <see cref="XmlConfigurationProvider"/></returns>
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            EnsureDefaults(builder);
            return new XmlConfigurationProvider(this);
        }
    }
}
