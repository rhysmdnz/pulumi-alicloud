// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./account";
export * from "./accountPrivilege";
export * from "./backupPolicy";
export * from "./connection";
export * from "./database";
export * from "./getAccounts";
export * from "./getInstanceClasses";
export * from "./getInstanceEngines";
export * from "./getInstances";
export * from "./getModifyParameterLogs";
export * from "./getRdsBackups";
export * from "./getRdsParameterGroups";
export * from "./getZones";
export * from "./instance";
export * from "./rdsAccount";
export * from "./rdsBackup";
export * from "./rdsCloneDbInstance";
export * from "./rdsParameterGroup";
export * from "./rdsUpgradeDbInstance";
export * from "./readOnlyInstance";
export * from "./readWriteSplittingConnection";

// Import resources to register:
import { Account } from "./account";
import { AccountPrivilege } from "./accountPrivilege";
import { BackupPolicy } from "./backupPolicy";
import { Connection } from "./connection";
import { Database } from "./database";
import { Instance } from "./instance";
import { RdsAccount } from "./rdsAccount";
import { RdsBackup } from "./rdsBackup";
import { RdsCloneDbInstance } from "./rdsCloneDbInstance";
import { RdsParameterGroup } from "./rdsParameterGroup";
import { RdsUpgradeDbInstance } from "./rdsUpgradeDbInstance";
import { ReadOnlyInstance } from "./readOnlyInstance";
import { ReadWriteSplittingConnection } from "./readWriteSplittingConnection";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "alicloud:rds/account:Account":
                return new Account(name, <any>undefined, { urn })
            case "alicloud:rds/accountPrivilege:AccountPrivilege":
                return new AccountPrivilege(name, <any>undefined, { urn })
            case "alicloud:rds/backupPolicy:BackupPolicy":
                return new BackupPolicy(name, <any>undefined, { urn })
            case "alicloud:rds/connection:Connection":
                return new Connection(name, <any>undefined, { urn })
            case "alicloud:rds/database:Database":
                return new Database(name, <any>undefined, { urn })
            case "alicloud:rds/instance:Instance":
                return new Instance(name, <any>undefined, { urn })
            case "alicloud:rds/rdsAccount:RdsAccount":
                return new RdsAccount(name, <any>undefined, { urn })
            case "alicloud:rds/rdsBackup:RdsBackup":
                return new RdsBackup(name, <any>undefined, { urn })
            case "alicloud:rds/rdsCloneDbInstance:RdsCloneDbInstance":
                return new RdsCloneDbInstance(name, <any>undefined, { urn })
            case "alicloud:rds/rdsParameterGroup:RdsParameterGroup":
                return new RdsParameterGroup(name, <any>undefined, { urn })
            case "alicloud:rds/rdsUpgradeDbInstance:RdsUpgradeDbInstance":
                return new RdsUpgradeDbInstance(name, <any>undefined, { urn })
            case "alicloud:rds/readOnlyInstance:ReadOnlyInstance":
                return new ReadOnlyInstance(name, <any>undefined, { urn })
            case "alicloud:rds/readWriteSplittingConnection:ReadWriteSplittingConnection":
                return new ReadWriteSplittingConnection(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("alicloud", "rds/account", _module)
pulumi.runtime.registerResourceModule("alicloud", "rds/accountPrivilege", _module)
pulumi.runtime.registerResourceModule("alicloud", "rds/backupPolicy", _module)
pulumi.runtime.registerResourceModule("alicloud", "rds/connection", _module)
pulumi.runtime.registerResourceModule("alicloud", "rds/database", _module)
pulumi.runtime.registerResourceModule("alicloud", "rds/instance", _module)
pulumi.runtime.registerResourceModule("alicloud", "rds/rdsAccount", _module)
pulumi.runtime.registerResourceModule("alicloud", "rds/rdsBackup", _module)
pulumi.runtime.registerResourceModule("alicloud", "rds/rdsCloneDbInstance", _module)
pulumi.runtime.registerResourceModule("alicloud", "rds/rdsParameterGroup", _module)
pulumi.runtime.registerResourceModule("alicloud", "rds/rdsUpgradeDbInstance", _module)
pulumi.runtime.registerResourceModule("alicloud", "rds/readOnlyInstance", _module)
pulumi.runtime.registerResourceModule("alicloud", "rds/readWriteSplittingConnection", _module)