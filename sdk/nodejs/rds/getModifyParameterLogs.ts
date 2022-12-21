// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This data source provides the Rds Modify Parameter Logs of the current Alibaba Cloud user.
 *
 * > **NOTE:** Available in v1.174.0+.
 *
 * ## Example Usage
 *
 * Basic Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const example = pulumi.output(alicloud.rds.getModifyParameterLogs({
 *     dbInstanceId: "example_value",
 *     endTime: "2022-06-08T13:56Z",
 *     startTime: "2022-06-04T13:56Z",
 * }));
 * ```
 */
export function getModifyParameterLogs(args: GetModifyParameterLogsArgs, opts?: pulumi.InvokeOptions): Promise<GetModifyParameterLogsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("alicloud:rds/getModifyParameterLogs:getModifyParameterLogs", {
        "dbInstanceId": args.dbInstanceId,
        "endTime": args.endTime,
        "outputFile": args.outputFile,
        "startTime": args.startTime,
    }, opts);
}

/**
 * A collection of arguments for invoking getModifyParameterLogs.
 */
export interface GetModifyParameterLogsArgs {
    /**
     * The db instance id.
     */
    dbInstanceId: string;
    /**
     * The end time.
     */
    endTime: string;
    outputFile?: string;
    /**
     * The start time.
     */
    startTime: string;
}

/**
 * A collection of values returned by getModifyParameterLogs.
 */
export interface GetModifyParameterLogsResult {
    readonly dbInstanceId: string;
    readonly endTime: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly logs: outputs.rds.GetModifyParameterLogsLog[];
    readonly outputFile?: string;
    readonly startTime: string;
}

export function getModifyParameterLogsOutput(args: GetModifyParameterLogsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetModifyParameterLogsResult> {
    return pulumi.output(args).apply(a => getModifyParameterLogs(a, opts))
}

/**
 * A collection of arguments for invoking getModifyParameterLogs.
 */
export interface GetModifyParameterLogsOutputArgs {
    /**
     * The db instance id.
     */
    dbInstanceId: pulumi.Input<string>;
    /**
     * The end time.
     */
    endTime: pulumi.Input<string>;
    outputFile?: pulumi.Input<string>;
    /**
     * The start time.
     */
    startTime: pulumi.Input<string>;
}