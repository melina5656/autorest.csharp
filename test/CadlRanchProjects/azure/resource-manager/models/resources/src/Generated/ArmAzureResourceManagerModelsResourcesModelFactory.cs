// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace _Azure.ResourceManager.Models.Resources.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmAzureResourceManagerModelsResourcesModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Resources.TopLevelTrackedResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="Resources.TopLevelTrackedResourceData"/> instance for mocking. </returns>
        public static TopLevelTrackedResourceData TopLevelTrackedResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, TopLevelTrackedResourceProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new TopLevelTrackedResourceData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.TopLevelTrackedResourceProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="description"> The description of the resource. </param>
        /// <returns> A new <see cref="Models.TopLevelTrackedResourceProperties"/> instance for mocking. </returns>
        public static TopLevelTrackedResourceProperties TopLevelTrackedResourceProperties(ProvisioningState? provisioningState = null, string description = null)
        {
            return new TopLevelTrackedResourceProperties(provisioningState, description, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Resources.NestedProxyResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="Resources.NestedProxyResourceData"/> instance for mocking. </returns>
        public static NestedProxyResourceData NestedProxyResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, NestedProxyResourceProperties properties = null)
        {
            return new NestedProxyResourceData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NestedProxyResourceProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning State of the nested child Resource. </param>
        /// <param name="description"> Nested resource description. </param>
        /// <returns> A new <see cref="Models.NestedProxyResourceProperties"/> instance for mocking. </returns>
        public static NestedProxyResourceProperties NestedProxyResourceProperties(ProvisioningState? provisioningState = null, string description = null)
        {
            return new NestedProxyResourceProperties(provisioningState, description, serializedAdditionalRawData: null);
        }
    }
}
