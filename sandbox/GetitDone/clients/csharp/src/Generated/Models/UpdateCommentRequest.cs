// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Getitdone.Models
{
    /// <summary> The UpdateCommentRequest. </summary>
    public partial class UpdateCommentRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        /// <summary> Initializes a new instance of <see cref="UpdateCommentRequest"/>. </summary>
        public UpdateCommentRequest()
        {
        }

        internal UpdateCommentRequest(string content, Attachment attachment, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Content = content;
            Attachment = attachment;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> Gets or sets the Content. </summary>
        public string Content { get; set; }

        /// <summary> Gets or sets the Attachment. </summary>
        public Attachment Attachment { get; set; }
    }
}
