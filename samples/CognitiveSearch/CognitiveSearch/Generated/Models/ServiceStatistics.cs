// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Response from a get service statistics request. If successful, it includes service level counters and limits. </summary>
    public partial class ServiceStatistics
    {
        /// <summary> Service level resource counters. </summary>
        public ServiceCounters Counters { get; set; }
        /// <summary> Service level general limits. </summary>
        public ServiceLimits Limits { get; set; }
    }
}
