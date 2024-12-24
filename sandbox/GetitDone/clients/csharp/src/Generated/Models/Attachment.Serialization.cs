// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Getitdone;

namespace Getitdone.Models
{
    /// <summary></summary>
    public partial class Attachment : IJsonModel<Attachment>
    {
        internal Attachment()
        {
        }

        void IJsonModel<Attachment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<Attachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Attachment)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("file_name"u8);
            writer.WriteStringValue(FileName);
            writer.WritePropertyName("file_type"u8);
            writer.WriteStringValue(FileType);
            writer.WritePropertyName("file_url"u8);
            writer.WriteStringValue(FileUrl);
            writer.WritePropertyName("resource_type"u8);
            writer.WriteStringValue(ResourceType);
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        Attachment IJsonModel<Attachment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual Attachment JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<Attachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Attachment)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAttachment(document.RootElement, options);
        }

        internal static Attachment DeserializeAttachment(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fileName = default;
            string fileType = default;
            string fileUrl = default;
            string resourceType = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("file_name"u8))
                {
                    fileName = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("file_type"u8))
                {
                    fileType = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("file_url"u8))
                {
                    fileUrl = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("resource_type"u8))
                {
                    resourceType = prop.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new Attachment(fileName, fileType, fileUrl, resourceType, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<Attachment>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<Attachment>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Attachment)} does not support writing '{options.Format}' format.");
            }
        }

        Attachment IPersistableModel<Attachment>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual Attachment PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<Attachment>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeAttachment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Attachment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Attachment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="attachment"> The <see cref="Attachment"/> to serialize into <see cref="BinaryContent"/>. </param>
        public static implicit operator BinaryContent(Attachment attachment)
        {
            if (attachment == null)
            {
                return null;
            }
            return BinaryContent.Create(attachment, ModelSerializationExtensions.WireOptions);
        }

        /// <param name="result"> The <see cref="ClientResult"/> to deserialize the <see cref="Attachment"/> from. </param>
        public static explicit operator Attachment(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeAttachment(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
