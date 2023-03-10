// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This data source provides available lifecycle hook resources.
 *
 * > **NOTE:** Available in 1.72.0+
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const ds = pulumi.output(alicloud.ess.getLifecycleHooks({
 *     nameRegex: "lifecyclehook_name",
 *     scalingGroupId: "scaling_group_id",
 * }));
 *
 * export const firstLifecycleHook = ds.hooks[0].id;
 * ```
 */
export function getLifecycleHooks(args?: GetLifecycleHooksArgs, opts?: pulumi.InvokeOptions): Promise<GetLifecycleHooksResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("alicloud:ess/getLifecycleHooks:getLifecycleHooks", {
        "ids": args.ids,
        "nameRegex": args.nameRegex,
        "outputFile": args.outputFile,
        "scalingGroupId": args.scalingGroupId,
    }, opts);
}

/**
 * A collection of arguments for invoking getLifecycleHooks.
 */
export interface GetLifecycleHooksArgs {
    /**
     * A list of lifecycle hook IDs.
     */
    ids?: string[];
    /**
     * A regex string to filter resulting lifecycle hook by name.
     */
    nameRegex?: string;
    outputFile?: string;
    /**
     * Scaling group id the lifecycle hooks belong to.
     */
    scalingGroupId?: string;
}

/**
 * A collection of values returned by getLifecycleHooks.
 */
export interface GetLifecycleHooksResult {
    /**
     * A list of lifecycle hooks. Each element contains the following attributes:
     */
    readonly hooks: outputs.ess.GetLifecycleHooksHook[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * A list of lifecycle hook ids.
     */
    readonly ids: string[];
    readonly nameRegex?: string;
    /**
     * A list of lifecycle hook names.
     */
    readonly names: string[];
    readonly outputFile?: string;
    /**
     * ID of the scaling group.
     */
    readonly scalingGroupId?: string;
}

export function getLifecycleHooksOutput(args?: GetLifecycleHooksOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetLifecycleHooksResult> {
    return pulumi.output(args).apply(a => getLifecycleHooks(a, opts))
}

/**
 * A collection of arguments for invoking getLifecycleHooks.
 */
export interface GetLifecycleHooksOutputArgs {
    /**
     * A list of lifecycle hook IDs.
     */
    ids?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A regex string to filter resulting lifecycle hook by name.
     */
    nameRegex?: pulumi.Input<string>;
    outputFile?: pulumi.Input<string>;
    /**
     * Scaling group id the lifecycle hooks belong to.
     */
    scalingGroupId?: pulumi.Input<string>;
}
