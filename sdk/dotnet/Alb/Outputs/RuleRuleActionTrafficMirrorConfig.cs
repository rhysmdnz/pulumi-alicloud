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
    public sealed class RuleRuleActionTrafficMirrorConfig
    {
        /// <summary>
        /// The Traffic is mirrored to the server group. See the following `Block mirror_group_config`.
        /// </summary>
        public readonly Outputs.RuleRuleActionTrafficMirrorConfigMirrorGroupConfig? MirrorGroupConfig;
        /// <summary>
        /// The Mirror target type.
        /// </summary>
        public readonly string? TargetType;

        [OutputConstructor]
        private RuleRuleActionTrafficMirrorConfig(
            Outputs.RuleRuleActionTrafficMirrorConfigMirrorGroupConfig? mirrorGroupConfig,

            string? targetType)
        {
            MirrorGroupConfig = mirrorGroupConfig;
            TargetType = targetType;
        }
    }
}