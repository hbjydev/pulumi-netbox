// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package netbox

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/virtualization/#clusters):
//
// > A cluster is a logical grouping of physical resources within which virtual machines run. A cluster must be assigned a type (technological classification), and may optionally be assigned to a cluster group, site, and/or tenant. Each cluster must have a unique name within its assigned group and/or site, if any.
// >
// > Physical devices may be associated with clusters as hosts. This allows users to track on which host(s) a particular virtual machine may reside. However, NetBox does not support pinning a specific VM within a cluster to a particular host device.
//
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
//			dcWest, err := netbox.LookupClusterGroup(ctx, &GetClusterGroupArgs{
//				Name: "dc-west",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			vmwVsphere, err := netbox.NewClusterType(ctx, "vmwVsphere", nil)
//			if err != nil {
//				return err
//			}
//			_, err = netbox.NewCluster(ctx, "vmwCluster01", &netbox.ClusterArgs{
//				ClusterTypeId:  vmwVsphere.ID(),
//				ClusterGroupId: pulumi.String(dcWest.Id),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type Cluster struct {
	pulumi.CustomResourceState

	ClusterGroupId pulumi.IntPtrOutput      `pulumi:"clusterGroupId"`
	ClusterTypeId  pulumi.IntOutput         `pulumi:"clusterTypeId"`
	Name           pulumi.StringOutput      `pulumi:"name"`
	SiteId         pulumi.IntPtrOutput      `pulumi:"siteId"`
	Tags           pulumi.StringArrayOutput `pulumi:"tags"`
}

// NewCluster registers a new resource with the given unique name, arguments, and options.
func NewCluster(ctx *pulumi.Context,
	name string, args *ClusterArgs, opts ...pulumi.ResourceOption) (*Cluster, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClusterTypeId == nil {
		return nil, errors.New("invalid value for required argument 'ClusterTypeId'")
	}
	var resource Cluster
	err := ctx.RegisterResource("netbox:index/cluster:Cluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCluster gets an existing Cluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterState, opts ...pulumi.ResourceOption) (*Cluster, error) {
	var resource Cluster
	err := ctx.ReadResource("netbox:index/cluster:Cluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Cluster resources.
type clusterState struct {
	ClusterGroupId *int     `pulumi:"clusterGroupId"`
	ClusterTypeId  *int     `pulumi:"clusterTypeId"`
	Name           *string  `pulumi:"name"`
	SiteId         *int     `pulumi:"siteId"`
	Tags           []string `pulumi:"tags"`
}

type ClusterState struct {
	ClusterGroupId pulumi.IntPtrInput
	ClusterTypeId  pulumi.IntPtrInput
	Name           pulumi.StringPtrInput
	SiteId         pulumi.IntPtrInput
	Tags           pulumi.StringArrayInput
}

func (ClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterState)(nil)).Elem()
}

type clusterArgs struct {
	ClusterGroupId *int     `pulumi:"clusterGroupId"`
	ClusterTypeId  int      `pulumi:"clusterTypeId"`
	Name           *string  `pulumi:"name"`
	SiteId         *int     `pulumi:"siteId"`
	Tags           []string `pulumi:"tags"`
}

// The set of arguments for constructing a Cluster resource.
type ClusterArgs struct {
	ClusterGroupId pulumi.IntPtrInput
	ClusterTypeId  pulumi.IntInput
	Name           pulumi.StringPtrInput
	SiteId         pulumi.IntPtrInput
	Tags           pulumi.StringArrayInput
}

func (ClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterArgs)(nil)).Elem()
}

type ClusterInput interface {
	pulumi.Input

	ToClusterOutput() ClusterOutput
	ToClusterOutputWithContext(ctx context.Context) ClusterOutput
}

func (*Cluster) ElementType() reflect.Type {
	return reflect.TypeOf((**Cluster)(nil)).Elem()
}

func (i *Cluster) ToClusterOutput() ClusterOutput {
	return i.ToClusterOutputWithContext(context.Background())
}

func (i *Cluster) ToClusterOutputWithContext(ctx context.Context) ClusterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterOutput)
}

// ClusterArrayInput is an input type that accepts ClusterArray and ClusterArrayOutput values.
// You can construct a concrete instance of `ClusterArrayInput` via:
//
//	ClusterArray{ ClusterArgs{...} }
type ClusterArrayInput interface {
	pulumi.Input

	ToClusterArrayOutput() ClusterArrayOutput
	ToClusterArrayOutputWithContext(context.Context) ClusterArrayOutput
}

type ClusterArray []ClusterInput

func (ClusterArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Cluster)(nil)).Elem()
}

func (i ClusterArray) ToClusterArrayOutput() ClusterArrayOutput {
	return i.ToClusterArrayOutputWithContext(context.Background())
}

func (i ClusterArray) ToClusterArrayOutputWithContext(ctx context.Context) ClusterArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterArrayOutput)
}

// ClusterMapInput is an input type that accepts ClusterMap and ClusterMapOutput values.
// You can construct a concrete instance of `ClusterMapInput` via:
//
//	ClusterMap{ "key": ClusterArgs{...} }
type ClusterMapInput interface {
	pulumi.Input

	ToClusterMapOutput() ClusterMapOutput
	ToClusterMapOutputWithContext(context.Context) ClusterMapOutput
}

type ClusterMap map[string]ClusterInput

func (ClusterMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Cluster)(nil)).Elem()
}

func (i ClusterMap) ToClusterMapOutput() ClusterMapOutput {
	return i.ToClusterMapOutputWithContext(context.Background())
}

func (i ClusterMap) ToClusterMapOutputWithContext(ctx context.Context) ClusterMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterMapOutput)
}

type ClusterOutput struct{ *pulumi.OutputState }

func (ClusterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Cluster)(nil)).Elem()
}

func (o ClusterOutput) ToClusterOutput() ClusterOutput {
	return o
}

func (o ClusterOutput) ToClusterOutputWithContext(ctx context.Context) ClusterOutput {
	return o
}

func (o ClusterOutput) ClusterGroupId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Cluster) pulumi.IntPtrOutput { return v.ClusterGroupId }).(pulumi.IntPtrOutput)
}

func (o ClusterOutput) ClusterTypeId() pulumi.IntOutput {
	return o.ApplyT(func(v *Cluster) pulumi.IntOutput { return v.ClusterTypeId }).(pulumi.IntOutput)
}

func (o ClusterOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o ClusterOutput) SiteId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Cluster) pulumi.IntPtrOutput { return v.SiteId }).(pulumi.IntPtrOutput)
}

func (o ClusterOutput) Tags() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringArrayOutput { return v.Tags }).(pulumi.StringArrayOutput)
}

type ClusterArrayOutput struct{ *pulumi.OutputState }

func (ClusterArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Cluster)(nil)).Elem()
}

func (o ClusterArrayOutput) ToClusterArrayOutput() ClusterArrayOutput {
	return o
}

func (o ClusterArrayOutput) ToClusterArrayOutputWithContext(ctx context.Context) ClusterArrayOutput {
	return o
}

func (o ClusterArrayOutput) Index(i pulumi.IntInput) ClusterOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Cluster {
		return vs[0].([]*Cluster)[vs[1].(int)]
	}).(ClusterOutput)
}

type ClusterMapOutput struct{ *pulumi.OutputState }

func (ClusterMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Cluster)(nil)).Elem()
}

func (o ClusterMapOutput) ToClusterMapOutput() ClusterMapOutput {
	return o
}

func (o ClusterMapOutput) ToClusterMapOutputWithContext(ctx context.Context) ClusterMapOutput {
	return o
}

func (o ClusterMapOutput) MapIndex(k pulumi.StringInput) ClusterOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Cluster {
		return vs[0].(map[string]*Cluster)[vs[1].(string)]
	}).(ClusterOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ClusterInput)(nil)).Elem(), &Cluster{})
	pulumi.RegisterInputType(reflect.TypeOf((*ClusterArrayInput)(nil)).Elem(), ClusterArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ClusterMapInput)(nil)).Elem(), ClusterMap{})
	pulumi.RegisterOutputType(ClusterOutput{})
	pulumi.RegisterOutputType(ClusterArrayOutput{})
	pulumi.RegisterOutputType(ClusterMapOutput{})
}