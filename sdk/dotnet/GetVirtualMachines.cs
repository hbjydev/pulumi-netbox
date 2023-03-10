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
    public static class GetVirtualMachines
    {
        /// <summary>
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Netbox = Pulumi.Netbox;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var vmwCluster01 = Netbox.GetCluster.Invoke(new()
        ///     {
        ///         Name = "vmw-cluster-01",
        ///     });
        /// 
        ///     var baseVm = Netbox.GetVirtualMachines.Invoke(new()
        ///     {
        ///         NameRegex = "myvm-1",
        ///         Filters = new[]
        ///         {
        ///             new Netbox.Inputs.GetVirtualMachinesFilterInputArgs
        ///             {
        ///                 Name = "cluster_id",
        ///                 Value = vmwCluster01.Apply(getClusterResult =&gt; getClusterResult.Id),
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetVirtualMachinesResult> InvokeAsync(GetVirtualMachinesArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualMachinesResult>("netbox:index/getVirtualMachines:getVirtualMachines", args ?? new GetVirtualMachinesArgs(), options.WithDefaults());

        /// <summary>
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Netbox = Pulumi.Netbox;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var vmwCluster01 = Netbox.GetCluster.Invoke(new()
        ///     {
        ///         Name = "vmw-cluster-01",
        ///     });
        /// 
        ///     var baseVm = Netbox.GetVirtualMachines.Invoke(new()
        ///     {
        ///         NameRegex = "myvm-1",
        ///         Filters = new[]
        ///         {
        ///             new Netbox.Inputs.GetVirtualMachinesFilterInputArgs
        ///             {
        ///                 Name = "cluster_id",
        ///                 Value = vmwCluster01.Apply(getClusterResult =&gt; getClusterResult.Id),
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetVirtualMachinesResult> Invoke(GetVirtualMachinesInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetVirtualMachinesResult>("netbox:index/getVirtualMachines:getVirtualMachines", args ?? new GetVirtualMachinesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVirtualMachinesArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetVirtualMachinesFilterArgs>? _filters;
        public List<Inputs.GetVirtualMachinesFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetVirtualMachinesFilterArgs>());
            set => _filters = value;
        }

        [Input("limit")]
        public int? Limit { get; set; }

        [Input("nameRegex")]
        public string? NameRegex { get; set; }

        public GetVirtualMachinesArgs()
        {
        }
        public static new GetVirtualMachinesArgs Empty => new GetVirtualMachinesArgs();
    }

    public sealed class GetVirtualMachinesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetVirtualMachinesFilterInputArgs>? _filters;
        public InputList<Inputs.GetVirtualMachinesFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetVirtualMachinesFilterInputArgs>());
            set => _filters = value;
        }

        [Input("limit")]
        public Input<int>? Limit { get; set; }

        [Input("nameRegex")]
        public Input<string>? NameRegex { get; set; }

        public GetVirtualMachinesInvokeArgs()
        {
        }
        public static new GetVirtualMachinesInvokeArgs Empty => new GetVirtualMachinesInvokeArgs();
    }


    [OutputType]
    public sealed class GetVirtualMachinesResult
    {
        public readonly ImmutableArray<Outputs.GetVirtualMachinesFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int? Limit;
        public readonly string? NameRegex;
        public readonly ImmutableArray<Outputs.GetVirtualMachinesVmResult> Vms;

        [OutputConstructor]
        private GetVirtualMachinesResult(
            ImmutableArray<Outputs.GetVirtualMachinesFilterResult> filters,

            string id,

            int? limit,

            string? nameRegex,

            ImmutableArray<Outputs.GetVirtualMachinesVmResult> vms)
        {
            Filters = filters;
            Id = id;
            Limit = limit;
            NameRegex = nameRegex;
            Vms = vms;
        }
    }
}
