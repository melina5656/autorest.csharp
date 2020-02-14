// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using lro.Models;

namespace lro
{
    internal partial class LROSADsOperations
    {
        private string host;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;
        /// <summary> Initializes a new instance of LROSADsOperations. </summary>
        public LROSADsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            this.host = host;
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        internal HttpMessage CreatePutNonRetry400Request(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/nonretryerror/put/400", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running put request, service returns a 400 to the initial request. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutNonRetry400Async(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutNonRetry400");
            scope.Start();
            try
            {
                using var message = CreatePutNonRetry400Request(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running put request, service returns a 400 to the initial request. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutNonRetry400(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutNonRetry400");
            scope.Start();
            try
            {
                using var message = CreatePutNonRetry400Request(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePutNonRetry201Creating400Request(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/nonretryerror/put/201/creating/400", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running put request, service returns a Product with &apos;ProvisioningState&apos; = &apos;Creating&apos; and 201 response code. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutNonRetry201Creating400Async(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutNonRetry201Creating400");
            scope.Start();
            try
            {
                using var message = CreatePutNonRetry201Creating400Request(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running put request, service returns a Product with &apos;ProvisioningState&apos; = &apos;Creating&apos; and 201 response code. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutNonRetry201Creating400(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutNonRetry201Creating400");
            scope.Start();
            try
            {
                using var message = CreatePutNonRetry201Creating400Request(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePutNonRetry201Creating400InvalidJsonRequest(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/nonretryerror/put/201/creating/400/invalidjson", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running put request, service returns a Product with &apos;ProvisioningState&apos; = &apos;Creating&apos; and 201 response code. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutNonRetry201Creating400InvalidJsonAsync(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutNonRetry201Creating400InvalidJson");
            scope.Start();
            try
            {
                using var message = CreatePutNonRetry201Creating400InvalidJsonRequest(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running put request, service returns a Product with &apos;ProvisioningState&apos; = &apos;Creating&apos; and 201 response code. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutNonRetry201Creating400InvalidJson(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutNonRetry201Creating400InvalidJson");
            scope.Start();
            try
            {
                using var message = CreatePutNonRetry201Creating400InvalidJsonRequest(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePutAsyncRelativeRetry400Request(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/nonretryerror/putasync/retry/400", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running put request, service returns a 200 with ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutAsyncRelativeRetry400Async(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutAsyncRelativeRetry400");
            scope.Start();
            try
            {
                using var message = CreatePutAsyncRelativeRetry400Request(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running put request, service returns a 200 with ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutAsyncRelativeRetry400(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutAsyncRelativeRetry400");
            scope.Start();
            try
            {
                using var message = CreatePutAsyncRelativeRetry400Request(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDeleteNonRetry400Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/nonretryerror/delete/400", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Long running delete request, service returns a 400 with an error body. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteNonRetry400Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.DeleteNonRetry400");
            scope.Start();
            try
            {
                using var message = CreateDeleteNonRetry400Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running delete request, service returns a 400 with an error body. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response DeleteNonRetry400(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.DeleteNonRetry400");
            scope.Start();
            try
            {
                using var message = CreateDeleteNonRetry400Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDelete202NonRetry400Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/nonretryerror/delete/202/retry/400", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Long running delete request, service returns a 202 with a location header. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Delete202NonRetry400Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Delete202NonRetry400");
            scope.Start();
            try
            {
                using var message = CreateDelete202NonRetry400Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running delete request, service returns a 202 with a location header. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete202NonRetry400(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Delete202NonRetry400");
            scope.Start();
            try
            {
                using var message = CreateDelete202NonRetry400Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDeleteAsyncRelativeRetry400Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/nonretryerror/deleteasync/retry/400", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsyncRelativeRetry400Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.DeleteAsyncRelativeRetry400");
            scope.Start();
            try
            {
                using var message = CreateDeleteAsyncRelativeRetry400Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response DeleteAsyncRelativeRetry400(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.DeleteAsyncRelativeRetry400");
            scope.Start();
            try
            {
                using var message = CreateDeleteAsyncRelativeRetry400Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePostNonRetry400Request(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/nonretryerror/post/400", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running post request, service returns a 400 with no error body. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostNonRetry400Async(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PostNonRetry400");
            scope.Start();
            try
            {
                using var message = CreatePostNonRetry400Request(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running post request, service returns a 400 with no error body. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostNonRetry400(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PostNonRetry400");
            scope.Start();
            try
            {
                using var message = CreatePostNonRetry400Request(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePost202NonRetry400Request(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/nonretryerror/post/202/retry/400", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running post request, service returns a 202 with a location header. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Post202NonRetry400Async(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Post202NonRetry400");
            scope.Start();
            try
            {
                using var message = CreatePost202NonRetry400Request(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running post request, service returns a 202 with a location header. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Post202NonRetry400(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Post202NonRetry400");
            scope.Start();
            try
            {
                using var message = CreatePost202NonRetry400Request(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePostAsyncRelativeRetry400Request(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/nonretryerror/postasync/retry/400", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running post request, service returns a 202 to the initial request Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostAsyncRelativeRetry400Async(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PostAsyncRelativeRetry400");
            scope.Start();
            try
            {
                using var message = CreatePostAsyncRelativeRetry400Request(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running post request, service returns a 202 to the initial request Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostAsyncRelativeRetry400(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PostAsyncRelativeRetry400");
            scope.Start();
            try
            {
                using var message = CreatePostAsyncRelativeRetry400Request(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePutError201NoProvisioningStatePayloadRequest(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/put/201/noprovisioningstatepayload", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running put request, service returns a 201 to the initial request with no payload. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutError201NoProvisioningStatePayloadAsync(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutError201NoProvisioningStatePayload");
            scope.Start();
            try
            {
                using var message = CreatePutError201NoProvisioningStatePayloadRequest(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running put request, service returns a 201 to the initial request with no payload. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutError201NoProvisioningStatePayload(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutError201NoProvisioningStatePayload");
            scope.Start();
            try
            {
                using var message = CreatePutError201NoProvisioningStatePayloadRequest(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePutAsyncRelativeRetryNoStatusRequest(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/putasync/retry/nostatus", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutAsyncRelativeRetryNoStatusAsync(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutAsyncRelativeRetryNoStatus");
            scope.Start();
            try
            {
                using var message = CreatePutAsyncRelativeRetryNoStatusRequest(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutAsyncRelativeRetryNoStatus(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutAsyncRelativeRetryNoStatus");
            scope.Start();
            try
            {
                using var message = CreatePutAsyncRelativeRetryNoStatusRequest(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePutAsyncRelativeRetryNoStatusPayloadRequest(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/putasync/retry/nostatuspayload", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutAsyncRelativeRetryNoStatusPayloadAsync(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutAsyncRelativeRetryNoStatusPayload");
            scope.Start();
            try
            {
                using var message = CreatePutAsyncRelativeRetryNoStatusPayloadRequest(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutAsyncRelativeRetryNoStatusPayload(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutAsyncRelativeRetryNoStatusPayload");
            scope.Start();
            try
            {
                using var message = CreatePutAsyncRelativeRetryNoStatusPayloadRequest(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDelete204SucceededRequest()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/delete/204/nolocation", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Long running delete request, service returns a 204 to the initial request, indicating success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Delete204SucceededAsync(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Delete204Succeeded");
            scope.Start();
            try
            {
                using var message = CreateDelete204SucceededRequest();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running delete request, service returns a 204 to the initial request, indicating success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete204Succeeded(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Delete204Succeeded");
            scope.Start();
            try
            {
                using var message = CreateDelete204SucceededRequest();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDeleteAsyncRelativeRetryNoStatusRequest()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/deleteasync/retry/nostatus", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsyncRelativeRetryNoStatusAsync(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.DeleteAsyncRelativeRetryNoStatus");
            scope.Start();
            try
            {
                using var message = CreateDeleteAsyncRelativeRetryNoStatusRequest();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response DeleteAsyncRelativeRetryNoStatus(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.DeleteAsyncRelativeRetryNoStatus");
            scope.Start();
            try
            {
                using var message = CreateDeleteAsyncRelativeRetryNoStatusRequest();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePost202NoLocationRequest(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/post/202/nolocation", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, without a location header. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Post202NoLocationAsync(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Post202NoLocation");
            scope.Start();
            try
            {
                using var message = CreatePost202NoLocationRequest(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, without a location header. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Post202NoLocation(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Post202NoLocation");
            scope.Start();
            try
            {
                using var message = CreatePost202NoLocationRequest(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePostAsyncRelativeRetryNoPayloadRequest(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/postasync/retry/nopayload", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostAsyncRelativeRetryNoPayloadAsync(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PostAsyncRelativeRetryNoPayload");
            scope.Start();
            try
            {
                using var message = CreatePostAsyncRelativeRetryNoPayloadRequest(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostAsyncRelativeRetryNoPayload(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PostAsyncRelativeRetryNoPayload");
            scope.Start();
            try
            {
                using var message = CreatePostAsyncRelativeRetryNoPayloadRequest(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePut200InvalidJsonRequest(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/put/200/invalidjson", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that is not a valid json. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Put200InvalidJsonAsync(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Put200InvalidJson");
            scope.Start();
            try
            {
                using var message = CreatePut200InvalidJsonRequest(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that is not a valid json. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Put200InvalidJson(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Put200InvalidJson");
            scope.Start();
            try
            {
                using var message = CreatePut200InvalidJsonRequest(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePutAsyncRelativeRetryInvalidHeaderRequest(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/putasync/retry/invalidheader", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutAsyncRelativeRetryInvalidHeaderAsync(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutAsyncRelativeRetryInvalidHeader");
            scope.Start();
            try
            {
                using var message = CreatePutAsyncRelativeRetryInvalidHeaderRequest(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutAsyncRelativeRetryInvalidHeader(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutAsyncRelativeRetryInvalidHeader");
            scope.Start();
            try
            {
                using var message = CreatePutAsyncRelativeRetryInvalidHeaderRequest(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePutAsyncRelativeRetryInvalidJsonPollingRequest(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/putasync/retry/invalidjsonpolling", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutAsyncRelativeRetryInvalidJsonPollingAsync(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutAsyncRelativeRetryInvalidJsonPolling");
            scope.Start();
            try
            {
                using var message = CreatePutAsyncRelativeRetryInvalidJsonPollingRequest(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutAsyncRelativeRetryInvalidJsonPolling(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PutAsyncRelativeRetryInvalidJsonPolling");
            scope.Start();
            try
            {
                using var message = CreatePutAsyncRelativeRetryInvalidJsonPollingRequest(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDelete202RetryInvalidHeaderRequest()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/delete/202/retry/invalidheader", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request receing a reponse with an invalid &apos;Location&apos; and &apos;Retry-After&apos; headers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Delete202RetryInvalidHeaderAsync(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Delete202RetryInvalidHeader");
            scope.Start();
            try
            {
                using var message = CreateDelete202RetryInvalidHeaderRequest();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request receing a reponse with an invalid &apos;Location&apos; and &apos;Retry-After&apos; headers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete202RetryInvalidHeader(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Delete202RetryInvalidHeader");
            scope.Start();
            try
            {
                using var message = CreateDelete202RetryInvalidHeaderRequest();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDeleteAsyncRelativeRetryInvalidHeaderRequest()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/deleteasync/retry/invalidheader", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsyncRelativeRetryInvalidHeaderAsync(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.DeleteAsyncRelativeRetryInvalidHeader");
            scope.Start();
            try
            {
                using var message = CreateDeleteAsyncRelativeRetryInvalidHeaderRequest();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response DeleteAsyncRelativeRetryInvalidHeader(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.DeleteAsyncRelativeRetryInvalidHeader");
            scope.Start();
            try
            {
                using var message = CreateDeleteAsyncRelativeRetryInvalidHeaderRequest();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDeleteAsyncRelativeRetryInvalidJsonPollingRequest()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/deleteasync/retry/invalidjsonpolling", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsyncRelativeRetryInvalidJsonPollingAsync(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.DeleteAsyncRelativeRetryInvalidJsonPolling");
            scope.Start();
            try
            {
                using var message = CreateDeleteAsyncRelativeRetryInvalidJsonPollingRequest();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response DeleteAsyncRelativeRetryInvalidJsonPolling(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.DeleteAsyncRelativeRetryInvalidJsonPolling");
            scope.Start();
            try
            {
                using var message = CreateDeleteAsyncRelativeRetryInvalidJsonPollingRequest();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePost202RetryInvalidHeaderRequest(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/post/202/retry/invalidheader", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with invalid &apos;Location&apos; and &apos;Retry-After&apos; headers. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Post202RetryInvalidHeaderAsync(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Post202RetryInvalidHeader");
            scope.Start();
            try
            {
                using var message = CreatePost202RetryInvalidHeaderRequest(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with invalid &apos;Location&apos; and &apos;Retry-After&apos; headers. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Post202RetryInvalidHeader(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.Post202RetryInvalidHeader");
            scope.Start();
            try
            {
                using var message = CreatePost202RetryInvalidHeaderRequest(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePostAsyncRelativeRetryInvalidHeaderRequest(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/postasync/retry/invalidheader", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostAsyncRelativeRetryInvalidHeaderAsync(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PostAsyncRelativeRetryInvalidHeader");
            scope.Start();
            try
            {
                using var message = CreatePostAsyncRelativeRetryInvalidHeaderRequest(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostAsyncRelativeRetryInvalidHeader(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PostAsyncRelativeRetryInvalidHeader");
            scope.Start();
            try
            {
                using var message = CreatePostAsyncRelativeRetryInvalidHeaderRequest(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePostAsyncRelativeRetryInvalidJsonPollingRequest(Product product)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/lro/error/postasync/retry/invalidjsonpolling", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(product);
            request.Content = content;
            return message;
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PostAsyncRelativeRetryInvalidJsonPollingAsync(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PostAsyncRelativeRetryInvalidJsonPolling");
            scope.Start();
            try
            {
                using var message = CreatePostAsyncRelativeRetryInvalidJsonPollingRequest(product);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PostAsyncRelativeRetryInvalidJsonPolling(Product product, CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("LROSADsOperations.PostAsyncRelativeRetryInvalidJsonPolling");
            scope.Start();
            try
            {
                using var message = CreatePostAsyncRelativeRetryInvalidJsonPollingRequest(product);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Long running put request, service returns a 400 to the initial request. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Product> CreatePutNonRetry400Operation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, true, "LROSADsOperations.PutNonRetry400", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                using var document = JsonDocument.Parse(r.ContentStream);
                var value = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value, r);
            },
            async (r, c) =>
            {
                using var document = await JsonDocument.ParseAsync(r.ContentStream, default, c).ConfigureAwait(false);
                var value0 = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value0, r);
            });
        }
        /// <summary> Long running put request, service returns a 400 to the initial request. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Product>> StartPutNonRetry400OperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PutNonRetry400Async(product, cancellationToken).ConfigureAwait(false);
            return CreatePutNonRetry400Operation(originalResponse, () => CreatePutNonRetry400Request(product));
        }
        /// <summary> Long running put request, service returns a 400 to the initial request. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Product> StartPutNonRetry400Operation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PutNonRetry400(product, cancellationToken);
            return CreatePutNonRetry400Operation(originalResponse, () => CreatePutNonRetry400Request(product));
        }
        /// <summary> Long running put request, service returns a Product with &apos;ProvisioningState&apos; = &apos;Creating&apos; and 201 response code. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Product> CreatePutNonRetry201Creating400Operation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, true, "LROSADsOperations.PutNonRetry201Creating400", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                using var document = JsonDocument.Parse(r.ContentStream);
                var value = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value, r);
            },
            async (r, c) =>
            {
                using var document = await JsonDocument.ParseAsync(r.ContentStream, default, c).ConfigureAwait(false);
                var value0 = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value0, r);
            });
        }
        /// <summary> Long running put request, service returns a Product with &apos;ProvisioningState&apos; = &apos;Creating&apos; and 201 response code. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Product>> StartPutNonRetry201Creating400OperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PutNonRetry201Creating400Async(product, cancellationToken).ConfigureAwait(false);
            return CreatePutNonRetry201Creating400Operation(originalResponse, () => CreatePutNonRetry201Creating400Request(product));
        }
        /// <summary> Long running put request, service returns a Product with &apos;ProvisioningState&apos; = &apos;Creating&apos; and 201 response code. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Product> StartPutNonRetry201Creating400Operation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PutNonRetry201Creating400(product, cancellationToken);
            return CreatePutNonRetry201Creating400Operation(originalResponse, () => CreatePutNonRetry201Creating400Request(product));
        }
        /// <summary> Long running put request, service returns a Product with &apos;ProvisioningState&apos; = &apos;Creating&apos; and 201 response code. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Product> CreatePutNonRetry201Creating400InvalidJsonOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, true, "LROSADsOperations.PutNonRetry201Creating400InvalidJson", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                using var document = JsonDocument.Parse(r.ContentStream);
                var value = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value, r);
            },
            async (r, c) =>
            {
                using var document = await JsonDocument.ParseAsync(r.ContentStream, default, c).ConfigureAwait(false);
                var value0 = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value0, r);
            });
        }
        /// <summary> Long running put request, service returns a Product with &apos;ProvisioningState&apos; = &apos;Creating&apos; and 201 response code. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Product>> StartPutNonRetry201Creating400InvalidJsonOperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PutNonRetry201Creating400InvalidJsonAsync(product, cancellationToken).ConfigureAwait(false);
            return CreatePutNonRetry201Creating400InvalidJsonOperation(originalResponse, () => CreatePutNonRetry201Creating400InvalidJsonRequest(product));
        }
        /// <summary> Long running put request, service returns a Product with &apos;ProvisioningState&apos; = &apos;Creating&apos; and 201 response code. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Product> StartPutNonRetry201Creating400InvalidJsonOperation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PutNonRetry201Creating400InvalidJson(product, cancellationToken);
            return CreatePutNonRetry201Creating400InvalidJsonOperation(originalResponse, () => CreatePutNonRetry201Creating400InvalidJsonRequest(product));
        }
        /// <summary> Long running put request, service returns a 200 with ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Product> CreatePutAsyncRelativeRetry400Operation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, true, "LROSADsOperations.PutAsyncRelativeRetry400", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                using var document = JsonDocument.Parse(r.ContentStream);
                var value = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value, r);
            },
            async (r, c) =>
            {
                using var document = await JsonDocument.ParseAsync(r.ContentStream, default, c).ConfigureAwait(false);
                var value0 = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value0, r);
            });
        }
        /// <summary> Long running put request, service returns a 200 with ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Product>> StartPutAsyncRelativeRetry400OperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PutAsyncRelativeRetry400Async(product, cancellationToken).ConfigureAwait(false);
            return CreatePutAsyncRelativeRetry400Operation(originalResponse, () => CreatePutAsyncRelativeRetry400Request(product));
        }
        /// <summary> Long running put request, service returns a 200 with ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Product> StartPutAsyncRelativeRetry400Operation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PutAsyncRelativeRetry400(product, cancellationToken);
            return CreatePutAsyncRelativeRetry400Operation(originalResponse, () => CreatePutAsyncRelativeRetry400Request(product));
        }
        /// <summary> Long running delete request, service returns a 400 with an error body. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreateDeleteNonRetry400Operation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.DeleteNonRetry400", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running delete request, service returns a 400 with an error body. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartDeleteNonRetry400OperationAsync(CancellationToken cancellationToken = default)
        {
            var originalResponse = await DeleteNonRetry400Async(cancellationToken).ConfigureAwait(false);
            return CreateDeleteNonRetry400Operation(originalResponse, () => CreateDeleteNonRetry400Request());
        }
        /// <summary> Long running delete request, service returns a 400 with an error body. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartDeleteNonRetry400Operation(CancellationToken cancellationToken = default)
        {
            var originalResponse = DeleteNonRetry400(cancellationToken);
            return CreateDeleteNonRetry400Operation(originalResponse, () => CreateDeleteNonRetry400Request());
        }
        /// <summary> Long running delete request, service returns a 202 with a location header. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreateDelete202NonRetry400Operation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.Delete202NonRetry400", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running delete request, service returns a 202 with a location header. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartDelete202NonRetry400OperationAsync(CancellationToken cancellationToken = default)
        {
            var originalResponse = await Delete202NonRetry400Async(cancellationToken).ConfigureAwait(false);
            return CreateDelete202NonRetry400Operation(originalResponse, () => CreateDelete202NonRetry400Request());
        }
        /// <summary> Long running delete request, service returns a 202 with a location header. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartDelete202NonRetry400Operation(CancellationToken cancellationToken = default)
        {
            var originalResponse = Delete202NonRetry400(cancellationToken);
            return CreateDelete202NonRetry400Operation(originalResponse, () => CreateDelete202NonRetry400Request());
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreateDeleteAsyncRelativeRetry400Operation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.DeleteAsyncRelativeRetry400", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartDeleteAsyncRelativeRetry400OperationAsync(CancellationToken cancellationToken = default)
        {
            var originalResponse = await DeleteAsyncRelativeRetry400Async(cancellationToken).ConfigureAwait(false);
            return CreateDeleteAsyncRelativeRetry400Operation(originalResponse, () => CreateDeleteAsyncRelativeRetry400Request());
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartDeleteAsyncRelativeRetry400Operation(CancellationToken cancellationToken = default)
        {
            var originalResponse = DeleteAsyncRelativeRetry400(cancellationToken);
            return CreateDeleteAsyncRelativeRetry400Operation(originalResponse, () => CreateDeleteAsyncRelativeRetry400Request());
        }
        /// <summary> Long running post request, service returns a 400 with no error body. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreatePostNonRetry400Operation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.PostNonRetry400", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running post request, service returns a 400 with no error body. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartPostNonRetry400OperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PostNonRetry400Async(product, cancellationToken).ConfigureAwait(false);
            return CreatePostNonRetry400Operation(originalResponse, () => CreatePostNonRetry400Request(product));
        }
        /// <summary> Long running post request, service returns a 400 with no error body. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartPostNonRetry400Operation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PostNonRetry400(product, cancellationToken);
            return CreatePostNonRetry400Operation(originalResponse, () => CreatePostNonRetry400Request(product));
        }
        /// <summary> Long running post request, service returns a 202 with a location header. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreatePost202NonRetry400Operation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.Post202NonRetry400", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running post request, service returns a 202 with a location header. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartPost202NonRetry400OperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await Post202NonRetry400Async(product, cancellationToken).ConfigureAwait(false);
            return CreatePost202NonRetry400Operation(originalResponse, () => CreatePost202NonRetry400Request(product));
        }
        /// <summary> Long running post request, service returns a 202 with a location header. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartPost202NonRetry400Operation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = Post202NonRetry400(product, cancellationToken);
            return CreatePost202NonRetry400Operation(originalResponse, () => CreatePost202NonRetry400Request(product));
        }
        /// <summary> Long running post request, service returns a 202 to the initial request Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreatePostAsyncRelativeRetry400Operation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.PostAsyncRelativeRetry400", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running post request, service returns a 202 to the initial request Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartPostAsyncRelativeRetry400OperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PostAsyncRelativeRetry400Async(product, cancellationToken).ConfigureAwait(false);
            return CreatePostAsyncRelativeRetry400Operation(originalResponse, () => CreatePostAsyncRelativeRetry400Request(product));
        }
        /// <summary> Long running post request, service returns a 202 to the initial request Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartPostAsyncRelativeRetry400Operation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PostAsyncRelativeRetry400(product, cancellationToken);
            return CreatePostAsyncRelativeRetry400Operation(originalResponse, () => CreatePostAsyncRelativeRetry400Request(product));
        }
        /// <summary> Long running put request, service returns a 201 to the initial request with no payload. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Product> CreatePutError201NoProvisioningStatePayloadOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, true, "LROSADsOperations.PutError201NoProvisioningStatePayload", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                using var document = JsonDocument.Parse(r.ContentStream);
                var value = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value, r);
            },
            async (r, c) =>
            {
                using var document = await JsonDocument.ParseAsync(r.ContentStream, default, c).ConfigureAwait(false);
                var value0 = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value0, r);
            });
        }
        /// <summary> Long running put request, service returns a 201 to the initial request with no payload. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Product>> StartPutError201NoProvisioningStatePayloadOperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PutError201NoProvisioningStatePayloadAsync(product, cancellationToken).ConfigureAwait(false);
            return CreatePutError201NoProvisioningStatePayloadOperation(originalResponse, () => CreatePutError201NoProvisioningStatePayloadRequest(product));
        }
        /// <summary> Long running put request, service returns a 201 to the initial request with no payload. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Product> StartPutError201NoProvisioningStatePayloadOperation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PutError201NoProvisioningStatePayload(product, cancellationToken);
            return CreatePutError201NoProvisioningStatePayloadOperation(originalResponse, () => CreatePutError201NoProvisioningStatePayloadRequest(product));
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Product> CreatePutAsyncRelativeRetryNoStatusOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, true, "LROSADsOperations.PutAsyncRelativeRetryNoStatus", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                using var document = JsonDocument.Parse(r.ContentStream);
                var value = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value, r);
            },
            async (r, c) =>
            {
                using var document = await JsonDocument.ParseAsync(r.ContentStream, default, c).ConfigureAwait(false);
                var value0 = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value0, r);
            });
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Product>> StartPutAsyncRelativeRetryNoStatusOperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PutAsyncRelativeRetryNoStatusAsync(product, cancellationToken).ConfigureAwait(false);
            return CreatePutAsyncRelativeRetryNoStatusOperation(originalResponse, () => CreatePutAsyncRelativeRetryNoStatusRequest(product));
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Product> StartPutAsyncRelativeRetryNoStatusOperation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PutAsyncRelativeRetryNoStatus(product, cancellationToken);
            return CreatePutAsyncRelativeRetryNoStatusOperation(originalResponse, () => CreatePutAsyncRelativeRetryNoStatusRequest(product));
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Product> CreatePutAsyncRelativeRetryNoStatusPayloadOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, true, "LROSADsOperations.PutAsyncRelativeRetryNoStatusPayload", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                using var document = JsonDocument.Parse(r.ContentStream);
                var value = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value, r);
            },
            async (r, c) =>
            {
                using var document = await JsonDocument.ParseAsync(r.ContentStream, default, c).ConfigureAwait(false);
                var value0 = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value0, r);
            });
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Product>> StartPutAsyncRelativeRetryNoStatusPayloadOperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PutAsyncRelativeRetryNoStatusPayloadAsync(product, cancellationToken).ConfigureAwait(false);
            return CreatePutAsyncRelativeRetryNoStatusPayloadOperation(originalResponse, () => CreatePutAsyncRelativeRetryNoStatusPayloadRequest(product));
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Product> StartPutAsyncRelativeRetryNoStatusPayloadOperation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PutAsyncRelativeRetryNoStatusPayload(product, cancellationToken);
            return CreatePutAsyncRelativeRetryNoStatusPayloadOperation(originalResponse, () => CreatePutAsyncRelativeRetryNoStatusPayloadRequest(product));
        }
        /// <summary> Long running delete request, service returns a 204 to the initial request, indicating success. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreateDelete204SucceededOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.Delete204Succeeded", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running delete request, service returns a 204 to the initial request, indicating success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartDelete204SucceededOperationAsync(CancellationToken cancellationToken = default)
        {
            var originalResponse = await Delete204SucceededAsync(cancellationToken).ConfigureAwait(false);
            return CreateDelete204SucceededOperation(originalResponse, () => CreateDelete204SucceededRequest());
        }
        /// <summary> Long running delete request, service returns a 204 to the initial request, indicating success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartDelete204SucceededOperation(CancellationToken cancellationToken = default)
        {
            var originalResponse = Delete204Succeeded(cancellationToken);
            return CreateDelete204SucceededOperation(originalResponse, () => CreateDelete204SucceededRequest());
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreateDeleteAsyncRelativeRetryNoStatusOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.DeleteAsyncRelativeRetryNoStatus", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartDeleteAsyncRelativeRetryNoStatusOperationAsync(CancellationToken cancellationToken = default)
        {
            var originalResponse = await DeleteAsyncRelativeRetryNoStatusAsync(cancellationToken).ConfigureAwait(false);
            return CreateDeleteAsyncRelativeRetryNoStatusOperation(originalResponse, () => CreateDeleteAsyncRelativeRetryNoStatusRequest());
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartDeleteAsyncRelativeRetryNoStatusOperation(CancellationToken cancellationToken = default)
        {
            var originalResponse = DeleteAsyncRelativeRetryNoStatus(cancellationToken);
            return CreateDeleteAsyncRelativeRetryNoStatusOperation(originalResponse, () => CreateDeleteAsyncRelativeRetryNoStatusRequest());
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, without a location header. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreatePost202NoLocationOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.Post202NoLocation", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, without a location header. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartPost202NoLocationOperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await Post202NoLocationAsync(product, cancellationToken).ConfigureAwait(false);
            return CreatePost202NoLocationOperation(originalResponse, () => CreatePost202NoLocationRequest(product));
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, without a location header. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartPost202NoLocationOperation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = Post202NoLocation(product, cancellationToken);
            return CreatePost202NoLocationOperation(originalResponse, () => CreatePost202NoLocationRequest(product));
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreatePostAsyncRelativeRetryNoPayloadOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.PostAsyncRelativeRetryNoPayload", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartPostAsyncRelativeRetryNoPayloadOperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PostAsyncRelativeRetryNoPayloadAsync(product, cancellationToken).ConfigureAwait(false);
            return CreatePostAsyncRelativeRetryNoPayloadOperation(originalResponse, () => CreatePostAsyncRelativeRetryNoPayloadRequest(product));
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartPostAsyncRelativeRetryNoPayloadOperation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PostAsyncRelativeRetryNoPayload(product, cancellationToken);
            return CreatePostAsyncRelativeRetryNoPayloadOperation(originalResponse, () => CreatePostAsyncRelativeRetryNoPayloadRequest(product));
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that is not a valid json. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Product> CreatePut200InvalidJsonOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, true, "LROSADsOperations.Put200InvalidJson", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                using var document = JsonDocument.Parse(r.ContentStream);
                var value = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value, r);
            },
            async (r, c) =>
            {
                using var document = await JsonDocument.ParseAsync(r.ContentStream, default, c).ConfigureAwait(false);
                var value0 = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value0, r);
            });
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that is not a valid json. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Product>> StartPut200InvalidJsonOperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await Put200InvalidJsonAsync(product, cancellationToken).ConfigureAwait(false);
            return CreatePut200InvalidJsonOperation(originalResponse, () => CreatePut200InvalidJsonRequest(product));
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that is not a valid json. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Product> StartPut200InvalidJsonOperation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = Put200InvalidJson(product, cancellationToken);
            return CreatePut200InvalidJsonOperation(originalResponse, () => CreatePut200InvalidJsonRequest(product));
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Product> CreatePutAsyncRelativeRetryInvalidHeaderOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, true, "LROSADsOperations.PutAsyncRelativeRetryInvalidHeader", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                using var document = JsonDocument.Parse(r.ContentStream);
                var value = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value, r);
            },
            async (r, c) =>
            {
                using var document = await JsonDocument.ParseAsync(r.ContentStream, default, c).ConfigureAwait(false);
                var value0 = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value0, r);
            });
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Product>> StartPutAsyncRelativeRetryInvalidHeaderOperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PutAsyncRelativeRetryInvalidHeaderAsync(product, cancellationToken).ConfigureAwait(false);
            return CreatePutAsyncRelativeRetryInvalidHeaderOperation(originalResponse, () => CreatePutAsyncRelativeRetryInvalidHeaderRequest(product));
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Product> StartPutAsyncRelativeRetryInvalidHeaderOperation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PutAsyncRelativeRetryInvalidHeader(product, cancellationToken);
            return CreatePutAsyncRelativeRetryInvalidHeaderOperation(originalResponse, () => CreatePutAsyncRelativeRetryInvalidHeaderRequest(product));
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Product> CreatePutAsyncRelativeRetryInvalidJsonPollingOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, true, "LROSADsOperations.PutAsyncRelativeRetryInvalidJsonPolling", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                using var document = JsonDocument.Parse(r.ContentStream);
                var value = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value, r);
            },
            async (r, c) =>
            {
                using var document = await JsonDocument.ParseAsync(r.ContentStream, default, c).ConfigureAwait(false);
                var value0 = Product.DeserializeProduct(document.RootElement);
                return Response.FromValue(value0, r);
            });
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Product>> StartPutAsyncRelativeRetryInvalidJsonPollingOperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PutAsyncRelativeRetryInvalidJsonPollingAsync(product, cancellationToken).ConfigureAwait(false);
            return CreatePutAsyncRelativeRetryInvalidJsonPollingOperation(originalResponse, () => CreatePutAsyncRelativeRetryInvalidJsonPollingRequest(product));
        }
        /// <summary> Long running put request, service returns a 200 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Product> StartPutAsyncRelativeRetryInvalidJsonPollingOperation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PutAsyncRelativeRetryInvalidJsonPolling(product, cancellationToken);
            return CreatePutAsyncRelativeRetryInvalidJsonPollingOperation(originalResponse, () => CreatePutAsyncRelativeRetryInvalidJsonPollingRequest(product));
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request receing a reponse with an invalid &apos;Location&apos; and &apos;Retry-After&apos; headers. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreateDelete202RetryInvalidHeaderOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.Delete202RetryInvalidHeader", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request receing a reponse with an invalid &apos;Location&apos; and &apos;Retry-After&apos; headers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartDelete202RetryInvalidHeaderOperationAsync(CancellationToken cancellationToken = default)
        {
            var originalResponse = await Delete202RetryInvalidHeaderAsync(cancellationToken).ConfigureAwait(false);
            return CreateDelete202RetryInvalidHeaderOperation(originalResponse, () => CreateDelete202RetryInvalidHeaderRequest());
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request receing a reponse with an invalid &apos;Location&apos; and &apos;Retry-After&apos; headers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartDelete202RetryInvalidHeaderOperation(CancellationToken cancellationToken = default)
        {
            var originalResponse = Delete202RetryInvalidHeader(cancellationToken);
            return CreateDelete202RetryInvalidHeaderOperation(originalResponse, () => CreateDelete202RetryInvalidHeaderRequest());
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreateDeleteAsyncRelativeRetryInvalidHeaderOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.DeleteAsyncRelativeRetryInvalidHeader", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartDeleteAsyncRelativeRetryInvalidHeaderOperationAsync(CancellationToken cancellationToken = default)
        {
            var originalResponse = await DeleteAsyncRelativeRetryInvalidHeaderAsync(cancellationToken).ConfigureAwait(false);
            return CreateDeleteAsyncRelativeRetryInvalidHeaderOperation(originalResponse, () => CreateDeleteAsyncRelativeRetryInvalidHeaderRequest());
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartDeleteAsyncRelativeRetryInvalidHeaderOperation(CancellationToken cancellationToken = default)
        {
            var originalResponse = DeleteAsyncRelativeRetryInvalidHeader(cancellationToken);
            return CreateDeleteAsyncRelativeRetryInvalidHeaderOperation(originalResponse, () => CreateDeleteAsyncRelativeRetryInvalidHeaderRequest());
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreateDeleteAsyncRelativeRetryInvalidJsonPollingOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.DeleteAsyncRelativeRetryInvalidJsonPolling", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartDeleteAsyncRelativeRetryInvalidJsonPollingOperationAsync(CancellationToken cancellationToken = default)
        {
            var originalResponse = await DeleteAsyncRelativeRetryInvalidJsonPollingAsync(cancellationToken).ConfigureAwait(false);
            return CreateDeleteAsyncRelativeRetryInvalidJsonPollingOperation(originalResponse, () => CreateDeleteAsyncRelativeRetryInvalidJsonPollingRequest());
        }
        /// <summary> Long running delete request, service returns a 202 to the initial request. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartDeleteAsyncRelativeRetryInvalidJsonPollingOperation(CancellationToken cancellationToken = default)
        {
            var originalResponse = DeleteAsyncRelativeRetryInvalidJsonPolling(cancellationToken);
            return CreateDeleteAsyncRelativeRetryInvalidJsonPollingOperation(originalResponse, () => CreateDeleteAsyncRelativeRetryInvalidJsonPollingRequest());
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with invalid &apos;Location&apos; and &apos;Retry-After&apos; headers. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreatePost202RetryInvalidHeaderOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.Post202RetryInvalidHeader", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with invalid &apos;Location&apos; and &apos;Retry-After&apos; headers. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartPost202RetryInvalidHeaderOperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await Post202RetryInvalidHeaderAsync(product, cancellationToken).ConfigureAwait(false);
            return CreatePost202RetryInvalidHeaderOperation(originalResponse, () => CreatePost202RetryInvalidHeaderRequest(product));
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with invalid &apos;Location&apos; and &apos;Retry-After&apos; headers. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartPost202RetryInvalidHeaderOperation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = Post202RetryInvalidHeader(product, cancellationToken);
            return CreatePost202RetryInvalidHeaderOperation(originalResponse, () => CreatePost202RetryInvalidHeaderRequest(product));
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreatePostAsyncRelativeRetryInvalidHeaderOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.PostAsyncRelativeRetryInvalidHeader", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartPostAsyncRelativeRetryInvalidHeaderOperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PostAsyncRelativeRetryInvalidHeaderAsync(product, cancellationToken).ConfigureAwait(false);
            return CreatePostAsyncRelativeRetryInvalidHeaderOperation(originalResponse, () => CreatePostAsyncRelativeRetryInvalidHeaderRequest(product));
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. The endpoint indicated in the Azure-AsyncOperation header is invalid. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartPostAsyncRelativeRetryInvalidHeaderOperation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PostAsyncRelativeRetryInvalidHeader(product, cancellationToken);
            return CreatePostAsyncRelativeRetryInvalidHeaderOperation(originalResponse, () => CreatePostAsyncRelativeRetryInvalidHeaderRequest(product));
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        public Operation<Response> CreatePostAsyncRelativeRetryInvalidJsonPollingOperation(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, false, "LROSADsOperations.PostAsyncRelativeRetryInvalidJsonPolling", FinalStateVia.Location, createOriginalHttpMessage,
            (r, c) =>
            {
                return Response.FromValue(r, r);
            },
            async (r, c) =>
            {
                await Task.CompletedTask;
                return Response.FromValue(r, r);
            });
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Operation<Response>> StartPostAsyncRelativeRetryInvalidJsonPollingOperationAsync(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = await PostAsyncRelativeRetryInvalidJsonPollingAsync(product, cancellationToken).ConfigureAwait(false);
            return CreatePostAsyncRelativeRetryInvalidJsonPollingOperation(originalResponse, () => CreatePostAsyncRelativeRetryInvalidJsonPollingRequest(product));
        }
        /// <summary> Long running post request, service returns a 202 to the initial request, with an entity that contains ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status. </summary>
        /// <param name="product"> Product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation<Response> StartPostAsyncRelativeRetryInvalidJsonPollingOperation(Product product, CancellationToken cancellationToken = default)
        {
            var originalResponse = PostAsyncRelativeRetryInvalidJsonPolling(product, cancellationToken);
            return CreatePostAsyncRelativeRetryInvalidJsonPollingOperation(originalResponse, () => CreatePostAsyncRelativeRetryInvalidJsonPollingRequest(product));
        }
    }
}
