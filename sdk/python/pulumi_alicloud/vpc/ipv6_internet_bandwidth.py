# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['Ipv6InternetBandwidthArgs', 'Ipv6InternetBandwidth']

@pulumi.input_type
class Ipv6InternetBandwidthArgs:
    def __init__(__self__, *,
                 bandwidth: pulumi.Input[int],
                 ipv6_address_id: pulumi.Input[str],
                 ipv6_gateway_id: pulumi.Input[str],
                 internet_charge_type: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Ipv6InternetBandwidth resource.
        :param pulumi.Input[int] bandwidth: The amount of Internet bandwidth resources of the IPv6 address, Unit: `Mbit/s`. Valid values: `1` to `5000`. **NOTE:** If `internet_charge_type` is set to `PayByTraffic`, the amount of Internet bandwidth resources of the IPv6 address is limited by the specification of the IPv6 gateway. `Small` (default): specifies the Free edition and the Internet bandwidth is from `1` to `500` Mbit/s. `Medium`: specifies the Medium edition and the Internet bandwidth is from `1` to `1000` Mbit/s. `Large`: specifies the Large edition and the Internet bandwidth is from `1` to `2000` Mbit/s.
        :param pulumi.Input[str] ipv6_address_id: The ID of the IPv6 address.
        :param pulumi.Input[str] ipv6_gateway_id: The ID of the IPv6 gateway.
        :param pulumi.Input[str] internet_charge_type: The metering method of the Internet bandwidth resources of the IPv6 gateway. Valid values: `PayByBandwidth`, `PayByTraffic`.
        """
        pulumi.set(__self__, "bandwidth", bandwidth)
        pulumi.set(__self__, "ipv6_address_id", ipv6_address_id)
        pulumi.set(__self__, "ipv6_gateway_id", ipv6_gateway_id)
        if internet_charge_type is not None:
            pulumi.set(__self__, "internet_charge_type", internet_charge_type)

    @property
    @pulumi.getter
    def bandwidth(self) -> pulumi.Input[int]:
        """
        The amount of Internet bandwidth resources of the IPv6 address, Unit: `Mbit/s`. Valid values: `1` to `5000`. **NOTE:** If `internet_charge_type` is set to `PayByTraffic`, the amount of Internet bandwidth resources of the IPv6 address is limited by the specification of the IPv6 gateway. `Small` (default): specifies the Free edition and the Internet bandwidth is from `1` to `500` Mbit/s. `Medium`: specifies the Medium edition and the Internet bandwidth is from `1` to `1000` Mbit/s. `Large`: specifies the Large edition and the Internet bandwidth is from `1` to `2000` Mbit/s.
        """
        return pulumi.get(self, "bandwidth")

    @bandwidth.setter
    def bandwidth(self, value: pulumi.Input[int]):
        pulumi.set(self, "bandwidth", value)

    @property
    @pulumi.getter(name="ipv6AddressId")
    def ipv6_address_id(self) -> pulumi.Input[str]:
        """
        The ID of the IPv6 address.
        """
        return pulumi.get(self, "ipv6_address_id")

    @ipv6_address_id.setter
    def ipv6_address_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "ipv6_address_id", value)

    @property
    @pulumi.getter(name="ipv6GatewayId")
    def ipv6_gateway_id(self) -> pulumi.Input[str]:
        """
        The ID of the IPv6 gateway.
        """
        return pulumi.get(self, "ipv6_gateway_id")

    @ipv6_gateway_id.setter
    def ipv6_gateway_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "ipv6_gateway_id", value)

    @property
    @pulumi.getter(name="internetChargeType")
    def internet_charge_type(self) -> Optional[pulumi.Input[str]]:
        """
        The metering method of the Internet bandwidth resources of the IPv6 gateway. Valid values: `PayByBandwidth`, `PayByTraffic`.
        """
        return pulumi.get(self, "internet_charge_type")

    @internet_charge_type.setter
    def internet_charge_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "internet_charge_type", value)


@pulumi.input_type
class _Ipv6InternetBandwidthState:
    def __init__(__self__, *,
                 bandwidth: Optional[pulumi.Input[int]] = None,
                 internet_charge_type: Optional[pulumi.Input[str]] = None,
                 ipv6_address_id: Optional[pulumi.Input[str]] = None,
                 ipv6_gateway_id: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Ipv6InternetBandwidth resources.
        :param pulumi.Input[int] bandwidth: The amount of Internet bandwidth resources of the IPv6 address, Unit: `Mbit/s`. Valid values: `1` to `5000`. **NOTE:** If `internet_charge_type` is set to `PayByTraffic`, the amount of Internet bandwidth resources of the IPv6 address is limited by the specification of the IPv6 gateway. `Small` (default): specifies the Free edition and the Internet bandwidth is from `1` to `500` Mbit/s. `Medium`: specifies the Medium edition and the Internet bandwidth is from `1` to `1000` Mbit/s. `Large`: specifies the Large edition and the Internet bandwidth is from `1` to `2000` Mbit/s.
        :param pulumi.Input[str] internet_charge_type: The metering method of the Internet bandwidth resources of the IPv6 gateway. Valid values: `PayByBandwidth`, `PayByTraffic`.
        :param pulumi.Input[str] ipv6_address_id: The ID of the IPv6 address.
        :param pulumi.Input[str] ipv6_gateway_id: The ID of the IPv6 gateway.
        :param pulumi.Input[str] status: The status of the resource.Valid values:`Normal`, `FinancialLocked` and `SecurityLocked`.
        """
        if bandwidth is not None:
            pulumi.set(__self__, "bandwidth", bandwidth)
        if internet_charge_type is not None:
            pulumi.set(__self__, "internet_charge_type", internet_charge_type)
        if ipv6_address_id is not None:
            pulumi.set(__self__, "ipv6_address_id", ipv6_address_id)
        if ipv6_gateway_id is not None:
            pulumi.set(__self__, "ipv6_gateway_id", ipv6_gateway_id)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter
    def bandwidth(self) -> Optional[pulumi.Input[int]]:
        """
        The amount of Internet bandwidth resources of the IPv6 address, Unit: `Mbit/s`. Valid values: `1` to `5000`. **NOTE:** If `internet_charge_type` is set to `PayByTraffic`, the amount of Internet bandwidth resources of the IPv6 address is limited by the specification of the IPv6 gateway. `Small` (default): specifies the Free edition and the Internet bandwidth is from `1` to `500` Mbit/s. `Medium`: specifies the Medium edition and the Internet bandwidth is from `1` to `1000` Mbit/s. `Large`: specifies the Large edition and the Internet bandwidth is from `1` to `2000` Mbit/s.
        """
        return pulumi.get(self, "bandwidth")

    @bandwidth.setter
    def bandwidth(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "bandwidth", value)

    @property
    @pulumi.getter(name="internetChargeType")
    def internet_charge_type(self) -> Optional[pulumi.Input[str]]:
        """
        The metering method of the Internet bandwidth resources of the IPv6 gateway. Valid values: `PayByBandwidth`, `PayByTraffic`.
        """
        return pulumi.get(self, "internet_charge_type")

    @internet_charge_type.setter
    def internet_charge_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "internet_charge_type", value)

    @property
    @pulumi.getter(name="ipv6AddressId")
    def ipv6_address_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the IPv6 address.
        """
        return pulumi.get(self, "ipv6_address_id")

    @ipv6_address_id.setter
    def ipv6_address_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ipv6_address_id", value)

    @property
    @pulumi.getter(name="ipv6GatewayId")
    def ipv6_gateway_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the IPv6 gateway.
        """
        return pulumi.get(self, "ipv6_gateway_id")

    @ipv6_gateway_id.setter
    def ipv6_gateway_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ipv6_gateway_id", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        The status of the resource.Valid values:`Normal`, `FinancialLocked` and `SecurityLocked`.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


class Ipv6InternetBandwidth(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bandwidth: Optional[pulumi.Input[int]] = None,
                 internet_charge_type: Optional[pulumi.Input[str]] = None,
                 ipv6_address_id: Optional[pulumi.Input[str]] = None,
                 ipv6_gateway_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a VPC Ipv6 Internet Bandwidth resource.

        For information about VPC Ipv6 Internet Bandwidth and how to use it, see [What is Ipv6 Internet Bandwidth](https://www.alibabacloud.com/help/doc-detail/102213.htm).

        > **NOTE:** Available in v1.143.0+.

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        example_instances = alicloud.ecs.get_instances(name_regex="ecs_with_ipv6_address",
            status="Running")
        example_ipv6_addresses = alicloud.vpc.get_ipv6_addresses(associated_instance_id=example_instances.instances[0].id,
            status="Available")
        example_ipv6_internet_bandwidth = alicloud.vpc.Ipv6InternetBandwidth("exampleIpv6InternetBandwidth",
            ipv6_address_id=example_ipv6_addresses.addresses[0].id,
            ipv6_gateway_id=example_ipv6_addresses.addresses[0].ipv6_gateway_id,
            internet_charge_type="PayByBandwidth",
            bandwidth=20)
        ```

        ## Import

        VPC Ipv6 Internet Bandwidth can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:vpc/ipv6InternetBandwidth:Ipv6InternetBandwidth example <id>
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] bandwidth: The amount of Internet bandwidth resources of the IPv6 address, Unit: `Mbit/s`. Valid values: `1` to `5000`. **NOTE:** If `internet_charge_type` is set to `PayByTraffic`, the amount of Internet bandwidth resources of the IPv6 address is limited by the specification of the IPv6 gateway. `Small` (default): specifies the Free edition and the Internet bandwidth is from `1` to `500` Mbit/s. `Medium`: specifies the Medium edition and the Internet bandwidth is from `1` to `1000` Mbit/s. `Large`: specifies the Large edition and the Internet bandwidth is from `1` to `2000` Mbit/s.
        :param pulumi.Input[str] internet_charge_type: The metering method of the Internet bandwidth resources of the IPv6 gateway. Valid values: `PayByBandwidth`, `PayByTraffic`.
        :param pulumi.Input[str] ipv6_address_id: The ID of the IPv6 address.
        :param pulumi.Input[str] ipv6_gateway_id: The ID of the IPv6 gateway.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Ipv6InternetBandwidthArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a VPC Ipv6 Internet Bandwidth resource.

        For information about VPC Ipv6 Internet Bandwidth and how to use it, see [What is Ipv6 Internet Bandwidth](https://www.alibabacloud.com/help/doc-detail/102213.htm).

        > **NOTE:** Available in v1.143.0+.

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        example_instances = alicloud.ecs.get_instances(name_regex="ecs_with_ipv6_address",
            status="Running")
        example_ipv6_addresses = alicloud.vpc.get_ipv6_addresses(associated_instance_id=example_instances.instances[0].id,
            status="Available")
        example_ipv6_internet_bandwidth = alicloud.vpc.Ipv6InternetBandwidth("exampleIpv6InternetBandwidth",
            ipv6_address_id=example_ipv6_addresses.addresses[0].id,
            ipv6_gateway_id=example_ipv6_addresses.addresses[0].ipv6_gateway_id,
            internet_charge_type="PayByBandwidth",
            bandwidth=20)
        ```

        ## Import

        VPC Ipv6 Internet Bandwidth can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:vpc/ipv6InternetBandwidth:Ipv6InternetBandwidth example <id>
        ```

        :param str resource_name: The name of the resource.
        :param Ipv6InternetBandwidthArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(Ipv6InternetBandwidthArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bandwidth: Optional[pulumi.Input[int]] = None,
                 internet_charge_type: Optional[pulumi.Input[str]] = None,
                 ipv6_address_id: Optional[pulumi.Input[str]] = None,
                 ipv6_gateway_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = Ipv6InternetBandwidthArgs.__new__(Ipv6InternetBandwidthArgs)

            if bandwidth is None and not opts.urn:
                raise TypeError("Missing required property 'bandwidth'")
            __props__.__dict__["bandwidth"] = bandwidth
            __props__.__dict__["internet_charge_type"] = internet_charge_type
            if ipv6_address_id is None and not opts.urn:
                raise TypeError("Missing required property 'ipv6_address_id'")
            __props__.__dict__["ipv6_address_id"] = ipv6_address_id
            if ipv6_gateway_id is None and not opts.urn:
                raise TypeError("Missing required property 'ipv6_gateway_id'")
            __props__.__dict__["ipv6_gateway_id"] = ipv6_gateway_id
            __props__.__dict__["status"] = None
        super(Ipv6InternetBandwidth, __self__).__init__(
            'alicloud:vpc/ipv6InternetBandwidth:Ipv6InternetBandwidth',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            bandwidth: Optional[pulumi.Input[int]] = None,
            internet_charge_type: Optional[pulumi.Input[str]] = None,
            ipv6_address_id: Optional[pulumi.Input[str]] = None,
            ipv6_gateway_id: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None) -> 'Ipv6InternetBandwidth':
        """
        Get an existing Ipv6InternetBandwidth resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] bandwidth: The amount of Internet bandwidth resources of the IPv6 address, Unit: `Mbit/s`. Valid values: `1` to `5000`. **NOTE:** If `internet_charge_type` is set to `PayByTraffic`, the amount of Internet bandwidth resources of the IPv6 address is limited by the specification of the IPv6 gateway. `Small` (default): specifies the Free edition and the Internet bandwidth is from `1` to `500` Mbit/s. `Medium`: specifies the Medium edition and the Internet bandwidth is from `1` to `1000` Mbit/s. `Large`: specifies the Large edition and the Internet bandwidth is from `1` to `2000` Mbit/s.
        :param pulumi.Input[str] internet_charge_type: The metering method of the Internet bandwidth resources of the IPv6 gateway. Valid values: `PayByBandwidth`, `PayByTraffic`.
        :param pulumi.Input[str] ipv6_address_id: The ID of the IPv6 address.
        :param pulumi.Input[str] ipv6_gateway_id: The ID of the IPv6 gateway.
        :param pulumi.Input[str] status: The status of the resource.Valid values:`Normal`, `FinancialLocked` and `SecurityLocked`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _Ipv6InternetBandwidthState.__new__(_Ipv6InternetBandwidthState)

        __props__.__dict__["bandwidth"] = bandwidth
        __props__.__dict__["internet_charge_type"] = internet_charge_type
        __props__.__dict__["ipv6_address_id"] = ipv6_address_id
        __props__.__dict__["ipv6_gateway_id"] = ipv6_gateway_id
        __props__.__dict__["status"] = status
        return Ipv6InternetBandwidth(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def bandwidth(self) -> pulumi.Output[int]:
        """
        The amount of Internet bandwidth resources of the IPv6 address, Unit: `Mbit/s`. Valid values: `1` to `5000`. **NOTE:** If `internet_charge_type` is set to `PayByTraffic`, the amount of Internet bandwidth resources of the IPv6 address is limited by the specification of the IPv6 gateway. `Small` (default): specifies the Free edition and the Internet bandwidth is from `1` to `500` Mbit/s. `Medium`: specifies the Medium edition and the Internet bandwidth is from `1` to `1000` Mbit/s. `Large`: specifies the Large edition and the Internet bandwidth is from `1` to `2000` Mbit/s.
        """
        return pulumi.get(self, "bandwidth")

    @property
    @pulumi.getter(name="internetChargeType")
    def internet_charge_type(self) -> pulumi.Output[str]:
        """
        The metering method of the Internet bandwidth resources of the IPv6 gateway. Valid values: `PayByBandwidth`, `PayByTraffic`.
        """
        return pulumi.get(self, "internet_charge_type")

    @property
    @pulumi.getter(name="ipv6AddressId")
    def ipv6_address_id(self) -> pulumi.Output[str]:
        """
        The ID of the IPv6 address.
        """
        return pulumi.get(self, "ipv6_address_id")

    @property
    @pulumi.getter(name="ipv6GatewayId")
    def ipv6_gateway_id(self) -> pulumi.Output[str]:
        """
        The ID of the IPv6 gateway.
        """
        return pulumi.get(self, "ipv6_gateway_id")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        The status of the resource.Valid values:`Normal`, `FinancialLocked` and `SecurityLocked`.
        """
        return pulumi.get(self, "status")

