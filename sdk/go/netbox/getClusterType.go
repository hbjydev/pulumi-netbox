// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package netbox

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupClusterType(ctx *pulumi.Context, args *LookupClusterTypeArgs, opts ...pulumi.InvokeOption) (*LookupClusterTypeResult, error) {
	var rv LookupClusterTypeResult
	err := ctx.Invoke("netbox:index/getClusterType:getClusterType", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getClusterType.
type LookupClusterTypeArgs struct {
	Name string `pulumi:"name"`
}

// A collection of values returned by getClusterType.
type LookupClusterTypeResult struct {
	ClusterTypeId int `pulumi:"clusterTypeId"`
	// The provider-assigned unique ID for this managed resource.
	Id   string `pulumi:"id"`
	Name string `pulumi:"name"`
}

func LookupClusterTypeOutput(ctx *pulumi.Context, args LookupClusterTypeOutputArgs, opts ...pulumi.InvokeOption) LookupClusterTypeResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupClusterTypeResult, error) {
			args := v.(LookupClusterTypeArgs)
			r, err := LookupClusterType(ctx, &args, opts...)
			var s LookupClusterTypeResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupClusterTypeResultOutput)
}

// A collection of arguments for invoking getClusterType.
type LookupClusterTypeOutputArgs struct {
	Name pulumi.StringInput `pulumi:"name"`
}

func (LookupClusterTypeOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupClusterTypeArgs)(nil)).Elem()
}

// A collection of values returned by getClusterType.
type LookupClusterTypeResultOutput struct{ *pulumi.OutputState }

func (LookupClusterTypeResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupClusterTypeResult)(nil)).Elem()
}

func (o LookupClusterTypeResultOutput) ToLookupClusterTypeResultOutput() LookupClusterTypeResultOutput {
	return o
}

func (o LookupClusterTypeResultOutput) ToLookupClusterTypeResultOutputWithContext(ctx context.Context) LookupClusterTypeResultOutput {
	return o
}

func (o LookupClusterTypeResultOutput) ClusterTypeId() pulumi.IntOutput {
	return o.ApplyT(func(v LookupClusterTypeResult) int { return v.ClusterTypeId }).(pulumi.IntOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupClusterTypeResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterTypeResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupClusterTypeResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterTypeResult) string { return v.Name }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupClusterTypeResultOutput{})
}
