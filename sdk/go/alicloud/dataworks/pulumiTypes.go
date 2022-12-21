// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dataworks

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type GetFoldersFolder struct {
	FolderId string `pulumi:"folderId"`
	// Folder Path.
	FolderPath string `pulumi:"folderPath"`
	// The Folder ID.
	Id string `pulumi:"id"`
	// The ID of the project.
	ProjectId string `pulumi:"projectId"`
}

// GetFoldersFolderInput is an input type that accepts GetFoldersFolderArgs and GetFoldersFolderOutput values.
// You can construct a concrete instance of `GetFoldersFolderInput` via:
//
//	GetFoldersFolderArgs{...}
type GetFoldersFolderInput interface {
	pulumi.Input

	ToGetFoldersFolderOutput() GetFoldersFolderOutput
	ToGetFoldersFolderOutputWithContext(context.Context) GetFoldersFolderOutput
}

type GetFoldersFolderArgs struct {
	FolderId pulumi.StringInput `pulumi:"folderId"`
	// Folder Path.
	FolderPath pulumi.StringInput `pulumi:"folderPath"`
	// The Folder ID.
	Id pulumi.StringInput `pulumi:"id"`
	// The ID of the project.
	ProjectId pulumi.StringInput `pulumi:"projectId"`
}

func (GetFoldersFolderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetFoldersFolder)(nil)).Elem()
}

func (i GetFoldersFolderArgs) ToGetFoldersFolderOutput() GetFoldersFolderOutput {
	return i.ToGetFoldersFolderOutputWithContext(context.Background())
}

func (i GetFoldersFolderArgs) ToGetFoldersFolderOutputWithContext(ctx context.Context) GetFoldersFolderOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetFoldersFolderOutput)
}

// GetFoldersFolderArrayInput is an input type that accepts GetFoldersFolderArray and GetFoldersFolderArrayOutput values.
// You can construct a concrete instance of `GetFoldersFolderArrayInput` via:
//
//	GetFoldersFolderArray{ GetFoldersFolderArgs{...} }
type GetFoldersFolderArrayInput interface {
	pulumi.Input

	ToGetFoldersFolderArrayOutput() GetFoldersFolderArrayOutput
	ToGetFoldersFolderArrayOutputWithContext(context.Context) GetFoldersFolderArrayOutput
}

type GetFoldersFolderArray []GetFoldersFolderInput

func (GetFoldersFolderArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetFoldersFolder)(nil)).Elem()
}

func (i GetFoldersFolderArray) ToGetFoldersFolderArrayOutput() GetFoldersFolderArrayOutput {
	return i.ToGetFoldersFolderArrayOutputWithContext(context.Background())
}

func (i GetFoldersFolderArray) ToGetFoldersFolderArrayOutputWithContext(ctx context.Context) GetFoldersFolderArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetFoldersFolderArrayOutput)
}

type GetFoldersFolderOutput struct{ *pulumi.OutputState }

func (GetFoldersFolderOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetFoldersFolder)(nil)).Elem()
}

func (o GetFoldersFolderOutput) ToGetFoldersFolderOutput() GetFoldersFolderOutput {
	return o
}

func (o GetFoldersFolderOutput) ToGetFoldersFolderOutputWithContext(ctx context.Context) GetFoldersFolderOutput {
	return o
}

func (o GetFoldersFolderOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v GetFoldersFolder) string { return v.FolderId }).(pulumi.StringOutput)
}

// Folder Path.
func (o GetFoldersFolderOutput) FolderPath() pulumi.StringOutput {
	return o.ApplyT(func(v GetFoldersFolder) string { return v.FolderPath }).(pulumi.StringOutput)
}

// The Folder ID.
func (o GetFoldersFolderOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetFoldersFolder) string { return v.Id }).(pulumi.StringOutput)
}

// The ID of the project.
func (o GetFoldersFolderOutput) ProjectId() pulumi.StringOutput {
	return o.ApplyT(func(v GetFoldersFolder) string { return v.ProjectId }).(pulumi.StringOutput)
}

type GetFoldersFolderArrayOutput struct{ *pulumi.OutputState }

func (GetFoldersFolderArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetFoldersFolder)(nil)).Elem()
}

func (o GetFoldersFolderArrayOutput) ToGetFoldersFolderArrayOutput() GetFoldersFolderArrayOutput {
	return o
}

func (o GetFoldersFolderArrayOutput) ToGetFoldersFolderArrayOutputWithContext(ctx context.Context) GetFoldersFolderArrayOutput {
	return o
}

func (o GetFoldersFolderArrayOutput) Index(i pulumi.IntInput) GetFoldersFolderOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetFoldersFolder {
		return vs[0].([]GetFoldersFolder)[vs[1].(int)]
	}).(GetFoldersFolderOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*GetFoldersFolderInput)(nil)).Elem(), GetFoldersFolderArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*GetFoldersFolderArrayInput)(nil)).Elem(), GetFoldersFolderArray{})
	pulumi.RegisterOutputType(GetFoldersFolderOutput{})
	pulumi.RegisterOutputType(GetFoldersFolderArrayOutput{})
}