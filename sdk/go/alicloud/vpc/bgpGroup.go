// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package vpc

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a VPC Bgp Group resource.
//
// For information about VPC Bgp Group and how to use it, see [What is Bgp Group](https://www.alibabacloud.com/help/en/doc-detail/91267.html).
//
// > **NOTE:** Available in v1.152.0+.
//
// ## Example Usage
//
// # Basic Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-alicloud/sdk/go/alicloud/expressconnect"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/expressconnect"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/vpc"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			examplePhysicalConnections, err := expressconnect.GetPhysicalConnections(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			exampleVirtualBorderRouter, err := expressconnect.NewVirtualBorderRouter(ctx, "exampleVirtualBorderRouter", &expressconnect.VirtualBorderRouterArgs{
//				LocalGatewayIp:          pulumi.String("10.0.0.1"),
//				PeerGatewayIp:           pulumi.String("10.0.0.2"),
//				PeeringSubnetMask:       pulumi.String("255.255.255.252"),
//				PhysicalConnectionId:    pulumi.String(examplePhysicalConnections.Connections[0].Id),
//				VirtualBorderRouterName: pulumi.Any(_var.Name),
//				VlanId:                  pulumi.Int(120),
//				MinRxInterval:           pulumi.Int(1000),
//				MinTxInterval:           pulumi.Int(1000),
//				DetectMultiplier:        pulumi.Int(10),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = vpc.NewBgpGroup(ctx, "default", &vpc.BgpGroupArgs{
//				AuthKey:      pulumi.String("YourPassword+12345678"),
//				BgpGroupName: pulumi.String("example_value"),
//				Description:  pulumi.String("example_value"),
//				LocalAsn:     pulumi.Int(64512),
//				PeerAsn:      pulumi.Int(1111),
//				RouterId:     exampleVirtualBorderRouter.ID(),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
//
// ## Import
//
// VPC Bgp Group can be imported using the id, e.g.
//
// ```sh
//
//	$ pulumi import alicloud:vpc/bgpGroup:BgpGroup example <id>
//
// ```
type BgpGroup struct {
	pulumi.CustomResourceState

	// The authentication key of the BGP group.
	AuthKey pulumi.StringPtrOutput `pulumi:"authKey"`
	// The name of the BGP group. The name must be `2` to `128` characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
	BgpGroupName pulumi.StringPtrOutput `pulumi:"bgpGroupName"`
	// The description of the BGP group. The description must be `2` to `256` characters in length. It must start with a letter but cannot start with `http://` or `https://`.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The is fake asn. A router that runs BGP typically belongs to only one AS. In some cases, for example, the AS needs to be migrated or is merged with another AS, a new AS number replaces the original one.
	IsFakeAsn pulumi.BoolOutput `pulumi:"isFakeAsn"`
	// The AS number on the Alibaba Cloud side.
	LocalAsn pulumi.IntOutput `pulumi:"localAsn"`
	// The AS number of the BGP peer.
	PeerAsn pulumi.IntOutput `pulumi:"peerAsn"`
	// The ID of the VBR.
	RouterId pulumi.StringOutput `pulumi:"routerId"`
	// The status of the resource.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewBgpGroup registers a new resource with the given unique name, arguments, and options.
func NewBgpGroup(ctx *pulumi.Context,
	name string, args *BgpGroupArgs, opts ...pulumi.ResourceOption) (*BgpGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PeerAsn == nil {
		return nil, errors.New("invalid value for required argument 'PeerAsn'")
	}
	if args.RouterId == nil {
		return nil, errors.New("invalid value for required argument 'RouterId'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource BgpGroup
	err := ctx.RegisterResource("alicloud:vpc/bgpGroup:BgpGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBgpGroup gets an existing BgpGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBgpGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BgpGroupState, opts ...pulumi.ResourceOption) (*BgpGroup, error) {
	var resource BgpGroup
	err := ctx.ReadResource("alicloud:vpc/bgpGroup:BgpGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BgpGroup resources.
type bgpGroupState struct {
	// The authentication key of the BGP group.
	AuthKey *string `pulumi:"authKey"`
	// The name of the BGP group. The name must be `2` to `128` characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
	BgpGroupName *string `pulumi:"bgpGroupName"`
	// The description of the BGP group. The description must be `2` to `256` characters in length. It must start with a letter but cannot start with `http://` or `https://`.
	Description *string `pulumi:"description"`
	// The is fake asn. A router that runs BGP typically belongs to only one AS. In some cases, for example, the AS needs to be migrated or is merged with another AS, a new AS number replaces the original one.
	IsFakeAsn *bool `pulumi:"isFakeAsn"`
	// The AS number on the Alibaba Cloud side.
	LocalAsn *int `pulumi:"localAsn"`
	// The AS number of the BGP peer.
	PeerAsn *int `pulumi:"peerAsn"`
	// The ID of the VBR.
	RouterId *string `pulumi:"routerId"`
	// The status of the resource.
	Status *string `pulumi:"status"`
}

type BgpGroupState struct {
	// The authentication key of the BGP group.
	AuthKey pulumi.StringPtrInput
	// The name of the BGP group. The name must be `2` to `128` characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
	BgpGroupName pulumi.StringPtrInput
	// The description of the BGP group. The description must be `2` to `256` characters in length. It must start with a letter but cannot start with `http://` or `https://`.
	Description pulumi.StringPtrInput
	// The is fake asn. A router that runs BGP typically belongs to only one AS. In some cases, for example, the AS needs to be migrated or is merged with another AS, a new AS number replaces the original one.
	IsFakeAsn pulumi.BoolPtrInput
	// The AS number on the Alibaba Cloud side.
	LocalAsn pulumi.IntPtrInput
	// The AS number of the BGP peer.
	PeerAsn pulumi.IntPtrInput
	// The ID of the VBR.
	RouterId pulumi.StringPtrInput
	// The status of the resource.
	Status pulumi.StringPtrInput
}

func (BgpGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*bgpGroupState)(nil)).Elem()
}

type bgpGroupArgs struct {
	// The authentication key of the BGP group.
	AuthKey *string `pulumi:"authKey"`
	// The name of the BGP group. The name must be `2` to `128` characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
	BgpGroupName *string `pulumi:"bgpGroupName"`
	// The description of the BGP group. The description must be `2` to `256` characters in length. It must start with a letter but cannot start with `http://` or `https://`.
	Description *string `pulumi:"description"`
	// The is fake asn. A router that runs BGP typically belongs to only one AS. In some cases, for example, the AS needs to be migrated or is merged with another AS, a new AS number replaces the original one.
	IsFakeAsn *bool `pulumi:"isFakeAsn"`
	// The AS number on the Alibaba Cloud side.
	LocalAsn *int `pulumi:"localAsn"`
	// The AS number of the BGP peer.
	PeerAsn int `pulumi:"peerAsn"`
	// The ID of the VBR.
	RouterId string `pulumi:"routerId"`
}

// The set of arguments for constructing a BgpGroup resource.
type BgpGroupArgs struct {
	// The authentication key of the BGP group.
	AuthKey pulumi.StringPtrInput
	// The name of the BGP group. The name must be `2` to `128` characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
	BgpGroupName pulumi.StringPtrInput
	// The description of the BGP group. The description must be `2` to `256` characters in length. It must start with a letter but cannot start with `http://` or `https://`.
	Description pulumi.StringPtrInput
	// The is fake asn. A router that runs BGP typically belongs to only one AS. In some cases, for example, the AS needs to be migrated or is merged with another AS, a new AS number replaces the original one.
	IsFakeAsn pulumi.BoolPtrInput
	// The AS number on the Alibaba Cloud side.
	LocalAsn pulumi.IntPtrInput
	// The AS number of the BGP peer.
	PeerAsn pulumi.IntInput
	// The ID of the VBR.
	RouterId pulumi.StringInput
}

func (BgpGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*bgpGroupArgs)(nil)).Elem()
}

type BgpGroupInput interface {
	pulumi.Input

	ToBgpGroupOutput() BgpGroupOutput
	ToBgpGroupOutputWithContext(ctx context.Context) BgpGroupOutput
}

func (*BgpGroup) ElementType() reflect.Type {
	return reflect.TypeOf((**BgpGroup)(nil)).Elem()
}

func (i *BgpGroup) ToBgpGroupOutput() BgpGroupOutput {
	return i.ToBgpGroupOutputWithContext(context.Background())
}

func (i *BgpGroup) ToBgpGroupOutputWithContext(ctx context.Context) BgpGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BgpGroupOutput)
}

// BgpGroupArrayInput is an input type that accepts BgpGroupArray and BgpGroupArrayOutput values.
// You can construct a concrete instance of `BgpGroupArrayInput` via:
//
//	BgpGroupArray{ BgpGroupArgs{...} }
type BgpGroupArrayInput interface {
	pulumi.Input

	ToBgpGroupArrayOutput() BgpGroupArrayOutput
	ToBgpGroupArrayOutputWithContext(context.Context) BgpGroupArrayOutput
}

type BgpGroupArray []BgpGroupInput

func (BgpGroupArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*BgpGroup)(nil)).Elem()
}

func (i BgpGroupArray) ToBgpGroupArrayOutput() BgpGroupArrayOutput {
	return i.ToBgpGroupArrayOutputWithContext(context.Background())
}

func (i BgpGroupArray) ToBgpGroupArrayOutputWithContext(ctx context.Context) BgpGroupArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BgpGroupArrayOutput)
}

// BgpGroupMapInput is an input type that accepts BgpGroupMap and BgpGroupMapOutput values.
// You can construct a concrete instance of `BgpGroupMapInput` via:
//
//	BgpGroupMap{ "key": BgpGroupArgs{...} }
type BgpGroupMapInput interface {
	pulumi.Input

	ToBgpGroupMapOutput() BgpGroupMapOutput
	ToBgpGroupMapOutputWithContext(context.Context) BgpGroupMapOutput
}

type BgpGroupMap map[string]BgpGroupInput

func (BgpGroupMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*BgpGroup)(nil)).Elem()
}

func (i BgpGroupMap) ToBgpGroupMapOutput() BgpGroupMapOutput {
	return i.ToBgpGroupMapOutputWithContext(context.Background())
}

func (i BgpGroupMap) ToBgpGroupMapOutputWithContext(ctx context.Context) BgpGroupMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BgpGroupMapOutput)
}

type BgpGroupOutput struct{ *pulumi.OutputState }

func (BgpGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BgpGroup)(nil)).Elem()
}

func (o BgpGroupOutput) ToBgpGroupOutput() BgpGroupOutput {
	return o
}

func (o BgpGroupOutput) ToBgpGroupOutputWithContext(ctx context.Context) BgpGroupOutput {
	return o
}

// The authentication key of the BGP group.
func (o BgpGroupOutput) AuthKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *BgpGroup) pulumi.StringPtrOutput { return v.AuthKey }).(pulumi.StringPtrOutput)
}

// The name of the BGP group. The name must be `2` to `128` characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
func (o BgpGroupOutput) BgpGroupName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *BgpGroup) pulumi.StringPtrOutput { return v.BgpGroupName }).(pulumi.StringPtrOutput)
}

// The description of the BGP group. The description must be `2` to `256` characters in length. It must start with a letter but cannot start with `http://` or `https://`.
func (o BgpGroupOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *BgpGroup) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// The is fake asn. A router that runs BGP typically belongs to only one AS. In some cases, for example, the AS needs to be migrated or is merged with another AS, a new AS number replaces the original one.
func (o BgpGroupOutput) IsFakeAsn() pulumi.BoolOutput {
	return o.ApplyT(func(v *BgpGroup) pulumi.BoolOutput { return v.IsFakeAsn }).(pulumi.BoolOutput)
}

// The AS number on the Alibaba Cloud side.
func (o BgpGroupOutput) LocalAsn() pulumi.IntOutput {
	return o.ApplyT(func(v *BgpGroup) pulumi.IntOutput { return v.LocalAsn }).(pulumi.IntOutput)
}

// The AS number of the BGP peer.
func (o BgpGroupOutput) PeerAsn() pulumi.IntOutput {
	return o.ApplyT(func(v *BgpGroup) pulumi.IntOutput { return v.PeerAsn }).(pulumi.IntOutput)
}

// The ID of the VBR.
func (o BgpGroupOutput) RouterId() pulumi.StringOutput {
	return o.ApplyT(func(v *BgpGroup) pulumi.StringOutput { return v.RouterId }).(pulumi.StringOutput)
}

// The status of the resource.
func (o BgpGroupOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *BgpGroup) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type BgpGroupArrayOutput struct{ *pulumi.OutputState }

func (BgpGroupArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*BgpGroup)(nil)).Elem()
}

func (o BgpGroupArrayOutput) ToBgpGroupArrayOutput() BgpGroupArrayOutput {
	return o
}

func (o BgpGroupArrayOutput) ToBgpGroupArrayOutputWithContext(ctx context.Context) BgpGroupArrayOutput {
	return o
}

func (o BgpGroupArrayOutput) Index(i pulumi.IntInput) BgpGroupOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *BgpGroup {
		return vs[0].([]*BgpGroup)[vs[1].(int)]
	}).(BgpGroupOutput)
}

type BgpGroupMapOutput struct{ *pulumi.OutputState }

func (BgpGroupMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*BgpGroup)(nil)).Elem()
}

func (o BgpGroupMapOutput) ToBgpGroupMapOutput() BgpGroupMapOutput {
	return o
}

func (o BgpGroupMapOutput) ToBgpGroupMapOutputWithContext(ctx context.Context) BgpGroupMapOutput {
	return o
}

func (o BgpGroupMapOutput) MapIndex(k pulumi.StringInput) BgpGroupOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *BgpGroup {
		return vs[0].(map[string]*BgpGroup)[vs[1].(string)]
	}).(BgpGroupOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*BgpGroupInput)(nil)).Elem(), &BgpGroup{})
	pulumi.RegisterInputType(reflect.TypeOf((*BgpGroupArrayInput)(nil)).Elem(), BgpGroupArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*BgpGroupMapInput)(nil)).Elem(), BgpGroupMap{})
	pulumi.RegisterOutputType(BgpGroupOutput{})
	pulumi.RegisterOutputType(BgpGroupArrayOutput{})
	pulumi.RegisterOutputType(BgpGroupMapOutput{})
}