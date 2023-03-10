// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This data source provides a list of KMS keys in an Alibaba Cloud account according to the specified filters.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * // Declare the data source
 * const kmsKeysDs = pulumi.output(alicloud.kms.getKeys({
 *     descriptionRegex: "Hello KMS",
 *     outputFile: "kms_keys.json",
 * }));
 *
 * export const firstKeyId = kmsKeysDs.keys[0].id;
 * ```
 */
export function getKeys(args?: GetKeysArgs, opts?: pulumi.InvokeOptions): Promise<GetKeysResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("alicloud:kms/getKeys:getKeys", {
        "descriptionRegex": args.descriptionRegex,
        "enableDetails": args.enableDetails,
        "filters": args.filters,
        "ids": args.ids,
        "outputFile": args.outputFile,
        "status": args.status,
    }, opts);
}

/**
 * A collection of arguments for invoking getKeys.
 */
export interface GetKeysArgs {
    /**
     * A regex string to filter the results by the KMS key description.
     */
    descriptionRegex?: string;
    enableDetails?: boolean;
    filters?: string;
    /**
     * A list of KMS key IDs.
     */
    ids?: string[];
    outputFile?: string;
    /**
     * Filter the results by status of the KMS keys. Valid values: `Enabled`, `Disabled`, `PendingDeletion`.
     */
    status?: string;
}

/**
 * A collection of values returned by getKeys.
 */
export interface GetKeysResult {
    readonly descriptionRegex?: string;
    readonly enableDetails?: boolean;
    readonly filters?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * A list of KMS key IDs.
     */
    readonly ids: string[];
    /**
     * A list of KMS keys. Each element contains the following attributes:
     */
    readonly keys: outputs.kms.GetKeysKey[];
    readonly outputFile?: string;
    /**
     * Status of the key. Possible values: `Enabled`, `Disabled` and `PendingDeletion`.
     */
    readonly status?: string;
}

export function getKeysOutput(args?: GetKeysOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetKeysResult> {
    return pulumi.output(args).apply(a => getKeys(a, opts))
}

/**
 * A collection of arguments for invoking getKeys.
 */
export interface GetKeysOutputArgs {
    /**
     * A regex string to filter the results by the KMS key description.
     */
    descriptionRegex?: pulumi.Input<string>;
    enableDetails?: pulumi.Input<boolean>;
    filters?: pulumi.Input<string>;
    /**
     * A list of KMS key IDs.
     */
    ids?: pulumi.Input<pulumi.Input<string>[]>;
    outputFile?: pulumi.Input<string>;
    /**
     * Filter the results by status of the KMS keys. Valid values: `Enabled`, `Disabled`, `PendingDeletion`.
     */
    status?: pulumi.Input<string>;
}
