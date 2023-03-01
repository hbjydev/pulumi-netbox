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
    /// From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/ipam/#aggregates):
    /// 
    /// &gt; NetBox allows us to specify the portions of IP space that are interesting to us by defining aggregates. Typically, an aggregate will correspond to either an allocation of public (globally routable) IP space granted by a regional authority, or a private (internally-routable) designation.
    /// </summary>
    [NetboxResourceType("netbox:index/aggregate:Aggregate")]
    public partial class Aggregate : global::Pulumi.CustomResource
    {
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("prefix")]
        public Output<string> Prefix { get; private set; } = null!;

        [Output("rirId")]
        public Output<int?> RirId { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        [Output("tenantId")]
        public Output<int?> TenantId { get; private set; } = null!;


        /// <summary>
        /// Create a Aggregate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Aggregate(string name, AggregateArgs args, CustomResourceOptions? options = null)
            : base("netbox:index/aggregate:Aggregate", name, args ?? new AggregateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Aggregate(string name, Input<string> id, AggregateState? state = null, CustomResourceOptions? options = null)
            : base("netbox:index/aggregate:Aggregate", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Aggregate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Aggregate Get(string name, Input<string> id, AggregateState? state = null, CustomResourceOptions? options = null)
        {
            return new Aggregate(name, id, state, options);
        }
    }

    public sealed class AggregateArgs : global::Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("prefix", required: true)]
        public Input<string> Prefix { get; set; } = null!;

        [Input("rirId")]
        public Input<int>? RirId { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("tenantId")]
        public Input<int>? TenantId { get; set; }

        public AggregateArgs()
        {
        }
        public static new AggregateArgs Empty => new AggregateArgs();
    }

    public sealed class AggregateState : global::Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        [Input("rirId")]
        public Input<int>? RirId { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("tenantId")]
        public Input<int>? TenantId { get; set; }

        public AggregateState()
        {
        }
        public static new AggregateState Empty => new AggregateState();
    }
}