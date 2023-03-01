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
    /// From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/circuits/#circuit-terminations):
    /// 
    /// &gt; The association of a circuit with a particular site and/or device is modeled separately as a circuit termination. A circuit may have up to two terminations, labeled A and Z. A single-termination circuit can be used when you don't know (or care) about the far end of a circuit (for example, an Internet access circuit which connects to a transit provider). A dual-termination circuit is useful for tracking circuits which connect two sites.
    /// &gt; 
    /// &gt; Each circuit termination is attached to either a site or to a provider network. Site terminations may optionally be connected via a cable to a specific device interface or port within that site. Each termination must be assigned a port speed, and can optionally be assigned an upstream speed if it differs from the downstream speed (a common scenario with e.g. DOCSIS cable modems). Fields are also available to track cross-connect and patch panel details.
    /// </summary>
    [NetboxResourceType("netbox:index/circuitTermination:CircuitTermination")]
    public partial class CircuitTermination : global::Pulumi.CustomResource
    {
        [Output("circuitId")]
        public Output<int> CircuitId { get; private set; } = null!;

        [Output("portSpeed")]
        public Output<int?> PortSpeed { get; private set; } = null!;

        [Output("siteId")]
        public Output<int> SiteId { get; private set; } = null!;

        [Output("termSide")]
        public Output<string> TermSide { get; private set; } = null!;

        [Output("upstreamSpeed")]
        public Output<int?> UpstreamSpeed { get; private set; } = null!;


        /// <summary>
        /// Create a CircuitTermination resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CircuitTermination(string name, CircuitTerminationArgs args, CustomResourceOptions? options = null)
            : base("netbox:index/circuitTermination:CircuitTermination", name, args ?? new CircuitTerminationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CircuitTermination(string name, Input<string> id, CircuitTerminationState? state = null, CustomResourceOptions? options = null)
            : base("netbox:index/circuitTermination:CircuitTermination", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CircuitTermination resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CircuitTermination Get(string name, Input<string> id, CircuitTerminationState? state = null, CustomResourceOptions? options = null)
        {
            return new CircuitTermination(name, id, state, options);
        }
    }

    public sealed class CircuitTerminationArgs : global::Pulumi.ResourceArgs
    {
        [Input("circuitId", required: true)]
        public Input<int> CircuitId { get; set; } = null!;

        [Input("portSpeed")]
        public Input<int>? PortSpeed { get; set; }

        [Input("siteId", required: true)]
        public Input<int> SiteId { get; set; } = null!;

        [Input("termSide", required: true)]
        public Input<string> TermSide { get; set; } = null!;

        [Input("upstreamSpeed")]
        public Input<int>? UpstreamSpeed { get; set; }

        public CircuitTerminationArgs()
        {
        }
        public static new CircuitTerminationArgs Empty => new CircuitTerminationArgs();
    }

    public sealed class CircuitTerminationState : global::Pulumi.ResourceArgs
    {
        [Input("circuitId")]
        public Input<int>? CircuitId { get; set; }

        [Input("portSpeed")]
        public Input<int>? PortSpeed { get; set; }

        [Input("siteId")]
        public Input<int>? SiteId { get; set; }

        [Input("termSide")]
        public Input<string>? TermSide { get; set; }

        [Input("upstreamSpeed")]
        public Input<int>? UpstreamSpeed { get; set; }

        public CircuitTerminationState()
        {
        }
        public static new CircuitTerminationState Empty => new CircuitTerminationState();
    }
}
