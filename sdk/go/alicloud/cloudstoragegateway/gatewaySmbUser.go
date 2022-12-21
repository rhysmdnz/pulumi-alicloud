// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cloudstoragegateway

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a Cloud Storage Gateway Gateway SMB User resource.
//
// For information about Cloud Storage Gateway Gateway SMB User and how to use it, see [What is Gateway SMB User](https://www.alibabacloud.com/help/en/doc-detail/53972.htm).
//
// > **NOTE:** Available in v1.142.0+.
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
//	"github.com/pulumi/pulumi-alicloud/sdk/go/alicloud/vpc"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/cloudstoragegateway"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/vpc"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			defaultNetworks, err := vpc.GetNetworks(ctx, &vpc.GetNetworksArgs{
//				NameRegex: pulumi.StringRef("default-NODELETING"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			defaultSwitches, err := vpc.GetSwitches(ctx, &vpc.GetSwitchesArgs{
//				VpcId: pulumi.StringRef(defaultNetworks.Ids[0]),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			example, err := cloudstoragegateway.NewStorageBundle(ctx, "example", &cloudstoragegateway.StorageBundleArgs{
//				StorageBundleName: pulumi.String("example_value"),
//			})
//			if err != nil {
//				return err
//			}
//			defaultGateway, err := cloudstoragegateway.NewGateway(ctx, "defaultGateway", &cloudstoragegateway.GatewayArgs{
//				Description:            pulumi.String("tf-acctestDesalone"),
//				GatewayClass:           pulumi.String("Standard"),
//				Type:                   pulumi.String("File"),
//				PaymentType:            pulumi.String("PayAsYouGo"),
//				VswitchId:              pulumi.String(defaultSwitches.Ids[0]),
//				ReleaseAfterExpiration: pulumi.Bool(false),
//				PublicNetworkBandwidth: pulumi.Int(40),
//				StorageBundleId:        example.ID(),
//				Location:               pulumi.String("Cloud"),
//				GatewayName:            pulumi.String("example_value"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = cloudstoragegateway.NewGatewaySmbUser(ctx, "defaultGatewaySmbUser", &cloudstoragegateway.GatewaySmbUserArgs{
//				Username:  pulumi.String("your_username"),
//				Password:  pulumi.String("password"),
//				GatewayId: defaultGateway.ID(),
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
// Cloud Storage Gateway Gateway SMB User can be imported using the id, e.g.
//
// ```sh
//
//	$ pulumi import alicloud:cloudstoragegateway/gatewaySmbUser:GatewaySmbUser example <gateway_id>:<username>
//
// ```
type GatewaySmbUser struct {
	pulumi.CustomResourceState

	// The Gateway ID of the Gateway SMB User.
	GatewayId pulumi.StringOutput `pulumi:"gatewayId"`
	// The password of the Gateway SMB User.
	Password pulumi.StringOutput `pulumi:"password"`
	// The username of the Gateway SMB User.
	Username pulumi.StringOutput `pulumi:"username"`
}

// NewGatewaySmbUser registers a new resource with the given unique name, arguments, and options.
func NewGatewaySmbUser(ctx *pulumi.Context,
	name string, args *GatewaySmbUserArgs, opts ...pulumi.ResourceOption) (*GatewaySmbUser, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.GatewayId == nil {
		return nil, errors.New("invalid value for required argument 'GatewayId'")
	}
	if args.Password == nil {
		return nil, errors.New("invalid value for required argument 'Password'")
	}
	if args.Username == nil {
		return nil, errors.New("invalid value for required argument 'Username'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource GatewaySmbUser
	err := ctx.RegisterResource("alicloud:cloudstoragegateway/gatewaySmbUser:GatewaySmbUser", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGatewaySmbUser gets an existing GatewaySmbUser resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGatewaySmbUser(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GatewaySmbUserState, opts ...pulumi.ResourceOption) (*GatewaySmbUser, error) {
	var resource GatewaySmbUser
	err := ctx.ReadResource("alicloud:cloudstoragegateway/gatewaySmbUser:GatewaySmbUser", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GatewaySmbUser resources.
type gatewaySmbUserState struct {
	// The Gateway ID of the Gateway SMB User.
	GatewayId *string `pulumi:"gatewayId"`
	// The password of the Gateway SMB User.
	Password *string `pulumi:"password"`
	// The username of the Gateway SMB User.
	Username *string `pulumi:"username"`
}

type GatewaySmbUserState struct {
	// The Gateway ID of the Gateway SMB User.
	GatewayId pulumi.StringPtrInput
	// The password of the Gateway SMB User.
	Password pulumi.StringPtrInput
	// The username of the Gateway SMB User.
	Username pulumi.StringPtrInput
}

func (GatewaySmbUserState) ElementType() reflect.Type {
	return reflect.TypeOf((*gatewaySmbUserState)(nil)).Elem()
}

type gatewaySmbUserArgs struct {
	// The Gateway ID of the Gateway SMB User.
	GatewayId string `pulumi:"gatewayId"`
	// The password of the Gateway SMB User.
	Password string `pulumi:"password"`
	// The username of the Gateway SMB User.
	Username string `pulumi:"username"`
}

// The set of arguments for constructing a GatewaySmbUser resource.
type GatewaySmbUserArgs struct {
	// The Gateway ID of the Gateway SMB User.
	GatewayId pulumi.StringInput
	// The password of the Gateway SMB User.
	Password pulumi.StringInput
	// The username of the Gateway SMB User.
	Username pulumi.StringInput
}

func (GatewaySmbUserArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*gatewaySmbUserArgs)(nil)).Elem()
}

type GatewaySmbUserInput interface {
	pulumi.Input

	ToGatewaySmbUserOutput() GatewaySmbUserOutput
	ToGatewaySmbUserOutputWithContext(ctx context.Context) GatewaySmbUserOutput
}

func (*GatewaySmbUser) ElementType() reflect.Type {
	return reflect.TypeOf((**GatewaySmbUser)(nil)).Elem()
}

func (i *GatewaySmbUser) ToGatewaySmbUserOutput() GatewaySmbUserOutput {
	return i.ToGatewaySmbUserOutputWithContext(context.Background())
}

func (i *GatewaySmbUser) ToGatewaySmbUserOutputWithContext(ctx context.Context) GatewaySmbUserOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GatewaySmbUserOutput)
}

// GatewaySmbUserArrayInput is an input type that accepts GatewaySmbUserArray and GatewaySmbUserArrayOutput values.
// You can construct a concrete instance of `GatewaySmbUserArrayInput` via:
//
//	GatewaySmbUserArray{ GatewaySmbUserArgs{...} }
type GatewaySmbUserArrayInput interface {
	pulumi.Input

	ToGatewaySmbUserArrayOutput() GatewaySmbUserArrayOutput
	ToGatewaySmbUserArrayOutputWithContext(context.Context) GatewaySmbUserArrayOutput
}

type GatewaySmbUserArray []GatewaySmbUserInput

func (GatewaySmbUserArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*GatewaySmbUser)(nil)).Elem()
}

func (i GatewaySmbUserArray) ToGatewaySmbUserArrayOutput() GatewaySmbUserArrayOutput {
	return i.ToGatewaySmbUserArrayOutputWithContext(context.Background())
}

func (i GatewaySmbUserArray) ToGatewaySmbUserArrayOutputWithContext(ctx context.Context) GatewaySmbUserArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GatewaySmbUserArrayOutput)
}

// GatewaySmbUserMapInput is an input type that accepts GatewaySmbUserMap and GatewaySmbUserMapOutput values.
// You can construct a concrete instance of `GatewaySmbUserMapInput` via:
//
//	GatewaySmbUserMap{ "key": GatewaySmbUserArgs{...} }
type GatewaySmbUserMapInput interface {
	pulumi.Input

	ToGatewaySmbUserMapOutput() GatewaySmbUserMapOutput
	ToGatewaySmbUserMapOutputWithContext(context.Context) GatewaySmbUserMapOutput
}

type GatewaySmbUserMap map[string]GatewaySmbUserInput

func (GatewaySmbUserMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*GatewaySmbUser)(nil)).Elem()
}

func (i GatewaySmbUserMap) ToGatewaySmbUserMapOutput() GatewaySmbUserMapOutput {
	return i.ToGatewaySmbUserMapOutputWithContext(context.Background())
}

func (i GatewaySmbUserMap) ToGatewaySmbUserMapOutputWithContext(ctx context.Context) GatewaySmbUserMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GatewaySmbUserMapOutput)
}

type GatewaySmbUserOutput struct{ *pulumi.OutputState }

func (GatewaySmbUserOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**GatewaySmbUser)(nil)).Elem()
}

func (o GatewaySmbUserOutput) ToGatewaySmbUserOutput() GatewaySmbUserOutput {
	return o
}

func (o GatewaySmbUserOutput) ToGatewaySmbUserOutputWithContext(ctx context.Context) GatewaySmbUserOutput {
	return o
}

// The Gateway ID of the Gateway SMB User.
func (o GatewaySmbUserOutput) GatewayId() pulumi.StringOutput {
	return o.ApplyT(func(v *GatewaySmbUser) pulumi.StringOutput { return v.GatewayId }).(pulumi.StringOutput)
}

// The password of the Gateway SMB User.
func (o GatewaySmbUserOutput) Password() pulumi.StringOutput {
	return o.ApplyT(func(v *GatewaySmbUser) pulumi.StringOutput { return v.Password }).(pulumi.StringOutput)
}

// The username of the Gateway SMB User.
func (o GatewaySmbUserOutput) Username() pulumi.StringOutput {
	return o.ApplyT(func(v *GatewaySmbUser) pulumi.StringOutput { return v.Username }).(pulumi.StringOutput)
}

type GatewaySmbUserArrayOutput struct{ *pulumi.OutputState }

func (GatewaySmbUserArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*GatewaySmbUser)(nil)).Elem()
}

func (o GatewaySmbUserArrayOutput) ToGatewaySmbUserArrayOutput() GatewaySmbUserArrayOutput {
	return o
}

func (o GatewaySmbUserArrayOutput) ToGatewaySmbUserArrayOutputWithContext(ctx context.Context) GatewaySmbUserArrayOutput {
	return o
}

func (o GatewaySmbUserArrayOutput) Index(i pulumi.IntInput) GatewaySmbUserOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *GatewaySmbUser {
		return vs[0].([]*GatewaySmbUser)[vs[1].(int)]
	}).(GatewaySmbUserOutput)
}

type GatewaySmbUserMapOutput struct{ *pulumi.OutputState }

func (GatewaySmbUserMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*GatewaySmbUser)(nil)).Elem()
}

func (o GatewaySmbUserMapOutput) ToGatewaySmbUserMapOutput() GatewaySmbUserMapOutput {
	return o
}

func (o GatewaySmbUserMapOutput) ToGatewaySmbUserMapOutputWithContext(ctx context.Context) GatewaySmbUserMapOutput {
	return o
}

func (o GatewaySmbUserMapOutput) MapIndex(k pulumi.StringInput) GatewaySmbUserOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *GatewaySmbUser {
		return vs[0].(map[string]*GatewaySmbUser)[vs[1].(string)]
	}).(GatewaySmbUserOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*GatewaySmbUserInput)(nil)).Elem(), &GatewaySmbUser{})
	pulumi.RegisterInputType(reflect.TypeOf((*GatewaySmbUserArrayInput)(nil)).Elem(), GatewaySmbUserArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*GatewaySmbUserMapInput)(nil)).Elem(), GatewaySmbUserMap{})
	pulumi.RegisterOutputType(GatewaySmbUserOutput{})
	pulumi.RegisterOutputType(GatewaySmbUserArrayOutput{})
	pulumi.RegisterOutputType(GatewaySmbUserMapOutput{})
}