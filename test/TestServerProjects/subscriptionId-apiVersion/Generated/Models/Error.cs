// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace subscriptionId_apiVersion.Models
{
    /// <summary> The Error. </summary>
    public partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        internal Error()
        {
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> . </param>
        /// <param name="message"> . </param>
        internal Error(int? code, string message)
        {
            Code = code;
            Message = message;
        }

        public int? Code { get; }
        public string Message { get; }
    }
}
