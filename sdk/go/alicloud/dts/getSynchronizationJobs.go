// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dts

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides the Dts Synchronization Jobs of the current Alibaba Cloud user.
//
// > **NOTE:** Available in v1.138.0+.
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
//	"github.com/pulumi/pulumi-alicloud/sdk/go/alicloud/dts"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/dts"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			ids, err := dts.GetSynchronizationJobs(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("dtsSynchronizationJobId1", ids.Jobs[0].Id)
//			return nil
//		})
//	}
//
// ```
func GetSynchronizationJobs(ctx *pulumi.Context, args *GetSynchronizationJobsArgs, opts ...pulumi.InvokeOption) (*GetSynchronizationJobsResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetSynchronizationJobsResult
	err := ctx.Invoke("alicloud:dts/getSynchronizationJobs:getSynchronizationJobs", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSynchronizationJobs.
type GetSynchronizationJobsArgs struct {
	EnableDetails *bool `pulumi:"enableDetails"`
	// A list of Synchronization Job IDs.
	Ids []string `pulumi:"ids"`
	// A regex string to filter results by synchronization job name.
	NameRegex  *string `pulumi:"nameRegex"`
	OutputFile *string `pulumi:"outputFile"`
	// The status of the resource. Valid values: `Synchronizing`, `Suspending`. You can stop the task by specifying `Suspending` and start the task by specifying `Synchronizing`.
	Status *string `pulumi:"status"`
}

// A collection of values returned by getSynchronizationJobs.
type GetSynchronizationJobsResult struct {
	EnableDetails *bool `pulumi:"enableDetails"`
	// The provider-assigned unique ID for this managed resource.
	Id         string                      `pulumi:"id"`
	Ids        []string                    `pulumi:"ids"`
	Jobs       []GetSynchronizationJobsJob `pulumi:"jobs"`
	NameRegex  *string                     `pulumi:"nameRegex"`
	OutputFile *string                     `pulumi:"outputFile"`
	Status     *string                     `pulumi:"status"`
}

func GetSynchronizationJobsOutput(ctx *pulumi.Context, args GetSynchronizationJobsOutputArgs, opts ...pulumi.InvokeOption) GetSynchronizationJobsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetSynchronizationJobsResult, error) {
			args := v.(GetSynchronizationJobsArgs)
			r, err := GetSynchronizationJobs(ctx, &args, opts...)
			var s GetSynchronizationJobsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetSynchronizationJobsResultOutput)
}

// A collection of arguments for invoking getSynchronizationJobs.
type GetSynchronizationJobsOutputArgs struct {
	EnableDetails pulumi.BoolPtrInput `pulumi:"enableDetails"`
	// A list of Synchronization Job IDs.
	Ids pulumi.StringArrayInput `pulumi:"ids"`
	// A regex string to filter results by synchronization job name.
	NameRegex  pulumi.StringPtrInput `pulumi:"nameRegex"`
	OutputFile pulumi.StringPtrInput `pulumi:"outputFile"`
	// The status of the resource. Valid values: `Synchronizing`, `Suspending`. You can stop the task by specifying `Suspending` and start the task by specifying `Synchronizing`.
	Status pulumi.StringPtrInput `pulumi:"status"`
}

func (GetSynchronizationJobsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSynchronizationJobsArgs)(nil)).Elem()
}

// A collection of values returned by getSynchronizationJobs.
type GetSynchronizationJobsResultOutput struct{ *pulumi.OutputState }

func (GetSynchronizationJobsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSynchronizationJobsResult)(nil)).Elem()
}

func (o GetSynchronizationJobsResultOutput) ToGetSynchronizationJobsResultOutput() GetSynchronizationJobsResultOutput {
	return o
}

func (o GetSynchronizationJobsResultOutput) ToGetSynchronizationJobsResultOutputWithContext(ctx context.Context) GetSynchronizationJobsResultOutput {
	return o
}

func (o GetSynchronizationJobsResultOutput) EnableDetails() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v GetSynchronizationJobsResult) *bool { return v.EnableDetails }).(pulumi.BoolPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetSynchronizationJobsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetSynchronizationJobsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetSynchronizationJobsResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetSynchronizationJobsResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

func (o GetSynchronizationJobsResultOutput) Jobs() GetSynchronizationJobsJobArrayOutput {
	return o.ApplyT(func(v GetSynchronizationJobsResult) []GetSynchronizationJobsJob { return v.Jobs }).(GetSynchronizationJobsJobArrayOutput)
}

func (o GetSynchronizationJobsResultOutput) NameRegex() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSynchronizationJobsResult) *string { return v.NameRegex }).(pulumi.StringPtrOutput)
}

func (o GetSynchronizationJobsResultOutput) OutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSynchronizationJobsResult) *string { return v.OutputFile }).(pulumi.StringPtrOutput)
}

func (o GetSynchronizationJobsResultOutput) Status() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSynchronizationJobsResult) *string { return v.Status }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetSynchronizationJobsResultOutput{})
}