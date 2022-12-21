// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dataworks

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides the Data Works Folders of the current Alibaba Cloud user.
//
// > **NOTE:** Available in v1.131.0+.
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
//	"github.com/pulumi/pulumi-alicloud/sdk/go/alicloud/dataworks"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/dataworks"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := dataworks.NewFolder(ctx, "default", &dataworks.FolderArgs{
//				ProjectId:  pulumi.String("xxxx"),
//				FolderPath: pulumi.String("Business Flow/tfTestAcc/folderDi"),
//			})
//			if err != nil {
//				return err
//			}
//			ctx.Export("dataWorksFolderId1", ids.ApplyT(func(ids dataworks.GetFoldersResult) (string, error) {
//				return ids.Folders[0].Id, nil
//			}).(pulumi.StringOutput))
//			return nil
//		})
//	}
//
// ```
func GetFolders(ctx *pulumi.Context, args *GetFoldersArgs, opts ...pulumi.InvokeOption) (*GetFoldersResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetFoldersResult
	err := ctx.Invoke("alicloud:dataworks/getFolders:getFolders", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getFolders.
type GetFoldersArgs struct {
	// A list of Folder IDs.
	Ids        []string `pulumi:"ids"`
	OutputFile *string  `pulumi:"outputFile"`
	// The parent folder path.
	ParentFolderPath string `pulumi:"parentFolderPath"`
	// The ID of the project.
	ProjectId string `pulumi:"projectId"`
}

// A collection of values returned by getFolders.
type GetFoldersResult struct {
	Folders []GetFoldersFolder `pulumi:"folders"`
	// The provider-assigned unique ID for this managed resource.
	Id               string   `pulumi:"id"`
	Ids              []string `pulumi:"ids"`
	OutputFile       *string  `pulumi:"outputFile"`
	ParentFolderPath string   `pulumi:"parentFolderPath"`
	ProjectId        string   `pulumi:"projectId"`
}

func GetFoldersOutput(ctx *pulumi.Context, args GetFoldersOutputArgs, opts ...pulumi.InvokeOption) GetFoldersResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetFoldersResult, error) {
			args := v.(GetFoldersArgs)
			r, err := GetFolders(ctx, &args, opts...)
			var s GetFoldersResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetFoldersResultOutput)
}

// A collection of arguments for invoking getFolders.
type GetFoldersOutputArgs struct {
	// A list of Folder IDs.
	Ids        pulumi.StringArrayInput `pulumi:"ids"`
	OutputFile pulumi.StringPtrInput   `pulumi:"outputFile"`
	// The parent folder path.
	ParentFolderPath pulumi.StringInput `pulumi:"parentFolderPath"`
	// The ID of the project.
	ProjectId pulumi.StringInput `pulumi:"projectId"`
}

func (GetFoldersOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetFoldersArgs)(nil)).Elem()
}

// A collection of values returned by getFolders.
type GetFoldersResultOutput struct{ *pulumi.OutputState }

func (GetFoldersResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetFoldersResult)(nil)).Elem()
}

func (o GetFoldersResultOutput) ToGetFoldersResultOutput() GetFoldersResultOutput {
	return o
}

func (o GetFoldersResultOutput) ToGetFoldersResultOutputWithContext(ctx context.Context) GetFoldersResultOutput {
	return o
}

func (o GetFoldersResultOutput) Folders() GetFoldersFolderArrayOutput {
	return o.ApplyT(func(v GetFoldersResult) []GetFoldersFolder { return v.Folders }).(GetFoldersFolderArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetFoldersResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetFoldersResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetFoldersResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetFoldersResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

func (o GetFoldersResultOutput) OutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetFoldersResult) *string { return v.OutputFile }).(pulumi.StringPtrOutput)
}

func (o GetFoldersResultOutput) ParentFolderPath() pulumi.StringOutput {
	return o.ApplyT(func(v GetFoldersResult) string { return v.ParentFolderPath }).(pulumi.StringOutput)
}

func (o GetFoldersResultOutput) ProjectId() pulumi.StringOutput {
	return o.ApplyT(func(v GetFoldersResult) string { return v.ProjectId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetFoldersResultOutput{})
}