// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Cdn.Outputs
{

    [OutputType]
    public sealed class DomainParameterFilterConfig
    {
        public readonly string? Enable;
        public readonly ImmutableArray<string> HashKeyArgs;

        [OutputConstructor]
        private DomainParameterFilterConfig(
            string? enable,

            ImmutableArray<string> hashKeyArgs)
        {
            Enable = enable;
            HashKeyArgs = hashKeyArgs;
        }
    }
}