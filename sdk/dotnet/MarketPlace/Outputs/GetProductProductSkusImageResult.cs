// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.MarketPlace.Outputs
{

    [OutputType]
    public sealed class GetProductProductSkusImageResult
    {
        /// <summary>
        /// The Ecs image id.
        /// </summary>
        public readonly string ImageId;
        /// <summary>
        /// The Ecs image display name.
        /// </summary>
        public readonly string ImageName;
        /// <summary>
        /// The Ecs image region.
        /// </summary>
        public readonly string RegionId;

        [OutputConstructor]
        private GetProductProductSkusImageResult(
            string imageId,

            string imageName,

            string regionId)
        {
            ImageId = imageId;
            ImageName = imageName;
            RegionId = regionId;
        }
    }
}