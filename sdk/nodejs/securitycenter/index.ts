// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./getGroups";
export * from "./group";
export * from "./serviceLinkedRole";

// Import resources to register:
import { Group } from "./group";
import { ServiceLinkedRole } from "./serviceLinkedRole";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "alicloud:securitycenter/group:Group":
                return new Group(name, <any>undefined, { urn })
            case "alicloud:securitycenter/serviceLinkedRole:ServiceLinkedRole":
                return new ServiceLinkedRole(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("alicloud", "securitycenter/group", _module)
pulumi.runtime.registerResourceModule("alicloud", "securitycenter/serviceLinkedRole", _module)
