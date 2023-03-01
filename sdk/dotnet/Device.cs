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
    /// From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/devices/#devices):
    /// 
    /// &gt; Every piece of hardware which is installed within a site or rack exists in NetBox as a device. Devices are measured in rack units (U) and can be half depth or full depth. A device may have a height of 0U: These devices do not consume vertical rack space and cannot be assigned to a particular rack unit. A common example of a 0U device is a vertically-mounted PDU.
    /// </summary>
    [NetboxResourceType("netbox:index/device:Device")]
    public partial class Device : global::Pulumi.CustomResource
    {
        [Output("comments")]
        public Output<string?> Comments { get; private set; } = null!;

        [Output("deviceTypeId")]
        public Output<int> DeviceTypeId { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("primaryIpv4")]
        public Output<int> PrimaryIpv4 { get; private set; } = null!;

        [Output("roleId")]
        public Output<int?> RoleId { get; private set; } = null!;

        [Output("serial")]
        public Output<string?> Serial { get; private set; } = null!;

        [Output("siteId")]
        public Output<int?> SiteId { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        [Output("tenantId")]
        public Output<int?> TenantId { get; private set; } = null!;


        /// <summary>
        /// Create a Device resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Device(string name, DeviceArgs args, CustomResourceOptions? options = null)
            : base("netbox:index/device:Device", name, args ?? new DeviceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Device(string name, Input<string> id, DeviceState? state = null, CustomResourceOptions? options = null)
            : base("netbox:index/device:Device", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Device resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Device Get(string name, Input<string> id, DeviceState? state = null, CustomResourceOptions? options = null)
        {
            return new Device(name, id, state, options);
        }
    }

    public sealed class DeviceArgs : global::Pulumi.ResourceArgs
    {
        [Input("comments")]
        public Input<string>? Comments { get; set; }

        [Input("deviceTypeId", required: true)]
        public Input<int> DeviceTypeId { get; set; } = null!;

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("roleId")]
        public Input<int>? RoleId { get; set; }

        [Input("serial")]
        public Input<string>? Serial { get; set; }

        [Input("siteId")]
        public Input<int>? SiteId { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("tenantId")]
        public Input<int>? TenantId { get; set; }

        public DeviceArgs()
        {
        }
        public static new DeviceArgs Empty => new DeviceArgs();
    }

    public sealed class DeviceState : global::Pulumi.ResourceArgs
    {
        [Input("comments")]
        public Input<string>? Comments { get; set; }

        [Input("deviceTypeId")]
        public Input<int>? DeviceTypeId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("primaryIpv4")]
        public Input<int>? PrimaryIpv4 { get; set; }

        [Input("roleId")]
        public Input<int>? RoleId { get; set; }

        [Input("serial")]
        public Input<string>? Serial { get; set; }

        [Input("siteId")]
        public Input<int>? SiteId { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("tenantId")]
        public Input<int>? TenantId { get; set; }

        public DeviceState()
        {
        }
        public static new DeviceState Empty => new DeviceState();
    }
}
