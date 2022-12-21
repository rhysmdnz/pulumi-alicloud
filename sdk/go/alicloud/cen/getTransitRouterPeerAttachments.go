// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cen

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides CEN Transit Router peer attachments available to the user.
//
// > **NOTE:** Available in 1.128.0+
func GetTransitRouterPeerAttachments(ctx *pulumi.Context, args *GetTransitRouterPeerAttachmentsArgs, opts ...pulumi.InvokeOption) (*GetTransitRouterPeerAttachmentsResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetTransitRouterPeerAttachmentsResult
	err := ctx.Invoke("alicloud:cen/getTransitRouterPeerAttachments:getTransitRouterPeerAttachments", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getTransitRouterPeerAttachments.
type GetTransitRouterPeerAttachmentsArgs struct {
	// ID of the CEN instance.
	CenId string `pulumi:"cenId"`
	// A list of CEN Transit Router peer attachments IDs.
	Ids []string `pulumi:"ids"`
	// A regex string to filter CEN Transit Router peer attachments by name.
	NameRegex  *string `pulumi:"nameRegex"`
	OutputFile *string `pulumi:"outputFile"`
	// The status of CEN Transit Router peer attachment. Valid values `Attached`, `Attaching` and `Detaching`.
	Status *string `pulumi:"status"`
	// The ID of CEN Transit Router peer attachments.
	TransitRouterAttachmentId *string `pulumi:"transitRouterAttachmentId"`
	// The ID of transit router.
	TransitRouterId *string `pulumi:"transitRouterId"`
}

// A collection of values returned by getTransitRouterPeerAttachments.
type GetTransitRouterPeerAttachmentsResult struct {
	Attachments []GetTransitRouterPeerAttachmentsAttachment `pulumi:"attachments"`
	CenId       string                                      `pulumi:"cenId"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// A list of CEN Transit Router peer attachments IDs.
	Ids       []string `pulumi:"ids"`
	NameRegex *string  `pulumi:"nameRegex"`
	// A list of CEN Transit Router peer attachments names.
	Names      []string `pulumi:"names"`
	OutputFile *string  `pulumi:"outputFile"`
	// The status of the transit router attachment.
	Status *string `pulumi:"status"`
	// ID of the transit router attachment.
	TransitRouterAttachmentId *string `pulumi:"transitRouterAttachmentId"`
	// ID of the transit router.
	TransitRouterId *string `pulumi:"transitRouterId"`
}

func GetTransitRouterPeerAttachmentsOutput(ctx *pulumi.Context, args GetTransitRouterPeerAttachmentsOutputArgs, opts ...pulumi.InvokeOption) GetTransitRouterPeerAttachmentsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetTransitRouterPeerAttachmentsResult, error) {
			args := v.(GetTransitRouterPeerAttachmentsArgs)
			r, err := GetTransitRouterPeerAttachments(ctx, &args, opts...)
			var s GetTransitRouterPeerAttachmentsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetTransitRouterPeerAttachmentsResultOutput)
}

// A collection of arguments for invoking getTransitRouterPeerAttachments.
type GetTransitRouterPeerAttachmentsOutputArgs struct {
	// ID of the CEN instance.
	CenId pulumi.StringInput `pulumi:"cenId"`
	// A list of CEN Transit Router peer attachments IDs.
	Ids pulumi.StringArrayInput `pulumi:"ids"`
	// A regex string to filter CEN Transit Router peer attachments by name.
	NameRegex  pulumi.StringPtrInput `pulumi:"nameRegex"`
	OutputFile pulumi.StringPtrInput `pulumi:"outputFile"`
	// The status of CEN Transit Router peer attachment. Valid values `Attached`, `Attaching` and `Detaching`.
	Status pulumi.StringPtrInput `pulumi:"status"`
	// The ID of CEN Transit Router peer attachments.
	TransitRouterAttachmentId pulumi.StringPtrInput `pulumi:"transitRouterAttachmentId"`
	// The ID of transit router.
	TransitRouterId pulumi.StringPtrInput `pulumi:"transitRouterId"`
}

func (GetTransitRouterPeerAttachmentsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTransitRouterPeerAttachmentsArgs)(nil)).Elem()
}

// A collection of values returned by getTransitRouterPeerAttachments.
type GetTransitRouterPeerAttachmentsResultOutput struct{ *pulumi.OutputState }

func (GetTransitRouterPeerAttachmentsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTransitRouterPeerAttachmentsResult)(nil)).Elem()
}

func (o GetTransitRouterPeerAttachmentsResultOutput) ToGetTransitRouterPeerAttachmentsResultOutput() GetTransitRouterPeerAttachmentsResultOutput {
	return o
}

func (o GetTransitRouterPeerAttachmentsResultOutput) ToGetTransitRouterPeerAttachmentsResultOutputWithContext(ctx context.Context) GetTransitRouterPeerAttachmentsResultOutput {
	return o
}

func (o GetTransitRouterPeerAttachmentsResultOutput) Attachments() GetTransitRouterPeerAttachmentsAttachmentArrayOutput {
	return o.ApplyT(func(v GetTransitRouterPeerAttachmentsResult) []GetTransitRouterPeerAttachmentsAttachment {
		return v.Attachments
	}).(GetTransitRouterPeerAttachmentsAttachmentArrayOutput)
}

func (o GetTransitRouterPeerAttachmentsResultOutput) CenId() pulumi.StringOutput {
	return o.ApplyT(func(v GetTransitRouterPeerAttachmentsResult) string { return v.CenId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetTransitRouterPeerAttachmentsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetTransitRouterPeerAttachmentsResult) string { return v.Id }).(pulumi.StringOutput)
}

// A list of CEN Transit Router peer attachments IDs.
func (o GetTransitRouterPeerAttachmentsResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetTransitRouterPeerAttachmentsResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

func (o GetTransitRouterPeerAttachmentsResultOutput) NameRegex() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetTransitRouterPeerAttachmentsResult) *string { return v.NameRegex }).(pulumi.StringPtrOutput)
}

// A list of CEN Transit Router peer attachments names.
func (o GetTransitRouterPeerAttachmentsResultOutput) Names() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetTransitRouterPeerAttachmentsResult) []string { return v.Names }).(pulumi.StringArrayOutput)
}

func (o GetTransitRouterPeerAttachmentsResultOutput) OutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetTransitRouterPeerAttachmentsResult) *string { return v.OutputFile }).(pulumi.StringPtrOutput)
}

// The status of the transit router attachment.
func (o GetTransitRouterPeerAttachmentsResultOutput) Status() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetTransitRouterPeerAttachmentsResult) *string { return v.Status }).(pulumi.StringPtrOutput)
}

// ID of the transit router attachment.
func (o GetTransitRouterPeerAttachmentsResultOutput) TransitRouterAttachmentId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetTransitRouterPeerAttachmentsResult) *string { return v.TransitRouterAttachmentId }).(pulumi.StringPtrOutput)
}

// ID of the transit router.
func (o GetTransitRouterPeerAttachmentsResultOutput) TransitRouterId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetTransitRouterPeerAttachmentsResult) *string { return v.TransitRouterId }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetTransitRouterPeerAttachmentsResultOutput{})
}