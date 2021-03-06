// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Migrate.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Security Rule data model for Network Security Groups.
    /// </summary>
    public partial class NsgSecurityRule
    {
        /// <summary>
        /// Initializes a new instance of the NsgSecurityRule class.
        /// </summary>
        public NsgSecurityRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NsgSecurityRule class.
        /// </summary>
        /// <param name="name">Gets or sets the Security rule name.</param>
        /// <param name="access">Gets or sets whether network traffic is
        /// allowed or denied.
        /// Possible values are “Allow” and “Deny”.</param>
        /// <param name="description">Gets or sets a description for this rule.
        /// Restricted to 140 chars.</param>
        /// <param name="destinationAddressPrefix">Gets or sets destination
        /// address prefix. CIDR or source IP range.
        /// A “*” can also be used to match all source IPs. Default tags such
        /// as ‘VirtualNetwork’, ‘AzureLoadBalancer’ and ‘Internet’ can also be
        /// used.</param>
        /// <param name="destinationPortRange">Gets or sets Destination Port or
        /// Range. Integer or range between
        /// 0 and 65535. A “*” can also be used to match all ports.</param>
        /// <param name="direction">Gets or sets the direction of the
        /// rule.InBound or Outbound. The
        /// direction specifies if rule will be evaluated on incoming or
        /// outgoing traffic.</param>
        /// <param name="priority">Gets or sets the priority of the rule. The
        /// value can be between
        /// 100 and 4096. The priority number must be unique for each rule in
        /// the collection.
        /// The lower the priority number, the higher the priority of the
        /// rule.</param>
        /// <param name="protocol">Gets or sets Network protocol this rule
        /// applies to. Can be Tcp, Udp or All(*).</param>
        /// <param name="sourceAddressPrefix">Gets or sets source address
        /// prefix. CIDR or source IP range. A
        /// “*” can also be used to match all source IPs.  Default tags such as
        /// ‘VirtualNetwork’,
        /// ‘AzureLoadBalancer’ and ‘Internet’ can also be used. If this is an
        /// ingress
        /// rule, specifies where network traffic originates from.</param>
        /// <param name="sourcePortRange">Gets or sets Source Port or Range.
        /// Integer or range between 0 and
        /// 65535. A “*” can also be used to match all ports.</param>
        public NsgSecurityRule(string name = default(string), string access = default(string), string description = default(string), string destinationAddressPrefix = default(string), string destinationPortRange = default(string), string direction = default(string), int? priority = default(int?), string protocol = default(string), string sourceAddressPrefix = default(string), string sourcePortRange = default(string))
        {
            Name = name;
            Access = access;
            Description = description;
            DestinationAddressPrefix = destinationAddressPrefix;
            DestinationPortRange = destinationPortRange;
            Direction = direction;
            Priority = priority;
            Protocol = protocol;
            SourceAddressPrefix = sourceAddressPrefix;
            SourcePortRange = sourcePortRange;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Security rule name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets whether network traffic is allowed or denied.
        /// Possible values are “Allow” and “Deny”.
        /// </summary>
        [JsonProperty(PropertyName = "access")]
        public string Access { get; set; }

        /// <summary>
        /// Gets or sets a description for this rule. Restricted to 140 chars.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets destination address prefix. CIDR or source IP range.
        /// A “*” can also be used to match all source IPs. Default tags such
        /// as ‘VirtualNetwork’, ‘AzureLoadBalancer’ and ‘Internet’ can also be
        /// used.
        /// </summary>
        [JsonProperty(PropertyName = "destinationAddressPrefix")]
        public string DestinationAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets Destination Port or Range. Integer or range between
        /// 0 and 65535. A “*” can also be used to match all ports.
        /// </summary>
        [JsonProperty(PropertyName = "destinationPortRange")]
        public string DestinationPortRange { get; set; }

        /// <summary>
        /// Gets or sets the direction of the rule.InBound or Outbound. The
        /// direction specifies if rule will be evaluated on incoming or
        /// outgoing traffic.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets the priority of the rule. The value can be between
        /// 100 and 4096. The priority number must be unique for each rule in
        /// the collection.
        /// The lower the priority number, the higher the priority of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets Network protocol this rule applies to. Can be Tcp, Udp
        /// or All(*).
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets source address prefix. CIDR or source IP range. A
        /// “*” can also be used to match all source IPs.  Default tags such as
        /// ‘VirtualNetwork’,
        /// ‘AzureLoadBalancer’ and ‘Internet’ can also be used. If this is an
        /// ingress
        /// rule, specifies where network traffic originates from.
        /// </summary>
        [JsonProperty(PropertyName = "sourceAddressPrefix")]
        public string SourceAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets Source Port or Range. Integer or range between 0 and
        /// 65535. A “*” can also be used to match all ports.
        /// </summary>
        [JsonProperty(PropertyName = "sourcePortRange")]
        public string SourcePortRange { get; set; }

    }
}
