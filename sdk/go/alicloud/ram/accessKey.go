// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ram

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a RAM User access key resource.
//
// > **NOTE:**  You should set the `secretFile` if you want to get the access key.
//
// > **NOTE:**  From version 1.98.0, if not set `pgpKey`, the resource will output the access key secret to field `secret` and please protect your backend state file judiciously
//
// ## Example Usage
//
// Output the secret to a file.
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/ram"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			user, err := ram.NewUser(ctx, "user", &ram.UserArgs{
//				DisplayName: pulumi.String("user_display_name"),
//				Mobile:      pulumi.String("86-18688888888"),
//				Email:       pulumi.String("hello.uuu@aaa.com"),
//				Comments:    pulumi.String("yoyoyo"),
//				Force:       pulumi.Bool(true),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = ram.NewAccessKey(ctx, "ak", &ram.AccessKeyArgs{
//				UserName:   user.Name,
//				SecretFile: pulumi.String("/xxx/xxx/xxx.txt"),
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
// Using `pgpKey` to encrypt the secret.
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud/ram"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			user, err := ram.NewUser(ctx, "user", &ram.UserArgs{
//				DisplayName: pulumi.String("user_display_name"),
//				Mobile:      pulumi.String("86-18688888888"),
//				Email:       pulumi.String("hello.uuu@aaa.com"),
//				Comments:    pulumi.String("yoyoyo"),
//				Force:       pulumi.Bool(true),
//			})
//			if err != nil {
//				return err
//			}
//			encrypt, err := ram.NewAccessKey(ctx, "encrypt", &ram.AccessKeyArgs{
//				UserName: user.Name,
//				PgpKey:   pulumi.String("keybase:some_person_that_exists"),
//			})
//			if err != nil {
//				return err
//			}
//			ctx.Export("secret", encrypt.EncryptedSecret)
//			return nil
//		})
//	}
//
// ```
type AccessKey struct {
	pulumi.CustomResourceState

	EncryptedSecret pulumi.StringOutput `pulumi:"encryptedSecret"`
	// The fingerprint of the PGP key used to encrypt the secret
	KeyFingerprint pulumi.StringOutput `pulumi:"keyFingerprint"`
	// Either a base-64 encoded PGP public key, or a keybase username in the form `keybase:some_person_that_exists`
	PgpKey pulumi.StringPtrOutput `pulumi:"pgpKey"`
	Secret pulumi.StringOutput    `pulumi:"secret"`
	// The name of file that can save access key id and access key secret. Strongly suggest you to specified it when you creating access key, otherwise, you wouldn't get its secret ever.
	SecretFile pulumi.StringPtrOutput `pulumi:"secretFile"`
	// Status of access key. It must be `Active` or `Inactive`. Default value is `Active`.
	Status pulumi.StringPtrOutput `pulumi:"status"`
	// Name of the RAM user. This name can have a string of 1 to 64 characters, must contain only alphanumeric characters or hyphens, such as "-",".","_", and must not begin with a hyphen.
	UserName pulumi.StringPtrOutput `pulumi:"userName"`
}

// NewAccessKey registers a new resource with the given unique name, arguments, and options.
func NewAccessKey(ctx *pulumi.Context,
	name string, args *AccessKeyArgs, opts ...pulumi.ResourceOption) (*AccessKey, error) {
	if args == nil {
		args = &AccessKeyArgs{}
	}

	opts = pkgResourceDefaultOpts(opts)
	var resource AccessKey
	err := ctx.RegisterResource("alicloud:ram/accessKey:AccessKey", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAccessKey gets an existing AccessKey resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAccessKey(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AccessKeyState, opts ...pulumi.ResourceOption) (*AccessKey, error) {
	var resource AccessKey
	err := ctx.ReadResource("alicloud:ram/accessKey:AccessKey", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AccessKey resources.
type accessKeyState struct {
	EncryptedSecret *string `pulumi:"encryptedSecret"`
	// The fingerprint of the PGP key used to encrypt the secret
	KeyFingerprint *string `pulumi:"keyFingerprint"`
	// Either a base-64 encoded PGP public key, or a keybase username in the form `keybase:some_person_that_exists`
	PgpKey *string `pulumi:"pgpKey"`
	Secret *string `pulumi:"secret"`
	// The name of file that can save access key id and access key secret. Strongly suggest you to specified it when you creating access key, otherwise, you wouldn't get its secret ever.
	SecretFile *string `pulumi:"secretFile"`
	// Status of access key. It must be `Active` or `Inactive`. Default value is `Active`.
	Status *string `pulumi:"status"`
	// Name of the RAM user. This name can have a string of 1 to 64 characters, must contain only alphanumeric characters or hyphens, such as "-",".","_", and must not begin with a hyphen.
	UserName *string `pulumi:"userName"`
}

type AccessKeyState struct {
	EncryptedSecret pulumi.StringPtrInput
	// The fingerprint of the PGP key used to encrypt the secret
	KeyFingerprint pulumi.StringPtrInput
	// Either a base-64 encoded PGP public key, or a keybase username in the form `keybase:some_person_that_exists`
	PgpKey pulumi.StringPtrInput
	Secret pulumi.StringPtrInput
	// The name of file that can save access key id and access key secret. Strongly suggest you to specified it when you creating access key, otherwise, you wouldn't get its secret ever.
	SecretFile pulumi.StringPtrInput
	// Status of access key. It must be `Active` or `Inactive`. Default value is `Active`.
	Status pulumi.StringPtrInput
	// Name of the RAM user. This name can have a string of 1 to 64 characters, must contain only alphanumeric characters or hyphens, such as "-",".","_", and must not begin with a hyphen.
	UserName pulumi.StringPtrInput
}

func (AccessKeyState) ElementType() reflect.Type {
	return reflect.TypeOf((*accessKeyState)(nil)).Elem()
}

type accessKeyArgs struct {
	// Either a base-64 encoded PGP public key, or a keybase username in the form `keybase:some_person_that_exists`
	PgpKey *string `pulumi:"pgpKey"`
	// The name of file that can save access key id and access key secret. Strongly suggest you to specified it when you creating access key, otherwise, you wouldn't get its secret ever.
	SecretFile *string `pulumi:"secretFile"`
	// Status of access key. It must be `Active` or `Inactive`. Default value is `Active`.
	Status *string `pulumi:"status"`
	// Name of the RAM user. This name can have a string of 1 to 64 characters, must contain only alphanumeric characters or hyphens, such as "-",".","_", and must not begin with a hyphen.
	UserName *string `pulumi:"userName"`
}

// The set of arguments for constructing a AccessKey resource.
type AccessKeyArgs struct {
	// Either a base-64 encoded PGP public key, or a keybase username in the form `keybase:some_person_that_exists`
	PgpKey pulumi.StringPtrInput
	// The name of file that can save access key id and access key secret. Strongly suggest you to specified it when you creating access key, otherwise, you wouldn't get its secret ever.
	SecretFile pulumi.StringPtrInput
	// Status of access key. It must be `Active` or `Inactive`. Default value is `Active`.
	Status pulumi.StringPtrInput
	// Name of the RAM user. This name can have a string of 1 to 64 characters, must contain only alphanumeric characters or hyphens, such as "-",".","_", and must not begin with a hyphen.
	UserName pulumi.StringPtrInput
}

func (AccessKeyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*accessKeyArgs)(nil)).Elem()
}

type AccessKeyInput interface {
	pulumi.Input

	ToAccessKeyOutput() AccessKeyOutput
	ToAccessKeyOutputWithContext(ctx context.Context) AccessKeyOutput
}

func (*AccessKey) ElementType() reflect.Type {
	return reflect.TypeOf((**AccessKey)(nil)).Elem()
}

func (i *AccessKey) ToAccessKeyOutput() AccessKeyOutput {
	return i.ToAccessKeyOutputWithContext(context.Background())
}

func (i *AccessKey) ToAccessKeyOutputWithContext(ctx context.Context) AccessKeyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessKeyOutput)
}

// AccessKeyArrayInput is an input type that accepts AccessKeyArray and AccessKeyArrayOutput values.
// You can construct a concrete instance of `AccessKeyArrayInput` via:
//
//	AccessKeyArray{ AccessKeyArgs{...} }
type AccessKeyArrayInput interface {
	pulumi.Input

	ToAccessKeyArrayOutput() AccessKeyArrayOutput
	ToAccessKeyArrayOutputWithContext(context.Context) AccessKeyArrayOutput
}

type AccessKeyArray []AccessKeyInput

func (AccessKeyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AccessKey)(nil)).Elem()
}

func (i AccessKeyArray) ToAccessKeyArrayOutput() AccessKeyArrayOutput {
	return i.ToAccessKeyArrayOutputWithContext(context.Background())
}

func (i AccessKeyArray) ToAccessKeyArrayOutputWithContext(ctx context.Context) AccessKeyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessKeyArrayOutput)
}

// AccessKeyMapInput is an input type that accepts AccessKeyMap and AccessKeyMapOutput values.
// You can construct a concrete instance of `AccessKeyMapInput` via:
//
//	AccessKeyMap{ "key": AccessKeyArgs{...} }
type AccessKeyMapInput interface {
	pulumi.Input

	ToAccessKeyMapOutput() AccessKeyMapOutput
	ToAccessKeyMapOutputWithContext(context.Context) AccessKeyMapOutput
}

type AccessKeyMap map[string]AccessKeyInput

func (AccessKeyMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AccessKey)(nil)).Elem()
}

func (i AccessKeyMap) ToAccessKeyMapOutput() AccessKeyMapOutput {
	return i.ToAccessKeyMapOutputWithContext(context.Background())
}

func (i AccessKeyMap) ToAccessKeyMapOutputWithContext(ctx context.Context) AccessKeyMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessKeyMapOutput)
}

type AccessKeyOutput struct{ *pulumi.OutputState }

func (AccessKeyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AccessKey)(nil)).Elem()
}

func (o AccessKeyOutput) ToAccessKeyOutput() AccessKeyOutput {
	return o
}

func (o AccessKeyOutput) ToAccessKeyOutputWithContext(ctx context.Context) AccessKeyOutput {
	return o
}

func (o AccessKeyOutput) EncryptedSecret() pulumi.StringOutput {
	return o.ApplyT(func(v *AccessKey) pulumi.StringOutput { return v.EncryptedSecret }).(pulumi.StringOutput)
}

// The fingerprint of the PGP key used to encrypt the secret
func (o AccessKeyOutput) KeyFingerprint() pulumi.StringOutput {
	return o.ApplyT(func(v *AccessKey) pulumi.StringOutput { return v.KeyFingerprint }).(pulumi.StringOutput)
}

// Either a base-64 encoded PGP public key, or a keybase username in the form `keybase:some_person_that_exists`
func (o AccessKeyOutput) PgpKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AccessKey) pulumi.StringPtrOutput { return v.PgpKey }).(pulumi.StringPtrOutput)
}

func (o AccessKeyOutput) Secret() pulumi.StringOutput {
	return o.ApplyT(func(v *AccessKey) pulumi.StringOutput { return v.Secret }).(pulumi.StringOutput)
}

// The name of file that can save access key id and access key secret. Strongly suggest you to specified it when you creating access key, otherwise, you wouldn't get its secret ever.
func (o AccessKeyOutput) SecretFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AccessKey) pulumi.StringPtrOutput { return v.SecretFile }).(pulumi.StringPtrOutput)
}

// Status of access key. It must be `Active` or `Inactive`. Default value is `Active`.
func (o AccessKeyOutput) Status() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AccessKey) pulumi.StringPtrOutput { return v.Status }).(pulumi.StringPtrOutput)
}

// Name of the RAM user. This name can have a string of 1 to 64 characters, must contain only alphanumeric characters or hyphens, such as "-",".","_", and must not begin with a hyphen.
func (o AccessKeyOutput) UserName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AccessKey) pulumi.StringPtrOutput { return v.UserName }).(pulumi.StringPtrOutput)
}

type AccessKeyArrayOutput struct{ *pulumi.OutputState }

func (AccessKeyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AccessKey)(nil)).Elem()
}

func (o AccessKeyArrayOutput) ToAccessKeyArrayOutput() AccessKeyArrayOutput {
	return o
}

func (o AccessKeyArrayOutput) ToAccessKeyArrayOutputWithContext(ctx context.Context) AccessKeyArrayOutput {
	return o
}

func (o AccessKeyArrayOutput) Index(i pulumi.IntInput) AccessKeyOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AccessKey {
		return vs[0].([]*AccessKey)[vs[1].(int)]
	}).(AccessKeyOutput)
}

type AccessKeyMapOutput struct{ *pulumi.OutputState }

func (AccessKeyMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AccessKey)(nil)).Elem()
}

func (o AccessKeyMapOutput) ToAccessKeyMapOutput() AccessKeyMapOutput {
	return o
}

func (o AccessKeyMapOutput) ToAccessKeyMapOutputWithContext(ctx context.Context) AccessKeyMapOutput {
	return o
}

func (o AccessKeyMapOutput) MapIndex(k pulumi.StringInput) AccessKeyOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AccessKey {
		return vs[0].(map[string]*AccessKey)[vs[1].(string)]
	}).(AccessKeyOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AccessKeyInput)(nil)).Elem(), &AccessKey{})
	pulumi.RegisterInputType(reflect.TypeOf((*AccessKeyArrayInput)(nil)).Elem(), AccessKeyArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AccessKeyMapInput)(nil)).Elem(), AccessKeyMap{})
	pulumi.RegisterOutputType(AccessKeyOutput{})
	pulumi.RegisterOutputType(AccessKeyArrayOutput{})
	pulumi.RegisterOutputType(AccessKeyMapOutput{})
}