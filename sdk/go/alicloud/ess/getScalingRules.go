// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ess

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides available scaling rule resources.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-alicloud/sdk/go/alicloud/ess"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/ess"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			scalingrulesDs, err := ess.GetScalingRules(ctx, &ess.GetScalingRulesArgs{
//				Ids: []string{
//					"scaling_rule_id1",
//					"scaling_rule_id2",
//				},
//				NameRegex:      pulumi.StringRef("scaling_rule_name"),
//				ScalingGroupId: pulumi.StringRef("scaling_group_id"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("firstScalingRule", scalingrulesDs.Rules[0].Id)
//			return nil
//		})
//	}
//
// ```
func GetScalingRules(ctx *pulumi.Context, args *GetScalingRulesArgs, opts ...pulumi.InvokeOption) (*GetScalingRulesResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetScalingRulesResult
	err := ctx.Invoke("alicloud:ess/getScalingRules:getScalingRules", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getScalingRules.
type GetScalingRulesArgs struct {
	// A list of scaling rule IDs.
	Ids []string `pulumi:"ids"`
	// A regex string to filter resulting scaling rules by name.
	NameRegex  *string `pulumi:"nameRegex"`
	OutputFile *string `pulumi:"outputFile"`
	// Scaling group id the scaling rules belong to.
	ScalingGroupId *string `pulumi:"scalingGroupId"`
	// Type of scaling rule.
	Type *string `pulumi:"type"`
}

// A collection of values returned by getScalingRules.
type GetScalingRulesResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// A list of scaling rule ids.
	Ids       []string `pulumi:"ids"`
	NameRegex *string  `pulumi:"nameRegex"`
	// A list of scaling rule names.
	Names      []string `pulumi:"names"`
	OutputFile *string  `pulumi:"outputFile"`
	// A list of scaling rules. Each element contains the following attributes:
	Rules []GetScalingRulesRule `pulumi:"rules"`
	// ID of the scaling group.
	ScalingGroupId *string `pulumi:"scalingGroupId"`
	// Type of the scaling rule.
	Type *string `pulumi:"type"`
}

func GetScalingRulesOutput(ctx *pulumi.Context, args GetScalingRulesOutputArgs, opts ...pulumi.InvokeOption) GetScalingRulesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetScalingRulesResult, error) {
			args := v.(GetScalingRulesArgs)
			r, err := GetScalingRules(ctx, &args, opts...)
			var s GetScalingRulesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetScalingRulesResultOutput)
}

// A collection of arguments for invoking getScalingRules.
type GetScalingRulesOutputArgs struct {
	// A list of scaling rule IDs.
	Ids pulumi.StringArrayInput `pulumi:"ids"`
	// A regex string to filter resulting scaling rules by name.
	NameRegex  pulumi.StringPtrInput `pulumi:"nameRegex"`
	OutputFile pulumi.StringPtrInput `pulumi:"outputFile"`
	// Scaling group id the scaling rules belong to.
	ScalingGroupId pulumi.StringPtrInput `pulumi:"scalingGroupId"`
	// Type of scaling rule.
	Type pulumi.StringPtrInput `pulumi:"type"`
}

func (GetScalingRulesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetScalingRulesArgs)(nil)).Elem()
}

// A collection of values returned by getScalingRules.
type GetScalingRulesResultOutput struct{ *pulumi.OutputState }

func (GetScalingRulesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetScalingRulesResult)(nil)).Elem()
}

func (o GetScalingRulesResultOutput) ToGetScalingRulesResultOutput() GetScalingRulesResultOutput {
	return o
}

func (o GetScalingRulesResultOutput) ToGetScalingRulesResultOutputWithContext(ctx context.Context) GetScalingRulesResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetScalingRulesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetScalingRulesResult) string { return v.Id }).(pulumi.StringOutput)
}

// A list of scaling rule ids.
func (o GetScalingRulesResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetScalingRulesResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

func (o GetScalingRulesResultOutput) NameRegex() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetScalingRulesResult) *string { return v.NameRegex }).(pulumi.StringPtrOutput)
}

// A list of scaling rule names.
func (o GetScalingRulesResultOutput) Names() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetScalingRulesResult) []string { return v.Names }).(pulumi.StringArrayOutput)
}

func (o GetScalingRulesResultOutput) OutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetScalingRulesResult) *string { return v.OutputFile }).(pulumi.StringPtrOutput)
}

// A list of scaling rules. Each element contains the following attributes:
func (o GetScalingRulesResultOutput) Rules() GetScalingRulesRuleArrayOutput {
	return o.ApplyT(func(v GetScalingRulesResult) []GetScalingRulesRule { return v.Rules }).(GetScalingRulesRuleArrayOutput)
}

// ID of the scaling group.
func (o GetScalingRulesResultOutput) ScalingGroupId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetScalingRulesResult) *string { return v.ScalingGroupId }).(pulumi.StringPtrOutput)
}

// Type of the scaling rule.
func (o GetScalingRulesResultOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetScalingRulesResult) *string { return v.Type }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetScalingRulesResultOutput{})
}