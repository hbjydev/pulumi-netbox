// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace HBJYDev.Netbox.Outputs
{

    [OutputType]
    public sealed class GetInterfacesInterfaceResult
    {
        public readonly string Description;
        public readonly bool Enabled;
        public readonly string MacAddress;
        public readonly ImmutableDictionary<string, string> Mode;
        public readonly int Mtu;
        public readonly string Name;
        public readonly ImmutableArray<int> TagIds;
        public readonly ImmutableArray<Outputs.GetInterfacesInterfaceTaggedVlanResult> TaggedVlans;
        public readonly ImmutableArray<Outputs.GetInterfacesInterfaceUntaggedVlanResult> UntaggedVlans;
        public readonly int VmId;

        [OutputConstructor]
        private GetInterfacesInterfaceResult(
            string description,

            bool enabled,

            string macAddress,

            ImmutableDictionary<string, string> mode,

            int mtu,

            string name,

            ImmutableArray<int> tagIds,

            ImmutableArray<Outputs.GetInterfacesInterfaceTaggedVlanResult> taggedVlans,

            ImmutableArray<Outputs.GetInterfacesInterfaceUntaggedVlanResult> untaggedVlans,

            int vmId)
        {
            Description = description;
            Enabled = enabled;
            MacAddress = macAddress;
            Mode = mode;
            Mtu = mtu;
            Name = name;
            TagIds = tagIds;
            TaggedVlans = taggedVlans;
            UntaggedVlans = untaggedVlans;
            VmId = vmId;
        }
    }
}
