// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.CS.Outputs
{

    [OutputType]
    public sealed class NodePoolDataDisk
    {
        public readonly string? AutoSnapshotPolicyId;
        /// <summary>
        /// The type of the data disks. Valid values:`cloud`, `cloud_efficiency`, `cloud_ssd` and `cloud_essd`.
        /// </summary>
        public readonly string? Category;
        public readonly string? Device;
        /// <summary>
        /// Specifies whether to encrypt data disks. Valid values: true and false. Default to `false`.
        /// </summary>
        public readonly string? Encrypted;
        /// <summary>
        /// The kms key id used to encrypt the data disk. It takes effect when `encrypted` is true.
        /// </summary>
        public readonly string? KmsKeyId;
        /// <summary>
        /// The name of node pool.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Worker node data disk performance level, when `category` values `cloud_essd`, the optional values are `PL0`, `PL1`, `PL2` or `PL3`, but the specific performance level is related to the disk capacity. For more information, see [Enhanced SSDs](https://www.alibabacloud.com/help/doc-detail/122389.htm). Default is `PL1`.
        /// </summary>
        public readonly string? PerformanceLevel;
        /// <summary>
        /// The size of a data disk, Its valid value range [40~32768] in GB. Default to `40`.
        /// </summary>
        public readonly int? Size;
        public readonly string? SnapshotId;

        [OutputConstructor]
        private NodePoolDataDisk(
            string? autoSnapshotPolicyId,

            string? category,

            string? device,

            string? encrypted,

            string? kmsKeyId,

            string? name,

            string? performanceLevel,

            int? size,

            string? snapshotId)
        {
            AutoSnapshotPolicyId = autoSnapshotPolicyId;
            Category = category;
            Device = device;
            Encrypted = encrypted;
            KmsKeyId = kmsKeyId;
            Name = name;
            PerformanceLevel = performanceLevel;
            Size = size;
            SnapshotId = snapshotId;
        }
    }
}
