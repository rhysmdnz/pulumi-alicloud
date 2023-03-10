// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.ResourceManager.Outputs
{

    [OutputType]
    public sealed class GetPolicyVersionsVersionResult
    {
        /// <summary>
        /// The ID of the resource, the value is `&lt;policy_name&gt;`:`&lt;version_id&gt;`.
        /// * `version_id`- The ID of the policy version.
        /// * `create_date`- (Removed form v1.114.0)The time when the policy version was created.
        /// * `is_default_version`- Indicates whether the policy version is the default version.
        /// * `policy_document`- (Available in v1.114.0+) The policy document of the policy version.
        /// </summary>
        public readonly string Id;
        public readonly bool IsDefaultVersion;
        public readonly string PolicyDocument;
        public readonly string VersionId;

        [OutputConstructor]
        private GetPolicyVersionsVersionResult(
            string id,

            bool isDefaultVersion,

            string policyDocument,

            string versionId)
        {
            Id = id;
            IsDefaultVersion = isDefaultVersion;
            PolicyDocument = policyDocument;
            VersionId = versionId;
        }
    }
}
