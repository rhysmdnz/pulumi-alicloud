// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.PolarDB.Outputs
{

    [OutputType]
    public sealed class ClusterDbClusterIpArray
    {
        /// <summary>
        /// The name of the IP whitelist group. The group name must be 2 to 120 characters in length and consists of lowercase letters and digits. It must start with a letter, and end with a letter or a digit.
        /// **NOTE:** If the specified whitelist group name does not exist, the whitelist group is created. If the specified whitelist group name exists, the whitelist group is modified. If you do not specify this parameter, the default group is modified. You can create a maximum of 50 IP whitelist groups for a cluster.
        /// </summary>
        public readonly string? DbClusterIpArrayName;
        /// <summary>
        /// The method for modifying the IP whitelist. Valid values are `Cover`, `Append`, `Delete`.
        /// **NOTE:** There does not recommend setting modify_mode to `Append` or `Delete` and it will bring a potential diff error.
        /// </summary>
        public readonly string? ModifyMode;
        /// <summary>
        /// List of IP addresses allowed to access all databases of a cluster. The list contains up to 1,000 IP addresses, separated by commas. Supported formats include 0.0.0.0/0, 10.23.12.24 (IP), and 10.23.12.24/24 (Classless Inter-Domain Routing (CIDR) mode. /24 represents the length of the prefix in an IP address. The range of the prefix length is [1,32]).
        /// </summary>
        public readonly ImmutableArray<string> SecurityIps;

        [OutputConstructor]
        private ClusterDbClusterIpArray(
            string? dbClusterIpArrayName,

            string? modifyMode,

            ImmutableArray<string> securityIps)
        {
            DbClusterIpArrayName = dbClusterIpArrayName;
            ModifyMode = modifyMode;
            SecurityIps = securityIps;
        }
    }
}