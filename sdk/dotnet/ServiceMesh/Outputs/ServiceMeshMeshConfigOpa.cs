// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.ServiceMesh.Outputs
{

    [OutputType]
    public sealed class ServiceMeshMeshConfigOpa
    {
        /// <summary>
        /// Whether to enable Service grid audit.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// The CPU resource  of the limitsOPA proxy container.
        /// </summary>
        public readonly string? LimitCpu;
        /// <summary>
        /// The memory resource limit of the OPA proxy container.
        /// </summary>
        public readonly string? LimitMemory;
        /// <summary>
        /// The log level of the OPA proxy container .
        /// </summary>
        public readonly string? LogLevel;
        /// <summary>
        /// The CPU resource request of the OPA proxy container.
        /// </summary>
        public readonly string? RequestCpu;
        /// <summary>
        /// The memory resource request of the OPA proxy container.
        /// </summary>
        public readonly string? RequestMemory;

        [OutputConstructor]
        private ServiceMeshMeshConfigOpa(
            bool? enabled,

            string? limitCpu,

            string? limitMemory,

            string? logLevel,

            string? requestCpu,

            string? requestMemory)
        {
            Enabled = enabled;
            LimitCpu = limitCpu;
            LimitMemory = limitMemory;
            LogLevel = logLevel;
            RequestCpu = requestCpu;
            RequestMemory = requestMemory;
        }
    }
}
