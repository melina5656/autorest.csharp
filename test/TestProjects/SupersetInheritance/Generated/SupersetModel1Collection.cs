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

namespace SupersetInheritance
{
    /// <summary> A class representing collection of SupersetModel1 and their operations over its parent. </summary>
    public partial class SupersetModel1Collection : ArmCollection, IEnumerable<SupersetModel1>, IAsyncEnumerable<SupersetModel1>
    {
        private readonly ClientDiagnostics _supersetModel1ClientDiagnostics;
        private readonly SupersetModel1SRestOperations _supersetModel1RestClient;

        /// <summary> Initializes a new instance of the <see cref="SupersetModel1Collection"/> class for mocking. </summary>
        protected SupersetModel1Collection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SupersetModel1Collection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SupersetModel1Collection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supersetModel1ClientDiagnostics = new ClientDiagnostics("SupersetInheritance", SupersetModel1.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SupersetModel1.ResourceType, out string supersetModel1ApiVersion);
            _supersetModel1RestClient = new SupersetModel1SRestOperations(_supersetModel1ClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, supersetModel1ApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1SName}
        /// Operation Id: SupersetModel1s_Put
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="parameters"> The SupersetModel1 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel1SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<SupersetModel1>> CreateOrUpdateAsync(bool waitForCompletion, string supersetModel1SName, SupersetModel1Data parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel1SName, nameof(supersetModel1SName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _supersetModel1ClientDiagnostics.CreateScope("SupersetModel1Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _supersetModel1RestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel1SName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SupersetInheritanceArmOperation<SupersetModel1>(Response.FromValue(new SupersetModel1(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1SName}
        /// Operation Id: SupersetModel1s_Put
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="parameters"> The SupersetModel1 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel1SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<SupersetModel1> CreateOrUpdate(bool waitForCompletion, string supersetModel1SName, SupersetModel1Data parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel1SName, nameof(supersetModel1SName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _supersetModel1ClientDiagnostics.CreateScope("SupersetModel1Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _supersetModel1RestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, supersetModel1SName, parameters, cancellationToken);
                var operation = new SupersetInheritanceArmOperation<SupersetModel1>(Response.FromValue(new SupersetModel1(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1SName}
        /// Operation Id: SupersetModel1s_Get
        /// </summary>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel1SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        public async virtual Task<Response<SupersetModel1>> GetAsync(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel1SName, nameof(supersetModel1SName));

            using var scope = _supersetModel1ClientDiagnostics.CreateScope("SupersetModel1Collection.Get");
            scope.Start();
            try
            {
                var response = await _supersetModel1RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel1SName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _supersetModel1ClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SupersetModel1(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1SName}
        /// Operation Id: SupersetModel1s_Get
        /// </summary>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel1SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        public virtual Response<SupersetModel1> Get(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel1SName, nameof(supersetModel1SName));

            using var scope = _supersetModel1ClientDiagnostics.CreateScope("SupersetModel1Collection.Get");
            scope.Start();
            try
            {
                var response = _supersetModel1RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, supersetModel1SName, cancellationToken);
                if (response.Value == null)
                    throw _supersetModel1ClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupersetModel1(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s
        /// Operation Id: SupersetModel1s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SupersetModel1" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SupersetModel1> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SupersetModel1>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _supersetModel1ClientDiagnostics.CreateScope("SupersetModel1Collection.GetAll");
                scope.Start();
                try
                {
                    var response = await _supersetModel1RestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SupersetModel1(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s
        /// Operation Id: SupersetModel1s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SupersetModel1" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SupersetModel1> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SupersetModel1> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _supersetModel1ClientDiagnostics.CreateScope("SupersetModel1Collection.GetAll");
                scope.Start();
                try
                {
                    var response = _supersetModel1RestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SupersetModel1(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1SName}
        /// Operation Id: SupersetModel1s_Get
        /// </summary>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel1SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel1SName, nameof(supersetModel1SName));

            using var scope = _supersetModel1ClientDiagnostics.CreateScope("SupersetModel1Collection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(supersetModel1SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1SName}
        /// Operation Id: SupersetModel1s_Get
        /// </summary>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel1SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        public virtual Response<bool> Exists(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel1SName, nameof(supersetModel1SName));

            using var scope = _supersetModel1ClientDiagnostics.CreateScope("SupersetModel1Collection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(supersetModel1SName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1SName}
        /// Operation Id: SupersetModel1s_Get
        /// </summary>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel1SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        public async virtual Task<Response<SupersetModel1>> GetIfExistsAsync(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel1SName, nameof(supersetModel1SName));

            using var scope = _supersetModel1ClientDiagnostics.CreateScope("SupersetModel1Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _supersetModel1RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel1SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SupersetModel1>(null, response.GetRawResponse());
                return Response.FromValue(new SupersetModel1(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1SName}
        /// Operation Id: SupersetModel1s_Get
        /// </summary>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel1SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        public virtual Response<SupersetModel1> GetIfExists(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel1SName, nameof(supersetModel1SName));

            using var scope = _supersetModel1ClientDiagnostics.CreateScope("SupersetModel1Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = _supersetModel1RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, supersetModel1SName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SupersetModel1>(null, response.GetRawResponse());
                return Response.FromValue(new SupersetModel1(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SupersetModel1> IEnumerable<SupersetModel1>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SupersetModel1> IAsyncEnumerable<SupersetModel1>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
