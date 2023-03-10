// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * ## Import
 *
 * Vswitch can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import alicloud:vpc/switch:Switch example vsw-abc123456
 * ```
 */
export class Switch extends pulumi.CustomResource {
    /**
     * Get an existing Switch resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SwitchState, opts?: pulumi.CustomResourceOptions): Switch {
        return new Switch(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'alicloud:vpc/switch:Switch';

    /**
     * Returns true if the given object is an instance of Switch.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Switch {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Switch.__pulumiType;
    }

    /**
     * Field `availabilityZone` has been deprecated from provider version 1.119.0. New field `zoneId` instead.
     *
     * @deprecated Field 'availability_zone' has been deprecated from provider version 1.119.0. New field 'zone_id' instead.
     */
    public readonly availabilityZone!: pulumi.Output<string>;
    /**
     * The CIDR block for the switch.
     */
    public readonly cidrBlock!: pulumi.Output<string>;
    /**
     * The switch description. Defaults to null.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Field `name` has been deprecated from provider version 1.119.0. New field `vswitchName` instead.
     *
     * @deprecated Field 'name' has been deprecated from provider version 1.119.0. New field 'vswitch_name' instead.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * (Available in 1.119.0+) The status of the switch.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * The VPC ID.
     */
    public readonly vpcId!: pulumi.Output<string>;
    /**
     * The name of the switch. Defaults to null.
     */
    public readonly vswitchName!: pulumi.Output<string>;
    /**
     * The AZ for the switch. **Note:** Required for a VPC switch.
     */
    public readonly zoneId!: pulumi.Output<string>;

    /**
     * Create a Switch resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SwitchArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SwitchArgs | SwitchState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SwitchState | undefined;
            resourceInputs["availabilityZone"] = state ? state.availabilityZone : undefined;
            resourceInputs["cidrBlock"] = state ? state.cidrBlock : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["vpcId"] = state ? state.vpcId : undefined;
            resourceInputs["vswitchName"] = state ? state.vswitchName : undefined;
            resourceInputs["zoneId"] = state ? state.zoneId : undefined;
        } else {
            const args = argsOrState as SwitchArgs | undefined;
            if ((!args || args.cidrBlock === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cidrBlock'");
            }
            if ((!args || args.vpcId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vpcId'");
            }
            resourceInputs["availabilityZone"] = args ? args.availabilityZone : undefined;
            resourceInputs["cidrBlock"] = args ? args.cidrBlock : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["vpcId"] = args ? args.vpcId : undefined;
            resourceInputs["vswitchName"] = args ? args.vswitchName : undefined;
            resourceInputs["zoneId"] = args ? args.zoneId : undefined;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Switch.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Switch resources.
 */
export interface SwitchState {
    /**
     * Field `availabilityZone` has been deprecated from provider version 1.119.0. New field `zoneId` instead.
     *
     * @deprecated Field 'availability_zone' has been deprecated from provider version 1.119.0. New field 'zone_id' instead.
     */
    availabilityZone?: pulumi.Input<string>;
    /**
     * The CIDR block for the switch.
     */
    cidrBlock?: pulumi.Input<string>;
    /**
     * The switch description. Defaults to null.
     */
    description?: pulumi.Input<string>;
    /**
     * Field `name` has been deprecated from provider version 1.119.0. New field `vswitchName` instead.
     *
     * @deprecated Field 'name' has been deprecated from provider version 1.119.0. New field 'vswitch_name' instead.
     */
    name?: pulumi.Input<string>;
    /**
     * (Available in 1.119.0+) The status of the switch.
     */
    status?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * The VPC ID.
     */
    vpcId?: pulumi.Input<string>;
    /**
     * The name of the switch. Defaults to null.
     */
    vswitchName?: pulumi.Input<string>;
    /**
     * The AZ for the switch. **Note:** Required for a VPC switch.
     */
    zoneId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Switch resource.
 */
export interface SwitchArgs {
    /**
     * Field `availabilityZone` has been deprecated from provider version 1.119.0. New field `zoneId` instead.
     *
     * @deprecated Field 'availability_zone' has been deprecated from provider version 1.119.0. New field 'zone_id' instead.
     */
    availabilityZone?: pulumi.Input<string>;
    /**
     * The CIDR block for the switch.
     */
    cidrBlock: pulumi.Input<string>;
    /**
     * The switch description. Defaults to null.
     */
    description?: pulumi.Input<string>;
    /**
     * Field `name` has been deprecated from provider version 1.119.0. New field `vswitchName` instead.
     *
     * @deprecated Field 'name' has been deprecated from provider version 1.119.0. New field 'vswitch_name' instead.
     */
    name?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * The VPC ID.
     */
    vpcId: pulumi.Input<string>;
    /**
     * The name of the switch. Defaults to null.
     */
    vswitchName?: pulumi.Input<string>;
    /**
     * The AZ for the switch. **Note:** Required for a VPC switch.
     */
    zoneId?: pulumi.Input<string>;
}
