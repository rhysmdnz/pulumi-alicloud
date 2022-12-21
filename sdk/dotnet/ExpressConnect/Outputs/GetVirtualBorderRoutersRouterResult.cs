// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.ExpressConnect.Outputs
{

    [OutputType]
    public sealed class GetVirtualBorderRoutersRouterResult
    {
        /// <summary>
        /// The physical leased line access point ID.
        /// </summary>
        public readonly string AccessPointId;
        /// <summary>
        /// The first activation time of VBR.
        /// </summary>
        public readonly string ActivationTime;
        /// <summary>
        /// Operators for physical connection circuit provided coding.
        /// </summary>
        public readonly string CircuitCode;
        /// <summary>
        /// Box Instance Id.
        /// </summary>
        public readonly string CloudBoxInstanceId;
        /// <summary>
        /// The representative of the creation time resources attribute field.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// The description of VBR. Length is from 2 to 256 characters, must start with a letter or the Chinese at the beginning, but not at the http:// Or https:// at the beginning.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Detection time multiplier that recipient allows the sender to send a message of the maximum allowable connections for the number of packets, used to detect whether the link normal. Value: 3~10.
        /// </summary>
        public readonly int DetectMultiplier;
        /// <summary>
        /// High Speed Migration Service Instance Id.
        /// </summary>
        public readonly string EccId;
        /// <summary>
        /// Whether to Enable IPv6.
        /// </summary>
        public readonly bool EnableIpv6;
        /// <summary>
        /// The ID of the Virtual Border Router.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Alibaba Cloud-Connected IPv4 address.
        /// </summary>
        public readonly string LocalGatewayIp;
        /// <summary>
        /// Alibaba Cloud-Connected IPv6 Address.
        /// </summary>
        public readonly string LocalIpv6GatewayIp;
        /// <summary>
        /// Configure BFD packet reception interval of values include: 200~1000, unit: ms.
        /// </summary>
        public readonly int MinRxInterval;
        /// <summary>
        /// Configure BFD packet transmission interval maximum value: 200~1000, unit: ms.
        /// </summary>
        public readonly int MinTxInterval;
        /// <summary>
        /// The Billing of the Extended Time.
        /// </summary>
        public readonly string PaymentVbrExpireTime;
        /// <summary>
        /// The Client-Side Interconnection IPv4 Address.
        /// </summary>
        public readonly string PeerGatewayIp;
        /// <summary>
        /// The Client-Side Interconnection IPv6 Address.
        /// </summary>
        public readonly string PeerIpv6GatewayIp;
        /// <summary>
        /// Alibaba Cloud-Connected IPv6 with Client-Side Interconnection IPv6 of Subnet Mask.
        /// </summary>
        public readonly string PeeringIpv6SubnetMask;
        /// <summary>
        /// Alibaba Cloud-Connected IPv4 and Client-Side Interconnection IPv4 of Subnet Mask.
        /// </summary>
        public readonly string PeeringSubnetMask;
        /// <summary>
        /// Physical Private Line Service Status Value Normal: Normal, financiallocked: If You Lock.
        /// </summary>
        public readonly string PhysicalConnectionBusinessStatus;
        /// <summary>
        /// The ID of the Physical Connection to Which the ID.
        /// </summary>
        public readonly string PhysicalConnectionId;
        /// <summary>
        /// Physical Private Line Where the Account ID.
        /// </summary>
        public readonly string PhysicalConnectionOwnerUid;
        /// <summary>
        /// Physical Private Line State.
        /// </summary>
        public readonly string PhysicalConnectionStatus;
        /// <summary>
        /// The Last from a Terminated State to the Active State of the Time.
        /// </summary>
        public readonly string RecoveryTime;
        /// <summary>
        /// Route Table ID.
        /// </summary>
        public readonly string RouteTableId;
        /// <summary>
        /// The VBR state.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// The Most Recent Was Aborted by the Time.
        /// </summary>
        public readonly string TerminationTime;
        /// <summary>
        /// VBR Type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The VBR ID.
        /// </summary>
        public readonly string VirtualBorderRouterId;
        /// <summary>
        /// The name of VBR. Length is from 2 to 128 characters, must start with a letter or the Chinese at the beginning can contain numbers, the underscore character (_) and dash (-). But do not start with http:// or https:// at the beginning.
        /// </summary>
        public readonly string VirtualBorderRouterName;
        /// <summary>
        /// The VLAN ID of the VBR. Value range: 0~2999.
        /// </summary>
        public readonly int VlanId;
        /// <summary>
        /// The ID of the Router Interface.
        /// </summary>
        public readonly string VlanInterfaceId;

        [OutputConstructor]
        private GetVirtualBorderRoutersRouterResult(
            string accessPointId,

            string activationTime,

            string circuitCode,

            string cloudBoxInstanceId,

            string createTime,

            string description,

            int detectMultiplier,

            string eccId,

            bool enableIpv6,

            string id,

            string localGatewayIp,

            string localIpv6GatewayIp,

            int minRxInterval,

            int minTxInterval,

            string paymentVbrExpireTime,

            string peerGatewayIp,

            string peerIpv6GatewayIp,

            string peeringIpv6SubnetMask,

            string peeringSubnetMask,

            string physicalConnectionBusinessStatus,

            string physicalConnectionId,

            string physicalConnectionOwnerUid,

            string physicalConnectionStatus,

            string recoveryTime,

            string routeTableId,

            string status,

            string terminationTime,

            string type,

            string virtualBorderRouterId,

            string virtualBorderRouterName,

            int vlanId,

            string vlanInterfaceId)
        {
            AccessPointId = accessPointId;
            ActivationTime = activationTime;
            CircuitCode = circuitCode;
            CloudBoxInstanceId = cloudBoxInstanceId;
            CreateTime = createTime;
            Description = description;
            DetectMultiplier = detectMultiplier;
            EccId = eccId;
            EnableIpv6 = enableIpv6;
            Id = id;
            LocalGatewayIp = localGatewayIp;
            LocalIpv6GatewayIp = localIpv6GatewayIp;
            MinRxInterval = minRxInterval;
            MinTxInterval = minTxInterval;
            PaymentVbrExpireTime = paymentVbrExpireTime;
            PeerGatewayIp = peerGatewayIp;
            PeerIpv6GatewayIp = peerIpv6GatewayIp;
            PeeringIpv6SubnetMask = peeringIpv6SubnetMask;
            PeeringSubnetMask = peeringSubnetMask;
            PhysicalConnectionBusinessStatus = physicalConnectionBusinessStatus;
            PhysicalConnectionId = physicalConnectionId;
            PhysicalConnectionOwnerUid = physicalConnectionOwnerUid;
            PhysicalConnectionStatus = physicalConnectionStatus;
            RecoveryTime = recoveryTime;
            RouteTableId = routeTableId;
            Status = status;
            TerminationTime = terminationTime;
            Type = type;
            VirtualBorderRouterId = virtualBorderRouterId;
            VirtualBorderRouterName = virtualBorderRouterName;
            VlanId = vlanId;
            VlanInterfaceId = vlanInterfaceId;
        }
    }
}