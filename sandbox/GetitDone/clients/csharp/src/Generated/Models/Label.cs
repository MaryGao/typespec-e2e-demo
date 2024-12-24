// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Getitdone.Models
{
    /// <summary> The Label. </summary>
    public partial class Label
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal Label(string id, string name, string color, int order, bool isFavorite)
        {
            Id = id;
            Name = name;
            Color = color;
            Order = order;
            IsFavorite = isFavorite;
        }

        internal Label(string id, string name, string color, int order, bool isFavorite, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            Name = name;
            Color = color;
            Order = order;
            IsFavorite = isFavorite;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> Gets the Id. </summary>
        public string Id { get; }

        /// <summary> Gets the Name. </summary>
        public string Name { get; }

        /// <summary> Gets the Color. </summary>
        public string Color { get; }

        /// <summary> Gets the Order. </summary>
        public int Order { get; }

        /// <summary> Gets the IsFavorite. </summary>
        public bool IsFavorite { get; }
    }
}
