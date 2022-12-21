// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const _default = new alicloud.slb.LoadBalancer("default", {});
 * const slbsDs = alicloud.slb.getLoadBalancers({
 *     nameRegex: "sample_slb",
 * });
 * export const firstSlbId = slbsDs.then(slbsDs => slbsDs.slbs?[0]?.id);
 * ```
 */
export function getLoadBalancers(args?: GetLoadBalancersArgs, opts?: pulumi.InvokeOptions): Promise<GetLoadBalancersResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("alicloud:slb/getLoadBalancers:getLoadBalancers", {
        "address": args.address,
        "addressIpVersion": args.addressIpVersion,
        "addressType": args.addressType,
        "enableDetails": args.enableDetails,
        "ids": args.ids,
        "internetChargeType": args.internetChargeType,
        "loadBalancerName": args.loadBalancerName,
        "masterZoneId": args.masterZoneId,
        "nameRegex": args.nameRegex,
        "networkType": args.networkType,
        "outputFile": args.outputFile,
        "pageNumber": args.pageNumber,
        "pageSize": args.pageSize,
        "paymentType": args.paymentType,
        "resourceGroupId": args.resourceGroupId,
        "serverId": args.serverId,
        "serverIntranetAddress": args.serverIntranetAddress,
        "slaveZoneId": args.slaveZoneId,
        "status": args.status,
        "tags": args.tags,
        "vpcId": args.vpcId,
        "vswitchId": args.vswitchId,
    }, opts);
}

/**
 * A collection of arguments for invoking getLoadBalancers.
 */
export interface GetLoadBalancersArgs {
    /**
     * Service address of the SLBs.
     */
    address?: string;
    addressIpVersion?: string;
    addressType?: string;
    enableDetails?: boolean;
    /**
     * A list of SLBs IDs.
     */
    ids?: string[];
    internetChargeType?: string;
    loadBalancerName?: string;
    masterZoneId?: string;
    /**
     * A regex string to filter results by SLB name.
     */
    nameRegex?: string;
    /**
     * Network type of the SLBs. Valid values: `vpc` and `classic`.
     */
    networkType?: string;
    outputFile?: string;
    pageNumber?: number;
    pageSize?: number;
    paymentType?: string;
    /**
     * The Id of resource group which SLB belongs.
     */
    resourceGroupId?: string;
    serverId?: string;
    serverIntranetAddress?: string;
    slaveZoneId?: string;
    /**
     * SLB current status. Possible values: `inactive`, `active` and `locked`.
     */
    status?: string;
    /**
     * A map of tags assigned to the SLB instances. The `tags` can have a maximum of 5 tag. It must be in the format:
     * ```typescript
     * import * as pulumi from "@pulumi/pulumi";
     * import * as alicloud from "@pulumi/alicloud";
     *
     * const taggedInstances = pulumi.output(alicloud.slb.getLoadBalancers({
     *     tags: {
     *         tagKey1: "tagValue1",
     *         tagKey2: "tagValue2",
     *     },
     * }));
     * ```
     */
    tags?: {[key: string]: any};
    /**
     * ID of the VPC linked to the SLBs.
     */
    vpcId?: string;
    /**
     * ID of the VSwitch linked to the SLBs.
     */
    vswitchId?: string;
}

/**
 * A collection of values returned by getLoadBalancers.
 */
export interface GetLoadBalancersResult {
    /**
     * Service address of the SLB.
     */
    readonly address?: string;
    readonly addressIpVersion?: string;
    readonly addressType?: string;
    readonly balancers: outputs.slb.GetLoadBalancersBalancer[];
    readonly enableDetails?: boolean;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * A list of slb IDs.
     */
    readonly ids: string[];
    readonly internetChargeType?: string;
    readonly loadBalancerName?: string;
    readonly masterZoneId?: string;
    readonly nameRegex?: string;
    /**
     * A list of slb names.
     */
    readonly names: string[];
    /**
     * Network type of the SLB. Possible values: `vpc` and `classic`.
     */
    readonly networkType?: string;
    readonly outputFile?: string;
    readonly pageNumber?: number;
    readonly pageSize?: number;
    readonly paymentType?: string;
    readonly resourceGroupId?: string;
    readonly serverId?: string;
    readonly serverIntranetAddress?: string;
    readonly slaveZoneId?: string;
    /**
     * A list of SLBs. Each element contains the following attributes:
     *
     * @deprecated Field 'slbs' has deprecated from v1.123.1 and replace by 'balancers'.
     */
    readonly slbs: outputs.slb.GetLoadBalancersSlb[];
    /**
     * SLB current status. Possible values: `inactive`, `active` and `locked`.
     */
    readonly status?: string;
    /**
     * A map of tags assigned to the SLB instance.
     */
    readonly tags?: {[key: string]: any};
    readonly totalCount: number;
    /**
     * ID of the VPC the SLB belongs to.
     */
    readonly vpcId?: string;
    /**
     * ID of the VSwitch the SLB belongs to.
     */
    readonly vswitchId?: string;
}

export function getLoadBalancersOutput(args?: GetLoadBalancersOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetLoadBalancersResult> {
    return pulumi.output(args).apply(a => getLoadBalancers(a, opts))
}

/**
 * A collection of arguments for invoking getLoadBalancers.
 */
export interface GetLoadBalancersOutputArgs {
    /**
     * Service address of the SLBs.
     */
    address?: pulumi.Input<string>;
    addressIpVersion?: pulumi.Input<string>;
    addressType?: pulumi.Input<string>;
    enableDetails?: pulumi.Input<boolean>;
    /**
     * A list of SLBs IDs.
     */
    ids?: pulumi.Input<pulumi.Input<string>[]>;
    internetChargeType?: pulumi.Input<string>;
    loadBalancerName?: pulumi.Input<string>;
    masterZoneId?: pulumi.Input<string>;
    /**
     * A regex string to filter results by SLB name.
     */
    nameRegex?: pulumi.Input<string>;
    /**
     * Network type of the SLBs. Valid values: `vpc` and `classic`.
     */
    networkType?: pulumi.Input<string>;
    outputFile?: pulumi.Input<string>;
    pageNumber?: pulumi.Input<number>;
    pageSize?: pulumi.Input<number>;
    paymentType?: pulumi.Input<string>;
    /**
     * The Id of resource group which SLB belongs.
     */
    resourceGroupId?: pulumi.Input<string>;
    serverId?: pulumi.Input<string>;
    serverIntranetAddress?: pulumi.Input<string>;
    slaveZoneId?: pulumi.Input<string>;
    /**
     * SLB current status. Possible values: `inactive`, `active` and `locked`.
     */
    status?: pulumi.Input<string>;
    /**
     * A map of tags assigned to the SLB instances. The `tags` can have a maximum of 5 tag. It must be in the format:
     * ```typescript
     * import * as pulumi from "@pulumi/pulumi";
     * import * as alicloud from "@pulumi/alicloud";
     *
     * const taggedInstances = pulumi.output(alicloud.slb.getLoadBalancers({
     *     tags: {
     *         tagKey1: "tagValue1",
     *         tagKey2: "tagValue2",
     *     },
     * }));
     * ```
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * ID of the VPC linked to the SLBs.
     */
    vpcId?: pulumi.Input<string>;
    /**
     * ID of the VSwitch linked to the SLBs.
     */
    vswitchId?: pulumi.Input<string>;
}