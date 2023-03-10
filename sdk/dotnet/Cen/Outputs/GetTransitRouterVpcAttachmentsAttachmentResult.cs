// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Cen.Outputs
{

    [OutputType]
    public sealed class GetTransitRouterVpcAttachmentsAttachmentResult
    {
        /// <summary>
        /// The ID of the transit router.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The payment type of the resource.
        /// </summary>
        public readonly string PaymentType;
        /// <summary>
        /// Type of the resource.
        /// </summary>
        public readonly string ResourceType;
        /// <summary>
        /// The status of the resource. Valid values `Attached`, `Attaching` and `Detaching`.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// The description of transit router attachment.
        /// </summary>
        public readonly string TransitRouterAttachmentDescription;
        /// <summary>
        /// ID of the transit router VBR attachment.
        /// </summary>
        public readonly string TransitRouterAttachmentId;
        /// <summary>
        /// Name of the transit router attachment.
        /// </summary>
        public readonly string TransitRouterAttachmentName;
        /// <summary>
        /// ID of the VPC.
        /// </summary>
        public readonly string VpcId;
        /// <summary>
        /// The Owner ID of the VPC.
        /// </summary>
        public readonly string VpcOwnerId;
        /// <summary>
        /// The mappings of zone
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTransitRouterVpcAttachmentsAttachmentZoneMappingResult> ZoneMappings;

        [OutputConstructor]
        private GetTransitRouterVpcAttachmentsAttachmentResult(
            string id,

            string paymentType,

            string resourceType,

            string status,

            string transitRouterAttachmentDescription,

            string transitRouterAttachmentId,

            string transitRouterAttachmentName,

            string vpcId,

            string vpcOwnerId,

            ImmutableArray<Outputs.GetTransitRouterVpcAttachmentsAttachmentZoneMappingResult> zoneMappings)
        {
            Id = id;
            PaymentType = paymentType;
            ResourceType = resourceType;
            Status = status;
            TransitRouterAttachmentDescription = transitRouterAttachmentDescription;
            TransitRouterAttachmentId = transitRouterAttachmentId;
            TransitRouterAttachmentName = transitRouterAttachmentName;
            VpcId = vpcId;
            VpcOwnerId = vpcOwnerId;
            ZoneMappings = zoneMappings;
        }
    }
}
