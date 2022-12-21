// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cfg

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides the Config Configuration Recorders of the current Alibaba Cloud user.
//
// > **NOTE:**  Available in 1.99.0+.
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
//	"github.com/pulumi/pulumi-alicloud/sdk/go/alicloud/cfg"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/cfg"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := cfg.GetConfigurationRecorders(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("listOfResourceTypes", data.Alicloud_config_configuration_recorders.This.Recorders[0].Resource_types)
//			return nil
//		})
//	}
//
// ```
func GetConfigurationRecorders(ctx *pulumi.Context, args *GetConfigurationRecordersArgs, opts ...pulumi.InvokeOption) (*GetConfigurationRecordersResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetConfigurationRecordersResult
	err := ctx.Invoke("alicloud:cfg/getConfigurationRecorders:getConfigurationRecorders", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getConfigurationRecorders.
type GetConfigurationRecordersArgs struct {
	OutputFile *string `pulumi:"outputFile"`
}

// A collection of values returned by getConfigurationRecorders.
type GetConfigurationRecordersResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id         string  `pulumi:"id"`
	OutputFile *string `pulumi:"outputFile"`
	// A list of Config Configuration Recorders. Each element contains the following attributes:
	Recorders []GetConfigurationRecordersRecorder `pulumi:"recorders"`
}

func GetConfigurationRecordersOutput(ctx *pulumi.Context, args GetConfigurationRecordersOutputArgs, opts ...pulumi.InvokeOption) GetConfigurationRecordersResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetConfigurationRecordersResult, error) {
			args := v.(GetConfigurationRecordersArgs)
			r, err := GetConfigurationRecorders(ctx, &args, opts...)
			var s GetConfigurationRecordersResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetConfigurationRecordersResultOutput)
}

// A collection of arguments for invoking getConfigurationRecorders.
type GetConfigurationRecordersOutputArgs struct {
	OutputFile pulumi.StringPtrInput `pulumi:"outputFile"`
}

func (GetConfigurationRecordersOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetConfigurationRecordersArgs)(nil)).Elem()
}

// A collection of values returned by getConfigurationRecorders.
type GetConfigurationRecordersResultOutput struct{ *pulumi.OutputState }

func (GetConfigurationRecordersResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetConfigurationRecordersResult)(nil)).Elem()
}

func (o GetConfigurationRecordersResultOutput) ToGetConfigurationRecordersResultOutput() GetConfigurationRecordersResultOutput {
	return o
}

func (o GetConfigurationRecordersResultOutput) ToGetConfigurationRecordersResultOutputWithContext(ctx context.Context) GetConfigurationRecordersResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetConfigurationRecordersResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetConfigurationRecordersResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetConfigurationRecordersResultOutput) OutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetConfigurationRecordersResult) *string { return v.OutputFile }).(pulumi.StringPtrOutput)
}

// A list of Config Configuration Recorders. Each element contains the following attributes:
func (o GetConfigurationRecordersResultOutput) Recorders() GetConfigurationRecordersRecorderArrayOutput {
	return o.ApplyT(func(v GetConfigurationRecordersResult) []GetConfigurationRecordersRecorder { return v.Recorders }).(GetConfigurationRecordersRecorderArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetConfigurationRecordersResultOutput{})
}