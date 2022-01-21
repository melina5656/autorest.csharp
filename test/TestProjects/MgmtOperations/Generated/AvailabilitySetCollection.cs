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
using MgmtOperations.Models;

namespace MgmtOperations
{
    /// <summary> A class representing collection of AvailabilitySet and their operations over its parent. </summary>
    public partial class AvailabilitySetCollection : ArmCollection, IEnumerable<AvailabilitySet>, IAsyncEnumerable<AvailabilitySet>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AvailabilitySetsRestOperations _availabilitySetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AvailabilitySetCollection"/> class for mocking. </summary>
        protected AvailabilitySetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AvailabilitySetCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AvailabilitySetCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(AvailabilitySet.ResourceType, out string apiVersion);
            _availabilitySetsRestClient = new AvailabilitySetsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AvailabilitySets_CreateOrUpdate
        /// <summary> Create or update an availability set. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual AvailabilitySetCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string availabilitySetName, AvailabilitySetData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _availabilitySetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, parameters, cancellationToken);
                var operation = new AvailabilitySetCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AvailabilitySets_CreateOrUpdate
        /// <summary> Create or update an availability set. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<AvailabilitySetCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string availabilitySetName, AvailabilitySetData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _availabilitySetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new AvailabilitySetCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AvailabilitySets_Get
        /// <summary> Retrieves information about an availability set. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual Response<AvailabilitySet> Get(string availabilitySetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetCollection.Get");
            scope.Start();
            try
            {
                var response = _availabilitySetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvailabilitySet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AvailabilitySets_Get
        /// <summary> Retrieves information about an availability set. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public async virtual Task<Response<AvailabilitySet>> GetAsync(string availabilitySetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetCollection.Get");
            scope.Start();
            try
            {
                var response = await _availabilitySetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AvailabilitySet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual Response<AvailabilitySet> GetIfExists(string availabilitySetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _availabilitySetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AvailabilitySet>(null, response.GetRawResponse());
                return Response.FromValue(new AvailabilitySet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public async virtual Task<Response<AvailabilitySet>> GetIfExistsAsync(string availabilitySetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _availabilitySetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, availabilitySetName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AvailabilitySet>(null, response.GetRawResponse());
                return Response.FromValue(new AvailabilitySet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public virtual Response<bool> Exists(string availabilitySetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(availabilitySetName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string availabilitySetName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetName, nameof(availabilitySetName));

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(availabilitySetName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AvailabilitySets_List
        /// <summary> Retrieves information about an availability set. </summary>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailabilitySet" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailabilitySet> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<AvailabilitySet> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailabilitySetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _availabilitySetsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AvailabilitySet(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AvailabilitySets_List
        /// <summary> Retrieves information about an availability set. </summary>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailabilitySet" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailabilitySet> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<AvailabilitySet>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailabilitySetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _availabilitySetsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AvailabilitySet(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="AvailabilitySet" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AvailabilitySet.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="AvailabilitySet" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AvailabilitySet.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AvailabilitySet> IEnumerable<AvailabilitySet>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AvailabilitySet> IAsyncEnumerable<AvailabilitySet>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, AvailabilitySet, AvailabilitySetData> Construct() { }
    }
}
