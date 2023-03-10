// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Slb
{
    /// <summary>
    /// HTTPS listeners of guaranteed-performance SLB support configuring multiple certificates, allowing you to forward requests with different domain names to different backend servers.
    /// Please refer to the [documentation](https://www.alibabacloud.com/help/doc-detail/85956.htm?spm=a2c63.p38356.b99.40.1c881563Co8p6w) for details.
    /// 
    /// &gt; **NOTE:** Available in 1.60.0+
    /// 
    /// &gt; **NOTE:** The instance with shared loadBalancerSpec doesn't support domainExtension.
    /// 
    /// ## Import
    /// 
    /// Load balancer domain_extension can be imported using the id, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import alicloud:slb/domainExtension:DomainExtension example de-abc123456
    /// ```
    /// </summary>
    [AliCloudResourceType("alicloud:slb/domainExtension:DomainExtension")]
    public partial class DomainExtension : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Checking DeleteProtection of SLB instance before deleting. If true, this resource will not be deleted when its SLB instance enabled DeleteProtection. Default to false.
        /// </summary>
        [Output("deleteProtectionValidation")]
        public Output<bool?> DeleteProtectionValidation { get; private set; } = null!;

        /// <summary>
        /// The domain name.
        /// </summary>
        [Output("domain")]
        public Output<string> Domain { get; private set; } = null!;

        /// <summary>
        /// The frontend port used by the HTTPS listener of the SLB instance. Valid values: 1–65535.
        /// </summary>
        [Output("frontendPort")]
        public Output<int> FrontendPort { get; private set; } = null!;

        /// <summary>
        /// The ID of the SLB instance.
        /// </summary>
        [Output("loadBalancerId")]
        public Output<string> LoadBalancerId { get; private set; } = null!;

        /// <summary>
        /// The ID of the certificate used by the domain name.
        /// </summary>
        [Output("serverCertificateId")]
        public Output<string> ServerCertificateId { get; private set; } = null!;


        /// <summary>
        /// Create a DomainExtension resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DomainExtension(string name, DomainExtensionArgs args, CustomResourceOptions? options = null)
            : base("alicloud:slb/domainExtension:DomainExtension", name, args ?? new DomainExtensionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DomainExtension(string name, Input<string> id, DomainExtensionState? state = null, CustomResourceOptions? options = null)
            : base("alicloud:slb/domainExtension:DomainExtension", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/rhysmdnz/pulumi-alicloud",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DomainExtension resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DomainExtension Get(string name, Input<string> id, DomainExtensionState? state = null, CustomResourceOptions? options = null)
        {
            return new DomainExtension(name, id, state, options);
        }
    }

    public sealed class DomainExtensionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Checking DeleteProtection of SLB instance before deleting. If true, this resource will not be deleted when its SLB instance enabled DeleteProtection. Default to false.
        /// </summary>
        [Input("deleteProtectionValidation")]
        public Input<bool>? DeleteProtectionValidation { get; set; }

        /// <summary>
        /// The domain name.
        /// </summary>
        [Input("domain", required: true)]
        public Input<string> Domain { get; set; } = null!;

        /// <summary>
        /// The frontend port used by the HTTPS listener of the SLB instance. Valid values: 1–65535.
        /// </summary>
        [Input("frontendPort", required: true)]
        public Input<int> FrontendPort { get; set; } = null!;

        /// <summary>
        /// The ID of the SLB instance.
        /// </summary>
        [Input("loadBalancerId", required: true)]
        public Input<string> LoadBalancerId { get; set; } = null!;

        /// <summary>
        /// The ID of the certificate used by the domain name.
        /// </summary>
        [Input("serverCertificateId", required: true)]
        public Input<string> ServerCertificateId { get; set; } = null!;

        public DomainExtensionArgs()
        {
        }
        public static new DomainExtensionArgs Empty => new DomainExtensionArgs();
    }

    public sealed class DomainExtensionState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Checking DeleteProtection of SLB instance before deleting. If true, this resource will not be deleted when its SLB instance enabled DeleteProtection. Default to false.
        /// </summary>
        [Input("deleteProtectionValidation")]
        public Input<bool>? DeleteProtectionValidation { get; set; }

        /// <summary>
        /// The domain name.
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        /// <summary>
        /// The frontend port used by the HTTPS listener of the SLB instance. Valid values: 1–65535.
        /// </summary>
        [Input("frontendPort")]
        public Input<int>? FrontendPort { get; set; }

        /// <summary>
        /// The ID of the SLB instance.
        /// </summary>
        [Input("loadBalancerId")]
        public Input<string>? LoadBalancerId { get; set; }

        /// <summary>
        /// The ID of the certificate used by the domain name.
        /// </summary>
        [Input("serverCertificateId")]
        public Input<string>? ServerCertificateId { get; set; }

        public DomainExtensionState()
        {
        }
        public static new DomainExtensionState Empty => new DomainExtensionState();
    }
}
