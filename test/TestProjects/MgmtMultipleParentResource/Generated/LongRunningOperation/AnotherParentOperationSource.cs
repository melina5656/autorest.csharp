// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace MgmtMultipleParentResource
{
    internal class AnotherParentOperationSource : IOperationSource<AnotherParentResource>
    {
        private readonly ArmClient _client;

        internal AnotherParentOperationSource(ArmClient client)
        {
            _client = client;
        }

        AnotherParentResource IOperationSource<AnotherParentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AnotherParentData.DeserializeAnotherParentData(document.RootElement);
            return new AnotherParentResource(_client, data);
        }

        async ValueTask<AnotherParentResource> IOperationSource<AnotherParentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AnotherParentData.DeserializeAnotherParentData(document.RootElement);
            return new AnotherParentResource(_client, data);
        }
    }
}
