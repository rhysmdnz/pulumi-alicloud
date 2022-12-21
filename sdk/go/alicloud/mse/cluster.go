// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mse

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a MSE Cluster resource. It is a one-stop microservice platform for the industry's mainstream open source microservice frameworks Spring Cloud and Dubbo, providing governance center, managed registry and managed configuration center.
//
// > **NOTE:** Available in 1.94.0+.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/mse"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := mse.NewCluster(ctx, "example", &mse.ClusterArgs{
//				AclEntryLists: pulumi.StringArray{
//					pulumi.String("127.0.0.1/32"),
//				},
//				ClusterAliasName:     pulumi.String("tf-testAccMseCluster"),
//				ClusterSpecification: pulumi.String("MSE_SC_1_2_200_c"),
//				ClusterType:          pulumi.String("Nacos-Ans"),
//				ClusterVersion:       pulumi.String("NACOS_ANS_1_2_1"),
//				InstanceCount:        pulumi.Int(1),
//				MseVersion:           pulumi.String("mse_dev"),
//				NetType:              pulumi.String("privatenet"),
//				PubNetworkFlow:       pulumi.String("1"),
//				VswitchId:            pulumi.String("vsw-123456"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
//
// ## Import
//
// MSE Cluster can be imported using the id, e.g.
//
// ```sh
//
//	$ pulumi import alicloud:mse/cluster:Cluster example mse-cn-0d9xxxx
//
// ```
type Cluster struct {
	pulumi.CustomResourceState

	// The whitelist. **NOTE:** This attribute is invalid when the value of `pubNetworkFlow` is `0` and the value of `netType` is `privatenet`.
	AclEntryLists pulumi.StringArrayOutput `pulumi:"aclEntryLists"`
	// The alias of MSE Cluster.
	ClusterAliasName pulumi.StringPtrOutput `pulumi:"clusterAliasName"`
	// (Available in v1.162.0+)  The id of Cluster.
	ClusterId pulumi.StringOutput `pulumi:"clusterId"`
	// The engine specification of MSE Cluster. **NOTE:** From version 1.188.0, `clusterSpecification` can be modified. Valid values:
	// - `MSE_SC_1_2_60_c`: 1C2G
	// - `MSE_SC_2_4_60_c`: 2C4G
	// - `MSE_SC_4_8_60_c`: 4C8G
	// - `MSE_SC_8_16_60_c`: 8C16G
	ClusterSpecification pulumi.StringOutput `pulumi:"clusterSpecification"`
	// The type of MSE Cluster.
	ClusterType pulumi.StringOutput `pulumi:"clusterType"`
	// The version of MSE Cluster. See [details](https://www.alibabacloud.com/help/en/microservices-engine/latest/api-doc-mse-2019-05-31-api-doc-createcluster)
	ClusterVersion pulumi.StringOutput `pulumi:"clusterVersion"`
	// The connection type. Valid values: `slb`.
	ConnectionType pulumi.StringOutput `pulumi:"connectionType"`
	// The type of Disk.
	DiskType pulumi.StringPtrOutput `pulumi:"diskType"`
	// The count of instance. **NOTE:** From version 1.188.0, `instanceCount` can be modified.
	InstanceCount pulumi.IntOutput `pulumi:"instanceCount"`
	// The version of MSE. Valid values: `mseDev` or `msePro`.
	MseVersion pulumi.StringOutput `pulumi:"mseVersion"`
	// The type of network. Valid values: "privatenet" and "pubnet".
	NetType pulumi.StringOutput `pulumi:"netType"`
	// The specification of private network SLB.
	PrivateSlbSpecification pulumi.StringPtrOutput `pulumi:"privateSlbSpecification"`
	// The public network bandwidth. `0` means no access to the public network.
	PubNetworkFlow pulumi.StringOutput `pulumi:"pubNetworkFlow"`
	// The specification of public network SLB.
	PubSlbSpecification pulumi.StringPtrOutput `pulumi:"pubSlbSpecification"`
	// The extended request parameters in the JSON format.
	RequestPars pulumi.StringPtrOutput `pulumi:"requestPars"`
	// The status of MSE Cluster.
	Status pulumi.StringOutput `pulumi:"status"`
	// The id of the VPC.
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
	// The id of VSwitch.
	VswitchId pulumi.StringPtrOutput `pulumi:"vswitchId"`
}

// NewCluster registers a new resource with the given unique name, arguments, and options.
func NewCluster(ctx *pulumi.Context,
	name string, args *ClusterArgs, opts ...pulumi.ResourceOption) (*Cluster, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClusterSpecification == nil {
		return nil, errors.New("invalid value for required argument 'ClusterSpecification'")
	}
	if args.ClusterType == nil {
		return nil, errors.New("invalid value for required argument 'ClusterType'")
	}
	if args.ClusterVersion == nil {
		return nil, errors.New("invalid value for required argument 'ClusterVersion'")
	}
	if args.InstanceCount == nil {
		return nil, errors.New("invalid value for required argument 'InstanceCount'")
	}
	if args.NetType == nil {
		return nil, errors.New("invalid value for required argument 'NetType'")
	}
	if args.PubNetworkFlow == nil {
		return nil, errors.New("invalid value for required argument 'PubNetworkFlow'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource Cluster
	err := ctx.RegisterResource("alicloud:mse/cluster:Cluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCluster gets an existing Cluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterState, opts ...pulumi.ResourceOption) (*Cluster, error) {
	var resource Cluster
	err := ctx.ReadResource("alicloud:mse/cluster:Cluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Cluster resources.
type clusterState struct {
	// The whitelist. **NOTE:** This attribute is invalid when the value of `pubNetworkFlow` is `0` and the value of `netType` is `privatenet`.
	AclEntryLists []string `pulumi:"aclEntryLists"`
	// The alias of MSE Cluster.
	ClusterAliasName *string `pulumi:"clusterAliasName"`
	// (Available in v1.162.0+)  The id of Cluster.
	ClusterId *string `pulumi:"clusterId"`
	// The engine specification of MSE Cluster. **NOTE:** From version 1.188.0, `clusterSpecification` can be modified. Valid values:
	// - `MSE_SC_1_2_60_c`: 1C2G
	// - `MSE_SC_2_4_60_c`: 2C4G
	// - `MSE_SC_4_8_60_c`: 4C8G
	// - `MSE_SC_8_16_60_c`: 8C16G
	ClusterSpecification *string `pulumi:"clusterSpecification"`
	// The type of MSE Cluster.
	ClusterType *string `pulumi:"clusterType"`
	// The version of MSE Cluster. See [details](https://www.alibabacloud.com/help/en/microservices-engine/latest/api-doc-mse-2019-05-31-api-doc-createcluster)
	ClusterVersion *string `pulumi:"clusterVersion"`
	// The connection type. Valid values: `slb`.
	ConnectionType *string `pulumi:"connectionType"`
	// The type of Disk.
	DiskType *string `pulumi:"diskType"`
	// The count of instance. **NOTE:** From version 1.188.0, `instanceCount` can be modified.
	InstanceCount *int `pulumi:"instanceCount"`
	// The version of MSE. Valid values: `mseDev` or `msePro`.
	MseVersion *string `pulumi:"mseVersion"`
	// The type of network. Valid values: "privatenet" and "pubnet".
	NetType *string `pulumi:"netType"`
	// The specification of private network SLB.
	PrivateSlbSpecification *string `pulumi:"privateSlbSpecification"`
	// The public network bandwidth. `0` means no access to the public network.
	PubNetworkFlow *string `pulumi:"pubNetworkFlow"`
	// The specification of public network SLB.
	PubSlbSpecification *string `pulumi:"pubSlbSpecification"`
	// The extended request parameters in the JSON format.
	RequestPars *string `pulumi:"requestPars"`
	// The status of MSE Cluster.
	Status *string `pulumi:"status"`
	// The id of the VPC.
	VpcId *string `pulumi:"vpcId"`
	// The id of VSwitch.
	VswitchId *string `pulumi:"vswitchId"`
}

type ClusterState struct {
	// The whitelist. **NOTE:** This attribute is invalid when the value of `pubNetworkFlow` is `0` and the value of `netType` is `privatenet`.
	AclEntryLists pulumi.StringArrayInput
	// The alias of MSE Cluster.
	ClusterAliasName pulumi.StringPtrInput
	// (Available in v1.162.0+)  The id of Cluster.
	ClusterId pulumi.StringPtrInput
	// The engine specification of MSE Cluster. **NOTE:** From version 1.188.0, `clusterSpecification` can be modified. Valid values:
	// - `MSE_SC_1_2_60_c`: 1C2G
	// - `MSE_SC_2_4_60_c`: 2C4G
	// - `MSE_SC_4_8_60_c`: 4C8G
	// - `MSE_SC_8_16_60_c`: 8C16G
	ClusterSpecification pulumi.StringPtrInput
	// The type of MSE Cluster.
	ClusterType pulumi.StringPtrInput
	// The version of MSE Cluster. See [details](https://www.alibabacloud.com/help/en/microservices-engine/latest/api-doc-mse-2019-05-31-api-doc-createcluster)
	ClusterVersion pulumi.StringPtrInput
	// The connection type. Valid values: `slb`.
	ConnectionType pulumi.StringPtrInput
	// The type of Disk.
	DiskType pulumi.StringPtrInput
	// The count of instance. **NOTE:** From version 1.188.0, `instanceCount` can be modified.
	InstanceCount pulumi.IntPtrInput
	// The version of MSE. Valid values: `mseDev` or `msePro`.
	MseVersion pulumi.StringPtrInput
	// The type of network. Valid values: "privatenet" and "pubnet".
	NetType pulumi.StringPtrInput
	// The specification of private network SLB.
	PrivateSlbSpecification pulumi.StringPtrInput
	// The public network bandwidth. `0` means no access to the public network.
	PubNetworkFlow pulumi.StringPtrInput
	// The specification of public network SLB.
	PubSlbSpecification pulumi.StringPtrInput
	// The extended request parameters in the JSON format.
	RequestPars pulumi.StringPtrInput
	// The status of MSE Cluster.
	Status pulumi.StringPtrInput
	// The id of the VPC.
	VpcId pulumi.StringPtrInput
	// The id of VSwitch.
	VswitchId pulumi.StringPtrInput
}

func (ClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterState)(nil)).Elem()
}

type clusterArgs struct {
	// The whitelist. **NOTE:** This attribute is invalid when the value of `pubNetworkFlow` is `0` and the value of `netType` is `privatenet`.
	AclEntryLists []string `pulumi:"aclEntryLists"`
	// The alias of MSE Cluster.
	ClusterAliasName *string `pulumi:"clusterAliasName"`
	// The engine specification of MSE Cluster. **NOTE:** From version 1.188.0, `clusterSpecification` can be modified. Valid values:
	// - `MSE_SC_1_2_60_c`: 1C2G
	// - `MSE_SC_2_4_60_c`: 2C4G
	// - `MSE_SC_4_8_60_c`: 4C8G
	// - `MSE_SC_8_16_60_c`: 8C16G
	ClusterSpecification string `pulumi:"clusterSpecification"`
	// The type of MSE Cluster.
	ClusterType string `pulumi:"clusterType"`
	// The version of MSE Cluster. See [details](https://www.alibabacloud.com/help/en/microservices-engine/latest/api-doc-mse-2019-05-31-api-doc-createcluster)
	ClusterVersion string `pulumi:"clusterVersion"`
	// The connection type. Valid values: `slb`.
	ConnectionType *string `pulumi:"connectionType"`
	// The type of Disk.
	DiskType *string `pulumi:"diskType"`
	// The count of instance. **NOTE:** From version 1.188.0, `instanceCount` can be modified.
	InstanceCount int `pulumi:"instanceCount"`
	// The version of MSE. Valid values: `mseDev` or `msePro`.
	MseVersion *string `pulumi:"mseVersion"`
	// The type of network. Valid values: "privatenet" and "pubnet".
	NetType string `pulumi:"netType"`
	// The specification of private network SLB.
	PrivateSlbSpecification *string `pulumi:"privateSlbSpecification"`
	// The public network bandwidth. `0` means no access to the public network.
	PubNetworkFlow string `pulumi:"pubNetworkFlow"`
	// The specification of public network SLB.
	PubSlbSpecification *string `pulumi:"pubSlbSpecification"`
	// The extended request parameters in the JSON format.
	RequestPars *string `pulumi:"requestPars"`
	// The id of the VPC.
	VpcId *string `pulumi:"vpcId"`
	// The id of VSwitch.
	VswitchId *string `pulumi:"vswitchId"`
}

// The set of arguments for constructing a Cluster resource.
type ClusterArgs struct {
	// The whitelist. **NOTE:** This attribute is invalid when the value of `pubNetworkFlow` is `0` and the value of `netType` is `privatenet`.
	AclEntryLists pulumi.StringArrayInput
	// The alias of MSE Cluster.
	ClusterAliasName pulumi.StringPtrInput
	// The engine specification of MSE Cluster. **NOTE:** From version 1.188.0, `clusterSpecification` can be modified. Valid values:
	// - `MSE_SC_1_2_60_c`: 1C2G
	// - `MSE_SC_2_4_60_c`: 2C4G
	// - `MSE_SC_4_8_60_c`: 4C8G
	// - `MSE_SC_8_16_60_c`: 8C16G
	ClusterSpecification pulumi.StringInput
	// The type of MSE Cluster.
	ClusterType pulumi.StringInput
	// The version of MSE Cluster. See [details](https://www.alibabacloud.com/help/en/microservices-engine/latest/api-doc-mse-2019-05-31-api-doc-createcluster)
	ClusterVersion pulumi.StringInput
	// The connection type. Valid values: `slb`.
	ConnectionType pulumi.StringPtrInput
	// The type of Disk.
	DiskType pulumi.StringPtrInput
	// The count of instance. **NOTE:** From version 1.188.0, `instanceCount` can be modified.
	InstanceCount pulumi.IntInput
	// The version of MSE. Valid values: `mseDev` or `msePro`.
	MseVersion pulumi.StringPtrInput
	// The type of network. Valid values: "privatenet" and "pubnet".
	NetType pulumi.StringInput
	// The specification of private network SLB.
	PrivateSlbSpecification pulumi.StringPtrInput
	// The public network bandwidth. `0` means no access to the public network.
	PubNetworkFlow pulumi.StringInput
	// The specification of public network SLB.
	PubSlbSpecification pulumi.StringPtrInput
	// The extended request parameters in the JSON format.
	RequestPars pulumi.StringPtrInput
	// The id of the VPC.
	VpcId pulumi.StringPtrInput
	// The id of VSwitch.
	VswitchId pulumi.StringPtrInput
}

func (ClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterArgs)(nil)).Elem()
}

type ClusterInput interface {
	pulumi.Input

	ToClusterOutput() ClusterOutput
	ToClusterOutputWithContext(ctx context.Context) ClusterOutput
}

func (*Cluster) ElementType() reflect.Type {
	return reflect.TypeOf((**Cluster)(nil)).Elem()
}

func (i *Cluster) ToClusterOutput() ClusterOutput {
	return i.ToClusterOutputWithContext(context.Background())
}

func (i *Cluster) ToClusterOutputWithContext(ctx context.Context) ClusterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterOutput)
}

// ClusterArrayInput is an input type that accepts ClusterArray and ClusterArrayOutput values.
// You can construct a concrete instance of `ClusterArrayInput` via:
//
//	ClusterArray{ ClusterArgs{...} }
type ClusterArrayInput interface {
	pulumi.Input

	ToClusterArrayOutput() ClusterArrayOutput
	ToClusterArrayOutputWithContext(context.Context) ClusterArrayOutput
}

type ClusterArray []ClusterInput

func (ClusterArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Cluster)(nil)).Elem()
}

func (i ClusterArray) ToClusterArrayOutput() ClusterArrayOutput {
	return i.ToClusterArrayOutputWithContext(context.Background())
}

func (i ClusterArray) ToClusterArrayOutputWithContext(ctx context.Context) ClusterArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterArrayOutput)
}

// ClusterMapInput is an input type that accepts ClusterMap and ClusterMapOutput values.
// You can construct a concrete instance of `ClusterMapInput` via:
//
//	ClusterMap{ "key": ClusterArgs{...} }
type ClusterMapInput interface {
	pulumi.Input

	ToClusterMapOutput() ClusterMapOutput
	ToClusterMapOutputWithContext(context.Context) ClusterMapOutput
}

type ClusterMap map[string]ClusterInput

func (ClusterMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Cluster)(nil)).Elem()
}

func (i ClusterMap) ToClusterMapOutput() ClusterMapOutput {
	return i.ToClusterMapOutputWithContext(context.Background())
}

func (i ClusterMap) ToClusterMapOutputWithContext(ctx context.Context) ClusterMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterMapOutput)
}

type ClusterOutput struct{ *pulumi.OutputState }

func (ClusterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Cluster)(nil)).Elem()
}

func (o ClusterOutput) ToClusterOutput() ClusterOutput {
	return o
}

func (o ClusterOutput) ToClusterOutputWithContext(ctx context.Context) ClusterOutput {
	return o
}

// The whitelist. **NOTE:** This attribute is invalid when the value of `pubNetworkFlow` is `0` and the value of `netType` is `privatenet`.
func (o ClusterOutput) AclEntryLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringArrayOutput { return v.AclEntryLists }).(pulumi.StringArrayOutput)
}

// The alias of MSE Cluster.
func (o ClusterOutput) ClusterAliasName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringPtrOutput { return v.ClusterAliasName }).(pulumi.StringPtrOutput)
}

// (Available in v1.162.0+)  The id of Cluster.
func (o ClusterOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringOutput { return v.ClusterId }).(pulumi.StringOutput)
}

// The engine specification of MSE Cluster. **NOTE:** From version 1.188.0, `clusterSpecification` can be modified. Valid values:
// - `MSE_SC_1_2_60_c`: 1C2G
// - `MSE_SC_2_4_60_c`: 2C4G
// - `MSE_SC_4_8_60_c`: 4C8G
// - `MSE_SC_8_16_60_c`: 8C16G
func (o ClusterOutput) ClusterSpecification() pulumi.StringOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringOutput { return v.ClusterSpecification }).(pulumi.StringOutput)
}

// The type of MSE Cluster.
func (o ClusterOutput) ClusterType() pulumi.StringOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringOutput { return v.ClusterType }).(pulumi.StringOutput)
}

// The version of MSE Cluster. See [details](https://www.alibabacloud.com/help/en/microservices-engine/latest/api-doc-mse-2019-05-31-api-doc-createcluster)
func (o ClusterOutput) ClusterVersion() pulumi.StringOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringOutput { return v.ClusterVersion }).(pulumi.StringOutput)
}

// The connection type. Valid values: `slb`.
func (o ClusterOutput) ConnectionType() pulumi.StringOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringOutput { return v.ConnectionType }).(pulumi.StringOutput)
}

// The type of Disk.
func (o ClusterOutput) DiskType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringPtrOutput { return v.DiskType }).(pulumi.StringPtrOutput)
}

// The count of instance. **NOTE:** From version 1.188.0, `instanceCount` can be modified.
func (o ClusterOutput) InstanceCount() pulumi.IntOutput {
	return o.ApplyT(func(v *Cluster) pulumi.IntOutput { return v.InstanceCount }).(pulumi.IntOutput)
}

// The version of MSE. Valid values: `mseDev` or `msePro`.
func (o ClusterOutput) MseVersion() pulumi.StringOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringOutput { return v.MseVersion }).(pulumi.StringOutput)
}

// The type of network. Valid values: "privatenet" and "pubnet".
func (o ClusterOutput) NetType() pulumi.StringOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringOutput { return v.NetType }).(pulumi.StringOutput)
}

// The specification of private network SLB.
func (o ClusterOutput) PrivateSlbSpecification() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringPtrOutput { return v.PrivateSlbSpecification }).(pulumi.StringPtrOutput)
}

// The public network bandwidth. `0` means no access to the public network.
func (o ClusterOutput) PubNetworkFlow() pulumi.StringOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringOutput { return v.PubNetworkFlow }).(pulumi.StringOutput)
}

// The specification of public network SLB.
func (o ClusterOutput) PubSlbSpecification() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringPtrOutput { return v.PubSlbSpecification }).(pulumi.StringPtrOutput)
}

// The extended request parameters in the JSON format.
func (o ClusterOutput) RequestPars() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringPtrOutput { return v.RequestPars }).(pulumi.StringPtrOutput)
}

// The status of MSE Cluster.
func (o ClusterOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

// The id of the VPC.
func (o ClusterOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringOutput { return v.VpcId }).(pulumi.StringOutput)
}

// The id of VSwitch.
func (o ClusterOutput) VswitchId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Cluster) pulumi.StringPtrOutput { return v.VswitchId }).(pulumi.StringPtrOutput)
}

type ClusterArrayOutput struct{ *pulumi.OutputState }

func (ClusterArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Cluster)(nil)).Elem()
}

func (o ClusterArrayOutput) ToClusterArrayOutput() ClusterArrayOutput {
	return o
}

func (o ClusterArrayOutput) ToClusterArrayOutputWithContext(ctx context.Context) ClusterArrayOutput {
	return o
}

func (o ClusterArrayOutput) Index(i pulumi.IntInput) ClusterOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Cluster {
		return vs[0].([]*Cluster)[vs[1].(int)]
	}).(ClusterOutput)
}

type ClusterMapOutput struct{ *pulumi.OutputState }

func (ClusterMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Cluster)(nil)).Elem()
}

func (o ClusterMapOutput) ToClusterMapOutput() ClusterMapOutput {
	return o
}

func (o ClusterMapOutput) ToClusterMapOutputWithContext(ctx context.Context) ClusterMapOutput {
	return o
}

func (o ClusterMapOutput) MapIndex(k pulumi.StringInput) ClusterOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Cluster {
		return vs[0].(map[string]*Cluster)[vs[1].(string)]
	}).(ClusterOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ClusterInput)(nil)).Elem(), &Cluster{})
	pulumi.RegisterInputType(reflect.TypeOf((*ClusterArrayInput)(nil)).Elem(), ClusterArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ClusterMapInput)(nil)).Elem(), ClusterMap{})
	pulumi.RegisterOutputType(ClusterOutput{})
	pulumi.RegisterOutputType(ClusterArrayOutput{})
	pulumi.RegisterOutputType(ClusterMapOutput{})
}