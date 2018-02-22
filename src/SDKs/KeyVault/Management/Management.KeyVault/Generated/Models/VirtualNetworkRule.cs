// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Class Virtual-Network-Rule
    /// </summary>
    public partial class VirtualNetworkRule
    {
        /// <summary>
        /// Full Azure resource id of a vnet subnet, such as
        /// "/subscriptions/subid/resourceGroups/rg1/
        /// providers/Microsoft.Network/virtualNetworks/
        /// test-vnet/subnets/subnet1".
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}