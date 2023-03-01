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
    public sealed class GetTenantsTenantTenantGroupResult
    {
        /// <summary>
        /// The ID of this resource.
        /// </summary>
        public readonly int Id;
        public readonly string Name;
        public readonly string Slug;
        public readonly int TenantCount;

        [OutputConstructor]
        private GetTenantsTenantTenantGroupResult(
            int id,

            string name,

            string slug,

            int tenantCount)
        {
            Id = id;
            Name = name;
            Slug = slug;
            TenantCount = tenantCount;
        }
    }
}
