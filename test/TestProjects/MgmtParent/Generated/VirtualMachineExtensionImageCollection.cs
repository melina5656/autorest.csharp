// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using MgmtParent.Models;

namespace MgmtParent
{
    /// <summary> A class representing collection of VirtualMachineExtensionImage and their operations over its parent. </summary>
    public partial class VirtualMachineExtensionImageCollection : ArmCollection, IEnumerable<VirtualMachineExtensionImage>, IAsyncEnumerable<VirtualMachineExtensionImage>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualMachineExtensionImagesRestOperations _virtualMachineExtensionImagesRestClient;
        private readonly string _location;
        private readonly string _publisherName;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineExtensionImageCollection"/> class for mocking. </summary>
        protected VirtualMachineExtensionImageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineExtensionImageCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="publisherName"/> is null. </exception>
        internal VirtualMachineExtensionImageCollection(ArmResource parent, string location, string publisherName) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(VirtualMachineExtensionImage.ResourceType, out string apiVersion);
            _virtualMachineExtensionImagesRestClient = new VirtualMachineExtensionImagesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _location = location;
            _publisherName = publisherName;
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions/{version}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: VirtualMachineExtensionImages_Get
        /// <summary> Gets a virtual machine extension image. </summary>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> or <paramref name="version"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public virtual Response<VirtualMachineExtensionImage> Get(string type, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineExtensionImagesRestClient.Get(Id.SubscriptionId, _location, _publisherName, type, version, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineExtensionImage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions/{version}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: VirtualMachineExtensionImages_Get
        /// <summary> Gets a virtual machine extension image. </summary>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> or <paramref name="version"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineExtensionImage>> GetAsync(string type, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineExtensionImagesRestClient.GetAsync(Id.SubscriptionId, _location, _publisherName, type, version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineExtensionImage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> or <paramref name="version"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public virtual Response<VirtualMachineExtensionImage> GetIfExists(string type, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineExtensionImagesRestClient.Get(Id.SubscriptionId, _location, _publisherName, type, version, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineExtensionImage>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineExtensionImage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> or <paramref name="version"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineExtensionImage>> GetIfExistsAsync(string type, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineExtensionImagesRestClient.GetAsync(Id.SubscriptionId, _location, _publisherName, type, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineExtensionImage>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineExtensionImage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> or <paramref name="version"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public virtual Response<bool> Exists(string type, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(type, version, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> or <paramref name="version"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string type, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(type, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: VirtualMachineExtensionImages_ListTypes
        /// <summary> Gets a list of virtual machine extension image types. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineExtensionImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineExtensionImage> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineExtensionImage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineExtensionImagesRestClient.ListTypes(Id.SubscriptionId, _location, _publisherName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Select(value => new VirtualMachineExtensionImage(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: VirtualMachineExtensionImages_ListTypes
        /// <summary> Gets a list of virtual machine extension image types. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineExtensionImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineExtensionImage> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineExtensionImage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineExtensionImagesRestClient.ListTypesAsync(Id.SubscriptionId, _location, _publisherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Select(value => new VirtualMachineExtensionImage(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: VirtualMachineExtensionImages_ListVersions
        /// <summary> Gets a list of virtual machine extension image versions. </summary>
        /// <param name="type"> The String to use. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="top"> The Integer to use. </param>
        /// <param name="orderby"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> is null. </exception>
        /// <returns> A collection of <see cref="VirtualMachineExtensionImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineExtensionImage> GetAll(string type, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));

            Page<VirtualMachineExtensionImage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineExtensionImagesRestClient.ListVersions(Id.SubscriptionId, _location, _publisherName, type, filter, top, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Select(value => new VirtualMachineExtensionImage(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: VirtualMachineExtensionImages_ListVersions
        /// <summary> Gets a list of virtual machine extension image versions. </summary>
        /// <param name="type"> The String to use. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="top"> The Integer to use. </param>
        /// <param name="orderby"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="type"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> is null. </exception>
        /// <returns> An async collection of <see cref="VirtualMachineExtensionImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineExtensionImage> GetAllAsync(string type, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(type, nameof(type));

            async Task<Page<VirtualMachineExtensionImage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineExtensionImagesRestClient.ListVersionsAsync(Id.SubscriptionId, _location, _publisherName, type, filter, top, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Select(value => new VirtualMachineExtensionImage(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="VirtualMachineExtensionImage" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineExtensionImage.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualMachineExtensionImage" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineExtensionImage.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineExtensionImage> IEnumerable<VirtualMachineExtensionImage>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineExtensionImage> IAsyncEnumerable<VirtualMachineExtensionImage>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VirtualMachineExtensionImage, VirtualMachineExtensionImageData> Construct() { }
    }
}
