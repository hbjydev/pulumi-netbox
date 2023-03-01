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
    /// From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/ipam/#ip-addresses):
    /// 
    /// &gt; An IP address comprises a single host address (either IPv4 or IPv6) and its subnet mask. Its mask should match exactly how the IP address is configured on an interface in the real world.
    /// &gt; 
    /// &gt; Like a prefix, an IP address can optionally be assigned to a VRF (otherwise, it will appear in the "global" table). IP addresses are automatically arranged under parent prefixes within their respective VRFs according to the IP hierarchy.
    /// </summary>
    [NetboxResourceType("netbox:index/ipAddress:IpAddress")]
    public partial class IpAddress : global::Pulumi.CustomResource
    {
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("dnsName")]
        public Output<string?> DnsName { get; private set; } = null!;

        [Output("interfaceId")]
        public Output<int?> InterfaceId { get; private set; } = null!;

        [Output("ipAddress")]
        public Output<string> IpAddressOutput { get; private set; } = null!;

        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        [Output("tenantId")]
        public Output<int?> TenantId { get; private set; } = null!;

        [Output("vrfId")]
        public Output<int?> VrfId { get; private set; } = null!;


        /// <summary>
        /// Create a IpAddress resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IpAddress(string name, IpAddressArgs args, CustomResourceOptions? options = null)
            : base("netbox:index/ipAddress:IpAddress", name, args ?? new IpAddressArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IpAddress(string name, Input<string> id, IpAddressState? state = null, CustomResourceOptions? options = null)
            : base("netbox:index/ipAddress:IpAddress", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IpAddress resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IpAddress Get(string name, Input<string> id, IpAddressState? state = null, CustomResourceOptions? options = null)
        {
            return new IpAddress(name, id, state, options);
        }
    }

    public sealed class IpAddressArgs : global::Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("dnsName")]
        public Input<string>? DnsName { get; set; }

        [Input("interfaceId")]
        public Input<int>? InterfaceId { get; set; }

        [Input("ipAddress", required: true)]
        public Input<string> IpAddressOutput { get; set; } = null!;

        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("tenantId")]
        public Input<int>? TenantId { get; set; }

        [Input("vrfId")]
        public Input<int>? VrfId { get; set; }

        public IpAddressArgs()
        {
        }
        public static new IpAddressArgs Empty => new IpAddressArgs();
    }

    public sealed class IpAddressState : global::Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("dnsName")]
        public Input<string>? DnsName { get; set; }

        [Input("interfaceId")]
        public Input<int>? InterfaceId { get; set; }

        [Input("ipAddress")]
        public Input<string>? IpAddressOutput { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("tenantId")]
        public Input<int>? TenantId { get; set; }

        [Input("vrfId")]
        public Input<int>? VrfId { get; set; }

        public IpAddressState()
        {
        }
        public static new IpAddressState Empty => new IpAddressState();
    }
}
