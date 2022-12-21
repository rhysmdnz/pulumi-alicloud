// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package eds

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a ECD Simple Office Site resource.
//
// For information about ECD Simple Office Site and how to use it, see [What is Simple Office Site](https://help.aliyun.com/document_detail/188382.html).
//
// > **NOTE:** Available in v1.140.0+.
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
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/eds"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := eds.NewSimpleOfficeSite(ctx, "default", &eds.SimpleOfficeSiteArgs{
//				Bandwidth:         pulumi.Int(5),
//				CidrBlock:         pulumi.String("172.16.0.0/12"),
//				DesktopAccessType: pulumi.String("Internet"),
//				OfficeSiteName:    pulumi.String("site_name"),
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
// ECD Simple Office Site can be imported using the id, e.g.
//
// ```sh
//
//	$ pulumi import alicloud:eds/simpleOfficeSite:SimpleOfficeSite example <id>
//
// ```
type SimpleOfficeSite struct {
	pulumi.CustomResourceState

	// The Internet Bandwidth Peak. It has been deprecated from version 1.142.0 and can be found in the new resource alicloud_ecd_network_package.
	//
	// Deprecated: Field 'bandwidth' has been deprecated from provider version 1.142.0.
	Bandwidth pulumi.IntOutput `pulumi:"bandwidth"`
	// Cloud Enterprise Network Instance ID.
	CenId pulumi.StringPtrOutput `pulumi:"cenId"`
	// The cen owner id.
	CenOwnerId pulumi.StringPtrOutput `pulumi:"cenOwnerId"`
	// Workspace Corresponds to the Security Office Network of IPv4 Segment.
	CidrBlock pulumi.StringOutput `pulumi:"cidrBlock"`
	// Connect to the Cloud Desktop Allows the Use of the Access Mode of. Valid values: `Any`, `Internet`, `VPC`.
	DesktopAccessType pulumi.StringOutput `pulumi:"desktopAccessType"`
	// Whether to Use Cloud Desktop User Empowerment of Local Administrator Permissions.
	EnableAdminAccess pulumi.BoolOutput `pulumi:"enableAdminAccess"`
	// Enable Cross-Desktop Access.
	EnableCrossDesktopAccess pulumi.BoolOutput `pulumi:"enableCrossDesktopAccess"`
	// Whether the Open Internet Access Function.
	//
	// Deprecated: Field 'enable_internet_access' has been deprecated from provider version 1.142.0.
	EnableInternetAccess pulumi.BoolOutput `pulumi:"enableInternetAccess"`
	// Whether to Enable Multi-Factor Authentication MFA.
	MfaEnabled pulumi.BoolOutput `pulumi:"mfaEnabled"`
	// The office site name.
	OfficeSiteName pulumi.StringPtrOutput `pulumi:"officeSiteName"`
	// Whether to Enable Single Sign-on (SSO) for User-Based SSO.
	SsoEnabled pulumi.BoolOutput `pulumi:"ssoEnabled"`
	// Workspace State. Valid Values: `REGISTERED`,`REGISTERING`.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewSimpleOfficeSite registers a new resource with the given unique name, arguments, and options.
func NewSimpleOfficeSite(ctx *pulumi.Context,
	name string, args *SimpleOfficeSiteArgs, opts ...pulumi.ResourceOption) (*SimpleOfficeSite, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CidrBlock == nil {
		return nil, errors.New("invalid value for required argument 'CidrBlock'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource SimpleOfficeSite
	err := ctx.RegisterResource("alicloud:eds/simpleOfficeSite:SimpleOfficeSite", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSimpleOfficeSite gets an existing SimpleOfficeSite resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSimpleOfficeSite(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SimpleOfficeSiteState, opts ...pulumi.ResourceOption) (*SimpleOfficeSite, error) {
	var resource SimpleOfficeSite
	err := ctx.ReadResource("alicloud:eds/simpleOfficeSite:SimpleOfficeSite", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SimpleOfficeSite resources.
type simpleOfficeSiteState struct {
	// The Internet Bandwidth Peak. It has been deprecated from version 1.142.0 and can be found in the new resource alicloud_ecd_network_package.
	//
	// Deprecated: Field 'bandwidth' has been deprecated from provider version 1.142.0.
	Bandwidth *int `pulumi:"bandwidth"`
	// Cloud Enterprise Network Instance ID.
	CenId *string `pulumi:"cenId"`
	// The cen owner id.
	CenOwnerId *string `pulumi:"cenOwnerId"`
	// Workspace Corresponds to the Security Office Network of IPv4 Segment.
	CidrBlock *string `pulumi:"cidrBlock"`
	// Connect to the Cloud Desktop Allows the Use of the Access Mode of. Valid values: `Any`, `Internet`, `VPC`.
	DesktopAccessType *string `pulumi:"desktopAccessType"`
	// Whether to Use Cloud Desktop User Empowerment of Local Administrator Permissions.
	EnableAdminAccess *bool `pulumi:"enableAdminAccess"`
	// Enable Cross-Desktop Access.
	EnableCrossDesktopAccess *bool `pulumi:"enableCrossDesktopAccess"`
	// Whether the Open Internet Access Function.
	//
	// Deprecated: Field 'enable_internet_access' has been deprecated from provider version 1.142.0.
	EnableInternetAccess *bool `pulumi:"enableInternetAccess"`
	// Whether to Enable Multi-Factor Authentication MFA.
	MfaEnabled *bool `pulumi:"mfaEnabled"`
	// The office site name.
	OfficeSiteName *string `pulumi:"officeSiteName"`
	// Whether to Enable Single Sign-on (SSO) for User-Based SSO.
	SsoEnabled *bool `pulumi:"ssoEnabled"`
	// Workspace State. Valid Values: `REGISTERED`,`REGISTERING`.
	Status *string `pulumi:"status"`
}

type SimpleOfficeSiteState struct {
	// The Internet Bandwidth Peak. It has been deprecated from version 1.142.0 and can be found in the new resource alicloud_ecd_network_package.
	//
	// Deprecated: Field 'bandwidth' has been deprecated from provider version 1.142.0.
	Bandwidth pulumi.IntPtrInput
	// Cloud Enterprise Network Instance ID.
	CenId pulumi.StringPtrInput
	// The cen owner id.
	CenOwnerId pulumi.StringPtrInput
	// Workspace Corresponds to the Security Office Network of IPv4 Segment.
	CidrBlock pulumi.StringPtrInput
	// Connect to the Cloud Desktop Allows the Use of the Access Mode of. Valid values: `Any`, `Internet`, `VPC`.
	DesktopAccessType pulumi.StringPtrInput
	// Whether to Use Cloud Desktop User Empowerment of Local Administrator Permissions.
	EnableAdminAccess pulumi.BoolPtrInput
	// Enable Cross-Desktop Access.
	EnableCrossDesktopAccess pulumi.BoolPtrInput
	// Whether the Open Internet Access Function.
	//
	// Deprecated: Field 'enable_internet_access' has been deprecated from provider version 1.142.0.
	EnableInternetAccess pulumi.BoolPtrInput
	// Whether to Enable Multi-Factor Authentication MFA.
	MfaEnabled pulumi.BoolPtrInput
	// The office site name.
	OfficeSiteName pulumi.StringPtrInput
	// Whether to Enable Single Sign-on (SSO) for User-Based SSO.
	SsoEnabled pulumi.BoolPtrInput
	// Workspace State. Valid Values: `REGISTERED`,`REGISTERING`.
	Status pulumi.StringPtrInput
}

func (SimpleOfficeSiteState) ElementType() reflect.Type {
	return reflect.TypeOf((*simpleOfficeSiteState)(nil)).Elem()
}

type simpleOfficeSiteArgs struct {
	// The Internet Bandwidth Peak. It has been deprecated from version 1.142.0 and can be found in the new resource alicloud_ecd_network_package.
	//
	// Deprecated: Field 'bandwidth' has been deprecated from provider version 1.142.0.
	Bandwidth *int `pulumi:"bandwidth"`
	// Cloud Enterprise Network Instance ID.
	CenId *string `pulumi:"cenId"`
	// The cen owner id.
	CenOwnerId *string `pulumi:"cenOwnerId"`
	// Workspace Corresponds to the Security Office Network of IPv4 Segment.
	CidrBlock string `pulumi:"cidrBlock"`
	// Connect to the Cloud Desktop Allows the Use of the Access Mode of. Valid values: `Any`, `Internet`, `VPC`.
	DesktopAccessType *string `pulumi:"desktopAccessType"`
	// Whether to Use Cloud Desktop User Empowerment of Local Administrator Permissions.
	EnableAdminAccess *bool `pulumi:"enableAdminAccess"`
	// Enable Cross-Desktop Access.
	EnableCrossDesktopAccess *bool `pulumi:"enableCrossDesktopAccess"`
	// Whether the Open Internet Access Function.
	//
	// Deprecated: Field 'enable_internet_access' has been deprecated from provider version 1.142.0.
	EnableInternetAccess *bool `pulumi:"enableInternetAccess"`
	// Whether to Enable Multi-Factor Authentication MFA.
	MfaEnabled *bool `pulumi:"mfaEnabled"`
	// The office site name.
	OfficeSiteName *string `pulumi:"officeSiteName"`
	// Whether to Enable Single Sign-on (SSO) for User-Based SSO.
	SsoEnabled *bool `pulumi:"ssoEnabled"`
}

// The set of arguments for constructing a SimpleOfficeSite resource.
type SimpleOfficeSiteArgs struct {
	// The Internet Bandwidth Peak. It has been deprecated from version 1.142.0 and can be found in the new resource alicloud_ecd_network_package.
	//
	// Deprecated: Field 'bandwidth' has been deprecated from provider version 1.142.0.
	Bandwidth pulumi.IntPtrInput
	// Cloud Enterprise Network Instance ID.
	CenId pulumi.StringPtrInput
	// The cen owner id.
	CenOwnerId pulumi.StringPtrInput
	// Workspace Corresponds to the Security Office Network of IPv4 Segment.
	CidrBlock pulumi.StringInput
	// Connect to the Cloud Desktop Allows the Use of the Access Mode of. Valid values: `Any`, `Internet`, `VPC`.
	DesktopAccessType pulumi.StringPtrInput
	// Whether to Use Cloud Desktop User Empowerment of Local Administrator Permissions.
	EnableAdminAccess pulumi.BoolPtrInput
	// Enable Cross-Desktop Access.
	EnableCrossDesktopAccess pulumi.BoolPtrInput
	// Whether the Open Internet Access Function.
	//
	// Deprecated: Field 'enable_internet_access' has been deprecated from provider version 1.142.0.
	EnableInternetAccess pulumi.BoolPtrInput
	// Whether to Enable Multi-Factor Authentication MFA.
	MfaEnabled pulumi.BoolPtrInput
	// The office site name.
	OfficeSiteName pulumi.StringPtrInput
	// Whether to Enable Single Sign-on (SSO) for User-Based SSO.
	SsoEnabled pulumi.BoolPtrInput
}

func (SimpleOfficeSiteArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*simpleOfficeSiteArgs)(nil)).Elem()
}

type SimpleOfficeSiteInput interface {
	pulumi.Input

	ToSimpleOfficeSiteOutput() SimpleOfficeSiteOutput
	ToSimpleOfficeSiteOutputWithContext(ctx context.Context) SimpleOfficeSiteOutput
}

func (*SimpleOfficeSite) ElementType() reflect.Type {
	return reflect.TypeOf((**SimpleOfficeSite)(nil)).Elem()
}

func (i *SimpleOfficeSite) ToSimpleOfficeSiteOutput() SimpleOfficeSiteOutput {
	return i.ToSimpleOfficeSiteOutputWithContext(context.Background())
}

func (i *SimpleOfficeSite) ToSimpleOfficeSiteOutputWithContext(ctx context.Context) SimpleOfficeSiteOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SimpleOfficeSiteOutput)
}

// SimpleOfficeSiteArrayInput is an input type that accepts SimpleOfficeSiteArray and SimpleOfficeSiteArrayOutput values.
// You can construct a concrete instance of `SimpleOfficeSiteArrayInput` via:
//
//	SimpleOfficeSiteArray{ SimpleOfficeSiteArgs{...} }
type SimpleOfficeSiteArrayInput interface {
	pulumi.Input

	ToSimpleOfficeSiteArrayOutput() SimpleOfficeSiteArrayOutput
	ToSimpleOfficeSiteArrayOutputWithContext(context.Context) SimpleOfficeSiteArrayOutput
}

type SimpleOfficeSiteArray []SimpleOfficeSiteInput

func (SimpleOfficeSiteArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SimpleOfficeSite)(nil)).Elem()
}

func (i SimpleOfficeSiteArray) ToSimpleOfficeSiteArrayOutput() SimpleOfficeSiteArrayOutput {
	return i.ToSimpleOfficeSiteArrayOutputWithContext(context.Background())
}

func (i SimpleOfficeSiteArray) ToSimpleOfficeSiteArrayOutputWithContext(ctx context.Context) SimpleOfficeSiteArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SimpleOfficeSiteArrayOutput)
}

// SimpleOfficeSiteMapInput is an input type that accepts SimpleOfficeSiteMap and SimpleOfficeSiteMapOutput values.
// You can construct a concrete instance of `SimpleOfficeSiteMapInput` via:
//
//	SimpleOfficeSiteMap{ "key": SimpleOfficeSiteArgs{...} }
type SimpleOfficeSiteMapInput interface {
	pulumi.Input

	ToSimpleOfficeSiteMapOutput() SimpleOfficeSiteMapOutput
	ToSimpleOfficeSiteMapOutputWithContext(context.Context) SimpleOfficeSiteMapOutput
}

type SimpleOfficeSiteMap map[string]SimpleOfficeSiteInput

func (SimpleOfficeSiteMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SimpleOfficeSite)(nil)).Elem()
}

func (i SimpleOfficeSiteMap) ToSimpleOfficeSiteMapOutput() SimpleOfficeSiteMapOutput {
	return i.ToSimpleOfficeSiteMapOutputWithContext(context.Background())
}

func (i SimpleOfficeSiteMap) ToSimpleOfficeSiteMapOutputWithContext(ctx context.Context) SimpleOfficeSiteMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SimpleOfficeSiteMapOutput)
}

type SimpleOfficeSiteOutput struct{ *pulumi.OutputState }

func (SimpleOfficeSiteOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SimpleOfficeSite)(nil)).Elem()
}

func (o SimpleOfficeSiteOutput) ToSimpleOfficeSiteOutput() SimpleOfficeSiteOutput {
	return o
}

func (o SimpleOfficeSiteOutput) ToSimpleOfficeSiteOutputWithContext(ctx context.Context) SimpleOfficeSiteOutput {
	return o
}

// The Internet Bandwidth Peak. It has been deprecated from version 1.142.0 and can be found in the new resource alicloud_ecd_network_package.
//
// Deprecated: Field 'bandwidth' has been deprecated from provider version 1.142.0.
func (o SimpleOfficeSiteOutput) Bandwidth() pulumi.IntOutput {
	return o.ApplyT(func(v *SimpleOfficeSite) pulumi.IntOutput { return v.Bandwidth }).(pulumi.IntOutput)
}

// Cloud Enterprise Network Instance ID.
func (o SimpleOfficeSiteOutput) CenId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SimpleOfficeSite) pulumi.StringPtrOutput { return v.CenId }).(pulumi.StringPtrOutput)
}

// The cen owner id.
func (o SimpleOfficeSiteOutput) CenOwnerId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SimpleOfficeSite) pulumi.StringPtrOutput { return v.CenOwnerId }).(pulumi.StringPtrOutput)
}

// Workspace Corresponds to the Security Office Network of IPv4 Segment.
func (o SimpleOfficeSiteOutput) CidrBlock() pulumi.StringOutput {
	return o.ApplyT(func(v *SimpleOfficeSite) pulumi.StringOutput { return v.CidrBlock }).(pulumi.StringOutput)
}

// Connect to the Cloud Desktop Allows the Use of the Access Mode of. Valid values: `Any`, `Internet`, `VPC`.
func (o SimpleOfficeSiteOutput) DesktopAccessType() pulumi.StringOutput {
	return o.ApplyT(func(v *SimpleOfficeSite) pulumi.StringOutput { return v.DesktopAccessType }).(pulumi.StringOutput)
}

// Whether to Use Cloud Desktop User Empowerment of Local Administrator Permissions.
func (o SimpleOfficeSiteOutput) EnableAdminAccess() pulumi.BoolOutput {
	return o.ApplyT(func(v *SimpleOfficeSite) pulumi.BoolOutput { return v.EnableAdminAccess }).(pulumi.BoolOutput)
}

// Enable Cross-Desktop Access.
func (o SimpleOfficeSiteOutput) EnableCrossDesktopAccess() pulumi.BoolOutput {
	return o.ApplyT(func(v *SimpleOfficeSite) pulumi.BoolOutput { return v.EnableCrossDesktopAccess }).(pulumi.BoolOutput)
}

// Whether the Open Internet Access Function.
//
// Deprecated: Field 'enable_internet_access' has been deprecated from provider version 1.142.0.
func (o SimpleOfficeSiteOutput) EnableInternetAccess() pulumi.BoolOutput {
	return o.ApplyT(func(v *SimpleOfficeSite) pulumi.BoolOutput { return v.EnableInternetAccess }).(pulumi.BoolOutput)
}

// Whether to Enable Multi-Factor Authentication MFA.
func (o SimpleOfficeSiteOutput) MfaEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *SimpleOfficeSite) pulumi.BoolOutput { return v.MfaEnabled }).(pulumi.BoolOutput)
}

// The office site name.
func (o SimpleOfficeSiteOutput) OfficeSiteName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SimpleOfficeSite) pulumi.StringPtrOutput { return v.OfficeSiteName }).(pulumi.StringPtrOutput)
}

// Whether to Enable Single Sign-on (SSO) for User-Based SSO.
func (o SimpleOfficeSiteOutput) SsoEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *SimpleOfficeSite) pulumi.BoolOutput { return v.SsoEnabled }).(pulumi.BoolOutput)
}

// Workspace State. Valid Values: `REGISTERED`,`REGISTERING`.
func (o SimpleOfficeSiteOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *SimpleOfficeSite) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type SimpleOfficeSiteArrayOutput struct{ *pulumi.OutputState }

func (SimpleOfficeSiteArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SimpleOfficeSite)(nil)).Elem()
}

func (o SimpleOfficeSiteArrayOutput) ToSimpleOfficeSiteArrayOutput() SimpleOfficeSiteArrayOutput {
	return o
}

func (o SimpleOfficeSiteArrayOutput) ToSimpleOfficeSiteArrayOutputWithContext(ctx context.Context) SimpleOfficeSiteArrayOutput {
	return o
}

func (o SimpleOfficeSiteArrayOutput) Index(i pulumi.IntInput) SimpleOfficeSiteOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *SimpleOfficeSite {
		return vs[0].([]*SimpleOfficeSite)[vs[1].(int)]
	}).(SimpleOfficeSiteOutput)
}

type SimpleOfficeSiteMapOutput struct{ *pulumi.OutputState }

func (SimpleOfficeSiteMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SimpleOfficeSite)(nil)).Elem()
}

func (o SimpleOfficeSiteMapOutput) ToSimpleOfficeSiteMapOutput() SimpleOfficeSiteMapOutput {
	return o
}

func (o SimpleOfficeSiteMapOutput) ToSimpleOfficeSiteMapOutputWithContext(ctx context.Context) SimpleOfficeSiteMapOutput {
	return o
}

func (o SimpleOfficeSiteMapOutput) MapIndex(k pulumi.StringInput) SimpleOfficeSiteOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *SimpleOfficeSite {
		return vs[0].(map[string]*SimpleOfficeSite)[vs[1].(string)]
	}).(SimpleOfficeSiteOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SimpleOfficeSiteInput)(nil)).Elem(), &SimpleOfficeSite{})
	pulumi.RegisterInputType(reflect.TypeOf((*SimpleOfficeSiteArrayInput)(nil)).Elem(), SimpleOfficeSiteArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*SimpleOfficeSiteMapInput)(nil)).Elem(), SimpleOfficeSiteMap{})
	pulumi.RegisterOutputType(SimpleOfficeSiteOutput{})
	pulumi.RegisterOutputType(SimpleOfficeSiteArrayOutput{})
	pulumi.RegisterOutputType(SimpleOfficeSiteMapOutput{})
}