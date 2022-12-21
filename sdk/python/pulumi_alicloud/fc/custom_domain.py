# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['CustomDomainArgs', 'CustomDomain']

@pulumi.input_type
class CustomDomainArgs:
    def __init__(__self__, *,
                 domain_name: pulumi.Input[str],
                 protocol: pulumi.Input[str],
                 cert_config: Optional[pulumi.Input['CustomDomainCertConfigArgs']] = None,
                 route_configs: Optional[pulumi.Input[Sequence[pulumi.Input['CustomDomainRouteConfigArgs']]]] = None):
        """
        The set of arguments for constructing a CustomDomain resource.
        :param pulumi.Input[str] domain_name: The custom domain name. For example, "example.com".
        :param pulumi.Input[str] protocol: The protocol, `HTTP` or `HTTP,HTTPS`.
        :param pulumi.Input['CustomDomainCertConfigArgs'] cert_config: The configuration of HTTPS certificate.
        :param pulumi.Input[Sequence[pulumi.Input['CustomDomainRouteConfigArgs']]] route_configs: The configuration of domain route, mapping the path and Function Compute function.
        """
        pulumi.set(__self__, "domain_name", domain_name)
        pulumi.set(__self__, "protocol", protocol)
        if cert_config is not None:
            pulumi.set(__self__, "cert_config", cert_config)
        if route_configs is not None:
            pulumi.set(__self__, "route_configs", route_configs)

    @property
    @pulumi.getter(name="domainName")
    def domain_name(self) -> pulumi.Input[str]:
        """
        The custom domain name. For example, "example.com".
        """
        return pulumi.get(self, "domain_name")

    @domain_name.setter
    def domain_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "domain_name", value)

    @property
    @pulumi.getter
    def protocol(self) -> pulumi.Input[str]:
        """
        The protocol, `HTTP` or `HTTP,HTTPS`.
        """
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: pulumi.Input[str]):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter(name="certConfig")
    def cert_config(self) -> Optional[pulumi.Input['CustomDomainCertConfigArgs']]:
        """
        The configuration of HTTPS certificate.
        """
        return pulumi.get(self, "cert_config")

    @cert_config.setter
    def cert_config(self, value: Optional[pulumi.Input['CustomDomainCertConfigArgs']]):
        pulumi.set(self, "cert_config", value)

    @property
    @pulumi.getter(name="routeConfigs")
    def route_configs(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['CustomDomainRouteConfigArgs']]]]:
        """
        The configuration of domain route, mapping the path and Function Compute function.
        """
        return pulumi.get(self, "route_configs")

    @route_configs.setter
    def route_configs(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['CustomDomainRouteConfigArgs']]]]):
        pulumi.set(self, "route_configs", value)


@pulumi.input_type
class _CustomDomainState:
    def __init__(__self__, *,
                 account_id: Optional[pulumi.Input[str]] = None,
                 api_version: Optional[pulumi.Input[str]] = None,
                 cert_config: Optional[pulumi.Input['CustomDomainCertConfigArgs']] = None,
                 created_time: Optional[pulumi.Input[str]] = None,
                 domain_name: Optional[pulumi.Input[str]] = None,
                 last_modified_time: Optional[pulumi.Input[str]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 route_configs: Optional[pulumi.Input[Sequence[pulumi.Input['CustomDomainRouteConfigArgs']]]] = None):
        """
        Input properties used for looking up and filtering CustomDomain resources.
        :param pulumi.Input[str] account_id: The account id.
        :param pulumi.Input[str] api_version: The api version of Function Compute.
        :param pulumi.Input['CustomDomainCertConfigArgs'] cert_config: The configuration of HTTPS certificate.
        :param pulumi.Input[str] created_time: The date this resource was created.
        :param pulumi.Input[str] domain_name: The custom domain name. For example, "example.com".
        :param pulumi.Input[str] last_modified_time: The date this resource was last modified.
        :param pulumi.Input[str] protocol: The protocol, `HTTP` or `HTTP,HTTPS`.
        :param pulumi.Input[Sequence[pulumi.Input['CustomDomainRouteConfigArgs']]] route_configs: The configuration of domain route, mapping the path and Function Compute function.
        """
        if account_id is not None:
            pulumi.set(__self__, "account_id", account_id)
        if api_version is not None:
            pulumi.set(__self__, "api_version", api_version)
        if cert_config is not None:
            pulumi.set(__self__, "cert_config", cert_config)
        if created_time is not None:
            pulumi.set(__self__, "created_time", created_time)
        if domain_name is not None:
            pulumi.set(__self__, "domain_name", domain_name)
        if last_modified_time is not None:
            pulumi.set(__self__, "last_modified_time", last_modified_time)
        if protocol is not None:
            pulumi.set(__self__, "protocol", protocol)
        if route_configs is not None:
            pulumi.set(__self__, "route_configs", route_configs)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> Optional[pulumi.Input[str]]:
        """
        The account id.
        """
        return pulumi.get(self, "account_id")

    @account_id.setter
    def account_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "account_id", value)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> Optional[pulumi.Input[str]]:
        """
        The api version of Function Compute.
        """
        return pulumi.get(self, "api_version")

    @api_version.setter
    def api_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "api_version", value)

    @property
    @pulumi.getter(name="certConfig")
    def cert_config(self) -> Optional[pulumi.Input['CustomDomainCertConfigArgs']]:
        """
        The configuration of HTTPS certificate.
        """
        return pulumi.get(self, "cert_config")

    @cert_config.setter
    def cert_config(self, value: Optional[pulumi.Input['CustomDomainCertConfigArgs']]):
        pulumi.set(self, "cert_config", value)

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> Optional[pulumi.Input[str]]:
        """
        The date this resource was created.
        """
        return pulumi.get(self, "created_time")

    @created_time.setter
    def created_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_time", value)

    @property
    @pulumi.getter(name="domainName")
    def domain_name(self) -> Optional[pulumi.Input[str]]:
        """
        The custom domain name. For example, "example.com".
        """
        return pulumi.get(self, "domain_name")

    @domain_name.setter
    def domain_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "domain_name", value)

    @property
    @pulumi.getter(name="lastModifiedTime")
    def last_modified_time(self) -> Optional[pulumi.Input[str]]:
        """
        The date this resource was last modified.
        """
        return pulumi.get(self, "last_modified_time")

    @last_modified_time.setter
    def last_modified_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "last_modified_time", value)

    @property
    @pulumi.getter
    def protocol(self) -> Optional[pulumi.Input[str]]:
        """
        The protocol, `HTTP` or `HTTP,HTTPS`.
        """
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter(name="routeConfigs")
    def route_configs(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['CustomDomainRouteConfigArgs']]]]:
        """
        The configuration of domain route, mapping the path and Function Compute function.
        """
        return pulumi.get(self, "route_configs")

    @route_configs.setter
    def route_configs(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['CustomDomainRouteConfigArgs']]]]):
        pulumi.set(self, "route_configs", value)


class CustomDomain(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cert_config: Optional[pulumi.Input[pulumi.InputType['CustomDomainCertConfigArgs']]] = None,
                 domain_name: Optional[pulumi.Input[str]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 route_configs: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CustomDomainRouteConfigArgs']]]]] = None,
                 __props__=None):
        """
        Provides an Alicloud Function Compute custom domain resource.
         For the detailed information, please refer to the [developer guide](https://www.alibabacloud.com/help/doc-detail/90759.htm).

        > **NOTE:** Available in 1.98.0+

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        config = pulumi.Config()
        name = config.get("name")
        if name is None:
            name = "tf-testaccalicloudfcservice"
        default_service = alicloud.fc.Service("defaultService", description=f"{name}-description")
        default_bucket = alicloud.oss.Bucket("defaultBucket", bucket=name)
        default_bucket_object = alicloud.oss.BucketObject("defaultBucketObject",
            bucket=default_bucket.id,
            key="fc/hello.zip",
            content=\"\"\"		# -*- coding: utf-8 -*-
        	def handler(event, context):
        		print "hello world"
        		return 'hello world'
        \"\"\")
        default_function = alicloud.fc.Function("defaultFunction",
            service=default_service.name,
            oss_bucket=default_bucket.id,
            oss_key=default_bucket_object.key,
            memory_size=512,
            runtime="python2.7",
            handler="hello.handler")
        default_custom_domain = alicloud.fc.CustomDomain("defaultCustomDomain",
            domain_name="terraform.functioncompute.com",
            protocol="HTTP",
            route_configs=[alicloud.fc.CustomDomainRouteConfigArgs(
                path="/login/*",
                service_name=default_service.name,
                function_name=default_function.name,
                qualifier="v1",
                methods=[
                    "GET",
                    "POST",
                ],
            )],
            cert_config=alicloud.fc.CustomDomainCertConfigArgs(
                cert_name="your certificate name",
                private_key="your private key",
                certificate="your certificate data",
            ))
        ```

        ## Import

        Function Compute custom domain can be imported using the id or the domain name, e.g.

        ```sh
         $ pulumi import alicloud:fc/customDomain:CustomDomain foo my-fc-custom-domain
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['CustomDomainCertConfigArgs']] cert_config: The configuration of HTTPS certificate.
        :param pulumi.Input[str] domain_name: The custom domain name. For example, "example.com".
        :param pulumi.Input[str] protocol: The protocol, `HTTP` or `HTTP,HTTPS`.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CustomDomainRouteConfigArgs']]]] route_configs: The configuration of domain route, mapping the path and Function Compute function.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: CustomDomainArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides an Alicloud Function Compute custom domain resource.
         For the detailed information, please refer to the [developer guide](https://www.alibabacloud.com/help/doc-detail/90759.htm).

        > **NOTE:** Available in 1.98.0+

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        config = pulumi.Config()
        name = config.get("name")
        if name is None:
            name = "tf-testaccalicloudfcservice"
        default_service = alicloud.fc.Service("defaultService", description=f"{name}-description")
        default_bucket = alicloud.oss.Bucket("defaultBucket", bucket=name)
        default_bucket_object = alicloud.oss.BucketObject("defaultBucketObject",
            bucket=default_bucket.id,
            key="fc/hello.zip",
            content=\"\"\"		# -*- coding: utf-8 -*-
        	def handler(event, context):
        		print "hello world"
        		return 'hello world'
        \"\"\")
        default_function = alicloud.fc.Function("defaultFunction",
            service=default_service.name,
            oss_bucket=default_bucket.id,
            oss_key=default_bucket_object.key,
            memory_size=512,
            runtime="python2.7",
            handler="hello.handler")
        default_custom_domain = alicloud.fc.CustomDomain("defaultCustomDomain",
            domain_name="terraform.functioncompute.com",
            protocol="HTTP",
            route_configs=[alicloud.fc.CustomDomainRouteConfigArgs(
                path="/login/*",
                service_name=default_service.name,
                function_name=default_function.name,
                qualifier="v1",
                methods=[
                    "GET",
                    "POST",
                ],
            )],
            cert_config=alicloud.fc.CustomDomainCertConfigArgs(
                cert_name="your certificate name",
                private_key="your private key",
                certificate="your certificate data",
            ))
        ```

        ## Import

        Function Compute custom domain can be imported using the id or the domain name, e.g.

        ```sh
         $ pulumi import alicloud:fc/customDomain:CustomDomain foo my-fc-custom-domain
        ```

        :param str resource_name: The name of the resource.
        :param CustomDomainArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CustomDomainArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cert_config: Optional[pulumi.Input[pulumi.InputType['CustomDomainCertConfigArgs']]] = None,
                 domain_name: Optional[pulumi.Input[str]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 route_configs: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CustomDomainRouteConfigArgs']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CustomDomainArgs.__new__(CustomDomainArgs)

            __props__.__dict__["cert_config"] = cert_config
            if domain_name is None and not opts.urn:
                raise TypeError("Missing required property 'domain_name'")
            __props__.__dict__["domain_name"] = domain_name
            if protocol is None and not opts.urn:
                raise TypeError("Missing required property 'protocol'")
            __props__.__dict__["protocol"] = protocol
            __props__.__dict__["route_configs"] = route_configs
            __props__.__dict__["account_id"] = None
            __props__.__dict__["api_version"] = None
            __props__.__dict__["created_time"] = None
            __props__.__dict__["last_modified_time"] = None
        super(CustomDomain, __self__).__init__(
            'alicloud:fc/customDomain:CustomDomain',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            account_id: Optional[pulumi.Input[str]] = None,
            api_version: Optional[pulumi.Input[str]] = None,
            cert_config: Optional[pulumi.Input[pulumi.InputType['CustomDomainCertConfigArgs']]] = None,
            created_time: Optional[pulumi.Input[str]] = None,
            domain_name: Optional[pulumi.Input[str]] = None,
            last_modified_time: Optional[pulumi.Input[str]] = None,
            protocol: Optional[pulumi.Input[str]] = None,
            route_configs: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CustomDomainRouteConfigArgs']]]]] = None) -> 'CustomDomain':
        """
        Get an existing CustomDomain resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_id: The account id.
        :param pulumi.Input[str] api_version: The api version of Function Compute.
        :param pulumi.Input[pulumi.InputType['CustomDomainCertConfigArgs']] cert_config: The configuration of HTTPS certificate.
        :param pulumi.Input[str] created_time: The date this resource was created.
        :param pulumi.Input[str] domain_name: The custom domain name. For example, "example.com".
        :param pulumi.Input[str] last_modified_time: The date this resource was last modified.
        :param pulumi.Input[str] protocol: The protocol, `HTTP` or `HTTP,HTTPS`.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CustomDomainRouteConfigArgs']]]] route_configs: The configuration of domain route, mapping the path and Function Compute function.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _CustomDomainState.__new__(_CustomDomainState)

        __props__.__dict__["account_id"] = account_id
        __props__.__dict__["api_version"] = api_version
        __props__.__dict__["cert_config"] = cert_config
        __props__.__dict__["created_time"] = created_time
        __props__.__dict__["domain_name"] = domain_name
        __props__.__dict__["last_modified_time"] = last_modified_time
        __props__.__dict__["protocol"] = protocol
        __props__.__dict__["route_configs"] = route_configs
        return CustomDomain(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> pulumi.Output[str]:
        """
        The account id.
        """
        return pulumi.get(self, "account_id")

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> pulumi.Output[str]:
        """
        The api version of Function Compute.
        """
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter(name="certConfig")
    def cert_config(self) -> pulumi.Output[Optional['outputs.CustomDomainCertConfig']]:
        """
        The configuration of HTTPS certificate.
        """
        return pulumi.get(self, "cert_config")

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> pulumi.Output[str]:
        """
        The date this resource was created.
        """
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter(name="domainName")
    def domain_name(self) -> pulumi.Output[str]:
        """
        The custom domain name. For example, "example.com".
        """
        return pulumi.get(self, "domain_name")

    @property
    @pulumi.getter(name="lastModifiedTime")
    def last_modified_time(self) -> pulumi.Output[str]:
        """
        The date this resource was last modified.
        """
        return pulumi.get(self, "last_modified_time")

    @property
    @pulumi.getter
    def protocol(self) -> pulumi.Output[str]:
        """
        The protocol, `HTTP` or `HTTP,HTTPS`.
        """
        return pulumi.get(self, "protocol")

    @property
    @pulumi.getter(name="routeConfigs")
    def route_configs(self) -> pulumi.Output[Optional[Sequence['outputs.CustomDomainRouteConfig']]]:
        """
        The configuration of domain route, mapping the path and Function Compute function.
        """
        return pulumi.get(self, "route_configs")
