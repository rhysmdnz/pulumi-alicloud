// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.ApiGateway.Outputs
{

    [OutputType]
    public sealed class ApiConstantParameter
    {
        /// <summary>
        /// The description of Constant parameter.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// System parameter location; values: 'HEAD' and 'QUERY'.
        /// </summary>
        public readonly string In;
        /// <summary>
        /// System parameter name which supports values including in [system parameter list](https://www.alibabacloud.com/help/doc-detail/43677.html).
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Constant parameter value.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private ApiConstantParameter(
            string? description,

            string @in,

            string name,

            string value)
        {
            Description = description;
            In = @in;
            Name = name;
            Value = value;
        }
    }
}