# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['ExpressSyncShareAttachmentArgs', 'ExpressSyncShareAttachment']

@pulumi.input_type
class ExpressSyncShareAttachmentArgs:
    def __init__(__self__, *,
                 express_sync_id: pulumi.Input[str],
                 gateway_id: pulumi.Input[str],
                 share_name: pulumi.Input[str]):
        """
        The set of arguments for constructing a ExpressSyncShareAttachment resource.
        :param pulumi.Input[str] express_sync_id: The ID of the ExpressSync.
        :param pulumi.Input[str] gateway_id: The ID of the Gateway.
        :param pulumi.Input[str] share_name: The name of the GatewayFileShare. **NOTE:** When GatewayFileShare is associated with a speed sync group, its reverse synchronization function will be turned off by default.
        """
        pulumi.set(__self__, "express_sync_id", express_sync_id)
        pulumi.set(__self__, "gateway_id", gateway_id)
        pulumi.set(__self__, "share_name", share_name)

    @property
    @pulumi.getter(name="expressSyncId")
    def express_sync_id(self) -> pulumi.Input[str]:
        """
        The ID of the ExpressSync.
        """
        return pulumi.get(self, "express_sync_id")

    @express_sync_id.setter
    def express_sync_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "express_sync_id", value)

    @property
    @pulumi.getter(name="gatewayId")
    def gateway_id(self) -> pulumi.Input[str]:
        """
        The ID of the Gateway.
        """
        return pulumi.get(self, "gateway_id")

    @gateway_id.setter
    def gateway_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "gateway_id", value)

    @property
    @pulumi.getter(name="shareName")
    def share_name(self) -> pulumi.Input[str]:
        """
        The name of the GatewayFileShare. **NOTE:** When GatewayFileShare is associated with a speed sync group, its reverse synchronization function will be turned off by default.
        """
        return pulumi.get(self, "share_name")

    @share_name.setter
    def share_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "share_name", value)


@pulumi.input_type
class _ExpressSyncShareAttachmentState:
    def __init__(__self__, *,
                 express_sync_id: Optional[pulumi.Input[str]] = None,
                 gateway_id: Optional[pulumi.Input[str]] = None,
                 share_name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ExpressSyncShareAttachment resources.
        :param pulumi.Input[str] express_sync_id: The ID of the ExpressSync.
        :param pulumi.Input[str] gateway_id: The ID of the Gateway.
        :param pulumi.Input[str] share_name: The name of the GatewayFileShare. **NOTE:** When GatewayFileShare is associated with a speed sync group, its reverse synchronization function will be turned off by default.
        """
        if express_sync_id is not None:
            pulumi.set(__self__, "express_sync_id", express_sync_id)
        if gateway_id is not None:
            pulumi.set(__self__, "gateway_id", gateway_id)
        if share_name is not None:
            pulumi.set(__self__, "share_name", share_name)

    @property
    @pulumi.getter(name="expressSyncId")
    def express_sync_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the ExpressSync.
        """
        return pulumi.get(self, "express_sync_id")

    @express_sync_id.setter
    def express_sync_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "express_sync_id", value)

    @property
    @pulumi.getter(name="gatewayId")
    def gateway_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the Gateway.
        """
        return pulumi.get(self, "gateway_id")

    @gateway_id.setter
    def gateway_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "gateway_id", value)

    @property
    @pulumi.getter(name="shareName")
    def share_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the GatewayFileShare. **NOTE:** When GatewayFileShare is associated with a speed sync group, its reverse synchronization function will be turned off by default.
        """
        return pulumi.get(self, "share_name")

    @share_name.setter
    def share_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "share_name", value)


class ExpressSyncShareAttachment(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 express_sync_id: Optional[pulumi.Input[str]] = None,
                 gateway_id: Optional[pulumi.Input[str]] = None,
                 share_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a Cloud Storage Gateway Express Sync Share Attachment resource.

        For information about Cloud Storage Gateway Express Sync Share Attachment and how to use it, see [What is Express Sync Share Attachment](https://www.alibabacloud.com/help/en/doc-detail/53972.htm).

        > **NOTE:** Available in v1.144.0+.

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        config = pulumi.Config()
        name = config.get("name")
        if name is None:
            name = "tftest"
        region = config.get("region")
        if region is None:
            region = "cn-shanghai"
        default_stocks = alicloud.cloudstoragegateway.get_stocks(gateway_class="Standard")
        vpc = alicloud.vpc.Network("vpc",
            vpc_name=name,
            cidr_block="192.16.0.0/12")
        default_switch = alicloud.vpc.Switch("defaultSwitch",
            vpc_id=vpc.id,
            cidr_block="192.16.0.0/21",
            zone_id=default_stocks.stocks[0].zone_id,
            vswitch_name=name)
        default_storage_bundle = alicloud.cloudstoragegateway.StorageBundle("defaultStorageBundle", storage_bundle_name=name)
        default_gateway = alicloud.cloudstoragegateway.Gateway("defaultGateway",
            description="tf-acctestDesalone",
            gateway_class="Standard",
            type="File",
            payment_type="PayAsYouGo",
            vswitch_id=default_switch.id,
            release_after_expiration=True,
            public_network_bandwidth=10,
            storage_bundle_id=default_storage_bundle.id,
            location="Cloud",
            gateway_name=name)
        default_gateway_cache_disk = alicloud.cloudstoragegateway.GatewayCacheDisk("defaultGatewayCacheDisk",
            cache_disk_category="cloud_efficiency",
            gateway_id=default_gateway.id,
            cache_disk_size_in_gb=50)
        default_bucket = alicloud.oss.Bucket("defaultBucket", bucket=name)
        default_gateway_file_share = alicloud.cloudstoragegateway.GatewayFileShare("defaultGatewayFileShare",
            gateway_file_share_name=name,
            gateway_id=default_gateway.id,
            local_path=default_gateway_cache_disk.local_file_path,
            oss_bucket_name=default_bucket.bucket,
            oss_endpoint=default_bucket.extranet_endpoint,
            protocol="NFS",
            remote_sync=False,
            fe_limit=0,
            backend_limit=0,
            cache_mode="Cache",
            squash="none",
            lag_period=5)
        default_express_sync = alicloud.cloudstoragegateway.ExpressSync("defaultExpressSync",
            bucket_name=default_gateway_file_share.oss_bucket_name,
            bucket_region=region,
            description=name,
            express_sync_name=name)
        default_express_sync_share_attachment = alicloud.cloudstoragegateway.ExpressSyncShareAttachment("defaultExpressSyncShareAttachment",
            express_sync_id=default_express_sync.id,
            gateway_id=default_gateway.id,
            share_name=default_gateway_file_share.gateway_file_share_name)
        ```

        ## Import

        Cloud Storage Gateway Express Sync Share Attachment can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:cloudstoragegateway/expressSyncShareAttachment:ExpressSyncShareAttachment example <express_sync_id>:<gateway_id>:<share_name>
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] express_sync_id: The ID of the ExpressSync.
        :param pulumi.Input[str] gateway_id: The ID of the Gateway.
        :param pulumi.Input[str] share_name: The name of the GatewayFileShare. **NOTE:** When GatewayFileShare is associated with a speed sync group, its reverse synchronization function will be turned off by default.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ExpressSyncShareAttachmentArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a Cloud Storage Gateway Express Sync Share Attachment resource.

        For information about Cloud Storage Gateway Express Sync Share Attachment and how to use it, see [What is Express Sync Share Attachment](https://www.alibabacloud.com/help/en/doc-detail/53972.htm).

        > **NOTE:** Available in v1.144.0+.

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        config = pulumi.Config()
        name = config.get("name")
        if name is None:
            name = "tftest"
        region = config.get("region")
        if region is None:
            region = "cn-shanghai"
        default_stocks = alicloud.cloudstoragegateway.get_stocks(gateway_class="Standard")
        vpc = alicloud.vpc.Network("vpc",
            vpc_name=name,
            cidr_block="192.16.0.0/12")
        default_switch = alicloud.vpc.Switch("defaultSwitch",
            vpc_id=vpc.id,
            cidr_block="192.16.0.0/21",
            zone_id=default_stocks.stocks[0].zone_id,
            vswitch_name=name)
        default_storage_bundle = alicloud.cloudstoragegateway.StorageBundle("defaultStorageBundle", storage_bundle_name=name)
        default_gateway = alicloud.cloudstoragegateway.Gateway("defaultGateway",
            description="tf-acctestDesalone",
            gateway_class="Standard",
            type="File",
            payment_type="PayAsYouGo",
            vswitch_id=default_switch.id,
            release_after_expiration=True,
            public_network_bandwidth=10,
            storage_bundle_id=default_storage_bundle.id,
            location="Cloud",
            gateway_name=name)
        default_gateway_cache_disk = alicloud.cloudstoragegateway.GatewayCacheDisk("defaultGatewayCacheDisk",
            cache_disk_category="cloud_efficiency",
            gateway_id=default_gateway.id,
            cache_disk_size_in_gb=50)
        default_bucket = alicloud.oss.Bucket("defaultBucket", bucket=name)
        default_gateway_file_share = alicloud.cloudstoragegateway.GatewayFileShare("defaultGatewayFileShare",
            gateway_file_share_name=name,
            gateway_id=default_gateway.id,
            local_path=default_gateway_cache_disk.local_file_path,
            oss_bucket_name=default_bucket.bucket,
            oss_endpoint=default_bucket.extranet_endpoint,
            protocol="NFS",
            remote_sync=False,
            fe_limit=0,
            backend_limit=0,
            cache_mode="Cache",
            squash="none",
            lag_period=5)
        default_express_sync = alicloud.cloudstoragegateway.ExpressSync("defaultExpressSync",
            bucket_name=default_gateway_file_share.oss_bucket_name,
            bucket_region=region,
            description=name,
            express_sync_name=name)
        default_express_sync_share_attachment = alicloud.cloudstoragegateway.ExpressSyncShareAttachment("defaultExpressSyncShareAttachment",
            express_sync_id=default_express_sync.id,
            gateway_id=default_gateway.id,
            share_name=default_gateway_file_share.gateway_file_share_name)
        ```

        ## Import

        Cloud Storage Gateway Express Sync Share Attachment can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:cloudstoragegateway/expressSyncShareAttachment:ExpressSyncShareAttachment example <express_sync_id>:<gateway_id>:<share_name>
        ```

        :param str resource_name: The name of the resource.
        :param ExpressSyncShareAttachmentArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ExpressSyncShareAttachmentArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 express_sync_id: Optional[pulumi.Input[str]] = None,
                 gateway_id: Optional[pulumi.Input[str]] = None,
                 share_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ExpressSyncShareAttachmentArgs.__new__(ExpressSyncShareAttachmentArgs)

            if express_sync_id is None and not opts.urn:
                raise TypeError("Missing required property 'express_sync_id'")
            __props__.__dict__["express_sync_id"] = express_sync_id
            if gateway_id is None and not opts.urn:
                raise TypeError("Missing required property 'gateway_id'")
            __props__.__dict__["gateway_id"] = gateway_id
            if share_name is None and not opts.urn:
                raise TypeError("Missing required property 'share_name'")
            __props__.__dict__["share_name"] = share_name
        super(ExpressSyncShareAttachment, __self__).__init__(
            'alicloud:cloudstoragegateway/expressSyncShareAttachment:ExpressSyncShareAttachment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            express_sync_id: Optional[pulumi.Input[str]] = None,
            gateway_id: Optional[pulumi.Input[str]] = None,
            share_name: Optional[pulumi.Input[str]] = None) -> 'ExpressSyncShareAttachment':
        """
        Get an existing ExpressSyncShareAttachment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] express_sync_id: The ID of the ExpressSync.
        :param pulumi.Input[str] gateway_id: The ID of the Gateway.
        :param pulumi.Input[str] share_name: The name of the GatewayFileShare. **NOTE:** When GatewayFileShare is associated with a speed sync group, its reverse synchronization function will be turned off by default.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ExpressSyncShareAttachmentState.__new__(_ExpressSyncShareAttachmentState)

        __props__.__dict__["express_sync_id"] = express_sync_id
        __props__.__dict__["gateway_id"] = gateway_id
        __props__.__dict__["share_name"] = share_name
        return ExpressSyncShareAttachment(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="expressSyncId")
    def express_sync_id(self) -> pulumi.Output[str]:
        """
        The ID of the ExpressSync.
        """
        return pulumi.get(self, "express_sync_id")

    @property
    @pulumi.getter(name="gatewayId")
    def gateway_id(self) -> pulumi.Output[str]:
        """
        The ID of the Gateway.
        """
        return pulumi.get(self, "gateway_id")

    @property
    @pulumi.getter(name="shareName")
    def share_name(self) -> pulumi.Output[str]:
        """
        The name of the GatewayFileShare. **NOTE:** When GatewayFileShare is associated with a speed sync group, its reverse synchronization function will be turned off by default.
        """
        return pulumi.get(self, "share_name")
