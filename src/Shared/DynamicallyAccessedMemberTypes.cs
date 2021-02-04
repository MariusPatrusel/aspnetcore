// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore
{
    internal static class DynamicallyAccessedMemberTypesFlags
    {
        /// <summary>
        /// Flags for a member that is JSON (de)serialized.
        /// </summary>
        public const DynamicallyAccessedMemberTypes JsonSerialized = DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.PublicProperties;
    }
}
