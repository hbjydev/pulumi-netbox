// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace HBJYDev.Netbox
{
    [NetboxResourceType("netbox:index/interface:Interface")]
    public partial class Interface : global::Pulumi.CustomResource
    {
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        [Output("macAddress")]
        public Output<string?> MacAddress { get; private set; } = null!;

        [Output("mode")]
        public Output<string?> Mode { get; private set; } = null!;

        [Output("mtu")]
        public Output<int?> Mtu { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("taggedVlans")]
        public Output<ImmutableArray<int>> TaggedVlans { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;

        [Output("untaggedVlan")]
        public Output<int?> UntaggedVlan { get; private set; } = null!;

        [Output("virtualMachineId")]
        public Output<int> VirtualMachineId { get; private set; } = null!;


        /// <summary>
        /// Create a Interface resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Interface(string name, InterfaceArgs args, CustomResourceOptions? options = null)
            : base("netbox:index/interface:Interface", name, args ?? new InterfaceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Interface(string name, Input<string> id, InterfaceState? state = null, CustomResourceOptions? options = null)
            : base("netbox:index/interface:Interface", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Interface resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Interface Get(string name, Input<string> id, InterfaceState? state = null, CustomResourceOptions? options = null)
        {
            return new Interface(name, id, state, options);
        }
    }

    public sealed class InterfaceArgs : global::Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("macAddress")]
        public Input<string>? MacAddress { get; set; }

        [Input("mode")]
        public Input<string>? Mode { get; set; }

        [Input("mtu")]
        public Input<int>? Mtu { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("taggedVlans")]
        private InputList<int>? _taggedVlans;
        public InputList<int> TaggedVlans
        {
            get => _taggedVlans ?? (_taggedVlans = new InputList<int>());
            set => _taggedVlans = value;
        }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("untaggedVlan")]
        public Input<int>? UntaggedVlan { get; set; }

        [Input("virtualMachineId", required: true)]
        public Input<int> VirtualMachineId { get; set; } = null!;

        public InterfaceArgs()
        {
        }
        public static new InterfaceArgs Empty => new InterfaceArgs();
    }

    public sealed class InterfaceState : global::Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("macAddress")]
        public Input<string>? MacAddress { get; set; }

        [Input("mode")]
        public Input<string>? Mode { get; set; }

        [Input("mtu")]
        public Input<int>? Mtu { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("taggedVlans")]
        private InputList<int>? _taggedVlans;
        public InputList<int> TaggedVlans
        {
            get => _taggedVlans ?? (_taggedVlans = new InputList<int>());
            set => _taggedVlans = value;
        }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("untaggedVlan")]
        public Input<int>? UntaggedVlan { get; set; }

        [Input("virtualMachineId")]
        public Input<int>? VirtualMachineId { get; set; }

        public InterfaceState()
        {
        }
        public static new InterfaceState Empty => new InterfaceState();
    }
}