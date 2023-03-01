// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package netbox

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetInterfaces(ctx *pulumi.Context, args *GetInterfacesArgs, opts ...pulumi.InvokeOption) (*GetInterfacesResult, error) {
	var rv GetInterfacesResult
	err := ctx.Invoke("netbox:index/getInterfaces:getInterfaces", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getInterfaces.
type GetInterfacesArgs struct {
	Filters   []GetInterfacesFilter `pulumi:"filters"`
	NameRegex *string               `pulumi:"nameRegex"`
}

// A collection of values returned by getInterfaces.
type GetInterfacesResult struct {
	Filters []GetInterfacesFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id         string                   `pulumi:"id"`
	Interfaces []GetInterfacesInterface `pulumi:"interfaces"`
	NameRegex  *string                  `pulumi:"nameRegex"`
}

func GetInterfacesOutput(ctx *pulumi.Context, args GetInterfacesOutputArgs, opts ...pulumi.InvokeOption) GetInterfacesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetInterfacesResult, error) {
			args := v.(GetInterfacesArgs)
			r, err := GetInterfaces(ctx, &args, opts...)
			var s GetInterfacesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetInterfacesResultOutput)
}

// A collection of arguments for invoking getInterfaces.
type GetInterfacesOutputArgs struct {
	Filters   GetInterfacesFilterArrayInput `pulumi:"filters"`
	NameRegex pulumi.StringPtrInput         `pulumi:"nameRegex"`
}

func (GetInterfacesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInterfacesArgs)(nil)).Elem()
}

// A collection of values returned by getInterfaces.
type GetInterfacesResultOutput struct{ *pulumi.OutputState }

func (GetInterfacesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInterfacesResult)(nil)).Elem()
}

func (o GetInterfacesResultOutput) ToGetInterfacesResultOutput() GetInterfacesResultOutput {
	return o
}

func (o GetInterfacesResultOutput) ToGetInterfacesResultOutputWithContext(ctx context.Context) GetInterfacesResultOutput {
	return o
}

func (o GetInterfacesResultOutput) Filters() GetInterfacesFilterArrayOutput {
	return o.ApplyT(func(v GetInterfacesResult) []GetInterfacesFilter { return v.Filters }).(GetInterfacesFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetInterfacesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetInterfacesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetInterfacesResultOutput) Interfaces() GetInterfacesInterfaceArrayOutput {
	return o.ApplyT(func(v GetInterfacesResult) []GetInterfacesInterface { return v.Interfaces }).(GetInterfacesInterfaceArrayOutput)
}

func (o GetInterfacesResultOutput) NameRegex() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetInterfacesResult) *string { return v.NameRegex }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetInterfacesResultOutput{})
}
