// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Ecs.Outputs
{

    [OutputType]
    public sealed class EcsLaunchTemplateSystemDisk
    {
        /// <summary>
        /// The category of the disk.
        /// </summary>
        public readonly string? Category;
        /// <summary>
        /// Indicates whether the data disk is released with the instance.
        /// </summary>
        public readonly bool? DeleteWithInstance;
        /// <summary>
        /// The description of the data disk.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The Iops.
        /// </summary>
        public readonly string? Iops;
        /// <summary>
        /// The name of the data disk.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The performance level of the ESSD used as the data disk.
        /// </summary>
        public readonly string? PerformanceLevel;
        /// <summary>
        /// The size of the data disk.
        /// </summary>
        public readonly int? Size;

        [OutputConstructor]
        private EcsLaunchTemplateSystemDisk(
            string? category,

            bool? deleteWithInstance,

            string? description,

            string? iops,

            string? name,

            string? performanceLevel,

            int? size)
        {
            Category = category;
            DeleteWithInstance = deleteWithInstance;
            Description = description;
            Iops = iops;
            Name = name;
            PerformanceLevel = performanceLevel;
            Size = size;
        }
    }
}