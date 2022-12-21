// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Mse
{
    public static class GetEngineNamespaces
    {
        /// <summary>
        /// This data source provides the Mse Engine Namespaces of the current Alibaba Cloud user.
        /// 
        /// &gt; **NOTE:** Available in v1.166.0+.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// Basic Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using AliCloud = Pulumi.AliCloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var ids = AliCloud.Mse.GetEngineNamespaces.Invoke(new()
        ///     {
        ///         ClusterId = "example_value",
        ///         Ids = new[]
        ///         {
        ///             "example_value",
        ///         },
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["mseEngineNamespaceId1"] = ids.Apply(getEngineNamespacesResult =&gt; getEngineNamespacesResult.Namespaces[0]?.Id),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetEngineNamespacesResult> InvokeAsync(GetEngineNamespacesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetEngineNamespacesResult>("alicloud:mse/getEngineNamespaces:getEngineNamespaces", args ?? new GetEngineNamespacesArgs(), options.WithDefaults());

        /// <summary>
        /// This data source provides the Mse Engine Namespaces of the current Alibaba Cloud user.
        /// 
        /// &gt; **NOTE:** Available in v1.166.0+.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// Basic Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using AliCloud = Pulumi.AliCloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var ids = AliCloud.Mse.GetEngineNamespaces.Invoke(new()
        ///     {
        ///         ClusterId = "example_value",
        ///         Ids = new[]
        ///         {
        ///             "example_value",
        ///         },
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["mseEngineNamespaceId1"] = ids.Apply(getEngineNamespacesResult =&gt; getEngineNamespacesResult.Namespaces[0]?.Id),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetEngineNamespacesResult> Invoke(GetEngineNamespacesInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetEngineNamespacesResult>("alicloud:mse/getEngineNamespaces:getEngineNamespaces", args ?? new GetEngineNamespacesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetEngineNamespacesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The language type of the returned information. Valid values: `zh`, `en`.
        /// </summary>
        [Input("acceptLanguage")]
        public string? AcceptLanguage { get; set; }

        /// <summary>
        /// The id of the cluster.
        /// </summary>
        [Input("clusterId", required: true)]
        public string ClusterId { get; set; } = null!;

        [Input("ids")]
        private List<string>? _ids;

        /// <summary>
        /// A list of Engine Namespace IDs. It is formatted to `&lt;cluster_id&gt;:&lt;namespace_id&gt;`.
        /// </summary>
        public List<string> Ids
        {
            get => _ids ?? (_ids = new List<string>());
            set => _ids = value;
        }

        [Input("outputFile")]
        public string? OutputFile { get; set; }

        public GetEngineNamespacesArgs()
        {
        }
        public static new GetEngineNamespacesArgs Empty => new GetEngineNamespacesArgs();
    }

    public sealed class GetEngineNamespacesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The language type of the returned information. Valid values: `zh`, `en`.
        /// </summary>
        [Input("acceptLanguage")]
        public Input<string>? AcceptLanguage { get; set; }

        /// <summary>
        /// The id of the cluster.
        /// </summary>
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        [Input("ids")]
        private InputList<string>? _ids;

        /// <summary>
        /// A list of Engine Namespace IDs. It is formatted to `&lt;cluster_id&gt;:&lt;namespace_id&gt;`.
        /// </summary>
        public InputList<string> Ids
        {
            get => _ids ?? (_ids = new InputList<string>());
            set => _ids = value;
        }

        [Input("outputFile")]
        public Input<string>? OutputFile { get; set; }

        public GetEngineNamespacesInvokeArgs()
        {
        }
        public static new GetEngineNamespacesInvokeArgs Empty => new GetEngineNamespacesInvokeArgs();
    }


    [OutputType]
    public sealed class GetEngineNamespacesResult
    {
        public readonly string? AcceptLanguage;
        public readonly string ClusterId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> Ids;
        public readonly ImmutableArray<Outputs.GetEngineNamespacesNamespaceResult> Namespaces;
        public readonly string? OutputFile;

        [OutputConstructor]
        private GetEngineNamespacesResult(
            string? acceptLanguage,

            string clusterId,

            string id,

            ImmutableArray<string> ids,

            ImmutableArray<Outputs.GetEngineNamespacesNamespaceResult> namespaces,

            string? outputFile)
        {
            AcceptLanguage = acceptLanguage;
            ClusterId = clusterId;
            Id = id;
            Ids = ids;
            Namespaces = namespaces;
            OutputFile = outputFile;
        }
    }
}