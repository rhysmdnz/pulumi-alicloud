// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * This resource will help you to manager Container Registry Enterprise Edition namespaces.
 *
 * For information about Container Registry Enterprise Edition namespaces and how to use it, see [Create a Namespace](https://www.alibabacloud.com/help/doc-detail/145483.htm)
 *
 * > **NOTE:** Available in v1.86.0+.
 *
 * > **NOTE:** You need to set your registry password in Container Registry Enterprise Edition console before use this resource.
 *
 * ## Example Usage
 *
 * Basic Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const my_namespace = new alicloud.cs.RegistryEnterpriseNamespace("my-namespace", {
 *     autoCreate: false,
 *     defaultVisibility: "PUBLIC",
 *     instanceId: "cri-xxx",
 * });
 * ```
 *
 * ## Import
 *
 * Container Registry Enterprise Edition namespace can be imported using the `{instance_id}:{namespace}`, e.g.
 *
 * ```sh
 *  $ pulumi import alicloud:cs/registryEnterpriseNamespace:RegistryEnterpriseNamespace default cri-xxx:my-namespace
 * ```
 */
export class RegistryEnterpriseNamespace extends pulumi.CustomResource {
    /**
     * Get an existing RegistryEnterpriseNamespace resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RegistryEnterpriseNamespaceState, opts?: pulumi.CustomResourceOptions): RegistryEnterpriseNamespace {
        return new RegistryEnterpriseNamespace(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'alicloud:cs/registryEnterpriseNamespace:RegistryEnterpriseNamespace';

    /**
     * Returns true if the given object is an instance of RegistryEnterpriseNamespace.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RegistryEnterpriseNamespace {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RegistryEnterpriseNamespace.__pulumiType;
    }

    /**
     * Boolean, when it set to true, repositories are automatically created when pushing new images. If it set to false, you create repository for images before pushing.
     */
    public readonly autoCreate!: pulumi.Output<boolean>;
    /**
     * `PUBLIC` or `PRIVATE`, default repository visibility in this namespace.
     */
    public readonly defaultVisibility!: pulumi.Output<string>;
    /**
     * ID of Container Registry Enterprise Edition instance.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * Name of Container Registry Enterprise Edition namespace. It can contain 2 to 30 characters.
     */
    public readonly name!: pulumi.Output<string>;

    /**
     * Create a RegistryEnterpriseNamespace resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RegistryEnterpriseNamespaceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RegistryEnterpriseNamespaceArgs | RegistryEnterpriseNamespaceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RegistryEnterpriseNamespaceState | undefined;
            resourceInputs["autoCreate"] = state ? state.autoCreate : undefined;
            resourceInputs["defaultVisibility"] = state ? state.defaultVisibility : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
        } else {
            const args = argsOrState as RegistryEnterpriseNamespaceArgs | undefined;
            if ((!args || args.autoCreate === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoCreate'");
            }
            if ((!args || args.defaultVisibility === undefined) && !opts.urn) {
                throw new Error("Missing required property 'defaultVisibility'");
            }
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["autoCreate"] = args ? args.autoCreate : undefined;
            resourceInputs["defaultVisibility"] = args ? args.defaultVisibility : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(RegistryEnterpriseNamespace.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RegistryEnterpriseNamespace resources.
 */
export interface RegistryEnterpriseNamespaceState {
    /**
     * Boolean, when it set to true, repositories are automatically created when pushing new images. If it set to false, you create repository for images before pushing.
     */
    autoCreate?: pulumi.Input<boolean>;
    /**
     * `PUBLIC` or `PRIVATE`, default repository visibility in this namespace.
     */
    defaultVisibility?: pulumi.Input<string>;
    /**
     * ID of Container Registry Enterprise Edition instance.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Name of Container Registry Enterprise Edition namespace. It can contain 2 to 30 characters.
     */
    name?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a RegistryEnterpriseNamespace resource.
 */
export interface RegistryEnterpriseNamespaceArgs {
    /**
     * Boolean, when it set to true, repositories are automatically created when pushing new images. If it set to false, you create repository for images before pushing.
     */
    autoCreate: pulumi.Input<boolean>;
    /**
     * `PUBLIC` or `PRIVATE`, default repository visibility in this namespace.
     */
    defaultVisibility: pulumi.Input<string>;
    /**
     * ID of Container Registry Enterprise Edition instance.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Name of Container Registry Enterprise Edition namespace. It can contain 2 to 30 characters.
     */
    name?: pulumi.Input<string>;
}