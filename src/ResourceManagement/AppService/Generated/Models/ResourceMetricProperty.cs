// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Resource metric property.
    /// </summary>
    public partial class ResourceMetricProperty
    {
        /// <summary>
        /// Initializes a new instance of the ResourceMetricProperty class.
        /// </summary>
        public ResourceMetricProperty()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceMetricProperty class.
        /// </summary>
        /// <param name="key">Key for resource metric property.</param>
        /// <param name="value">Value of pair.</param>
        public ResourceMetricProperty(string key = default(string), string value = default(string))
        {
            Key = key;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets key for resource metric property.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets value of pair.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}