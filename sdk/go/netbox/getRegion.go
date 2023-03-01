// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package netbox

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupRegion(ctx *pulumi.Context, args *LookupRegionArgs, opts ...pulumi.InvokeOption) (*LookupRegionResult, error) {
	var rv LookupRegionResult
	err := ctx.Invoke("netbox:index/getRegion:getRegion", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRegion.
type LookupRegionArgs struct {
	Filters []GetRegionFilter `pulumi:"filters"`
}

// A collection of values returned by getRegion.
type LookupRegionResult struct {
	Description string            `pulumi:"description"`
	Filters     []GetRegionFilter `pulumi:"filters"`
	// The ID of this resource.
	Id             int    `pulumi:"id"`
	Name           string `pulumi:"name"`
	ParentRegionId int    `pulumi:"parentRegionId"`
	Slug           string `pulumi:"slug"`
}

func LookupRegionOutput(ctx *pulumi.Context, args LookupRegionOutputArgs, opts ...pulumi.InvokeOption) LookupRegionResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupRegionResult, error) {
			args := v.(LookupRegionArgs)
			r, err := LookupRegion(ctx, &args, opts...)
			var s LookupRegionResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupRegionResultOutput)
}

// A collection of arguments for invoking getRegion.
type LookupRegionOutputArgs struct {
	Filters GetRegionFilterArrayInput `pulumi:"filters"`
}

func (LookupRegionOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRegionArgs)(nil)).Elem()
}

// A collection of values returned by getRegion.
type LookupRegionResultOutput struct{ *pulumi.OutputState }

func (LookupRegionResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRegionResult)(nil)).Elem()
}

func (o LookupRegionResultOutput) ToLookupRegionResultOutput() LookupRegionResultOutput {
	return o
}

func (o LookupRegionResultOutput) ToLookupRegionResultOutputWithContext(ctx context.Context) LookupRegionResultOutput {
	return o
}

func (o LookupRegionResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRegionResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupRegionResultOutput) Filters() GetRegionFilterArrayOutput {
	return o.ApplyT(func(v LookupRegionResult) []GetRegionFilter { return v.Filters }).(GetRegionFilterArrayOutput)
}

// The ID of this resource.
func (o LookupRegionResultOutput) Id() pulumi.IntOutput {
	return o.ApplyT(func(v LookupRegionResult) int { return v.Id }).(pulumi.IntOutput)
}

func (o LookupRegionResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRegionResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupRegionResultOutput) ParentRegionId() pulumi.IntOutput {
	return o.ApplyT(func(v LookupRegionResult) int { return v.ParentRegionId }).(pulumi.IntOutput)
}

func (o LookupRegionResultOutput) Slug() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRegionResult) string { return v.Slug }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupRegionResultOutput{})
}
