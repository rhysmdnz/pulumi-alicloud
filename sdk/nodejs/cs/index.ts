// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./application";
export * from "./autoscalingConfig";
export * from "./cluster";
export * from "./edgeKubernetes";
export * from "./getAckService";
export * from "./getEdgeKubernetesClusters";
export * from "./getKubernetesAddonMetadata";
export * from "./getKubernetesAddons";
export * from "./getKubernetesClusters";
export * from "./getKubernetesPermission";
export * from "./getKubernetesVersion";
export * from "./getManagedKubernetesClusters";
export * from "./getRegistryEnterpriseInstances";
export * from "./getRegistryEnterpriseNamespaces";
export * from "./getRegistryEnterpriseRepos";
export * from "./getRegistryEnterpriseSyncRules";
export * from "./getServerlessKubernetesClusters";
export * from "./kubernetes";
export * from "./kubernetesAddon";
export * from "./kubernetesAutoscaler";
export * from "./kubernetesPermission";
export * from "./managedKubernetes";
export * from "./nodePool";
export * from "./registryEnterpriseNamespace";
export * from "./registryEnterpriseRepo";
export * from "./registryEnterpriseSyncRule";
export * from "./serverlessKubernetes";
export * from "./swarm";

// Import resources to register:
import { Application } from "./application";
import { AutoscalingConfig } from "./autoscalingConfig";
import { Cluster } from "./cluster";
import { EdgeKubernetes } from "./edgeKubernetes";
import { Kubernetes } from "./kubernetes";
import { KubernetesAddon } from "./kubernetesAddon";
import { KubernetesAutoscaler } from "./kubernetesAutoscaler";
import { KubernetesPermission } from "./kubernetesPermission";
import { ManagedKubernetes } from "./managedKubernetes";
import { NodePool } from "./nodePool";
import { RegistryEnterpriseNamespace } from "./registryEnterpriseNamespace";
import { RegistryEnterpriseRepo } from "./registryEnterpriseRepo";
import { RegistryEnterpriseSyncRule } from "./registryEnterpriseSyncRule";
import { ServerlessKubernetes } from "./serverlessKubernetes";
import { Swarm } from "./swarm";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "alicloud:cs/application:Application":
                return new Application(name, <any>undefined, { urn })
            case "alicloud:cs/autoscalingConfig:AutoscalingConfig":
                return new AutoscalingConfig(name, <any>undefined, { urn })
            case "alicloud:cs/cluster:Cluster":
                return new Cluster(name, <any>undefined, { urn })
            case "alicloud:cs/edgeKubernetes:EdgeKubernetes":
                return new EdgeKubernetes(name, <any>undefined, { urn })
            case "alicloud:cs/kubernetes:Kubernetes":
                return new Kubernetes(name, <any>undefined, { urn })
            case "alicloud:cs/kubernetesAddon:KubernetesAddon":
                return new KubernetesAddon(name, <any>undefined, { urn })
            case "alicloud:cs/kubernetesAutoscaler:KubernetesAutoscaler":
                return new KubernetesAutoscaler(name, <any>undefined, { urn })
            case "alicloud:cs/kubernetesPermission:KubernetesPermission":
                return new KubernetesPermission(name, <any>undefined, { urn })
            case "alicloud:cs/managedKubernetes:ManagedKubernetes":
                return new ManagedKubernetes(name, <any>undefined, { urn })
            case "alicloud:cs/nodePool:NodePool":
                return new NodePool(name, <any>undefined, { urn })
            case "alicloud:cs/registryEnterpriseNamespace:RegistryEnterpriseNamespace":
                return new RegistryEnterpriseNamespace(name, <any>undefined, { urn })
            case "alicloud:cs/registryEnterpriseRepo:RegistryEnterpriseRepo":
                return new RegistryEnterpriseRepo(name, <any>undefined, { urn })
            case "alicloud:cs/registryEnterpriseSyncRule:RegistryEnterpriseSyncRule":
                return new RegistryEnterpriseSyncRule(name, <any>undefined, { urn })
            case "alicloud:cs/serverlessKubernetes:ServerlessKubernetes":
                return new ServerlessKubernetes(name, <any>undefined, { urn })
            case "alicloud:cs/swarm:Swarm":
                return new Swarm(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("alicloud", "cs/application", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/autoscalingConfig", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/cluster", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/edgeKubernetes", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/kubernetes", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/kubernetesAddon", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/kubernetesAutoscaler", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/kubernetesPermission", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/managedKubernetes", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/nodePool", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/registryEnterpriseNamespace", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/registryEnterpriseRepo", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/registryEnterpriseSyncRule", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/serverlessKubernetes", _module)
pulumi.runtime.registerResourceModule("alicloud", "cs/swarm", _module)
