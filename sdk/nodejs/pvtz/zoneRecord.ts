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
 * const zone = new alicloud.pvtz.Zone("zone", {});
 * const foo = new alicloud.pvtz.ZoneRecord("foo", {
 *     zoneId: zone.id,
 *     rr: "www",
 *     type: "CNAME",
 *     value: "bbb.test.com",
 *     ttl: 60,
 * });
 * ```
 *
 * ## Import
 *
 * Private Zone Record can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import alicloud:pvtz/zoneRecord:ZoneRecord example abc123456
 * ```
 */
export class ZoneRecord extends pulumi.CustomResource {
    /**
     * Get an existing ZoneRecord resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ZoneRecordState, opts?: pulumi.CustomResourceOptions): ZoneRecord {
        return new ZoneRecord(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'alicloud:pvtz/zoneRecord:ZoneRecord';

    /**
     * Returns true if the given object is an instance of ZoneRecord.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ZoneRecord {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ZoneRecord.__pulumiType;
    }

    /**
     * User language.
     */
    public readonly lang!: pulumi.Output<string | undefined>;
    /**
     * The priority of the Private Zone Record. At present, only can "MX" record support it. Valid values: [1-99]. Default to 1.
     */
    public readonly priority!: pulumi.Output<number | undefined>;
    /**
     * The Private Zone Record ID.
     */
    public /*out*/ readonly recordId!: pulumi.Output<string>;
    /**
     * The remark of the Private Zone Record.
     */
    public readonly remark!: pulumi.Output<string | undefined>;
    /**
     * The resource record of the Private Zone Record.
     *
     * @deprecated Field 'resource_record' has been deprecated from version 1.109.0. Use 'rr' instead.
     */
    public readonly resourceRecord!: pulumi.Output<string>;
    /**
     * The rr of the Private Zone Record.
     */
    public readonly rr!: pulumi.Output<string>;
    /**
     * Resolve record status. Value:
     * - ENABLE: enable resolution.
     * - DISABLE: pause parsing.
     */
    public readonly status!: pulumi.Output<string | undefined>;
    /**
     * The ttl of the Private Zone Record. Default to `60`.
     */
    public readonly ttl!: pulumi.Output<number | undefined>;
    /**
     * The type of the Private Zone Record. Valid values: A, CNAME, TXT, MX, PTR, SRV.
     */
    public readonly type!: pulumi.Output<string>;
    public readonly userClientIp!: pulumi.Output<string | undefined>;
    /**
     * The value of the Private Zone Record.
     */
    public readonly value!: pulumi.Output<string>;
    /**
     * The name of the Private Zone Record.
     */
    public readonly zoneId!: pulumi.Output<string>;

    /**
     * Create a ZoneRecord resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ZoneRecordArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ZoneRecordArgs | ZoneRecordState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ZoneRecordState | undefined;
            resourceInputs["lang"] = state ? state.lang : undefined;
            resourceInputs["priority"] = state ? state.priority : undefined;
            resourceInputs["recordId"] = state ? state.recordId : undefined;
            resourceInputs["remark"] = state ? state.remark : undefined;
            resourceInputs["resourceRecord"] = state ? state.resourceRecord : undefined;
            resourceInputs["rr"] = state ? state.rr : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["ttl"] = state ? state.ttl : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
            resourceInputs["userClientIp"] = state ? state.userClientIp : undefined;
            resourceInputs["value"] = state ? state.value : undefined;
            resourceInputs["zoneId"] = state ? state.zoneId : undefined;
        } else {
            const args = argsOrState as ZoneRecordArgs | undefined;
            if ((!args || args.type === undefined) && !opts.urn) {
                throw new Error("Missing required property 'type'");
            }
            if ((!args || args.value === undefined) && !opts.urn) {
                throw new Error("Missing required property 'value'");
            }
            if ((!args || args.zoneId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zoneId'");
            }
            resourceInputs["lang"] = args ? args.lang : undefined;
            resourceInputs["priority"] = args ? args.priority : undefined;
            resourceInputs["remark"] = args ? args.remark : undefined;
            resourceInputs["resourceRecord"] = args ? args.resourceRecord : undefined;
            resourceInputs["rr"] = args ? args.rr : undefined;
            resourceInputs["status"] = args ? args.status : undefined;
            resourceInputs["ttl"] = args ? args.ttl : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["userClientIp"] = args ? args.userClientIp : undefined;
            resourceInputs["value"] = args ? args.value : undefined;
            resourceInputs["zoneId"] = args ? args.zoneId : undefined;
            resourceInputs["recordId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ZoneRecord.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ZoneRecord resources.
 */
export interface ZoneRecordState {
    /**
     * User language.
     */
    lang?: pulumi.Input<string>;
    /**
     * The priority of the Private Zone Record. At present, only can "MX" record support it. Valid values: [1-99]. Default to 1.
     */
    priority?: pulumi.Input<number>;
    /**
     * The Private Zone Record ID.
     */
    recordId?: pulumi.Input<string>;
    /**
     * The remark of the Private Zone Record.
     */
    remark?: pulumi.Input<string>;
    /**
     * The resource record of the Private Zone Record.
     *
     * @deprecated Field 'resource_record' has been deprecated from version 1.109.0. Use 'rr' instead.
     */
    resourceRecord?: pulumi.Input<string>;
    /**
     * The rr of the Private Zone Record.
     */
    rr?: pulumi.Input<string>;
    /**
     * Resolve record status. Value:
     * - ENABLE: enable resolution.
     * - DISABLE: pause parsing.
     */
    status?: pulumi.Input<string>;
    /**
     * The ttl of the Private Zone Record. Default to `60`.
     */
    ttl?: pulumi.Input<number>;
    /**
     * The type of the Private Zone Record. Valid values: A, CNAME, TXT, MX, PTR, SRV.
     */
    type?: pulumi.Input<string>;
    userClientIp?: pulumi.Input<string>;
    /**
     * The value of the Private Zone Record.
     */
    value?: pulumi.Input<string>;
    /**
     * The name of the Private Zone Record.
     */
    zoneId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ZoneRecord resource.
 */
export interface ZoneRecordArgs {
    /**
     * User language.
     */
    lang?: pulumi.Input<string>;
    /**
     * The priority of the Private Zone Record. At present, only can "MX" record support it. Valid values: [1-99]. Default to 1.
     */
    priority?: pulumi.Input<number>;
    /**
     * The remark of the Private Zone Record.
     */
    remark?: pulumi.Input<string>;
    /**
     * The resource record of the Private Zone Record.
     *
     * @deprecated Field 'resource_record' has been deprecated from version 1.109.0. Use 'rr' instead.
     */
    resourceRecord?: pulumi.Input<string>;
    /**
     * The rr of the Private Zone Record.
     */
    rr?: pulumi.Input<string>;
    /**
     * Resolve record status. Value:
     * - ENABLE: enable resolution.
     * - DISABLE: pause parsing.
     */
    status?: pulumi.Input<string>;
    /**
     * The ttl of the Private Zone Record. Default to `60`.
     */
    ttl?: pulumi.Input<number>;
    /**
     * The type of the Private Zone Record. Valid values: A, CNAME, TXT, MX, PTR, SRV.
     */
    type: pulumi.Input<string>;
    userClientIp?: pulumi.Input<string>;
    /**
     * The value of the Private Zone Record.
     */
    value: pulumi.Input<string>;
    /**
     * The name of the Private Zone Record.
     */
    zoneId: pulumi.Input<string>;
}