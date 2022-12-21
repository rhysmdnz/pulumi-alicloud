// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package brain

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides the Brain Industrial Pid Projects of the current Alibaba Cloud user.
//
// > **NOTE:** Available in v1.113.0+.
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
//	"github.com/pulumi/pulumi-alicloud/sdk/go/alicloud/brain"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/brain"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			example, err := brain.GetIndustrialPidProjects(ctx, &brain.GetIndustrialPidProjectsArgs{
//				Ids: []string{
//					"3e74e684-cbb5-xxxx",
//				},
//				NameRegex: pulumi.StringRef("tf-testAcc"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("firstBrainIndustrialPidProjectId", example.Projects[0].Id)
//			return nil
//		})
//	}
//
// ```
func GetIndustrialPidProjects(ctx *pulumi.Context, args *GetIndustrialPidProjectsArgs, opts ...pulumi.InvokeOption) (*GetIndustrialPidProjectsResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetIndustrialPidProjectsResult
	err := ctx.Invoke("alicloud:brain/getIndustrialPidProjects:getIndustrialPidProjects", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getIndustrialPidProjects.
type GetIndustrialPidProjectsArgs struct {
	// A list of Pid Project IDs.
	Ids []string `pulumi:"ids"`
	// A regex string to filter results by Pid Project name.
	NameRegex  *string `pulumi:"nameRegex"`
	OutputFile *string `pulumi:"outputFile"`
	// The ID of Pid Organization.
	PidOrganizationId *string `pulumi:"pidOrganizationId"`
	// The name of Pid Project.
	PidProjectName *string `pulumi:"pidProjectName"`
}

// A collection of values returned by getIndustrialPidProjects.
type GetIndustrialPidProjectsResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id                string                            `pulumi:"id"`
	Ids               []string                          `pulumi:"ids"`
	NameRegex         *string                           `pulumi:"nameRegex"`
	Names             []string                          `pulumi:"names"`
	OutputFile        *string                           `pulumi:"outputFile"`
	PidOrganizationId *string                           `pulumi:"pidOrganizationId"`
	PidProjectName    *string                           `pulumi:"pidProjectName"`
	Projects          []GetIndustrialPidProjectsProject `pulumi:"projects"`
}

func GetIndustrialPidProjectsOutput(ctx *pulumi.Context, args GetIndustrialPidProjectsOutputArgs, opts ...pulumi.InvokeOption) GetIndustrialPidProjectsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetIndustrialPidProjectsResult, error) {
			args := v.(GetIndustrialPidProjectsArgs)
			r, err := GetIndustrialPidProjects(ctx, &args, opts...)
			var s GetIndustrialPidProjectsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetIndustrialPidProjectsResultOutput)
}

// A collection of arguments for invoking getIndustrialPidProjects.
type GetIndustrialPidProjectsOutputArgs struct {
	// A list of Pid Project IDs.
	Ids pulumi.StringArrayInput `pulumi:"ids"`
	// A regex string to filter results by Pid Project name.
	NameRegex  pulumi.StringPtrInput `pulumi:"nameRegex"`
	OutputFile pulumi.StringPtrInput `pulumi:"outputFile"`
	// The ID of Pid Organization.
	PidOrganizationId pulumi.StringPtrInput `pulumi:"pidOrganizationId"`
	// The name of Pid Project.
	PidProjectName pulumi.StringPtrInput `pulumi:"pidProjectName"`
}

func (GetIndustrialPidProjectsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetIndustrialPidProjectsArgs)(nil)).Elem()
}

// A collection of values returned by getIndustrialPidProjects.
type GetIndustrialPidProjectsResultOutput struct{ *pulumi.OutputState }

func (GetIndustrialPidProjectsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetIndustrialPidProjectsResult)(nil)).Elem()
}

func (o GetIndustrialPidProjectsResultOutput) ToGetIndustrialPidProjectsResultOutput() GetIndustrialPidProjectsResultOutput {
	return o
}

func (o GetIndustrialPidProjectsResultOutput) ToGetIndustrialPidProjectsResultOutputWithContext(ctx context.Context) GetIndustrialPidProjectsResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetIndustrialPidProjectsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetIndustrialPidProjectsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetIndustrialPidProjectsResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetIndustrialPidProjectsResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

func (o GetIndustrialPidProjectsResultOutput) NameRegex() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetIndustrialPidProjectsResult) *string { return v.NameRegex }).(pulumi.StringPtrOutput)
}

func (o GetIndustrialPidProjectsResultOutput) Names() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetIndustrialPidProjectsResult) []string { return v.Names }).(pulumi.StringArrayOutput)
}

func (o GetIndustrialPidProjectsResultOutput) OutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetIndustrialPidProjectsResult) *string { return v.OutputFile }).(pulumi.StringPtrOutput)
}

func (o GetIndustrialPidProjectsResultOutput) PidOrganizationId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetIndustrialPidProjectsResult) *string { return v.PidOrganizationId }).(pulumi.StringPtrOutput)
}

func (o GetIndustrialPidProjectsResultOutput) PidProjectName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetIndustrialPidProjectsResult) *string { return v.PidProjectName }).(pulumi.StringPtrOutput)
}

func (o GetIndustrialPidProjectsResultOutput) Projects() GetIndustrialPidProjectsProjectArrayOutput {
	return o.ApplyT(func(v GetIndustrialPidProjectsResult) []GetIndustrialPidProjectsProject { return v.Projects }).(GetIndustrialPidProjectsProjectArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetIndustrialPidProjectsResultOutput{})
}