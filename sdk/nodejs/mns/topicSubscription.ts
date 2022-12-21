// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * ## Example Usage
 *
 * Basic Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as alicloud from "@pulumi/alicloud";
 *
 * const topic = new alicloud.mns.Topic("topic", {
 *     loggingEnabled: false,
 *     maximumMessageSize: 65536,
 * });
 * const subscription = new alicloud.mns.TopicSubscription("subscription", {
 *     endpoint: "http://www.xxx.com/xxx",
 *     filterTag: "test",
 *     notifyContentFormat: "XML",
 *     notifyStrategy: "BACKOFF_RETRY",
 *     topicName: "tf-example-mnstopic",
 * });
 * ```
 *
 * ## Import
 *
 * MNS Topic subscription can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import alicloud:mns/topicSubscription:TopicSubscription subscription tf-example-mnstopic:tf-example-mnstopic-sub
 * ```
 */
export class TopicSubscription extends pulumi.CustomResource {
    /**
     * Get an existing TopicSubscription resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: TopicSubscriptionState, opts?: pulumi.CustomResourceOptions): TopicSubscription {
        return new TopicSubscription(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'alicloud:mns/topicSubscription:TopicSubscription';

    /**
     * Returns true if the given object is an instance of TopicSubscription.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is TopicSubscription {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === TopicSubscription.__pulumiType;
    }

    /**
     * The endpoint has three format. Available values format:
     * - `HTTP Format`: http://xxx.com/xxx
     * - `Queue Format`: acs:mns:{REGION}:{AccountID}:queues/{QueueName}
     * - `Email Format`: mail:directmail:{MailAddress}
     */
    public readonly endpoint!: pulumi.Output<string>;
    /**
     * The length should be shorter than 16.
     */
    public readonly filterTag!: pulumi.Output<string | undefined>;
    /**
     * Two topics subscription on a single account in the same topic cannot have the same name. A topic subscription name must start with an English letter or a digit, and can contain English letters, digits, and hyphens, with the length not exceeding 256 characters.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The NotifyContentFormat attribute of Subscription. This attribute specifies the content format of the messages pushed to users. The valid values: `SIMPLIFIED`, `XML` and `JSON`. Default to `SIMPLIFIED`.
     */
    public readonly notifyContentFormat!: pulumi.Output<string | undefined>;
    /**
     * The NotifyStrategy attribute of Subscription. This attribute specifies the retry strategy when message sending fails. The Valid values: `EXPONENTIAL_DECAY_RETRY` and `BACKOFF_RETRY`. Default value to `BACKOFF_RETRY` .
     */
    public readonly notifyStrategy!: pulumi.Output<string | undefined>;
    /**
     * The topic which The subscription belongs to was named with the name.A topic name must start with an English letter or a digit, and can contain English letters, digits, and hyphens, with the length not exceeding 256 characters.
     */
    public readonly topicName!: pulumi.Output<string>;

    /**
     * Create a TopicSubscription resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TopicSubscriptionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: TopicSubscriptionArgs | TopicSubscriptionState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as TopicSubscriptionState | undefined;
            resourceInputs["endpoint"] = state ? state.endpoint : undefined;
            resourceInputs["filterTag"] = state ? state.filterTag : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["notifyContentFormat"] = state ? state.notifyContentFormat : undefined;
            resourceInputs["notifyStrategy"] = state ? state.notifyStrategy : undefined;
            resourceInputs["topicName"] = state ? state.topicName : undefined;
        } else {
            const args = argsOrState as TopicSubscriptionArgs | undefined;
            if ((!args || args.endpoint === undefined) && !opts.urn) {
                throw new Error("Missing required property 'endpoint'");
            }
            if ((!args || args.topicName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'topicName'");
            }
            resourceInputs["endpoint"] = args ? args.endpoint : undefined;
            resourceInputs["filterTag"] = args ? args.filterTag : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["notifyContentFormat"] = args ? args.notifyContentFormat : undefined;
            resourceInputs["notifyStrategy"] = args ? args.notifyStrategy : undefined;
            resourceInputs["topicName"] = args ? args.topicName : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(TopicSubscription.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering TopicSubscription resources.
 */
export interface TopicSubscriptionState {
    /**
     * The endpoint has three format. Available values format:
     * - `HTTP Format`: http://xxx.com/xxx
     * - `Queue Format`: acs:mns:{REGION}:{AccountID}:queues/{QueueName}
     * - `Email Format`: mail:directmail:{MailAddress}
     */
    endpoint?: pulumi.Input<string>;
    /**
     * The length should be shorter than 16.
     */
    filterTag?: pulumi.Input<string>;
    /**
     * Two topics subscription on a single account in the same topic cannot have the same name. A topic subscription name must start with an English letter or a digit, and can contain English letters, digits, and hyphens, with the length not exceeding 256 characters.
     */
    name?: pulumi.Input<string>;
    /**
     * The NotifyContentFormat attribute of Subscription. This attribute specifies the content format of the messages pushed to users. The valid values: `SIMPLIFIED`, `XML` and `JSON`. Default to `SIMPLIFIED`.
     */
    notifyContentFormat?: pulumi.Input<string>;
    /**
     * The NotifyStrategy attribute of Subscription. This attribute specifies the retry strategy when message sending fails. The Valid values: `EXPONENTIAL_DECAY_RETRY` and `BACKOFF_RETRY`. Default value to `BACKOFF_RETRY` .
     */
    notifyStrategy?: pulumi.Input<string>;
    /**
     * The topic which The subscription belongs to was named with the name.A topic name must start with an English letter or a digit, and can contain English letters, digits, and hyphens, with the length not exceeding 256 characters.
     */
    topicName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a TopicSubscription resource.
 */
export interface TopicSubscriptionArgs {
    /**
     * The endpoint has three format. Available values format:
     * - `HTTP Format`: http://xxx.com/xxx
     * - `Queue Format`: acs:mns:{REGION}:{AccountID}:queues/{QueueName}
     * - `Email Format`: mail:directmail:{MailAddress}
     */
    endpoint: pulumi.Input<string>;
    /**
     * The length should be shorter than 16.
     */
    filterTag?: pulumi.Input<string>;
    /**
     * Two topics subscription on a single account in the same topic cannot have the same name. A topic subscription name must start with an English letter or a digit, and can contain English letters, digits, and hyphens, with the length not exceeding 256 characters.
     */
    name?: pulumi.Input<string>;
    /**
     * The NotifyContentFormat attribute of Subscription. This attribute specifies the content format of the messages pushed to users. The valid values: `SIMPLIFIED`, `XML` and `JSON`. Default to `SIMPLIFIED`.
     */
    notifyContentFormat?: pulumi.Input<string>;
    /**
     * The NotifyStrategy attribute of Subscription. This attribute specifies the retry strategy when message sending fails. The Valid values: `EXPONENTIAL_DECAY_RETRY` and `BACKOFF_RETRY`. Default value to `BACKOFF_RETRY` .
     */
    notifyStrategy?: pulumi.Input<string>;
    /**
     * The topic which The subscription belongs to was named with the name.A topic name must start with an English letter or a digit, and can contain English letters, digits, and hyphens, with the length not exceeding 256 characters.
     */
    topicName: pulumi.Input<string>;
}