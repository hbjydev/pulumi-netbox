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
    public sealed class GetVirtualMachinesFilterResult
    {
        public readonly string Name;
        public readonly string Value;

        [OutputConstructor]
        private GetVirtualMachinesFilterResult(
            string name,

            string value)
        {
            Name = name;
            Value = value;
        }
    }
}
