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
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A Class representing a MgmtGrpParentWithNonResChWithLoc along with the instance operations that can be performed on it. </summary>
    public partial class MgmtGrpParentWithNonResChWithLoc : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MgmtGrpParentWithNonResChWithLoc"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string groupId, string mgmtGrpParentWithNonResChWithLocName)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mgmtGrpParentWithNonResChWithLocClientDiagnostics;
        private readonly MgmtGrpParentWithNonResChWithLocsRestOperations _mgmtGrpParentWithNonResChWithLocRestClient;
        private readonly MgmtGrpParentWithNonResChWithLocData _data;

        /// <summary> Initializes a new instance of the <see cref="MgmtGrpParentWithNonResChWithLoc"/> class for mocking. </summary>
        protected MgmtGrpParentWithNonResChWithLoc()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MgmtGrpParentWithNonResChWithLoc"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MgmtGrpParentWithNonResChWithLoc(ArmClient client, MgmtGrpParentWithNonResChWithLocData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MgmtGrpParentWithNonResChWithLoc"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MgmtGrpParentWithNonResChWithLoc(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mgmtGrpParentWithNonResChWithLocClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string mgmtGrpParentWithNonResChWithLocApiVersion);
            _mgmtGrpParentWithNonResChWithLocRestClient = new MgmtGrpParentWithNonResChWithLocsRestOperations(_mgmtGrpParentWithNonResChWithLocClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, mgmtGrpParentWithNonResChWithLocApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Management/managementGroups/mgmtGrpParentWithNonResChWithLocs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MgmtGrpParentWithNonResChWithLocData Data
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
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}
        /// Operation Id: MgmtGrpParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<MgmtGrpParentWithNonResChWithLoc>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mgmtGrpParentWithNonResChWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLoc.Get");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithNonResChWithLocRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _mgmtGrpParentWithNonResChWithLocClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MgmtGrpParentWithNonResChWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}
        /// Operation Id: MgmtGrpParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MgmtGrpParentWithNonResChWithLoc> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mgmtGrpParentWithNonResChWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLoc.Get");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithNonResChWithLocRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _mgmtGrpParentWithNonResChWithLocClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MgmtGrpParentWithNonResChWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}/nonResourceChild
        /// Operation Id: MgmtGrpParentWithNonResChWithLocs_ListNonResourceChild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NonResourceChild" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NonResourceChild> GetNonResourceChildAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NonResourceChild>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mgmtGrpParentWithNonResChWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLoc.GetNonResourceChild");
                scope.Start();
                try
                {
                    var response = await _mgmtGrpParentWithNonResChWithLocRestClient.ListNonResourceChildAsync(Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Lists all.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}/nonResourceChild
        /// Operation Id: MgmtGrpParentWithNonResChWithLocs_ListNonResourceChild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NonResourceChild" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NonResourceChild> GetNonResourceChild(CancellationToken cancellationToken = default)
        {
            Page<NonResourceChild> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mgmtGrpParentWithNonResChWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLoc.GetNonResourceChild");
                scope.Start();
                try
                {
                    var response = _mgmtGrpParentWithNonResChWithLocRestClient.ListNonResourceChild(Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Add a tag to the current resource.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}
        /// Operation Id: MgmtGrpParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<MgmtGrpParentWithNonResChWithLoc>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _mgmtGrpParentWithNonResChWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLoc.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _mgmtGrpParentWithNonResChWithLocRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MgmtGrpParentWithNonResChWithLoc(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}
        /// Operation Id: MgmtGrpParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithNonResChWithLoc> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _mgmtGrpParentWithNonResChWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLoc.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _mgmtGrpParentWithNonResChWithLocRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new MgmtGrpParentWithNonResChWithLoc(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}
        /// Operation Id: MgmtGrpParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<MgmtGrpParentWithNonResChWithLoc>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _mgmtGrpParentWithNonResChWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLoc.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _mgmtGrpParentWithNonResChWithLocRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MgmtGrpParentWithNonResChWithLoc(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}
        /// Operation Id: MgmtGrpParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithNonResChWithLoc> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _mgmtGrpParentWithNonResChWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLoc.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _mgmtGrpParentWithNonResChWithLocRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new MgmtGrpParentWithNonResChWithLoc(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}
        /// Operation Id: MgmtGrpParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<MgmtGrpParentWithNonResChWithLoc>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _mgmtGrpParentWithNonResChWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLoc.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _mgmtGrpParentWithNonResChWithLocRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MgmtGrpParentWithNonResChWithLoc(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}
        /// Operation Id: MgmtGrpParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithNonResChWithLoc> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _mgmtGrpParentWithNonResChWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLoc.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _mgmtGrpParentWithNonResChWithLocRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new MgmtGrpParentWithNonResChWithLoc(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
