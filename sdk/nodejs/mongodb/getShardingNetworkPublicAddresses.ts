// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This data source provides the Mongodb Sharding Network Public Addresses of the current Alibaba Cloud user.
 *
 * > **NOTE:** Available in v1.149.0+.
 *
 * ## Example Usage
 *
 * Basic Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const example = alicloud.mongodb.getShardingNetworkPublicAddresses({
 *     dbInstanceId: "example_value",
 *     nodeId: "example_value",
 *     role: "Primary",
 * });
 * export const mongodbShardingNetworkPublicAddressDbInstanceId1 = example.then(example => example.addresses?[0]?.dbInstanceId);
 * ```
 */
export function getShardingNetworkPublicAddresses(args: GetShardingNetworkPublicAddressesArgs, opts?: pulumi.InvokeOptions): Promise<GetShardingNetworkPublicAddressesResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("alicloud:mongodb/getShardingNetworkPublicAddresses:getShardingNetworkPublicAddresses", {
        "dbInstanceId": args.dbInstanceId,
        "nodeId": args.nodeId,
        "outputFile": args.outputFile,
        "role": args.role,
    }, opts);
}

/**
 * A collection of arguments for invoking getShardingNetworkPublicAddresses.
 */
export interface GetShardingNetworkPublicAddressesArgs {
    /**
     * The db instance id.
     */
    dbInstanceId: string;
    /**
     * The ID of the `mongos`, `shard`, or `Configserver` node in the sharded cluster instance.
     */
    nodeId?: string;
    outputFile?: string;
    /**
     * The role of the node.
     */
    role?: string;
}

/**
 * A collection of values returned by getShardingNetworkPublicAddresses.
 */
export interface GetShardingNetworkPublicAddressesResult {
    readonly addresses: outputs.mongodb.GetShardingNetworkPublicAddressesAddress[];
    readonly dbInstanceId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly nodeId?: string;
    readonly outputFile?: string;
    readonly role?: string;
}

export function getShardingNetworkPublicAddressesOutput(args: GetShardingNetworkPublicAddressesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetShardingNetworkPublicAddressesResult> {
    return pulumi.output(args).apply(a => getShardingNetworkPublicAddresses(a, opts))
}

/**
 * A collection of arguments for invoking getShardingNetworkPublicAddresses.
 */
export interface GetShardingNetworkPublicAddressesOutputArgs {
    /**
     * The db instance id.
     */
    dbInstanceId: pulumi.Input<string>;
    /**
     * The ID of the `mongos`, `shard`, or `Configserver` node in the sharded cluster instance.
     */
    nodeId?: pulumi.Input<string>;
    outputFile?: pulumi.Input<string>;
    /**
     * The role of the node.
     */
    role?: pulumi.Input<string>;
}
