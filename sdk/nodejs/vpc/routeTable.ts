// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
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
 * const fooNetwork = new alicloud.vpc.Network("fooNetwork", {
 *     cidrBlock: "172.16.0.0/12",
 *     vpcName: "vpc-example-name",
 * });
 * const fooRouteTable = new alicloud.vpc.RouteTable("fooRouteTable", {
 *     vpcId: fooNetwork.id,
 *     routeTableName: "route-table-example-name",
 *     description: "route-table-example-description",
 * });
 * ```
 *
 * ## Import
 *
 * The route table can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import alicloud:vpc/routeTable:RouteTable foo vtb-abc123456
 * ```
 */
export class RouteTable extends pulumi.CustomResource {
    /**
     * Get an existing RouteTable resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RouteTableState, opts?: pulumi.CustomResourceOptions): RouteTable {
        return new RouteTable(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'alicloud:vpc/routeTable:RouteTable';

    /**
     * Returns true if the given object is an instance of RouteTable.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RouteTable {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RouteTable.__pulumiType;
    }

    /**
     * The type of routing table created. Valid values are `VSwitch` and `Gateway`
     */
    public readonly associateType!: pulumi.Output<string>;
    /**
     * The description of the route table instance.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Field `name` has been deprecated from provider version 1.119.1. New field `routeTableName` instead.
     *
     * @deprecated Field 'name' has been deprecated from provider version 1.119.1. New field 'route_table_name' instead.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The name of the route table.
     */
    public readonly routeTableName!: pulumi.Output<string>;
    /**
     * (Available in v1.119.1+) The status of the route table.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * The vpcId of the route table, the field can't be changed.
     */
    public readonly vpcId!: pulumi.Output<string>;

    /**
     * Create a RouteTable resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RouteTableArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RouteTableArgs | RouteTableState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RouteTableState | undefined;
            resourceInputs["associateType"] = state ? state.associateType : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["routeTableName"] = state ? state.routeTableName : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["vpcId"] = state ? state.vpcId : undefined;
        } else {
            const args = argsOrState as RouteTableArgs | undefined;
            if ((!args || args.vpcId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vpcId'");
            }
            resourceInputs["associateType"] = args ? args.associateType : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["routeTableName"] = args ? args.routeTableName : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["vpcId"] = args ? args.vpcId : undefined;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(RouteTable.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RouteTable resources.
 */
export interface RouteTableState {
    /**
     * The type of routing table created. Valid values are `VSwitch` and `Gateway`
     */
    associateType?: pulumi.Input<string>;
    /**
     * The description of the route table instance.
     */
    description?: pulumi.Input<string>;
    /**
     * Field `name` has been deprecated from provider version 1.119.1. New field `routeTableName` instead.
     *
     * @deprecated Field 'name' has been deprecated from provider version 1.119.1. New field 'route_table_name' instead.
     */
    name?: pulumi.Input<string>;
    /**
     * The name of the route table.
     */
    routeTableName?: pulumi.Input<string>;
    /**
     * (Available in v1.119.1+) The status of the route table.
     */
    status?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * The vpcId of the route table, the field can't be changed.
     */
    vpcId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a RouteTable resource.
 */
export interface RouteTableArgs {
    /**
     * The type of routing table created. Valid values are `VSwitch` and `Gateway`
     */
    associateType?: pulumi.Input<string>;
    /**
     * The description of the route table instance.
     */
    description?: pulumi.Input<string>;
    /**
     * Field `name` has been deprecated from provider version 1.119.1. New field `routeTableName` instead.
     *
     * @deprecated Field 'name' has been deprecated from provider version 1.119.1. New field 'route_table_name' instead.
     */
    name?: pulumi.Input<string>;
    /**
     * The name of the route table.
     */
    routeTableName?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * The vpcId of the route table, the field can't be changed.
     */
    vpcId: pulumi.Input<string>;
}
