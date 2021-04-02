// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Represents the response to a List database replication link request. </summary>
    internal partial class ReplicationLinkListResult
    {
        /// <summary> Initializes a new instance of ReplicationLinkListResult. </summary>
        internal ReplicationLinkListResult()
        {
            Value = new ChangeTrackingList<ReplicationLink>();
        }

        /// <summary> Initializes a new instance of ReplicationLinkListResult. </summary>
        /// <param name="value"> The list of database replication links housed in the database. </param>
        internal ReplicationLinkListResult(IReadOnlyList<ReplicationLink> value)
        {
            Value = value;
        }

        /// <summary> The list of database replication links housed in the database. </summary>
        public IReadOnlyList<ReplicationLink> Value { get; }
    }
}
