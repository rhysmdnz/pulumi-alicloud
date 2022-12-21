// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud
{
    /// <summary>
    /// The provider type for the alicloud package. By default, resources use package-wide configuration
    /// settings, however an explicit `Provider` instance may be created and passed during resource
    /// construction to achieve fine-grained programmatic control over provider settings. See the
    /// [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
    /// </summary>
    [AliCloudResourceType("pulumi:providers:alicloud")]
    public partial class Provider : global::Pulumi.ProviderResource
    {
        /// <summary>
        /// The access key for API operations. You can retrieve this from the 'Security Management' section of the Alibaba Cloud
        /// console.
        /// </summary>
        [Output("accessKey")]
        public Output<string?> AccessKey { get; private set; } = null!;

        /// <summary>
        /// The account ID for some service API operations. You can retrieve this from the 'Security Settings' section of the
        /// Alibaba Cloud console.
        /// </summary>
        [Output("accountId")]
        public Output<string?> AccountId { get; private set; } = null!;

        /// <summary>
        /// Use this to mark a terraform configuration file source.
        /// </summary>
        [Output("configurationSource")]
        public Output<string?> ConfigurationSource { get; private set; } = null!;

        /// <summary>
        /// The URI of sidecar credentials service.
        /// </summary>
        [Output("credentialsUri")]
        public Output<string?> CredentialsUri { get; private set; } = null!;

        /// <summary>
        /// The RAM Role Name attached on a ECS instance for API operations. You can retrieve this from the 'Access Control' section
        /// of the Alibaba Cloud console.
        /// </summary>
        [Output("ecsRoleName")]
        public Output<string?> EcsRoleName { get; private set; } = null!;

        [Output("fc")]
        public Output<string?> Fc { get; private set; } = null!;

        [Output("logEndpoint")]
        public Output<string?> LogEndpoint { get; private set; } = null!;

        [Output("mnsEndpoint")]
        public Output<string?> MnsEndpoint { get; private set; } = null!;

        [Output("otsInstanceName")]
        public Output<string?> OtsInstanceName { get; private set; } = null!;

        /// <summary>
        /// The profile for API operations. If not set, the default profile created with `aliyun configure` will be used.
        /// </summary>
        [Output("profile")]
        public Output<string?> Profile { get; private set; } = null!;

        [Output("protocol")]
        public Output<string?> Protocol { get; private set; } = null!;

        /// <summary>
        /// The region where Alibaba Cloud operations will take place. Examples are cn-beijing, cn-hangzhou, eu-central-1, etc.
        /// </summary>
        [Output("region")]
        public Output<string?> Region { get; private set; } = null!;

        /// <summary>
        /// The secret key for API operations. You can retrieve this from the 'Security Management' section of the Alibaba Cloud
        /// console.
        /// </summary>
        [Output("secretKey")]
        public Output<string?> SecretKey { get; private set; } = null!;

        /// <summary>
        /// The security transport for the assume role invoking.
        /// </summary>
        [Output("secureTransport")]
        public Output<string?> SecureTransport { get; private set; } = null!;

        /// <summary>
        /// security token. A security token is only required if you are using Security Token Service.
        /// </summary>
        [Output("securityToken")]
        public Output<string?> SecurityToken { get; private set; } = null!;

        [Output("securityTransport")]
        public Output<string?> SecurityTransport { get; private set; } = null!;

        /// <summary>
        /// The path to the shared credentials file. If not set this defaults to ~/.aliyun/config.json
        /// </summary>
        [Output("sharedCredentialsFile")]
        public Output<string?> SharedCredentialsFile { get; private set; } = null!;

        /// <summary>
        /// The source ip for the assume role invoking.
        /// </summary>
        [Output("sourceIp")]
        public Output<string?> SourceIp { get; private set; } = null!;


        /// <summary>
        /// Create a Provider resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Provider(string name, ProviderArgs? args = null, CustomResourceOptions? options = null)
            : base("alicloud", name, args ?? new ProviderArgs(), MakeResourceOptions(options, ""))
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
    }

    public sealed class ProviderArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The access key for API operations. You can retrieve this from the 'Security Management' section of the Alibaba Cloud
        /// console.
        /// </summary>
        [Input("accessKey")]
        public Input<string>? AccessKey { get; set; }

        /// <summary>
        /// The account ID for some service API operations. You can retrieve this from the 'Security Settings' section of the
        /// Alibaba Cloud console.
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        [Input("assumeRole", json: true)]
        public Input<Inputs.ProviderAssumeRoleArgs>? AssumeRole { get; set; }

        /// <summary>
        /// The maximum timeout of the client connection server.
        /// </summary>
        [Input("clientConnectTimeout", json: true)]
        public Input<int>? ClientConnectTimeout { get; set; }

        /// <summary>
        /// The maximum timeout of the client read request.
        /// </summary>
        [Input("clientReadTimeout", json: true)]
        public Input<int>? ClientReadTimeout { get; set; }

        /// <summary>
        /// Use this to mark a terraform configuration file source.
        /// </summary>
        [Input("configurationSource")]
        public Input<string>? ConfigurationSource { get; set; }

        /// <summary>
        /// The URI of sidecar credentials service.
        /// </summary>
        [Input("credentialsUri")]
        public Input<string>? CredentialsUri { get; set; }

        /// <summary>
        /// The RAM Role Name attached on a ECS instance for API operations. You can retrieve this from the 'Access Control' section
        /// of the Alibaba Cloud console.
        /// </summary>
        [Input("ecsRoleName")]
        public Input<string>? EcsRoleName { get; set; }

        [Input("endpoints", json: true)]
        private InputList<Inputs.ProviderEndpointArgs>? _endpoints;
        public InputList<Inputs.ProviderEndpointArgs> Endpoints
        {
            get => _endpoints ?? (_endpoints = new InputList<Inputs.ProviderEndpointArgs>());
            set => _endpoints = value;
        }

        [Input("fc")]
        public Input<string>? Fc { get; set; }

        [Input("logEndpoint")]
        public Input<string>? LogEndpoint { get; set; }

        /// <summary>
        /// The maximum retry timeout of the request.
        /// </summary>
        [Input("maxRetryTimeout", json: true)]
        public Input<int>? MaxRetryTimeout { get; set; }

        [Input("mnsEndpoint")]
        public Input<string>? MnsEndpoint { get; set; }

        [Input("otsInstanceName")]
        public Input<string>? OtsInstanceName { get; set; }

        /// <summary>
        /// The profile for API operations. If not set, the default profile created with `aliyun configure` will be used.
        /// </summary>
        [Input("profile")]
        public Input<string>? Profile { get; set; }

        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The region where Alibaba Cloud operations will take place. Examples are cn-beijing, cn-hangzhou, eu-central-1, etc.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// The secret key for API operations. You can retrieve this from the 'Security Management' section of the Alibaba Cloud
        /// console.
        /// </summary>
        [Input("secretKey")]
        public Input<string>? SecretKey { get; set; }

        /// <summary>
        /// The security transport for the assume role invoking.
        /// </summary>
        [Input("secureTransport")]
        public Input<string>? SecureTransport { get; set; }

        /// <summary>
        /// security token. A security token is only required if you are using Security Token Service.
        /// </summary>
        [Input("securityToken")]
        public Input<string>? SecurityToken { get; set; }

        [Input("securityTransport")]
        public Input<string>? SecurityTransport { get; set; }

        /// <summary>
        /// The path to the shared credentials file. If not set this defaults to ~/.aliyun/config.json
        /// </summary>
        [Input("sharedCredentialsFile")]
        public Input<string>? SharedCredentialsFile { get; set; }

        /// <summary>
        /// Skip static validation of region ID. Used by users of alternative AlibabaCloud-like APIs or users w/ access to regions
        /// that are not public (yet).
        /// </summary>
        [Input("skipRegionValidation", json: true)]
        public Input<bool>? SkipRegionValidation { get; set; }

        /// <summary>
        /// The source ip for the assume role invoking.
        /// </summary>
        [Input("sourceIp")]
        public Input<string>? SourceIp { get; set; }

        public ProviderArgs()
        {
            EcsRoleName = Utilities.GetEnv("ALICLOUD_ECS_ROLE_NAME");
            Profile = Utilities.GetEnv("ALICLOUD_PROFILE");
            Region = Utilities.GetEnv("ALICLOUD_REGION");
        }
        public static new ProviderArgs Empty => new ProviderArgs();
    }
}