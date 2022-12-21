// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.VideoSurveillance
{
    public static class GetSystemGroups
    {
        /// <summary>
        /// This data source provides the Video Surveillance System Groups of the current Alibaba Cloud user.
        /// 
        /// &gt; **NOTE:** Available in v1.135.0+.
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
        ///     var defaultSystemGroup = new AliCloud.VideoSurveillance.SystemGroup("defaultSystemGroup", new()
        ///     {
        ///         GroupName = "groupname",
        ///         InProtocol = "rtmp",
        ///         OutProtocol = "flv",
        ///         PlayDomain = "your_plan_domain",
        ///         PushDomain = "your_push_domain",
        ///     });
        /// 
        ///     var defaultSystemGroups = AliCloud.VideoSurveillance.GetSystemGroups.Invoke(new()
        ///     {
        ///         Ids = new[]
        ///         {
        ///             defaultSystemGroup.Id,
        ///         },
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["vsGroup"] = defaultSystemGroups.Apply(getSystemGroupsResult =&gt; getSystemGroupsResult.Ids[0]),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetSystemGroupsResult> InvokeAsync(GetSystemGroupsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSystemGroupsResult>("alicloud:videosurveillance/getSystemGroups:getSystemGroups", args ?? new GetSystemGroupsArgs(), options.WithDefaults());

        /// <summary>
        /// This data source provides the Video Surveillance System Groups of the current Alibaba Cloud user.
        /// 
        /// &gt; **NOTE:** Available in v1.135.0+.
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
        ///     var defaultSystemGroup = new AliCloud.VideoSurveillance.SystemGroup("defaultSystemGroup", new()
        ///     {
        ///         GroupName = "groupname",
        ///         InProtocol = "rtmp",
        ///         OutProtocol = "flv",
        ///         PlayDomain = "your_plan_domain",
        ///         PushDomain = "your_push_domain",
        ///     });
        /// 
        ///     var defaultSystemGroups = AliCloud.VideoSurveillance.GetSystemGroups.Invoke(new()
        ///     {
        ///         Ids = new[]
        ///         {
        ///             defaultSystemGroup.Id,
        ///         },
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["vsGroup"] = defaultSystemGroups.Apply(getSystemGroupsResult =&gt; getSystemGroupsResult.Ids[0]),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetSystemGroupsResult> Invoke(GetSystemGroupsInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSystemGroupsResult>("alicloud:videosurveillance/getSystemGroups:getSystemGroups", args ?? new GetSystemGroupsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSystemGroupsArgs : global::Pulumi.InvokeArgs
    {
        [Input("ids")]
        private List<string>? _ids;

        /// <summary>
        /// A list of Group IDs.
        /// </summary>
        public List<string> Ids
        {
            get => _ids ?? (_ids = new List<string>());
            set => _ids = value;
        }

        /// <summary>
        /// The use of the access protocol support `gb28181`,`rtmp`(Real Time Messaging Protocol).
        /// </summary>
        [Input("inProtocol")]
        public string? InProtocol { get; set; }

        /// <summary>
        /// The name.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A regex string to filter results by Group name.
        /// </summary>
        [Input("nameRegex")]
        public string? NameRegex { get; set; }

        [Input("outputFile")]
        public string? OutputFile { get; set; }

        /// <summary>
        /// The status. Valid values: `on`,`off`.
        /// </summary>
        [Input("status")]
        public string? Status { get; set; }

        public GetSystemGroupsArgs()
        {
        }
        public static new GetSystemGroupsArgs Empty => new GetSystemGroupsArgs();
    }

    public sealed class GetSystemGroupsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("ids")]
        private InputList<string>? _ids;

        /// <summary>
        /// A list of Group IDs.
        /// </summary>
        public InputList<string> Ids
        {
            get => _ids ?? (_ids = new InputList<string>());
            set => _ids = value;
        }

        /// <summary>
        /// The use of the access protocol support `gb28181`,`rtmp`(Real Time Messaging Protocol).
        /// </summary>
        [Input("inProtocol")]
        public Input<string>? InProtocol { get; set; }

        /// <summary>
        /// The name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A regex string to filter results by Group name.
        /// </summary>
        [Input("nameRegex")]
        public Input<string>? NameRegex { get; set; }

        [Input("outputFile")]
        public Input<string>? OutputFile { get; set; }

        /// <summary>
        /// The status. Valid values: `on`,`off`.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public GetSystemGroupsInvokeArgs()
        {
        }
        public static new GetSystemGroupsInvokeArgs Empty => new GetSystemGroupsInvokeArgs();
    }


    [OutputType]
    public sealed class GetSystemGroupsResult
    {
        public readonly ImmutableArray<Outputs.GetSystemGroupsGroupResult> Groups;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> Ids;
        public readonly string? InProtocol;
        public readonly string? Name;
        public readonly string? NameRegex;
        public readonly ImmutableArray<string> Names;
        public readonly string? OutputFile;
        public readonly string? Status;

        [OutputConstructor]
        private GetSystemGroupsResult(
            ImmutableArray<Outputs.GetSystemGroupsGroupResult> groups,

            string id,

            ImmutableArray<string> ids,

            string? inProtocol,

            string? name,

            string? nameRegex,

            ImmutableArray<string> names,

            string? outputFile,

            string? status)
        {
            Groups = groups;
            Id = id;
            Ids = ids;
            InProtocol = inProtocol;
            Name = name;
            NameRegex = nameRegex;
            Names = names;
            OutputFile = outputFile;
            Status = status;
        }
    }
}