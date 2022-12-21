// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Dns
{
    public static class GetDomains
    {
        /// <summary>
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using AliCloud = Pulumi.AliCloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var domainsDs = AliCloud.Dns.GetDomains.Invoke(new()
        ///     {
        ///         DomainNameRegex = "^hegu",
        ///         OutputFile = "domains.txt",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["firstDomainId"] = domainsDs.Apply(getDomainsResult =&gt; getDomainsResult.Domains[0]?.DomainId),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDomainsResult> InvokeAsync(GetDomainsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDomainsResult>("alicloud:dns/getDomains:getDomains", args ?? new GetDomainsArgs(), options.WithDefaults());

        /// <summary>
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using AliCloud = Pulumi.AliCloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var domainsDs = AliCloud.Dns.GetDomains.Invoke(new()
        ///     {
        ///         DomainNameRegex = "^hegu",
        ///         OutputFile = "domains.txt",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["firstDomainId"] = domainsDs.Apply(getDomainsResult =&gt; getDomainsResult.Domains[0]?.DomainId),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetDomainsResult> Invoke(GetDomainsInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDomainsResult>("alicloud:dns/getDomains:getDomains", args ?? new GetDomainsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDomainsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specifies whether the domain is from Alibaba Cloud or not.
        /// </summary>
        [Input("aliDomain")]
        public bool? AliDomain { get; set; }

        /// <summary>
        /// A regex string to filter results by the domain name.
        /// </summary>
        [Input("domainNameRegex")]
        public string? DomainNameRegex { get; set; }

        [Input("enableDetails")]
        public bool? EnableDetails { get; set; }

        /// <summary>
        /// Domain group ID, if not filled, the default is all groups.
        /// </summary>
        [Input("groupId")]
        public string? GroupId { get; set; }

        /// <summary>
        /// A regex string to filter results by the group name.
        /// </summary>
        [Input("groupNameRegex")]
        public string? GroupNameRegex { get; set; }

        [Input("ids")]
        private List<string>? _ids;

        /// <summary>
        /// - A list of domain IDs.
        /// </summary>
        public List<string> Ids
        {
            get => _ids ?? (_ids = new List<string>());
            set => _ids = value;
        }

        /// <summary>
        /// Cloud analysis product ID.
        /// </summary>
        [Input("instanceId")]
        public string? InstanceId { get; set; }

        /// <summary>
        /// The keywords are searched according to the `%KeyWord%` mode, which is not case sensitive.
        /// </summary>
        [Input("keyWord")]
        public string? KeyWord { get; set; }

        /// <summary>
        /// User language.
        /// </summary>
        [Input("lang")]
        public string? Lang { get; set; }

        [Input("outputFile")]
        public string? OutputFile { get; set; }

        /// <summary>
        /// The Id of resource group which the dns belongs.
        /// </summary>
        [Input("resourceGroupId")]
        public string? ResourceGroupId { get; set; }

        /// <summary>
        /// Search mode, `LIKE` fuzzy search, `EXACT` exact search.
        /// </summary>
        [Input("searchMode")]
        public string? SearchMode { get; set; }

        /// <summary>
        /// Whether to query the domain name star.
        /// </summary>
        [Input("starmark")]
        public bool? Starmark { get; set; }

        [Input("tags")]
        private Dictionary<string, object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        /// <summary>
        /// Cloud analysis version code.
        /// </summary>
        [Input("versionCode")]
        public string? VersionCode { get; set; }

        public GetDomainsArgs()
        {
        }
        public static new GetDomainsArgs Empty => new GetDomainsArgs();
    }

    public sealed class GetDomainsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specifies whether the domain is from Alibaba Cloud or not.
        /// </summary>
        [Input("aliDomain")]
        public Input<bool>? AliDomain { get; set; }

        /// <summary>
        /// A regex string to filter results by the domain name.
        /// </summary>
        [Input("domainNameRegex")]
        public Input<string>? DomainNameRegex { get; set; }

        [Input("enableDetails")]
        public Input<bool>? EnableDetails { get; set; }

        /// <summary>
        /// Domain group ID, if not filled, the default is all groups.
        /// </summary>
        [Input("groupId")]
        public Input<string>? GroupId { get; set; }

        /// <summary>
        /// A regex string to filter results by the group name.
        /// </summary>
        [Input("groupNameRegex")]
        public Input<string>? GroupNameRegex { get; set; }

        [Input("ids")]
        private InputList<string>? _ids;

        /// <summary>
        /// - A list of domain IDs.
        /// </summary>
        public InputList<string> Ids
        {
            get => _ids ?? (_ids = new InputList<string>());
            set => _ids = value;
        }

        /// <summary>
        /// Cloud analysis product ID.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// The keywords are searched according to the `%KeyWord%` mode, which is not case sensitive.
        /// </summary>
        [Input("keyWord")]
        public Input<string>? KeyWord { get; set; }

        /// <summary>
        /// User language.
        /// </summary>
        [Input("lang")]
        public Input<string>? Lang { get; set; }

        [Input("outputFile")]
        public Input<string>? OutputFile { get; set; }

        /// <summary>
        /// The Id of resource group which the dns belongs.
        /// </summary>
        [Input("resourceGroupId")]
        public Input<string>? ResourceGroupId { get; set; }

        /// <summary>
        /// Search mode, `LIKE` fuzzy search, `EXACT` exact search.
        /// </summary>
        [Input("searchMode")]
        public Input<string>? SearchMode { get; set; }

        /// <summary>
        /// Whether to query the domain name star.
        /// </summary>
        [Input("starmark")]
        public Input<bool>? Starmark { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// Cloud analysis version code.
        /// </summary>
        [Input("versionCode")]
        public Input<string>? VersionCode { get; set; }

        public GetDomainsInvokeArgs()
        {
        }
        public static new GetDomainsInvokeArgs Empty => new GetDomainsInvokeArgs();
    }


    [OutputType]
    public sealed class GetDomainsResult
    {
        /// <summary>
        /// Indicates whether the domain is an Alibaba Cloud domain.
        /// </summary>
        public readonly bool? AliDomain;
        public readonly string? DomainNameRegex;
        /// <summary>
        /// A list of domains. Each element contains the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDomainsDomainResult> Domains;
        public readonly bool? EnableDetails;
        /// <summary>
        /// Id of group that contains the domain.
        /// </summary>
        public readonly string? GroupId;
        public readonly string? GroupNameRegex;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A list of domain IDs.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        /// <summary>
        /// Cloud analysis product ID of the domain.
        /// </summary>
        public readonly string? InstanceId;
        public readonly string? KeyWord;
        public readonly string? Lang;
        /// <summary>
        /// A list of domain names.
        /// </summary>
        public readonly ImmutableArray<string> Names;
        public readonly string? OutputFile;
        /// <summary>
        /// The Id of resource group which the dns belongs.
        /// </summary>
        public readonly string? ResourceGroupId;
        public readonly string? SearchMode;
        public readonly bool? Starmark;
        public readonly ImmutableDictionary<string, object>? Tags;
        /// <summary>
        /// Cloud resolution version ID.
        /// </summary>
        public readonly string? VersionCode;

        [OutputConstructor]
        private GetDomainsResult(
            bool? aliDomain,

            string? domainNameRegex,

            ImmutableArray<Outputs.GetDomainsDomainResult> domains,

            bool? enableDetails,

            string? groupId,

            string? groupNameRegex,

            string id,

            ImmutableArray<string> ids,

            string? instanceId,

            string? keyWord,

            string? lang,

            ImmutableArray<string> names,

            string? outputFile,

            string? resourceGroupId,

            string? searchMode,

            bool? starmark,

            ImmutableDictionary<string, object>? tags,

            string? versionCode)
        {
            AliDomain = aliDomain;
            DomainNameRegex = domainNameRegex;
            Domains = domains;
            EnableDetails = enableDetails;
            GroupId = groupId;
            GroupNameRegex = groupNameRegex;
            Id = id;
            Ids = ids;
            InstanceId = instanceId;
            KeyWord = keyWord;
            Lang = lang;
            Names = names;
            OutputFile = outputFile;
            ResourceGroupId = resourceGroupId;
            SearchMode = searchMode;
            Starmark = starmark;
            Tags = tags;
            VersionCode = versionCode;
        }
    }
}