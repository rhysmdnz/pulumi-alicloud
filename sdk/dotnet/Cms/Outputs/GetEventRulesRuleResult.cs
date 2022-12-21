// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Cms.Outputs
{

    [OutputType]
    public sealed class GetEventRulesRuleResult
    {
        /// <summary>
        /// The description of the rule.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Event mode, used to describe the trigger conditions for this event.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetEventRulesRuleEventPatternResult> EventPatterns;
        /// <summary>
        /// The name of the event rule.
        /// </summary>
        public readonly string EventRuleName;
        /// <summary>
        /// The type of event.
        /// </summary>
        public readonly string EventType;
        /// <summary>
        /// The ID of the application Group.
        /// </summary>
        public readonly string GroupId;
        /// <summary>
        /// The ID of the Event Rule. Its value is same as Event Rule Name.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The mute period during which new alerts are not sent even if the trigger conditions are met.
        /// </summary>
        public readonly int SilenceTime;
        /// <summary>
        /// The status of the resource.
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private GetEventRulesRuleResult(
            string description,

            ImmutableArray<Outputs.GetEventRulesRuleEventPatternResult> eventPatterns,

            string eventRuleName,

            string eventType,

            string groupId,

            string id,

            int silenceTime,

            string status)
        {
            Description = description;
            EventPatterns = eventPatterns;
            EventRuleName = eventRuleName;
            EventType = eventType;
            GroupId = groupId;
            Id = id;
            SilenceTime = silenceTime;
            Status = status;
        }
    }
}