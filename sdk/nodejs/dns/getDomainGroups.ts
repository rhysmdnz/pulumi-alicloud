// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

export function getDomainGroups(args?: GetDomainGroupsArgs, opts?: pulumi.InvokeOptions): Promise<GetDomainGroupsResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("alicloud:dns/getDomainGroups:getDomainGroups", {
        "ids": args.ids,
        "nameRegex": args.nameRegex,
        "outputFile": args.outputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getDomainGroups.
 */
export interface GetDomainGroupsArgs {
    ids?: string[];
    nameRegex?: string;
    outputFile?: string;
}

/**
 * A collection of values returned by getDomainGroups.
 */
export interface GetDomainGroupsResult {
    readonly groups: outputs.dns.GetDomainGroupsGroup[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly ids: string[];
    readonly nameRegex?: string;
    readonly names: string[];
    readonly outputFile?: string;
}

export function getDomainGroupsOutput(args?: GetDomainGroupsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDomainGroupsResult> {
    return pulumi.output(args).apply(a => getDomainGroups(a, opts))
}

/**
 * A collection of arguments for invoking getDomainGroups.
 */
export interface GetDomainGroupsOutputArgs {
    ids?: pulumi.Input<pulumi.Input<string>[]>;
    nameRegex?: pulumi.Input<string>;
    outputFile?: pulumi.Input<string>;
}
