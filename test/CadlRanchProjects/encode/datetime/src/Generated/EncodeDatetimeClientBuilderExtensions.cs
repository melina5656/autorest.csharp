// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using Encode.Datetime;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="DatetimeClient"/> to client builder. </summary>
    public static partial class EncodeDatetimeClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="DatetimeClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        public static IAzureClientBuilder<DatetimeClient, DatetimeClientOptions> AddDatetimeClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<DatetimeClient, DatetimeClientOptions>((options) => new DatetimeClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="DatetimeClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<DatetimeClient, DatetimeClientOptions> AddDatetimeClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<DatetimeClient, DatetimeClientOptions>(configuration);
        }
    }
}
