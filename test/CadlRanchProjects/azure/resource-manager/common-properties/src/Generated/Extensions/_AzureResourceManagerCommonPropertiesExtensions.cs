// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using _Azure.ResourceManager.CommonProperties.Mocking;

namespace _Azure.ResourceManager.CommonProperties
{
    /// <summary> A class to add extension methods to _Azure.ResourceManager.CommonProperties. </summary>
    public static partial class _AzureResourceManagerCommonPropertiesExtensions
    {
        private static Mockable_AzureResourceManagerCommonPropertiesArmClient GetMockable_AzureResourceManagerCommonPropertiesArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new Mockable_AzureResourceManagerCommonPropertiesArmClient(client0));
        }

        private static Mockable_AzureResourceManagerCommonPropertiesResourceGroupResource GetMockable_AzureResourceManagerCommonPropertiesResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new Mockable_AzureResourceManagerCommonPropertiesResourceGroupResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="ManagedIdentityTrackedResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedIdentityTrackedResource.CreateResourceIdentifier" /> to create a <see cref="ManagedIdentityTrackedResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="Mockable_AzureResourceManagerCommonPropertiesArmClient.GetManagedIdentityTrackedResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ManagedIdentityTrackedResource"/> object. </returns>
        public static ManagedIdentityTrackedResource GetManagedIdentityTrackedResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockable_AzureResourceManagerCommonPropertiesArmClient(client).GetManagedIdentityTrackedResource(id);
        }

        /// <summary>
        /// Gets a collection of ManagedIdentityTrackedResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="Mockable_AzureResourceManagerCommonPropertiesResourceGroupResource.GetManagedIdentityTrackedResources()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of ManagedIdentityTrackedResources and their operations over a ManagedIdentityTrackedResource. </returns>
        public static ManagedIdentityTrackedResourceCollection GetManagedIdentityTrackedResources(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockable_AzureResourceManagerCommonPropertiesResourceGroupResource(resourceGroupResource).GetManagedIdentityTrackedResources();
        }

        /// <summary>
        /// Get a ManagedIdentityTrackedResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Azure.ResourceManager.CommonProperties/managedIdentityTrackedResources/{managedIdentityTrackedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedIdentityTrackedResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedIdentityTrackedResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="Mockable_AzureResourceManagerCommonPropertiesResourceGroupResource.GetManagedIdentityTrackedResourceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="managedIdentityTrackedResourceName"> arm resource name for path. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="managedIdentityTrackedResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managedIdentityTrackedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ManagedIdentityTrackedResource>> GetManagedIdentityTrackedResourceAsync(this ResourceGroupResource resourceGroupResource, string managedIdentityTrackedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockable_AzureResourceManagerCommonPropertiesResourceGroupResource(resourceGroupResource).GetManagedIdentityTrackedResourceAsync(managedIdentityTrackedResourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a ManagedIdentityTrackedResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Azure.ResourceManager.CommonProperties/managedIdentityTrackedResources/{managedIdentityTrackedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedIdentityTrackedResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedIdentityTrackedResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="Mockable_AzureResourceManagerCommonPropertiesResourceGroupResource.GetManagedIdentityTrackedResource(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="managedIdentityTrackedResourceName"> arm resource name for path. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="managedIdentityTrackedResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managedIdentityTrackedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ManagedIdentityTrackedResource> GetManagedIdentityTrackedResource(this ResourceGroupResource resourceGroupResource, string managedIdentityTrackedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockable_AzureResourceManagerCommonPropertiesResourceGroupResource(resourceGroupResource).GetManagedIdentityTrackedResource(managedIdentityTrackedResourceName, cancellationToken);
        }
    }
}
