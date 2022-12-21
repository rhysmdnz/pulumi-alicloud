# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['EcsBackupClientArgs', 'EcsBackupClient']

@pulumi.input_type
class EcsBackupClientArgs:
    def __init__(__self__, *,
                 instance_id: pulumi.Input[str],
                 data_network_type: Optional[pulumi.Input[str]] = None,
                 data_proxy_setting: Optional[pulumi.Input[str]] = None,
                 max_cpu_core: Optional[pulumi.Input[str]] = None,
                 max_worker: Optional[pulumi.Input[str]] = None,
                 proxy_host: Optional[pulumi.Input[str]] = None,
                 proxy_password: Optional[pulumi.Input[str]] = None,
                 proxy_port: Optional[pulumi.Input[str]] = None,
                 proxy_user: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 use_https: Optional[pulumi.Input[bool]] = None):
        """
        The set of arguments for constructing a EcsBackupClient resource.
        :param pulumi.Input[str] instance_id: The ID of ECS instance.
        :param pulumi.Input[str] data_network_type: The data plane access point type. Valid values: `CLASSIC`, `PUBLIC`, `VPC`. **NOTE:** The value of `CLASSIC` has been deprecated in v1.161.0+.
        :param pulumi.Input[str] data_proxy_setting: The data plane proxy settings. Valid values: `CUSTOM`, `DISABLE`, `USE_CONTROL_PROXY`.
        :param pulumi.Input[str] max_cpu_core: The number of CPU cores used by a single backup task, 0 means no restrictions.
        :param pulumi.Input[str] max_worker: The number of concurrent jobs for a single backup task, 0 means no restrictions.
        :param pulumi.Input[str] proxy_host: Custom data plane proxy server host address.
        :param pulumi.Input[str] proxy_password: The password of custom data plane proxy server.
        :param pulumi.Input[str] proxy_port: Custom data plane proxy server host port.
        :param pulumi.Input[str] proxy_user: The username of custom data plane proxy server.
        :param pulumi.Input[str] status: Status of client. Valid values: `ACTIVATED`, `STOPPED`. You can start or stop the client by specifying the status.
        :param pulumi.Input[bool] use_https: Indicates whether to use the HTTPS protocol. Valid values: `true`, `false`.
        """
        pulumi.set(__self__, "instance_id", instance_id)
        if data_network_type is not None:
            pulumi.set(__self__, "data_network_type", data_network_type)
        if data_proxy_setting is not None:
            pulumi.set(__self__, "data_proxy_setting", data_proxy_setting)
        if max_cpu_core is not None:
            pulumi.set(__self__, "max_cpu_core", max_cpu_core)
        if max_worker is not None:
            pulumi.set(__self__, "max_worker", max_worker)
        if proxy_host is not None:
            pulumi.set(__self__, "proxy_host", proxy_host)
        if proxy_password is not None:
            pulumi.set(__self__, "proxy_password", proxy_password)
        if proxy_port is not None:
            pulumi.set(__self__, "proxy_port", proxy_port)
        if proxy_user is not None:
            pulumi.set(__self__, "proxy_user", proxy_user)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if use_https is not None:
            pulumi.set(__self__, "use_https", use_https)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        The ID of ECS instance.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="dataNetworkType")
    def data_network_type(self) -> Optional[pulumi.Input[str]]:
        """
        The data plane access point type. Valid values: `CLASSIC`, `PUBLIC`, `VPC`. **NOTE:** The value of `CLASSIC` has been deprecated in v1.161.0+.
        """
        return pulumi.get(self, "data_network_type")

    @data_network_type.setter
    def data_network_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "data_network_type", value)

    @property
    @pulumi.getter(name="dataProxySetting")
    def data_proxy_setting(self) -> Optional[pulumi.Input[str]]:
        """
        The data plane proxy settings. Valid values: `CUSTOM`, `DISABLE`, `USE_CONTROL_PROXY`.
        """
        return pulumi.get(self, "data_proxy_setting")

    @data_proxy_setting.setter
    def data_proxy_setting(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "data_proxy_setting", value)

    @property
    @pulumi.getter(name="maxCpuCore")
    def max_cpu_core(self) -> Optional[pulumi.Input[str]]:
        """
        The number of CPU cores used by a single backup task, 0 means no restrictions.
        """
        return pulumi.get(self, "max_cpu_core")

    @max_cpu_core.setter
    def max_cpu_core(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "max_cpu_core", value)

    @property
    @pulumi.getter(name="maxWorker")
    def max_worker(self) -> Optional[pulumi.Input[str]]:
        """
        The number of concurrent jobs for a single backup task, 0 means no restrictions.
        """
        return pulumi.get(self, "max_worker")

    @max_worker.setter
    def max_worker(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "max_worker", value)

    @property
    @pulumi.getter(name="proxyHost")
    def proxy_host(self) -> Optional[pulumi.Input[str]]:
        """
        Custom data plane proxy server host address.
        """
        return pulumi.get(self, "proxy_host")

    @proxy_host.setter
    def proxy_host(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "proxy_host", value)

    @property
    @pulumi.getter(name="proxyPassword")
    def proxy_password(self) -> Optional[pulumi.Input[str]]:
        """
        The password of custom data plane proxy server.
        """
        return pulumi.get(self, "proxy_password")

    @proxy_password.setter
    def proxy_password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "proxy_password", value)

    @property
    @pulumi.getter(name="proxyPort")
    def proxy_port(self) -> Optional[pulumi.Input[str]]:
        """
        Custom data plane proxy server host port.
        """
        return pulumi.get(self, "proxy_port")

    @proxy_port.setter
    def proxy_port(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "proxy_port", value)

    @property
    @pulumi.getter(name="proxyUser")
    def proxy_user(self) -> Optional[pulumi.Input[str]]:
        """
        The username of custom data plane proxy server.
        """
        return pulumi.get(self, "proxy_user")

    @proxy_user.setter
    def proxy_user(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "proxy_user", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Status of client. Valid values: `ACTIVATED`, `STOPPED`. You can start or stop the client by specifying the status.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter(name="useHttps")
    def use_https(self) -> Optional[pulumi.Input[bool]]:
        """
        Indicates whether to use the HTTPS protocol. Valid values: `true`, `false`.
        """
        return pulumi.get(self, "use_https")

    @use_https.setter
    def use_https(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "use_https", value)


@pulumi.input_type
class _EcsBackupClientState:
    def __init__(__self__, *,
                 data_network_type: Optional[pulumi.Input[str]] = None,
                 data_proxy_setting: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 max_cpu_core: Optional[pulumi.Input[str]] = None,
                 max_worker: Optional[pulumi.Input[str]] = None,
                 proxy_host: Optional[pulumi.Input[str]] = None,
                 proxy_password: Optional[pulumi.Input[str]] = None,
                 proxy_port: Optional[pulumi.Input[str]] = None,
                 proxy_user: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 use_https: Optional[pulumi.Input[bool]] = None):
        """
        Input properties used for looking up and filtering EcsBackupClient resources.
        :param pulumi.Input[str] data_network_type: The data plane access point type. Valid values: `CLASSIC`, `PUBLIC`, `VPC`. **NOTE:** The value of `CLASSIC` has been deprecated in v1.161.0+.
        :param pulumi.Input[str] data_proxy_setting: The data plane proxy settings. Valid values: `CUSTOM`, `DISABLE`, `USE_CONTROL_PROXY`.
        :param pulumi.Input[str] instance_id: The ID of ECS instance.
        :param pulumi.Input[str] max_cpu_core: The number of CPU cores used by a single backup task, 0 means no restrictions.
        :param pulumi.Input[str] max_worker: The number of concurrent jobs for a single backup task, 0 means no restrictions.
        :param pulumi.Input[str] proxy_host: Custom data plane proxy server host address.
        :param pulumi.Input[str] proxy_password: The password of custom data plane proxy server.
        :param pulumi.Input[str] proxy_port: Custom data plane proxy server host port.
        :param pulumi.Input[str] proxy_user: The username of custom data plane proxy server.
        :param pulumi.Input[str] status: Status of client. Valid values: `ACTIVATED`, `STOPPED`. You can start or stop the client by specifying the status.
        :param pulumi.Input[bool] use_https: Indicates whether to use the HTTPS protocol. Valid values: `true`, `false`.
        """
        if data_network_type is not None:
            pulumi.set(__self__, "data_network_type", data_network_type)
        if data_proxy_setting is not None:
            pulumi.set(__self__, "data_proxy_setting", data_proxy_setting)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if max_cpu_core is not None:
            pulumi.set(__self__, "max_cpu_core", max_cpu_core)
        if max_worker is not None:
            pulumi.set(__self__, "max_worker", max_worker)
        if proxy_host is not None:
            pulumi.set(__self__, "proxy_host", proxy_host)
        if proxy_password is not None:
            pulumi.set(__self__, "proxy_password", proxy_password)
        if proxy_port is not None:
            pulumi.set(__self__, "proxy_port", proxy_port)
        if proxy_user is not None:
            pulumi.set(__self__, "proxy_user", proxy_user)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if use_https is not None:
            pulumi.set(__self__, "use_https", use_https)

    @property
    @pulumi.getter(name="dataNetworkType")
    def data_network_type(self) -> Optional[pulumi.Input[str]]:
        """
        The data plane access point type. Valid values: `CLASSIC`, `PUBLIC`, `VPC`. **NOTE:** The value of `CLASSIC` has been deprecated in v1.161.0+.
        """
        return pulumi.get(self, "data_network_type")

    @data_network_type.setter
    def data_network_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "data_network_type", value)

    @property
    @pulumi.getter(name="dataProxySetting")
    def data_proxy_setting(self) -> Optional[pulumi.Input[str]]:
        """
        The data plane proxy settings. Valid values: `CUSTOM`, `DISABLE`, `USE_CONTROL_PROXY`.
        """
        return pulumi.get(self, "data_proxy_setting")

    @data_proxy_setting.setter
    def data_proxy_setting(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "data_proxy_setting", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of ECS instance.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="maxCpuCore")
    def max_cpu_core(self) -> Optional[pulumi.Input[str]]:
        """
        The number of CPU cores used by a single backup task, 0 means no restrictions.
        """
        return pulumi.get(self, "max_cpu_core")

    @max_cpu_core.setter
    def max_cpu_core(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "max_cpu_core", value)

    @property
    @pulumi.getter(name="maxWorker")
    def max_worker(self) -> Optional[pulumi.Input[str]]:
        """
        The number of concurrent jobs for a single backup task, 0 means no restrictions.
        """
        return pulumi.get(self, "max_worker")

    @max_worker.setter
    def max_worker(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "max_worker", value)

    @property
    @pulumi.getter(name="proxyHost")
    def proxy_host(self) -> Optional[pulumi.Input[str]]:
        """
        Custom data plane proxy server host address.
        """
        return pulumi.get(self, "proxy_host")

    @proxy_host.setter
    def proxy_host(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "proxy_host", value)

    @property
    @pulumi.getter(name="proxyPassword")
    def proxy_password(self) -> Optional[pulumi.Input[str]]:
        """
        The password of custom data plane proxy server.
        """
        return pulumi.get(self, "proxy_password")

    @proxy_password.setter
    def proxy_password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "proxy_password", value)

    @property
    @pulumi.getter(name="proxyPort")
    def proxy_port(self) -> Optional[pulumi.Input[str]]:
        """
        Custom data plane proxy server host port.
        """
        return pulumi.get(self, "proxy_port")

    @proxy_port.setter
    def proxy_port(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "proxy_port", value)

    @property
    @pulumi.getter(name="proxyUser")
    def proxy_user(self) -> Optional[pulumi.Input[str]]:
        """
        The username of custom data plane proxy server.
        """
        return pulumi.get(self, "proxy_user")

    @proxy_user.setter
    def proxy_user(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "proxy_user", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Status of client. Valid values: `ACTIVATED`, `STOPPED`. You can start or stop the client by specifying the status.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter(name="useHttps")
    def use_https(self) -> Optional[pulumi.Input[bool]]:
        """
        Indicates whether to use the HTTPS protocol. Valid values: `true`, `false`.
        """
        return pulumi.get(self, "use_https")

    @use_https.setter
    def use_https(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "use_https", value)


class EcsBackupClient(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 data_network_type: Optional[pulumi.Input[str]] = None,
                 data_proxy_setting: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 max_cpu_core: Optional[pulumi.Input[str]] = None,
                 max_worker: Optional[pulumi.Input[str]] = None,
                 proxy_host: Optional[pulumi.Input[str]] = None,
                 proxy_password: Optional[pulumi.Input[str]] = None,
                 proxy_port: Optional[pulumi.Input[str]] = None,
                 proxy_user: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 use_https: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        """
        Provides a Hybrid Backup Recovery (HBR) Ecs Backup Client resource.

        For information about Hybrid Backup Recovery (HBR) Ecs Backup Client and how to use it, see [What is Ecs Backup Client](https://www.alibabacloud.com/help/doc-detail/186570.htm).

        > **NOTE:** Available in v1.132.0+.

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        default = alicloud.ecs.get_instances(name_regex="ecs_instance_name",
            status="Running")
        example = alicloud.hbr.EcsBackupClient("example",
            instance_id=default.instances[0].id,
            use_https=False,
            data_network_type="PUBLIC",
            max_cpu_core="2",
            max_worker="4",
            data_proxy_setting="USE_CONTROL_PROXY",
            proxy_host="192.168.11.101",
            proxy_port="80",
            proxy_user="user",
            proxy_password="password")
        ```
        ## Notice

        > **Note:** Please read the following precautions carefully before deleting a client:
        1. You cannot delete active clients that have received heartbeat packets within one hour.
        2. You can make the client inactive by change the status of client to `STOPPED`.
        3. The resources bound to the client will be deleted in cascade, including:
            - Backup plan
            - Backup task (Running in the background)
            - Snapshot

        ## Import

        Hybrid Backup Recovery (HBR) Ecs Backup Client can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:hbr/ecsBackupClient:EcsBackupClient example <id>
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] data_network_type: The data plane access point type. Valid values: `CLASSIC`, `PUBLIC`, `VPC`. **NOTE:** The value of `CLASSIC` has been deprecated in v1.161.0+.
        :param pulumi.Input[str] data_proxy_setting: The data plane proxy settings. Valid values: `CUSTOM`, `DISABLE`, `USE_CONTROL_PROXY`.
        :param pulumi.Input[str] instance_id: The ID of ECS instance.
        :param pulumi.Input[str] max_cpu_core: The number of CPU cores used by a single backup task, 0 means no restrictions.
        :param pulumi.Input[str] max_worker: The number of concurrent jobs for a single backup task, 0 means no restrictions.
        :param pulumi.Input[str] proxy_host: Custom data plane proxy server host address.
        :param pulumi.Input[str] proxy_password: The password of custom data plane proxy server.
        :param pulumi.Input[str] proxy_port: Custom data plane proxy server host port.
        :param pulumi.Input[str] proxy_user: The username of custom data plane proxy server.
        :param pulumi.Input[str] status: Status of client. Valid values: `ACTIVATED`, `STOPPED`. You can start or stop the client by specifying the status.
        :param pulumi.Input[bool] use_https: Indicates whether to use the HTTPS protocol. Valid values: `true`, `false`.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: EcsBackupClientArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a Hybrid Backup Recovery (HBR) Ecs Backup Client resource.

        For information about Hybrid Backup Recovery (HBR) Ecs Backup Client and how to use it, see [What is Ecs Backup Client](https://www.alibabacloud.com/help/doc-detail/186570.htm).

        > **NOTE:** Available in v1.132.0+.

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        default = alicloud.ecs.get_instances(name_regex="ecs_instance_name",
            status="Running")
        example = alicloud.hbr.EcsBackupClient("example",
            instance_id=default.instances[0].id,
            use_https=False,
            data_network_type="PUBLIC",
            max_cpu_core="2",
            max_worker="4",
            data_proxy_setting="USE_CONTROL_PROXY",
            proxy_host="192.168.11.101",
            proxy_port="80",
            proxy_user="user",
            proxy_password="password")
        ```
        ## Notice

        > **Note:** Please read the following precautions carefully before deleting a client:
        1. You cannot delete active clients that have received heartbeat packets within one hour.
        2. You can make the client inactive by change the status of client to `STOPPED`.
        3. The resources bound to the client will be deleted in cascade, including:
            - Backup plan
            - Backup task (Running in the background)
            - Snapshot

        ## Import

        Hybrid Backup Recovery (HBR) Ecs Backup Client can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:hbr/ecsBackupClient:EcsBackupClient example <id>
        ```

        :param str resource_name: The name of the resource.
        :param EcsBackupClientArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(EcsBackupClientArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 data_network_type: Optional[pulumi.Input[str]] = None,
                 data_proxy_setting: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 max_cpu_core: Optional[pulumi.Input[str]] = None,
                 max_worker: Optional[pulumi.Input[str]] = None,
                 proxy_host: Optional[pulumi.Input[str]] = None,
                 proxy_password: Optional[pulumi.Input[str]] = None,
                 proxy_port: Optional[pulumi.Input[str]] = None,
                 proxy_user: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 use_https: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = EcsBackupClientArgs.__new__(EcsBackupClientArgs)

            __props__.__dict__["data_network_type"] = data_network_type
            __props__.__dict__["data_proxy_setting"] = data_proxy_setting
            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            __props__.__dict__["max_cpu_core"] = max_cpu_core
            __props__.__dict__["max_worker"] = max_worker
            __props__.__dict__["proxy_host"] = proxy_host
            __props__.__dict__["proxy_password"] = proxy_password
            __props__.__dict__["proxy_port"] = proxy_port
            __props__.__dict__["proxy_user"] = proxy_user
            __props__.__dict__["status"] = status
            __props__.__dict__["use_https"] = use_https
        super(EcsBackupClient, __self__).__init__(
            'alicloud:hbr/ecsBackupClient:EcsBackupClient',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            data_network_type: Optional[pulumi.Input[str]] = None,
            data_proxy_setting: Optional[pulumi.Input[str]] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            max_cpu_core: Optional[pulumi.Input[str]] = None,
            max_worker: Optional[pulumi.Input[str]] = None,
            proxy_host: Optional[pulumi.Input[str]] = None,
            proxy_password: Optional[pulumi.Input[str]] = None,
            proxy_port: Optional[pulumi.Input[str]] = None,
            proxy_user: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None,
            use_https: Optional[pulumi.Input[bool]] = None) -> 'EcsBackupClient':
        """
        Get an existing EcsBackupClient resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] data_network_type: The data plane access point type. Valid values: `CLASSIC`, `PUBLIC`, `VPC`. **NOTE:** The value of `CLASSIC` has been deprecated in v1.161.0+.
        :param pulumi.Input[str] data_proxy_setting: The data plane proxy settings. Valid values: `CUSTOM`, `DISABLE`, `USE_CONTROL_PROXY`.
        :param pulumi.Input[str] instance_id: The ID of ECS instance.
        :param pulumi.Input[str] max_cpu_core: The number of CPU cores used by a single backup task, 0 means no restrictions.
        :param pulumi.Input[str] max_worker: The number of concurrent jobs for a single backup task, 0 means no restrictions.
        :param pulumi.Input[str] proxy_host: Custom data plane proxy server host address.
        :param pulumi.Input[str] proxy_password: The password of custom data plane proxy server.
        :param pulumi.Input[str] proxy_port: Custom data plane proxy server host port.
        :param pulumi.Input[str] proxy_user: The username of custom data plane proxy server.
        :param pulumi.Input[str] status: Status of client. Valid values: `ACTIVATED`, `STOPPED`. You can start or stop the client by specifying the status.
        :param pulumi.Input[bool] use_https: Indicates whether to use the HTTPS protocol. Valid values: `true`, `false`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _EcsBackupClientState.__new__(_EcsBackupClientState)

        __props__.__dict__["data_network_type"] = data_network_type
        __props__.__dict__["data_proxy_setting"] = data_proxy_setting
        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["max_cpu_core"] = max_cpu_core
        __props__.__dict__["max_worker"] = max_worker
        __props__.__dict__["proxy_host"] = proxy_host
        __props__.__dict__["proxy_password"] = proxy_password
        __props__.__dict__["proxy_port"] = proxy_port
        __props__.__dict__["proxy_user"] = proxy_user
        __props__.__dict__["status"] = status
        __props__.__dict__["use_https"] = use_https
        return EcsBackupClient(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dataNetworkType")
    def data_network_type(self) -> pulumi.Output[str]:
        """
        The data plane access point type. Valid values: `CLASSIC`, `PUBLIC`, `VPC`. **NOTE:** The value of `CLASSIC` has been deprecated in v1.161.0+.
        """
        return pulumi.get(self, "data_network_type")

    @property
    @pulumi.getter(name="dataProxySetting")
    def data_proxy_setting(self) -> pulumi.Output[str]:
        """
        The data plane proxy settings. Valid values: `CUSTOM`, `DISABLE`, `USE_CONTROL_PROXY`.
        """
        return pulumi.get(self, "data_proxy_setting")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        The ID of ECS instance.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="maxCpuCore")
    def max_cpu_core(self) -> pulumi.Output[str]:
        """
        The number of CPU cores used by a single backup task, 0 means no restrictions.
        """
        return pulumi.get(self, "max_cpu_core")

    @property
    @pulumi.getter(name="maxWorker")
    def max_worker(self) -> pulumi.Output[str]:
        """
        The number of concurrent jobs for a single backup task, 0 means no restrictions.
        """
        return pulumi.get(self, "max_worker")

    @property
    @pulumi.getter(name="proxyHost")
    def proxy_host(self) -> pulumi.Output[str]:
        """
        Custom data plane proxy server host address.
        """
        return pulumi.get(self, "proxy_host")

    @property
    @pulumi.getter(name="proxyPassword")
    def proxy_password(self) -> pulumi.Output[str]:
        """
        The password of custom data plane proxy server.
        """
        return pulumi.get(self, "proxy_password")

    @property
    @pulumi.getter(name="proxyPort")
    def proxy_port(self) -> pulumi.Output[str]:
        """
        Custom data plane proxy server host port.
        """
        return pulumi.get(self, "proxy_port")

    @property
    @pulumi.getter(name="proxyUser")
    def proxy_user(self) -> pulumi.Output[str]:
        """
        The username of custom data plane proxy server.
        """
        return pulumi.get(self, "proxy_user")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        Status of client. Valid values: `ACTIVATED`, `STOPPED`. You can start or stop the client by specifying the status.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="useHttps")
    def use_https(self) -> pulumi.Output[bool]:
        """
        Indicates whether to use the HTTPS protocol. Valid values: `true`, `false`.
        """
        return pulumi.get(self, "use_https")
