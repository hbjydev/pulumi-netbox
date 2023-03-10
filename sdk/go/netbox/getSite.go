// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package netbox

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/hbjydev/pulumi-netbox/sdk/go/netbox"
//	"github.com/pulumi/pulumi-netbox/sdk/go/netbox"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := netbox.LookupSite(ctx, &GetSiteArgs{
//				Name: pulumi.StringRef("Example Site 1"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			_, err = netbox.LookupSite(ctx, &GetSiteArgs{
//				Slug: pulumi.StringRef("example-site-1"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupSite(ctx *pulumi.Context, args *LookupSiteArgs, opts ...pulumi.InvokeOption) (*LookupSiteResult, error) {
	var rv LookupSiteResult
	err := ctx.Invoke("netbox:index/getSite:getSite", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSite.
type LookupSiteArgs struct {
	Name *string `pulumi:"name"`
	Slug *string `pulumi:"slug"`
}

// A collection of values returned by getSite.
type LookupSiteResult struct {
	Asn         int    `pulumi:"asn"`
	Comments    string `pulumi:"comments"`
	Description string `pulumi:"description"`
	GroupId     int    `pulumi:"groupId"`
	// The provider-assigned unique ID for this managed resource.
	Id       string  `pulumi:"id"`
	Name     *string `pulumi:"name"`
	RegionId int     `pulumi:"regionId"`
	SiteId   int     `pulumi:"siteId"`
	Slug     *string `pulumi:"slug"`
	Status   string  `pulumi:"status"`
	TenantId int     `pulumi:"tenantId"`
	TimeZone string  `pulumi:"timeZone"`
}

func LookupSiteOutput(ctx *pulumi.Context, args LookupSiteOutputArgs, opts ...pulumi.InvokeOption) LookupSiteResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupSiteResult, error) {
			args := v.(LookupSiteArgs)
			r, err := LookupSite(ctx, &args, opts...)
			var s LookupSiteResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupSiteResultOutput)
}

// A collection of arguments for invoking getSite.
type LookupSiteOutputArgs struct {
	Name pulumi.StringPtrInput `pulumi:"name"`
	Slug pulumi.StringPtrInput `pulumi:"slug"`
}

func (LookupSiteOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupSiteArgs)(nil)).Elem()
}

// A collection of values returned by getSite.
type LookupSiteResultOutput struct{ *pulumi.OutputState }

func (LookupSiteResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupSiteResult)(nil)).Elem()
}

func (o LookupSiteResultOutput) ToLookupSiteResultOutput() LookupSiteResultOutput {
	return o
}

func (o LookupSiteResultOutput) ToLookupSiteResultOutputWithContext(ctx context.Context) LookupSiteResultOutput {
	return o
}

func (o LookupSiteResultOutput) Asn() pulumi.IntOutput {
	return o.ApplyT(func(v LookupSiteResult) int { return v.Asn }).(pulumi.IntOutput)
}

func (o LookupSiteResultOutput) Comments() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSiteResult) string { return v.Comments }).(pulumi.StringOutput)
}

func (o LookupSiteResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSiteResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupSiteResultOutput) GroupId() pulumi.IntOutput {
	return o.ApplyT(func(v LookupSiteResult) int { return v.GroupId }).(pulumi.IntOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupSiteResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSiteResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupSiteResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupSiteResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func (o LookupSiteResultOutput) RegionId() pulumi.IntOutput {
	return o.ApplyT(func(v LookupSiteResult) int { return v.RegionId }).(pulumi.IntOutput)
}

func (o LookupSiteResultOutput) SiteId() pulumi.IntOutput {
	return o.ApplyT(func(v LookupSiteResult) int { return v.SiteId }).(pulumi.IntOutput)
}

func (o LookupSiteResultOutput) Slug() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupSiteResult) *string { return v.Slug }).(pulumi.StringPtrOutput)
}

func (o LookupSiteResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSiteResult) string { return v.Status }).(pulumi.StringOutput)
}

func (o LookupSiteResultOutput) TenantId() pulumi.IntOutput {
	return o.ApplyT(func(v LookupSiteResult) int { return v.TenantId }).(pulumi.IntOutput)
}

func (o LookupSiteResultOutput) TimeZone() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSiteResult) string { return v.TimeZone }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupSiteResultOutput{})
}
