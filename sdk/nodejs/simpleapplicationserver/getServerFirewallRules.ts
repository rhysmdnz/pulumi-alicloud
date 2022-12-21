// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This data source provides the Simple Application Server Firewall Rules of the current Alibaba Cloud user.
 *
 * > **NOTE:** Available in v1.143.0+.
 *
 * ## Example Usage
 *
 * Basic Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const ids = alicloud.simpleapplicationserver.getServerFirewallRules({
 *     instanceId: "example_value",
 *     ids: [
 *         "example_value-1",
 *         "example_value-2",
 *     ],
 * });
 * export const simpleApplicationServerFirewallRuleId1 = ids.then(ids => ids.rules?[0]?.id);
 * ```
 */
export function getServerFirewallRules(args: GetServerFirewallRulesArgs, opts?: pulumi.InvokeOptions): Promise<GetServerFirewallRulesResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("alicloud:simpleapplicationserver/getServerFirewallRules:getServerFirewallRules", {
        "ids": args.ids,
        "instanceId": args.instanceId,
        "outputFile": args.outputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getServerFirewallRules.
 */
export interface GetServerFirewallRulesArgs {
    /**
     * A list of Firewall Rule IDs.
     */
    ids?: string[];
    /**
     * Alibaba Cloud simple application server instance ID.
     */
    instanceId: string;
    outputFile?: string;
}

/**
 * A collection of values returned by getServerFirewallRules.
 */
export interface GetServerFirewallRulesResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly ids: string[];
    readonly instanceId: string;
    readonly outputFile?: string;
    readonly rules: outputs.simpleapplicationserver.GetServerFirewallRulesRule[];
}

export function getServerFirewallRulesOutput(args: GetServerFirewallRulesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetServerFirewallRulesResult> {
    return pulumi.output(args).apply(a => getServerFirewallRules(a, opts))
}

/**
 * A collection of arguments for invoking getServerFirewallRules.
 */
export interface GetServerFirewallRulesOutputArgs {
    /**
     * A list of Firewall Rule IDs.
     */
    ids?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Alibaba Cloud simple application server instance ID.
     */
    instanceId: pulumi.Input<string>;
    outputFile?: pulumi.Input<string>;
}