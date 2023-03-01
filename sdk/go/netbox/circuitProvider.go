// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package netbox

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/circuits/#providers):
//
// > A circuit provider is any entity which provides some form of connectivity of among sites or organizations within a site. While this obviously includes carriers which offer Internet and private transit service, it might also include Internet exchange (IX) points and even organizations with whom you peer directly. Each circuit within NetBox must be assigned a provider and a circuit ID which is unique to that provider.
// >
// > Each provider may be assigned an autonomous system number (ASN), an account number, and contact information.
type CircuitProvider struct {
	pulumi.CustomResourceState

	Name pulumi.StringOutput `pulumi:"name"`
	Slug pulumi.StringOutput `pulumi:"slug"`
}

// NewCircuitProvider registers a new resource with the given unique name, arguments, and options.
func NewCircuitProvider(ctx *pulumi.Context,
	name string, args *CircuitProviderArgs, opts ...pulumi.ResourceOption) (*CircuitProvider, error) {
	if args == nil {
		args = &CircuitProviderArgs{}
	}

	var resource CircuitProvider
	err := ctx.RegisterResource("netbox:index/circuitProvider:CircuitProvider", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCircuitProvider gets an existing CircuitProvider resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCircuitProvider(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CircuitProviderState, opts ...pulumi.ResourceOption) (*CircuitProvider, error) {
	var resource CircuitProvider
	err := ctx.ReadResource("netbox:index/circuitProvider:CircuitProvider", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CircuitProvider resources.
type circuitProviderState struct {
	Name *string `pulumi:"name"`
	Slug *string `pulumi:"slug"`
}

type CircuitProviderState struct {
	Name pulumi.StringPtrInput
	Slug pulumi.StringPtrInput
}

func (CircuitProviderState) ElementType() reflect.Type {
	return reflect.TypeOf((*circuitProviderState)(nil)).Elem()
}

type circuitProviderArgs struct {
	Name *string `pulumi:"name"`
	Slug *string `pulumi:"slug"`
}

// The set of arguments for constructing a CircuitProvider resource.
type CircuitProviderArgs struct {
	Name pulumi.StringPtrInput
	Slug pulumi.StringPtrInput
}

func (CircuitProviderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*circuitProviderArgs)(nil)).Elem()
}

type CircuitProviderInput interface {
	pulumi.Input

	ToCircuitProviderOutput() CircuitProviderOutput
	ToCircuitProviderOutputWithContext(ctx context.Context) CircuitProviderOutput
}

func (*CircuitProvider) ElementType() reflect.Type {
	return reflect.TypeOf((**CircuitProvider)(nil)).Elem()
}

func (i *CircuitProvider) ToCircuitProviderOutput() CircuitProviderOutput {
	return i.ToCircuitProviderOutputWithContext(context.Background())
}

func (i *CircuitProvider) ToCircuitProviderOutputWithContext(ctx context.Context) CircuitProviderOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CircuitProviderOutput)
}

// CircuitProviderArrayInput is an input type that accepts CircuitProviderArray and CircuitProviderArrayOutput values.
// You can construct a concrete instance of `CircuitProviderArrayInput` via:
//
//	CircuitProviderArray{ CircuitProviderArgs{...} }
type CircuitProviderArrayInput interface {
	pulumi.Input

	ToCircuitProviderArrayOutput() CircuitProviderArrayOutput
	ToCircuitProviderArrayOutputWithContext(context.Context) CircuitProviderArrayOutput
}

type CircuitProviderArray []CircuitProviderInput

func (CircuitProviderArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CircuitProvider)(nil)).Elem()
}

func (i CircuitProviderArray) ToCircuitProviderArrayOutput() CircuitProviderArrayOutput {
	return i.ToCircuitProviderArrayOutputWithContext(context.Background())
}

func (i CircuitProviderArray) ToCircuitProviderArrayOutputWithContext(ctx context.Context) CircuitProviderArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CircuitProviderArrayOutput)
}

// CircuitProviderMapInput is an input type that accepts CircuitProviderMap and CircuitProviderMapOutput values.
// You can construct a concrete instance of `CircuitProviderMapInput` via:
//
//	CircuitProviderMap{ "key": CircuitProviderArgs{...} }
type CircuitProviderMapInput interface {
	pulumi.Input

	ToCircuitProviderMapOutput() CircuitProviderMapOutput
	ToCircuitProviderMapOutputWithContext(context.Context) CircuitProviderMapOutput
}

type CircuitProviderMap map[string]CircuitProviderInput

func (CircuitProviderMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CircuitProvider)(nil)).Elem()
}

func (i CircuitProviderMap) ToCircuitProviderMapOutput() CircuitProviderMapOutput {
	return i.ToCircuitProviderMapOutputWithContext(context.Background())
}

func (i CircuitProviderMap) ToCircuitProviderMapOutputWithContext(ctx context.Context) CircuitProviderMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CircuitProviderMapOutput)
}

type CircuitProviderOutput struct{ *pulumi.OutputState }

func (CircuitProviderOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CircuitProvider)(nil)).Elem()
}

func (o CircuitProviderOutput) ToCircuitProviderOutput() CircuitProviderOutput {
	return o
}

func (o CircuitProviderOutput) ToCircuitProviderOutputWithContext(ctx context.Context) CircuitProviderOutput {
	return o
}

func (o CircuitProviderOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *CircuitProvider) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o CircuitProviderOutput) Slug() pulumi.StringOutput {
	return o.ApplyT(func(v *CircuitProvider) pulumi.StringOutput { return v.Slug }).(pulumi.StringOutput)
}

type CircuitProviderArrayOutput struct{ *pulumi.OutputState }

func (CircuitProviderArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CircuitProvider)(nil)).Elem()
}

func (o CircuitProviderArrayOutput) ToCircuitProviderArrayOutput() CircuitProviderArrayOutput {
	return o
}

func (o CircuitProviderArrayOutput) ToCircuitProviderArrayOutputWithContext(ctx context.Context) CircuitProviderArrayOutput {
	return o
}

func (o CircuitProviderArrayOutput) Index(i pulumi.IntInput) CircuitProviderOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *CircuitProvider {
		return vs[0].([]*CircuitProvider)[vs[1].(int)]
	}).(CircuitProviderOutput)
}

type CircuitProviderMapOutput struct{ *pulumi.OutputState }

func (CircuitProviderMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CircuitProvider)(nil)).Elem()
}

func (o CircuitProviderMapOutput) ToCircuitProviderMapOutput() CircuitProviderMapOutput {
	return o
}

func (o CircuitProviderMapOutput) ToCircuitProviderMapOutputWithContext(ctx context.Context) CircuitProviderMapOutput {
	return o
}

func (o CircuitProviderMapOutput) MapIndex(k pulumi.StringInput) CircuitProviderOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *CircuitProvider {
		return vs[0].(map[string]*CircuitProvider)[vs[1].(string)]
	}).(CircuitProviderOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CircuitProviderInput)(nil)).Elem(), &CircuitProvider{})
	pulumi.RegisterInputType(reflect.TypeOf((*CircuitProviderArrayInput)(nil)).Elem(), CircuitProviderArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*CircuitProviderMapInput)(nil)).Elem(), CircuitProviderMap{})
	pulumi.RegisterOutputType(CircuitProviderOutput{})
	pulumi.RegisterOutputType(CircuitProviderArrayOutput{})
	pulumi.RegisterOutputType(CircuitProviderMapOutput{})
}
