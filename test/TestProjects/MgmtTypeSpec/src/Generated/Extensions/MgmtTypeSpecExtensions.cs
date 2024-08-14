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
using MgmtTypeSpec.Mocking;
using MgmtTypeSpec.Models;

namespace MgmtTypeSpec
{
    /// <summary> A class to add extension methods to MgmtTypeSpec. </summary>
    public static partial class MgmtTypeSpecExtensions
    {
        private static MockableMgmtTypeSpecArmClient GetMockableMgmtTypeSpecArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableMgmtTypeSpecArmClient(client0));
        }

        private static MockableMgmtTypeSpecResourceGroupResource GetMockableMgmtTypeSpecResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableMgmtTypeSpecResourceGroupResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="FooResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FooResource.CreateResourceIdentifier" /> to create a <see cref="FooResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtTypeSpecArmClient.GetFooResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="FooResource"/> object. </returns>
        public static FooResource GetFooResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableMgmtTypeSpecArmClient(client).GetFooResource(id);
        }

        /// <summary>
        /// Gets a collection of FooResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtTypeSpecResourceGroupResource.GetFoos()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of FooResources and their operations over a FooResource. </returns>
        public static FooCollection GetFoos(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableMgmtTypeSpecResourceGroupResource(resourceGroupResource).GetFoos();
        }

        /// <summary>
        /// Get a Foo
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/MgmtTypeSpec/foos/{fooName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Foos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>v1</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FooResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtTypeSpecResourceGroupResource.GetFooAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="fooName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fooName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<FooResource>> GetFooAsync(this ResourceGroupResource resourceGroupResource, string fooName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableMgmtTypeSpecResourceGroupResource(resourceGroupResource).GetFooAsync(fooName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Foo
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/MgmtTypeSpec/foos/{fooName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Foos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>v1</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FooResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtTypeSpecResourceGroupResource.GetFoo(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="fooName"> The name of the Foo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="fooName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fooName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<FooResource> GetFoo(this ResourceGroupResource resourceGroupResource, string fooName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableMgmtTypeSpecResourceGroupResource(resourceGroupResource).GetFoo(fooName, cancellationToken);
        }

        /// <summary>
        /// list private links on the given resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/MgmtTypeSpec/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResource_GetAllPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>v1</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtTypeSpecResourceGroupResource.GetAllPrivateLinkResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="MgmtTypeSpecPrivateLinkResourceData"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<MgmtTypeSpecPrivateLinkResourceData> GetAllPrivateLinkResourcesAsync(this ResourceGroupResource resourceGroupResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableMgmtTypeSpecResourceGroupResource(resourceGroupResource).GetAllPrivateLinkResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// list private links on the given resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/MgmtTypeSpec/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResource_GetAllPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>v1</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtTypeSpecResourceGroupResource.GetAllPrivateLinkResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> A collection of <see cref="MgmtTypeSpecPrivateLinkResourceData"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<MgmtTypeSpecPrivateLinkResourceData> GetAllPrivateLinkResources(this ResourceGroupResource resourceGroupResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableMgmtTypeSpecResourceGroupResource(resourceGroupResource).GetAllPrivateLinkResources(cancellationToken);
        }
    }
}
