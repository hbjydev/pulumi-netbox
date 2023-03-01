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
    /// <summary>
    /// From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/circuits/#circuit-types):
    /// 
    /// &gt; Circuits are classified by functional type. These types are completely customizable, and are typically used to convey the type of service being delivered over a circuit.
    /// </summary>
    [NetboxResourceType("netbox:index/circuitType:CircuitType")]
    public partial class CircuitType : global::Pulumi.CustomResource
    {
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("slug")]
        public Output<string> Slug { get; private set; } = null!;


        /// <summary>
        /// Create a CircuitType resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CircuitType(string name, CircuitTypeArgs? args = null, CustomResourceOptions? options = null)
            : base("netbox:index/circuitType:CircuitType", name, args ?? new CircuitTypeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CircuitType(string name, Input<string> id, CircuitTypeState? state = null, CustomResourceOptions? options = null)
            : base("netbox:index/circuitType:CircuitType", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CircuitType resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CircuitType Get(string name, Input<string> id, CircuitTypeState? state = null, CustomResourceOptions? options = null)
        {
            return new CircuitType(name, id, state, options);
        }
    }

    public sealed class CircuitTypeArgs : global::Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("slug")]
        public Input<string>? Slug { get; set; }

        public CircuitTypeArgs()
        {
        }
        public static new CircuitTypeArgs Empty => new CircuitTypeArgs();
    }

    public sealed class CircuitTypeState : global::Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("slug")]
        public Input<string>? Slug { get; set; }

        public CircuitTypeState()
        {
        }
        public static new CircuitTypeState Empty => new CircuitTypeState();
    }
}