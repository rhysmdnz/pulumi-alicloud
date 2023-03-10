// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./account";
export * from "./backupPolicy";
export * from "./cluster";
export * from "./connection";
export * from "./dbcluster";
export * from "./getClusters";
export * from "./getDBClusters";
export * from "./getZones";

// Import resources to register:
import { Account } from "./account";
import { BackupPolicy } from "./backupPolicy";
import { Cluster } from "./cluster";
import { Connection } from "./connection";
import { DBCluster } from "./dbcluster";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "alicloud:adb/account:Account":
                return new Account(name, <any>undefined, { urn })
            case "alicloud:adb/backupPolicy:BackupPolicy":
                return new BackupPolicy(name, <any>undefined, { urn })
            case "alicloud:adb/cluster:Cluster":
                return new Cluster(name, <any>undefined, { urn })
            case "alicloud:adb/connection:Connection":
                return new Connection(name, <any>undefined, { urn })
            case "alicloud:adb/dBCluster:DBCluster":
                return new DBCluster(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("alicloud", "adb/account", _module)
pulumi.runtime.registerResourceModule("alicloud", "adb/backupPolicy", _module)
pulumi.runtime.registerResourceModule("alicloud", "adb/cluster", _module)
pulumi.runtime.registerResourceModule("alicloud", "adb/connection", _module)
pulumi.runtime.registerResourceModule("alicloud", "adb/dBCluster", _module)
