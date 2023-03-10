// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./application";
export * from "./applicationGroup";
export * from "./execution";
export * from "./getApplicationGroups";
export * from "./getApplications";
export * from "./getExecutions";
export * from "./getParameters";
export * from "./getPatchBaselines";
export * from "./getSecretParameters";
export * from "./getStateConfigurations";
export * from "./getTemplates";
export * from "./parameter";
export * from "./patchBaseline";
export * from "./secretParameter";
export * from "./serviceSetting";
export * from "./stateConfiguration";
export * from "./template";

// Import resources to register:
import { Application } from "./application";
import { ApplicationGroup } from "./applicationGroup";
import { Execution } from "./execution";
import { Parameter } from "./parameter";
import { PatchBaseline } from "./patchBaseline";
import { SecretParameter } from "./secretParameter";
import { ServiceSetting } from "./serviceSetting";
import { StateConfiguration } from "./stateConfiguration";
import { Template } from "./template";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "alicloud:oos/application:Application":
                return new Application(name, <any>undefined, { urn })
            case "alicloud:oos/applicationGroup:ApplicationGroup":
                return new ApplicationGroup(name, <any>undefined, { urn })
            case "alicloud:oos/execution:Execution":
                return new Execution(name, <any>undefined, { urn })
            case "alicloud:oos/parameter:Parameter":
                return new Parameter(name, <any>undefined, { urn })
            case "alicloud:oos/patchBaseline:PatchBaseline":
                return new PatchBaseline(name, <any>undefined, { urn })
            case "alicloud:oos/secretParameter:SecretParameter":
                return new SecretParameter(name, <any>undefined, { urn })
            case "alicloud:oos/serviceSetting:ServiceSetting":
                return new ServiceSetting(name, <any>undefined, { urn })
            case "alicloud:oos/stateConfiguration:StateConfiguration":
                return new StateConfiguration(name, <any>undefined, { urn })
            case "alicloud:oos/template:Template":
                return new Template(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("alicloud", "oos/application", _module)
pulumi.runtime.registerResourceModule("alicloud", "oos/applicationGroup", _module)
pulumi.runtime.registerResourceModule("alicloud", "oos/execution", _module)
pulumi.runtime.registerResourceModule("alicloud", "oos/parameter", _module)
pulumi.runtime.registerResourceModule("alicloud", "oos/patchBaseline", _module)
pulumi.runtime.registerResourceModule("alicloud", "oos/secretParameter", _module)
pulumi.runtime.registerResourceModule("alicloud", "oos/serviceSetting", _module)
pulumi.runtime.registerResourceModule("alicloud", "oos/stateConfiguration", _module)
pulumi.runtime.registerResourceModule("alicloud", "oos/template", _module)
