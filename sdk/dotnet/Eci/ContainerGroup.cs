// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Eci
{
    /// <summary>
    /// Provides ECI Container Group resource.
    /// 
    /// For information about ECI Container Group and how to use it, see [What is Container Group](https://www.alibabacloud.com/help/en/doc-detail/90341.htm).
    /// 
    /// &gt; **NOTE:** Available in v1.111.0+.
    /// 
    /// ## Example Usage
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
    ///     var example = new AliCloud.Eci.ContainerGroup("example", new()
    ///     {
    ///         ContainerGroupName = "tf-testacc-eci-gruop",
    ///         Cpu = 8,
    ///         Memory = 16,
    ///         RestartPolicy = "OnFailure",
    ///         SecurityGroupId = alicloud_security_group.Group.Id,
    ///         VswitchId = data.Alicloud_vpcs.Default.Vpcs[0].Vswitch_ids[0],
    ///         Tags = 
    ///         {
    ///             { "TF", "create" },
    ///         },
    ///         Containers = new[]
    ///         {
    ///             new AliCloud.Eci.Inputs.ContainerGroupContainerArgs
    ///             {
    ///                 Image = "registry-vpc.cn-beijing.aliyuncs.com/eci_open/nginx:alpine",
    ///                 Name = "nginx",
    ///                 WorkingDir = "/tmp/nginx",
    ///                 ImagePullPolicy = "IfNotPresent",
    ///                 Commands = new[]
    ///                 {
    ///                     "/bin/sh",
    ///                     "-c",
    ///                     "sleep 9999",
    ///                 },
    ///                 VolumeMounts = new[]
    ///                 {
    ///                     new AliCloud.Eci.Inputs.ContainerGroupContainerVolumeMountArgs
    ///                     {
    ///                         MountPath = "/tmp/test",
    ///                         ReadOnly = false,
    ///                         Name = "empty1",
    ///                     },
    ///                 },
    ///                 Ports = new[]
    ///                 {
    ///                     new AliCloud.Eci.Inputs.ContainerGroupContainerPortArgs
    ///                     {
    ///                         Port = 80,
    ///                         Protocol = "TCP",
    ///                     },
    ///                 },
    ///                 EnvironmentVars = new[]
    ///                 {
    ///                     new AliCloud.Eci.Inputs.ContainerGroupContainerEnvironmentVarArgs
    ///                     {
    ///                         Key = "test",
    ///                         Value = "nginx",
    ///                     },
    ///                 },
    ///                 LivenessProbes = new[]
    ///                 {
    ///                     new AliCloud.Eci.Inputs.ContainerGroupContainerLivenessProbeArgs
    ///                     {
    ///                         PeriodSeconds = 5,
    ///                         InitialDelaySeconds = 5,
    ///                         SuccessThreshold = 1,
    ///                         FailureThreshold = 3,
    ///                         TimeoutSeconds = 1,
    ///                         Execs = new[]
    ///                         {
    ///                             new AliCloud.Eci.Inputs.ContainerGroupContainerLivenessProbeExecArgs
    ///                             {
    ///                                 Commands = new[]
    ///                                 {
    ///                                     "cat /tmp/healthy",
    ///                                 },
    ///                             },
    ///                         },
    ///                     },
    ///                 },
    ///                 ReadinessProbes = new[]
    ///                 {
    ///                     new AliCloud.Eci.Inputs.ContainerGroupContainerReadinessProbeArgs
    ///                     {
    ///                         PeriodSeconds = 5,
    ///                         InitialDelaySeconds = 5,
    ///                         SuccessThreshold = 1,
    ///                         FailureThreshold = 3,
    ///                         TimeoutSeconds = 1,
    ///                         Execs = new[]
    ///                         {
    ///                             new AliCloud.Eci.Inputs.ContainerGroupContainerReadinessProbeExecArgs
    ///                             {
    ///                                 Commands = new[]
    ///                                 {
    ///                                     "cat /tmp/healthy",
    ///                                 },
    ///                             },
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             new AliCloud.Eci.Inputs.ContainerGroupContainerArgs
    ///             {
    ///                 Image = "registry-vpc.cn-beijing.aliyuncs.com/eci_open/centos:7",
    ///                 Name = "centos",
    ///                 Commands = new[]
    ///                 {
    ///                     "/bin/sh",
    ///                     "-c",
    ///                     "sleep 9999",
    ///                 },
    ///             },
    ///         },
    ///         InitContainers = new[]
    ///         {
    ///             new AliCloud.Eci.Inputs.ContainerGroupInitContainerArgs
    ///             {
    ///                 Name = "init-busybox",
    ///                 Image = "registry-vpc.cn-beijing.aliyuncs.com/eci_open/busybox:1.30",
    ///                 ImagePullPolicy = "IfNotPresent",
    ///                 Commands = new[]
    ///                 {
    ///                     "echo",
    ///                 },
    ///                 Args = new[]
    ///                 {
    ///                     "hello initcontainer",
    ///                 },
    ///             },
    ///         },
    ///         Volumes = new[]
    ///         {
    ///             new AliCloud.Eci.Inputs.ContainerGroupVolumeArgs
    ///             {
    ///                 Name = "empty1",
    ///                 Type = "EmptyDirVolume",
    ///             },
    ///             new AliCloud.Eci.Inputs.ContainerGroupVolumeArgs
    ///             {
    ///                 Name = "empty2",
    ///                 Type = "EmptyDirVolume",
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// ECI Container Group can be imported using the id, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import alicloud:eci/containerGroup:ContainerGroup example &lt;container_group_id&gt;
    /// ```
    /// </summary>
    [AliCloudResourceType("alicloud:eci/containerGroup:ContainerGroup")]
    public partial class ContainerGroup : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The ACR enterprise edition example properties.
        /// </summary>
        [Output("acrRegistryInfos")]
        public Output<ImmutableArray<Outputs.ContainerGroupAcrRegistryInfo>> AcrRegistryInfos { get; private set; } = null!;

        /// <summary>
        /// Specifies whether to automatically create an EIP and bind the EIP to the elastic container instance.
        /// </summary>
        [Output("autoCreateEip")]
        public Output<bool?> AutoCreateEip { get; private set; } = null!;

        /// <summary>
        /// Specifies whether to automatically match the image cache. Default value: false.
        /// </summary>
        [Output("autoMatchImageCache")]
        public Output<bool?> AutoMatchImageCache { get; private set; } = null!;

        /// <summary>
        /// The name of the container group.
        /// </summary>
        [Output("containerGroupName")]
        public Output<string> ContainerGroupName { get; private set; } = null!;

        /// <summary>
        /// The list of containers.
        /// </summary>
        [Output("containers")]
        public Output<ImmutableArray<Outputs.ContainerGroupContainer>> Containers { get; private set; } = null!;

        /// <summary>
        /// The amount of CPU resources allocated to the container.
        /// </summary>
        [Output("cpu")]
        public Output<double> Cpu { get; private set; } = null!;

        /// <summary>
        /// The structure of dnsConfig.
        /// </summary>
        [Output("dnsConfig")]
        public Output<Outputs.ContainerGroupDnsConfig?> DnsConfig { get; private set; } = null!;

        /// <summary>
        /// The security context of the container group.
        /// </summary>
        [Output("eciSecurityContext")]
        public Output<Outputs.ContainerGroupEciSecurityContext?> EciSecurityContext { get; private set; } = null!;

        /// <summary>
        /// The bandwidth of the EIP. The default value is `5`.
        /// </summary>
        [Output("eipBandwidth")]
        public Output<int?> EipBandwidth { get; private set; } = null!;

        /// <summary>
        /// The ID of the elastic IP address (EIP).
        /// </summary>
        [Output("eipInstanceId")]
        public Output<string?> EipInstanceId { get; private set; } = null!;

        /// <summary>
        /// HostAliases.
        /// </summary>
        [Output("hostAliases")]
        public Output<ImmutableArray<Outputs.ContainerGroupHostAlias>> HostAliases { get; private set; } = null!;

        /// <summary>
        /// The image registry credential. The details see Block `image_registry_credential`.
        /// </summary>
        [Output("imageRegistryCredentials")]
        public Output<ImmutableArray<Outputs.ContainerGroupImageRegistryCredential>> ImageRegistryCredentials { get; private set; } = null!;

        /// <summary>
        /// The list of initContainers.
        /// </summary>
        [Output("initContainers")]
        public Output<ImmutableArray<Outputs.ContainerGroupInitContainer>> InitContainers { get; private set; } = null!;

        /// <summary>
        /// The address of the self-built mirror warehouse. When creating an image cache using an image in a self-built image repository with a self-signed certificate, you need to configure this parameter to skip certificate authentication to avoid image pull failure due to certificate authentication failure.
        /// </summary>
        [Output("insecureRegistry")]
        public Output<string?> InsecureRegistry { get; private set; } = null!;

        /// <summary>
        /// The type of the ECS instance.
        /// </summary>
        [Output("instanceType")]
        public Output<string?> InstanceType { get; private set; } = null!;

        /// <summary>
        /// (Available in v1.170.0+) The Public IP of the container group.
        /// </summary>
        [Output("internetIp")]
        public Output<string> InternetIp { get; private set; } = null!;

        /// <summary>
        /// (Available in v1.170.0+) The Private IP of the container group.
        /// </summary>
        [Output("intranetIp")]
        public Output<string> IntranetIp { get; private set; } = null!;

        /// <summary>
        /// The amount of memory resources allocated to the container.
        /// </summary>
        [Output("memory")]
        public Output<double> Memory { get; private set; } = null!;

        /// <summary>
        /// The address of the self-built mirror warehouse. When creating an image cache from an image in a self-built image repository using the HTTP protocol, you need to configure this parameter so that the ECI uses the HTTP protocol to pull the image to avoid image pull failure due to different protocols.
        /// </summary>
        [Output("plainHttpRegistry")]
        public Output<string?> PlainHttpRegistry { get; private set; } = null!;

        /// <summary>
        /// The RAM role that the container group assumes. ECI and ECS share the same RAM role.
        /// </summary>
        [Output("ramRoleName")]
        public Output<string?> RamRoleName { get; private set; } = null!;

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [Output("resourceGroupId")]
        public Output<string> ResourceGroupId { get; private set; } = null!;

        /// <summary>
        /// The restart policy of the container group. Valid values: `Always`, `Never`, `OnFailure`.
        /// </summary>
        [Output("restartPolicy")]
        public Output<string> RestartPolicy { get; private set; } = null!;

        /// <summary>
        /// The ID of the security group to which the container group belongs. Container groups within the same security group can access each other.
        /// </summary>
        [Output("securityGroupId")]
        public Output<string> SecurityGroupId { get; private set; } = null!;

        /// <summary>
        /// The status of container group.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// - Key: It can be up to 64 characters in length. It cannot begin with "aliyun", "acs:", "http://", or "https://". It cannot be a null string.
        /// - Value: It can be up to 128 characters in length. It cannot begin with "aliyun", "acs:", "http://", or "https://". It can be a null string.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The list of volumes.
        /// </summary>
        [Output("volumes")]
        public Output<ImmutableArray<Outputs.ContainerGroupVolume>> Volumes { get; private set; } = null!;

        /// <summary>
        /// The ID of the VSwitch. Currently, container groups can only be deployed in VPC networks. The number of IP addresses in the VSwitch CIDR block determines the maximum number of container groups that can be created in the VSwitch. Before you can create an ECI instance, plan the CIDR block of the VSwitch.
        /// </summary>
        [Output("vswitchId")]
        public Output<string> VswitchId { get; private set; } = null!;

        /// <summary>
        /// The ID of the zone where you want to deploy the container group. If no value is specified, the system assigns a zone to the container group. By default, no value is specified.
        /// </summary>
        [Output("zoneId")]
        public Output<string> ZoneId { get; private set; } = null!;


        /// <summary>
        /// Create a ContainerGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ContainerGroup(string name, ContainerGroupArgs args, CustomResourceOptions? options = null)
            : base("alicloud:eci/containerGroup:ContainerGroup", name, args ?? new ContainerGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ContainerGroup(string name, Input<string> id, ContainerGroupState? state = null, CustomResourceOptions? options = null)
            : base("alicloud:eci/containerGroup:ContainerGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ContainerGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ContainerGroup Get(string name, Input<string> id, ContainerGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new ContainerGroup(name, id, state, options);
        }
    }

    public sealed class ContainerGroupArgs : global::Pulumi.ResourceArgs
    {
        [Input("acrRegistryInfos")]
        private InputList<Inputs.ContainerGroupAcrRegistryInfoArgs>? _acrRegistryInfos;

        /// <summary>
        /// The ACR enterprise edition example properties.
        /// </summary>
        public InputList<Inputs.ContainerGroupAcrRegistryInfoArgs> AcrRegistryInfos
        {
            get => _acrRegistryInfos ?? (_acrRegistryInfos = new InputList<Inputs.ContainerGroupAcrRegistryInfoArgs>());
            set => _acrRegistryInfos = value;
        }

        /// <summary>
        /// Specifies whether to automatically create an EIP and bind the EIP to the elastic container instance.
        /// </summary>
        [Input("autoCreateEip")]
        public Input<bool>? AutoCreateEip { get; set; }

        /// <summary>
        /// Specifies whether to automatically match the image cache. Default value: false.
        /// </summary>
        [Input("autoMatchImageCache")]
        public Input<bool>? AutoMatchImageCache { get; set; }

        /// <summary>
        /// The name of the container group.
        /// </summary>
        [Input("containerGroupName", required: true)]
        public Input<string> ContainerGroupName { get; set; } = null!;

        [Input("containers", required: true)]
        private InputList<Inputs.ContainerGroupContainerArgs>? _containers;

        /// <summary>
        /// The list of containers.
        /// </summary>
        public InputList<Inputs.ContainerGroupContainerArgs> Containers
        {
            get => _containers ?? (_containers = new InputList<Inputs.ContainerGroupContainerArgs>());
            set => _containers = value;
        }

        /// <summary>
        /// The amount of CPU resources allocated to the container.
        /// </summary>
        [Input("cpu")]
        public Input<double>? Cpu { get; set; }

        /// <summary>
        /// The structure of dnsConfig.
        /// </summary>
        [Input("dnsConfig")]
        public Input<Inputs.ContainerGroupDnsConfigArgs>? DnsConfig { get; set; }

        /// <summary>
        /// The security context of the container group.
        /// </summary>
        [Input("eciSecurityContext")]
        public Input<Inputs.ContainerGroupEciSecurityContextArgs>? EciSecurityContext { get; set; }

        /// <summary>
        /// The bandwidth of the EIP. The default value is `5`.
        /// </summary>
        [Input("eipBandwidth")]
        public Input<int>? EipBandwidth { get; set; }

        /// <summary>
        /// The ID of the elastic IP address (EIP).
        /// </summary>
        [Input("eipInstanceId")]
        public Input<string>? EipInstanceId { get; set; }

        [Input("hostAliases")]
        private InputList<Inputs.ContainerGroupHostAliasArgs>? _hostAliases;

        /// <summary>
        /// HostAliases.
        /// </summary>
        public InputList<Inputs.ContainerGroupHostAliasArgs> HostAliases
        {
            get => _hostAliases ?? (_hostAliases = new InputList<Inputs.ContainerGroupHostAliasArgs>());
            set => _hostAliases = value;
        }

        [Input("imageRegistryCredentials")]
        private InputList<Inputs.ContainerGroupImageRegistryCredentialArgs>? _imageRegistryCredentials;

        /// <summary>
        /// The image registry credential. The details see Block `image_registry_credential`.
        /// </summary>
        public InputList<Inputs.ContainerGroupImageRegistryCredentialArgs> ImageRegistryCredentials
        {
            get => _imageRegistryCredentials ?? (_imageRegistryCredentials = new InputList<Inputs.ContainerGroupImageRegistryCredentialArgs>());
            set => _imageRegistryCredentials = value;
        }

        [Input("initContainers")]
        private InputList<Inputs.ContainerGroupInitContainerArgs>? _initContainers;

        /// <summary>
        /// The list of initContainers.
        /// </summary>
        public InputList<Inputs.ContainerGroupInitContainerArgs> InitContainers
        {
            get => _initContainers ?? (_initContainers = new InputList<Inputs.ContainerGroupInitContainerArgs>());
            set => _initContainers = value;
        }

        /// <summary>
        /// The address of the self-built mirror warehouse. When creating an image cache using an image in a self-built image repository with a self-signed certificate, you need to configure this parameter to skip certificate authentication to avoid image pull failure due to certificate authentication failure.
        /// </summary>
        [Input("insecureRegistry")]
        public Input<string>? InsecureRegistry { get; set; }

        /// <summary>
        /// The type of the ECS instance.
        /// </summary>
        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        /// <summary>
        /// The amount of memory resources allocated to the container.
        /// </summary>
        [Input("memory")]
        public Input<double>? Memory { get; set; }

        /// <summary>
        /// The address of the self-built mirror warehouse. When creating an image cache from an image in a self-built image repository using the HTTP protocol, you need to configure this parameter so that the ECI uses the HTTP protocol to pull the image to avoid image pull failure due to different protocols.
        /// </summary>
        [Input("plainHttpRegistry")]
        public Input<string>? PlainHttpRegistry { get; set; }

        /// <summary>
        /// The RAM role that the container group assumes. ECI and ECS share the same RAM role.
        /// </summary>
        [Input("ramRoleName")]
        public Input<string>? RamRoleName { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [Input("resourceGroupId")]
        public Input<string>? ResourceGroupId { get; set; }

        /// <summary>
        /// The restart policy of the container group. Valid values: `Always`, `Never`, `OnFailure`.
        /// </summary>
        [Input("restartPolicy")]
        public Input<string>? RestartPolicy { get; set; }

        /// <summary>
        /// The ID of the security group to which the container group belongs. Container groups within the same security group can access each other.
        /// </summary>
        [Input("securityGroupId", required: true)]
        public Input<string> SecurityGroupId { get; set; } = null!;

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

        [Input("volumes")]
        private InputList<Inputs.ContainerGroupVolumeArgs>? _volumes;

        /// <summary>
        /// The list of volumes.
        /// </summary>
        public InputList<Inputs.ContainerGroupVolumeArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<Inputs.ContainerGroupVolumeArgs>());
            set => _volumes = value;
        }

        /// <summary>
        /// The ID of the VSwitch. Currently, container groups can only be deployed in VPC networks. The number of IP addresses in the VSwitch CIDR block determines the maximum number of container groups that can be created in the VSwitch. Before you can create an ECI instance, plan the CIDR block of the VSwitch.
        /// </summary>
        [Input("vswitchId", required: true)]
        public Input<string> VswitchId { get; set; } = null!;

        /// <summary>
        /// The ID of the zone where you want to deploy the container group. If no value is specified, the system assigns a zone to the container group. By default, no value is specified.
        /// </summary>
        [Input("zoneId")]
        public Input<string>? ZoneId { get; set; }

        public ContainerGroupArgs()
        {
        }
        public static new ContainerGroupArgs Empty => new ContainerGroupArgs();
    }

    public sealed class ContainerGroupState : global::Pulumi.ResourceArgs
    {
        [Input("acrRegistryInfos")]
        private InputList<Inputs.ContainerGroupAcrRegistryInfoGetArgs>? _acrRegistryInfos;

        /// <summary>
        /// The ACR enterprise edition example properties.
        /// </summary>
        public InputList<Inputs.ContainerGroupAcrRegistryInfoGetArgs> AcrRegistryInfos
        {
            get => _acrRegistryInfos ?? (_acrRegistryInfos = new InputList<Inputs.ContainerGroupAcrRegistryInfoGetArgs>());
            set => _acrRegistryInfos = value;
        }

        /// <summary>
        /// Specifies whether to automatically create an EIP and bind the EIP to the elastic container instance.
        /// </summary>
        [Input("autoCreateEip")]
        public Input<bool>? AutoCreateEip { get; set; }

        /// <summary>
        /// Specifies whether to automatically match the image cache. Default value: false.
        /// </summary>
        [Input("autoMatchImageCache")]
        public Input<bool>? AutoMatchImageCache { get; set; }

        /// <summary>
        /// The name of the container group.
        /// </summary>
        [Input("containerGroupName")]
        public Input<string>? ContainerGroupName { get; set; }

        [Input("containers")]
        private InputList<Inputs.ContainerGroupContainerGetArgs>? _containers;

        /// <summary>
        /// The list of containers.
        /// </summary>
        public InputList<Inputs.ContainerGroupContainerGetArgs> Containers
        {
            get => _containers ?? (_containers = new InputList<Inputs.ContainerGroupContainerGetArgs>());
            set => _containers = value;
        }

        /// <summary>
        /// The amount of CPU resources allocated to the container.
        /// </summary>
        [Input("cpu")]
        public Input<double>? Cpu { get; set; }

        /// <summary>
        /// The structure of dnsConfig.
        /// </summary>
        [Input("dnsConfig")]
        public Input<Inputs.ContainerGroupDnsConfigGetArgs>? DnsConfig { get; set; }

        /// <summary>
        /// The security context of the container group.
        /// </summary>
        [Input("eciSecurityContext")]
        public Input<Inputs.ContainerGroupEciSecurityContextGetArgs>? EciSecurityContext { get; set; }

        /// <summary>
        /// The bandwidth of the EIP. The default value is `5`.
        /// </summary>
        [Input("eipBandwidth")]
        public Input<int>? EipBandwidth { get; set; }

        /// <summary>
        /// The ID of the elastic IP address (EIP).
        /// </summary>
        [Input("eipInstanceId")]
        public Input<string>? EipInstanceId { get; set; }

        [Input("hostAliases")]
        private InputList<Inputs.ContainerGroupHostAliasGetArgs>? _hostAliases;

        /// <summary>
        /// HostAliases.
        /// </summary>
        public InputList<Inputs.ContainerGroupHostAliasGetArgs> HostAliases
        {
            get => _hostAliases ?? (_hostAliases = new InputList<Inputs.ContainerGroupHostAliasGetArgs>());
            set => _hostAliases = value;
        }

        [Input("imageRegistryCredentials")]
        private InputList<Inputs.ContainerGroupImageRegistryCredentialGetArgs>? _imageRegistryCredentials;

        /// <summary>
        /// The image registry credential. The details see Block `image_registry_credential`.
        /// </summary>
        public InputList<Inputs.ContainerGroupImageRegistryCredentialGetArgs> ImageRegistryCredentials
        {
            get => _imageRegistryCredentials ?? (_imageRegistryCredentials = new InputList<Inputs.ContainerGroupImageRegistryCredentialGetArgs>());
            set => _imageRegistryCredentials = value;
        }

        [Input("initContainers")]
        private InputList<Inputs.ContainerGroupInitContainerGetArgs>? _initContainers;

        /// <summary>
        /// The list of initContainers.
        /// </summary>
        public InputList<Inputs.ContainerGroupInitContainerGetArgs> InitContainers
        {
            get => _initContainers ?? (_initContainers = new InputList<Inputs.ContainerGroupInitContainerGetArgs>());
            set => _initContainers = value;
        }

        /// <summary>
        /// The address of the self-built mirror warehouse. When creating an image cache using an image in a self-built image repository with a self-signed certificate, you need to configure this parameter to skip certificate authentication to avoid image pull failure due to certificate authentication failure.
        /// </summary>
        [Input("insecureRegistry")]
        public Input<string>? InsecureRegistry { get; set; }

        /// <summary>
        /// The type of the ECS instance.
        /// </summary>
        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        /// <summary>
        /// (Available in v1.170.0+) The Public IP of the container group.
        /// </summary>
        [Input("internetIp")]
        public Input<string>? InternetIp { get; set; }

        /// <summary>
        /// (Available in v1.170.0+) The Private IP of the container group.
        /// </summary>
        [Input("intranetIp")]
        public Input<string>? IntranetIp { get; set; }

        /// <summary>
        /// The amount of memory resources allocated to the container.
        /// </summary>
        [Input("memory")]
        public Input<double>? Memory { get; set; }

        /// <summary>
        /// The address of the self-built mirror warehouse. When creating an image cache from an image in a self-built image repository using the HTTP protocol, you need to configure this parameter so that the ECI uses the HTTP protocol to pull the image to avoid image pull failure due to different protocols.
        /// </summary>
        [Input("plainHttpRegistry")]
        public Input<string>? PlainHttpRegistry { get; set; }

        /// <summary>
        /// The RAM role that the container group assumes. ECI and ECS share the same RAM role.
        /// </summary>
        [Input("ramRoleName")]
        public Input<string>? RamRoleName { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [Input("resourceGroupId")]
        public Input<string>? ResourceGroupId { get; set; }

        /// <summary>
        /// The restart policy of the container group. Valid values: `Always`, `Never`, `OnFailure`.
        /// </summary>
        [Input("restartPolicy")]
        public Input<string>? RestartPolicy { get; set; }

        /// <summary>
        /// The ID of the security group to which the container group belongs. Container groups within the same security group can access each other.
        /// </summary>
        [Input("securityGroupId")]
        public Input<string>? SecurityGroupId { get; set; }

        /// <summary>
        /// The status of container group.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

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

        [Input("volumes")]
        private InputList<Inputs.ContainerGroupVolumeGetArgs>? _volumes;

        /// <summary>
        /// The list of volumes.
        /// </summary>
        public InputList<Inputs.ContainerGroupVolumeGetArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<Inputs.ContainerGroupVolumeGetArgs>());
            set => _volumes = value;
        }

        /// <summary>
        /// The ID of the VSwitch. Currently, container groups can only be deployed in VPC networks. The number of IP addresses in the VSwitch CIDR block determines the maximum number of container groups that can be created in the VSwitch. Before you can create an ECI instance, plan the CIDR block of the VSwitch.
        /// </summary>
        [Input("vswitchId")]
        public Input<string>? VswitchId { get; set; }

        /// <summary>
        /// The ID of the zone where you want to deploy the container group. If no value is specified, the system assigns a zone to the container group. By default, no value is specified.
        /// </summary>
        [Input("zoneId")]
        public Input<string>? ZoneId { get; set; }

        public ContainerGroupState()
        {
        }
        public static new ContainerGroupState Empty => new ContainerGroupState();
    }
}