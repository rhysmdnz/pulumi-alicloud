# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['FilesetArgs', 'Fileset']

@pulumi.input_type
class FilesetArgs:
    def __init__(__self__, *,
                 file_system_id: pulumi.Input[str],
                 file_system_path: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 dry_run: Optional[pulumi.Input[bool]] = None):
        """
        The set of arguments for constructing a Fileset resource.
        :param pulumi.Input[str] file_system_id: The ID of the file system.
        :param pulumi.Input[str] file_system_path: The path of the fileset.
        :param pulumi.Input[str] description: The description of the Fileset. It must be `2` to `128` characters in length and must start with a letter or Chinese, but cannot start with `https://` or `https://`.
        :param pulumi.Input[bool] dry_run: The dry run.
        """
        pulumi.set(__self__, "file_system_id", file_system_id)
        pulumi.set(__self__, "file_system_path", file_system_path)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if dry_run is not None:
            pulumi.set(__self__, "dry_run", dry_run)

    @property
    @pulumi.getter(name="fileSystemId")
    def file_system_id(self) -> pulumi.Input[str]:
        """
        The ID of the file system.
        """
        return pulumi.get(self, "file_system_id")

    @file_system_id.setter
    def file_system_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "file_system_id", value)

    @property
    @pulumi.getter(name="fileSystemPath")
    def file_system_path(self) -> pulumi.Input[str]:
        """
        The path of the fileset.
        """
        return pulumi.get(self, "file_system_path")

    @file_system_path.setter
    def file_system_path(self, value: pulumi.Input[str]):
        pulumi.set(self, "file_system_path", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The description of the Fileset. It must be `2` to `128` characters in length and must start with a letter or Chinese, but cannot start with `https://` or `https://`.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

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


@pulumi.input_type
class _FilesetState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 dry_run: Optional[pulumi.Input[bool]] = None,
                 file_system_id: Optional[pulumi.Input[str]] = None,
                 file_system_path: Optional[pulumi.Input[str]] = None,
                 fileset_id: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Fileset resources.
        :param pulumi.Input[str] description: The description of the Fileset. It must be `2` to `128` characters in length and must start with a letter or Chinese, but cannot start with `https://` or `https://`.
        :param pulumi.Input[bool] dry_run: The dry run.
        :param pulumi.Input[str] file_system_id: The ID of the file system.
        :param pulumi.Input[str] file_system_path: The path of the fileset.
        :param pulumi.Input[str] fileset_id: The first ID of the resource.
        :param pulumi.Input[str] status: The status of the fileset.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if dry_run is not None:
            pulumi.set(__self__, "dry_run", dry_run)
        if file_system_id is not None:
            pulumi.set(__self__, "file_system_id", file_system_id)
        if file_system_path is not None:
            pulumi.set(__self__, "file_system_path", file_system_path)
        if fileset_id is not None:
            pulumi.set(__self__, "fileset_id", fileset_id)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The description of the Fileset. It must be `2` to `128` characters in length and must start with a letter or Chinese, but cannot start with `https://` or `https://`.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

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
    @pulumi.getter(name="fileSystemId")
    def file_system_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the file system.
        """
        return pulumi.get(self, "file_system_id")

    @file_system_id.setter
    def file_system_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "file_system_id", value)

    @property
    @pulumi.getter(name="fileSystemPath")
    def file_system_path(self) -> Optional[pulumi.Input[str]]:
        """
        The path of the fileset.
        """
        return pulumi.get(self, "file_system_path")

    @file_system_path.setter
    def file_system_path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "file_system_path", value)

    @property
    @pulumi.getter(name="filesetId")
    def fileset_id(self) -> Optional[pulumi.Input[str]]:
        """
        The first ID of the resource.
        """
        return pulumi.get(self, "fileset_id")

    @fileset_id.setter
    def fileset_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "fileset_id", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        The status of the fileset.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


class Fileset(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 dry_run: Optional[pulumi.Input[bool]] = None,
                 file_system_id: Optional[pulumi.Input[str]] = None,
                 file_system_path: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a Network Attached Storage (NAS) Fileset resource.

        For information about Network Attached Storage (NAS) Fileset and how to use it, see [What is Fileset](https://www.alibabacloud.com/help/en/doc-detail/27530.html).

        > **NOTE:** Available in v1.153.0+.

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        default_zones = alicloud.nas.get_zones(file_system_type="cpfs")
        default_networks = alicloud.vpc.get_networks(name_regex="default-NODELETING")
        default_switches = alicloud.vpc.get_switches(vpc_id=default_networks.ids[0],
            zone_id=default_zones.zones[0].zone_id)
        default_file_system = alicloud.nas.FileSystem("defaultFileSystem",
            protocol_type="cpfs",
            storage_type="advance_200",
            file_system_type="cpfs",
            capacity=3600,
            description="tf-testacc",
            zone_id=default_zones.zones[0].zone_id,
            vpc_id=default_networks.ids[0],
            vswitch_id=default_switches.ids[0])
        default_fileset = alicloud.nas.Fileset("defaultFileset",
            file_system_id=default_file_system.id,
            file_system_path="/example_path/",
            description="tf-testacc")
        ```

        ## Import

        Network Attached Storage (NAS) Fileset can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:nas/fileset:Fileset example <file_system_id>:<fileset_id>
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The description of the Fileset. It must be `2` to `128` characters in length and must start with a letter or Chinese, but cannot start with `https://` or `https://`.
        :param pulumi.Input[bool] dry_run: The dry run.
        :param pulumi.Input[str] file_system_id: The ID of the file system.
        :param pulumi.Input[str] file_system_path: The path of the fileset.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: FilesetArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a Network Attached Storage (NAS) Fileset resource.

        For information about Network Attached Storage (NAS) Fileset and how to use it, see [What is Fileset](https://www.alibabacloud.com/help/en/doc-detail/27530.html).

        > **NOTE:** Available in v1.153.0+.

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        default_zones = alicloud.nas.get_zones(file_system_type="cpfs")
        default_networks = alicloud.vpc.get_networks(name_regex="default-NODELETING")
        default_switches = alicloud.vpc.get_switches(vpc_id=default_networks.ids[0],
            zone_id=default_zones.zones[0].zone_id)
        default_file_system = alicloud.nas.FileSystem("defaultFileSystem",
            protocol_type="cpfs",
            storage_type="advance_200",
            file_system_type="cpfs",
            capacity=3600,
            description="tf-testacc",
            zone_id=default_zones.zones[0].zone_id,
            vpc_id=default_networks.ids[0],
            vswitch_id=default_switches.ids[0])
        default_fileset = alicloud.nas.Fileset("defaultFileset",
            file_system_id=default_file_system.id,
            file_system_path="/example_path/",
            description="tf-testacc")
        ```

        ## Import

        Network Attached Storage (NAS) Fileset can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:nas/fileset:Fileset example <file_system_id>:<fileset_id>
        ```

        :param str resource_name: The name of the resource.
        :param FilesetArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(FilesetArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 dry_run: Optional[pulumi.Input[bool]] = None,
                 file_system_id: Optional[pulumi.Input[str]] = None,
                 file_system_path: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = FilesetArgs.__new__(FilesetArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["dry_run"] = dry_run
            if file_system_id is None and not opts.urn:
                raise TypeError("Missing required property 'file_system_id'")
            __props__.__dict__["file_system_id"] = file_system_id
            if file_system_path is None and not opts.urn:
                raise TypeError("Missing required property 'file_system_path'")
            __props__.__dict__["file_system_path"] = file_system_path
            __props__.__dict__["fileset_id"] = None
            __props__.__dict__["status"] = None
        super(Fileset, __self__).__init__(
            'alicloud:nas/fileset:Fileset',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            dry_run: Optional[pulumi.Input[bool]] = None,
            file_system_id: Optional[pulumi.Input[str]] = None,
            file_system_path: Optional[pulumi.Input[str]] = None,
            fileset_id: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None) -> 'Fileset':
        """
        Get an existing Fileset resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The description of the Fileset. It must be `2` to `128` characters in length and must start with a letter or Chinese, but cannot start with `https://` or `https://`.
        :param pulumi.Input[bool] dry_run: The dry run.
        :param pulumi.Input[str] file_system_id: The ID of the file system.
        :param pulumi.Input[str] file_system_path: The path of the fileset.
        :param pulumi.Input[str] fileset_id: The first ID of the resource.
        :param pulumi.Input[str] status: The status of the fileset.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _FilesetState.__new__(_FilesetState)

        __props__.__dict__["description"] = description
        __props__.__dict__["dry_run"] = dry_run
        __props__.__dict__["file_system_id"] = file_system_id
        __props__.__dict__["file_system_path"] = file_system_path
        __props__.__dict__["fileset_id"] = fileset_id
        __props__.__dict__["status"] = status
        return Fileset(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        The description of the Fileset. It must be `2` to `128` characters in length and must start with a letter or Chinese, but cannot start with `https://` or `https://`.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="dryRun")
    def dry_run(self) -> pulumi.Output[Optional[bool]]:
        """
        The dry run.
        """
        return pulumi.get(self, "dry_run")

    @property
    @pulumi.getter(name="fileSystemId")
    def file_system_id(self) -> pulumi.Output[str]:
        """
        The ID of the file system.
        """
        return pulumi.get(self, "file_system_id")

    @property
    @pulumi.getter(name="fileSystemPath")
    def file_system_path(self) -> pulumi.Output[str]:
        """
        The path of the fileset.
        """
        return pulumi.get(self, "file_system_path")

    @property
    @pulumi.getter(name="filesetId")
    def fileset_id(self) -> pulumi.Output[str]:
        """
        The first ID of the resource.
        """
        return pulumi.get(self, "fileset_id")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        The status of the fileset.
        """
        return pulumi.get(self, "status")
