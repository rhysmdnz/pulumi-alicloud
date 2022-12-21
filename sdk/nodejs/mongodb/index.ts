// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./account";
export * from "./auditPolicy";
export * from "./getAccounts";
export * from "./getAuditPolicies";
export * from "./getInstances";
export * from "./getServerlessInstances";
export * from "./getShardingNetworkPrivateAddresses";
export * from "./getShardingNetworkPublicAddresses";
export * from "./getZones";
export * from "./instance";
export * from "./serverlessInstance";
export * from "./shardingInstance";
export * from "./shardingNetworkPrivateAddress";
export * from "./shardingNetworkPublicAddress";

// Import resources to register:
import { Account } from "./account";
import { AuditPolicy } from "./auditPolicy";
import { Instance } from "./instance";
import { ServerlessInstance } from "./serverlessInstance";
import { ShardingInstance } from "./shardingInstance";
import { ShardingNetworkPrivateAddress } from "./shardingNetworkPrivateAddress";
import { ShardingNetworkPublicAddress } from "./shardingNetworkPublicAddress";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "alicloud:mongodb/account:Account":
                return new Account(name, <any>undefined, { urn })
            case "alicloud:mongodb/auditPolicy:AuditPolicy":
                return new AuditPolicy(name, <any>undefined, { urn })
            case "alicloud:mongodb/instance:Instance":
                return new Instance(name, <any>undefined, { urn })
            case "alicloud:mongodb/serverlessInstance:ServerlessInstance":
                return new ServerlessInstance(name, <any>undefined, { urn })
            case "alicloud:mongodb/shardingInstance:ShardingInstance":
                return new ShardingInstance(name, <any>undefined, { urn })
            case "alicloud:mongodb/shardingNetworkPrivateAddress:ShardingNetworkPrivateAddress":
                return new ShardingNetworkPrivateAddress(name, <any>undefined, { urn })
            case "alicloud:mongodb/shardingNetworkPublicAddress:ShardingNetworkPublicAddress":
                return new ShardingNetworkPublicAddress(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("alicloud", "mongodb/account", _module)
pulumi.runtime.registerResourceModule("alicloud", "mongodb/auditPolicy", _module)
pulumi.runtime.registerResourceModule("alicloud", "mongodb/instance", _module)
pulumi.runtime.registerResourceModule("alicloud", "mongodb/serverlessInstance", _module)
pulumi.runtime.registerResourceModule("alicloud", "mongodb/shardingInstance", _module)
pulumi.runtime.registerResourceModule("alicloud", "mongodb/shardingNetworkPrivateAddress", _module)
pulumi.runtime.registerResourceModule("alicloud", "mongodb/shardingNetworkPublicAddress", _module)