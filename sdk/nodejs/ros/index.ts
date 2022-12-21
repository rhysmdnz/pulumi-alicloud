// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./changeSet";
export * from "./getChangeSets";
export * from "./getRegions";
export * from "./getStackGroups";
export * from "./getStackInstances";
export * from "./getStacks";
export * from "./getTemplateScratches";
export * from "./getTemplates";
export * from "./stack";
export * from "./stackGroup";
export * from "./stackInstance";
export * from "./template";
export * from "./templateScratch";

// Import resources to register:
import { ChangeSet } from "./changeSet";
import { Stack } from "./stack";
import { StackGroup } from "./stackGroup";
import { StackInstance } from "./stackInstance";
import { Template } from "./template";
import { TemplateScratch } from "./templateScratch";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "alicloud:ros/changeSet:ChangeSet":
                return new ChangeSet(name, <any>undefined, { urn })
            case "alicloud:ros/stack:Stack":
                return new Stack(name, <any>undefined, { urn })
            case "alicloud:ros/stackGroup:StackGroup":
                return new StackGroup(name, <any>undefined, { urn })
            case "alicloud:ros/stackInstance:StackInstance":
                return new StackInstance(name, <any>undefined, { urn })
            case "alicloud:ros/template:Template":
                return new Template(name, <any>undefined, { urn })
            case "alicloud:ros/templateScratch:TemplateScratch":
                return new TemplateScratch(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("alicloud", "ros/changeSet", _module)
pulumi.runtime.registerResourceModule("alicloud", "ros/stack", _module)
pulumi.runtime.registerResourceModule("alicloud", "ros/stackGroup", _module)
pulumi.runtime.registerResourceModule("alicloud", "ros/stackInstance", _module)
pulumi.runtime.registerResourceModule("alicloud", "ros/template", _module)
pulumi.runtime.registerResourceModule("alicloud", "ros/templateScratch", _module)