// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Rdc
{
    public static class GetOrganizations
    {
        /// <summary>
        /// This data source provides the Rdc Organizations of the current Alibaba Cloud user.
        /// 
        /// &gt; **NOTE:** Available in v1.137.0+.
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
        ///     var config = new Config();
        ///     var name = config.Get("name") ?? "tf-testAccOrganizations-Organizations";
        ///     var @default = new AliCloud.Rdc.Organization("default", new()
        ///     {
        ///         OrganizationName = name,
        ///         Source = name,
        ///     });
        /// 
        ///     var ids = AliCloud.Rdc.GetOrganizations.Invoke(new()
        ///     {
        ///         Ids = new[]
        ///         {
        ///             @default.Id,
        ///         },
        ///     });
        /// 
        ///     var nameRegex = AliCloud.Rdc.GetOrganizations.Invoke(new()
        ///     {
        ///         NameRegex = "^my-Organization",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["rdcOrganizationId1"] = ids.Apply(getOrganizationsResult =&gt; getOrganizationsResult.Id),
        ///         ["rdcOrganizationId2"] = nameRegex.Apply(getOrganizationsResult =&gt; getOrganizationsResult.Id),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetOrganizationsResult> InvokeAsync(GetOrganizationsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetOrganizationsResult>("alicloud:rdc/getOrganizations:getOrganizations", args ?? new GetOrganizationsArgs(), options.WithDefaults());

        /// <summary>
        /// This data source provides the Rdc Organizations of the current Alibaba Cloud user.
        /// 
        /// &gt; **NOTE:** Available in v1.137.0+.
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
        ///     var config = new Config();
        ///     var name = config.Get("name") ?? "tf-testAccOrganizations-Organizations";
        ///     var @default = new AliCloud.Rdc.Organization("default", new()
        ///     {
        ///         OrganizationName = name,
        ///         Source = name,
        ///     });
        /// 
        ///     var ids = AliCloud.Rdc.GetOrganizations.Invoke(new()
        ///     {
        ///         Ids = new[]
        ///         {
        ///             @default.Id,
        ///         },
        ///     });
        /// 
        ///     var nameRegex = AliCloud.Rdc.GetOrganizations.Invoke(new()
        ///     {
        ///         NameRegex = "^my-Organization",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["rdcOrganizationId1"] = ids.Apply(getOrganizationsResult =&gt; getOrganizationsResult.Id),
        ///         ["rdcOrganizationId2"] = nameRegex.Apply(getOrganizationsResult =&gt; getOrganizationsResult.Id),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetOrganizationsResult> Invoke(GetOrganizationsInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetOrganizationsResult>("alicloud:rdc/getOrganizations:getOrganizations", args ?? new GetOrganizationsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetOrganizationsArgs : global::Pulumi.InvokeArgs
    {
        [Input("ids")]
        private List<string>? _ids;

        /// <summary>
        /// A list of Organization IDs.
        /// </summary>
        public List<string> Ids
        {
            get => _ids ?? (_ids = new List<string>());
            set => _ids = value;
        }

        /// <summary>
        /// A regex string to filter results by Organization name.
        /// </summary>
        [Input("nameRegex")]
        public string? NameRegex { get; set; }

        [Input("outputFile")]
        public string? OutputFile { get; set; }

        /// <summary>
        /// User pk, not required, only required when the ak used by the calling interface is inconsistent with the user pk
        /// </summary>
        [Input("realPk")]
        public string? RealPk { get; set; }

        public GetOrganizationsArgs()
        {
        }
        public static new GetOrganizationsArgs Empty => new GetOrganizationsArgs();
    }

    public sealed class GetOrganizationsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("ids")]
        private InputList<string>? _ids;

        /// <summary>
        /// A list of Organization IDs.
        /// </summary>
        public InputList<string> Ids
        {
            get => _ids ?? (_ids = new InputList<string>());
            set => _ids = value;
        }

        /// <summary>
        /// A regex string to filter results by Organization name.
        /// </summary>
        [Input("nameRegex")]
        public Input<string>? NameRegex { get; set; }

        [Input("outputFile")]
        public Input<string>? OutputFile { get; set; }

        /// <summary>
        /// User pk, not required, only required when the ak used by the calling interface is inconsistent with the user pk
        /// </summary>
        [Input("realPk")]
        public Input<string>? RealPk { get; set; }

        public GetOrganizationsInvokeArgs()
        {
        }
        public static new GetOrganizationsInvokeArgs Empty => new GetOrganizationsInvokeArgs();
    }


    [OutputType]
    public sealed class GetOrganizationsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> Ids;
        public readonly string? NameRegex;
        public readonly ImmutableArray<string> Names;
        public readonly ImmutableArray<Outputs.GetOrganizationsOrganizationResult> Organizations;
        public readonly string? OutputFile;
        public readonly string? RealPk;

        [OutputConstructor]
        private GetOrganizationsResult(
            string id,

            ImmutableArray<string> ids,

            string? nameRegex,

            ImmutableArray<string> names,

            ImmutableArray<Outputs.GetOrganizationsOrganizationResult> organizations,

            string? outputFile,

            string? realPk)
        {
            Id = id;
            Ids = ids;
            NameRegex = nameRegex;
            Names = names;
            Organizations = organizations;
            OutputFile = outputFile;
            RealPk = realPk;
        }
    }
}