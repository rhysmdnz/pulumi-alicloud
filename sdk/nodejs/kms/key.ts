// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * A kms key can help user to protect data security in the transmission process. For information about Alikms Key and how to use it, see [What is Resource Alikms Key](https://www.alibabacloud.com/help/doc-detail/28947.htm).
 *
 * > **NOTE:** Available in v1.85.0+.
 *
 * ## Example Usage
 *
 * Basic Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const key = new alicloud.kms.Key("key", {
 *     description: "Hello KMS",
 *     pendingWindowInDays: 7,
 *     status: "Enabled",
 * });
 * ```
 *
 * ## Import
 *
 * Alikms key can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import alicloud:kms/key:Key example abc123456
 * ```
 */
export class Key extends pulumi.CustomResource {
    /**
     * Get an existing Key resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: KeyState, opts?: pulumi.CustomResourceOptions): Key {
        return new Key(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'alicloud:kms/key:Key';

    /**
     * Returns true if the given object is an instance of Key.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Key {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Key.__pulumiType;
    }

    /**
     * The Alicloud Resource Name (ARN) of the key.
     * * `creationDate` -The date and time when the CMK was created. The time is displayed in UTC.
     * * `creator` -The creator of the CMK.
     * * `deleteDate` -The scheduled date to delete CMK. The time is displayed in UTC. This value is returned only when the KeyState value is PendingDeletion.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * Specifies whether to enable automatic key rotation. Valid values: 
     * - Enabled
     * - Disabled (default value)
     * **NOTE**: If you set the origin parameter to EXTERNAL or the keySpec parameter to an asymmetric CMK type, automatic key rotation is unavailable.
     */
    public readonly automaticRotation!: pulumi.Output<string | undefined>;
    public /*out*/ readonly creationDate!: pulumi.Output<string>;
    public /*out*/ readonly creator!: pulumi.Output<string>;
    public /*out*/ readonly deleteDate!: pulumi.Output<string>;
    /**
     * Field `deletionWindowInDays` has been deprecated from provider version 1.85.0. New field `pendingWindowInDays` instead.
     *
     * @deprecated Field 'deletion_window_in_days' has been deprecated from provider version 1.85.0. New field 'pending_window_in_days' instead.
     */
    public readonly deletionWindowInDays!: pulumi.Output<number>;
    /**
     * The description of the CMK. The description can be 0 to 8,192 characters in length.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The instance ID of the exclusive KMS instance.
     */
    public readonly dkmsInstanceId!: pulumi.Output<string | undefined>;
    /**
     * Field `isEnabled` has been deprecated from provider version 1.85.0. New field `keyState` instead.
     *
     * @deprecated Field 'is_enabled' has been deprecated from provider version 1.85.0. New field 'key_state' instead.
     */
    public readonly isEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * The type of the CMK. Valid values: 
     * "Aliyun_AES_256", "Aliyun_AES_128", "Aliyun_AES_192", "Aliyun_SM4", "RSA_2048", "RSA_3072", "EC_P256", "EC_P256K", "EC_SM2".
     * Note: The default type of the CMK is Aliyun_AES_256. Only Dedicated KMS supports Aliyun_AES_128 and Aliyun_AES_192.
     */
    public readonly keySpec!: pulumi.Output<string>;
    /**
     * Field `keyState` has been deprecated from provider version 1.123.1. New field `status` instead.
     *
     * @deprecated Field 'key_state' has been deprecated from provider version 1.123.1. New field 'status' instead.
     */
    public readonly keyState!: pulumi.Output<string>;
    /**
     * The usage of the CMK. Valid values:
     * - ENCRYPT/DECRYPT(default value): encrypts or decrypts data.
     * - SIGN/VERIFY: generates or verifies a digital signature.
     */
    public readonly keyUsage!: pulumi.Output<string | undefined>;
    /**
     * The date and time the last rotation was performed. The time is displayed in UTC.
     */
    public /*out*/ readonly lastRotationDate!: pulumi.Output<string>;
    /**
     * The time and date the key material for the CMK expires. The time is displayed in UTC. If the value is empty, the key material for the CMK does not expire.
     */
    public /*out*/ readonly materialExpireTime!: pulumi.Output<string>;
    /**
     * The time the next rotation is scheduled for execution.
     */
    public /*out*/ readonly nextRotationDate!: pulumi.Output<string>;
    /**
     * The source of key material. Valid values: 
     * - Aliyun_KMS (default value)
     * - EXTERNAL
     * **NOTE**: The value of this parameter is case-sensitive. If you set the `keySpec` to an asymmetric CMK type,
     * you are not allowed to set the `origin` to EXTERNAL. If you set the `origin` to EXTERNAL, you must import key material.
     * For more information, see [import key material](https://www.alibabacloud.com/help/en/doc-detail/68523.htm).
     */
    public readonly origin!: pulumi.Output<string>;
    /**
     * The number of days before the CMK is deleted. 
     * During this period, the CMK is in the PendingDeletion state.
     * After this period ends, you cannot cancel the deletion. Valid values: 7 to 366. Unit: days.
     * **NOTE:** From version 1.184.0, `pendingWindowInDays` can be set to `366`.
     */
    public readonly pendingWindowInDays!: pulumi.Output<number>;
    /**
     * The ID of the current primary key version of the symmetric CMK.
     */
    public /*out*/ readonly primaryKeyVersion!: pulumi.Output<string>;
    /**
     * The protection level of the CMK. Valid values:
     * - SOFTWARE (default value)
     * - HSM
     * **NOTE**: The value of this parameter is case-sensitive. Assume that you set this parameter to HSM.
     * If you set the origin parameter to Aliyun_KMS, the CMK is created in a managed hardware security module (HSM).
     * If you set the origin parameter to EXTERNA, you can import an external key to the managed HSM.
     */
    public readonly protectionLevel!: pulumi.Output<string | undefined>;
    /**
     * The interval for automatic key rotation. Specify the value in the integer[unit] format.
     * The following units are supported: d (day), h (hour), m (minute), and s (second).
     * For example, you can use either 7d or 604800s to specify a seven-day interval.
     * The interval can range from 7 days to 730 days.
     * **NOTE**: It is Required when `automaticRotation = "Enabled"`
     */
    public readonly rotationInterval!: pulumi.Output<string | undefined>;
    /**
     * The status of CMK. Valid Values: 
     * - Disabled
     * - Enabled (default value)
     * - PendingDeletion
     */
    public readonly status!: pulumi.Output<string>;

    /**
     * Create a Key resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: KeyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: KeyArgs | KeyState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as KeyState | undefined;
            resourceInputs["arn"] = state ? state.arn : undefined;
            resourceInputs["automaticRotation"] = state ? state.automaticRotation : undefined;
            resourceInputs["creationDate"] = state ? state.creationDate : undefined;
            resourceInputs["creator"] = state ? state.creator : undefined;
            resourceInputs["deleteDate"] = state ? state.deleteDate : undefined;
            resourceInputs["deletionWindowInDays"] = state ? state.deletionWindowInDays : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["dkmsInstanceId"] = state ? state.dkmsInstanceId : undefined;
            resourceInputs["isEnabled"] = state ? state.isEnabled : undefined;
            resourceInputs["keySpec"] = state ? state.keySpec : undefined;
            resourceInputs["keyState"] = state ? state.keyState : undefined;
            resourceInputs["keyUsage"] = state ? state.keyUsage : undefined;
            resourceInputs["lastRotationDate"] = state ? state.lastRotationDate : undefined;
            resourceInputs["materialExpireTime"] = state ? state.materialExpireTime : undefined;
            resourceInputs["nextRotationDate"] = state ? state.nextRotationDate : undefined;
            resourceInputs["origin"] = state ? state.origin : undefined;
            resourceInputs["pendingWindowInDays"] = state ? state.pendingWindowInDays : undefined;
            resourceInputs["primaryKeyVersion"] = state ? state.primaryKeyVersion : undefined;
            resourceInputs["protectionLevel"] = state ? state.protectionLevel : undefined;
            resourceInputs["rotationInterval"] = state ? state.rotationInterval : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
        } else {
            const args = argsOrState as KeyArgs | undefined;
            resourceInputs["automaticRotation"] = args ? args.automaticRotation : undefined;
            resourceInputs["deletionWindowInDays"] = args ? args.deletionWindowInDays : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["dkmsInstanceId"] = args ? args.dkmsInstanceId : undefined;
            resourceInputs["isEnabled"] = args ? args.isEnabled : undefined;
            resourceInputs["keySpec"] = args ? args.keySpec : undefined;
            resourceInputs["keyState"] = args ? args.keyState : undefined;
            resourceInputs["keyUsage"] = args ? args.keyUsage : undefined;
            resourceInputs["origin"] = args ? args.origin : undefined;
            resourceInputs["pendingWindowInDays"] = args ? args.pendingWindowInDays : undefined;
            resourceInputs["protectionLevel"] = args ? args.protectionLevel : undefined;
            resourceInputs["rotationInterval"] = args ? args.rotationInterval : undefined;
            resourceInputs["status"] = args ? args.status : undefined;
            resourceInputs["arn"] = undefined /*out*/;
            resourceInputs["creationDate"] = undefined /*out*/;
            resourceInputs["creator"] = undefined /*out*/;
            resourceInputs["deleteDate"] = undefined /*out*/;
            resourceInputs["lastRotationDate"] = undefined /*out*/;
            resourceInputs["materialExpireTime"] = undefined /*out*/;
            resourceInputs["nextRotationDate"] = undefined /*out*/;
            resourceInputs["primaryKeyVersion"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Key.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Key resources.
 */
export interface KeyState {
    /**
     * The Alicloud Resource Name (ARN) of the key.
     * * `creationDate` -The date and time when the CMK was created. The time is displayed in UTC.
     * * `creator` -The creator of the CMK.
     * * `deleteDate` -The scheduled date to delete CMK. The time is displayed in UTC. This value is returned only when the KeyState value is PendingDeletion.
     */
    arn?: pulumi.Input<string>;
    /**
     * Specifies whether to enable automatic key rotation. Valid values: 
     * - Enabled
     * - Disabled (default value)
     * **NOTE**: If you set the origin parameter to EXTERNAL or the keySpec parameter to an asymmetric CMK type, automatic key rotation is unavailable.
     */
    automaticRotation?: pulumi.Input<string>;
    creationDate?: pulumi.Input<string>;
    creator?: pulumi.Input<string>;
    deleteDate?: pulumi.Input<string>;
    /**
     * Field `deletionWindowInDays` has been deprecated from provider version 1.85.0. New field `pendingWindowInDays` instead.
     *
     * @deprecated Field 'deletion_window_in_days' has been deprecated from provider version 1.85.0. New field 'pending_window_in_days' instead.
     */
    deletionWindowInDays?: pulumi.Input<number>;
    /**
     * The description of the CMK. The description can be 0 to 8,192 characters in length.
     */
    description?: pulumi.Input<string>;
    /**
     * The instance ID of the exclusive KMS instance.
     */
    dkmsInstanceId?: pulumi.Input<string>;
    /**
     * Field `isEnabled` has been deprecated from provider version 1.85.0. New field `keyState` instead.
     *
     * @deprecated Field 'is_enabled' has been deprecated from provider version 1.85.0. New field 'key_state' instead.
     */
    isEnabled?: pulumi.Input<boolean>;
    /**
     * The type of the CMK. Valid values: 
     * "Aliyun_AES_256", "Aliyun_AES_128", "Aliyun_AES_192", "Aliyun_SM4", "RSA_2048", "RSA_3072", "EC_P256", "EC_P256K", "EC_SM2".
     * Note: The default type of the CMK is Aliyun_AES_256. Only Dedicated KMS supports Aliyun_AES_128 and Aliyun_AES_192.
     */
    keySpec?: pulumi.Input<string>;
    /**
     * Field `keyState` has been deprecated from provider version 1.123.1. New field `status` instead.
     *
     * @deprecated Field 'key_state' has been deprecated from provider version 1.123.1. New field 'status' instead.
     */
    keyState?: pulumi.Input<string>;
    /**
     * The usage of the CMK. Valid values:
     * - ENCRYPT/DECRYPT(default value): encrypts or decrypts data.
     * - SIGN/VERIFY: generates or verifies a digital signature.
     */
    keyUsage?: pulumi.Input<string>;
    /**
     * The date and time the last rotation was performed. The time is displayed in UTC.
     */
    lastRotationDate?: pulumi.Input<string>;
    /**
     * The time and date the key material for the CMK expires. The time is displayed in UTC. If the value is empty, the key material for the CMK does not expire.
     */
    materialExpireTime?: pulumi.Input<string>;
    /**
     * The time the next rotation is scheduled for execution.
     */
    nextRotationDate?: pulumi.Input<string>;
    /**
     * The source of key material. Valid values: 
     * - Aliyun_KMS (default value)
     * - EXTERNAL
     * **NOTE**: The value of this parameter is case-sensitive. If you set the `keySpec` to an asymmetric CMK type,
     * you are not allowed to set the `origin` to EXTERNAL. If you set the `origin` to EXTERNAL, you must import key material.
     * For more information, see [import key material](https://www.alibabacloud.com/help/en/doc-detail/68523.htm).
     */
    origin?: pulumi.Input<string>;
    /**
     * The number of days before the CMK is deleted. 
     * During this period, the CMK is in the PendingDeletion state.
     * After this period ends, you cannot cancel the deletion. Valid values: 7 to 366. Unit: days.
     * **NOTE:** From version 1.184.0, `pendingWindowInDays` can be set to `366`.
     */
    pendingWindowInDays?: pulumi.Input<number>;
    /**
     * The ID of the current primary key version of the symmetric CMK.
     */
    primaryKeyVersion?: pulumi.Input<string>;
    /**
     * The protection level of the CMK. Valid values:
     * - SOFTWARE (default value)
     * - HSM
     * **NOTE**: The value of this parameter is case-sensitive. Assume that you set this parameter to HSM.
     * If you set the origin parameter to Aliyun_KMS, the CMK is created in a managed hardware security module (HSM).
     * If you set the origin parameter to EXTERNA, you can import an external key to the managed HSM.
     */
    protectionLevel?: pulumi.Input<string>;
    /**
     * The interval for automatic key rotation. Specify the value in the integer[unit] format.
     * The following units are supported: d (day), h (hour), m (minute), and s (second).
     * For example, you can use either 7d or 604800s to specify a seven-day interval.
     * The interval can range from 7 days to 730 days.
     * **NOTE**: It is Required when `automaticRotation = "Enabled"`
     */
    rotationInterval?: pulumi.Input<string>;
    /**
     * The status of CMK. Valid Values: 
     * - Disabled
     * - Enabled (default value)
     * - PendingDeletion
     */
    status?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Key resource.
 */
export interface KeyArgs {
    /**
     * Specifies whether to enable automatic key rotation. Valid values: 
     * - Enabled
     * - Disabled (default value)
     * **NOTE**: If you set the origin parameter to EXTERNAL or the keySpec parameter to an asymmetric CMK type, automatic key rotation is unavailable.
     */
    automaticRotation?: pulumi.Input<string>;
    /**
     * Field `deletionWindowInDays` has been deprecated from provider version 1.85.0. New field `pendingWindowInDays` instead.
     *
     * @deprecated Field 'deletion_window_in_days' has been deprecated from provider version 1.85.0. New field 'pending_window_in_days' instead.
     */
    deletionWindowInDays?: pulumi.Input<number>;
    /**
     * The description of the CMK. The description can be 0 to 8,192 characters in length.
     */
    description?: pulumi.Input<string>;
    /**
     * The instance ID of the exclusive KMS instance.
     */
    dkmsInstanceId?: pulumi.Input<string>;
    /**
     * Field `isEnabled` has been deprecated from provider version 1.85.0. New field `keyState` instead.
     *
     * @deprecated Field 'is_enabled' has been deprecated from provider version 1.85.0. New field 'key_state' instead.
     */
    isEnabled?: pulumi.Input<boolean>;
    /**
     * The type of the CMK. Valid values: 
     * "Aliyun_AES_256", "Aliyun_AES_128", "Aliyun_AES_192", "Aliyun_SM4", "RSA_2048", "RSA_3072", "EC_P256", "EC_P256K", "EC_SM2".
     * Note: The default type of the CMK is Aliyun_AES_256. Only Dedicated KMS supports Aliyun_AES_128 and Aliyun_AES_192.
     */
    keySpec?: pulumi.Input<string>;
    /**
     * Field `keyState` has been deprecated from provider version 1.123.1. New field `status` instead.
     *
     * @deprecated Field 'key_state' has been deprecated from provider version 1.123.1. New field 'status' instead.
     */
    keyState?: pulumi.Input<string>;
    /**
     * The usage of the CMK. Valid values:
     * - ENCRYPT/DECRYPT(default value): encrypts or decrypts data.
     * - SIGN/VERIFY: generates or verifies a digital signature.
     */
    keyUsage?: pulumi.Input<string>;
    /**
     * The source of key material. Valid values: 
     * - Aliyun_KMS (default value)
     * - EXTERNAL
     * **NOTE**: The value of this parameter is case-sensitive. If you set the `keySpec` to an asymmetric CMK type,
     * you are not allowed to set the `origin` to EXTERNAL. If you set the `origin` to EXTERNAL, you must import key material.
     * For more information, see [import key material](https://www.alibabacloud.com/help/en/doc-detail/68523.htm).
     */
    origin?: pulumi.Input<string>;
    /**
     * The number of days before the CMK is deleted. 
     * During this period, the CMK is in the PendingDeletion state.
     * After this period ends, you cannot cancel the deletion. Valid values: 7 to 366. Unit: days.
     * **NOTE:** From version 1.184.0, `pendingWindowInDays` can be set to `366`.
     */
    pendingWindowInDays?: pulumi.Input<number>;
    /**
     * The protection level of the CMK. Valid values:
     * - SOFTWARE (default value)
     * - HSM
     * **NOTE**: The value of this parameter is case-sensitive. Assume that you set this parameter to HSM.
     * If you set the origin parameter to Aliyun_KMS, the CMK is created in a managed hardware security module (HSM).
     * If you set the origin parameter to EXTERNA, you can import an external key to the managed HSM.
     */
    protectionLevel?: pulumi.Input<string>;
    /**
     * The interval for automatic key rotation. Specify the value in the integer[unit] format.
     * The following units are supported: d (day), h (hour), m (minute), and s (second).
     * For example, you can use either 7d or 604800s to specify a seven-day interval.
     * The interval can range from 7 days to 730 days.
     * **NOTE**: It is Required when `automaticRotation = "Enabled"`
     */
    rotationInterval?: pulumi.Input<string>;
    /**
     * The status of CMK. Valid Values: 
     * - Disabled
     * - Enabled (default value)
     * - PendingDeletion
     */
    status?: pulumi.Input<string>;
}