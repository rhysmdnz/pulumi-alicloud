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
    public sealed class GetRulesRuleRuleActionResult
    {
        /// <summary>
        /// The configuration of the fixed response.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRulesRuleRuleActionFixedResponseConfigResult> FixedResponseConfigs;
        /// <summary>
        /// The configurations of the destination server groups.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRulesRuleRuleActionForwardGroupConfigResult> ForwardGroupConfigs;
        /// <summary>
        /// The configuration of the inserted header field.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRulesRuleRuleActionInsertHeaderConfigResult> InsertHeaderConfigs;
        /// <summary>
        /// The order of the forwarding rule actions. Valid values:1 to 50000. The actions are performed in ascending order. You cannot leave this parameter empty. Each value must be unique.
        /// </summary>
        public readonly int Order;
        /// <summary>
        /// The configuration of the external redirect action.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRulesRuleRuleActionRedirectConfigResult> RedirectConfigs;
        /// <summary>
        /// The redirect action within ALB.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRulesRuleRuleActionRewriteConfigResult> RewriteConfigs;
        /// <summary>
        /// The Flow speed limit.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRulesRuleRuleActionTrafficLimitConfigResult> TrafficLimitConfigs;
        /// <summary>
        /// The Traffic mirroring.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRulesRuleRuleActionTrafficMirrorConfigResult> TrafficMirrorConfigs;
        /// <summary>
        /// The type of the forwarding rule.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetRulesRuleRuleActionResult(
            ImmutableArray<Outputs.GetRulesRuleRuleActionFixedResponseConfigResult> fixedResponseConfigs,

            ImmutableArray<Outputs.GetRulesRuleRuleActionForwardGroupConfigResult> forwardGroupConfigs,

            ImmutableArray<Outputs.GetRulesRuleRuleActionInsertHeaderConfigResult> insertHeaderConfigs,

            int order,

            ImmutableArray<Outputs.GetRulesRuleRuleActionRedirectConfigResult> redirectConfigs,

            ImmutableArray<Outputs.GetRulesRuleRuleActionRewriteConfigResult> rewriteConfigs,

            ImmutableArray<Outputs.GetRulesRuleRuleActionTrafficLimitConfigResult> trafficLimitConfigs,

            ImmutableArray<Outputs.GetRulesRuleRuleActionTrafficMirrorConfigResult> trafficMirrorConfigs,

            string type)
        {
            FixedResponseConfigs = fixedResponseConfigs;
            ForwardGroupConfigs = forwardGroupConfigs;
            InsertHeaderConfigs = insertHeaderConfigs;
            Order = order;
            RedirectConfigs = redirectConfigs;
            RewriteConfigs = rewriteConfigs;
            TrafficLimitConfigs = trafficLimitConfigs;
            TrafficMirrorConfigs = trafficMirrorConfigs;
            Type = type;
        }
    }
}