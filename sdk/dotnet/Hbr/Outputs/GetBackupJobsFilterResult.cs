// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Hbr.Outputs
{

    [OutputType]
    public sealed class GetBackupJobsFilterResult
    {
        /// <summary>
        /// The key of the field to filter. Valid values: `PlanId`, `VaultId`, `InstanceId`, `Bucket`, `FileSystemId`, `CompleteTime`.
        /// </summary>
        public readonly string? Key;
        /// <summary>
        /// The operator of the field to filter. Valid values: `EQUAL`, `NOT_EQUAL`, `GREATER_THAN`, `GREATER_THAN_OR_EQUAL`, `LESS_THAN`, `LESS_THAN_OR_EQUAL`, `BETWEEN`, `IN`.
        /// </summary>
        public readonly string? Operator;
        /// <summary>
        /// Set of values that are accepted for the given field.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private GetBackupJobsFilterResult(
            string? key,

            string? @operator,

            ImmutableArray<string> values)
        {
            Key = key;
            Operator = @operator;
            Values = values;
        }
    }
}