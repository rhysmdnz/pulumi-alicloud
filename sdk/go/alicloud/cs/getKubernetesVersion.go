// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cs

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides the details of the Kubernetes version supported by ACK.
//
// > **NOTE:** Available in 1.170.0+.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-alicloud/sdk/go/alicloud/cs"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/cs"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_default, err := cs.GetKubernetesVersion(ctx, &cs.GetKubernetesVersionArgs{
//				ClusterType:       "ManagedKubernetes",
//				KubernetesVersion: pulumi.StringRef("1.22.3-aliyun.1"),
//				Profile:           pulumi.StringRef("Default"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("metadata", _default.Metadatas)
//			return nil
//		})
//	}
//
// ```
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-alicloud/sdk/go/alicloud/cs"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/cs"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_default, err := cs.GetKubernetesVersion(ctx, &cs.GetKubernetesVersionArgs{
//				ClusterType:       "Kubernetes",
//				KubernetesVersion: pulumi.StringRef("1.22.3-aliyun.1"),
//				Profile:           pulumi.StringRef("Default"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("metadata", _default.Metadatas)
//			return nil
//		})
//	}
//
// ```
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-alicloud/sdk/go/alicloud/cs"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/cs"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_default, err := cs.GetKubernetesVersion(ctx, &cs.GetKubernetesVersionArgs{
//				ClusterType:       "ManagedKubernetes",
//				KubernetesVersion: pulumi.StringRef("1.22.3-aliyun.1"),
//				Profile:           pulumi.StringRef("Serverless"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("metadata", _default.Metadatas)
//			return nil
//		})
//	}
//
// ```
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-alicloud/sdk/go/alicloud/cs"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/cs"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_default, err := cs.GetKubernetesVersion(ctx, &cs.GetKubernetesVersionArgs{
//				ClusterType:       "ManagedKubernetes",
//				KubernetesVersion: pulumi.StringRef("1.20.11-aliyunedge.1"),
//				Profile:           pulumi.StringRef("Edge"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("metadata", _default.Metadatas)
//			return nil
//		})
//	}
//
// ```
func GetKubernetesVersion(ctx *pulumi.Context, args *GetKubernetesVersionArgs, opts ...pulumi.InvokeOption) (*GetKubernetesVersionResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetKubernetesVersionResult
	err := ctx.Invoke("alicloud:cs/getKubernetesVersion:getKubernetesVersion", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getKubernetesVersion.
type GetKubernetesVersionArgs struct {
	// The type of cluster. Its valid value are `Kubernetes` and `ManagedKubernetes`.
	ClusterType string `pulumi:"clusterType"`
	// The ACK released kubernetes version.
	KubernetesVersion *string `pulumi:"kubernetesVersion"`
	// The profile of cluster. Its valid value are `Default`, `Serverless` and `Edge`.
	Profile *string `pulumi:"profile"`
}

// A collection of values returned by getKubernetesVersion.
type GetKubernetesVersionResult struct {
	ClusterType string `pulumi:"clusterType"`
	// The provider-assigned unique ID for this managed resource.
	Id                string  `pulumi:"id"`
	KubernetesVersion *string `pulumi:"kubernetesVersion"`
	// A list of metadata of kubernetes version.
	Metadatas []GetKubernetesVersionMetadata `pulumi:"metadatas"`
	Profile   *string                        `pulumi:"profile"`
}

func GetKubernetesVersionOutput(ctx *pulumi.Context, args GetKubernetesVersionOutputArgs, opts ...pulumi.InvokeOption) GetKubernetesVersionResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetKubernetesVersionResult, error) {
			args := v.(GetKubernetesVersionArgs)
			r, err := GetKubernetesVersion(ctx, &args, opts...)
			var s GetKubernetesVersionResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetKubernetesVersionResultOutput)
}

// A collection of arguments for invoking getKubernetesVersion.
type GetKubernetesVersionOutputArgs struct {
	// The type of cluster. Its valid value are `Kubernetes` and `ManagedKubernetes`.
	ClusterType pulumi.StringInput `pulumi:"clusterType"`
	// The ACK released kubernetes version.
	KubernetesVersion pulumi.StringPtrInput `pulumi:"kubernetesVersion"`
	// The profile of cluster. Its valid value are `Default`, `Serverless` and `Edge`.
	Profile pulumi.StringPtrInput `pulumi:"profile"`
}

func (GetKubernetesVersionOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetKubernetesVersionArgs)(nil)).Elem()
}

// A collection of values returned by getKubernetesVersion.
type GetKubernetesVersionResultOutput struct{ *pulumi.OutputState }

func (GetKubernetesVersionResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetKubernetesVersionResult)(nil)).Elem()
}

func (o GetKubernetesVersionResultOutput) ToGetKubernetesVersionResultOutput() GetKubernetesVersionResultOutput {
	return o
}

func (o GetKubernetesVersionResultOutput) ToGetKubernetesVersionResultOutputWithContext(ctx context.Context) GetKubernetesVersionResultOutput {
	return o
}

func (o GetKubernetesVersionResultOutput) ClusterType() pulumi.StringOutput {
	return o.ApplyT(func(v GetKubernetesVersionResult) string { return v.ClusterType }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetKubernetesVersionResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetKubernetesVersionResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetKubernetesVersionResultOutput) KubernetesVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetKubernetesVersionResult) *string { return v.KubernetesVersion }).(pulumi.StringPtrOutput)
}

// A list of metadata of kubernetes version.
func (o GetKubernetesVersionResultOutput) Metadatas() GetKubernetesVersionMetadataArrayOutput {
	return o.ApplyT(func(v GetKubernetesVersionResult) []GetKubernetesVersionMetadata { return v.Metadatas }).(GetKubernetesVersionMetadataArrayOutput)
}

func (o GetKubernetesVersionResultOutput) Profile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetKubernetesVersionResult) *string { return v.Profile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetKubernetesVersionResultOutput{})
}