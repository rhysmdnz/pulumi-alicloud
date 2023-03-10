// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./consumerGroup";
export * from "./instance";
export * from "./instanceAllowedIpAttachment";
export * from "./saslAcl";
export * from "./saslUser";
export * from "./topic";

// Import resources to register:
import { ConsumerGroup } from "./consumerGroup";
import { Instance } from "./instance";
import { InstanceAllowedIpAttachment } from "./instanceAllowedIpAttachment";
import { SaslAcl } from "./saslAcl";
import { SaslUser } from "./saslUser";
import { Topic } from "./topic";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "alicloud:alikafka/consumerGroup:ConsumerGroup":
                return new ConsumerGroup(name, <any>undefined, { urn })
            case "alicloud:alikafka/instance:Instance":
                return new Instance(name, <any>undefined, { urn })
            case "alicloud:alikafka/instanceAllowedIpAttachment:InstanceAllowedIpAttachment":
                return new InstanceAllowedIpAttachment(name, <any>undefined, { urn })
            case "alicloud:alikafka/saslAcl:SaslAcl":
                return new SaslAcl(name, <any>undefined, { urn })
            case "alicloud:alikafka/saslUser:SaslUser":
                return new SaslUser(name, <any>undefined, { urn })
            case "alicloud:alikafka/topic:Topic":
                return new Topic(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("alicloud", "alikafka/consumerGroup", _module)
pulumi.runtime.registerResourceModule("alicloud", "alikafka/instance", _module)
pulumi.runtime.registerResourceModule("alicloud", "alikafka/instanceAllowedIpAttachment", _module)
pulumi.runtime.registerResourceModule("alicloud", "alikafka/saslAcl", _module)
pulumi.runtime.registerResourceModule("alicloud", "alikafka/saslUser", _module)
pulumi.runtime.registerResourceModule("alicloud", "alikafka/topic", _module)
