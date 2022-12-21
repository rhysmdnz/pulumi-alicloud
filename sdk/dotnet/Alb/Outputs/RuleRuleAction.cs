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
    public sealed class RuleRuleAction
    {
        /// <summary>
        /// The configuration of the fixed response. See the following `Block fixed_response_config`.
        /// </summary>
        public readonly Outputs.RuleRuleActionFixedResponseConfig? FixedResponseConfig;
        /// <summary>
        /// The forward response action within ALB. See the following `Block forward_group_config`.
        /// </summary>
        public readonly Outputs.RuleRuleActionForwardGroupConfig? ForwardGroupConfig;
        /// <summary>
        /// The configuration of the inserted header field. See the following `Block insert_header_config`.
        /// </summary>
        public readonly Outputs.RuleRuleActionInsertHeaderConfig? InsertHeaderConfig;
        /// <summary>
        /// The order of the forwarding rule actions. Valid values: 1 to 50000. The actions are performed in ascending order. You cannot leave this parameter empty. Each value must be unique.
        /// </summary>
        public readonly int Order;
        /// <summary>
        /// The configuration of the external redirect action. See the following `Block redirect_config`.
        /// </summary>
        public readonly Outputs.RuleRuleActionRedirectConfig? RedirectConfig;
        /// <summary>
        /// The redirect action within ALB. See the following `Block rewrite_config`.
        /// </summary>
        public readonly Outputs.RuleRuleActionRewriteConfig? RewriteConfig;
        /// <summary>
        /// The Flow speed limit. See the following `Block traffic_limit_config`.
        /// </summary>
        public readonly Outputs.RuleRuleActionTrafficLimitConfig? TrafficLimitConfig;
        /// <summary>
        /// The Traffic mirroring. See the following `Block traffic_mirror_config`.
        /// </summary>
        public readonly Outputs.RuleRuleActionTrafficMirrorConfig? TrafficMirrorConfig;
        /// <summary>
        /// The action. Valid values: `ForwardGroup`, `Redirect`, `FixedResponse`, `Rewrite`, `InsertHeader`, `TrafficLimit` and `TrafficMirror`. **Note:**  The preceding actions can be classified into two types:  `FinalType`: A forwarding rule can contain only one `FinalType` action, which is executed last. This type of action can contain only one `ForwardGroup`, `Redirect` or `FixedResponse` action. `ExtType`: A forwarding rule can contain one or more `ExtType` actions, which are executed before `FinalType` actions and need to coexist with the `FinalType` actions. This type of action can contain multiple `InsertHeader` actions or one `Rewrite` action. **NOTE:** The `TrafficLimit` and `TrafficMirror` option is available in 1.162.0+.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private RuleRuleAction(
            Outputs.RuleRuleActionFixedResponseConfig? fixedResponseConfig,

            Outputs.RuleRuleActionForwardGroupConfig? forwardGroupConfig,

            Outputs.RuleRuleActionInsertHeaderConfig? insertHeaderConfig,

            int order,

            Outputs.RuleRuleActionRedirectConfig? redirectConfig,

            Outputs.RuleRuleActionRewriteConfig? rewriteConfig,

            Outputs.RuleRuleActionTrafficLimitConfig? trafficLimitConfig,

            Outputs.RuleRuleActionTrafficMirrorConfig? trafficMirrorConfig,

            string type)
        {
            FixedResponseConfig = fixedResponseConfig;
            ForwardGroupConfig = forwardGroupConfig;
            InsertHeaderConfig = insertHeaderConfig;
            Order = order;
            RedirectConfig = redirectConfig;
            RewriteConfig = rewriteConfig;
            TrafficLimitConfig = trafficLimitConfig;
            TrafficMirrorConfig = trafficMirrorConfig;
            Type = type;
        }
    }
}