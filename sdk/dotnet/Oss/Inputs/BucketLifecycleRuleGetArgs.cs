// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Oss.Inputs
{

    public sealed class BucketLifecycleRuleGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("abortMultipartUploads")]
        private InputList<Inputs.BucketLifecycleRuleAbortMultipartUploadGetArgs>? _abortMultipartUploads;

        /// <summary>
        /// Specifies the number of days after initiating a multipart upload when the multipart upload must be completed (documented below).
        /// </summary>
        public InputList<Inputs.BucketLifecycleRuleAbortMultipartUploadGetArgs> AbortMultipartUploads
        {
            get => _abortMultipartUploads ?? (_abortMultipartUploads = new InputList<Inputs.BucketLifecycleRuleAbortMultipartUploadGetArgs>());
            set => _abortMultipartUploads = value;
        }

        /// <summary>
        /// Specifies the accelerate status of a bucket.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("expirations")]
        private InputList<Inputs.BucketLifecycleRuleExpirationGetArgs>? _expirations;

        /// <summary>
        /// Specifies a period in the object's expire (documented below).
        /// </summary>
        public InputList<Inputs.BucketLifecycleRuleExpirationGetArgs> Expirations
        {
            get => _expirations ?? (_expirations = new InputList<Inputs.BucketLifecycleRuleExpirationGetArgs>());
            set => _expirations = value;
        }

        /// <summary>
        /// Unique identifier for the rule. If omitted, OSS bucket will assign a unique name.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("noncurrentVersionExpirations")]
        private InputList<Inputs.BucketLifecycleRuleNoncurrentVersionExpirationGetArgs>? _noncurrentVersionExpirations;

        /// <summary>
        /// Specifies when noncurrent object versions expire (documented below).
        /// </summary>
        public InputList<Inputs.BucketLifecycleRuleNoncurrentVersionExpirationGetArgs> NoncurrentVersionExpirations
        {
            get => _noncurrentVersionExpirations ?? (_noncurrentVersionExpirations = new InputList<Inputs.BucketLifecycleRuleNoncurrentVersionExpirationGetArgs>());
            set => _noncurrentVersionExpirations = value;
        }

        [Input("noncurrentVersionTransitions")]
        private InputList<Inputs.BucketLifecycleRuleNoncurrentVersionTransitionGetArgs>? _noncurrentVersionTransitions;

        /// <summary>
        /// Specifies when noncurrent object versions transitions (documented below).
        /// </summary>
        public InputList<Inputs.BucketLifecycleRuleNoncurrentVersionTransitionGetArgs> NoncurrentVersionTransitions
        {
            get => _noncurrentVersionTransitions ?? (_noncurrentVersionTransitions = new InputList<Inputs.BucketLifecycleRuleNoncurrentVersionTransitionGetArgs>());
            set => _noncurrentVersionTransitions = value;
        }

        /// <summary>
        /// Object key prefix identifying one or more objects to which the rule applies. Default value is null, the rule applies to all objects in a bucket.
        /// </summary>
        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        [Input("transitions")]
        private InputList<Inputs.BucketLifecycleRuleTransitionGetArgs>? _transitions;

        /// <summary>
        /// Specifies the time when an object is converted to the IA or archive storage class during a valid life cycle. (documented below).
        /// </summary>
        public InputList<Inputs.BucketLifecycleRuleTransitionGetArgs> Transitions
        {
            get => _transitions ?? (_transitions = new InputList<Inputs.BucketLifecycleRuleTransitionGetArgs>());
            set => _transitions = value;
        }

        public BucketLifecycleRuleGetArgs()
        {
        }
        public static new BucketLifecycleRuleGetArgs Empty => new BucketLifecycleRuleGetArgs();
    }
}