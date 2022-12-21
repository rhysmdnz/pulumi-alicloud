// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This data source provides the resource manager folders of the current Alibaba Cloud user.
 *
 * > **NOTE:**  Available in 1.84.0+.
 *
 * > **NOTE:**  You can view only the information of the first-level child folders of the specified folder.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const example = pulumi.output(alicloud.resourcemanager.getFolders({
 *     nameRegex: "tftest",
 * }));
 *
 * export const firstFolderId = example.folders[0].id;
 * ```
 */
export function getFolders(args?: GetFoldersArgs, opts?: pulumi.InvokeOptions): Promise<GetFoldersResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("alicloud:resourcemanager/getFolders:getFolders", {
        "enableDetails": args.enableDetails,
        "ids": args.ids,
        "nameRegex": args.nameRegex,
        "outputFile": args.outputFile,
        "parentFolderId": args.parentFolderId,
        "queryKeyword": args.queryKeyword,
    }, opts);
}

/**
 * A collection of arguments for invoking getFolders.
 */
export interface GetFoldersArgs {
    /**
     * -(Optional, Available in v1.114.0+) Default to `false`. Set it to true can output more details.
     */
    enableDetails?: boolean;
    /**
     * A list of resource manager folders IDs.
     */
    ids?: string[];
    /**
     * A regex string to filter results by folder name.
     */
    nameRegex?: string;
    outputFile?: string;
    /**
     * The ID of the parent folder.
     */
    parentFolderId?: string;
    /**
     * The query keyword.
     */
    queryKeyword?: string;
}

/**
 * A collection of values returned by getFolders.
 */
export interface GetFoldersResult {
    readonly enableDetails?: boolean;
    /**
     * A list of folders. Each element contains the following attributes:
     */
    readonly folders: outputs.resourcemanager.GetFoldersFolder[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * A list of folder IDs.
     */
    readonly ids: string[];
    readonly nameRegex?: string;
    /**
     * A list of folder names.
     */
    readonly names: string[];
    readonly outputFile?: string;
    readonly parentFolderId?: string;
    readonly queryKeyword?: string;
}

export function getFoldersOutput(args?: GetFoldersOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetFoldersResult> {
    return pulumi.output(args).apply(a => getFolders(a, opts))
}

/**
 * A collection of arguments for invoking getFolders.
 */
export interface GetFoldersOutputArgs {
    /**
     * -(Optional, Available in v1.114.0+) Default to `false`. Set it to true can output more details.
     */
    enableDetails?: pulumi.Input<boolean>;
    /**
     * A list of resource manager folders IDs.
     */
    ids?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A regex string to filter results by folder name.
     */
    nameRegex?: pulumi.Input<string>;
    outputFile?: pulumi.Input<string>;
    /**
     * The ID of the parent folder.
     */
    parentFolderId?: pulumi.Input<string>;
    /**
     * The query keyword.
     */
    queryKeyword?: pulumi.Input<string>;
}