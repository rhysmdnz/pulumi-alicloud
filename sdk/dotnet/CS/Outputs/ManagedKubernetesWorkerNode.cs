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
    public sealed class ManagedKubernetesWorkerNode
    {
        /// <summary>
        /// (Deprecated from version 1.177.0) ID of the node.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The kubernetes cluster's name. It is unique in one Alicloud account.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// (Deprecated from version 1.177.0) The private IP address of node.
        /// </summary>
        public readonly string? PrivateIp;

        [OutputConstructor]
        private ManagedKubernetesWorkerNode(
            string? id,

            string? name,

            string? privateIp)
        {
            Id = id;
            Name = name;
            PrivateIp = privateIp;
        }
    }
}
