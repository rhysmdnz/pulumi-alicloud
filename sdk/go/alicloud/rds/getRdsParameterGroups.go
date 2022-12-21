// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package rds

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetRdsParameterGroups(ctx *pulumi.Context, args *GetRdsParameterGroupsArgs, opts ...pulumi.InvokeOption) (*GetRdsParameterGroupsResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetRdsParameterGroupsResult
	err := ctx.Invoke("alicloud:rds/getRdsParameterGroups:getRdsParameterGroups", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRdsParameterGroups.
type GetRdsParameterGroupsArgs struct {
	EnableDetails *bool    `pulumi:"enableDetails"`
	Ids           []string `pulumi:"ids"`
	NameRegex     *string  `pulumi:"nameRegex"`
	OutputFile    *string  `pulumi:"outputFile"`
}

// A collection of values returned by getRdsParameterGroups.
type GetRdsParameterGroupsResult struct {
	EnableDetails *bool                        `pulumi:"enableDetails"`
	Groups        []GetRdsParameterGroupsGroup `pulumi:"groups"`
	// The provider-assigned unique ID for this managed resource.
	Id         string   `pulumi:"id"`
	Ids        []string `pulumi:"ids"`
	NameRegex  *string  `pulumi:"nameRegex"`
	Names      []string `pulumi:"names"`
	OutputFile *string  `pulumi:"outputFile"`
}

func GetRdsParameterGroupsOutput(ctx *pulumi.Context, args GetRdsParameterGroupsOutputArgs, opts ...pulumi.InvokeOption) GetRdsParameterGroupsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetRdsParameterGroupsResult, error) {
			args := v.(GetRdsParameterGroupsArgs)
			r, err := GetRdsParameterGroups(ctx, &args, opts...)
			var s GetRdsParameterGroupsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetRdsParameterGroupsResultOutput)
}

// A collection of arguments for invoking getRdsParameterGroups.
type GetRdsParameterGroupsOutputArgs struct {
	EnableDetails pulumi.BoolPtrInput     `pulumi:"enableDetails"`
	Ids           pulumi.StringArrayInput `pulumi:"ids"`
	NameRegex     pulumi.StringPtrInput   `pulumi:"nameRegex"`
	OutputFile    pulumi.StringPtrInput   `pulumi:"outputFile"`
}

func (GetRdsParameterGroupsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRdsParameterGroupsArgs)(nil)).Elem()
}

// A collection of values returned by getRdsParameterGroups.
type GetRdsParameterGroupsResultOutput struct{ *pulumi.OutputState }

func (GetRdsParameterGroupsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRdsParameterGroupsResult)(nil)).Elem()
}

func (o GetRdsParameterGroupsResultOutput) ToGetRdsParameterGroupsResultOutput() GetRdsParameterGroupsResultOutput {
	return o
}

func (o GetRdsParameterGroupsResultOutput) ToGetRdsParameterGroupsResultOutputWithContext(ctx context.Context) GetRdsParameterGroupsResultOutput {
	return o
}

func (o GetRdsParameterGroupsResultOutput) EnableDetails() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v GetRdsParameterGroupsResult) *bool { return v.EnableDetails }).(pulumi.BoolPtrOutput)
}

func (o GetRdsParameterGroupsResultOutput) Groups() GetRdsParameterGroupsGroupArrayOutput {
	return o.ApplyT(func(v GetRdsParameterGroupsResult) []GetRdsParameterGroupsGroup { return v.Groups }).(GetRdsParameterGroupsGroupArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetRdsParameterGroupsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetRdsParameterGroupsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetRdsParameterGroupsResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetRdsParameterGroupsResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

func (o GetRdsParameterGroupsResultOutput) NameRegex() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRdsParameterGroupsResult) *string { return v.NameRegex }).(pulumi.StringPtrOutput)
}

func (o GetRdsParameterGroupsResultOutput) Names() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetRdsParameterGroupsResult) []string { return v.Names }).(pulumi.StringArrayOutput)
}

func (o GetRdsParameterGroupsResultOutput) OutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRdsParameterGroupsResult) *string { return v.OutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetRdsParameterGroupsResultOutput{})
}