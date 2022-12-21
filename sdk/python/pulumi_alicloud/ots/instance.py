# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['InstanceArgs', 'Instance']

@pulumi.input_type
class InstanceArgs:
    def __init__(__self__, *,
                 accessed_by: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 instance_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        """
        The set of arguments for constructing a Instance resource.
        :param pulumi.Input[str] accessed_by: The network limitation of accessing instance. Valid values:
        :param pulumi.Input[str] description: The description of the instance. Currently, it does not support modifying.
        :param pulumi.Input[str] instance_type: The type of instance. Valid values are "Capacity" and "HighPerformance". Default to "HighPerformance".
        :param pulumi.Input[str] name: The name of the instance.
        :param pulumi.Input[Mapping[str, Any]] tags: A mapping of tags to assign to the instance.
        """
        if accessed_by is not None:
            pulumi.set(__self__, "accessed_by", accessed_by)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if instance_type is not None:
            pulumi.set(__self__, "instance_type", instance_type)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="accessedBy")
    def accessed_by(self) -> Optional[pulumi.Input[str]]:
        """
        The network limitation of accessing instance. Valid values:
        """
        return pulumi.get(self, "accessed_by")

    @accessed_by.setter
    def accessed_by(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "accessed_by", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The description of the instance. Currently, it does not support modifying.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> Optional[pulumi.Input[str]]:
        """
        The type of instance. Valid values are "Capacity" and "HighPerformance". Default to "HighPerformance".
        """
        return pulumi.get(self, "instance_type")

    @instance_type.setter
    def instance_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_type", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the instance.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        A mapping of tags to assign to the instance.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "tags", value)


@pulumi.input_type
class _InstanceState:
    def __init__(__self__, *,
                 accessed_by: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 instance_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        """
        Input properties used for looking up and filtering Instance resources.
        :param pulumi.Input[str] accessed_by: The network limitation of accessing instance. Valid values:
        :param pulumi.Input[str] description: The description of the instance. Currently, it does not support modifying.
        :param pulumi.Input[str] instance_type: The type of instance. Valid values are "Capacity" and "HighPerformance". Default to "HighPerformance".
        :param pulumi.Input[str] name: The name of the instance.
        :param pulumi.Input[Mapping[str, Any]] tags: A mapping of tags to assign to the instance.
        """
        if accessed_by is not None:
            pulumi.set(__self__, "accessed_by", accessed_by)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if instance_type is not None:
            pulumi.set(__self__, "instance_type", instance_type)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="accessedBy")
    def accessed_by(self) -> Optional[pulumi.Input[str]]:
        """
        The network limitation of accessing instance. Valid values:
        """
        return pulumi.get(self, "accessed_by")

    @accessed_by.setter
    def accessed_by(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "accessed_by", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The description of the instance. Currently, it does not support modifying.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> Optional[pulumi.Input[str]]:
        """
        The type of instance. Valid values are "Capacity" and "HighPerformance". Default to "HighPerformance".
        """
        return pulumi.get(self, "instance_type")

    @instance_type.setter
    def instance_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_type", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the instance.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        A mapping of tags to assign to the instance.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "tags", value)


class Instance(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 accessed_by: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 instance_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 __props__=None):
        """
        This resource will help you to manager a [Table Store](https://www.alibabacloud.com/help/doc-detail/27280.htm) Instance.
        It is foundation of creating data table.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        # Create an OTS instance
        foo = alicloud.ots.Instance("foo",
            accessed_by="Vpc",
            description="for table",
            tags={
                "Created": "TF",
                "For": "Building table",
            })
        ```

        ## Import

        OTS instance can be imported using instance id or name, e.g.

        ```sh
         $ pulumi import alicloud:ots/instance:Instance foo "my-ots-instance"
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] accessed_by: The network limitation of accessing instance. Valid values:
        :param pulumi.Input[str] description: The description of the instance. Currently, it does not support modifying.
        :param pulumi.Input[str] instance_type: The type of instance. Valid values are "Capacity" and "HighPerformance". Default to "HighPerformance".
        :param pulumi.Input[str] name: The name of the instance.
        :param pulumi.Input[Mapping[str, Any]] tags: A mapping of tags to assign to the instance.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[InstanceArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        This resource will help you to manager a [Table Store](https://www.alibabacloud.com/help/doc-detail/27280.htm) Instance.
        It is foundation of creating data table.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        # Create an OTS instance
        foo = alicloud.ots.Instance("foo",
            accessed_by="Vpc",
            description="for table",
            tags={
                "Created": "TF",
                "For": "Building table",
            })
        ```

        ## Import

        OTS instance can be imported using instance id or name, e.g.

        ```sh
         $ pulumi import alicloud:ots/instance:Instance foo "my-ots-instance"
        ```

        :param str resource_name: The name of the resource.
        :param InstanceArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(InstanceArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 accessed_by: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 instance_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = InstanceArgs.__new__(InstanceArgs)

            __props__.__dict__["accessed_by"] = accessed_by
            __props__.__dict__["description"] = description
            __props__.__dict__["instance_type"] = instance_type
            __props__.__dict__["name"] = name
            __props__.__dict__["tags"] = tags
        super(Instance, __self__).__init__(
            'alicloud:ots/instance:Instance',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            accessed_by: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            instance_type: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, Any]]] = None) -> 'Instance':
        """
        Get an existing Instance resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] accessed_by: The network limitation of accessing instance. Valid values:
        :param pulumi.Input[str] description: The description of the instance. Currently, it does not support modifying.
        :param pulumi.Input[str] instance_type: The type of instance. Valid values are "Capacity" and "HighPerformance". Default to "HighPerformance".
        :param pulumi.Input[str] name: The name of the instance.
        :param pulumi.Input[Mapping[str, Any]] tags: A mapping of tags to assign to the instance.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _InstanceState.__new__(_InstanceState)

        __props__.__dict__["accessed_by"] = accessed_by
        __props__.__dict__["description"] = description
        __props__.__dict__["instance_type"] = instance_type
        __props__.__dict__["name"] = name
        __props__.__dict__["tags"] = tags
        return Instance(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accessedBy")
    def accessed_by(self) -> pulumi.Output[Optional[str]]:
        """
        The network limitation of accessing instance. Valid values:
        """
        return pulumi.get(self, "accessed_by")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        The description of the instance. Currently, it does not support modifying.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> pulumi.Output[Optional[str]]:
        """
        The type of instance. Valid values are "Capacity" and "HighPerformance". Default to "HighPerformance".
        """
        return pulumi.get(self, "instance_type")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the instance.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, Any]]]:
        """
        A mapping of tags to assign to the instance.
        """
        return pulumi.get(self, "tags")
