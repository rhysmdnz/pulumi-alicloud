// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.ExpressConnect
{
    /// <summary>
    /// Provides a Express Connect Virtual Border Router resource.
    /// 
    /// For information about Express Connect Virtual Border Router and how to use it, see [What is Virtual Border Router](https://www.alibabacloud.com/help/en/doc-detail/44854.htm).
    /// 
    /// &gt; **NOTE:** Available in v1.134.0+.
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
    ///     var nameRegex = AliCloud.ExpressConnect.GetPhysicalConnections.Invoke(new()
    ///     {
    ///         NameRegex = "^my-PhysicalConnection",
    ///     });
    /// 
    ///     var example = new AliCloud.ExpressConnect.VirtualBorderRouter("example", new()
    ///     {
    ///         LocalGatewayIp = "10.0.0.1",
    ///         PeerGatewayIp = "10.0.0.2",
    ///         PeeringSubnetMask = "255.255.255.252",
    ///         PhysicalConnectionId = nameRegex.Apply(getPhysicalConnectionsResult =&gt; getPhysicalConnectionsResult.Connections[0]?.Id),
    ///         VirtualBorderRouterName = "example_value",
    ///         VlanId = 1,
    ///         MinRxInterval = 1000,
    ///         MinTxInterval = 1000,
    ///         DetectMultiplier = 10,
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// Express Connect Virtual Border Router can be imported using the id, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import alicloud:expressconnect/virtualBorderRouter:VirtualBorderRouter example &lt;id&gt;
    /// ```
    /// </summary>
    [AliCloudResourceType("alicloud:expressconnect/virtualBorderRouter:VirtualBorderRouter")]
    public partial class VirtualBorderRouter : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The associated physical connections.
        /// </summary>
        [Output("associatedPhysicalConnections")]
        public Output<string?> AssociatedPhysicalConnections { get; private set; } = null!;

        /// <summary>
        /// The bandwidth.
        /// </summary>
        [Output("bandwidth")]
        public Output<int> Bandwidth { get; private set; } = null!;

        /// <summary>
        /// Operators for physical connection circuit provided coding.
        /// </summary>
        [Output("circuitCode")]
        public Output<string?> CircuitCode { get; private set; } = null!;

        /// <summary>
        /// The description of VBR. Length is from 2 to 256 characters, must start with a letter or the Chinese at the beginning, but not at the http:// Or https:// at the beginning.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Detection time multiplier that recipient allows the sender to send a message of the maximum allowable connections for the number of packets, used to detect whether the link normal. Value: 3~10.
        /// </summary>
        [Output("detectMultiplier")]
        public Output<int> DetectMultiplier { get; private set; } = null!;

        /// <summary>
        /// Whether to Enable IPv6. Valid values: `false`, `true`.
        /// </summary>
        [Output("enableIpv6")]
        public Output<bool> EnableIpv6 { get; private set; } = null!;

        /// <summary>
        /// Whether cross account border routers are included. Valid values: `false`, `true`. Default: `true`.
        /// </summary>
        [Output("includeCrossAccountVbr")]
        public Output<bool> IncludeCrossAccountVbr { get; private set; } = null!;

        /// <summary>
        /// Alibaba Cloud-Connected IPv4 address.
        /// </summary>
        [Output("localGatewayIp")]
        public Output<string> LocalGatewayIp { get; private set; } = null!;

        /// <summary>
        /// Alibaba Cloud-Connected IPv6 Address.
        /// </summary>
        [Output("localIpv6GatewayIp")]
        public Output<string?> LocalIpv6GatewayIp { get; private set; } = null!;

        /// <summary>
        /// Configure BFD packet reception interval of values include: 200~1000, unit: ms.
        /// </summary>
        [Output("minRxInterval")]
        public Output<int> MinRxInterval { get; private set; } = null!;

        /// <summary>
        /// Configure BFD packet transmission interval maximum value: 200~1000, unit: ms.
        /// </summary>
        [Output("minTxInterval")]
        public Output<int> MinTxInterval { get; private set; } = null!;

        /// <summary>
        /// The Client-Side Interconnection IPv4 Address.
        /// </summary>
        [Output("peerGatewayIp")]
        public Output<string> PeerGatewayIp { get; private set; } = null!;

        /// <summary>
        /// The Client-Side Interconnection IPv6 Address.
        /// </summary>
        [Output("peerIpv6GatewayIp")]
        public Output<string?> PeerIpv6GatewayIp { get; private set; } = null!;

        /// <summary>
        /// Alibaba Cloud-Connected IPv6 with Client-Side Interconnection IPv6 of Subnet Mask.
        /// </summary>
        [Output("peeringIpv6SubnetMask")]
        public Output<string?> PeeringIpv6SubnetMask { get; private set; } = null!;

        /// <summary>
        /// Alibaba Cloud-Connected IPv4 and Client-Side Interconnection IPv4 of Subnet Mask.
        /// </summary>
        [Output("peeringSubnetMask")]
        public Output<string> PeeringSubnetMask { get; private set; } = null!;

        /// <summary>
        /// The ID of the Physical Connection to Which the ID.
        /// </summary>
        [Output("physicalConnectionId")]
        public Output<string> PhysicalConnectionId { get; private set; } = null!;

        /// <summary>
        /// (Available in v1.166.0+) The Route Table ID Of the Virtual Border Router.
        /// </summary>
        [Output("routeTableId")]
        public Output<string> RouteTableId { get; private set; } = null!;

        /// <summary>
        /// The instance state. Valid values: `active`, `deleting`, `recovering`, `terminated`, `terminating`, `unconfirmed`.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// The vbr owner id.
        /// </summary>
        [Output("vbrOwnerId")]
        public Output<string?> VbrOwnerId { get; private set; } = null!;

        /// <summary>
        /// The name of VBR. Length is from 2 to 128 characters, must start with a letter or the Chinese at the beginning can contain numbers, the underscore character (_) and dash (-). But do not start with http:// or https:// at the beginning.
        /// </summary>
        [Output("virtualBorderRouterName")]
        public Output<string?> VirtualBorderRouterName { get; private set; } = null!;

        /// <summary>
        /// The VLAN ID of the VBR. Value range: 0~2999.
        /// </summary>
        [Output("vlanId")]
        public Output<int> VlanId { get; private set; } = null!;


        /// <summary>
        /// Create a VirtualBorderRouter resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VirtualBorderRouter(string name, VirtualBorderRouterArgs args, CustomResourceOptions? options = null)
            : base("alicloud:expressconnect/virtualBorderRouter:VirtualBorderRouter", name, args ?? new VirtualBorderRouterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VirtualBorderRouter(string name, Input<string> id, VirtualBorderRouterState? state = null, CustomResourceOptions? options = null)
            : base("alicloud:expressconnect/virtualBorderRouter:VirtualBorderRouter", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing VirtualBorderRouter resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VirtualBorderRouter Get(string name, Input<string> id, VirtualBorderRouterState? state = null, CustomResourceOptions? options = null)
        {
            return new VirtualBorderRouter(name, id, state, options);
        }
    }

    public sealed class VirtualBorderRouterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The associated physical connections.
        /// </summary>
        [Input("associatedPhysicalConnections")]
        public Input<string>? AssociatedPhysicalConnections { get; set; }

        /// <summary>
        /// The bandwidth.
        /// </summary>
        [Input("bandwidth")]
        public Input<int>? Bandwidth { get; set; }

        /// <summary>
        /// Operators for physical connection circuit provided coding.
        /// </summary>
        [Input("circuitCode")]
        public Input<string>? CircuitCode { get; set; }

        /// <summary>
        /// The description of VBR. Length is from 2 to 256 characters, must start with a letter or the Chinese at the beginning, but not at the http:// Or https:// at the beginning.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Detection time multiplier that recipient allows the sender to send a message of the maximum allowable connections for the number of packets, used to detect whether the link normal. Value: 3~10.
        /// </summary>
        [Input("detectMultiplier")]
        public Input<int>? DetectMultiplier { get; set; }

        /// <summary>
        /// Whether to Enable IPv6. Valid values: `false`, `true`.
        /// </summary>
        [Input("enableIpv6")]
        public Input<bool>? EnableIpv6 { get; set; }

        /// <summary>
        /// Whether cross account border routers are included. Valid values: `false`, `true`. Default: `true`.
        /// </summary>
        [Input("includeCrossAccountVbr")]
        public Input<bool>? IncludeCrossAccountVbr { get; set; }

        /// <summary>
        /// Alibaba Cloud-Connected IPv4 address.
        /// </summary>
        [Input("localGatewayIp", required: true)]
        public Input<string> LocalGatewayIp { get; set; } = null!;

        /// <summary>
        /// Alibaba Cloud-Connected IPv6 Address.
        /// </summary>
        [Input("localIpv6GatewayIp")]
        public Input<string>? LocalIpv6GatewayIp { get; set; }

        /// <summary>
        /// Configure BFD packet reception interval of values include: 200~1000, unit: ms.
        /// </summary>
        [Input("minRxInterval")]
        public Input<int>? MinRxInterval { get; set; }

        /// <summary>
        /// Configure BFD packet transmission interval maximum value: 200~1000, unit: ms.
        /// </summary>
        [Input("minTxInterval")]
        public Input<int>? MinTxInterval { get; set; }

        /// <summary>
        /// The Client-Side Interconnection IPv4 Address.
        /// </summary>
        [Input("peerGatewayIp", required: true)]
        public Input<string> PeerGatewayIp { get; set; } = null!;

        /// <summary>
        /// The Client-Side Interconnection IPv6 Address.
        /// </summary>
        [Input("peerIpv6GatewayIp")]
        public Input<string>? PeerIpv6GatewayIp { get; set; }

        /// <summary>
        /// Alibaba Cloud-Connected IPv6 with Client-Side Interconnection IPv6 of Subnet Mask.
        /// </summary>
        [Input("peeringIpv6SubnetMask")]
        public Input<string>? PeeringIpv6SubnetMask { get; set; }

        /// <summary>
        /// Alibaba Cloud-Connected IPv4 and Client-Side Interconnection IPv4 of Subnet Mask.
        /// </summary>
        [Input("peeringSubnetMask", required: true)]
        public Input<string> PeeringSubnetMask { get; set; } = null!;

        /// <summary>
        /// The ID of the Physical Connection to Which the ID.
        /// </summary>
        [Input("physicalConnectionId", required: true)]
        public Input<string> PhysicalConnectionId { get; set; } = null!;

        /// <summary>
        /// The instance state. Valid values: `active`, `deleting`, `recovering`, `terminated`, `terminating`, `unconfirmed`.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// The vbr owner id.
        /// </summary>
        [Input("vbrOwnerId")]
        public Input<string>? VbrOwnerId { get; set; }

        /// <summary>
        /// The name of VBR. Length is from 2 to 128 characters, must start with a letter or the Chinese at the beginning can contain numbers, the underscore character (_) and dash (-). But do not start with http:// or https:// at the beginning.
        /// </summary>
        [Input("virtualBorderRouterName")]
        public Input<string>? VirtualBorderRouterName { get; set; }

        /// <summary>
        /// The VLAN ID of the VBR. Value range: 0~2999.
        /// </summary>
        [Input("vlanId", required: true)]
        public Input<int> VlanId { get; set; } = null!;

        public VirtualBorderRouterArgs()
        {
        }
        public static new VirtualBorderRouterArgs Empty => new VirtualBorderRouterArgs();
    }

    public sealed class VirtualBorderRouterState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The associated physical connections.
        /// </summary>
        [Input("associatedPhysicalConnections")]
        public Input<string>? AssociatedPhysicalConnections { get; set; }

        /// <summary>
        /// The bandwidth.
        /// </summary>
        [Input("bandwidth")]
        public Input<int>? Bandwidth { get; set; }

        /// <summary>
        /// Operators for physical connection circuit provided coding.
        /// </summary>
        [Input("circuitCode")]
        public Input<string>? CircuitCode { get; set; }

        /// <summary>
        /// The description of VBR. Length is from 2 to 256 characters, must start with a letter or the Chinese at the beginning, but not at the http:// Or https:// at the beginning.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Detection time multiplier that recipient allows the sender to send a message of the maximum allowable connections for the number of packets, used to detect whether the link normal. Value: 3~10.
        /// </summary>
        [Input("detectMultiplier")]
        public Input<int>? DetectMultiplier { get; set; }

        /// <summary>
        /// Whether to Enable IPv6. Valid values: `false`, `true`.
        /// </summary>
        [Input("enableIpv6")]
        public Input<bool>? EnableIpv6 { get; set; }

        /// <summary>
        /// Whether cross account border routers are included. Valid values: `false`, `true`. Default: `true`.
        /// </summary>
        [Input("includeCrossAccountVbr")]
        public Input<bool>? IncludeCrossAccountVbr { get; set; }

        /// <summary>
        /// Alibaba Cloud-Connected IPv4 address.
        /// </summary>
        [Input("localGatewayIp")]
        public Input<string>? LocalGatewayIp { get; set; }

        /// <summary>
        /// Alibaba Cloud-Connected IPv6 Address.
        /// </summary>
        [Input("localIpv6GatewayIp")]
        public Input<string>? LocalIpv6GatewayIp { get; set; }

        /// <summary>
        /// Configure BFD packet reception interval of values include: 200~1000, unit: ms.
        /// </summary>
        [Input("minRxInterval")]
        public Input<int>? MinRxInterval { get; set; }

        /// <summary>
        /// Configure BFD packet transmission interval maximum value: 200~1000, unit: ms.
        /// </summary>
        [Input("minTxInterval")]
        public Input<int>? MinTxInterval { get; set; }

        /// <summary>
        /// The Client-Side Interconnection IPv4 Address.
        /// </summary>
        [Input("peerGatewayIp")]
        public Input<string>? PeerGatewayIp { get; set; }

        /// <summary>
        /// The Client-Side Interconnection IPv6 Address.
        /// </summary>
        [Input("peerIpv6GatewayIp")]
        public Input<string>? PeerIpv6GatewayIp { get; set; }

        /// <summary>
        /// Alibaba Cloud-Connected IPv6 with Client-Side Interconnection IPv6 of Subnet Mask.
        /// </summary>
        [Input("peeringIpv6SubnetMask")]
        public Input<string>? PeeringIpv6SubnetMask { get; set; }

        /// <summary>
        /// Alibaba Cloud-Connected IPv4 and Client-Side Interconnection IPv4 of Subnet Mask.
        /// </summary>
        [Input("peeringSubnetMask")]
        public Input<string>? PeeringSubnetMask { get; set; }

        /// <summary>
        /// The ID of the Physical Connection to Which the ID.
        /// </summary>
        [Input("physicalConnectionId")]
        public Input<string>? PhysicalConnectionId { get; set; }

        /// <summary>
        /// (Available in v1.166.0+) The Route Table ID Of the Virtual Border Router.
        /// </summary>
        [Input("routeTableId")]
        public Input<string>? RouteTableId { get; set; }

        /// <summary>
        /// The instance state. Valid values: `active`, `deleting`, `recovering`, `terminated`, `terminating`, `unconfirmed`.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// The vbr owner id.
        /// </summary>
        [Input("vbrOwnerId")]
        public Input<string>? VbrOwnerId { get; set; }

        /// <summary>
        /// The name of VBR. Length is from 2 to 128 characters, must start with a letter or the Chinese at the beginning can contain numbers, the underscore character (_) and dash (-). But do not start with http:// or https:// at the beginning.
        /// </summary>
        [Input("virtualBorderRouterName")]
        public Input<string>? VirtualBorderRouterName { get; set; }

        /// <summary>
        /// The VLAN ID of the VBR. Value range: 0~2999.
        /// </summary>
        [Input("vlanId")]
        public Input<int>? VlanId { get; set; }

        public VirtualBorderRouterState()
        {
        }
        public static new VirtualBorderRouterState Empty => new VirtualBorderRouterState();
    }
}