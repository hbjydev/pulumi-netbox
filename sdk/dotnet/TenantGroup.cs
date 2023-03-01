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
    [NetboxResourceType("netbox:index/tenantGroup:TenantGroup")]
    public partial class TenantGroup : global::Pulumi.CustomResource
    {
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("parentId")]
        public Output<int?> ParentId { get; private set; } = null!;

        [Output("slug")]
        public Output<string> Slug { get; private set; } = null!;


        /// <summary>
        /// Create a TenantGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TenantGroup(string name, TenantGroupArgs? args = null, CustomResourceOptions? options = null)
            : base("netbox:index/tenantGroup:TenantGroup", name, args ?? new TenantGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TenantGroup(string name, Input<string> id, TenantGroupState? state = null, CustomResourceOptions? options = null)
            : base("netbox:index/tenantGroup:TenantGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing TenantGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TenantGroup Get(string name, Input<string> id, TenantGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new TenantGroup(name, id, state, options);
        }
    }

    public sealed class TenantGroupArgs : global::Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parentId")]
        public Input<int>? ParentId { get; set; }

        [Input("slug")]
        public Input<string>? Slug { get; set; }

        public TenantGroupArgs()
        {
        }
        public static new TenantGroupArgs Empty => new TenantGroupArgs();
    }

    public sealed class TenantGroupState : global::Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parentId")]
        public Input<int>? ParentId { get; set; }

        [Input("slug")]
        public Input<string>? Slug { get; set; }

        public TenantGroupState()
        {
        }
        public static new TenantGroupState Empty => new TenantGroupState();
    }
}