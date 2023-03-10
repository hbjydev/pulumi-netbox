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
    public static class GetPrefix
    {
        public static Task<GetPrefixResult> InvokeAsync(GetPrefixArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPrefixResult>("netbox:index/getPrefix:getPrefix", args ?? new GetPrefixArgs(), options.WithDefaults());

        public static Output<GetPrefixResult> Invoke(GetPrefixInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetPrefixResult>("netbox:index/getPrefix:getPrefix", args ?? new GetPrefixInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPrefixArgs : global::Pulumi.InvokeArgs
    {
        [Input("cidr", required: true)]
        public string Cidr { get; set; } = null!;

        public GetPrefixArgs()
        {
        }
        public static new GetPrefixArgs Empty => new GetPrefixArgs();
    }

    public sealed class GetPrefixInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("cidr", required: true)]
        public Input<string> Cidr { get; set; } = null!;

        public GetPrefixInvokeArgs()
        {
        }
        public static new GetPrefixInvokeArgs Empty => new GetPrefixInvokeArgs();
    }


    [OutputType]
    public sealed class GetPrefixResult
    {
        public readonly string Cidr;
        /// <summary>
        /// The ID of this resource.
        /// </summary>
        public readonly int Id;

        [OutputConstructor]
        private GetPrefixResult(
            string cidr,

            int id)
        {
            Cidr = cidr;
            Id = id;
        }
    }
}
