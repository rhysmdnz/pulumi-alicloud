// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package quotas

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides the Quotas Quota Applications of the current Alibaba Cloud user.
//
// > **NOTE:** Available in v1.117.0+.
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
//	"github.com/pulumi/pulumi-alicloud/sdk/go/alicloud/quotas"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/quotas"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			example, err := quotas.GetQuotaApplications(ctx, &quotas.GetQuotaApplicationsArgs{
//				ProductCode: "ess",
//				Ids: []string{
//					"4621F886-81E9-xxxx-xxxx",
//				},
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("firstQuotasQuotaApplicationId", example.Applications[0].Id)
//			return nil
//		})
//	}
//
// ```
func GetQuotaApplications(ctx *pulumi.Context, args *GetQuotaApplicationsArgs, opts ...pulumi.InvokeOption) (*GetQuotaApplicationsResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetQuotaApplicationsResult
	err := ctx.Invoke("alicloud:quotas/getQuotaApplications:getQuotaApplications", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getQuotaApplications.
type GetQuotaApplicationsArgs struct {
	// The quota dimensions.
	Dimensions []GetQuotaApplicationsDimension `pulumi:"dimensions"`
	// Default to `false`. Set it to `true` can output more details about resource attributes.
	EnableDetails *bool `pulumi:"enableDetails"`
	// A list of Application Info IDs.
	Ids        []string `pulumi:"ids"`
	KeyWord    *string  `pulumi:"keyWord"`
	OutputFile *string  `pulumi:"outputFile"`
	// The product code.
	ProductCode string `pulumi:"productCode"`
	// The ID of quota action..
	QuotaActionCode *string `pulumi:"quotaActionCode"`
	// The quota category. Valid values: `CommonQuota`, `FlowControl`.
	QuotaCategory *string `pulumi:"quotaCategory"`
	// The status of the quota application.
	Status *string `pulumi:"status"`
}

// A collection of values returned by getQuotaApplications.
type GetQuotaApplicationsResult struct {
	Applications  []GetQuotaApplicationsApplication `pulumi:"applications"`
	Dimensions    []GetQuotaApplicationsDimension   `pulumi:"dimensions"`
	EnableDetails *bool                             `pulumi:"enableDetails"`
	// The provider-assigned unique ID for this managed resource.
	Id              string   `pulumi:"id"`
	Ids             []string `pulumi:"ids"`
	KeyWord         *string  `pulumi:"keyWord"`
	OutputFile      *string  `pulumi:"outputFile"`
	ProductCode     string   `pulumi:"productCode"`
	QuotaActionCode *string  `pulumi:"quotaActionCode"`
	QuotaCategory   *string  `pulumi:"quotaCategory"`
	Status          *string  `pulumi:"status"`
}

func GetQuotaApplicationsOutput(ctx *pulumi.Context, args GetQuotaApplicationsOutputArgs, opts ...pulumi.InvokeOption) GetQuotaApplicationsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetQuotaApplicationsResult, error) {
			args := v.(GetQuotaApplicationsArgs)
			r, err := GetQuotaApplications(ctx, &args, opts...)
			var s GetQuotaApplicationsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetQuotaApplicationsResultOutput)
}

// A collection of arguments for invoking getQuotaApplications.
type GetQuotaApplicationsOutputArgs struct {
	// The quota dimensions.
	Dimensions GetQuotaApplicationsDimensionArrayInput `pulumi:"dimensions"`
	// Default to `false`. Set it to `true` can output more details about resource attributes.
	EnableDetails pulumi.BoolPtrInput `pulumi:"enableDetails"`
	// A list of Application Info IDs.
	Ids        pulumi.StringArrayInput `pulumi:"ids"`
	KeyWord    pulumi.StringPtrInput   `pulumi:"keyWord"`
	OutputFile pulumi.StringPtrInput   `pulumi:"outputFile"`
	// The product code.
	ProductCode pulumi.StringInput `pulumi:"productCode"`
	// The ID of quota action..
	QuotaActionCode pulumi.StringPtrInput `pulumi:"quotaActionCode"`
	// The quota category. Valid values: `CommonQuota`, `FlowControl`.
	QuotaCategory pulumi.StringPtrInput `pulumi:"quotaCategory"`
	// The status of the quota application.
	Status pulumi.StringPtrInput `pulumi:"status"`
}

func (GetQuotaApplicationsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetQuotaApplicationsArgs)(nil)).Elem()
}

// A collection of values returned by getQuotaApplications.
type GetQuotaApplicationsResultOutput struct{ *pulumi.OutputState }

func (GetQuotaApplicationsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetQuotaApplicationsResult)(nil)).Elem()
}

func (o GetQuotaApplicationsResultOutput) ToGetQuotaApplicationsResultOutput() GetQuotaApplicationsResultOutput {
	return o
}

func (o GetQuotaApplicationsResultOutput) ToGetQuotaApplicationsResultOutputWithContext(ctx context.Context) GetQuotaApplicationsResultOutput {
	return o
}

func (o GetQuotaApplicationsResultOutput) Applications() GetQuotaApplicationsApplicationArrayOutput {
	return o.ApplyT(func(v GetQuotaApplicationsResult) []GetQuotaApplicationsApplication { return v.Applications }).(GetQuotaApplicationsApplicationArrayOutput)
}

func (o GetQuotaApplicationsResultOutput) Dimensions() GetQuotaApplicationsDimensionArrayOutput {
	return o.ApplyT(func(v GetQuotaApplicationsResult) []GetQuotaApplicationsDimension { return v.Dimensions }).(GetQuotaApplicationsDimensionArrayOutput)
}

func (o GetQuotaApplicationsResultOutput) EnableDetails() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v GetQuotaApplicationsResult) *bool { return v.EnableDetails }).(pulumi.BoolPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetQuotaApplicationsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetQuotaApplicationsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetQuotaApplicationsResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetQuotaApplicationsResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

func (o GetQuotaApplicationsResultOutput) KeyWord() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetQuotaApplicationsResult) *string { return v.KeyWord }).(pulumi.StringPtrOutput)
}

func (o GetQuotaApplicationsResultOutput) OutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetQuotaApplicationsResult) *string { return v.OutputFile }).(pulumi.StringPtrOutput)
}

func (o GetQuotaApplicationsResultOutput) ProductCode() pulumi.StringOutput {
	return o.ApplyT(func(v GetQuotaApplicationsResult) string { return v.ProductCode }).(pulumi.StringOutput)
}

func (o GetQuotaApplicationsResultOutput) QuotaActionCode() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetQuotaApplicationsResult) *string { return v.QuotaActionCode }).(pulumi.StringPtrOutput)
}

func (o GetQuotaApplicationsResultOutput) QuotaCategory() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetQuotaApplicationsResult) *string { return v.QuotaCategory }).(pulumi.StringPtrOutput)
}

func (o GetQuotaApplicationsResultOutput) Status() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetQuotaApplicationsResult) *string { return v.Status }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetQuotaApplicationsResultOutput{})
}