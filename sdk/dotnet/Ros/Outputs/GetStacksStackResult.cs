// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Ros.Outputs
{

    [OutputType]
    public sealed class GetStacksStackResult
    {
        /// <summary>
        /// Specifies whether to enable deletion protection on the stack.
        /// </summary>
        public readonly string DeletionProtection;
        /// <summary>
        /// The Description of the Stack.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Specifies whether to disable rollback on stack creation failure..
        /// </summary>
        public readonly bool DisableRollback;
        /// <summary>
        /// Drift DetectionTime.
        /// </summary>
        public readonly string DriftDetectionTime;
        /// <summary>
        /// The ID of the Stack.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The parameters.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetStacksStackParameterResult> Parameters;
        /// <summary>
        /// Parent Stack Id.
        /// </summary>
        public readonly string ParentStackId;
        /// <summary>
        /// The RamRoleName.
        /// </summary>
        public readonly string RamRoleName;
        /// <summary>
        /// Root Stack Id.
        /// </summary>
        public readonly string RootStackId;
        /// <summary>
        /// Stack DriftStatus.
        /// </summary>
        public readonly string StackDriftStatus;
        /// <summary>
        /// Stack Id.
        /// </summary>
        public readonly string StackId;
        /// <summary>
        /// Stack Name.
        /// </summary>
        public readonly string StackName;
        /// <summary>
        /// The structure that contains the stack policy body.
        /// </summary>
        public readonly string StackPolicyBody;
        /// <summary>
        /// The status of Stack. Valid Values: `CREATE_COMPLETE`, `CREATE_FAILED`, `CREATE_IN_PROGRESS`, `DELETE_COMPLETE`, `DELETE_FAILED`, `DELETE_IN_PROGRESS`, `ROLLBACK_COMPLETE`, `ROLLBACK_FAILED`, `ROLLBACK_IN_PROGRESS`.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Status Reason.
        /// </summary>
        public readonly string StatusReason;
        /// <summary>
        /// Query the instance bound to the tag. The format of the incoming value is `json` string, including `TagKey` and `TagValue`. `TagKey` cannot be null, and `TagValue` can be empty. Format example `{"key1":"value1"}`.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Tags;
        /// <summary>
        /// Template Description.
        /// </summary>
        public readonly string TemplateDescription;
        /// <summary>
        /// Specifies whether to use the values that were passed last time for the parameters that you do not specify in the current request.
        /// </summary>
        public readonly int TimeoutInMinutes;

        [OutputConstructor]
        private GetStacksStackResult(
            string deletionProtection,

            string description,

            bool disableRollback,

            string driftDetectionTime,

            string id,

            ImmutableArray<Outputs.GetStacksStackParameterResult> parameters,

            string parentStackId,

            string ramRoleName,

            string rootStackId,

            string stackDriftStatus,

            string stackId,

            string stackName,

            string stackPolicyBody,

            string status,

            string statusReason,

            ImmutableDictionary<string, object> tags,

            string templateDescription,

            int timeoutInMinutes)
        {
            DeletionProtection = deletionProtection;
            Description = description;
            DisableRollback = disableRollback;
            DriftDetectionTime = driftDetectionTime;
            Id = id;
            Parameters = parameters;
            ParentStackId = parentStackId;
            RamRoleName = ramRoleName;
            RootStackId = rootStackId;
            StackDriftStatus = stackDriftStatus;
            StackId = stackId;
            StackName = stackName;
            StackPolicyBody = stackPolicyBody;
            Status = status;
            StatusReason = statusReason;
            Tags = tags;
            TemplateDescription = templateDescription;
            TimeoutInMinutes = timeoutInMinutes;
        }
    }
}