// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dcdn

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/rhysmdnz/pulumi-alicloud/sdk/go/alicloud"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "alicloud:dcdn/domain:Domain":
		r = &Domain{}
	case "alicloud:dcdn/domainConfig:DomainConfig":
		r = &DomainConfig{}
	case "alicloud:dcdn/ipaDomain:IpaDomain":
		r = &IpaDomain{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

func init() {
	version, err := alicloud.PkgVersion()
	if err != nil {
		version = semver.Version{Major: 1}
	}
	pulumi.RegisterResourceModule(
		"alicloud",
		"dcdn/domain",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"alicloud",
		"dcdn/domainConfig",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"alicloud",
		"dcdn/ipaDomain",
		&module{version},
	)
}
