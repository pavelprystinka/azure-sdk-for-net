// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines web application firewall policy for Azure CDN.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CdnWebApplicationFirewallPolicy : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the CdnWebApplicationFirewallPolicy
        /// class.
        /// </summary>
        public CdnWebApplicationFirewallPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CdnWebApplicationFirewallPolicy
        /// class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="sku">The pricing tier (defines a CDN provider, feature
        /// list and rate) of the CdnWebApplicationFirewallPolicy.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="policySettings">Describes  policySettings for
        /// policy</param>
        /// <param name="rateLimitRules">Describes rate limit rules inside the
        /// policy.</param>
        /// <param name="customRules">Describes custom rules inside the
        /// policy.</param>
        /// <param name="managedRules">Describes managed rules inside the
        /// policy.</param>
        /// <param name="endpointLinks">Describes Azure CDN endpoints
        /// associated with this Web Application Firewall policy.</param>
        /// <param name="provisioningState">Provisioning state of the
        /// WebApplicationFirewallPolicy. Possible values include: 'Creating',
        /// 'Succeeded', 'Failed'</param>
        /// <param name="resourceState">Resource status of the policy.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public CdnWebApplicationFirewallPolicy(string location, Sku sku, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), IDictionary<string, string> tags = default(IDictionary<string, string>), PolicySettings policySettings = default(PolicySettings), RateLimitRuleList rateLimitRules = default(RateLimitRuleList), CustomRuleList customRules = default(CustomRuleList), ManagedRuleSetList managedRules = default(ManagedRuleSetList), IList<CdnEndpoint> endpointLinks = default(IList<CdnEndpoint>), string provisioningState = default(string), string resourceState = default(string), string etag = default(string))
            : base(location, id, name, type, systemData, tags)
        {
            PolicySettings = policySettings;
            RateLimitRules = rateLimitRules;
            CustomRules = customRules;
            ManagedRules = managedRules;
            EndpointLinks = endpointLinks;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            Etag = etag;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes  policySettings for policy
        /// </summary>
        [JsonProperty(PropertyName = "properties.policySettings")]
        public PolicySettings PolicySettings { get; set; }

        /// <summary>
        /// Gets or sets describes rate limit rules inside the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rateLimitRules")]
        public RateLimitRuleList RateLimitRules { get; set; }

        /// <summary>
        /// Gets or sets describes custom rules inside the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customRules")]
        public CustomRuleList CustomRules { get; set; }

        /// <summary>
        /// Gets or sets describes managed rules inside the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedRules")]
        public ManagedRuleSetList ManagedRules { get; set; }

        /// <summary>
        /// Gets describes Azure CDN endpoints associated with this Web
        /// Application Firewall policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpointLinks")]
        public IList<CdnEndpoint> EndpointLinks { get; private set; }

        /// <summary>
        /// Gets provisioning state of the WebApplicationFirewallPolicy.
        /// Possible values include: 'Creating', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets resource status of the policy.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'Creating', 'Enabling', 'Enabled',
        /// 'Disabling', 'Disabled', 'Deleting'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the pricing tier (defines a CDN provider, feature list
        /// and rate) of the CdnWebApplicationFirewallPolicy.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (PolicySettings != null)
            {
                PolicySettings.Validate();
            }
        }
    }
}
