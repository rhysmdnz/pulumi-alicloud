// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Alb.Inputs
{

    public sealed class RuleRuleActionFixedResponseConfigGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The fixed response. The response cannot exceed 1 KB in size and can contain only ASCII characters.
        /// </summary>
        [Input("content", required: true)]
        public Input<string> Content { get; set; } = null!;

        /// <summary>
        /// The format of the fixed response.  Valid values: `text/plain`, `text/css`, `text/html`, `application/javascript`, and `application/json`.
        /// </summary>
        [Input("contentType")]
        public Input<string>? ContentType { get; set; }

        /// <summary>
        /// The HTTP status code of the response. The code must be an `HTTP_2xx`, `HTTP_4xx` or `HTTP_5xx.x` is a digit.
        /// </summary>
        [Input("httpCode")]
        public Input<string>? HttpCode { get; set; }

        public RuleRuleActionFixedResponseConfigGetArgs()
        {
        }
        public static new RuleRuleActionFixedResponseConfigGetArgs Empty => new RuleRuleActionFixedResponseConfigGetArgs();
    }
}
