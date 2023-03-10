# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['VpcEndpointZoneArgs', 'VpcEndpointZone']

@pulumi.input_type
class VpcEndpointZoneArgs:
    def __init__(__self__, *,
                 endpoint_id: pulumi.Input[str],
                 vswitch_id: pulumi.Input[str],
                 dry_run: Optional[pulumi.Input[bool]] = None,
                 zone_id: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a VpcEndpointZone resource.
        :param pulumi.Input[str] endpoint_id: The ID of the Vpc Endpoint.
        :param pulumi.Input[str] vswitch_id: The VSwitch id.
        :param pulumi.Input[bool] dry_run: The dry run.
        :param pulumi.Input[str] zone_id: The Zone Id.
        """
        pulumi.set(__self__, "endpoint_id", endpoint_id)
        pulumi.set(__self__, "vswitch_id", vswitch_id)
        if dry_run is not None:
            pulumi.set(__self__, "dry_run", dry_run)
        if zone_id is not None:
            pulumi.set(__self__, "zone_id", zone_id)

    @property
    @pulumi.getter(name="endpointId")
    def endpoint_id(self) -> pulumi.Input[str]:
        """
        The ID of the Vpc Endpoint.
        """
        return pulumi.get(self, "endpoint_id")

    @endpoint_id.setter
    def endpoint_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "endpoint_id", value)

    @property
    @pulumi.getter(name="vswitchId")
    def vswitch_id(self) -> pulumi.Input[str]:
        """
        The VSwitch id.
        """
        return pulumi.get(self, "vswitch_id")

    @vswitch_id.setter
    def vswitch_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "vswitch_id", value)

    @property
    @pulumi.getter(name="dryRun")
    def dry_run(self) -> Optional[pulumi.Input[bool]]:
        """
        The dry run.
        """
        return pulumi.get(self, "dry_run")

    @dry_run.setter
    def dry_run(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "dry_run", value)

    @property
    @pulumi.getter(name="zoneId")
    def zone_id(self) -> Optional[pulumi.Input[str]]:
        """
        The Zone Id.
        """
        return pulumi.get(self, "zone_id")

    @zone_id.setter
    def zone_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "zone_id", value)


@pulumi.input_type
class _VpcEndpointZoneState:
    def __init__(__self__, *,
                 dry_run: Optional[pulumi.Input[bool]] = None,
                 endpoint_id: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 vswitch_id: Optional[pulumi.Input[str]] = None,
                 zone_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering VpcEndpointZone resources.
        :param pulumi.Input[bool] dry_run: The dry run.
        :param pulumi.Input[str] endpoint_id: The ID of the Vpc Endpoint.
        :param pulumi.Input[str] status: Status.
        :param pulumi.Input[str] vswitch_id: The VSwitch id.
        :param pulumi.Input[str] zone_id: The Zone Id.
        """
        if dry_run is not None:
            pulumi.set(__self__, "dry_run", dry_run)
        if endpoint_id is not None:
            pulumi.set(__self__, "endpoint_id", endpoint_id)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if vswitch_id is not None:
            pulumi.set(__self__, "vswitch_id", vswitch_id)
        if zone_id is not None:
            pulumi.set(__self__, "zone_id", zone_id)

    @property
    @pulumi.getter(name="dryRun")
    def dry_run(self) -> Optional[pulumi.Input[bool]]:
        """
        The dry run.
        """
        return pulumi.get(self, "dry_run")

    @dry_run.setter
    def dry_run(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "dry_run", value)

    @property
    @pulumi.getter(name="endpointId")
    def endpoint_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the Vpc Endpoint.
        """
        return pulumi.get(self, "endpoint_id")

    @endpoint_id.setter
    def endpoint_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "endpoint_id", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Status.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter(name="vswitchId")
    def vswitch_id(self) -> Optional[pulumi.Input[str]]:
        """
        The VSwitch id.
        """
        return pulumi.get(self, "vswitch_id")

    @vswitch_id.setter
    def vswitch_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "vswitch_id", value)

    @property
    @pulumi.getter(name="zoneId")
    def zone_id(self) -> Optional[pulumi.Input[str]]:
        """
        The Zone Id.
        """
        return pulumi.get(self, "zone_id")

    @zone_id.setter
    def zone_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "zone_id", value)


class VpcEndpointZone(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 dry_run: Optional[pulumi.Input[bool]] = None,
                 endpoint_id: Optional[pulumi.Input[str]] = None,
                 vswitch_id: Optional[pulumi.Input[str]] = None,
                 zone_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a Private Link Vpc Endpoint Zone resource.

        For information about Private Link Vpc Endpoint Zone and how to use it, see [What is Vpc Endpoint Zone](https://help.aliyun.com/document_detail/183561.html).

        > **NOTE:** Available in v1.111.0+.

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        example = alicloud.privatelink.VpcEndpointZone("example",
            endpoint_id="ep-gw8boxxxxx",
            vswitch_id="vsw-rtycxxxxx",
            zone_id="eu-central-1a")
        ```

        ## Import

        Private Link Vpc Endpoint Zone can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:privatelink/vpcEndpointZone:VpcEndpointZone example <endpoint_id>:<zone_id>
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] dry_run: The dry run.
        :param pulumi.Input[str] endpoint_id: The ID of the Vpc Endpoint.
        :param pulumi.Input[str] vswitch_id: The VSwitch id.
        :param pulumi.Input[str] zone_id: The Zone Id.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: VpcEndpointZoneArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a Private Link Vpc Endpoint Zone resource.

        For information about Private Link Vpc Endpoint Zone and how to use it, see [What is Vpc Endpoint Zone](https://help.aliyun.com/document_detail/183561.html).

        > **NOTE:** Available in v1.111.0+.

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        example = alicloud.privatelink.VpcEndpointZone("example",
            endpoint_id="ep-gw8boxxxxx",
            vswitch_id="vsw-rtycxxxxx",
            zone_id="eu-central-1a")
        ```

        ## Import

        Private Link Vpc Endpoint Zone can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:privatelink/vpcEndpointZone:VpcEndpointZone example <endpoint_id>:<zone_id>
        ```

        :param str resource_name: The name of the resource.
        :param VpcEndpointZoneArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(VpcEndpointZoneArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 dry_run: Optional[pulumi.Input[bool]] = None,
                 endpoint_id: Optional[pulumi.Input[str]] = None,
                 vswitch_id: Optional[pulumi.Input[str]] = None,
                 zone_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = VpcEndpointZoneArgs.__new__(VpcEndpointZoneArgs)

            __props__.__dict__["dry_run"] = dry_run
            if endpoint_id is None and not opts.urn:
                raise TypeError("Missing required property 'endpoint_id'")
            __props__.__dict__["endpoint_id"] = endpoint_id
            if vswitch_id is None and not opts.urn:
                raise TypeError("Missing required property 'vswitch_id'")
            __props__.__dict__["vswitch_id"] = vswitch_id
            __props__.__dict__["zone_id"] = zone_id
            __props__.__dict__["status"] = None
        super(VpcEndpointZone, __self__).__init__(
            'alicloud:privatelink/vpcEndpointZone:VpcEndpointZone',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            dry_run: Optional[pulumi.Input[bool]] = None,
            endpoint_id: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None,
            vswitch_id: Optional[pulumi.Input[str]] = None,
            zone_id: Optional[pulumi.Input[str]] = None) -> 'VpcEndpointZone':
        """
        Get an existing VpcEndpointZone resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] dry_run: The dry run.
        :param pulumi.Input[str] endpoint_id: The ID of the Vpc Endpoint.
        :param pulumi.Input[str] status: Status.
        :param pulumi.Input[str] vswitch_id: The VSwitch id.
        :param pulumi.Input[str] zone_id: The Zone Id.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _VpcEndpointZoneState.__new__(_VpcEndpointZoneState)

        __props__.__dict__["dry_run"] = dry_run
        __props__.__dict__["endpoint_id"] = endpoint_id
        __props__.__dict__["status"] = status
        __props__.__dict__["vswitch_id"] = vswitch_id
        __props__.__dict__["zone_id"] = zone_id
        return VpcEndpointZone(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dryRun")
    def dry_run(self) -> pulumi.Output[Optional[bool]]:
        """
        The dry run.
        """
        return pulumi.get(self, "dry_run")

    @property
    @pulumi.getter(name="endpointId")
    def endpoint_id(self) -> pulumi.Output[str]:
        """
        The ID of the Vpc Endpoint.
        """
        return pulumi.get(self, "endpoint_id")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        Status.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="vswitchId")
    def vswitch_id(self) -> pulumi.Output[str]:
        """
        The VSwitch id.
        """
        return pulumi.get(self, "vswitch_id")

    @property
    @pulumi.getter(name="zoneId")
    def zone_id(self) -> pulumi.Output[str]:
        """
        The Zone Id.
        """
        return pulumi.get(self, "zone_id")

