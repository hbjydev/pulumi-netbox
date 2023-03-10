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
    [NetboxResourceType("netbox:index/deviceType:DeviceType")]
    public partial class DeviceType : global::Pulumi.CustomResource
    {
        [Output("manufacturerId")]
        public Output<int?> ManufacturerId { get; private set; } = null!;

        [Output("model")]
        public Output<string> Model { get; private set; } = null!;

        [Output("partNumber")]
        public Output<string?> PartNumber { get; private set; } = null!;

        [Output("slug")]
        public Output<string> Slug { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a DeviceType resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DeviceType(string name, DeviceTypeArgs args, CustomResourceOptions? options = null)
            : base("netbox:index/deviceType:DeviceType", name, args ?? new DeviceTypeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DeviceType(string name, Input<string> id, DeviceTypeState? state = null, CustomResourceOptions? options = null)
            : base("netbox:index/deviceType:DeviceType", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DeviceType resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DeviceType Get(string name, Input<string> id, DeviceTypeState? state = null, CustomResourceOptions? options = null)
        {
            return new DeviceType(name, id, state, options);
        }
    }

    public sealed class DeviceTypeArgs : global::Pulumi.ResourceArgs
    {
        [Input("manufacturerId")]
        public Input<int>? ManufacturerId { get; set; }

        [Input("model", required: true)]
        public Input<string> Model { get; set; } = null!;

        [Input("partNumber")]
        public Input<string>? PartNumber { get; set; }

        [Input("slug")]
        public Input<string>? Slug { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        public DeviceTypeArgs()
        {
        }
        public static new DeviceTypeArgs Empty => new DeviceTypeArgs();
    }

    public sealed class DeviceTypeState : global::Pulumi.ResourceArgs
    {
        [Input("manufacturerId")]
        public Input<int>? ManufacturerId { get; set; }

        [Input("model")]
        public Input<string>? Model { get; set; }

        [Input("partNumber")]
        public Input<string>? PartNumber { get; set; }

        [Input("slug")]
        public Input<string>? Slug { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        public DeviceTypeState()
        {
        }
        public static new DeviceTypeState Empty => new DeviceTypeState();
    }
}
