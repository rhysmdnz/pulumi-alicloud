// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.CloudFirewall
{
    public static class GetAddressBooks
    {
        /// <summary>
        /// This data source provides the Cloud Firewall Address Books of the current Alibaba Cloud user.
        /// 
        /// &gt; **NOTE:** Available in v1.178.0+.
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
        ///     var ids = AliCloud.CloudFirewall.GetAddressBooks.Invoke();
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["cloudFirewallAddressBookId1"] = ids.Apply(getAddressBooksResult =&gt; getAddressBooksResult.Books[0]?.Id),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetAddressBooksResult> InvokeAsync(GetAddressBooksArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAddressBooksResult>("alicloud:cloudfirewall/getAddressBooks:getAddressBooks", args ?? new GetAddressBooksArgs(), options.WithDefaults());

        /// <summary>
        /// This data source provides the Cloud Firewall Address Books of the current Alibaba Cloud user.
        /// 
        /// &gt; **NOTE:** Available in v1.178.0+.
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
        ///     var ids = AliCloud.CloudFirewall.GetAddressBooks.Invoke();
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["cloudFirewallAddressBookId1"] = ids.Apply(getAddressBooksResult =&gt; getAddressBooksResult.Books[0]?.Id),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetAddressBooksResult> Invoke(GetAddressBooksInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetAddressBooksResult>("alicloud:cloudfirewall/getAddressBooks:getAddressBooks", args ?? new GetAddressBooksInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAddressBooksArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The type of the Address Book.
        /// </summary>
        [Input("groupType")]
        public string? GroupType { get; set; }

        [Input("ids")]
        private List<string>? _ids;

        /// <summary>
        /// A list of Address Book IDs.
        /// </summary>
        public List<string> Ids
        {
            get => _ids ?? (_ids = new List<string>());
            set => _ids = value;
        }

        /// <summary>
        /// A regex string to filter results Address Book name.
        /// </summary>
        [Input("nameRegex")]
        public string? NameRegex { get; set; }

        [Input("outputFile")]
        public string? OutputFile { get; set; }

        public GetAddressBooksArgs()
        {
        }
        public static new GetAddressBooksArgs Empty => new GetAddressBooksArgs();
    }

    public sealed class GetAddressBooksInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The type of the Address Book.
        /// </summary>
        [Input("groupType")]
        public Input<string>? GroupType { get; set; }

        [Input("ids")]
        private InputList<string>? _ids;

        /// <summary>
        /// A list of Address Book IDs.
        /// </summary>
        public InputList<string> Ids
        {
            get => _ids ?? (_ids = new InputList<string>());
            set => _ids = value;
        }

        /// <summary>
        /// A regex string to filter results Address Book name.
        /// </summary>
        [Input("nameRegex")]
        public Input<string>? NameRegex { get; set; }

        [Input("outputFile")]
        public Input<string>? OutputFile { get; set; }

        public GetAddressBooksInvokeArgs()
        {
        }
        public static new GetAddressBooksInvokeArgs Empty => new GetAddressBooksInvokeArgs();
    }


    [OutputType]
    public sealed class GetAddressBooksResult
    {
        public readonly ImmutableArray<Outputs.GetAddressBooksBookResult> Books;
        public readonly string? GroupType;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> Ids;
        public readonly string? NameRegex;
        public readonly ImmutableArray<string> Names;
        public readonly string? OutputFile;

        [OutputConstructor]
        private GetAddressBooksResult(
            ImmutableArray<Outputs.GetAddressBooksBookResult> books,

            string? groupType,

            string id,

            ImmutableArray<string> ids,

            string? nameRegex,

            ImmutableArray<string> names,

            string? outputFile)
        {
            Books = books;
            GroupType = groupType;
            Id = id;
            Ids = ids;
            NameRegex = nameRegex;
            Names = names;
            OutputFile = outputFile;
        }
    }
}