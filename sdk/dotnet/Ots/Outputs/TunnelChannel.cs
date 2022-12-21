// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Ots.Outputs
{

    [OutputType]
    public sealed class TunnelChannel
    {
        /// <summary>
        /// The id of the channel.
        /// </summary>
        public readonly string? ChannelId;
        /// <summary>
        /// The latest consumption time of the channel, unix time in nanosecond.
        /// </summary>
        public readonly int? ChannelRpo;
        /// <summary>
        /// The status of the channel, valid values: `WAIT`, `OPEN`, `CLOSING`, `CLOSE`, `TERMINATED`.
        /// </summary>
        public readonly string? ChannelStatus;
        /// <summary>
        /// The type of the channel, valid values: `BaseData`, `Stream`.
        /// </summary>
        public readonly string? ChannelType;
        /// <summary>
        /// The client id of the channel.
        /// </summary>
        public readonly string? ClientId;

        [OutputConstructor]
        private TunnelChannel(
            string? channelId,

            int? channelRpo,

            string? channelStatus,

            string? channelType,

            string? clientId)
        {
            ChannelId = channelId;
            ChannelRpo = channelRpo;
            ChannelStatus = channelStatus;
            ChannelType = channelType;
            ClientId = clientId;
        }
    }
}