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
    /// From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/virtualization/#clusters):
    /// 
    /// &gt; A cluster is a logical grouping of physical resources within which virtual machines run. A cluster must be assigned a type (technological classification), and may optionally be assigned to a cluster group, site, and/or tenant. Each cluster must have a unique name within its assigned group and/or site, if any.
    /// &gt; 
    /// &gt; Physical devices may be associated with clusters as hosts. This allows users to track on which host(s) a particular virtual machine may reside. However, NetBox does not support pinning a specific VM within a cluster to a particular host device.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Netbox = HBJYDev.Netbox;
    /// using Netbox = Pulumi.Netbox;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var dcWest = Netbox.GetClusterGroup.Invoke(new()
    ///     {
    ///         Name = "dc-west",
    ///     });
    /// 
    ///     var vmwVsphere = new Netbox.ClusterType("vmwVsphere");
    /// 
    ///     var vmwCluster01 = new Netbox.Cluster("vmwCluster01", new()
    ///     {
    ///         ClusterTypeId = vmwVsphere.Id,
    ///         ClusterGroupId = dcWest.Apply(getClusterGroupResult =&gt; getClusterGroupResult.Id),
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [NetboxResourceType("netbox:index/cluster:Cluster")]
    public partial class Cluster : global::Pulumi.CustomResource
    {
        [Output("clusterGroupId")]
        public Output<int?> ClusterGroupId { get; private set; } = null!;

        [Output("clusterTypeId")]
        public Output<int> ClusterTypeId { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("siteId")]
        public Output<int?> SiteId { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Cluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Cluster(string name, ClusterArgs args, CustomResourceOptions? options = null)
            : base("netbox:index/cluster:Cluster", name, args ?? new ClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Cluster(string name, Input<string> id, ClusterState? state = null, CustomResourceOptions? options = null)
            : base("netbox:index/cluster:Cluster", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Cluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Cluster Get(string name, Input<string> id, ClusterState? state = null, CustomResourceOptions? options = null)
        {
            return new Cluster(name, id, state, options);
        }
    }

    public sealed class ClusterArgs : global::Pulumi.ResourceArgs
    {
        [Input("clusterGroupId")]
        public Input<int>? ClusterGroupId { get; set; }

        [Input("clusterTypeId", required: true)]
        public Input<int> ClusterTypeId { get; set; } = null!;

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("siteId")]
        public Input<int>? SiteId { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        public ClusterArgs()
        {
        }
        public static new ClusterArgs Empty => new ClusterArgs();
    }

    public sealed class ClusterState : global::Pulumi.ResourceArgs
    {
        [Input("clusterGroupId")]
        public Input<int>? ClusterGroupId { get; set; }

        [Input("clusterTypeId")]
        public Input<int>? ClusterTypeId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("siteId")]
        public Input<int>? SiteId { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        public ClusterState()
        {
        }
        public static new ClusterState Empty => new ClusterState();
    }
}
