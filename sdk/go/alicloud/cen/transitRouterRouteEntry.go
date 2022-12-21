// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cen

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a CEN transit router route entry resource.[What is Cen Transit Router Route Entry](https://help.aliyun.com/document_detail/261238.html)
//
// > **NOTE:** Available in 1.126.0+
//
// ## Import
//
// CEN instance can be imported using the id, e.g.
//
// ```sh
//
//	$ pulumi import alicloud:cen/transitRouterRouteEntry:TransitRouterRouteEntry default vtb-*********:rte-*******
//
// ```
type TransitRouterRouteEntry struct {
	pulumi.CustomResourceState

	// The dry run.
	DryRun pulumi.BoolPtrOutput `pulumi:"dryRun"`
	// The associating status of the Transit Router.
	Status pulumi.StringOutput `pulumi:"status"`
	// The description of the transit router route entry.
	TransitRouterRouteEntryDescription pulumi.StringPtrOutput `pulumi:"transitRouterRouteEntryDescription"`
	// The CIDR of the transit router route entry.
	TransitRouterRouteEntryDestinationCidrBlock pulumi.StringOutput `pulumi:"transitRouterRouteEntryDestinationCidrBlock"`
	// The ID of the route entry.
	TransitRouterRouteEntryId pulumi.StringOutput `pulumi:"transitRouterRouteEntryId"`
	// The name of the transit router route entry.
	TransitRouterRouteEntryName pulumi.StringPtrOutput `pulumi:"transitRouterRouteEntryName"`
	// The ID of the transit router route entry next hop.
	TransitRouterRouteEntryNextHopId pulumi.StringPtrOutput `pulumi:"transitRouterRouteEntryNextHopId"`
	// The Type of the transit router route entry next hop,Valid values `Attachment` and `BlackHole`.
	TransitRouterRouteEntryNextHopType pulumi.StringOutput `pulumi:"transitRouterRouteEntryNextHopType"`
	// The ID of the transit router route table.
	TransitRouterRouteTableId pulumi.StringOutput `pulumi:"transitRouterRouteTableId"`
}

// NewTransitRouterRouteEntry registers a new resource with the given unique name, arguments, and options.
func NewTransitRouterRouteEntry(ctx *pulumi.Context,
	name string, args *TransitRouterRouteEntryArgs, opts ...pulumi.ResourceOption) (*TransitRouterRouteEntry, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.TransitRouterRouteEntryDestinationCidrBlock == nil {
		return nil, errors.New("invalid value for required argument 'TransitRouterRouteEntryDestinationCidrBlock'")
	}
	if args.TransitRouterRouteEntryNextHopType == nil {
		return nil, errors.New("invalid value for required argument 'TransitRouterRouteEntryNextHopType'")
	}
	if args.TransitRouterRouteTableId == nil {
		return nil, errors.New("invalid value for required argument 'TransitRouterRouteTableId'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource TransitRouterRouteEntry
	err := ctx.RegisterResource("alicloud:cen/transitRouterRouteEntry:TransitRouterRouteEntry", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTransitRouterRouteEntry gets an existing TransitRouterRouteEntry resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTransitRouterRouteEntry(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TransitRouterRouteEntryState, opts ...pulumi.ResourceOption) (*TransitRouterRouteEntry, error) {
	var resource TransitRouterRouteEntry
	err := ctx.ReadResource("alicloud:cen/transitRouterRouteEntry:TransitRouterRouteEntry", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TransitRouterRouteEntry resources.
type transitRouterRouteEntryState struct {
	// The dry run.
	DryRun *bool `pulumi:"dryRun"`
	// The associating status of the Transit Router.
	Status *string `pulumi:"status"`
	// The description of the transit router route entry.
	TransitRouterRouteEntryDescription *string `pulumi:"transitRouterRouteEntryDescription"`
	// The CIDR of the transit router route entry.
	TransitRouterRouteEntryDestinationCidrBlock *string `pulumi:"transitRouterRouteEntryDestinationCidrBlock"`
	// The ID of the route entry.
	TransitRouterRouteEntryId *string `pulumi:"transitRouterRouteEntryId"`
	// The name of the transit router route entry.
	TransitRouterRouteEntryName *string `pulumi:"transitRouterRouteEntryName"`
	// The ID of the transit router route entry next hop.
	TransitRouterRouteEntryNextHopId *string `pulumi:"transitRouterRouteEntryNextHopId"`
	// The Type of the transit router route entry next hop,Valid values `Attachment` and `BlackHole`.
	TransitRouterRouteEntryNextHopType *string `pulumi:"transitRouterRouteEntryNextHopType"`
	// The ID of the transit router route table.
	TransitRouterRouteTableId *string `pulumi:"transitRouterRouteTableId"`
}

type TransitRouterRouteEntryState struct {
	// The dry run.
	DryRun pulumi.BoolPtrInput
	// The associating status of the Transit Router.
	Status pulumi.StringPtrInput
	// The description of the transit router route entry.
	TransitRouterRouteEntryDescription pulumi.StringPtrInput
	// The CIDR of the transit router route entry.
	TransitRouterRouteEntryDestinationCidrBlock pulumi.StringPtrInput
	// The ID of the route entry.
	TransitRouterRouteEntryId pulumi.StringPtrInput
	// The name of the transit router route entry.
	TransitRouterRouteEntryName pulumi.StringPtrInput
	// The ID of the transit router route entry next hop.
	TransitRouterRouteEntryNextHopId pulumi.StringPtrInput
	// The Type of the transit router route entry next hop,Valid values `Attachment` and `BlackHole`.
	TransitRouterRouteEntryNextHopType pulumi.StringPtrInput
	// The ID of the transit router route table.
	TransitRouterRouteTableId pulumi.StringPtrInput
}

func (TransitRouterRouteEntryState) ElementType() reflect.Type {
	return reflect.TypeOf((*transitRouterRouteEntryState)(nil)).Elem()
}

type transitRouterRouteEntryArgs struct {
	// The dry run.
	DryRun *bool `pulumi:"dryRun"`
	// The description of the transit router route entry.
	TransitRouterRouteEntryDescription *string `pulumi:"transitRouterRouteEntryDescription"`
	// The CIDR of the transit router route entry.
	TransitRouterRouteEntryDestinationCidrBlock string `pulumi:"transitRouterRouteEntryDestinationCidrBlock"`
	// The name of the transit router route entry.
	TransitRouterRouteEntryName *string `pulumi:"transitRouterRouteEntryName"`
	// The ID of the transit router route entry next hop.
	TransitRouterRouteEntryNextHopId *string `pulumi:"transitRouterRouteEntryNextHopId"`
	// The Type of the transit router route entry next hop,Valid values `Attachment` and `BlackHole`.
	TransitRouterRouteEntryNextHopType string `pulumi:"transitRouterRouteEntryNextHopType"`
	// The ID of the transit router route table.
	TransitRouterRouteTableId string `pulumi:"transitRouterRouteTableId"`
}

// The set of arguments for constructing a TransitRouterRouteEntry resource.
type TransitRouterRouteEntryArgs struct {
	// The dry run.
	DryRun pulumi.BoolPtrInput
	// The description of the transit router route entry.
	TransitRouterRouteEntryDescription pulumi.StringPtrInput
	// The CIDR of the transit router route entry.
	TransitRouterRouteEntryDestinationCidrBlock pulumi.StringInput
	// The name of the transit router route entry.
	TransitRouterRouteEntryName pulumi.StringPtrInput
	// The ID of the transit router route entry next hop.
	TransitRouterRouteEntryNextHopId pulumi.StringPtrInput
	// The Type of the transit router route entry next hop,Valid values `Attachment` and `BlackHole`.
	TransitRouterRouteEntryNextHopType pulumi.StringInput
	// The ID of the transit router route table.
	TransitRouterRouteTableId pulumi.StringInput
}

func (TransitRouterRouteEntryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*transitRouterRouteEntryArgs)(nil)).Elem()
}

type TransitRouterRouteEntryInput interface {
	pulumi.Input

	ToTransitRouterRouteEntryOutput() TransitRouterRouteEntryOutput
	ToTransitRouterRouteEntryOutputWithContext(ctx context.Context) TransitRouterRouteEntryOutput
}

func (*TransitRouterRouteEntry) ElementType() reflect.Type {
	return reflect.TypeOf((**TransitRouterRouteEntry)(nil)).Elem()
}

func (i *TransitRouterRouteEntry) ToTransitRouterRouteEntryOutput() TransitRouterRouteEntryOutput {
	return i.ToTransitRouterRouteEntryOutputWithContext(context.Background())
}

func (i *TransitRouterRouteEntry) ToTransitRouterRouteEntryOutputWithContext(ctx context.Context) TransitRouterRouteEntryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TransitRouterRouteEntryOutput)
}

// TransitRouterRouteEntryArrayInput is an input type that accepts TransitRouterRouteEntryArray and TransitRouterRouteEntryArrayOutput values.
// You can construct a concrete instance of `TransitRouterRouteEntryArrayInput` via:
//
//	TransitRouterRouteEntryArray{ TransitRouterRouteEntryArgs{...} }
type TransitRouterRouteEntryArrayInput interface {
	pulumi.Input

	ToTransitRouterRouteEntryArrayOutput() TransitRouterRouteEntryArrayOutput
	ToTransitRouterRouteEntryArrayOutputWithContext(context.Context) TransitRouterRouteEntryArrayOutput
}

type TransitRouterRouteEntryArray []TransitRouterRouteEntryInput

func (TransitRouterRouteEntryArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TransitRouterRouteEntry)(nil)).Elem()
}

func (i TransitRouterRouteEntryArray) ToTransitRouterRouteEntryArrayOutput() TransitRouterRouteEntryArrayOutput {
	return i.ToTransitRouterRouteEntryArrayOutputWithContext(context.Background())
}

func (i TransitRouterRouteEntryArray) ToTransitRouterRouteEntryArrayOutputWithContext(ctx context.Context) TransitRouterRouteEntryArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TransitRouterRouteEntryArrayOutput)
}

// TransitRouterRouteEntryMapInput is an input type that accepts TransitRouterRouteEntryMap and TransitRouterRouteEntryMapOutput values.
// You can construct a concrete instance of `TransitRouterRouteEntryMapInput` via:
//
//	TransitRouterRouteEntryMap{ "key": TransitRouterRouteEntryArgs{...} }
type TransitRouterRouteEntryMapInput interface {
	pulumi.Input

	ToTransitRouterRouteEntryMapOutput() TransitRouterRouteEntryMapOutput
	ToTransitRouterRouteEntryMapOutputWithContext(context.Context) TransitRouterRouteEntryMapOutput
}

type TransitRouterRouteEntryMap map[string]TransitRouterRouteEntryInput

func (TransitRouterRouteEntryMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TransitRouterRouteEntry)(nil)).Elem()
}

func (i TransitRouterRouteEntryMap) ToTransitRouterRouteEntryMapOutput() TransitRouterRouteEntryMapOutput {
	return i.ToTransitRouterRouteEntryMapOutputWithContext(context.Background())
}

func (i TransitRouterRouteEntryMap) ToTransitRouterRouteEntryMapOutputWithContext(ctx context.Context) TransitRouterRouteEntryMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TransitRouterRouteEntryMapOutput)
}

type TransitRouterRouteEntryOutput struct{ *pulumi.OutputState }

func (TransitRouterRouteEntryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**TransitRouterRouteEntry)(nil)).Elem()
}

func (o TransitRouterRouteEntryOutput) ToTransitRouterRouteEntryOutput() TransitRouterRouteEntryOutput {
	return o
}

func (o TransitRouterRouteEntryOutput) ToTransitRouterRouteEntryOutputWithContext(ctx context.Context) TransitRouterRouteEntryOutput {
	return o
}

// The dry run.
func (o TransitRouterRouteEntryOutput) DryRun() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *TransitRouterRouteEntry) pulumi.BoolPtrOutput { return v.DryRun }).(pulumi.BoolPtrOutput)
}

// The associating status of the Transit Router.
func (o TransitRouterRouteEntryOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *TransitRouterRouteEntry) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

// The description of the transit router route entry.
func (o TransitRouterRouteEntryOutput) TransitRouterRouteEntryDescription() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TransitRouterRouteEntry) pulumi.StringPtrOutput { return v.TransitRouterRouteEntryDescription }).(pulumi.StringPtrOutput)
}

// The CIDR of the transit router route entry.
func (o TransitRouterRouteEntryOutput) TransitRouterRouteEntryDestinationCidrBlock() pulumi.StringOutput {
	return o.ApplyT(func(v *TransitRouterRouteEntry) pulumi.StringOutput {
		return v.TransitRouterRouteEntryDestinationCidrBlock
	}).(pulumi.StringOutput)
}

// The ID of the route entry.
func (o TransitRouterRouteEntryOutput) TransitRouterRouteEntryId() pulumi.StringOutput {
	return o.ApplyT(func(v *TransitRouterRouteEntry) pulumi.StringOutput { return v.TransitRouterRouteEntryId }).(pulumi.StringOutput)
}

// The name of the transit router route entry.
func (o TransitRouterRouteEntryOutput) TransitRouterRouteEntryName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TransitRouterRouteEntry) pulumi.StringPtrOutput { return v.TransitRouterRouteEntryName }).(pulumi.StringPtrOutput)
}

// The ID of the transit router route entry next hop.
func (o TransitRouterRouteEntryOutput) TransitRouterRouteEntryNextHopId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TransitRouterRouteEntry) pulumi.StringPtrOutput { return v.TransitRouterRouteEntryNextHopId }).(pulumi.StringPtrOutput)
}

// The Type of the transit router route entry next hop,Valid values `Attachment` and `BlackHole`.
func (o TransitRouterRouteEntryOutput) TransitRouterRouteEntryNextHopType() pulumi.StringOutput {
	return o.ApplyT(func(v *TransitRouterRouteEntry) pulumi.StringOutput { return v.TransitRouterRouteEntryNextHopType }).(pulumi.StringOutput)
}

// The ID of the transit router route table.
func (o TransitRouterRouteEntryOutput) TransitRouterRouteTableId() pulumi.StringOutput {
	return o.ApplyT(func(v *TransitRouterRouteEntry) pulumi.StringOutput { return v.TransitRouterRouteTableId }).(pulumi.StringOutput)
}

type TransitRouterRouteEntryArrayOutput struct{ *pulumi.OutputState }

func (TransitRouterRouteEntryArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TransitRouterRouteEntry)(nil)).Elem()
}

func (o TransitRouterRouteEntryArrayOutput) ToTransitRouterRouteEntryArrayOutput() TransitRouterRouteEntryArrayOutput {
	return o
}

func (o TransitRouterRouteEntryArrayOutput) ToTransitRouterRouteEntryArrayOutputWithContext(ctx context.Context) TransitRouterRouteEntryArrayOutput {
	return o
}

func (o TransitRouterRouteEntryArrayOutput) Index(i pulumi.IntInput) TransitRouterRouteEntryOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *TransitRouterRouteEntry {
		return vs[0].([]*TransitRouterRouteEntry)[vs[1].(int)]
	}).(TransitRouterRouteEntryOutput)
}

type TransitRouterRouteEntryMapOutput struct{ *pulumi.OutputState }

func (TransitRouterRouteEntryMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TransitRouterRouteEntry)(nil)).Elem()
}

func (o TransitRouterRouteEntryMapOutput) ToTransitRouterRouteEntryMapOutput() TransitRouterRouteEntryMapOutput {
	return o
}

func (o TransitRouterRouteEntryMapOutput) ToTransitRouterRouteEntryMapOutputWithContext(ctx context.Context) TransitRouterRouteEntryMapOutput {
	return o
}

func (o TransitRouterRouteEntryMapOutput) MapIndex(k pulumi.StringInput) TransitRouterRouteEntryOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *TransitRouterRouteEntry {
		return vs[0].(map[string]*TransitRouterRouteEntry)[vs[1].(string)]
	}).(TransitRouterRouteEntryOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TransitRouterRouteEntryInput)(nil)).Elem(), &TransitRouterRouteEntry{})
	pulumi.RegisterInputType(reflect.TypeOf((*TransitRouterRouteEntryArrayInput)(nil)).Elem(), TransitRouterRouteEntryArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*TransitRouterRouteEntryMapInput)(nil)).Elem(), TransitRouterRouteEntryMap{})
	pulumi.RegisterOutputType(TransitRouterRouteEntryOutput{})
	pulumi.RegisterOutputType(TransitRouterRouteEntryArrayOutput{})
	pulumi.RegisterOutputType(TransitRouterRouteEntryMapOutput{})
}