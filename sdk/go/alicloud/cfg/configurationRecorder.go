// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cfg

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a Alicloud Config Configuration Recorder resource. Cloud Config is a specialized service for evaluating resources. Cloud Config tracks configuration changes of your resources and evaluates configuration compliance. Cloud Config can help you evaluate numerous resources and maintain the continuous compliance of your cloud infrastructure.
// For information about Alicloud Config Configuration Recorder and how to use it, see [What is Configuration Recorder.](https://www.alibabacloud.com/help/en/doc-detail/153156.html)
//
// > **NOTE:** Available in v1.99.0+.
//
// > **NOTE:** The Cloud Config region only support `cn-shanghai` and `ap-southeast-1`.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/cfg"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := cfg.NewConfigurationRecorder(ctx, "example", &cfg.ConfigurationRecorderArgs{
//				ResourceTypes: pulumi.StringArray{
//					pulumi.String("ACS::ECS::Instance"),
//					pulumi.String("ACS::ECS::Disk"),
//				},
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
// Alicloud Config Configuration Recorder can be imported using the id, e.g.
//
// ```sh
//
//	$ pulumi import alicloud:cfg/configurationRecorder:ConfigurationRecorder example 122378463********
//
// ```
type ConfigurationRecorder struct {
	pulumi.CustomResourceState

	EnterpriseEdition pulumi.BoolOutput `pulumi:"enterpriseEdition"`
	// Enterprise version configuration audit enabled status. Values: `REGISTRABLE`: Not enabled, `BUILDING`: Building and `REGISTERED`: Enabled.
	OrganizationEnableStatus pulumi.StringOutput `pulumi:"organizationEnableStatus"`
	// The ID of the Enterprise management account.
	OrganizationMasterId pulumi.IntOutput `pulumi:"organizationMasterId"`
	// A list of resource types to be monitored. [Resource types that support Cloud Config.](https://www.alibabacloud.com/help/en/doc-detail/127411.htm)
	// * If you use an ordinary account, the `resourceTypes` supports the update operation after the process of creation is completed.
	// * If you use an enterprise account, the `resourceTypes` does not support updating.
	ResourceTypes pulumi.StringArrayOutput `pulumi:"resourceTypes"`
	// Status of resource monitoring. Values: `REGISTRABLE`: Not registered, `BUILDING`: Under construction, `REGISTERED`: Registered and `REBUILDING`: Rebuilding.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewConfigurationRecorder registers a new resource with the given unique name, arguments, and options.
func NewConfigurationRecorder(ctx *pulumi.Context,
	name string, args *ConfigurationRecorderArgs, opts ...pulumi.ResourceOption) (*ConfigurationRecorder, error) {
	if args == nil {
		args = &ConfigurationRecorderArgs{}
	}

	opts = pkgResourceDefaultOpts(opts)
	var resource ConfigurationRecorder
	err := ctx.RegisterResource("alicloud:cfg/configurationRecorder:ConfigurationRecorder", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConfigurationRecorder gets an existing ConfigurationRecorder resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConfigurationRecorder(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConfigurationRecorderState, opts ...pulumi.ResourceOption) (*ConfigurationRecorder, error) {
	var resource ConfigurationRecorder
	err := ctx.ReadResource("alicloud:cfg/configurationRecorder:ConfigurationRecorder", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConfigurationRecorder resources.
type configurationRecorderState struct {
	EnterpriseEdition *bool `pulumi:"enterpriseEdition"`
	// Enterprise version configuration audit enabled status. Values: `REGISTRABLE`: Not enabled, `BUILDING`: Building and `REGISTERED`: Enabled.
	OrganizationEnableStatus *string `pulumi:"organizationEnableStatus"`
	// The ID of the Enterprise management account.
	OrganizationMasterId *int `pulumi:"organizationMasterId"`
	// A list of resource types to be monitored. [Resource types that support Cloud Config.](https://www.alibabacloud.com/help/en/doc-detail/127411.htm)
	// * If you use an ordinary account, the `resourceTypes` supports the update operation after the process of creation is completed.
	// * If you use an enterprise account, the `resourceTypes` does not support updating.
	ResourceTypes []string `pulumi:"resourceTypes"`
	// Status of resource monitoring. Values: `REGISTRABLE`: Not registered, `BUILDING`: Under construction, `REGISTERED`: Registered and `REBUILDING`: Rebuilding.
	Status *string `pulumi:"status"`
}

type ConfigurationRecorderState struct {
	EnterpriseEdition pulumi.BoolPtrInput
	// Enterprise version configuration audit enabled status. Values: `REGISTRABLE`: Not enabled, `BUILDING`: Building and `REGISTERED`: Enabled.
	OrganizationEnableStatus pulumi.StringPtrInput
	// The ID of the Enterprise management account.
	OrganizationMasterId pulumi.IntPtrInput
	// A list of resource types to be monitored. [Resource types that support Cloud Config.](https://www.alibabacloud.com/help/en/doc-detail/127411.htm)
	// * If you use an ordinary account, the `resourceTypes` supports the update operation after the process of creation is completed.
	// * If you use an enterprise account, the `resourceTypes` does not support updating.
	ResourceTypes pulumi.StringArrayInput
	// Status of resource monitoring. Values: `REGISTRABLE`: Not registered, `BUILDING`: Under construction, `REGISTERED`: Registered and `REBUILDING`: Rebuilding.
	Status pulumi.StringPtrInput
}

func (ConfigurationRecorderState) ElementType() reflect.Type {
	return reflect.TypeOf((*configurationRecorderState)(nil)).Elem()
}

type configurationRecorderArgs struct {
	EnterpriseEdition *bool `pulumi:"enterpriseEdition"`
	// A list of resource types to be monitored. [Resource types that support Cloud Config.](https://www.alibabacloud.com/help/en/doc-detail/127411.htm)
	// * If you use an ordinary account, the `resourceTypes` supports the update operation after the process of creation is completed.
	// * If you use an enterprise account, the `resourceTypes` does not support updating.
	ResourceTypes []string `pulumi:"resourceTypes"`
}

// The set of arguments for constructing a ConfigurationRecorder resource.
type ConfigurationRecorderArgs struct {
	EnterpriseEdition pulumi.BoolPtrInput
	// A list of resource types to be monitored. [Resource types that support Cloud Config.](https://www.alibabacloud.com/help/en/doc-detail/127411.htm)
	// * If you use an ordinary account, the `resourceTypes` supports the update operation after the process of creation is completed.
	// * If you use an enterprise account, the `resourceTypes` does not support updating.
	ResourceTypes pulumi.StringArrayInput
}

func (ConfigurationRecorderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*configurationRecorderArgs)(nil)).Elem()
}

type ConfigurationRecorderInput interface {
	pulumi.Input

	ToConfigurationRecorderOutput() ConfigurationRecorderOutput
	ToConfigurationRecorderOutputWithContext(ctx context.Context) ConfigurationRecorderOutput
}

func (*ConfigurationRecorder) ElementType() reflect.Type {
	return reflect.TypeOf((**ConfigurationRecorder)(nil)).Elem()
}

func (i *ConfigurationRecorder) ToConfigurationRecorderOutput() ConfigurationRecorderOutput {
	return i.ToConfigurationRecorderOutputWithContext(context.Background())
}

func (i *ConfigurationRecorder) ToConfigurationRecorderOutputWithContext(ctx context.Context) ConfigurationRecorderOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConfigurationRecorderOutput)
}

// ConfigurationRecorderArrayInput is an input type that accepts ConfigurationRecorderArray and ConfigurationRecorderArrayOutput values.
// You can construct a concrete instance of `ConfigurationRecorderArrayInput` via:
//
//	ConfigurationRecorderArray{ ConfigurationRecorderArgs{...} }
type ConfigurationRecorderArrayInput interface {
	pulumi.Input

	ToConfigurationRecorderArrayOutput() ConfigurationRecorderArrayOutput
	ToConfigurationRecorderArrayOutputWithContext(context.Context) ConfigurationRecorderArrayOutput
}

type ConfigurationRecorderArray []ConfigurationRecorderInput

func (ConfigurationRecorderArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ConfigurationRecorder)(nil)).Elem()
}

func (i ConfigurationRecorderArray) ToConfigurationRecorderArrayOutput() ConfigurationRecorderArrayOutput {
	return i.ToConfigurationRecorderArrayOutputWithContext(context.Background())
}

func (i ConfigurationRecorderArray) ToConfigurationRecorderArrayOutputWithContext(ctx context.Context) ConfigurationRecorderArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConfigurationRecorderArrayOutput)
}

// ConfigurationRecorderMapInput is an input type that accepts ConfigurationRecorderMap and ConfigurationRecorderMapOutput values.
// You can construct a concrete instance of `ConfigurationRecorderMapInput` via:
//
//	ConfigurationRecorderMap{ "key": ConfigurationRecorderArgs{...} }
type ConfigurationRecorderMapInput interface {
	pulumi.Input

	ToConfigurationRecorderMapOutput() ConfigurationRecorderMapOutput
	ToConfigurationRecorderMapOutputWithContext(context.Context) ConfigurationRecorderMapOutput
}

type ConfigurationRecorderMap map[string]ConfigurationRecorderInput

func (ConfigurationRecorderMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ConfigurationRecorder)(nil)).Elem()
}

func (i ConfigurationRecorderMap) ToConfigurationRecorderMapOutput() ConfigurationRecorderMapOutput {
	return i.ToConfigurationRecorderMapOutputWithContext(context.Background())
}

func (i ConfigurationRecorderMap) ToConfigurationRecorderMapOutputWithContext(ctx context.Context) ConfigurationRecorderMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConfigurationRecorderMapOutput)
}

type ConfigurationRecorderOutput struct{ *pulumi.OutputState }

func (ConfigurationRecorderOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ConfigurationRecorder)(nil)).Elem()
}

func (o ConfigurationRecorderOutput) ToConfigurationRecorderOutput() ConfigurationRecorderOutput {
	return o
}

func (o ConfigurationRecorderOutput) ToConfigurationRecorderOutputWithContext(ctx context.Context) ConfigurationRecorderOutput {
	return o
}

func (o ConfigurationRecorderOutput) EnterpriseEdition() pulumi.BoolOutput {
	return o.ApplyT(func(v *ConfigurationRecorder) pulumi.BoolOutput { return v.EnterpriseEdition }).(pulumi.BoolOutput)
}

// Enterprise version configuration audit enabled status. Values: `REGISTRABLE`: Not enabled, `BUILDING`: Building and `REGISTERED`: Enabled.
func (o ConfigurationRecorderOutput) OrganizationEnableStatus() pulumi.StringOutput {
	return o.ApplyT(func(v *ConfigurationRecorder) pulumi.StringOutput { return v.OrganizationEnableStatus }).(pulumi.StringOutput)
}

// The ID of the Enterprise management account.
func (o ConfigurationRecorderOutput) OrganizationMasterId() pulumi.IntOutput {
	return o.ApplyT(func(v *ConfigurationRecorder) pulumi.IntOutput { return v.OrganizationMasterId }).(pulumi.IntOutput)
}

// A list of resource types to be monitored. [Resource types that support Cloud Config.](https://www.alibabacloud.com/help/en/doc-detail/127411.htm)
// * If you use an ordinary account, the `resourceTypes` supports the update operation after the process of creation is completed.
// * If you use an enterprise account, the `resourceTypes` does not support updating.
func (o ConfigurationRecorderOutput) ResourceTypes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ConfigurationRecorder) pulumi.StringArrayOutput { return v.ResourceTypes }).(pulumi.StringArrayOutput)
}

// Status of resource monitoring. Values: `REGISTRABLE`: Not registered, `BUILDING`: Under construction, `REGISTERED`: Registered and `REBUILDING`: Rebuilding.
func (o ConfigurationRecorderOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *ConfigurationRecorder) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type ConfigurationRecorderArrayOutput struct{ *pulumi.OutputState }

func (ConfigurationRecorderArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ConfigurationRecorder)(nil)).Elem()
}

func (o ConfigurationRecorderArrayOutput) ToConfigurationRecorderArrayOutput() ConfigurationRecorderArrayOutput {
	return o
}

func (o ConfigurationRecorderArrayOutput) ToConfigurationRecorderArrayOutputWithContext(ctx context.Context) ConfigurationRecorderArrayOutput {
	return o
}

func (o ConfigurationRecorderArrayOutput) Index(i pulumi.IntInput) ConfigurationRecorderOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ConfigurationRecorder {
		return vs[0].([]*ConfigurationRecorder)[vs[1].(int)]
	}).(ConfigurationRecorderOutput)
}

type ConfigurationRecorderMapOutput struct{ *pulumi.OutputState }

func (ConfigurationRecorderMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ConfigurationRecorder)(nil)).Elem()
}

func (o ConfigurationRecorderMapOutput) ToConfigurationRecorderMapOutput() ConfigurationRecorderMapOutput {
	return o
}

func (o ConfigurationRecorderMapOutput) ToConfigurationRecorderMapOutputWithContext(ctx context.Context) ConfigurationRecorderMapOutput {
	return o
}

func (o ConfigurationRecorderMapOutput) MapIndex(k pulumi.StringInput) ConfigurationRecorderOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ConfigurationRecorder {
		return vs[0].(map[string]*ConfigurationRecorder)[vs[1].(string)]
	}).(ConfigurationRecorderOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ConfigurationRecorderInput)(nil)).Elem(), &ConfigurationRecorder{})
	pulumi.RegisterInputType(reflect.TypeOf((*ConfigurationRecorderArrayInput)(nil)).Elem(), ConfigurationRecorderArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ConfigurationRecorderMapInput)(nil)).Elem(), ConfigurationRecorderMap{})
	pulumi.RegisterOutputType(ConfigurationRecorderOutput{})
	pulumi.RegisterOutputType(ConfigurationRecorderArrayOutput{})
	pulumi.RegisterOutputType(ConfigurationRecorderMapOutput{})
}