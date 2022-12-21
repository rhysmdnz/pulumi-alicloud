// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Ess
{
    /// <summary>
    /// ## Import
    /// 
    /// ESS scaling group can be imported using the id, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import alicloud:ess/scalingGroup:ScalingGroup example asg-abc123456
    /// ```
    /// </summary>
    [AliCloudResourceType("alicloud:ess/scalingGroup:ScalingGroup")]
    public partial class ScalingGroup : global::Pulumi.CustomResource
    {
        /// <summary>
        /// If an RDS instance is specified in the scaling group, the scaling group automatically attaches the Intranet IP addresses of its ECS instances to the RDS access whitelist.
        /// - The specified RDS instance must be in running status.
        /// - The specified RDS instance’s whitelist must have room for more IP addresses.
        /// </summary>
        [Output("dbInstanceIds")]
        public Output<ImmutableArray<string>> DbInstanceIds { get; private set; } = null!;

        /// <summary>
        /// Default cool-down time (in seconds) of the scaling group. Value range: [0, 86400]. The default value is 300s.
        /// </summary>
        [Output("defaultCooldown")]
        public Output<int?> DefaultCooldown { get; private set; } = null!;

        /// <summary>
        /// Expected number of ECS instances in the scaling group. Value range: [min_size, max_size].
        /// </summary>
        [Output("desiredCapacity")]
        public Output<int?> DesiredCapacity { get; private set; } = null!;

        /// <summary>
        /// Specifies whether the scaling group deletion protection is enabled. `true` or `false`, Default value: `false`.
        /// </summary>
        [Output("groupDeletionProtection")]
        public Output<bool?> GroupDeletionProtection { get; private set; } = null!;

        /// <summary>
        /// Resource type within scaling group. Optional values: ECS, ECI. Default to ECS.
        /// </summary>
        [Output("groupType")]
        public Output<string> GroupType { get; private set; } = null!;

        /// <summary>
        /// Resource type within scaling group. Optional values: ECS, NONE. Default to ECS.
        /// </summary>
        [Output("healthCheckType")]
        public Output<string> HealthCheckType { get; private set; } = null!;

        /// <summary>
        /// Instance launch template ID, scaling group obtains launch configuration from instance launch template, see [Launch Template](https://www.alibabacloud.com/help/doc-detail/73916.html). Creating scaling group from launch template enable group automatically.
        /// </summary>
        [Output("launchTemplateId")]
        public Output<string?> LaunchTemplateId { get; private set; } = null!;

        /// <summary>
        /// The version number of the launch template. Valid values are the version number, `Latest`, or `Default`, Default value: `Default`.
        /// </summary>
        [Output("launchTemplateVersion")]
        public Output<string?> LaunchTemplateVersion { get; private set; } = null!;

        /// <summary>
        /// If a Server Load Balancer instance is specified in the scaling group, the scaling group automatically attaches its ECS instances to the Server Load Balancer instance.
        /// - The Server Load Balancer instance must be enabled.
        /// - At least one listener must be configured for each Server Load Balancer and it HealthCheck must be on. Otherwise, creation will fail (it may be useful to add a `depends_on` argument
        /// targeting your `alicloud.slb.Listener` in order to make sure the listener with its HealthCheck configuration is ready before creating your scaling group).
        /// - The Server Load Balancer instance attached with VPC-type ECS instances cannot be attached to the scaling group.
        /// - The default weight of an ECS instance attached to the Server Load Balancer instance is 50.
        /// </summary>
        [Output("loadbalancerIds")]
        public Output<ImmutableArray<string>> LoadbalancerIds { get; private set; } = null!;

        /// <summary>
        /// Maximum number of ECS instances in the scaling group. Value range: [0, 1000].
        /// </summary>
        [Output("maxSize")]
        public Output<int> MaxSize { get; private set; } = null!;

        /// <summary>
        /// Minimum number of ECS instances in the scaling group. Value range: [0, 1000].
        /// </summary>
        [Output("minSize")]
        public Output<int> MinSize { get; private set; } = null!;

        /// <summary>
        /// Multi-AZ scaling group ECS instance expansion and contraction strategy. PRIORITY, BALANCE or COST_OPTIMIZED(Available in 1.54.0+).
        /// </summary>
        [Output("multiAzPolicy")]
        public Output<string?> MultiAzPolicy { get; private set; } = null!;

        /// <summary>
        /// The minimum amount of the Auto Scaling group's capacity that must be fulfilled by On-Demand Instances. This base portion is provisioned first as your group scales.
        /// </summary>
        [Output("onDemandBaseCapacity")]
        public Output<int> OnDemandBaseCapacity { get; private set; } = null!;

        /// <summary>
        /// Controls the percentages of On-Demand Instances and Spot Instances for your additional capacity beyond OnDemandBaseCapacity.
        /// </summary>
        [Output("onDemandPercentageAboveBaseCapacity")]
        public Output<int> OnDemandPercentageAboveBaseCapacity { get; private set; } = null!;

        /// <summary>
        /// Set or unset instances within group into protected status.
        /// </summary>
        [Output("protectedInstances")]
        public Output<ImmutableArray<string>> ProtectedInstances { get; private set; } = null!;

        /// <summary>
        /// RemovalPolicy is used to select the ECS instances you want to remove from the scaling group when multiple candidates for removal exist. Optional values:
        /// - OldestInstance: removes the ECS instance that is added to the scaling group at the earliest point in time.
        /// - NewestInstance: removes the ECS instance that is added to the scaling group at the latest point in time.
        /// - OldestScalingConfiguration: removes the ECS instance that is created based on the earliest scaling configuration.
        /// - Default values: Default value of RemovalPolicy.1: OldestScalingConfiguration. Default value of RemovalPolicy.2: OldestInstance.
        /// </summary>
        [Output("removalPolicies")]
        public Output<ImmutableArray<string>> RemovalPolicies { get; private set; } = null!;

        /// <summary>
        /// Name shown for the scaling group, which must contain 2-64 characters (English or Chinese), starting with numbers, English letters or Chinese characters, and can contain numbers, underscores `_`, hyphens `-`, and decimal points `.`. If this parameter is not specified, the default value is ScalingGroupId.
        /// </summary>
        [Output("scalingGroupName")]
        public Output<string?> ScalingGroupName { get; private set; } = null!;

        /// <summary>
        /// The number of Spot pools to use to allocate your Spot capacity. The Spot pools is composed of instance types of lowest price.
        /// </summary>
        [Output("spotInstancePools")]
        public Output<int> SpotInstancePools { get; private set; } = null!;

        /// <summary>
        /// Whether to replace spot instances with newly created spot/onDemand instance when receive a spot recycling message.
        /// </summary>
        [Output("spotInstanceRemedy")]
        public Output<bool> SpotInstanceRemedy { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// - Key: It can be up to 64 characters in length. It cannot begin with "aliyun", "acs:", "http://", or "https://". It cannot be a null string.
        /// - Value: It can be up to 128 characters in length. It cannot begin with "aliyun", "acs:", "http://", or "https://". It can be a null string.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// It has been deprecated from version 1.7.1 and new field 'vswitch_ids' replaces it.
        /// </summary>
        [Output("vswitchId")]
        public Output<string?> VswitchId { get; private set; } = null!;

        /// <summary>
        /// List of virtual switch IDs in which the ecs instances to be launched.
        /// </summary>
        [Output("vswitchIds")]
        public Output<ImmutableArray<string>> VswitchIds { get; private set; } = null!;


        /// <summary>
        /// Create a ScalingGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ScalingGroup(string name, ScalingGroupArgs args, CustomResourceOptions? options = null)
            : base("alicloud:ess/scalingGroup:ScalingGroup", name, args ?? new ScalingGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ScalingGroup(string name, Input<string> id, ScalingGroupState? state = null, CustomResourceOptions? options = null)
            : base("alicloud:ess/scalingGroup:ScalingGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ScalingGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ScalingGroup Get(string name, Input<string> id, ScalingGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new ScalingGroup(name, id, state, options);
        }
    }

    public sealed class ScalingGroupArgs : global::Pulumi.ResourceArgs
    {
        [Input("dbInstanceIds")]
        private InputList<string>? _dbInstanceIds;

        /// <summary>
        /// If an RDS instance is specified in the scaling group, the scaling group automatically attaches the Intranet IP addresses of its ECS instances to the RDS access whitelist.
        /// - The specified RDS instance must be in running status.
        /// - The specified RDS instance’s whitelist must have room for more IP addresses.
        /// </summary>
        public InputList<string> DbInstanceIds
        {
            get => _dbInstanceIds ?? (_dbInstanceIds = new InputList<string>());
            set => _dbInstanceIds = value;
        }

        /// <summary>
        /// Default cool-down time (in seconds) of the scaling group. Value range: [0, 86400]. The default value is 300s.
        /// </summary>
        [Input("defaultCooldown")]
        public Input<int>? DefaultCooldown { get; set; }

        /// <summary>
        /// Expected number of ECS instances in the scaling group. Value range: [min_size, max_size].
        /// </summary>
        [Input("desiredCapacity")]
        public Input<int>? DesiredCapacity { get; set; }

        /// <summary>
        /// Specifies whether the scaling group deletion protection is enabled. `true` or `false`, Default value: `false`.
        /// </summary>
        [Input("groupDeletionProtection")]
        public Input<bool>? GroupDeletionProtection { get; set; }

        /// <summary>
        /// Resource type within scaling group. Optional values: ECS, ECI. Default to ECS.
        /// </summary>
        [Input("groupType")]
        public Input<string>? GroupType { get; set; }

        /// <summary>
        /// Resource type within scaling group. Optional values: ECS, NONE. Default to ECS.
        /// </summary>
        [Input("healthCheckType")]
        public Input<string>? HealthCheckType { get; set; }

        /// <summary>
        /// Instance launch template ID, scaling group obtains launch configuration from instance launch template, see [Launch Template](https://www.alibabacloud.com/help/doc-detail/73916.html). Creating scaling group from launch template enable group automatically.
        /// </summary>
        [Input("launchTemplateId")]
        public Input<string>? LaunchTemplateId { get; set; }

        /// <summary>
        /// The version number of the launch template. Valid values are the version number, `Latest`, or `Default`, Default value: `Default`.
        /// </summary>
        [Input("launchTemplateVersion")]
        public Input<string>? LaunchTemplateVersion { get; set; }

        [Input("loadbalancerIds")]
        private InputList<string>? _loadbalancerIds;

        /// <summary>
        /// If a Server Load Balancer instance is specified in the scaling group, the scaling group automatically attaches its ECS instances to the Server Load Balancer instance.
        /// - The Server Load Balancer instance must be enabled.
        /// - At least one listener must be configured for each Server Load Balancer and it HealthCheck must be on. Otherwise, creation will fail (it may be useful to add a `depends_on` argument
        /// targeting your `alicloud.slb.Listener` in order to make sure the listener with its HealthCheck configuration is ready before creating your scaling group).
        /// - The Server Load Balancer instance attached with VPC-type ECS instances cannot be attached to the scaling group.
        /// - The default weight of an ECS instance attached to the Server Load Balancer instance is 50.
        /// </summary>
        public InputList<string> LoadbalancerIds
        {
            get => _loadbalancerIds ?? (_loadbalancerIds = new InputList<string>());
            set => _loadbalancerIds = value;
        }

        /// <summary>
        /// Maximum number of ECS instances in the scaling group. Value range: [0, 1000].
        /// </summary>
        [Input("maxSize", required: true)]
        public Input<int> MaxSize { get; set; } = null!;

        /// <summary>
        /// Minimum number of ECS instances in the scaling group. Value range: [0, 1000].
        /// </summary>
        [Input("minSize", required: true)]
        public Input<int> MinSize { get; set; } = null!;

        /// <summary>
        /// Multi-AZ scaling group ECS instance expansion and contraction strategy. PRIORITY, BALANCE or COST_OPTIMIZED(Available in 1.54.0+).
        /// </summary>
        [Input("multiAzPolicy")]
        public Input<string>? MultiAzPolicy { get; set; }

        /// <summary>
        /// The minimum amount of the Auto Scaling group's capacity that must be fulfilled by On-Demand Instances. This base portion is provisioned first as your group scales.
        /// </summary>
        [Input("onDemandBaseCapacity")]
        public Input<int>? OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// Controls the percentages of On-Demand Instances and Spot Instances for your additional capacity beyond OnDemandBaseCapacity.
        /// </summary>
        [Input("onDemandPercentageAboveBaseCapacity")]
        public Input<int>? OnDemandPercentageAboveBaseCapacity { get; set; }

        [Input("protectedInstances")]
        private InputList<string>? _protectedInstances;

        /// <summary>
        /// Set or unset instances within group into protected status.
        /// </summary>
        public InputList<string> ProtectedInstances
        {
            get => _protectedInstances ?? (_protectedInstances = new InputList<string>());
            set => _protectedInstances = value;
        }

        [Input("removalPolicies")]
        private InputList<string>? _removalPolicies;

        /// <summary>
        /// RemovalPolicy is used to select the ECS instances you want to remove from the scaling group when multiple candidates for removal exist. Optional values:
        /// - OldestInstance: removes the ECS instance that is added to the scaling group at the earliest point in time.
        /// - NewestInstance: removes the ECS instance that is added to the scaling group at the latest point in time.
        /// - OldestScalingConfiguration: removes the ECS instance that is created based on the earliest scaling configuration.
        /// - Default values: Default value of RemovalPolicy.1: OldestScalingConfiguration. Default value of RemovalPolicy.2: OldestInstance.
        /// </summary>
        public InputList<string> RemovalPolicies
        {
            get => _removalPolicies ?? (_removalPolicies = new InputList<string>());
            set => _removalPolicies = value;
        }

        /// <summary>
        /// Name shown for the scaling group, which must contain 2-64 characters (English or Chinese), starting with numbers, English letters or Chinese characters, and can contain numbers, underscores `_`, hyphens `-`, and decimal points `.`. If this parameter is not specified, the default value is ScalingGroupId.
        /// </summary>
        [Input("scalingGroupName")]
        public Input<string>? ScalingGroupName { get; set; }

        /// <summary>
        /// The number of Spot pools to use to allocate your Spot capacity. The Spot pools is composed of instance types of lowest price.
        /// </summary>
        [Input("spotInstancePools")]
        public Input<int>? SpotInstancePools { get; set; }

        /// <summary>
        /// Whether to replace spot instances with newly created spot/onDemand instance when receive a spot recycling message.
        /// </summary>
        [Input("spotInstanceRemedy")]
        public Input<bool>? SpotInstanceRemedy { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// - Key: It can be up to 64 characters in length. It cannot begin with "aliyun", "acs:", "http://", or "https://". It cannot be a null string.
        /// - Value: It can be up to 128 characters in length. It cannot begin with "aliyun", "acs:", "http://", or "https://". It can be a null string.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// It has been deprecated from version 1.7.1 and new field 'vswitch_ids' replaces it.
        /// </summary>
        [Input("vswitchId")]
        public Input<string>? VswitchId { get; set; }

        [Input("vswitchIds")]
        private InputList<string>? _vswitchIds;

        /// <summary>
        /// List of virtual switch IDs in which the ecs instances to be launched.
        /// </summary>
        public InputList<string> VswitchIds
        {
            get => _vswitchIds ?? (_vswitchIds = new InputList<string>());
            set => _vswitchIds = value;
        }

        public ScalingGroupArgs()
        {
        }
        public static new ScalingGroupArgs Empty => new ScalingGroupArgs();
    }

    public sealed class ScalingGroupState : global::Pulumi.ResourceArgs
    {
        [Input("dbInstanceIds")]
        private InputList<string>? _dbInstanceIds;

        /// <summary>
        /// If an RDS instance is specified in the scaling group, the scaling group automatically attaches the Intranet IP addresses of its ECS instances to the RDS access whitelist.
        /// - The specified RDS instance must be in running status.
        /// - The specified RDS instance’s whitelist must have room for more IP addresses.
        /// </summary>
        public InputList<string> DbInstanceIds
        {
            get => _dbInstanceIds ?? (_dbInstanceIds = new InputList<string>());
            set => _dbInstanceIds = value;
        }

        /// <summary>
        /// Default cool-down time (in seconds) of the scaling group. Value range: [0, 86400]. The default value is 300s.
        /// </summary>
        [Input("defaultCooldown")]
        public Input<int>? DefaultCooldown { get; set; }

        /// <summary>
        /// Expected number of ECS instances in the scaling group. Value range: [min_size, max_size].
        /// </summary>
        [Input("desiredCapacity")]
        public Input<int>? DesiredCapacity { get; set; }

        /// <summary>
        /// Specifies whether the scaling group deletion protection is enabled. `true` or `false`, Default value: `false`.
        /// </summary>
        [Input("groupDeletionProtection")]
        public Input<bool>? GroupDeletionProtection { get; set; }

        /// <summary>
        /// Resource type within scaling group. Optional values: ECS, ECI. Default to ECS.
        /// </summary>
        [Input("groupType")]
        public Input<string>? GroupType { get; set; }

        /// <summary>
        /// Resource type within scaling group. Optional values: ECS, NONE. Default to ECS.
        /// </summary>
        [Input("healthCheckType")]
        public Input<string>? HealthCheckType { get; set; }

        /// <summary>
        /// Instance launch template ID, scaling group obtains launch configuration from instance launch template, see [Launch Template](https://www.alibabacloud.com/help/doc-detail/73916.html). Creating scaling group from launch template enable group automatically.
        /// </summary>
        [Input("launchTemplateId")]
        public Input<string>? LaunchTemplateId { get; set; }

        /// <summary>
        /// The version number of the launch template. Valid values are the version number, `Latest`, or `Default`, Default value: `Default`.
        /// </summary>
        [Input("launchTemplateVersion")]
        public Input<string>? LaunchTemplateVersion { get; set; }

        [Input("loadbalancerIds")]
        private InputList<string>? _loadbalancerIds;

        /// <summary>
        /// If a Server Load Balancer instance is specified in the scaling group, the scaling group automatically attaches its ECS instances to the Server Load Balancer instance.
        /// - The Server Load Balancer instance must be enabled.
        /// - At least one listener must be configured for each Server Load Balancer and it HealthCheck must be on. Otherwise, creation will fail (it may be useful to add a `depends_on` argument
        /// targeting your `alicloud.slb.Listener` in order to make sure the listener with its HealthCheck configuration is ready before creating your scaling group).
        /// - The Server Load Balancer instance attached with VPC-type ECS instances cannot be attached to the scaling group.
        /// - The default weight of an ECS instance attached to the Server Load Balancer instance is 50.
        /// </summary>
        public InputList<string> LoadbalancerIds
        {
            get => _loadbalancerIds ?? (_loadbalancerIds = new InputList<string>());
            set => _loadbalancerIds = value;
        }

        /// <summary>
        /// Maximum number of ECS instances in the scaling group. Value range: [0, 1000].
        /// </summary>
        [Input("maxSize")]
        public Input<int>? MaxSize { get; set; }

        /// <summary>
        /// Minimum number of ECS instances in the scaling group. Value range: [0, 1000].
        /// </summary>
        [Input("minSize")]
        public Input<int>? MinSize { get; set; }

        /// <summary>
        /// Multi-AZ scaling group ECS instance expansion and contraction strategy. PRIORITY, BALANCE or COST_OPTIMIZED(Available in 1.54.0+).
        /// </summary>
        [Input("multiAzPolicy")]
        public Input<string>? MultiAzPolicy { get; set; }

        /// <summary>
        /// The minimum amount of the Auto Scaling group's capacity that must be fulfilled by On-Demand Instances. This base portion is provisioned first as your group scales.
        /// </summary>
        [Input("onDemandBaseCapacity")]
        public Input<int>? OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// Controls the percentages of On-Demand Instances and Spot Instances for your additional capacity beyond OnDemandBaseCapacity.
        /// </summary>
        [Input("onDemandPercentageAboveBaseCapacity")]
        public Input<int>? OnDemandPercentageAboveBaseCapacity { get; set; }

        [Input("protectedInstances")]
        private InputList<string>? _protectedInstances;

        /// <summary>
        /// Set or unset instances within group into protected status.
        /// </summary>
        public InputList<string> ProtectedInstances
        {
            get => _protectedInstances ?? (_protectedInstances = new InputList<string>());
            set => _protectedInstances = value;
        }

        [Input("removalPolicies")]
        private InputList<string>? _removalPolicies;

        /// <summary>
        /// RemovalPolicy is used to select the ECS instances you want to remove from the scaling group when multiple candidates for removal exist. Optional values:
        /// - OldestInstance: removes the ECS instance that is added to the scaling group at the earliest point in time.
        /// - NewestInstance: removes the ECS instance that is added to the scaling group at the latest point in time.
        /// - OldestScalingConfiguration: removes the ECS instance that is created based on the earliest scaling configuration.
        /// - Default values: Default value of RemovalPolicy.1: OldestScalingConfiguration. Default value of RemovalPolicy.2: OldestInstance.
        /// </summary>
        public InputList<string> RemovalPolicies
        {
            get => _removalPolicies ?? (_removalPolicies = new InputList<string>());
            set => _removalPolicies = value;
        }

        /// <summary>
        /// Name shown for the scaling group, which must contain 2-64 characters (English or Chinese), starting with numbers, English letters or Chinese characters, and can contain numbers, underscores `_`, hyphens `-`, and decimal points `.`. If this parameter is not specified, the default value is ScalingGroupId.
        /// </summary>
        [Input("scalingGroupName")]
        public Input<string>? ScalingGroupName { get; set; }

        /// <summary>
        /// The number of Spot pools to use to allocate your Spot capacity. The Spot pools is composed of instance types of lowest price.
        /// </summary>
        [Input("spotInstancePools")]
        public Input<int>? SpotInstancePools { get; set; }

        /// <summary>
        /// Whether to replace spot instances with newly created spot/onDemand instance when receive a spot recycling message.
        /// </summary>
        [Input("spotInstanceRemedy")]
        public Input<bool>? SpotInstanceRemedy { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// - Key: It can be up to 64 characters in length. It cannot begin with "aliyun", "acs:", "http://", or "https://". It cannot be a null string.
        /// - Value: It can be up to 128 characters in length. It cannot begin with "aliyun", "acs:", "http://", or "https://". It can be a null string.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// It has been deprecated from version 1.7.1 and new field 'vswitch_ids' replaces it.
        /// </summary>
        [Input("vswitchId")]
        public Input<string>? VswitchId { get; set; }

        [Input("vswitchIds")]
        private InputList<string>? _vswitchIds;

        /// <summary>
        /// List of virtual switch IDs in which the ecs instances to be launched.
        /// </summary>
        public InputList<string> VswitchIds
        {
            get => _vswitchIds ?? (_vswitchIds = new InputList<string>());
            set => _vswitchIds = value;
        }

        public ScalingGroupState()
        {
        }
        public static new ScalingGroupState Empty => new ScalingGroupState();
    }
}