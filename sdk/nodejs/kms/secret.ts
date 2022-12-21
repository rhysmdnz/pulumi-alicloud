// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * This resouce used to create a secret and store its initial version.
 *
 * > **NOTE:** Available in 1.76.0+.
 *
 * ## Example Usage
 *
 * Basic Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const defaultSecret = new alicloud.kms.Secret("default", {
 *     description: "from terraform",
 *     forceDeleteWithoutRecovery: true,
 *     secretData: "Secret data.",
 *     secretName: "secret-foo",
 *     versionId: "000000000001",
 * });
 * ```
 *
 * ## Import
 *
 * KMS secret can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import alicloud:kms/secret:Secret default secret-foo
 * ```
 */
export class Secret extends pulumi.CustomResource {
    /**
     * Get an existing Secret resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SecretState, opts?: pulumi.CustomResourceOptions): Secret {
        return new Secret(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'alicloud:kms/secret:Secret';

    /**
     * Returns true if the given object is an instance of Secret.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Secret {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Secret.__pulumiType;
    }

    /**
     * The Alicloud Resource Name (ARN) of the secret.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * The description of the secret.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The instance ID of the exclusive KMS instance.
     */
    public readonly dkmsInstanceId!: pulumi.Output<string | undefined>;
    /**
     * Whether to enable automatic key rotation.
     */
    public readonly enableAutomaticRotation!: pulumi.Output<boolean | undefined>;
    /**
     * The ID of the KMS CMK that is used to encrypt the secret value. If you do not specify this parameter, Secrets Manager automatically creates an encryption key to encrypt the secret.
     */
    public readonly encryptionKeyId!: pulumi.Output<string | undefined>;
    /**
     * Specifies whether to forcibly delete the secret. If this parameter is set to true, the secret cannot be recovered. Valid values: true, false. Default to: false.
     */
    public readonly forceDeleteWithoutRecovery!: pulumi.Output<boolean | undefined>;
    /**
     * The time when the secret is scheduled to be deleted.
     */
    public /*out*/ readonly plannedDeleteTime!: pulumi.Output<string>;
    /**
     * Specifies the recovery period of the secret if you do not forcibly delete it. Default value: 30. It will be ignored when `forceDeleteWithoutRecovery` is true.
     */
    public readonly recoveryWindowInDays!: pulumi.Output<number | undefined>;
    /**
     * The time period of automatic rotation. The format is integer[unit], where integer represents the length of time, and unit represents the unit of time. The legal unit units are: d (day), h (hour), m (minute), s (second). 7d or 604800s both indicate a 7-day cycle.
     */
    public readonly rotationInterval!: pulumi.Output<string | undefined>;
    /**
     * The value of the secret that you want to create. Secrets Manager encrypts the secret value and stores it in the initial version.
     */
    public readonly secretData!: pulumi.Output<string>;
    /**
     * The type of the secret value. Valid values: text, binary. Default to "text".
     */
    public readonly secretDataType!: pulumi.Output<string | undefined>;
    /**
     * The name of the secret.
     */
    public readonly secretName!: pulumi.Output<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * The version number of the initial version. Version numbers are unique in each secret object.
     */
    public readonly versionId!: pulumi.Output<string>;
    /**
     * ) The stage labels that mark the new secret version. If you do not specify this parameter, Secrets Manager marks it with "ACSCurrent".
     */
    public readonly versionStages!: pulumi.Output<string[]>;

    /**
     * Create a Secret resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SecretArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SecretArgs | SecretState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SecretState | undefined;
            resourceInputs["arn"] = state ? state.arn : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["dkmsInstanceId"] = state ? state.dkmsInstanceId : undefined;
            resourceInputs["enableAutomaticRotation"] = state ? state.enableAutomaticRotation : undefined;
            resourceInputs["encryptionKeyId"] = state ? state.encryptionKeyId : undefined;
            resourceInputs["forceDeleteWithoutRecovery"] = state ? state.forceDeleteWithoutRecovery : undefined;
            resourceInputs["plannedDeleteTime"] = state ? state.plannedDeleteTime : undefined;
            resourceInputs["recoveryWindowInDays"] = state ? state.recoveryWindowInDays : undefined;
            resourceInputs["rotationInterval"] = state ? state.rotationInterval : undefined;
            resourceInputs["secretData"] = state ? state.secretData : undefined;
            resourceInputs["secretDataType"] = state ? state.secretDataType : undefined;
            resourceInputs["secretName"] = state ? state.secretName : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["versionId"] = state ? state.versionId : undefined;
            resourceInputs["versionStages"] = state ? state.versionStages : undefined;
        } else {
            const args = argsOrState as SecretArgs | undefined;
            if ((!args || args.secretData === undefined) && !opts.urn) {
                throw new Error("Missing required property 'secretData'");
            }
            if ((!args || args.secretName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'secretName'");
            }
            if ((!args || args.versionId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'versionId'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["dkmsInstanceId"] = args ? args.dkmsInstanceId : undefined;
            resourceInputs["enableAutomaticRotation"] = args ? args.enableAutomaticRotation : undefined;
            resourceInputs["encryptionKeyId"] = args ? args.encryptionKeyId : undefined;
            resourceInputs["forceDeleteWithoutRecovery"] = args ? args.forceDeleteWithoutRecovery : undefined;
            resourceInputs["recoveryWindowInDays"] = args ? args.recoveryWindowInDays : undefined;
            resourceInputs["rotationInterval"] = args ? args.rotationInterval : undefined;
            resourceInputs["secretData"] = args ? args.secretData : undefined;
            resourceInputs["secretDataType"] = args ? args.secretDataType : undefined;
            resourceInputs["secretName"] = args ? args.secretName : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["versionId"] = args ? args.versionId : undefined;
            resourceInputs["versionStages"] = args ? args.versionStages : undefined;
            resourceInputs["arn"] = undefined /*out*/;
            resourceInputs["plannedDeleteTime"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Secret.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Secret resources.
 */
export interface SecretState {
    /**
     * The Alicloud Resource Name (ARN) of the secret.
     */
    arn?: pulumi.Input<string>;
    /**
     * The description of the secret.
     */
    description?: pulumi.Input<string>;
    /**
     * The instance ID of the exclusive KMS instance.
     */
    dkmsInstanceId?: pulumi.Input<string>;
    /**
     * Whether to enable automatic key rotation.
     */
    enableAutomaticRotation?: pulumi.Input<boolean>;
    /**
     * The ID of the KMS CMK that is used to encrypt the secret value. If you do not specify this parameter, Secrets Manager automatically creates an encryption key to encrypt the secret.
     */
    encryptionKeyId?: pulumi.Input<string>;
    /**
     * Specifies whether to forcibly delete the secret. If this parameter is set to true, the secret cannot be recovered. Valid values: true, false. Default to: false.
     */
    forceDeleteWithoutRecovery?: pulumi.Input<boolean>;
    /**
     * The time when the secret is scheduled to be deleted.
     */
    plannedDeleteTime?: pulumi.Input<string>;
    /**
     * Specifies the recovery period of the secret if you do not forcibly delete it. Default value: 30. It will be ignored when `forceDeleteWithoutRecovery` is true.
     */
    recoveryWindowInDays?: pulumi.Input<number>;
    /**
     * The time period of automatic rotation. The format is integer[unit], where integer represents the length of time, and unit represents the unit of time. The legal unit units are: d (day), h (hour), m (minute), s (second). 7d or 604800s both indicate a 7-day cycle.
     */
    rotationInterval?: pulumi.Input<string>;
    /**
     * The value of the secret that you want to create. Secrets Manager encrypts the secret value and stores it in the initial version.
     */
    secretData?: pulumi.Input<string>;
    /**
     * The type of the secret value. Valid values: text, binary. Default to "text".
     */
    secretDataType?: pulumi.Input<string>;
    /**
     * The name of the secret.
     */
    secretName?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * The version number of the initial version. Version numbers are unique in each secret object.
     */
    versionId?: pulumi.Input<string>;
    /**
     * ) The stage labels that mark the new secret version. If you do not specify this parameter, Secrets Manager marks it with "ACSCurrent".
     */
    versionStages?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a Secret resource.
 */
export interface SecretArgs {
    /**
     * The description of the secret.
     */
    description?: pulumi.Input<string>;
    /**
     * The instance ID of the exclusive KMS instance.
     */
    dkmsInstanceId?: pulumi.Input<string>;
    /**
     * Whether to enable automatic key rotation.
     */
    enableAutomaticRotation?: pulumi.Input<boolean>;
    /**
     * The ID of the KMS CMK that is used to encrypt the secret value. If you do not specify this parameter, Secrets Manager automatically creates an encryption key to encrypt the secret.
     */
    encryptionKeyId?: pulumi.Input<string>;
    /**
     * Specifies whether to forcibly delete the secret. If this parameter is set to true, the secret cannot be recovered. Valid values: true, false. Default to: false.
     */
    forceDeleteWithoutRecovery?: pulumi.Input<boolean>;
    /**
     * Specifies the recovery period of the secret if you do not forcibly delete it. Default value: 30. It will be ignored when `forceDeleteWithoutRecovery` is true.
     */
    recoveryWindowInDays?: pulumi.Input<number>;
    /**
     * The time period of automatic rotation. The format is integer[unit], where integer represents the length of time, and unit represents the unit of time. The legal unit units are: d (day), h (hour), m (minute), s (second). 7d or 604800s both indicate a 7-day cycle.
     */
    rotationInterval?: pulumi.Input<string>;
    /**
     * The value of the secret that you want to create. Secrets Manager encrypts the secret value and stores it in the initial version.
     */
    secretData: pulumi.Input<string>;
    /**
     * The type of the secret value. Valid values: text, binary. Default to "text".
     */
    secretDataType?: pulumi.Input<string>;
    /**
     * The name of the secret.
     */
    secretName: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * The version number of the initial version. Version numbers are unique in each secret object.
     */
    versionId: pulumi.Input<string>;
    /**
     * ) The stage labels that mark the new secret version. If you do not specify this parameter, Secrets Manager marks it with "ACSCurrent".
     */
    versionStages?: pulumi.Input<pulumi.Input<string>[]>;
}