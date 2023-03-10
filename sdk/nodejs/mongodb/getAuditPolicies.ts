// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This data source provides the Mongodb Audit Policies of the current Alibaba Cloud user.
 *
 * > **NOTE:** Available in v1.148.0+.
 *
 * ## Example Usage
 *
 * Basic Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const example = alicloud.mongodb.getAuditPolicies({
 *     dbInstanceId: "example_value",
 * });
 * export const mongodbAuditPolicyId1 = example.then(example => example.policies?[0]?.id);
 * ```
 */
export function getAuditPolicies(args: GetAuditPoliciesArgs, opts?: pulumi.InvokeOptions): Promise<GetAuditPoliciesResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("alicloud:mongodb/getAuditPolicies:getAuditPolicies", {
        "dbInstanceId": args.dbInstanceId,
        "outputFile": args.outputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getAuditPolicies.
 */
export interface GetAuditPoliciesArgs {
    /**
     * The ID of the instance.
     */
    dbInstanceId: string;
    outputFile?: string;
}

/**
 * A collection of values returned by getAuditPolicies.
 */
export interface GetAuditPoliciesResult {
    readonly dbInstanceId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly outputFile?: string;
    readonly policies: outputs.mongodb.GetAuditPoliciesPolicy[];
}

export function getAuditPoliciesOutput(args: GetAuditPoliciesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAuditPoliciesResult> {
    return pulumi.output(args).apply(a => getAuditPolicies(a, opts))
}

/**
 * A collection of arguments for invoking getAuditPolicies.
 */
export interface GetAuditPoliciesOutputArgs {
    /**
     * The ID of the instance.
     */
    dbInstanceId: pulumi.Input<string>;
    outputFile?: pulumi.Input<string>;
}
