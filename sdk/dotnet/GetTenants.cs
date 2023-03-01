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
    public static class GetTenants
    {
        public static Task<GetTenantsResult> InvokeAsync(GetTenantsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetTenantsResult>("netbox:index/getTenants:getTenants", args ?? new GetTenantsArgs(), options.WithDefaults());

        public static Output<GetTenantsResult> Invoke(GetTenantsInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetTenantsResult>("netbox:index/getTenants:getTenants", args ?? new GetTenantsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTenantsArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetTenantsFilterArgs>? _filters;
        public List<Inputs.GetTenantsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetTenantsFilterArgs>());
            set => _filters = value;
        }

        public GetTenantsArgs()
        {
        }
        public static new GetTenantsArgs Empty => new GetTenantsArgs();
    }

    public sealed class GetTenantsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetTenantsFilterInputArgs>? _filters;
        public InputList<Inputs.GetTenantsFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetTenantsFilterInputArgs>());
            set => _filters = value;
        }

        public GetTenantsInvokeArgs()
        {
        }
        public static new GetTenantsInvokeArgs Empty => new GetTenantsInvokeArgs();
    }


    [OutputType]
    public sealed class GetTenantsResult
    {
        public readonly ImmutableArray<Outputs.GetTenantsFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetTenantsTenantResult> Tenants;

        [OutputConstructor]
        private GetTenantsResult(
            ImmutableArray<Outputs.GetTenantsFilterResult> filters,

            string id,

            ImmutableArray<Outputs.GetTenantsTenantResult> tenants)
        {
            Filters = filters;
            Id = id;
            Tenants = tenants;
        }
    }
}
