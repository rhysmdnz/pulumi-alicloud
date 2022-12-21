// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mns

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

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
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/mns"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := mns.NewTopic(ctx, "topic", &mns.TopicArgs{
//				LoggingEnabled:     pulumi.Bool(false),
//				MaximumMessageSize: pulumi.Int(65536),
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
// MNS Topic can be imported using the id or name, e.g.
//
// ```sh
//
//	$ pulumi import alicloud:mns/topic:Topic topic topicName
//
// ```
type Topic struct {
	pulumi.CustomResourceState

	// Is logging enabled? true or false. Default value to false.
	LoggingEnabled pulumi.BoolPtrOutput `pulumi:"loggingEnabled"`
	// This indicates the maximum length, in bytes, of any message body sent to the topic. Valid value range: 1024-65536, i.e., 1K to 64K. Default value to 65536.
	MaximumMessageSize pulumi.IntPtrOutput `pulumi:"maximumMessageSize"`
	// Two topics on a single account in the same region cannot have the same name. A topic name must start with an English letter or a digit, and can contain English letters, digits, and hyphens, with the length not exceeding 256 characters.
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewTopic registers a new resource with the given unique name, arguments, and options.
func NewTopic(ctx *pulumi.Context,
	name string, args *TopicArgs, opts ...pulumi.ResourceOption) (*Topic, error) {
	if args == nil {
		args = &TopicArgs{}
	}

	opts = pkgResourceDefaultOpts(opts)
	var resource Topic
	err := ctx.RegisterResource("alicloud:mns/topic:Topic", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTopic gets an existing Topic resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTopic(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TopicState, opts ...pulumi.ResourceOption) (*Topic, error) {
	var resource Topic
	err := ctx.ReadResource("alicloud:mns/topic:Topic", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Topic resources.
type topicState struct {
	// Is logging enabled? true or false. Default value to false.
	LoggingEnabled *bool `pulumi:"loggingEnabled"`
	// This indicates the maximum length, in bytes, of any message body sent to the topic. Valid value range: 1024-65536, i.e., 1K to 64K. Default value to 65536.
	MaximumMessageSize *int `pulumi:"maximumMessageSize"`
	// Two topics on a single account in the same region cannot have the same name. A topic name must start with an English letter or a digit, and can contain English letters, digits, and hyphens, with the length not exceeding 256 characters.
	Name *string `pulumi:"name"`
}

type TopicState struct {
	// Is logging enabled? true or false. Default value to false.
	LoggingEnabled pulumi.BoolPtrInput
	// This indicates the maximum length, in bytes, of any message body sent to the topic. Valid value range: 1024-65536, i.e., 1K to 64K. Default value to 65536.
	MaximumMessageSize pulumi.IntPtrInput
	// Two topics on a single account in the same region cannot have the same name. A topic name must start with an English letter or a digit, and can contain English letters, digits, and hyphens, with the length not exceeding 256 characters.
	Name pulumi.StringPtrInput
}

func (TopicState) ElementType() reflect.Type {
	return reflect.TypeOf((*topicState)(nil)).Elem()
}

type topicArgs struct {
	// Is logging enabled? true or false. Default value to false.
	LoggingEnabled *bool `pulumi:"loggingEnabled"`
	// This indicates the maximum length, in bytes, of any message body sent to the topic. Valid value range: 1024-65536, i.e., 1K to 64K. Default value to 65536.
	MaximumMessageSize *int `pulumi:"maximumMessageSize"`
	// Two topics on a single account in the same region cannot have the same name. A topic name must start with an English letter or a digit, and can contain English letters, digits, and hyphens, with the length not exceeding 256 characters.
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a Topic resource.
type TopicArgs struct {
	// Is logging enabled? true or false. Default value to false.
	LoggingEnabled pulumi.BoolPtrInput
	// This indicates the maximum length, in bytes, of any message body sent to the topic. Valid value range: 1024-65536, i.e., 1K to 64K. Default value to 65536.
	MaximumMessageSize pulumi.IntPtrInput
	// Two topics on a single account in the same region cannot have the same name. A topic name must start with an English letter or a digit, and can contain English letters, digits, and hyphens, with the length not exceeding 256 characters.
	Name pulumi.StringPtrInput
}

func (TopicArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*topicArgs)(nil)).Elem()
}

type TopicInput interface {
	pulumi.Input

	ToTopicOutput() TopicOutput
	ToTopicOutputWithContext(ctx context.Context) TopicOutput
}

func (*Topic) ElementType() reflect.Type {
	return reflect.TypeOf((**Topic)(nil)).Elem()
}

func (i *Topic) ToTopicOutput() TopicOutput {
	return i.ToTopicOutputWithContext(context.Background())
}

func (i *Topic) ToTopicOutputWithContext(ctx context.Context) TopicOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TopicOutput)
}

// TopicArrayInput is an input type that accepts TopicArray and TopicArrayOutput values.
// You can construct a concrete instance of `TopicArrayInput` via:
//
//	TopicArray{ TopicArgs{...} }
type TopicArrayInput interface {
	pulumi.Input

	ToTopicArrayOutput() TopicArrayOutput
	ToTopicArrayOutputWithContext(context.Context) TopicArrayOutput
}

type TopicArray []TopicInput

func (TopicArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Topic)(nil)).Elem()
}

func (i TopicArray) ToTopicArrayOutput() TopicArrayOutput {
	return i.ToTopicArrayOutputWithContext(context.Background())
}

func (i TopicArray) ToTopicArrayOutputWithContext(ctx context.Context) TopicArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TopicArrayOutput)
}

// TopicMapInput is an input type that accepts TopicMap and TopicMapOutput values.
// You can construct a concrete instance of `TopicMapInput` via:
//
//	TopicMap{ "key": TopicArgs{...} }
type TopicMapInput interface {
	pulumi.Input

	ToTopicMapOutput() TopicMapOutput
	ToTopicMapOutputWithContext(context.Context) TopicMapOutput
}

type TopicMap map[string]TopicInput

func (TopicMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Topic)(nil)).Elem()
}

func (i TopicMap) ToTopicMapOutput() TopicMapOutput {
	return i.ToTopicMapOutputWithContext(context.Background())
}

func (i TopicMap) ToTopicMapOutputWithContext(ctx context.Context) TopicMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TopicMapOutput)
}

type TopicOutput struct{ *pulumi.OutputState }

func (TopicOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Topic)(nil)).Elem()
}

func (o TopicOutput) ToTopicOutput() TopicOutput {
	return o
}

func (o TopicOutput) ToTopicOutputWithContext(ctx context.Context) TopicOutput {
	return o
}

// Is logging enabled? true or false. Default value to false.
func (o TopicOutput) LoggingEnabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Topic) pulumi.BoolPtrOutput { return v.LoggingEnabled }).(pulumi.BoolPtrOutput)
}

// This indicates the maximum length, in bytes, of any message body sent to the topic. Valid value range: 1024-65536, i.e., 1K to 64K. Default value to 65536.
func (o TopicOutput) MaximumMessageSize() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Topic) pulumi.IntPtrOutput { return v.MaximumMessageSize }).(pulumi.IntPtrOutput)
}

// Two topics on a single account in the same region cannot have the same name. A topic name must start with an English letter or a digit, and can contain English letters, digits, and hyphens, with the length not exceeding 256 characters.
func (o TopicOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Topic) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

type TopicArrayOutput struct{ *pulumi.OutputState }

func (TopicArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Topic)(nil)).Elem()
}

func (o TopicArrayOutput) ToTopicArrayOutput() TopicArrayOutput {
	return o
}

func (o TopicArrayOutput) ToTopicArrayOutputWithContext(ctx context.Context) TopicArrayOutput {
	return o
}

func (o TopicArrayOutput) Index(i pulumi.IntInput) TopicOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Topic {
		return vs[0].([]*Topic)[vs[1].(int)]
	}).(TopicOutput)
}

type TopicMapOutput struct{ *pulumi.OutputState }

func (TopicMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Topic)(nil)).Elem()
}

func (o TopicMapOutput) ToTopicMapOutput() TopicMapOutput {
	return o
}

func (o TopicMapOutput) ToTopicMapOutputWithContext(ctx context.Context) TopicMapOutput {
	return o
}

func (o TopicMapOutput) MapIndex(k pulumi.StringInput) TopicOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Topic {
		return vs[0].(map[string]*Topic)[vs[1].(string)]
	}).(TopicOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TopicInput)(nil)).Elem(), &Topic{})
	pulumi.RegisterInputType(reflect.TypeOf((*TopicArrayInput)(nil)).Elem(), TopicArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*TopicMapInput)(nil)).Elem(), TopicMap{})
	pulumi.RegisterOutputType(TopicOutput{})
	pulumi.RegisterOutputType(TopicArrayOutput{})
	pulumi.RegisterOutputType(TopicMapOutput{})
}