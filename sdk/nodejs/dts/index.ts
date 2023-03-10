// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./consumerChannel";
export * from "./getConsumerChannels";
export * from "./getMigrationJobs";
export * from "./getSubscriptionJobs";
export * from "./getSynchronizationJobs";
export * from "./jobMonitorRule";
export * from "./migrationInstance";
export * from "./migrationJob";
export * from "./subscriptionJob";
export * from "./synchronizationInstance";
export * from "./synchronizationJob";

// Import resources to register:
import { ConsumerChannel } from "./consumerChannel";
import { JobMonitorRule } from "./jobMonitorRule";
import { MigrationInstance } from "./migrationInstance";
import { MigrationJob } from "./migrationJob";
import { SubscriptionJob } from "./subscriptionJob";
import { SynchronizationInstance } from "./synchronizationInstance";
import { SynchronizationJob } from "./synchronizationJob";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "alicloud:dts/consumerChannel:ConsumerChannel":
                return new ConsumerChannel(name, <any>undefined, { urn })
            case "alicloud:dts/jobMonitorRule:JobMonitorRule":
                return new JobMonitorRule(name, <any>undefined, { urn })
            case "alicloud:dts/migrationInstance:MigrationInstance":
                return new MigrationInstance(name, <any>undefined, { urn })
            case "alicloud:dts/migrationJob:MigrationJob":
                return new MigrationJob(name, <any>undefined, { urn })
            case "alicloud:dts/subscriptionJob:SubscriptionJob":
                return new SubscriptionJob(name, <any>undefined, { urn })
            case "alicloud:dts/synchronizationInstance:SynchronizationInstance":
                return new SynchronizationInstance(name, <any>undefined, { urn })
            case "alicloud:dts/synchronizationJob:SynchronizationJob":
                return new SynchronizationJob(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("alicloud", "dts/consumerChannel", _module)
pulumi.runtime.registerResourceModule("alicloud", "dts/jobMonitorRule", _module)
pulumi.runtime.registerResourceModule("alicloud", "dts/migrationInstance", _module)
pulumi.runtime.registerResourceModule("alicloud", "dts/migrationJob", _module)
pulumi.runtime.registerResourceModule("alicloud", "dts/subscriptionJob", _module)
pulumi.runtime.registerResourceModule("alicloud", "dts/synchronizationInstance", _module)
pulumi.runtime.registerResourceModule("alicloud", "dts/synchronizationJob", _module)
