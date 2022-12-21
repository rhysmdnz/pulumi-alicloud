// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package resourcemanager

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a Resource Manager Resource Share resource.
//
// For information about Resource Manager Resource Share and how to use it, see [What is Resource Share](https://www.alibabacloud.com/help/en/doc-detail/94475.htm).
//
// > **NOTE:** Available in v1.111.0+.
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
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/resourcemanager"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := resourcemanager.NewResourceShare(ctx, "example", &resourcemanager.ResourceShareArgs{
//				ResourceShareName: pulumi.String("example_value"),
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
// Resource Manager Resource Share can be imported using the id, e.g.
//
// ```sh
//
//	$ pulumi import alicloud:resourcemanager/resourceShare:ResourceShare example <id>
//
// ```
type ResourceShare struct {
	pulumi.CustomResourceState

	// The name of resource share.
	ResourceShareName pulumi.StringOutput `pulumi:"resourceShareName"`
	// The owner of resource share.
	ResourceShareOwner pulumi.StringOutput `pulumi:"resourceShareOwner"`
	// The status of resource share.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewResourceShare registers a new resource with the given unique name, arguments, and options.
func NewResourceShare(ctx *pulumi.Context,
	name string, args *ResourceShareArgs, opts ...pulumi.ResourceOption) (*ResourceShare, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceShareName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceShareName'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource ResourceShare
	err := ctx.RegisterResource("alicloud:resourcemanager/resourceShare:ResourceShare", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetResourceShare gets an existing ResourceShare resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetResourceShare(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ResourceShareState, opts ...pulumi.ResourceOption) (*ResourceShare, error) {
	var resource ResourceShare
	err := ctx.ReadResource("alicloud:resourcemanager/resourceShare:ResourceShare", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ResourceShare resources.
type resourceShareState struct {
	// The name of resource share.
	ResourceShareName *string `pulumi:"resourceShareName"`
	// The owner of resource share.
	ResourceShareOwner *string `pulumi:"resourceShareOwner"`
	// The status of resource share.
	Status *string `pulumi:"status"`
}

type ResourceShareState struct {
	// The name of resource share.
	ResourceShareName pulumi.StringPtrInput
	// The owner of resource share.
	ResourceShareOwner pulumi.StringPtrInput
	// The status of resource share.
	Status pulumi.StringPtrInput
}

func (ResourceShareState) ElementType() reflect.Type {
	return reflect.TypeOf((*resourceShareState)(nil)).Elem()
}

type resourceShareArgs struct {
	// The name of resource share.
	ResourceShareName string `pulumi:"resourceShareName"`
}

// The set of arguments for constructing a ResourceShare resource.
type ResourceShareArgs struct {
	// The name of resource share.
	ResourceShareName pulumi.StringInput
}

func (ResourceShareArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*resourceShareArgs)(nil)).Elem()
}

type ResourceShareInput interface {
	pulumi.Input

	ToResourceShareOutput() ResourceShareOutput
	ToResourceShareOutputWithContext(ctx context.Context) ResourceShareOutput
}

func (*ResourceShare) ElementType() reflect.Type {
	return reflect.TypeOf((**ResourceShare)(nil)).Elem()
}

func (i *ResourceShare) ToResourceShareOutput() ResourceShareOutput {
	return i.ToResourceShareOutputWithContext(context.Background())
}

func (i *ResourceShare) ToResourceShareOutputWithContext(ctx context.Context) ResourceShareOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourceShareOutput)
}

// ResourceShareArrayInput is an input type that accepts ResourceShareArray and ResourceShareArrayOutput values.
// You can construct a concrete instance of `ResourceShareArrayInput` via:
//
//	ResourceShareArray{ ResourceShareArgs{...} }
type ResourceShareArrayInput interface {
	pulumi.Input

	ToResourceShareArrayOutput() ResourceShareArrayOutput
	ToResourceShareArrayOutputWithContext(context.Context) ResourceShareArrayOutput
}

type ResourceShareArray []ResourceShareInput

func (ResourceShareArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ResourceShare)(nil)).Elem()
}

func (i ResourceShareArray) ToResourceShareArrayOutput() ResourceShareArrayOutput {
	return i.ToResourceShareArrayOutputWithContext(context.Background())
}

func (i ResourceShareArray) ToResourceShareArrayOutputWithContext(ctx context.Context) ResourceShareArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourceShareArrayOutput)
}

// ResourceShareMapInput is an input type that accepts ResourceShareMap and ResourceShareMapOutput values.
// You can construct a concrete instance of `ResourceShareMapInput` via:
//
//	ResourceShareMap{ "key": ResourceShareArgs{...} }
type ResourceShareMapInput interface {
	pulumi.Input

	ToResourceShareMapOutput() ResourceShareMapOutput
	ToResourceShareMapOutputWithContext(context.Context) ResourceShareMapOutput
}

type ResourceShareMap map[string]ResourceShareInput

func (ResourceShareMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ResourceShare)(nil)).Elem()
}

func (i ResourceShareMap) ToResourceShareMapOutput() ResourceShareMapOutput {
	return i.ToResourceShareMapOutputWithContext(context.Background())
}

func (i ResourceShareMap) ToResourceShareMapOutputWithContext(ctx context.Context) ResourceShareMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourceShareMapOutput)
}

type ResourceShareOutput struct{ *pulumi.OutputState }

func (ResourceShareOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ResourceShare)(nil)).Elem()
}

func (o ResourceShareOutput) ToResourceShareOutput() ResourceShareOutput {
	return o
}

func (o ResourceShareOutput) ToResourceShareOutputWithContext(ctx context.Context) ResourceShareOutput {
	return o
}

// The name of resource share.
func (o ResourceShareOutput) ResourceShareName() pulumi.StringOutput {
	return o.ApplyT(func(v *ResourceShare) pulumi.StringOutput { return v.ResourceShareName }).(pulumi.StringOutput)
}

// The owner of resource share.
func (o ResourceShareOutput) ResourceShareOwner() pulumi.StringOutput {
	return o.ApplyT(func(v *ResourceShare) pulumi.StringOutput { return v.ResourceShareOwner }).(pulumi.StringOutput)
}

// The status of resource share.
func (o ResourceShareOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *ResourceShare) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type ResourceShareArrayOutput struct{ *pulumi.OutputState }

func (ResourceShareArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ResourceShare)(nil)).Elem()
}

func (o ResourceShareArrayOutput) ToResourceShareArrayOutput() ResourceShareArrayOutput {
	return o
}

func (o ResourceShareArrayOutput) ToResourceShareArrayOutputWithContext(ctx context.Context) ResourceShareArrayOutput {
	return o
}

func (o ResourceShareArrayOutput) Index(i pulumi.IntInput) ResourceShareOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ResourceShare {
		return vs[0].([]*ResourceShare)[vs[1].(int)]
	}).(ResourceShareOutput)
}

type ResourceShareMapOutput struct{ *pulumi.OutputState }

func (ResourceShareMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ResourceShare)(nil)).Elem()
}

func (o ResourceShareMapOutput) ToResourceShareMapOutput() ResourceShareMapOutput {
	return o
}

func (o ResourceShareMapOutput) ToResourceShareMapOutputWithContext(ctx context.Context) ResourceShareMapOutput {
	return o
}

func (o ResourceShareMapOutput) MapIndex(k pulumi.StringInput) ResourceShareOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ResourceShare {
		return vs[0].(map[string]*ResourceShare)[vs[1].(string)]
	}).(ResourceShareOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ResourceShareInput)(nil)).Elem(), &ResourceShare{})
	pulumi.RegisterInputType(reflect.TypeOf((*ResourceShareArrayInput)(nil)).Elem(), ResourceShareArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ResourceShareMapInput)(nil)).Elem(), ResourceShareMap{})
	pulumi.RegisterOutputType(ResourceShareOutput{})
	pulumi.RegisterOutputType(ResourceShareArrayOutput{})
	pulumi.RegisterOutputType(ResourceShareMapOutput{})
}