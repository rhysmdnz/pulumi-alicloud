// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./acl";
export * from "./aclEntryAttachment";
export * from "./applicationLoadBalancer";
export * from "./attachment";
export * from "./backendServer";
export * from "./caCertificate";
export * from "./domainExtension";
export * from "./getAcls";
export * from "./getApplicationLoadBalancers";
export * from "./getAttachments";
export * from "./getBackendServers";
export * from "./getCaCertificates";
export * from "./getDomainExtensions";
export * from "./getListeners";
export * from "./getLoadBalancers";
export * from "./getMasterSlaveServerGroups";
export * from "./getRules";
export * from "./getServerCertificates";
export * from "./getServerGroups";
export * from "./getTlsCipherPolicies";
export * from "./getZones";
export * from "./listener";
export * from "./loadBalancer";
export * from "./masterSlaveServerGroup";
export * from "./rule";
export * from "./serverCertificate";
export * from "./serverGroup";
export * from "./serverGroupServerAttachment";
export * from "./tlsCipherPolicy";

// Import resources to register:
import { Acl } from "./acl";
import { AclEntryAttachment } from "./aclEntryAttachment";
import { ApplicationLoadBalancer } from "./applicationLoadBalancer";
import { Attachment } from "./attachment";
import { BackendServer } from "./backendServer";
import { CaCertificate } from "./caCertificate";
import { DomainExtension } from "./domainExtension";
import { Listener } from "./listener";
import { LoadBalancer } from "./loadBalancer";
import { MasterSlaveServerGroup } from "./masterSlaveServerGroup";
import { Rule } from "./rule";
import { ServerCertificate } from "./serverCertificate";
import { ServerGroup } from "./serverGroup";
import { ServerGroupServerAttachment } from "./serverGroupServerAttachment";
import { TlsCipherPolicy } from "./tlsCipherPolicy";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "alicloud:slb/acl:Acl":
                return new Acl(name, <any>undefined, { urn })
            case "alicloud:slb/aclEntryAttachment:AclEntryAttachment":
                return new AclEntryAttachment(name, <any>undefined, { urn })
            case "alicloud:slb/applicationLoadBalancer:ApplicationLoadBalancer":
                return new ApplicationLoadBalancer(name, <any>undefined, { urn })
            case "alicloud:slb/attachment:Attachment":
                return new Attachment(name, <any>undefined, { urn })
            case "alicloud:slb/backendServer:BackendServer":
                return new BackendServer(name, <any>undefined, { urn })
            case "alicloud:slb/caCertificate:CaCertificate":
                return new CaCertificate(name, <any>undefined, { urn })
            case "alicloud:slb/domainExtension:DomainExtension":
                return new DomainExtension(name, <any>undefined, { urn })
            case "alicloud:slb/listener:Listener":
                return new Listener(name, <any>undefined, { urn })
            case "alicloud:slb/loadBalancer:LoadBalancer":
                return new LoadBalancer(name, <any>undefined, { urn })
            case "alicloud:slb/masterSlaveServerGroup:MasterSlaveServerGroup":
                return new MasterSlaveServerGroup(name, <any>undefined, { urn })
            case "alicloud:slb/rule:Rule":
                return new Rule(name, <any>undefined, { urn })
            case "alicloud:slb/serverCertificate:ServerCertificate":
                return new ServerCertificate(name, <any>undefined, { urn })
            case "alicloud:slb/serverGroup:ServerGroup":
                return new ServerGroup(name, <any>undefined, { urn })
            case "alicloud:slb/serverGroupServerAttachment:ServerGroupServerAttachment":
                return new ServerGroupServerAttachment(name, <any>undefined, { urn })
            case "alicloud:slb/tlsCipherPolicy:TlsCipherPolicy":
                return new TlsCipherPolicy(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("alicloud", "slb/acl", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/aclEntryAttachment", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/applicationLoadBalancer", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/attachment", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/backendServer", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/caCertificate", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/domainExtension", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/listener", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/loadBalancer", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/masterSlaveServerGroup", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/rule", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/serverCertificate", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/serverGroup", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/serverGroupServerAttachment", _module)
pulumi.runtime.registerResourceModule("alicloud", "slb/tlsCipherPolicy", _module)
