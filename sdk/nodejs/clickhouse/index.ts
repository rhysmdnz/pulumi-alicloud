// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./account";
export * from "./backupPolicy";
export * from "./dbCluster";
export * from "./getAccounts";
export * from "./getBackupPolicies";
export * from "./getDbClusters";
export * from "./getRegions";

// Import resources to register:
import { Account } from "./account";
import { BackupPolicy } from "./backupPolicy";
import { DbCluster } from "./dbCluster";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "alicloud:clickhouse/account:Account":
                return new Account(name, <any>undefined, { urn })
            case "alicloud:clickhouse/backupPolicy:BackupPolicy":
                return new BackupPolicy(name, <any>undefined, { urn })
            case "alicloud:clickhouse/dbCluster:DbCluster":
                return new DbCluster(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("alicloud", "clickhouse/account", _module)
pulumi.runtime.registerResourceModule("alicloud", "clickhouse/backupPolicy", _module)
pulumi.runtime.registerResourceModule("alicloud", "clickhouse/dbCluster", _module)