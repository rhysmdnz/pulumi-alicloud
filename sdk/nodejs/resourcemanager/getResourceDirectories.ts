// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This data source provides the Resource Manager Resource Directories of the current Alibaba Cloud user.
 *
 * > **NOTE:**  Available in 1.86.0+.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const defaultResourceDirectories = pulumi.output(alicloud.resourcemanager.getResourceDirectories());
 *
 * export const resourceDirectoryId = defaultResourceDirectories.directories[0].id;
 * ```
 */
export function getResourceDirectories(args?: GetResourceDirectoriesArgs, opts?: pulumi.InvokeOptions): Promise<GetResourceDirectoriesResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("alicloud:resourcemanager/getResourceDirectories:getResourceDirectories", {
        "outputFile": args.outputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getResourceDirectories.
 */
export interface GetResourceDirectoriesArgs {
    outputFile?: string;
}

/**
 * A collection of values returned by getResourceDirectories.
 */
export interface GetResourceDirectoriesResult {
    /**
     * A list of resource directories. Each element contains the following attributes:
     */
    readonly directories: outputs.resourcemanager.GetResourceDirectoriesDirectory[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly outputFile?: string;
}

export function getResourceDirectoriesOutput(args?: GetResourceDirectoriesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetResourceDirectoriesResult> {
    return pulumi.output(args).apply(a => getResourceDirectories(a, opts))
}

/**
 * A collection of arguments for invoking getResourceDirectories.
 */
export interface GetResourceDirectoriesOutputArgs {
    outputFile?: pulumi.Input<string>;
}
