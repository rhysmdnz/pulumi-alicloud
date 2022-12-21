// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provide  a data source to retrieve the type of protocol used to create NAS file system.
 *
 * > **NOTE:** Available in 1.42.0
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const defaultProtocols = pulumi.output(alicloud.nas.getProtocols({
 *     outputFile: "protocols.txt",
 *     type: "Performance",
 *     zoneId: "cn-beijing-e",
 * }));
 *
 * export const nasProtocolsProtocol = defaultProtocols.protocols[0];
 * ```
 */
export function getProtocols(args: GetProtocolsArgs, opts?: pulumi.InvokeOptions): Promise<GetProtocolsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("alicloud:nas/getProtocols:getProtocols", {
        "outputFile": args.outputFile,
        "type": args.type,
        "zoneId": args.zoneId,
    }, opts);
}

/**
 * A collection of arguments for invoking getProtocols.
 */
export interface GetProtocolsArgs {
    outputFile?: string;
    /**
     * The file system type. Valid Values: `Performance` and `Capacity`.
     */
    type: string;
    /**
     * String to filter results by zone id.
     */
    zoneId?: string;
}

/**
 * A collection of values returned by getProtocols.
 */
export interface GetProtocolsResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly outputFile?: string;
    /**
     * A list of supported protocol type..
     */
    readonly protocols: string[];
    readonly type: string;
    readonly zoneId?: string;
}

export function getProtocolsOutput(args: GetProtocolsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetProtocolsResult> {
    return pulumi.output(args).apply(a => getProtocols(a, opts))
}

/**
 * A collection of arguments for invoking getProtocols.
 */
export interface GetProtocolsOutputArgs {
    outputFile?: pulumi.Input<string>;
    /**
     * The file system type. Valid Values: `Performance` and `Capacity`.
     */
    type: pulumi.Input<string>;
    /**
     * String to filter results by zone id.
     */
    zoneId?: pulumi.Input<string>;
}