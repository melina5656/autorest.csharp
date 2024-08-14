// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace NoDocsTypeSpec.Models
{
    public readonly partial struct AnonymousBodyRequestOptionalLiteralString : IEquatable<AnonymousBodyRequestOptionalLiteralString>
    {
        private readonly string _value;

        public AnonymousBodyRequestOptionalLiteralString(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RejectValue = "reject";

        public static AnonymousBodyRequestOptionalLiteralString Reject { get; } = new AnonymousBodyRequestOptionalLiteralString(RejectValue);
        public static bool operator ==(AnonymousBodyRequestOptionalLiteralString left, AnonymousBodyRequestOptionalLiteralString right) => left.Equals(right);
        public static bool operator !=(AnonymousBodyRequestOptionalLiteralString left, AnonymousBodyRequestOptionalLiteralString right) => !left.Equals(right);
        public static implicit operator AnonymousBodyRequestOptionalLiteralString(string value) => new AnonymousBodyRequestOptionalLiteralString(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnonymousBodyRequestOptionalLiteralString other && Equals(other);
        public bool Equals(AnonymousBodyRequestOptionalLiteralString other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
