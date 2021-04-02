// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The TagOrderBy. </summary>
    public readonly partial struct TagOrderBy : IEquatable<TagOrderBy>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TagOrderBy"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TagOrderBy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LastUpdatedOnDescendingValue = "timedesc";
        private const string LastUpdatedOnAscendingValue = "timeasc";

        /// <summary> Order tags by LastUpdatedOn field, from most recently updated to least recently updated. </summary>
        public static TagOrderBy LastUpdatedOnDescending { get; } = new TagOrderBy(LastUpdatedOnDescendingValue);
        /// <summary> Order tags by LastUpdatedOn field, from least recently updated to most recently updated. </summary>
        public static TagOrderBy LastUpdatedOnAscending { get; } = new TagOrderBy(LastUpdatedOnAscendingValue);
        /// <summary> Determines if two <see cref="TagOrderBy"/> values are the same. </summary>
        public static bool operator ==(TagOrderBy left, TagOrderBy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TagOrderBy"/> values are not the same. </summary>
        public static bool operator !=(TagOrderBy left, TagOrderBy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TagOrderBy"/>. </summary>
        public static implicit operator TagOrderBy(string value) => new TagOrderBy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TagOrderBy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TagOrderBy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
