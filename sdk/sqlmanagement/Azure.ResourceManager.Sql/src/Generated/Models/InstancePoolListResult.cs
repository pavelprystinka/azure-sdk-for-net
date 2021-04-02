// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of Azure SQL instance pools. </summary>
    internal partial class InstancePoolListResult
    {
        /// <summary> Initializes a new instance of InstancePoolListResult. </summary>
        internal InstancePoolListResult()
        {
            Value = new ChangeTrackingList<InstancePool>();
        }

        /// <summary> Initializes a new instance of InstancePoolListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal InstancePoolListResult(IReadOnlyList<InstancePool> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<InstancePool> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
