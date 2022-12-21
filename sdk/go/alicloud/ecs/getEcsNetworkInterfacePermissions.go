// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ecs

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides the Ecs Network Interface Permissions of the current Alibaba Cloud user.
//
// > **NOTE:** Available in v1.166.0+.
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
//	"github.com/pulumi/pulumi-alicloud/sdk/go/alicloud/ecs"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/ecs"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			ids, err := ecs.GetEcsNetworkInterfacePermissions(ctx, &ecs.GetEcsNetworkInterfacePermissionsArgs{
//				Ids: []string{
//					"example_value",
//				},
//				NetworkInterfaceId: "example_value",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("ecsNetworkInterfacePermissionId1", ids.Permissions[0].Id)
//			return nil
//		})
//	}
//
// ```
func GetEcsNetworkInterfacePermissions(ctx *pulumi.Context, args *GetEcsNetworkInterfacePermissionsArgs, opts ...pulumi.InvokeOption) (*GetEcsNetworkInterfacePermissionsResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetEcsNetworkInterfacePermissionsResult
	err := ctx.Invoke("alicloud:ecs/getEcsNetworkInterfacePermissions:getEcsNetworkInterfacePermissions", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getEcsNetworkInterfacePermissions.
type GetEcsNetworkInterfacePermissionsArgs struct {
	// A list of Network Interface Permission IDs.
	Ids []string `pulumi:"ids"`
	// The ID of the network interface.
	NetworkInterfaceId string  `pulumi:"networkInterfaceId"`
	OutputFile         *string `pulumi:"outputFile"`
	PageNumber         *int    `pulumi:"pageNumber"`
	PageSize           *int    `pulumi:"pageSize"`
	// The Status of the Network Interface Permissions.
	Status *string `pulumi:"status"`
}

// A collection of values returned by getEcsNetworkInterfacePermissions.
type GetEcsNetworkInterfacePermissionsResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id                 string                                        `pulumi:"id"`
	Ids                []string                                      `pulumi:"ids"`
	NetworkInterfaceId string                                        `pulumi:"networkInterfaceId"`
	OutputFile         *string                                       `pulumi:"outputFile"`
	PageNumber         *int                                          `pulumi:"pageNumber"`
	PageSize           *int                                          `pulumi:"pageSize"`
	Permissions        []GetEcsNetworkInterfacePermissionsPermission `pulumi:"permissions"`
	Status             *string                                       `pulumi:"status"`
	TotalCount         int                                           `pulumi:"totalCount"`
}

func GetEcsNetworkInterfacePermissionsOutput(ctx *pulumi.Context, args GetEcsNetworkInterfacePermissionsOutputArgs, opts ...pulumi.InvokeOption) GetEcsNetworkInterfacePermissionsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetEcsNetworkInterfacePermissionsResult, error) {
			args := v.(GetEcsNetworkInterfacePermissionsArgs)
			r, err := GetEcsNetworkInterfacePermissions(ctx, &args, opts...)
			var s GetEcsNetworkInterfacePermissionsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetEcsNetworkInterfacePermissionsResultOutput)
}

// A collection of arguments for invoking getEcsNetworkInterfacePermissions.
type GetEcsNetworkInterfacePermissionsOutputArgs struct {
	// A list of Network Interface Permission IDs.
	Ids pulumi.StringArrayInput `pulumi:"ids"`
	// The ID of the network interface.
	NetworkInterfaceId pulumi.StringInput    `pulumi:"networkInterfaceId"`
	OutputFile         pulumi.StringPtrInput `pulumi:"outputFile"`
	PageNumber         pulumi.IntPtrInput    `pulumi:"pageNumber"`
	PageSize           pulumi.IntPtrInput    `pulumi:"pageSize"`
	// The Status of the Network Interface Permissions.
	Status pulumi.StringPtrInput `pulumi:"status"`
}

func (GetEcsNetworkInterfacePermissionsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetEcsNetworkInterfacePermissionsArgs)(nil)).Elem()
}

// A collection of values returned by getEcsNetworkInterfacePermissions.
type GetEcsNetworkInterfacePermissionsResultOutput struct{ *pulumi.OutputState }

func (GetEcsNetworkInterfacePermissionsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetEcsNetworkInterfacePermissionsResult)(nil)).Elem()
}

func (o GetEcsNetworkInterfacePermissionsResultOutput) ToGetEcsNetworkInterfacePermissionsResultOutput() GetEcsNetworkInterfacePermissionsResultOutput {
	return o
}

func (o GetEcsNetworkInterfacePermissionsResultOutput) ToGetEcsNetworkInterfacePermissionsResultOutputWithContext(ctx context.Context) GetEcsNetworkInterfacePermissionsResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetEcsNetworkInterfacePermissionsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetEcsNetworkInterfacePermissionsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetEcsNetworkInterfacePermissionsResultOutput) Ids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetEcsNetworkInterfacePermissionsResult) []string { return v.Ids }).(pulumi.StringArrayOutput)
}

func (o GetEcsNetworkInterfacePermissionsResultOutput) NetworkInterfaceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetEcsNetworkInterfacePermissionsResult) string { return v.NetworkInterfaceId }).(pulumi.StringOutput)
}

func (o GetEcsNetworkInterfacePermissionsResultOutput) OutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetEcsNetworkInterfacePermissionsResult) *string { return v.OutputFile }).(pulumi.StringPtrOutput)
}

func (o GetEcsNetworkInterfacePermissionsResultOutput) PageNumber() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetEcsNetworkInterfacePermissionsResult) *int { return v.PageNumber }).(pulumi.IntPtrOutput)
}

func (o GetEcsNetworkInterfacePermissionsResultOutput) PageSize() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetEcsNetworkInterfacePermissionsResult) *int { return v.PageSize }).(pulumi.IntPtrOutput)
}

func (o GetEcsNetworkInterfacePermissionsResultOutput) Permissions() GetEcsNetworkInterfacePermissionsPermissionArrayOutput {
	return o.ApplyT(func(v GetEcsNetworkInterfacePermissionsResult) []GetEcsNetworkInterfacePermissionsPermission {
		return v.Permissions
	}).(GetEcsNetworkInterfacePermissionsPermissionArrayOutput)
}

func (o GetEcsNetworkInterfacePermissionsResultOutput) Status() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetEcsNetworkInterfacePermissionsResult) *string { return v.Status }).(pulumi.StringPtrOutput)
}

func (o GetEcsNetworkInterfacePermissionsResultOutput) TotalCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetEcsNetworkInterfacePermissionsResult) int { return v.TotalCount }).(pulumi.IntOutput)
}

func init() {
	pulumi.RegisterOutputType(GetEcsNetworkInterfacePermissionsResultOutput{})
}