// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package netbox

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetIpAddresses(ctx *pulumi.Context, args *GetIpAddressesArgs, opts ...pulumi.InvokeOption) (*GetIpAddressesResult, error) {
	var rv GetIpAddressesResult
	err := ctx.Invoke("netbox:index/getIpAddresses:getIpAddresses", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getIpAddresses.
type GetIpAddressesArgs struct {
	Filters []GetIpAddressesFilter `pulumi:"filters"`
}

// A collection of values returned by getIpAddresses.
type GetIpAddressesResult struct {
	Filters []GetIpAddressesFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id          string                    `pulumi:"id"`
	IpAddresses []GetIpAddressesIpAddress `pulumi:"ipAddresses"`
}

func GetIpAddressesOutput(ctx *pulumi.Context, args GetIpAddressesOutputArgs, opts ...pulumi.InvokeOption) GetIpAddressesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetIpAddressesResult, error) {
			args := v.(GetIpAddressesArgs)
			r, err := GetIpAddresses(ctx, &args, opts...)
			var s GetIpAddressesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetIpAddressesResultOutput)
}

// A collection of arguments for invoking getIpAddresses.
type GetIpAddressesOutputArgs struct {
	Filters GetIpAddressesFilterArrayInput `pulumi:"filters"`
}

func (GetIpAddressesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetIpAddressesArgs)(nil)).Elem()
}

// A collection of values returned by getIpAddresses.
type GetIpAddressesResultOutput struct{ *pulumi.OutputState }

func (GetIpAddressesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetIpAddressesResult)(nil)).Elem()
}

func (o GetIpAddressesResultOutput) ToGetIpAddressesResultOutput() GetIpAddressesResultOutput {
	return o
}

func (o GetIpAddressesResultOutput) ToGetIpAddressesResultOutputWithContext(ctx context.Context) GetIpAddressesResultOutput {
	return o
}

func (o GetIpAddressesResultOutput) Filters() GetIpAddressesFilterArrayOutput {
	return o.ApplyT(func(v GetIpAddressesResult) []GetIpAddressesFilter { return v.Filters }).(GetIpAddressesFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetIpAddressesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetIpAddressesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetIpAddressesResultOutput) IpAddresses() GetIpAddressesIpAddressArrayOutput {
	return o.ApplyT(func(v GetIpAddressesResult) []GetIpAddressesIpAddress { return v.IpAddresses }).(GetIpAddressesIpAddressArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetIpAddressesResultOutput{})
}
