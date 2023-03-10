// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./dedicatedHost";
export * from "./dedicatedHostAccount";
export * from "./dedicatedHostGroup";
export * from "./getDedicatedHostAccounts";
export * from "./getDedicatedHostGroups";
export * from "./getDedicatedHosts";
export * from "./getHostEcsLevelInfos";
export * from "./getZones";

// Import resources to register:
import { DedicatedHost } from "./dedicatedHost";
import { DedicatedHostAccount } from "./dedicatedHostAccount";
import { DedicatedHostGroup } from "./dedicatedHostGroup";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "alicloud:cddc/dedicatedHost:DedicatedHost":
                return new DedicatedHost(name, <any>undefined, { urn })
            case "alicloud:cddc/dedicatedHostAccount:DedicatedHostAccount":
                return new DedicatedHostAccount(name, <any>undefined, { urn })
            case "alicloud:cddc/dedicatedHostGroup:DedicatedHostGroup":
                return new DedicatedHostGroup(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("alicloud", "cddc/dedicatedHost", _module)
pulumi.runtime.registerResourceModule("alicloud", "cddc/dedicatedHostAccount", _module)
pulumi.runtime.registerResourceModule("alicloud", "cddc/dedicatedHostGroup", _module)
