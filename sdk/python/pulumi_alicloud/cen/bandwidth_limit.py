# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['BandwidthLimitArgs', 'BandwidthLimit']

@pulumi.input_type
class BandwidthLimitArgs:
    def __init__(__self__, *,
                 bandwidth_limit: pulumi.Input[int],
                 instance_id: pulumi.Input[str],
                 region_ids: pulumi.Input[Sequence[pulumi.Input[str]]]):
        """
        The set of arguments for constructing a BandwidthLimit resource.
        :param pulumi.Input[int] bandwidth_limit: The bandwidth configured for the interconnected regions communication.
        :param pulumi.Input[str] instance_id: The ID of the CEN.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] region_ids: List of the two regions to interconnect. Must be two different regions.
        """
        pulumi.set(__self__, "bandwidth_limit", bandwidth_limit)
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "region_ids", region_ids)

    @property
    @pulumi.getter(name="bandwidthLimit")
    def bandwidth_limit(self) -> pulumi.Input[int]:
        """
        The bandwidth configured for the interconnected regions communication.
        """
        return pulumi.get(self, "bandwidth_limit")

    @bandwidth_limit.setter
    def bandwidth_limit(self, value: pulumi.Input[int]):
        pulumi.set(self, "bandwidth_limit", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        The ID of the CEN.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="regionIds")
    def region_ids(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        List of the two regions to interconnect. Must be two different regions.
        """
        return pulumi.get(self, "region_ids")

    @region_ids.setter
    def region_ids(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "region_ids", value)


@pulumi.input_type
class _BandwidthLimitState:
    def __init__(__self__, *,
                 bandwidth_limit: Optional[pulumi.Input[int]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 region_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        Input properties used for looking up and filtering BandwidthLimit resources.
        :param pulumi.Input[int] bandwidth_limit: The bandwidth configured for the interconnected regions communication.
        :param pulumi.Input[str] instance_id: The ID of the CEN.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] region_ids: List of the two regions to interconnect. Must be two different regions.
        """
        if bandwidth_limit is not None:
            pulumi.set(__self__, "bandwidth_limit", bandwidth_limit)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if region_ids is not None:
            pulumi.set(__self__, "region_ids", region_ids)

    @property
    @pulumi.getter(name="bandwidthLimit")
    def bandwidth_limit(self) -> Optional[pulumi.Input[int]]:
        """
        The bandwidth configured for the interconnected regions communication.
        """
        return pulumi.get(self, "bandwidth_limit")

    @bandwidth_limit.setter
    def bandwidth_limit(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "bandwidth_limit", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the CEN.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="regionIds")
    def region_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        List of the two regions to interconnect. Must be two different regions.
        """
        return pulumi.get(self, "region_ids")

    @region_ids.setter
    def region_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "region_ids", value)


class BandwidthLimit(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bandwidth_limit: Optional[pulumi.Input[int]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 region_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Provides a CEN cross-regional interconnection bandwidth resource. To connect networks in different regions, you must set cross-region interconnection bandwidth after buying a bandwidth package. The total bandwidth set for all the interconnected regions of a bandwidth package cannot exceed the bandwidth of the bandwidth package. By default, 1 Kbps bandwidth is provided for connectivity test. To run normal business, you must buy a bandwidth package and set a proper interconnection bandwidth.

        For example, a CEN instance is bound to a bandwidth package of 20 Mbps and  the interconnection areas are Mainland China and North America. You can set the cross-region interconnection bandwidth between US West 1 and China East 1, China East 2, China South 1, and so on. However, the total bandwidth set for all the interconnected regions cannot exceed 20  Mbps.

        For information about CEN and how to use it, see [Cross-region interconnection bandwidth](https://www.alibabacloud.com/help/doc-detail/65983.htm)

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        config = pulumi.Config()
        name = config.get("name")
        if name is None:
            name = "tf-testAccCenBandwidthLimitConfig"
        fra = alicloud.Provider("fra", region="eu-central-1")
        sh = alicloud.Provider("sh", region="cn-shanghai")
        vpc1 = alicloud.vpc.Network("vpc1",
            vpc_name=name,
            cidr_block="192.168.0.0/16",
            opts=pulumi.ResourceOptions(provider=alicloud["fra"]))
        vpc2 = alicloud.vpc.Network("vpc2", cidr_block="172.16.0.0/12",
        opts=pulumi.ResourceOptions(provider=alicloud["sh"]))
        cen = alicloud.cen.Instance("cen", description="tf-testAccCenBandwidthLimitConfigDescription")
        bwp = alicloud.cen.BandwidthPackage("bwp",
            bandwidth=5,
            geographic_region_ids=[
                "Europe",
                "China",
            ])
        bwp_attach = alicloud.cen.BandwidthPackageAttachment("bwpAttach",
            instance_id=cen.id,
            bandwidth_package_id=bwp.id)
        vpc_attach1 = alicloud.cen.InstanceAttachment("vpcAttach1",
            instance_id=cen.id,
            child_instance_id=vpc1.id,
            child_instance_type="VPC",
            child_instance_region_id="eu-central-1")
        vpc_attach2 = alicloud.cen.InstanceAttachment("vpcAttach2",
            instance_id=cen.id,
            child_instance_id=vpc2.id,
            child_instance_type="VPC",
            child_instance_region_id="cn-shanghai")
        foo = alicloud.cen.BandwidthLimit("foo",
            instance_id=cen.id,
            region_ids=[
                "eu-central-1",
                "cn-shanghai",
            ],
            bandwidth_limit=4,
            opts=pulumi.ResourceOptions(depends_on=[
                    bwp_attach,
                    vpc_attach1,
                    vpc_attach2,
                ]))
        ```

        ## Import

        CEN bandwidth limit can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:cen/bandwidthLimit:BandwidthLimit example cen-abc123456:cn-beijing:eu-west-1
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] bandwidth_limit: The bandwidth configured for the interconnected regions communication.
        :param pulumi.Input[str] instance_id: The ID of the CEN.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] region_ids: List of the two regions to interconnect. Must be two different regions.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: BandwidthLimitArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a CEN cross-regional interconnection bandwidth resource. To connect networks in different regions, you must set cross-region interconnection bandwidth after buying a bandwidth package. The total bandwidth set for all the interconnected regions of a bandwidth package cannot exceed the bandwidth of the bandwidth package. By default, 1 Kbps bandwidth is provided for connectivity test. To run normal business, you must buy a bandwidth package and set a proper interconnection bandwidth.

        For example, a CEN instance is bound to a bandwidth package of 20 Mbps and  the interconnection areas are Mainland China and North America. You can set the cross-region interconnection bandwidth between US West 1 and China East 1, China East 2, China South 1, and so on. However, the total bandwidth set for all the interconnected regions cannot exceed 20  Mbps.

        For information about CEN and how to use it, see [Cross-region interconnection bandwidth](https://www.alibabacloud.com/help/doc-detail/65983.htm)

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        config = pulumi.Config()
        name = config.get("name")
        if name is None:
            name = "tf-testAccCenBandwidthLimitConfig"
        fra = alicloud.Provider("fra", region="eu-central-1")
        sh = alicloud.Provider("sh", region="cn-shanghai")
        vpc1 = alicloud.vpc.Network("vpc1",
            vpc_name=name,
            cidr_block="192.168.0.0/16",
            opts=pulumi.ResourceOptions(provider=alicloud["fra"]))
        vpc2 = alicloud.vpc.Network("vpc2", cidr_block="172.16.0.0/12",
        opts=pulumi.ResourceOptions(provider=alicloud["sh"]))
        cen = alicloud.cen.Instance("cen", description="tf-testAccCenBandwidthLimitConfigDescription")
        bwp = alicloud.cen.BandwidthPackage("bwp",
            bandwidth=5,
            geographic_region_ids=[
                "Europe",
                "China",
            ])
        bwp_attach = alicloud.cen.BandwidthPackageAttachment("bwpAttach",
            instance_id=cen.id,
            bandwidth_package_id=bwp.id)
        vpc_attach1 = alicloud.cen.InstanceAttachment("vpcAttach1",
            instance_id=cen.id,
            child_instance_id=vpc1.id,
            child_instance_type="VPC",
            child_instance_region_id="eu-central-1")
        vpc_attach2 = alicloud.cen.InstanceAttachment("vpcAttach2",
            instance_id=cen.id,
            child_instance_id=vpc2.id,
            child_instance_type="VPC",
            child_instance_region_id="cn-shanghai")
        foo = alicloud.cen.BandwidthLimit("foo",
            instance_id=cen.id,
            region_ids=[
                "eu-central-1",
                "cn-shanghai",
            ],
            bandwidth_limit=4,
            opts=pulumi.ResourceOptions(depends_on=[
                    bwp_attach,
                    vpc_attach1,
                    vpc_attach2,
                ]))
        ```

        ## Import

        CEN bandwidth limit can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:cen/bandwidthLimit:BandwidthLimit example cen-abc123456:cn-beijing:eu-west-1
        ```

        :param str resource_name: The name of the resource.
        :param BandwidthLimitArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(BandwidthLimitArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bandwidth_limit: Optional[pulumi.Input[int]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 region_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = BandwidthLimitArgs.__new__(BandwidthLimitArgs)

            if bandwidth_limit is None and not opts.urn:
                raise TypeError("Missing required property 'bandwidth_limit'")
            __props__.__dict__["bandwidth_limit"] = bandwidth_limit
            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            if region_ids is None and not opts.urn:
                raise TypeError("Missing required property 'region_ids'")
            __props__.__dict__["region_ids"] = region_ids
        super(BandwidthLimit, __self__).__init__(
            'alicloud:cen/bandwidthLimit:BandwidthLimit',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            bandwidth_limit: Optional[pulumi.Input[int]] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            region_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None) -> 'BandwidthLimit':
        """
        Get an existing BandwidthLimit resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] bandwidth_limit: The bandwidth configured for the interconnected regions communication.
        :param pulumi.Input[str] instance_id: The ID of the CEN.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] region_ids: List of the two regions to interconnect. Must be two different regions.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _BandwidthLimitState.__new__(_BandwidthLimitState)

        __props__.__dict__["bandwidth_limit"] = bandwidth_limit
        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["region_ids"] = region_ids
        return BandwidthLimit(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="bandwidthLimit")
    def bandwidth_limit(self) -> pulumi.Output[int]:
        """
        The bandwidth configured for the interconnected regions communication.
        """
        return pulumi.get(self, "bandwidth_limit")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        The ID of the CEN.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="regionIds")
    def region_ids(self) -> pulumi.Output[Sequence[str]]:
        """
        List of the two regions to interconnect. Must be two different regions.
        """
        return pulumi.get(self, "region_ids")
