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
    public static class GetSite
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
        ///     var getByName = Netbox.GetSite.Invoke(new()
        ///     {
        ///         Name = "Example Site 1",
        ///     });
        /// 
        ///     var getBySlug = Netbox.GetSite.Invoke(new()
        ///     {
        ///         Slug = "example-site-1",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetSiteResult> InvokeAsync(GetSiteArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSiteResult>("netbox:index/getSite:getSite", args ?? new GetSiteArgs(), options.WithDefaults());

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
        ///     var getByName = Netbox.GetSite.Invoke(new()
        ///     {
        ///         Name = "Example Site 1",
        ///     });
        /// 
        ///     var getBySlug = Netbox.GetSite.Invoke(new()
        ///     {
        ///         Slug = "example-site-1",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetSiteResult> Invoke(GetSiteInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSiteResult>("netbox:index/getSite:getSite", args ?? new GetSiteInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSiteArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public string? Name { get; set; }

        [Input("slug")]
        public string? Slug { get; set; }

        public GetSiteArgs()
        {
        }
        public static new GetSiteArgs Empty => new GetSiteArgs();
    }

    public sealed class GetSiteInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("slug")]
        public Input<string>? Slug { get; set; }

        public GetSiteInvokeArgs()
        {
        }
        public static new GetSiteInvokeArgs Empty => new GetSiteInvokeArgs();
    }


    [OutputType]
    public sealed class GetSiteResult
    {
        public readonly int Asn;
        public readonly string Comments;
        public readonly string Description;
        public readonly int GroupId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Name;
        public readonly int RegionId;
        public readonly int SiteId;
        public readonly string? Slug;
        public readonly string Status;
        public readonly int TenantId;
        public readonly string TimeZone;

        [OutputConstructor]
        private GetSiteResult(
            int asn,

            string comments,

            string description,

            int groupId,

            string id,

            string? name,

            int regionId,

            int siteId,

            string? slug,

            string status,

            int tenantId,

            string timeZone)
        {
            Asn = asn;
            Comments = comments;
            Description = description;
            GroupId = groupId;
            Id = id;
            Name = name;
            RegionId = regionId;
            SiteId = siteId;
            Slug = slug;
            Status = status;
            TenantId = tenantId;
            TimeZone = timeZone;
        }
    }
}