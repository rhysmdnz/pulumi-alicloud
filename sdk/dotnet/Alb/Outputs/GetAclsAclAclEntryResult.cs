// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Alb.Outputs
{

    [OutputType]
    public sealed class GetAclsAclAclEntryResult
    {
        /// <summary>
        /// Access Control Entries Note Description Length Is Limited to 1 to 256 Characters, Letters, digital, the Dash (-), a Forward Slash (/), Half a Period (.) and Underscores (_), Support Chinese Characters.
        /// </summary>
        public readonly string Description;
        public readonly string Entry;
        /// <summary>
        /// The state of the ACL. Valid values:`Provisioning` , `Available` and `Configuring`. `Provisioning`: The ACL is being created. `Available`: The ACL is available. `Configuring`: The ACL is being configured.
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private GetAclsAclAclEntryResult(
            string description,

            string entry,

            string status)
        {
            Description = description;
            Entry = entry;
            Status = status;
        }
    }
}