// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * This data source provides the identity of the current user.
 *
 * > **NOTE:** Available in 1.65.0+.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const current = pulumi.output(alicloud.getCallerIdentity());
 *
 * export const currentUserArn = current.id;
 * ```
 */
export function getCallerIdentity(opts?: pulumi.InvokeOptions): Promise<GetCallerIdentityResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("alicloud:index/getCallerIdentity:getCallerIdentity", {
    }, opts);
}

/**
 * A collection of values returned by getCallerIdentity.
 */
export interface GetCallerIdentityResult {
    /**
     * Account ID.
     */
    readonly accountId: string;
    /**
     * The Alibaba Cloud Resource Name (ARN) of the user making the call.
     */
    readonly arn: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The type of the princiapal. RAMUser for users.
     */
    readonly identityType: string;
}