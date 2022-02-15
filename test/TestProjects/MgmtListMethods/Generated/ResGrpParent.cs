// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace MgmtListMethods
{
    /// <summary> A Class representing a ResGrpParent along with the instance operations that can be performed on it. </summary>
    public partial class ResGrpParent : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResGrpParent"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resGrpParentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resGrpParentClientDiagnostics;
        private readonly ResGrpParentsRestOperations _resGrpParentRestClient;
        private readonly ResGrpParentData _data;

        /// <summary> Initializes a new instance of the <see cref="ResGrpParent"/> class for mocking. </summary>
        protected ResGrpParent()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResGrpParent"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResGrpParent(ArmClient client, ResGrpParentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResGrpParent"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResGrpParent(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resGrpParentClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string resGrpParentApiVersion);
            _resGrpParentRestClient = new ResGrpParentsRestOperations(_resGrpParentClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, resGrpParentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MgmtListMethods/resGrpParents";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResGrpParentData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ResGrpParent>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParent.Get");
            scope.Start();
            try
            {
                var response = await _resGrpParentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _resGrpParentClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ResGrpParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResGrpParent> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParent.Get");
            scope.Start();
            try
            {
                var response = _resGrpParentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _resGrpParentClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResGrpParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<ResGrpParent>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParent.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _resGrpParentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResGrpParent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<ResGrpParent> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParent.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _resGrpParentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ResGrpParent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<ResGrpParent>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParent.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _resGrpParentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResGrpParent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<ResGrpParent> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParent.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _resGrpParentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ResGrpParent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<ResGrpParent>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParent.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _resGrpParentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResGrpParent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<ResGrpParent> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParent.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _resGrpParentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ResGrpParent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
