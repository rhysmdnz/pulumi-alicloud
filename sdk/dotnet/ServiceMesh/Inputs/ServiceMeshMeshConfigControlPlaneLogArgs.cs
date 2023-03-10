// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.ServiceMesh.Inputs
{

    public sealed class ServiceMeshMeshConfigControlPlaneLogArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to enable Service grid audit.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The Service grid audit that to the project.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        public ServiceMeshMeshConfigControlPlaneLogArgs()
        {
        }
        public static new ServiceMeshMeshConfigControlPlaneLogArgs Empty => new ServiceMeshMeshConfigControlPlaneLogArgs();
    }
}
