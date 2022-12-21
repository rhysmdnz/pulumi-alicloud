// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * ## Example Usage
 *
 * Basic Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const fooGateway = new alicloud.vpn.Gateway("fooGateway", {
 *     vpcId: "vpc-fake-id",
 *     bandwidth: 10,
 *     enableSsl: true,
 *     instanceChargeType: "PostPaid",
 *     description: "test_create_description",
 * });
 * const fooCustomerGateway = new alicloud.vpn.CustomerGateway("fooCustomerGateway", {
 *     ipAddress: "42.104.22.228",
 *     description: "testAccVpnCgwDesc",
 * });
 * const fooConnection = new alicloud.vpn.Connection("fooConnection", {
 *     vpnGatewayId: fooGateway.id,
 *     customerGatewayId: fooCustomerGateway.id,
 *     localSubnets: [
 *         "172.16.0.0/24",
 *         "172.16.1.0/24",
 *     ],
 *     remoteSubnets: [
 *         "10.0.0.0/24",
 *         "10.0.1.0/24",
 *     ],
 *     effectImmediately: true,
 *     ikeConfig: {
 *         ikeAuthAlg: "md5",
 *         ikeEncAlg: "des",
 *         ikeVersion: "ikev1",
 *         ikeMode: "main",
 *         ikeLifetime: 86400,
 *         psk: "tf-testvpn2",
 *         ikePfs: "group1",
 *         ikeRemoteId: "testbob2",
 *         ikeLocalId: "testalice2",
 *     },
 *     ipsecConfig: {
 *         ipsecPfs: "group5",
 *         ipsecEncAlg: "des",
 *         ipsecAuthAlg: "md5",
 *         ipsecLifetime: 8640,
 *     },
 * });
 * ```
 *
 * ## Import
 *
 * VPN connection can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import alicloud:vpn/connection:Connection example vco-abc123456
 * ```
 */
export class Connection extends pulumi.CustomResource {
    /**
     * Get an existing Connection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ConnectionState, opts?: pulumi.CustomResourceOptions): Connection {
        return new Connection(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'alicloud:vpn/connection:Connection';

    /**
     * Returns true if the given object is an instance of Connection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Connection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Connection.__pulumiType;
    }

    /**
     * The configurations of the BGP routing protocol. See the following `Block bgpConfig`.
     */
    public readonly bgpConfig!: pulumi.Output<outputs.vpn.ConnectionBgpConfig>;
    /**
     * The ID of the customer gateway.
     */
    public readonly customerGatewayId!: pulumi.Output<string>;
    /**
     * Whether to delete a successfully negotiated IPsec tunnel and initiate a negotiation again. Valid value:true,false.
     */
    public readonly effectImmediately!: pulumi.Output<boolean | undefined>;
    /**
     * Whether to enable NAT traversal.
     */
    public readonly enableDpd!: pulumi.Output<boolean>;
    /**
     * Whether to enable NAT traversal.
     */
    public readonly enableNatTraversal!: pulumi.Output<boolean>;
    /**
     * The health check configurations. See the following `Block healthCheckConfig`.
     */
    public readonly healthCheckConfig!: pulumi.Output<outputs.vpn.ConnectionHealthCheckConfig>;
    /**
     * The configurations of phase-one negotiation. See the following `Block ikeConfig`.
     */
    public readonly ikeConfig!: pulumi.Output<outputs.vpn.ConnectionIkeConfig>;
    /**
     * The configurations of phase-two negotiation. See the following `Block ipsecConfig`.
     */
    public readonly ipsecConfig!: pulumi.Output<outputs.vpn.ConnectionIpsecConfig>;
    /**
     * The CIDR block of the VPC to be connected with the local data center. This parameter is used for phase-two negotiation.
     */
    public readonly localSubnets!: pulumi.Output<string[]>;
    /**
     * The name of the IPsec connection.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The CIDR block of the local data center. This parameter is used for phase-two negotiation.
     */
    public readonly remoteSubnets!: pulumi.Output<string[]>;
    /**
     * The status of VPN connection.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * The ID of the VPN gateway.
     */
    public readonly vpnGatewayId!: pulumi.Output<string>;

    /**
     * Create a Connection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ConnectionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ConnectionArgs | ConnectionState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ConnectionState | undefined;
            resourceInputs["bgpConfig"] = state ? state.bgpConfig : undefined;
            resourceInputs["customerGatewayId"] = state ? state.customerGatewayId : undefined;
            resourceInputs["effectImmediately"] = state ? state.effectImmediately : undefined;
            resourceInputs["enableDpd"] = state ? state.enableDpd : undefined;
            resourceInputs["enableNatTraversal"] = state ? state.enableNatTraversal : undefined;
            resourceInputs["healthCheckConfig"] = state ? state.healthCheckConfig : undefined;
            resourceInputs["ikeConfig"] = state ? state.ikeConfig : undefined;
            resourceInputs["ipsecConfig"] = state ? state.ipsecConfig : undefined;
            resourceInputs["localSubnets"] = state ? state.localSubnets : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["remoteSubnets"] = state ? state.remoteSubnets : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["vpnGatewayId"] = state ? state.vpnGatewayId : undefined;
        } else {
            const args = argsOrState as ConnectionArgs | undefined;
            if ((!args || args.customerGatewayId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'customerGatewayId'");
            }
            if ((!args || args.localSubnets === undefined) && !opts.urn) {
                throw new Error("Missing required property 'localSubnets'");
            }
            if ((!args || args.remoteSubnets === undefined) && !opts.urn) {
                throw new Error("Missing required property 'remoteSubnets'");
            }
            if ((!args || args.vpnGatewayId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vpnGatewayId'");
            }
            resourceInputs["bgpConfig"] = args ? args.bgpConfig : undefined;
            resourceInputs["customerGatewayId"] = args ? args.customerGatewayId : undefined;
            resourceInputs["effectImmediately"] = args ? args.effectImmediately : undefined;
            resourceInputs["enableDpd"] = args ? args.enableDpd : undefined;
            resourceInputs["enableNatTraversal"] = args ? args.enableNatTraversal : undefined;
            resourceInputs["healthCheckConfig"] = args ? args.healthCheckConfig : undefined;
            resourceInputs["ikeConfig"] = args ? args.ikeConfig : undefined;
            resourceInputs["ipsecConfig"] = args ? args.ipsecConfig : undefined;
            resourceInputs["localSubnets"] = args ? args.localSubnets : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["remoteSubnets"] = args ? args.remoteSubnets : undefined;
            resourceInputs["vpnGatewayId"] = args ? args.vpnGatewayId : undefined;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Connection.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Connection resources.
 */
export interface ConnectionState {
    /**
     * The configurations of the BGP routing protocol. See the following `Block bgpConfig`.
     */
    bgpConfig?: pulumi.Input<inputs.vpn.ConnectionBgpConfig>;
    /**
     * The ID of the customer gateway.
     */
    customerGatewayId?: pulumi.Input<string>;
    /**
     * Whether to delete a successfully negotiated IPsec tunnel and initiate a negotiation again. Valid value:true,false.
     */
    effectImmediately?: pulumi.Input<boolean>;
    /**
     * Whether to enable NAT traversal.
     */
    enableDpd?: pulumi.Input<boolean>;
    /**
     * Whether to enable NAT traversal.
     */
    enableNatTraversal?: pulumi.Input<boolean>;
    /**
     * The health check configurations. See the following `Block healthCheckConfig`.
     */
    healthCheckConfig?: pulumi.Input<inputs.vpn.ConnectionHealthCheckConfig>;
    /**
     * The configurations of phase-one negotiation. See the following `Block ikeConfig`.
     */
    ikeConfig?: pulumi.Input<inputs.vpn.ConnectionIkeConfig>;
    /**
     * The configurations of phase-two negotiation. See the following `Block ipsecConfig`.
     */
    ipsecConfig?: pulumi.Input<inputs.vpn.ConnectionIpsecConfig>;
    /**
     * The CIDR block of the VPC to be connected with the local data center. This parameter is used for phase-two negotiation.
     */
    localSubnets?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The name of the IPsec connection.
     */
    name?: pulumi.Input<string>;
    /**
     * The CIDR block of the local data center. This parameter is used for phase-two negotiation.
     */
    remoteSubnets?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The status of VPN connection.
     */
    status?: pulumi.Input<string>;
    /**
     * The ID of the VPN gateway.
     */
    vpnGatewayId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Connection resource.
 */
export interface ConnectionArgs {
    /**
     * The configurations of the BGP routing protocol. See the following `Block bgpConfig`.
     */
    bgpConfig?: pulumi.Input<inputs.vpn.ConnectionBgpConfig>;
    /**
     * The ID of the customer gateway.
     */
    customerGatewayId: pulumi.Input<string>;
    /**
     * Whether to delete a successfully negotiated IPsec tunnel and initiate a negotiation again. Valid value:true,false.
     */
    effectImmediately?: pulumi.Input<boolean>;
    /**
     * Whether to enable NAT traversal.
     */
    enableDpd?: pulumi.Input<boolean>;
    /**
     * Whether to enable NAT traversal.
     */
    enableNatTraversal?: pulumi.Input<boolean>;
    /**
     * The health check configurations. See the following `Block healthCheckConfig`.
     */
    healthCheckConfig?: pulumi.Input<inputs.vpn.ConnectionHealthCheckConfig>;
    /**
     * The configurations of phase-one negotiation. See the following `Block ikeConfig`.
     */
    ikeConfig?: pulumi.Input<inputs.vpn.ConnectionIkeConfig>;
    /**
     * The configurations of phase-two negotiation. See the following `Block ipsecConfig`.
     */
    ipsecConfig?: pulumi.Input<inputs.vpn.ConnectionIpsecConfig>;
    /**
     * The CIDR block of the VPC to be connected with the local data center. This parameter is used for phase-two negotiation.
     */
    localSubnets: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The name of the IPsec connection.
     */
    name?: pulumi.Input<string>;
    /**
     * The CIDR block of the local data center. This parameter is used for phase-two negotiation.
     */
    remoteSubnets: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The ID of the VPN gateway.
     */
    vpnGatewayId: pulumi.Input<string>;
}