// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace CognitiveSearch.Models
{
    /// <summary> Represents a search index definition, which describes the fields and search behavior of an index. </summary>
    public partial class Index
    {
        /// <summary> The name of the index. </summary>
        public string Name { get; set; }
        /// <summary> The fields of the index. </summary>
        public ICollection<Field> Fields { get; set; } = new System.Collections.Generic.List<CognitiveSearch.Models.Field>();
        /// <summary> The scoring profiles for the index. </summary>
        public ICollection<ScoringProfile> ScoringProfiles { get; set; }
        /// <summary> The name of the scoring profile to use if none is specified in the query. If this property is not set and no scoring profile is specified in the query, then default scoring (tf-idf) will be used. </summary>
        public string DefaultScoringProfile { get; set; }
        /// <summary> Options to control Cross-Origin Resource Sharing (CORS) for the index. </summary>
        public CorsOptions CorsOptions { get; set; }
        /// <summary> The suggesters for the index. </summary>
        public ICollection<Suggester> Suggesters { get; set; }
        /// <summary> The analyzers for the index. </summary>
        public ICollection<Analyzer> Analyzers { get; set; }
        /// <summary> The tokenizers for the index. </summary>
        public ICollection<Tokenizer> Tokenizers { get; set; }
        /// <summary> The token filters for the index. </summary>
        public ICollection<TokenFilter> TokenFilters { get; set; }
        /// <summary> The character filters for the index. </summary>
        public ICollection<CharFilter> CharFilters { get; set; }
        /// <summary> The ETag of the index. </summary>
        public string ETag { get; set; }
    }
}
