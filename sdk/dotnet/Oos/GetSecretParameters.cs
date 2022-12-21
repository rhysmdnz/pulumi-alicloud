// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Oos
{
    public static class GetSecretParameters
    {
        /// <summary>
        /// This data source provides the Oos Secret Parameters of the current Alibaba Cloud user.
        /// 
        /// &gt; **NOTE:** Available in v1.147.0+.
        /// </summary>
        public static Task<GetSecretParametersResult> InvokeAsync(GetSecretParametersArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSecretParametersResult>("alicloud:oos/getSecretParameters:getSecretParameters", args ?? new GetSecretParametersArgs(), options.WithDefaults());

        /// <summary>
        /// This data source provides the Oos Secret Parameters of the current Alibaba Cloud user.
        /// 
        /// &gt; **NOTE:** Available in v1.147.0+.
        /// </summary>
        public static Output<GetSecretParametersResult> Invoke(GetSecretParametersInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSecretParametersResult>("alicloud:oos/getSecretParameters:getSecretParameters", args ?? new GetSecretParametersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSecretParametersArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Default to `false`. Set it to `true` can output more details about resource attributes.
        /// </summary>
        [Input("enableDetails")]
        public bool? EnableDetails { get; set; }

        [Input("ids")]
        private List<string>? _ids;

        /// <summary>
        /// A list of Secret Parameter IDs.
        /// </summary>
        public List<string> Ids
        {
            get => _ids ?? (_ids = new List<string>());
            set => _ids = value;
        }

        /// <summary>
        /// A regex string to filter results by Secret Parameter name.
        /// </summary>
        [Input("nameRegex")]
        public string? NameRegex { get; set; }

        [Input("outputFile")]
        public string? OutputFile { get; set; }

        /// <summary>
        /// The ID of the Resource Group.
        /// </summary>
        [Input("resourceGroupId")]
        public string? ResourceGroupId { get; set; }

        /// <summary>
        /// The name of the encryption parameter.
        /// </summary>
        [Input("secretParameterName")]
        public string? SecretParameterName { get; set; }

        [Input("sortField")]
        public string? SortField { get; set; }

        [Input("sortOrder")]
        public string? SortOrder { get; set; }

        [Input("tags")]
        private Dictionary<string, object>? _tags;

        /// <summary>
        /// The tag of the resource.
        /// </summary>
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        public GetSecretParametersArgs()
        {
        }
        public static new GetSecretParametersArgs Empty => new GetSecretParametersArgs();
    }

    public sealed class GetSecretParametersInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Default to `false`. Set it to `true` can output more details about resource attributes.
        /// </summary>
        [Input("enableDetails")]
        public Input<bool>? EnableDetails { get; set; }

        [Input("ids")]
        private InputList<string>? _ids;

        /// <summary>
        /// A list of Secret Parameter IDs.
        /// </summary>
        public InputList<string> Ids
        {
            get => _ids ?? (_ids = new InputList<string>());
            set => _ids = value;
        }

        /// <summary>
        /// A regex string to filter results by Secret Parameter name.
        /// </summary>
        [Input("nameRegex")]
        public Input<string>? NameRegex { get; set; }

        [Input("outputFile")]
        public Input<string>? OutputFile { get; set; }

        /// <summary>
        /// The ID of the Resource Group.
        /// </summary>
        [Input("resourceGroupId")]
        public Input<string>? ResourceGroupId { get; set; }

        /// <summary>
        /// The name of the encryption parameter.
        /// </summary>
        [Input("secretParameterName")]
        public Input<string>? SecretParameterName { get; set; }

        [Input("sortField")]
        public Input<string>? SortField { get; set; }

        [Input("sortOrder")]
        public Input<string>? SortOrder { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// The tag of the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public GetSecretParametersInvokeArgs()
        {
        }
        public static new GetSecretParametersInvokeArgs Empty => new GetSecretParametersInvokeArgs();
    }


    [OutputType]
    public sealed class GetSecretParametersResult
    {
        public readonly bool? EnableDetails;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> Ids;
        public readonly string? NameRegex;
        public readonly ImmutableArray<string> Names;
        public readonly string? OutputFile;
        public readonly ImmutableArray<Outputs.GetSecretParametersParameterResult> Parameters;
        public readonly string? ResourceGroupId;
        public readonly string? SecretParameterName;
        public readonly string? SortField;
        public readonly string? SortOrder;
        public readonly ImmutableDictionary<string, object>? Tags;

        [OutputConstructor]
        private GetSecretParametersResult(
            bool? enableDetails,

            string id,

            ImmutableArray<string> ids,

            string? nameRegex,

            ImmutableArray<string> names,

            string? outputFile,

            ImmutableArray<Outputs.GetSecretParametersParameterResult> parameters,

            string? resourceGroupId,

            string? secretParameterName,

            string? sortField,

            string? sortOrder,

            ImmutableDictionary<string, object>? tags)
        {
            EnableDetails = enableDetails;
            Id = id;
            Ids = ids;
            NameRegex = nameRegex;
            Names = names;
            OutputFile = outputFile;
            Parameters = parameters;
            ResourceGroupId = resourceGroupId;
            SecretParameterName = secretParameterName;
            SortField = sortField;
            SortOrder = sortOrder;
            Tags = tags;
        }
    }
}