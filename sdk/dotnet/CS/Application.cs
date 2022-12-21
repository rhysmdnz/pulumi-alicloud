// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.CS
{
    [AliCloudResourceType("alicloud:cs/application:Application")]
    public partial class Application : global::Pulumi.CustomResource
    {
        [Output("blueGreen")]
        public Output<bool?> BlueGreen { get; private set; } = null!;

        [Output("blueGreenConfirm")]
        public Output<bool?> BlueGreenConfirm { get; private set; } = null!;

        [Output("clusterName")]
        public Output<string> ClusterName { get; private set; } = null!;

        [Output("defaultDomain")]
        public Output<string> DefaultDomain { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("environment")]
        public Output<ImmutableDictionary<string, object>?> Environment { get; private set; } = null!;

        [Output("latestImage")]
        public Output<bool?> LatestImage { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("services")]
        public Output<ImmutableArray<Outputs.ApplicationService>> Services { get; private set; } = null!;

        [Output("template")]
        public Output<string> Template { get; private set; } = null!;

        [Output("version")]
        public Output<string?> Version { get; private set; } = null!;


        /// <summary>
        /// Create a Application resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Application(string name, ApplicationArgs args, CustomResourceOptions? options = null)
            : base("alicloud:cs/application:Application", name, args ?? new ApplicationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Application(string name, Input<string> id, ApplicationState? state = null, CustomResourceOptions? options = null)
            : base("alicloud:cs/application:Application", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/rhysmdnz/pulumi-alicloud",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Application resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Application Get(string name, Input<string> id, ApplicationState? state = null, CustomResourceOptions? options = null)
        {
            return new Application(name, id, state, options);
        }
    }

    public sealed class ApplicationArgs : global::Pulumi.ResourceArgs
    {
        [Input("blueGreen")]
        public Input<bool>? BlueGreen { get; set; }

        [Input("blueGreenConfirm")]
        public Input<bool>? BlueGreenConfirm { get; set; }

        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("environment")]
        private InputMap<object>? _environment;
        public InputMap<object> Environment
        {
            get => _environment ?? (_environment = new InputMap<object>());
            set => _environment = value;
        }

        [Input("latestImage")]
        public Input<bool>? LatestImage { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("template", required: true)]
        public Input<string> Template { get; set; } = null!;

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ApplicationArgs()
        {
        }
        public static new ApplicationArgs Empty => new ApplicationArgs();
    }

    public sealed class ApplicationState : global::Pulumi.ResourceArgs
    {
        [Input("blueGreen")]
        public Input<bool>? BlueGreen { get; set; }

        [Input("blueGreenConfirm")]
        public Input<bool>? BlueGreenConfirm { get; set; }

        [Input("clusterName")]
        public Input<string>? ClusterName { get; set; }

        [Input("defaultDomain")]
        public Input<string>? DefaultDomain { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("environment")]
        private InputMap<object>? _environment;
        public InputMap<object> Environment
        {
            get => _environment ?? (_environment = new InputMap<object>());
            set => _environment = value;
        }

        [Input("latestImage")]
        public Input<bool>? LatestImage { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("services")]
        private InputList<Inputs.ApplicationServiceGetArgs>? _services;
        public InputList<Inputs.ApplicationServiceGetArgs> Services
        {
            get => _services ?? (_services = new InputList<Inputs.ApplicationServiceGetArgs>());
            set => _services = value;
        }

        [Input("template")]
        public Input<string>? Template { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ApplicationState()
        {
        }
        public static new ApplicationState Empty => new ApplicationState();
    }
}