// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListPublicIpAddresses API service call. </summary>
    internal partial class PublicIPAddressListResult
    {
        /// <summary> Initializes a new instance of PublicIPAddressListResult. </summary>
        internal PublicIPAddressListResult()
        {
            Value = new ChangeTrackingList<PublicIPAddress>();
        }

        /// <summary> Initializes a new instance of PublicIPAddressListResult. </summary>
        /// <param name="value"> A list of public IP addresses that exists in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal PublicIPAddressListResult(IReadOnlyList<PublicIPAddress> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of public IP addresses that exists in a resource group. </summary>
        public IReadOnlyList<PublicIPAddress> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
