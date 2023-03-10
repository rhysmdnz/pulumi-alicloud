// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Oss.Outputs
{

    [OutputType]
    public sealed class BucketLifecycleRuleTransition
    {
        /// <summary>
        /// Specifies the time before which the rules take effect. The date must conform to the ISO8601 format and always be UTC 00:00. For example: 2002-10-11T00:00:00.000Z indicates that parts created before 2002-10-11T00:00:00.000Z are deleted, and parts created after this time (including this time) are not deleted.
        /// </summary>
        public readonly string? CreatedBeforeDate;
        /// <summary>
        /// Specifies the number of days noncurrent object versions transition.
        /// </summary>
        public readonly int? Days;
        /// <summary>
        /// Specifies the storage class that objects that conform to the rule are converted into. The storage class of the objects in a bucket of the IA storage class can be converted into Archive but cannot be converted into Standard. Values: `IA`, `Archive`.
        /// </summary>
        public readonly string? StorageClass;

        [OutputConstructor]
        private BucketLifecycleRuleTransition(
            string? createdBeforeDate,

            int? days,

            string? storageClass)
        {
            CreatedBeforeDate = createdBeforeDate;
            Days = days;
            StorageClass = storageClass;
        }
    }
}
