// <auto-generated/>

#nullable disable

using System.ClientModel;
using System.ClientModel.Primitives;

namespace PetStore
{
    /// <summary></summary>
    public partial class OwnerCheckups
    {
        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier _pipelineMessageClassifier200201;

        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 = PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });

        private static PipelineMessageClassifier PipelineMessageClassifier200201 => _pipelineMessageClassifier200201 = PipelineMessageClassifier.Create(stackalloc ushort[] { 200, 201 });

        internal PipelineMessage CreateCreateOrUpdateRequest(long ownerId, int checkupId, BinaryContent content, RequestOptions options)
        {
            PipelineMessage message = Pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200201;
            PipelineRequest request = message.Request;
            request.Method = "PATCH";
            ClientUriBuilder uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/owners/", false);
            uri.AppendPath(ownerId.ToString(), true);
            uri.AppendPath("/checkups/", false);
            uri.AppendPath(checkupId.ToString(), true);
            request.Uri = uri.ToUri();
            request.Headers.Set("Content-Type", "application/json");
            request.Headers.Set("Accept", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateListRequest(long ownerId, RequestOptions options)
        {
            PipelineMessage message = Pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            PipelineRequest request = message.Request;
            request.Method = "GET";
            ClientUriBuilder uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/owners/", false);
            uri.AppendPath(ownerId.ToString(), true);
            uri.AppendPath("/checkups", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }
    }
}
