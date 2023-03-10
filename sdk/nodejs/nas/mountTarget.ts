// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a NAS Mount Target resource.
 * For information about NAS Mount Target and how to use it, see [Manage NAS Mount Targets](https://www.alibabacloud.com/help/en/doc-detail/27531.htm).
 *
 * > **NOTE**: Available in v1.34.0+.
 *
 * > **NOTE**: Currently this resource support create a mount point in a classic network only when current region is China mainland regions.
 *
 * > **NOTE**: You must grant NAS with specific RAM permissions when creating a classic mount targets,
 * and it only can be achieved by creating a classic mount target mannually.
 * See [Add a mount point](https://www.alibabacloud.com/help/doc-detail/60431.htm) and [Why do I need RAM permissions to create a mount point in a classic network](https://www.alibabacloud.com/help/faq-detail/42176.htm).
 *
 * ## Example Usage
 *
 * Basic Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const exampleFileSystem = new alicloud.nas.FileSystem("exampleFileSystem", {
 *     protocolType: "NFS",
 *     storageType: "Performance",
 *     description: "test file system",
 * });
 * const exampleAccessGroup = new alicloud.nas.AccessGroup("exampleAccessGroup", {
 *     accessGroupName: "test_name",
 *     accessGroupType: "Classic",
 *     description: "test access group",
 * });
 * const exampleMountTarget = new alicloud.nas.MountTarget("exampleMountTarget", {
 *     fileSystemId: exampleFileSystem.id,
 *     accessGroupName: exampleAccessGroup.accessGroupName,
 * });
 * ```
 *
 * ## Import
 *
 * NAS MountTarget
 *
 * can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import alicloud:nas/mountTarget:MountTarget foo 192094b415:192094b415-luw38.cn-beijing.nas.aliyuncs.com
 * ```
 */
export class MountTarget extends pulumi.CustomResource {
    /**
     * Get an existing MountTarget resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MountTargetState, opts?: pulumi.CustomResourceOptions): MountTarget {
        return new MountTarget(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'alicloud:nas/mountTarget:MountTarget';

    /**
     * Returns true if the given object is an instance of MountTarget.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MountTarget {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MountTarget.__pulumiType;
    }

    /**
     * The name of the permission group that applies to the mount target.
     */
    public readonly accessGroupName!: pulumi.Output<string | undefined>;
    /**
     * The ID of the file system.
     */
    public readonly fileSystemId!: pulumi.Output<string>;
    /**
     * The IPv4 domain name of the mount target. **NOTE:** Available in v1.161.0+.
     */
    public /*out*/ readonly mountTargetDomain!: pulumi.Output<string>;
    /**
     * The ID of security group.
     */
    public readonly securityGroupId!: pulumi.Output<string | undefined>;
    /**
     * Whether the MountTarget is active. The status of the mount target. Valid values: `Active` and `Inactive`, Default value is `Active`. Before you mount a file system, make sure that the mount target is in the Active state.
     */
    public readonly status!: pulumi.Output<string>;
    /**
     * The ID of the VSwitch in the VPC where the mount target resides.
     */
    public readonly vswitchId!: pulumi.Output<string | undefined>;

    /**
     * Create a MountTarget resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MountTargetArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MountTargetArgs | MountTargetState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MountTargetState | undefined;
            resourceInputs["accessGroupName"] = state ? state.accessGroupName : undefined;
            resourceInputs["fileSystemId"] = state ? state.fileSystemId : undefined;
            resourceInputs["mountTargetDomain"] = state ? state.mountTargetDomain : undefined;
            resourceInputs["securityGroupId"] = state ? state.securityGroupId : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["vswitchId"] = state ? state.vswitchId : undefined;
        } else {
            const args = argsOrState as MountTargetArgs | undefined;
            if ((!args || args.fileSystemId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'fileSystemId'");
            }
            resourceInputs["accessGroupName"] = args ? args.accessGroupName : undefined;
            resourceInputs["fileSystemId"] = args ? args.fileSystemId : undefined;
            resourceInputs["securityGroupId"] = args ? args.securityGroupId : undefined;
            resourceInputs["status"] = args ? args.status : undefined;
            resourceInputs["vswitchId"] = args ? args.vswitchId : undefined;
            resourceInputs["mountTargetDomain"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(MountTarget.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MountTarget resources.
 */
export interface MountTargetState {
    /**
     * The name of the permission group that applies to the mount target.
     */
    accessGroupName?: pulumi.Input<string>;
    /**
     * The ID of the file system.
     */
    fileSystemId?: pulumi.Input<string>;
    /**
     * The IPv4 domain name of the mount target. **NOTE:** Available in v1.161.0+.
     */
    mountTargetDomain?: pulumi.Input<string>;
    /**
     * The ID of security group.
     */
    securityGroupId?: pulumi.Input<string>;
    /**
     * Whether the MountTarget is active. The status of the mount target. Valid values: `Active` and `Inactive`, Default value is `Active`. Before you mount a file system, make sure that the mount target is in the Active state.
     */
    status?: pulumi.Input<string>;
    /**
     * The ID of the VSwitch in the VPC where the mount target resides.
     */
    vswitchId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a MountTarget resource.
 */
export interface MountTargetArgs {
    /**
     * The name of the permission group that applies to the mount target.
     */
    accessGroupName?: pulumi.Input<string>;
    /**
     * The ID of the file system.
     */
    fileSystemId: pulumi.Input<string>;
    /**
     * The ID of security group.
     */
    securityGroupId?: pulumi.Input<string>;
    /**
     * Whether the MountTarget is active. The status of the mount target. Valid values: `Active` and `Inactive`, Default value is `Active`. Before you mount a file system, make sure that the mount target is in the Active state.
     */
    status?: pulumi.Input<string>;
    /**
     * The ID of the VSwitch in the VPC where the mount target resides.
     */
    vswitchId?: pulumi.Input<string>;
}
