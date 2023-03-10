// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package netbox

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type VirtualMachine struct {
	pulumi.CustomResourceState

	ClusterId    pulumi.IntOutput         `pulumi:"clusterId"`
	Comments     pulumi.StringPtrOutput   `pulumi:"comments"`
	CustomFields pulumi.StringMapOutput   `pulumi:"customFields"`
	DiskSizeGb   pulumi.IntPtrOutput      `pulumi:"diskSizeGb"`
	MemoryMb     pulumi.IntPtrOutput      `pulumi:"memoryMb"`
	Name         pulumi.StringOutput      `pulumi:"name"`
	PlatformId   pulumi.IntPtrOutput      `pulumi:"platformId"`
	PrimaryIpv4  pulumi.IntOutput         `pulumi:"primaryIpv4"`
	RoleId       pulumi.IntPtrOutput      `pulumi:"roleId"`
	SiteId       pulumi.IntOutput         `pulumi:"siteId"`
	Tags         pulumi.StringArrayOutput `pulumi:"tags"`
	TenantId     pulumi.IntPtrOutput      `pulumi:"tenantId"`
	Vcpus        pulumi.Float64PtrOutput  `pulumi:"vcpus"`
}

// NewVirtualMachine registers a new resource with the given unique name, arguments, and options.
func NewVirtualMachine(ctx *pulumi.Context,
	name string, args *VirtualMachineArgs, opts ...pulumi.ResourceOption) (*VirtualMachine, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClusterId == nil {
		return nil, errors.New("invalid value for required argument 'ClusterId'")
	}
	var resource VirtualMachine
	err := ctx.RegisterResource("netbox:index/virtualMachine:VirtualMachine", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualMachine gets an existing VirtualMachine resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualMachine(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualMachineState, opts ...pulumi.ResourceOption) (*VirtualMachine, error) {
	var resource VirtualMachine
	err := ctx.ReadResource("netbox:index/virtualMachine:VirtualMachine", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualMachine resources.
type virtualMachineState struct {
	ClusterId    *int              `pulumi:"clusterId"`
	Comments     *string           `pulumi:"comments"`
	CustomFields map[string]string `pulumi:"customFields"`
	DiskSizeGb   *int              `pulumi:"diskSizeGb"`
	MemoryMb     *int              `pulumi:"memoryMb"`
	Name         *string           `pulumi:"name"`
	PlatformId   *int              `pulumi:"platformId"`
	PrimaryIpv4  *int              `pulumi:"primaryIpv4"`
	RoleId       *int              `pulumi:"roleId"`
	SiteId       *int              `pulumi:"siteId"`
	Tags         []string          `pulumi:"tags"`
	TenantId     *int              `pulumi:"tenantId"`
	Vcpus        *float64          `pulumi:"vcpus"`
}

type VirtualMachineState struct {
	ClusterId    pulumi.IntPtrInput
	Comments     pulumi.StringPtrInput
	CustomFields pulumi.StringMapInput
	DiskSizeGb   pulumi.IntPtrInput
	MemoryMb     pulumi.IntPtrInput
	Name         pulumi.StringPtrInput
	PlatformId   pulumi.IntPtrInput
	PrimaryIpv4  pulumi.IntPtrInput
	RoleId       pulumi.IntPtrInput
	SiteId       pulumi.IntPtrInput
	Tags         pulumi.StringArrayInput
	TenantId     pulumi.IntPtrInput
	Vcpus        pulumi.Float64PtrInput
}

func (VirtualMachineState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualMachineState)(nil)).Elem()
}

type virtualMachineArgs struct {
	ClusterId    int               `pulumi:"clusterId"`
	Comments     *string           `pulumi:"comments"`
	CustomFields map[string]string `pulumi:"customFields"`
	DiskSizeGb   *int              `pulumi:"diskSizeGb"`
	MemoryMb     *int              `pulumi:"memoryMb"`
	Name         *string           `pulumi:"name"`
	PlatformId   *int              `pulumi:"platformId"`
	RoleId       *int              `pulumi:"roleId"`
	Tags         []string          `pulumi:"tags"`
	TenantId     *int              `pulumi:"tenantId"`
	Vcpus        *float64          `pulumi:"vcpus"`
}

// The set of arguments for constructing a VirtualMachine resource.
type VirtualMachineArgs struct {
	ClusterId    pulumi.IntInput
	Comments     pulumi.StringPtrInput
	CustomFields pulumi.StringMapInput
	DiskSizeGb   pulumi.IntPtrInput
	MemoryMb     pulumi.IntPtrInput
	Name         pulumi.StringPtrInput
	PlatformId   pulumi.IntPtrInput
	RoleId       pulumi.IntPtrInput
	Tags         pulumi.StringArrayInput
	TenantId     pulumi.IntPtrInput
	Vcpus        pulumi.Float64PtrInput
}

func (VirtualMachineArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualMachineArgs)(nil)).Elem()
}

type VirtualMachineInput interface {
	pulumi.Input

	ToVirtualMachineOutput() VirtualMachineOutput
	ToVirtualMachineOutputWithContext(ctx context.Context) VirtualMachineOutput
}

func (*VirtualMachine) ElementType() reflect.Type {
	return reflect.TypeOf((**VirtualMachine)(nil)).Elem()
}

func (i *VirtualMachine) ToVirtualMachineOutput() VirtualMachineOutput {
	return i.ToVirtualMachineOutputWithContext(context.Background())
}

func (i *VirtualMachine) ToVirtualMachineOutputWithContext(ctx context.Context) VirtualMachineOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualMachineOutput)
}

// VirtualMachineArrayInput is an input type that accepts VirtualMachineArray and VirtualMachineArrayOutput values.
// You can construct a concrete instance of `VirtualMachineArrayInput` via:
//
//	VirtualMachineArray{ VirtualMachineArgs{...} }
type VirtualMachineArrayInput interface {
	pulumi.Input

	ToVirtualMachineArrayOutput() VirtualMachineArrayOutput
	ToVirtualMachineArrayOutputWithContext(context.Context) VirtualMachineArrayOutput
}

type VirtualMachineArray []VirtualMachineInput

func (VirtualMachineArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*VirtualMachine)(nil)).Elem()
}

func (i VirtualMachineArray) ToVirtualMachineArrayOutput() VirtualMachineArrayOutput {
	return i.ToVirtualMachineArrayOutputWithContext(context.Background())
}

func (i VirtualMachineArray) ToVirtualMachineArrayOutputWithContext(ctx context.Context) VirtualMachineArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualMachineArrayOutput)
}

// VirtualMachineMapInput is an input type that accepts VirtualMachineMap and VirtualMachineMapOutput values.
// You can construct a concrete instance of `VirtualMachineMapInput` via:
//
//	VirtualMachineMap{ "key": VirtualMachineArgs{...} }
type VirtualMachineMapInput interface {
	pulumi.Input

	ToVirtualMachineMapOutput() VirtualMachineMapOutput
	ToVirtualMachineMapOutputWithContext(context.Context) VirtualMachineMapOutput
}

type VirtualMachineMap map[string]VirtualMachineInput

func (VirtualMachineMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*VirtualMachine)(nil)).Elem()
}

func (i VirtualMachineMap) ToVirtualMachineMapOutput() VirtualMachineMapOutput {
	return i.ToVirtualMachineMapOutputWithContext(context.Background())
}

func (i VirtualMachineMap) ToVirtualMachineMapOutputWithContext(ctx context.Context) VirtualMachineMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualMachineMapOutput)
}

type VirtualMachineOutput struct{ *pulumi.OutputState }

func (VirtualMachineOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**VirtualMachine)(nil)).Elem()
}

func (o VirtualMachineOutput) ToVirtualMachineOutput() VirtualMachineOutput {
	return o
}

func (o VirtualMachineOutput) ToVirtualMachineOutputWithContext(ctx context.Context) VirtualMachineOutput {
	return o
}

func (o VirtualMachineOutput) ClusterId() pulumi.IntOutput {
	return o.ApplyT(func(v *VirtualMachine) pulumi.IntOutput { return v.ClusterId }).(pulumi.IntOutput)
}

func (o VirtualMachineOutput) Comments() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *VirtualMachine) pulumi.StringPtrOutput { return v.Comments }).(pulumi.StringPtrOutput)
}

func (o VirtualMachineOutput) CustomFields() pulumi.StringMapOutput {
	return o.ApplyT(func(v *VirtualMachine) pulumi.StringMapOutput { return v.CustomFields }).(pulumi.StringMapOutput)
}

func (o VirtualMachineOutput) DiskSizeGb() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *VirtualMachine) pulumi.IntPtrOutput { return v.DiskSizeGb }).(pulumi.IntPtrOutput)
}

func (o VirtualMachineOutput) MemoryMb() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *VirtualMachine) pulumi.IntPtrOutput { return v.MemoryMb }).(pulumi.IntPtrOutput)
}

func (o VirtualMachineOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *VirtualMachine) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o VirtualMachineOutput) PlatformId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *VirtualMachine) pulumi.IntPtrOutput { return v.PlatformId }).(pulumi.IntPtrOutput)
}

func (o VirtualMachineOutput) PrimaryIpv4() pulumi.IntOutput {
	return o.ApplyT(func(v *VirtualMachine) pulumi.IntOutput { return v.PrimaryIpv4 }).(pulumi.IntOutput)
}

func (o VirtualMachineOutput) RoleId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *VirtualMachine) pulumi.IntPtrOutput { return v.RoleId }).(pulumi.IntPtrOutput)
}

func (o VirtualMachineOutput) SiteId() pulumi.IntOutput {
	return o.ApplyT(func(v *VirtualMachine) pulumi.IntOutput { return v.SiteId }).(pulumi.IntOutput)
}

func (o VirtualMachineOutput) Tags() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *VirtualMachine) pulumi.StringArrayOutput { return v.Tags }).(pulumi.StringArrayOutput)
}

func (o VirtualMachineOutput) TenantId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *VirtualMachine) pulumi.IntPtrOutput { return v.TenantId }).(pulumi.IntPtrOutput)
}

func (o VirtualMachineOutput) Vcpus() pulumi.Float64PtrOutput {
	return o.ApplyT(func(v *VirtualMachine) pulumi.Float64PtrOutput { return v.Vcpus }).(pulumi.Float64PtrOutput)
}

type VirtualMachineArrayOutput struct{ *pulumi.OutputState }

func (VirtualMachineArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*VirtualMachine)(nil)).Elem()
}

func (o VirtualMachineArrayOutput) ToVirtualMachineArrayOutput() VirtualMachineArrayOutput {
	return o
}

func (o VirtualMachineArrayOutput) ToVirtualMachineArrayOutputWithContext(ctx context.Context) VirtualMachineArrayOutput {
	return o
}

func (o VirtualMachineArrayOutput) Index(i pulumi.IntInput) VirtualMachineOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *VirtualMachine {
		return vs[0].([]*VirtualMachine)[vs[1].(int)]
	}).(VirtualMachineOutput)
}

type VirtualMachineMapOutput struct{ *pulumi.OutputState }

func (VirtualMachineMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*VirtualMachine)(nil)).Elem()
}

func (o VirtualMachineMapOutput) ToVirtualMachineMapOutput() VirtualMachineMapOutput {
	return o
}

func (o VirtualMachineMapOutput) ToVirtualMachineMapOutputWithContext(ctx context.Context) VirtualMachineMapOutput {
	return o
}

func (o VirtualMachineMapOutput) MapIndex(k pulumi.StringInput) VirtualMachineOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *VirtualMachine {
		return vs[0].(map[string]*VirtualMachine)[vs[1].(string)]
	}).(VirtualMachineOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*VirtualMachineInput)(nil)).Elem(), &VirtualMachine{})
	pulumi.RegisterInputType(reflect.TypeOf((*VirtualMachineArrayInput)(nil)).Elem(), VirtualMachineArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*VirtualMachineMapInput)(nil)).Elem(), VirtualMachineMap{})
	pulumi.RegisterOutputType(VirtualMachineOutput{})
	pulumi.RegisterOutputType(VirtualMachineArrayOutput{})
	pulumi.RegisterOutputType(VirtualMachineMapOutput{})
}
