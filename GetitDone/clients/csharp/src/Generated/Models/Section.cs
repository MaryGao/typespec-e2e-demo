// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Getitdone.Models
{
    /// <summary> The Section. </summary>
    public partial class Section
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal Section(string id, string projectId, int order, string name)
        {
            Id = id;
            ProjectId = projectId;
            Order = order;
            Name = name;
        }

        internal Section(string id, string projectId, int order, string name, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            ProjectId = projectId;
            Order = order;
            Name = name;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> Gets the Id. </summary>
        public string Id { get; }

        /// <summary> Gets the ProjectId. </summary>
        public string ProjectId { get; }

        /// <summary> Gets the Order. </summary>
        public int Order { get; }

        /// <summary> Gets the Name. </summary>
        public string Name { get; }
    }
}