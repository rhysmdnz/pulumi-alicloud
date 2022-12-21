// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Ecs
{
    /// <summary>
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using AliCloud = Pulumi.AliCloud;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var images = AliCloud.Ecs.GetImages.Invoke(new()
    ///     {
    ///         Owners = "system",
    ///     });
    /// 
    ///     var instances = AliCloud.Ecs.GetInstances.Invoke();
    /// 
    ///     var template = new AliCloud.Ecs.LaunchTemplate("template", new()
    ///     {
    ///         Description = "test1",
    ///         ImageId = images.Apply(getImagesResult =&gt; getImagesResult.Images[0]?.Id),
    ///         HostName = "tf-test-host",
    ///         InstanceChargeType = "PrePaid",
    ///         InstanceName = "tf-instance-name",
    ///         InstanceType = instances.Apply(getInstancesResult =&gt; getInstancesResult.Instances[0]?.InstanceType),
    ///         InternetChargeType = "PayByBandwidth",
    ///         InternetMaxBandwidthIn = 5,
    ///         InternetMaxBandwidthOut = 0,
    ///         IoOptimized = "none",
    ///         KeyPairName = "test-key-pair",
    ///         RamRoleName = "xxxxx",
    ///         NetworkType = "vpc",
    ///         SecurityEnhancementStrategy = "Active",
    ///         SpotPriceLimit = 5,
    ///         SpotStrategy = "SpotWithPriceLimit",
    ///         SecurityGroupId = "sg-zxcvj0lasdf102350asdf9a",
    ///         SystemDiskCategory = "cloud_ssd",
    ///         SystemDiskDescription = "test disk",
    ///         SystemDiskName = "hello",
    ///         SystemDiskSize = 40,
    ///         ResourceGroupId = "rg-zkdfjahg9zxncv0",
    ///         Userdata = "xxxxxxxxxxxxxx",
    ///         VswitchId = "sw-ljkngaksdjfj0nnasdf",
    ///         VpcId = "vpc-asdfnbg0as8dfk1nb2",
    ///         ZoneId = "beijing-a",
    ///         Tags = 
    ///         {
    ///             { "tag1", "hello" },
    ///             { "tag2", "world" },
    ///         },
    ///         NetworkInterfaces = new AliCloud.Ecs.Inputs.LaunchTemplateNetworkInterfacesArgs
    ///         {
    ///             Name = "eth0",
    ///             Description = "hello1",
    ///             PrimaryIp = "10.0.0.2",
    ///             SecurityGroupId = "xxxx",
    ///             VswitchId = "xxxxxxx",
    ///         },
    ///         DataDisks = new[]
    ///         {
    ///             new AliCloud.Ecs.Inputs.LaunchTemplateDataDiskArgs
    ///             {
    ///                 Name = "disk1",
    ///                 Description = "test1",
    ///             },
    ///             new AliCloud.Ecs.Inputs.LaunchTemplateDataDiskArgs
    ///             {
    ///                 Name = "disk2",
    ///                 Description = "test2",
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// Launch Template can be imported using the id, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import alicloud:ecs/launchTemplate:LaunchTemplate lt lt-abc1234567890000
    /// ```
    /// </summary>
    [AliCloudResourceType("alicloud:ecs/launchTemplate:LaunchTemplate")]
    public partial class LaunchTemplate : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Instance auto release time. The time is presented using the ISO8601 standard and in UTC time. The format is  YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [Output("autoReleaseTime")]
        public Output<string?> AutoReleaseTime { get; private set; } = null!;

        /// <summary>
        /// The list of data disks created with instance.
        /// </summary>
        [Output("dataDisks")]
        public Output<ImmutableArray<Outputs.LaunchTemplateDataDisk>> DataDisks { get; private set; } = null!;

        [Output("deploymentSetId")]
        public Output<string?> DeploymentSetId { get; private set; } = null!;

        /// <summary>
        /// The description of the data disk.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("enableVmOsConfig")]
        public Output<bool?> EnableVmOsConfig { get; private set; } = null!;

        /// <summary>
        /// Instance host name.It cannot start or end with a period (.) or a hyphen (-) and it cannot have two or more consecutive periods (.) or hyphens (-).For Windows: The host name can be [2, 15] characters in length. It can contain A-Z, a-z, numbers, periods (.), and hyphens (-). It cannot only contain numbers. For other operating systems: The host name can be [2, 64] characters in length. It can be segments separated by periods (.). It can contain A-Z, a-z, numbers, and hyphens (-).
        /// </summary>
        [Output("hostName")]
        public Output<string?> HostName { get; private set; } = null!;

        /// <summary>
        /// Image ID.
        /// </summary>
        [Output("imageId")]
        public Output<string?> ImageId { get; private set; } = null!;

        [Output("imageOwnerAlias")]
        public Output<string?> ImageOwnerAlias { get; private set; } = null!;

        /// <summary>
        /// Billing methods. Optional values:
        /// - PrePaid: Monthly, or annual subscription. Make sure that your registered credit card is invalid or you have insufficient balance in your PayPal account. Otherwise, InvalidPayMethod error may occur.
        /// - PostPaid: Pay-As-You-Go.
        /// </summary>
        [Output("instanceChargeType")]
        public Output<string?> InstanceChargeType { get; private set; } = null!;

        /// <summary>
        /// The name of the instance. The name is a string of 2 to 128 characters. It must begin with an English or a Chinese character. It can contain A-Z, a-z, Chinese characters, numbers, periods (.), colons (:), underscores (_), and hyphens (-).
        /// </summary>
        [Output("instanceName")]
        public Output<string?> InstanceName { get; private set; } = null!;

        /// <summary>
        /// Instance type. For more information, call resource_alicloud_instances to obtain the latest instance type list.
        /// </summary>
        [Output("instanceType")]
        public Output<string?> InstanceType { get; private set; } = null!;

        /// <summary>
        /// Internet bandwidth billing method. Optional values: `PayByTraffic` | `PayByBandwidth`.
        /// </summary>
        [Output("internetChargeType")]
        public Output<string?> InternetChargeType { get; private set; } = null!;

        /// <summary>
        /// The maximum inbound bandwidth from the Internet network, measured in Mbit/s. Value range: [1, 200].
        /// </summary>
        [Output("internetMaxBandwidthIn")]
        public Output<int> InternetMaxBandwidthIn { get; private set; } = null!;

        /// <summary>
        /// Maximum outbound bandwidth from the Internet, its unit of measurement is Mbit/s. Value range: [0, 100].
        /// </summary>
        [Output("internetMaxBandwidthOut")]
        public Output<int?> InternetMaxBandwidthOut { get; private set; } = null!;

        /// <summary>
        /// Whether it is an I/O-optimized instance or not. Optional values:
        /// - none
        /// - optimized
        /// </summary>
        [Output("ioOptimized")]
        public Output<string?> IoOptimized { get; private set; } = null!;

        /// <summary>
        /// The name of the key pair.
        /// - Ignore this parameter for Windows instances. It is null by default. Even if you enter this parameter, only the  Password content is used.
        /// - The password logon method for Linux instances is set to forbidden upon initialization.
        /// </summary>
        [Output("keyPairName")]
        public Output<string?> KeyPairName { get; private set; } = null!;

        [Output("launchTemplateName")]
        public Output<string> LaunchTemplateName { get; private set; } = null!;

        /// <summary>
        /// The name of the data disk.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The list of network interfaces created with instance.
        /// </summary>
        [Output("networkInterfaces")]
        public Output<Outputs.LaunchTemplateNetworkInterfaces?> NetworkInterfaces { get; private set; } = null!;

        /// <summary>
        /// Network type of the instance. Value options: `classic` | `vpc`.
        /// </summary>
        [Output("networkType")]
        public Output<string?> NetworkType { get; private set; } = null!;

        [Output("passwordInherit")]
        public Output<bool?> PasswordInherit { get; private set; } = null!;

        [Output("period")]
        public Output<int?> Period { get; private set; } = null!;

        [Output("privateIpAddress")]
        public Output<string?> PrivateIpAddress { get; private set; } = null!;

        /// <summary>
        /// The RAM role name of the instance. You can use the RAM API ListRoles to query instance RAM role names.
        /// </summary>
        [Output("ramRoleName")]
        public Output<string?> RamRoleName { get; private set; } = null!;

        [Output("resourceGroupId")]
        public Output<string?> ResourceGroupId { get; private set; } = null!;

        /// <summary>
        /// Whether or not to activate the security enhancement feature and install network security software free of charge. Optional values: Active | Deactive.
        /// </summary>
        [Output("securityEnhancementStrategy")]
        public Output<string?> SecurityEnhancementStrategy { get; private set; } = null!;

        /// <summary>
        /// The security group ID must be one in the same VPC.
        /// </summary>
        [Output("securityGroupId")]
        public Output<string?> SecurityGroupId { get; private set; } = null!;

        [Output("securityGroupIds")]
        public Output<ImmutableArray<string>> SecurityGroupIds { get; private set; } = null!;

        [Output("spotDuration")]
        public Output<string?> SpotDuration { get; private set; } = null!;

        /// <summary>
        /// -(Optional) 	Sets the maximum hourly instance price. Supports up to three decimal places.
        /// </summary>
        [Output("spotPriceLimit")]
        public Output<double?> SpotPriceLimit { get; private set; } = null!;

        /// <summary>
        /// The spot strategy for a Pay-As-You-Go instance. This parameter is valid and required only when InstanceChargeType is set to PostPaid. Value range:
        /// - NoSpot: Normal Pay-As-You-Go instance.
        /// - SpotWithPriceLimit: Sets the maximum price for a spot instance.
        /// - SpotAsPriceGo: The system automatically calculates the price. The maximum value is the Pay-As-You-Go price.
        /// </summary>
        [Output("spotStrategy")]
        public Output<string?> SpotStrategy { get; private set; } = null!;

        [Output("systemDisk")]
        public Output<Outputs.LaunchTemplateSystemDisk> SystemDisk { get; private set; } = null!;

        /// <summary>
        /// The category of the system disk. System disk type. Optional values:
        /// - cloud: Basic cloud disk.
        /// - cloud_efficiency: Ultra cloud disk.
        /// - cloud_ssd: SSD cloud Disks.
        /// - ephemeral_ssd: local SSD Disks
        /// - cloud_essd: ESSD cloud Disks.
        /// </summary>
        [Output("systemDiskCategory")]
        public Output<string> SystemDiskCategory { get; private set; } = null!;

        /// <summary>
        /// System disk description. It cannot begin with http:// or https://.
        /// </summary>
        [Output("systemDiskDescription")]
        public Output<string> SystemDiskDescription { get; private set; } = null!;

        /// <summary>
        /// System disk name. The name is a string of 2 to 128 characters. It must begin with an English or a Chinese character. It can contain A-Z, a-z, Chinese characters, numbers, periods (.), colons (:), underscores (_), and hyphens (-).
        /// </summary>
        [Output("systemDiskName")]
        public Output<string> SystemDiskName { get; private set; } = null!;

        /// <summary>
        /// Size of the system disk, measured in GB. Value range: [20, 500].
        /// </summary>
        [Output("systemDiskSize")]
        public Output<int> SystemDiskSize { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// - Key: It can be up to 64 characters in length. It cannot begin with "aliyun", "acs:", "http://", or "https://". It cannot be a null string.
        /// - Value: It can be up to 128 characters in length. It cannot begin with "aliyun", "acs:", "http://", or "https://". It can be a null string.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        [Output("templateResourceGroupId")]
        public Output<string?> TemplateResourceGroupId { get; private set; } = null!;

        [Output("templateTags")]
        public Output<ImmutableDictionary<string, object>?> TemplateTags { get; private set; } = null!;

        [Output("userData")]
        public Output<string> UserData { get; private set; } = null!;

        /// <summary>
        /// User data of the instance, which is Base64-encoded. Size of the raw data cannot exceed 16 KB.
        /// </summary>
        [Output("userdata")]
        public Output<string> Userdata { get; private set; } = null!;

        [Output("versionDescription")]
        public Output<string?> VersionDescription { get; private set; } = null!;

        [Output("vpcId")]
        public Output<string> VpcId { get; private set; } = null!;

        /// <summary>
        /// The VSwitch ID for ENI. The instance must be in the same zone of the same VPC network as the ENI, but they may belong to different VSwitches.
        /// </summary>
        [Output("vswitchId")]
        public Output<string?> VswitchId { get; private set; } = null!;

        /// <summary>
        /// The zone ID of the instance.
        /// </summary>
        [Output("zoneId")]
        public Output<string> ZoneId { get; private set; } = null!;


        /// <summary>
        /// Create a LaunchTemplate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LaunchTemplate(string name, LaunchTemplateArgs? args = null, CustomResourceOptions? options = null)
            : base("alicloud:ecs/launchTemplate:LaunchTemplate", name, args ?? new LaunchTemplateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LaunchTemplate(string name, Input<string> id, LaunchTemplateState? state = null, CustomResourceOptions? options = null)
            : base("alicloud:ecs/launchTemplate:LaunchTemplate", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LaunchTemplate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LaunchTemplate Get(string name, Input<string> id, LaunchTemplateState? state = null, CustomResourceOptions? options = null)
        {
            return new LaunchTemplate(name, id, state, options);
        }
    }

    public sealed class LaunchTemplateArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance auto release time. The time is presented using the ISO8601 standard and in UTC time. The format is  YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [Input("autoReleaseTime")]
        public Input<string>? AutoReleaseTime { get; set; }

        [Input("dataDisks")]
        private InputList<Inputs.LaunchTemplateDataDiskArgs>? _dataDisks;

        /// <summary>
        /// The list of data disks created with instance.
        /// </summary>
        public InputList<Inputs.LaunchTemplateDataDiskArgs> DataDisks
        {
            get => _dataDisks ?? (_dataDisks = new InputList<Inputs.LaunchTemplateDataDiskArgs>());
            set => _dataDisks = value;
        }

        [Input("deploymentSetId")]
        public Input<string>? DeploymentSetId { get; set; }

        /// <summary>
        /// The description of the data disk.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("enableVmOsConfig")]
        public Input<bool>? EnableVmOsConfig { get; set; }

        /// <summary>
        /// Instance host name.It cannot start or end with a period (.) or a hyphen (-) and it cannot have two or more consecutive periods (.) or hyphens (-).For Windows: The host name can be [2, 15] characters in length. It can contain A-Z, a-z, numbers, periods (.), and hyphens (-). It cannot only contain numbers. For other operating systems: The host name can be [2, 64] characters in length. It can be segments separated by periods (.). It can contain A-Z, a-z, numbers, and hyphens (-).
        /// </summary>
        [Input("hostName")]
        public Input<string>? HostName { get; set; }

        /// <summary>
        /// Image ID.
        /// </summary>
        [Input("imageId")]
        public Input<string>? ImageId { get; set; }

        [Input("imageOwnerAlias")]
        public Input<string>? ImageOwnerAlias { get; set; }

        /// <summary>
        /// Billing methods. Optional values:
        /// - PrePaid: Monthly, or annual subscription. Make sure that your registered credit card is invalid or you have insufficient balance in your PayPal account. Otherwise, InvalidPayMethod error may occur.
        /// - PostPaid: Pay-As-You-Go.
        /// </summary>
        [Input("instanceChargeType")]
        public Input<string>? InstanceChargeType { get; set; }

        /// <summary>
        /// The name of the instance. The name is a string of 2 to 128 characters. It must begin with an English or a Chinese character. It can contain A-Z, a-z, Chinese characters, numbers, periods (.), colons (:), underscores (_), and hyphens (-).
        /// </summary>
        [Input("instanceName")]
        public Input<string>? InstanceName { get; set; }

        /// <summary>
        /// Instance type. For more information, call resource_alicloud_instances to obtain the latest instance type list.
        /// </summary>
        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        /// <summary>
        /// Internet bandwidth billing method. Optional values: `PayByTraffic` | `PayByBandwidth`.
        /// </summary>
        [Input("internetChargeType")]
        public Input<string>? InternetChargeType { get; set; }

        /// <summary>
        /// The maximum inbound bandwidth from the Internet network, measured in Mbit/s. Value range: [1, 200].
        /// </summary>
        [Input("internetMaxBandwidthIn")]
        public Input<int>? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// Maximum outbound bandwidth from the Internet, its unit of measurement is Mbit/s. Value range: [0, 100].
        /// </summary>
        [Input("internetMaxBandwidthOut")]
        public Input<int>? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// Whether it is an I/O-optimized instance or not. Optional values:
        /// - none
        /// - optimized
        /// </summary>
        [Input("ioOptimized")]
        public Input<string>? IoOptimized { get; set; }

        /// <summary>
        /// The name of the key pair.
        /// - Ignore this parameter for Windows instances. It is null by default. Even if you enter this parameter, only the  Password content is used.
        /// - The password logon method for Linux instances is set to forbidden upon initialization.
        /// </summary>
        [Input("keyPairName")]
        public Input<string>? KeyPairName { get; set; }

        [Input("launchTemplateName")]
        public Input<string>? LaunchTemplateName { get; set; }

        /// <summary>
        /// The name of the data disk.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The list of network interfaces created with instance.
        /// </summary>
        [Input("networkInterfaces")]
        public Input<Inputs.LaunchTemplateNetworkInterfacesArgs>? NetworkInterfaces { get; set; }

        /// <summary>
        /// Network type of the instance. Value options: `classic` | `vpc`.
        /// </summary>
        [Input("networkType")]
        public Input<string>? NetworkType { get; set; }

        [Input("passwordInherit")]
        public Input<bool>? PasswordInherit { get; set; }

        [Input("period")]
        public Input<int>? Period { get; set; }

        [Input("privateIpAddress")]
        public Input<string>? PrivateIpAddress { get; set; }

        /// <summary>
        /// The RAM role name of the instance. You can use the RAM API ListRoles to query instance RAM role names.
        /// </summary>
        [Input("ramRoleName")]
        public Input<string>? RamRoleName { get; set; }

        [Input("resourceGroupId")]
        public Input<string>? ResourceGroupId { get; set; }

        /// <summary>
        /// Whether or not to activate the security enhancement feature and install network security software free of charge. Optional values: Active | Deactive.
        /// </summary>
        [Input("securityEnhancementStrategy")]
        public Input<string>? SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// The security group ID must be one in the same VPC.
        /// </summary>
        [Input("securityGroupId")]
        public Input<string>? SecurityGroupId { get; set; }

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        [Input("spotDuration")]
        public Input<string>? SpotDuration { get; set; }

        /// <summary>
        /// -(Optional) 	Sets the maximum hourly instance price. Supports up to three decimal places.
        /// </summary>
        [Input("spotPriceLimit")]
        public Input<double>? SpotPriceLimit { get; set; }

        /// <summary>
        /// The spot strategy for a Pay-As-You-Go instance. This parameter is valid and required only when InstanceChargeType is set to PostPaid. Value range:
        /// - NoSpot: Normal Pay-As-You-Go instance.
        /// - SpotWithPriceLimit: Sets the maximum price for a spot instance.
        /// - SpotAsPriceGo: The system automatically calculates the price. The maximum value is the Pay-As-You-Go price.
        /// </summary>
        [Input("spotStrategy")]
        public Input<string>? SpotStrategy { get; set; }

        [Input("systemDisk")]
        public Input<Inputs.LaunchTemplateSystemDiskArgs>? SystemDisk { get; set; }

        /// <summary>
        /// The category of the system disk. System disk type. Optional values:
        /// - cloud: Basic cloud disk.
        /// - cloud_efficiency: Ultra cloud disk.
        /// - cloud_ssd: SSD cloud Disks.
        /// - ephemeral_ssd: local SSD Disks
        /// - cloud_essd: ESSD cloud Disks.
        /// </summary>
        [Input("systemDiskCategory")]
        public Input<string>? SystemDiskCategory { get; set; }

        /// <summary>
        /// System disk description. It cannot begin with http:// or https://.
        /// </summary>
        [Input("systemDiskDescription")]
        public Input<string>? SystemDiskDescription { get; set; }

        /// <summary>
        /// System disk name. The name is a string of 2 to 128 characters. It must begin with an English or a Chinese character. It can contain A-Z, a-z, Chinese characters, numbers, periods (.), colons (:), underscores (_), and hyphens (-).
        /// </summary>
        [Input("systemDiskName")]
        public Input<string>? SystemDiskName { get; set; }

        /// <summary>
        /// Size of the system disk, measured in GB. Value range: [20, 500].
        /// </summary>
        [Input("systemDiskSize")]
        public Input<int>? SystemDiskSize { get; set; }

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

        [Input("templateResourceGroupId")]
        public Input<string>? TemplateResourceGroupId { get; set; }

        [Input("templateTags")]
        private InputMap<object>? _templateTags;
        public InputMap<object> TemplateTags
        {
            get => _templateTags ?? (_templateTags = new InputMap<object>());
            set => _templateTags = value;
        }

        [Input("userData")]
        public Input<string>? UserData { get; set; }

        /// <summary>
        /// User data of the instance, which is Base64-encoded. Size of the raw data cannot exceed 16 KB.
        /// </summary>
        [Input("userdata")]
        public Input<string>? Userdata { get; set; }

        [Input("versionDescription")]
        public Input<string>? VersionDescription { get; set; }

        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        /// <summary>
        /// The VSwitch ID for ENI. The instance must be in the same zone of the same VPC network as the ENI, but they may belong to different VSwitches.
        /// </summary>
        [Input("vswitchId")]
        public Input<string>? VswitchId { get; set; }

        /// <summary>
        /// The zone ID of the instance.
        /// </summary>
        [Input("zoneId")]
        public Input<string>? ZoneId { get; set; }

        public LaunchTemplateArgs()
        {
        }
        public static new LaunchTemplateArgs Empty => new LaunchTemplateArgs();
    }

    public sealed class LaunchTemplateState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance auto release time. The time is presented using the ISO8601 standard and in UTC time. The format is  YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [Input("autoReleaseTime")]
        public Input<string>? AutoReleaseTime { get; set; }

        [Input("dataDisks")]
        private InputList<Inputs.LaunchTemplateDataDiskGetArgs>? _dataDisks;

        /// <summary>
        /// The list of data disks created with instance.
        /// </summary>
        public InputList<Inputs.LaunchTemplateDataDiskGetArgs> DataDisks
        {
            get => _dataDisks ?? (_dataDisks = new InputList<Inputs.LaunchTemplateDataDiskGetArgs>());
            set => _dataDisks = value;
        }

        [Input("deploymentSetId")]
        public Input<string>? DeploymentSetId { get; set; }

        /// <summary>
        /// The description of the data disk.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("enableVmOsConfig")]
        public Input<bool>? EnableVmOsConfig { get; set; }

        /// <summary>
        /// Instance host name.It cannot start or end with a period (.) or a hyphen (-) and it cannot have two or more consecutive periods (.) or hyphens (-).For Windows: The host name can be [2, 15] characters in length. It can contain A-Z, a-z, numbers, periods (.), and hyphens (-). It cannot only contain numbers. For other operating systems: The host name can be [2, 64] characters in length. It can be segments separated by periods (.). It can contain A-Z, a-z, numbers, and hyphens (-).
        /// </summary>
        [Input("hostName")]
        public Input<string>? HostName { get; set; }

        /// <summary>
        /// Image ID.
        /// </summary>
        [Input("imageId")]
        public Input<string>? ImageId { get; set; }

        [Input("imageOwnerAlias")]
        public Input<string>? ImageOwnerAlias { get; set; }

        /// <summary>
        /// Billing methods. Optional values:
        /// - PrePaid: Monthly, or annual subscription. Make sure that your registered credit card is invalid or you have insufficient balance in your PayPal account. Otherwise, InvalidPayMethod error may occur.
        /// - PostPaid: Pay-As-You-Go.
        /// </summary>
        [Input("instanceChargeType")]
        public Input<string>? InstanceChargeType { get; set; }

        /// <summary>
        /// The name of the instance. The name is a string of 2 to 128 characters. It must begin with an English or a Chinese character. It can contain A-Z, a-z, Chinese characters, numbers, periods (.), colons (:), underscores (_), and hyphens (-).
        /// </summary>
        [Input("instanceName")]
        public Input<string>? InstanceName { get; set; }

        /// <summary>
        /// Instance type. For more information, call resource_alicloud_instances to obtain the latest instance type list.
        /// </summary>
        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        /// <summary>
        /// Internet bandwidth billing method. Optional values: `PayByTraffic` | `PayByBandwidth`.
        /// </summary>
        [Input("internetChargeType")]
        public Input<string>? InternetChargeType { get; set; }

        /// <summary>
        /// The maximum inbound bandwidth from the Internet network, measured in Mbit/s. Value range: [1, 200].
        /// </summary>
        [Input("internetMaxBandwidthIn")]
        public Input<int>? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// Maximum outbound bandwidth from the Internet, its unit of measurement is Mbit/s. Value range: [0, 100].
        /// </summary>
        [Input("internetMaxBandwidthOut")]
        public Input<int>? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// Whether it is an I/O-optimized instance or not. Optional values:
        /// - none
        /// - optimized
        /// </summary>
        [Input("ioOptimized")]
        public Input<string>? IoOptimized { get; set; }

        /// <summary>
        /// The name of the key pair.
        /// - Ignore this parameter for Windows instances. It is null by default. Even if you enter this parameter, only the  Password content is used.
        /// - The password logon method for Linux instances is set to forbidden upon initialization.
        /// </summary>
        [Input("keyPairName")]
        public Input<string>? KeyPairName { get; set; }

        [Input("launchTemplateName")]
        public Input<string>? LaunchTemplateName { get; set; }

        /// <summary>
        /// The name of the data disk.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The list of network interfaces created with instance.
        /// </summary>
        [Input("networkInterfaces")]
        public Input<Inputs.LaunchTemplateNetworkInterfacesGetArgs>? NetworkInterfaces { get; set; }

        /// <summary>
        /// Network type of the instance. Value options: `classic` | `vpc`.
        /// </summary>
        [Input("networkType")]
        public Input<string>? NetworkType { get; set; }

        [Input("passwordInherit")]
        public Input<bool>? PasswordInherit { get; set; }

        [Input("period")]
        public Input<int>? Period { get; set; }

        [Input("privateIpAddress")]
        public Input<string>? PrivateIpAddress { get; set; }

        /// <summary>
        /// The RAM role name of the instance. You can use the RAM API ListRoles to query instance RAM role names.
        /// </summary>
        [Input("ramRoleName")]
        public Input<string>? RamRoleName { get; set; }

        [Input("resourceGroupId")]
        public Input<string>? ResourceGroupId { get; set; }

        /// <summary>
        /// Whether or not to activate the security enhancement feature and install network security software free of charge. Optional values: Active | Deactive.
        /// </summary>
        [Input("securityEnhancementStrategy")]
        public Input<string>? SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// The security group ID must be one in the same VPC.
        /// </summary>
        [Input("securityGroupId")]
        public Input<string>? SecurityGroupId { get; set; }

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        [Input("spotDuration")]
        public Input<string>? SpotDuration { get; set; }

        /// <summary>
        /// -(Optional) 	Sets the maximum hourly instance price. Supports up to three decimal places.
        /// </summary>
        [Input("spotPriceLimit")]
        public Input<double>? SpotPriceLimit { get; set; }

        /// <summary>
        /// The spot strategy for a Pay-As-You-Go instance. This parameter is valid and required only when InstanceChargeType is set to PostPaid. Value range:
        /// - NoSpot: Normal Pay-As-You-Go instance.
        /// - SpotWithPriceLimit: Sets the maximum price for a spot instance.
        /// - SpotAsPriceGo: The system automatically calculates the price. The maximum value is the Pay-As-You-Go price.
        /// </summary>
        [Input("spotStrategy")]
        public Input<string>? SpotStrategy { get; set; }

        [Input("systemDisk")]
        public Input<Inputs.LaunchTemplateSystemDiskGetArgs>? SystemDisk { get; set; }

        /// <summary>
        /// The category of the system disk. System disk type. Optional values:
        /// - cloud: Basic cloud disk.
        /// - cloud_efficiency: Ultra cloud disk.
        /// - cloud_ssd: SSD cloud Disks.
        /// - ephemeral_ssd: local SSD Disks
        /// - cloud_essd: ESSD cloud Disks.
        /// </summary>
        [Input("systemDiskCategory")]
        public Input<string>? SystemDiskCategory { get; set; }

        /// <summary>
        /// System disk description. It cannot begin with http:// or https://.
        /// </summary>
        [Input("systemDiskDescription")]
        public Input<string>? SystemDiskDescription { get; set; }

        /// <summary>
        /// System disk name. The name is a string of 2 to 128 characters. It must begin with an English or a Chinese character. It can contain A-Z, a-z, Chinese characters, numbers, periods (.), colons (:), underscores (_), and hyphens (-).
        /// </summary>
        [Input("systemDiskName")]
        public Input<string>? SystemDiskName { get; set; }

        /// <summary>
        /// Size of the system disk, measured in GB. Value range: [20, 500].
        /// </summary>
        [Input("systemDiskSize")]
        public Input<int>? SystemDiskSize { get; set; }

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

        [Input("templateResourceGroupId")]
        public Input<string>? TemplateResourceGroupId { get; set; }

        [Input("templateTags")]
        private InputMap<object>? _templateTags;
        public InputMap<object> TemplateTags
        {
            get => _templateTags ?? (_templateTags = new InputMap<object>());
            set => _templateTags = value;
        }

        [Input("userData")]
        public Input<string>? UserData { get; set; }

        /// <summary>
        /// User data of the instance, which is Base64-encoded. Size of the raw data cannot exceed 16 KB.
        /// </summary>
        [Input("userdata")]
        public Input<string>? Userdata { get; set; }

        [Input("versionDescription")]
        public Input<string>? VersionDescription { get; set; }

        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        /// <summary>
        /// The VSwitch ID for ENI. The instance must be in the same zone of the same VPC network as the ENI, but they may belong to different VSwitches.
        /// </summary>
        [Input("vswitchId")]
        public Input<string>? VswitchId { get; set; }

        /// <summary>
        /// The zone ID of the instance.
        /// </summary>
        [Input("zoneId")]
        public Input<string>? ZoneId { get; set; }

        public LaunchTemplateState()
        {
        }
        public static new LaunchTemplateState Empty => new LaunchTemplateState();
    }
}