// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Ros.Inputs
{

    public sealed class StackInstanceParameterOverrideGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key of override parameter. If you do not specify the key and value of the parameter, ROS uses the key and value that you specified when you created the stack group.
        /// </summary>
        [Input("parameterKey")]
        public Input<string>? ParameterKey { get; set; }

        /// <summary>
        /// The value of override parameter. If you do not specify the key and value of the parameter, ROS uses the key and value that you specified when you created the stack group.
        /// </summary>
        [Input("parameterValue")]
        public Input<string>? ParameterValue { get; set; }

        public StackInstanceParameterOverrideGetArgs()
        {
        }
        public static new StackInstanceParameterOverrideGetArgs Empty => new StackInstanceParameterOverrideGetArgs();
    }
}
