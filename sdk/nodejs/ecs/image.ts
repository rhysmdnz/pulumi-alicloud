// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Creates a custom image. You can then use a custom image to create ECS instances (RunInstances) or change the system disk for an existing instance (ReplaceSystemDisk).
 *
 * > **NOTE:**  If you want to create a template from an ECS instance, you can specify the instance ID (InstanceId) to create a custom image. You must make sure that the status of the specified instance is Running or Stopped. After a successful invocation, each disk of the specified instance has a new snapshot created.
 *
 * > **NOTE:**  If you want to create a custom image based on the system disk of your ECS instance, you can specify one of the system disk snapshots (SnapshotId) to create a custom image. However, the specified snapshot cannot be created on or before July 15, 2013.
 *
 * > **NOTE:**  If you want to combine snapshots of multiple disks into an image template, you can specify DiskDeviceMapping to create a custom image.
 *
 * > **NOTE:**  Available in 1.64.0+
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const defaultImage = new alicloud.ecs.Image("default", {
 *     architecture: "x86_64",
 *     description: "test-image",
 *     imageName: "test-image",
 *     instanceId: "i-bp1g6zv0ce8oghu7k***",
 *     platform: "CentOS",
 *     resourceGroupId: "rg-bp67acfmxazb4ph***",
 *     tags: {
 *         FinanceDept: "FinanceDeptJoshua",
 *     },
 * });
 * ```
 *
 * ## Import
 *
 *  image can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import alicloud:ecs/image:Image default m-uf66871ape***yg1q***
 * ```
 */
export class Image extends pulumi.CustomResource {
    /**
     * Get an existing Image resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ImageState, opts?: pulumi.CustomResourceOptions): Image {
        return new Image(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'alicloud:ecs/image:Image';

    /**
     * Returns true if the given object is an instance of Image.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Image {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Image.__pulumiType;
    }

    /**
     * Specifies the architecture of the system disk after you specify a data disk snapshot as the data source of the system disk for creating an image. Valid values: `i386` , Default is `x8664`.
     */
    public readonly architecture!: pulumi.Output<string | undefined>;
    public readonly deleteAutoSnapshot!: pulumi.Output<boolean | undefined>;
    /**
     * The description of the image. It must be 2 to 256 characters in length and must not start with http:// or https://. Default value: null.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Description of the system with disks and snapshots under the image.
     */
    public readonly diskDeviceMappings!: pulumi.Output<outputs.ecs.ImageDiskDeviceMapping[]>;
    /**
     * Indicates whether to force delete the custom image, Default is `false`. 
     * - true：Force deletes the custom image, regardless of whether the image is currently being used by other instances.
     * - false：Verifies that the image is not currently in use by any other instances before deleting the image.
     */
    public readonly force!: pulumi.Output<boolean | undefined>;
    /**
     * The image name. It must be 2 to 128 characters in length, and must begin with a letter or Chinese character (beginning with http:// or https:// is not allowed). It can contain digits, colons (:), underscores (_), or hyphens (-). Default value: null.
     */
    public readonly imageName!: pulumi.Output<string>;
    /**
     * The instance ID.
     */
    public readonly instanceId!: pulumi.Output<string | undefined>;
    /**
     * @deprecated Attribute 'name' has been deprecated from version 1.69.0. Use `image_name` instead.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Specifies the operating system platform of the system disk after you specify a data disk snapshot as the data source of the system disk for creating an image. Valid values: `CentOS`, `Ubuntu`, `SUSE`, `OpenSUSE`, `RedHat`, `Debian`, `CoreOS`, `Aliyun Linux`, `Windows Server 2003`, `Windows Server 2008`, `Windows Server 2012`, `Windows 7`, Default is `Others Linux`.
     */
    public readonly platform!: pulumi.Output<string | undefined>;
    /**
     * The ID of the enterprise resource group to which a custom image belongs
     */
    public readonly resourceGroupId!: pulumi.Output<string | undefined>;
    /**
     * Specifies a snapshot that is used to create a combined custom image.
     */
    public readonly snapshotId!: pulumi.Output<string | undefined>;
    /**
     * The tag value of an image. The value of N ranges from 1 to 20.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any} | undefined>;

    /**
     * Create a Image resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ImageArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ImageArgs | ImageState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ImageState | undefined;
            resourceInputs["architecture"] = state ? state.architecture : undefined;
            resourceInputs["deleteAutoSnapshot"] = state ? state.deleteAutoSnapshot : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["diskDeviceMappings"] = state ? state.diskDeviceMappings : undefined;
            resourceInputs["force"] = state ? state.force : undefined;
            resourceInputs["imageName"] = state ? state.imageName : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["platform"] = state ? state.platform : undefined;
            resourceInputs["resourceGroupId"] = state ? state.resourceGroupId : undefined;
            resourceInputs["snapshotId"] = state ? state.snapshotId : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as ImageArgs | undefined;
            resourceInputs["architecture"] = args ? args.architecture : undefined;
            resourceInputs["deleteAutoSnapshot"] = args ? args.deleteAutoSnapshot : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["diskDeviceMappings"] = args ? args.diskDeviceMappings : undefined;
            resourceInputs["force"] = args ? args.force : undefined;
            resourceInputs["imageName"] = args ? args.imageName : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["platform"] = args ? args.platform : undefined;
            resourceInputs["resourceGroupId"] = args ? args.resourceGroupId : undefined;
            resourceInputs["snapshotId"] = args ? args.snapshotId : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Image.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Image resources.
 */
export interface ImageState {
    /**
     * Specifies the architecture of the system disk after you specify a data disk snapshot as the data source of the system disk for creating an image. Valid values: `i386` , Default is `x8664`.
     */
    architecture?: pulumi.Input<string>;
    deleteAutoSnapshot?: pulumi.Input<boolean>;
    /**
     * The description of the image. It must be 2 to 256 characters in length and must not start with http:// or https://. Default value: null.
     */
    description?: pulumi.Input<string>;
    /**
     * Description of the system with disks and snapshots under the image.
     */
    diskDeviceMappings?: pulumi.Input<pulumi.Input<inputs.ecs.ImageDiskDeviceMapping>[]>;
    /**
     * Indicates whether to force delete the custom image, Default is `false`. 
     * - true：Force deletes the custom image, regardless of whether the image is currently being used by other instances.
     * - false：Verifies that the image is not currently in use by any other instances before deleting the image.
     */
    force?: pulumi.Input<boolean>;
    /**
     * The image name. It must be 2 to 128 characters in length, and must begin with a letter or Chinese character (beginning with http:// or https:// is not allowed). It can contain digits, colons (:), underscores (_), or hyphens (-). Default value: null.
     */
    imageName?: pulumi.Input<string>;
    /**
     * The instance ID.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * @deprecated Attribute 'name' has been deprecated from version 1.69.0. Use `image_name` instead.
     */
    name?: pulumi.Input<string>;
    /**
     * Specifies the operating system platform of the system disk after you specify a data disk snapshot as the data source of the system disk for creating an image. Valid values: `CentOS`, `Ubuntu`, `SUSE`, `OpenSUSE`, `RedHat`, `Debian`, `CoreOS`, `Aliyun Linux`, `Windows Server 2003`, `Windows Server 2008`, `Windows Server 2012`, `Windows 7`, Default is `Others Linux`.
     */
    platform?: pulumi.Input<string>;
    /**
     * The ID of the enterprise resource group to which a custom image belongs
     */
    resourceGroupId?: pulumi.Input<string>;
    /**
     * Specifies a snapshot that is used to create a combined custom image.
     */
    snapshotId?: pulumi.Input<string>;
    /**
     * The tag value of an image. The value of N ranges from 1 to 20.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a Image resource.
 */
export interface ImageArgs {
    /**
     * Specifies the architecture of the system disk after you specify a data disk snapshot as the data source of the system disk for creating an image. Valid values: `i386` , Default is `x8664`.
     */
    architecture?: pulumi.Input<string>;
    deleteAutoSnapshot?: pulumi.Input<boolean>;
    /**
     * The description of the image. It must be 2 to 256 characters in length and must not start with http:// or https://. Default value: null.
     */
    description?: pulumi.Input<string>;
    /**
     * Description of the system with disks and snapshots under the image.
     */
    diskDeviceMappings?: pulumi.Input<pulumi.Input<inputs.ecs.ImageDiskDeviceMapping>[]>;
    /**
     * Indicates whether to force delete the custom image, Default is `false`. 
     * - true：Force deletes the custom image, regardless of whether the image is currently being used by other instances.
     * - false：Verifies that the image is not currently in use by any other instances before deleting the image.
     */
    force?: pulumi.Input<boolean>;
    /**
     * The image name. It must be 2 to 128 characters in length, and must begin with a letter or Chinese character (beginning with http:// or https:// is not allowed). It can contain digits, colons (:), underscores (_), or hyphens (-). Default value: null.
     */
    imageName?: pulumi.Input<string>;
    /**
     * The instance ID.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * @deprecated Attribute 'name' has been deprecated from version 1.69.0. Use `image_name` instead.
     */
    name?: pulumi.Input<string>;
    /**
     * Specifies the operating system platform of the system disk after you specify a data disk snapshot as the data source of the system disk for creating an image. Valid values: `CentOS`, `Ubuntu`, `SUSE`, `OpenSUSE`, `RedHat`, `Debian`, `CoreOS`, `Aliyun Linux`, `Windows Server 2003`, `Windows Server 2008`, `Windows Server 2012`, `Windows 7`, Default is `Others Linux`.
     */
    platform?: pulumi.Input<string>;
    /**
     * The ID of the enterprise resource group to which a custom image belongs
     */
    resourceGroupId?: pulumi.Input<string>;
    /**
     * Specifies a snapshot that is used to create a combined custom image.
     */
    snapshotId?: pulumi.Input<string>;
    /**
     * The tag value of an image. The value of N ranges from 1 to 20.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
}