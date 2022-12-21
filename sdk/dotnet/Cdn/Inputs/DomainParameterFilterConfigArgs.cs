// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Cdn.Inputs
{

    public sealed class DomainParameterFilterConfigArgs : global::Pulumi.ResourceArgs
    {
        [Input("enable")]
        public Input<string>? Enable { get; set; }

        [Input("hashKeyArgs")]
        private InputList<string>? _hashKeyArgs;
        public InputList<string> HashKeyArgs
        {
            get => _hashKeyArgs ?? (_hashKeyArgs = new InputList<string>());
            set => _hashKeyArgs = value;
        }

        public DomainParameterFilterConfigArgs()
        {
        }
        public static new DomainParameterFilterConfigArgs Empty => new DomainParameterFilterConfigArgs();
    }
}