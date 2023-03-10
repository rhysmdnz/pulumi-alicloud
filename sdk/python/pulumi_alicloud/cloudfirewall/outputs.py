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

__all__ = [
    'AddressBookEcsTag',
    'GetAddressBooksBookResult',
    'GetAddressBooksBookEcsTagResult',
    'GetControlPoliciesPolicyResult',
    'GetInstancesInstanceResult',
]

@pulumi.output_type
class AddressBookEcsTag(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "tagKey":
            suggest = "tag_key"
        elif key == "tagValue":
            suggest = "tag_value"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in AddressBookEcsTag. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        AddressBookEcsTag.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        AddressBookEcsTag.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 tag_key: Optional[str] = None,
                 tag_value: Optional[str] = None):
        """
        :param str tag_key: The key of ECS tag that to be matched.
        :param str tag_value: The value of ECS tag that to be matched.
        """
        if tag_key is not None:
            pulumi.set(__self__, "tag_key", tag_key)
        if tag_value is not None:
            pulumi.set(__self__, "tag_value", tag_value)

    @property
    @pulumi.getter(name="tagKey")
    def tag_key(self) -> Optional[str]:
        """
        The key of ECS tag that to be matched.
        """
        return pulumi.get(self, "tag_key")

    @property
    @pulumi.getter(name="tagValue")
    def tag_value(self) -> Optional[str]:
        """
        The value of ECS tag that to be matched.
        """
        return pulumi.get(self, "tag_value")


@pulumi.output_type
class GetAddressBooksBookResult(dict):
    def __init__(__self__, *,
                 address_lists: Sequence[str],
                 auto_add_tag_ecs: int,
                 description: str,
                 group_name: str,
                 group_type: str,
                 group_uuid: str,
                 id: str,
                 tag_relation: str,
                 ecs_tags: Optional[Sequence['outputs.GetAddressBooksBookEcsTagResult']] = None):
        """
        :param Sequence[str] address_lists: The addresses in the Address Book.
        :param int auto_add_tag_ecs: Whether you want to automatically add new matching tags of the ECS IP address to the Address Book.
        :param str description: The description of the Address Book.
        :param str group_name: The name of the Address Book.
        :param str group_type: The type of the Address Book.
        :param str group_uuid: The ID of the Address Book.
        :param str id: The ID of the Address Book.
        :param str tag_relation: One or more tags for the relationship between.
        :param Sequence['GetAddressBooksBookEcsTagArgs'] ecs_tags: The logical relation among the ECS tags that to be matchedh.
        """
        pulumi.set(__self__, "address_lists", address_lists)
        pulumi.set(__self__, "auto_add_tag_ecs", auto_add_tag_ecs)
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "group_name", group_name)
        pulumi.set(__self__, "group_type", group_type)
        pulumi.set(__self__, "group_uuid", group_uuid)
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "tag_relation", tag_relation)
        if ecs_tags is not None:
            pulumi.set(__self__, "ecs_tags", ecs_tags)

    @property
    @pulumi.getter(name="addressLists")
    def address_lists(self) -> Sequence[str]:
        """
        The addresses in the Address Book.
        """
        return pulumi.get(self, "address_lists")

    @property
    @pulumi.getter(name="autoAddTagEcs")
    def auto_add_tag_ecs(self) -> int:
        """
        Whether you want to automatically add new matching tags of the ECS IP address to the Address Book.
        """
        return pulumi.get(self, "auto_add_tag_ecs")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        The description of the Address Book.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="groupName")
    def group_name(self) -> str:
        """
        The name of the Address Book.
        """
        return pulumi.get(self, "group_name")

    @property
    @pulumi.getter(name="groupType")
    def group_type(self) -> str:
        """
        The type of the Address Book.
        """
        return pulumi.get(self, "group_type")

    @property
    @pulumi.getter(name="groupUuid")
    def group_uuid(self) -> str:
        """
        The ID of the Address Book.
        """
        return pulumi.get(self, "group_uuid")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The ID of the Address Book.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="tagRelation")
    def tag_relation(self) -> str:
        """
        One or more tags for the relationship between.
        """
        return pulumi.get(self, "tag_relation")

    @property
    @pulumi.getter(name="ecsTags")
    def ecs_tags(self) -> Optional[Sequence['outputs.GetAddressBooksBookEcsTagResult']]:
        """
        The logical relation among the ECS tags that to be matchedh.
        """
        return pulumi.get(self, "ecs_tags")


@pulumi.output_type
class GetAddressBooksBookEcsTagResult(dict):
    def __init__(__self__, *,
                 tag_key: Optional[str] = None,
                 tag_value: Optional[str] = None):
        """
        :param str tag_key: The key of ECS tag that to be matched.
        :param str tag_value: The value of ECS tag that to be matched.
        """
        if tag_key is not None:
            pulumi.set(__self__, "tag_key", tag_key)
        if tag_value is not None:
            pulumi.set(__self__, "tag_value", tag_value)

    @property
    @pulumi.getter(name="tagKey")
    def tag_key(self) -> Optional[str]:
        """
        The key of ECS tag that to be matched.
        """
        return pulumi.get(self, "tag_key")

    @property
    @pulumi.getter(name="tagValue")
    def tag_value(self) -> Optional[str]:
        """
        The value of ECS tag that to be matched.
        """
        return pulumi.get(self, "tag_value")


@pulumi.output_type
class GetControlPoliciesPolicyResult(dict):
    def __init__(__self__, *,
                 acl_action: str,
                 acl_uuid: str,
                 application_id: str,
                 application_name: str,
                 description: str,
                 dest_port: str,
                 dest_port_group: str,
                 dest_port_group_ports: Sequence[str],
                 dest_port_type: str,
                 destination: str,
                 destination_group_cidrs: Sequence[str],
                 destination_group_type: str,
                 destination_type: str,
                 direction: str,
                 dns_result: str,
                 dns_result_time: str,
                 hit_times: str,
                 id: str,
                 order: int,
                 proto: str,
                 release: bool,
                 source: str,
                 source_group_cidrs: Sequence[str],
                 source_group_type: str,
                 source_type: str):
        """
        :param str acl_action: The action that Cloud Firewall performs on the traffic. Valid values: `accept`, `drop`, `log`.
        :param str acl_uuid: The unique ID of the access control policy.
        :param str application_name: The application type that the access control policy supports.If `direction` is `in`, the valid value is `ANY`. If `direction` is `out`, `ANY`, `HTTP`, `HTTPS`, `MQTT`, `Memcache`, `MongoDB`, `MySQL`, `RDP`, `Redis`, `SMTP`, `SMTPS`, `SSH`, `SSL`, `VNC`.
        :param str description: The description of the access control policy.
        :param str dest_port: The destination port defined in the access control policy.
        :param str dest_port_group: The destination port address book defined in the access control policy.
        :param str dest_port_type: The destination port type defined in the access control policy. Valid values: `group`, `port`.
        :param str destination: The destination address defined in the access control policy.
        :param str destination_type: The destination address type defined in the access control policy.Valid values: If `direction` is `in`, the valid values are `net`, `group`. If `direction` is `out`, the valid values are `net`, `group`, `domain`, `location`.
        :param str direction: The direction of traffic to which the access control policy applies. Valid values: `in`, `out`.
        :param str id: The ID of the Control Policy.
        :param str proto: The protocol type of traffic to which the access control policy applies. Valid values: If `direction` is `in`, the valid value is `ANY`. If `direction` is `out`, the valid values are `ANY`, `TCP`, `UDP`, `ICMP`.
        :param bool release: Specifies whether the access control policy is enabled. By default, an access control policy is enabled after it is created. Valid values: `true`, `false`.
        :param str source: The source address defined in the access control policy.
        :param str source_type: The type of the source address book defined in the access control policy. Valid values: If `direction` is to `in`, the valid values are `net`, `group`, `location`. If `direction` is `out`, the valid values are `net`, `group`.
        """
        pulumi.set(__self__, "acl_action", acl_action)
        pulumi.set(__self__, "acl_uuid", acl_uuid)
        pulumi.set(__self__, "application_id", application_id)
        pulumi.set(__self__, "application_name", application_name)
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "dest_port", dest_port)
        pulumi.set(__self__, "dest_port_group", dest_port_group)
        pulumi.set(__self__, "dest_port_group_ports", dest_port_group_ports)
        pulumi.set(__self__, "dest_port_type", dest_port_type)
        pulumi.set(__self__, "destination", destination)
        pulumi.set(__self__, "destination_group_cidrs", destination_group_cidrs)
        pulumi.set(__self__, "destination_group_type", destination_group_type)
        pulumi.set(__self__, "destination_type", destination_type)
        pulumi.set(__self__, "direction", direction)
        pulumi.set(__self__, "dns_result", dns_result)
        pulumi.set(__self__, "dns_result_time", dns_result_time)
        pulumi.set(__self__, "hit_times", hit_times)
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "order", order)
        pulumi.set(__self__, "proto", proto)
        pulumi.set(__self__, "release", release)
        pulumi.set(__self__, "source", source)
        pulumi.set(__self__, "source_group_cidrs", source_group_cidrs)
        pulumi.set(__self__, "source_group_type", source_group_type)
        pulumi.set(__self__, "source_type", source_type)

    @property
    @pulumi.getter(name="aclAction")
    def acl_action(self) -> str:
        """
        The action that Cloud Firewall performs on the traffic. Valid values: `accept`, `drop`, `log`.
        """
        return pulumi.get(self, "acl_action")

    @property
    @pulumi.getter(name="aclUuid")
    def acl_uuid(self) -> str:
        """
        The unique ID of the access control policy.
        """
        return pulumi.get(self, "acl_uuid")

    @property
    @pulumi.getter(name="applicationId")
    def application_id(self) -> str:
        return pulumi.get(self, "application_id")

    @property
    @pulumi.getter(name="applicationName")
    def application_name(self) -> str:
        """
        The application type that the access control policy supports.If `direction` is `in`, the valid value is `ANY`. If `direction` is `out`, `ANY`, `HTTP`, `HTTPS`, `MQTT`, `Memcache`, `MongoDB`, `MySQL`, `RDP`, `Redis`, `SMTP`, `SMTPS`, `SSH`, `SSL`, `VNC`.
        """
        return pulumi.get(self, "application_name")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        The description of the access control policy.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="destPort")
    def dest_port(self) -> str:
        """
        The destination port defined in the access control policy.
        """
        return pulumi.get(self, "dest_port")

    @property
    @pulumi.getter(name="destPortGroup")
    def dest_port_group(self) -> str:
        """
        The destination port address book defined in the access control policy.
        """
        return pulumi.get(self, "dest_port_group")

    @property
    @pulumi.getter(name="destPortGroupPorts")
    def dest_port_group_ports(self) -> Sequence[str]:
        return pulumi.get(self, "dest_port_group_ports")

    @property
    @pulumi.getter(name="destPortType")
    def dest_port_type(self) -> str:
        """
        The destination port type defined in the access control policy. Valid values: `group`, `port`.
        """
        return pulumi.get(self, "dest_port_type")

    @property
    @pulumi.getter
    def destination(self) -> str:
        """
        The destination address defined in the access control policy.
        """
        return pulumi.get(self, "destination")

    @property
    @pulumi.getter(name="destinationGroupCidrs")
    def destination_group_cidrs(self) -> Sequence[str]:
        return pulumi.get(self, "destination_group_cidrs")

    @property
    @pulumi.getter(name="destinationGroupType")
    def destination_group_type(self) -> str:
        return pulumi.get(self, "destination_group_type")

    @property
    @pulumi.getter(name="destinationType")
    def destination_type(self) -> str:
        """
        The destination address type defined in the access control policy.Valid values: If `direction` is `in`, the valid values are `net`, `group`. If `direction` is `out`, the valid values are `net`, `group`, `domain`, `location`.
        """
        return pulumi.get(self, "destination_type")

    @property
    @pulumi.getter
    def direction(self) -> str:
        """
        The direction of traffic to which the access control policy applies. Valid values: `in`, `out`.
        """
        return pulumi.get(self, "direction")

    @property
    @pulumi.getter(name="dnsResult")
    def dns_result(self) -> str:
        return pulumi.get(self, "dns_result")

    @property
    @pulumi.getter(name="dnsResultTime")
    def dns_result_time(self) -> str:
        return pulumi.get(self, "dns_result_time")

    @property
    @pulumi.getter(name="hitTimes")
    def hit_times(self) -> str:
        return pulumi.get(self, "hit_times")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The ID of the Control Policy.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def order(self) -> int:
        return pulumi.get(self, "order")

    @property
    @pulumi.getter
    def proto(self) -> str:
        """
        The protocol type of traffic to which the access control policy applies. Valid values: If `direction` is `in`, the valid value is `ANY`. If `direction` is `out`, the valid values are `ANY`, `TCP`, `UDP`, `ICMP`.
        """
        return pulumi.get(self, "proto")

    @property
    @pulumi.getter
    def release(self) -> bool:
        """
        Specifies whether the access control policy is enabled. By default, an access control policy is enabled after it is created. Valid values: `true`, `false`.
        """
        return pulumi.get(self, "release")

    @property
    @pulumi.getter
    def source(self) -> str:
        """
        The source address defined in the access control policy.
        """
        return pulumi.get(self, "source")

    @property
    @pulumi.getter(name="sourceGroupCidrs")
    def source_group_cidrs(self) -> Sequence[str]:
        return pulumi.get(self, "source_group_cidrs")

    @property
    @pulumi.getter(name="sourceGroupType")
    def source_group_type(self) -> str:
        return pulumi.get(self, "source_group_type")

    @property
    @pulumi.getter(name="sourceType")
    def source_type(self) -> str:
        """
        The type of the source address book defined in the access control policy. Valid values: If `direction` is to `in`, the valid values are `net`, `group`, `location`. If `direction` is `out`, the valid values are `net`, `group`.
        """
        return pulumi.get(self, "source_type")


@pulumi.output_type
class GetInstancesInstanceResult(dict):
    def __init__(__self__, *,
                 create_time: str,
                 end_time: str,
                 id: str,
                 instance_id: str,
                 payment_type: str,
                 renewal_duration_unit: str,
                 renewal_status: str,
                 status: str):
        """
        :param str create_time: The Creation time of the resource.
        :param str end_time: The end time of the resource..
        :param str id: The ID of the Instance.
        :param str instance_id: The first ID of the resource.
        :param str payment_type: The payment type of the resource. Valid values: `Subscription`.
        :param str renewal_duration_unit: Automatic renewal period unit. Valid values: `Month`,`Year`.
        :param str renewal_status: Automatic renewal status. Valid values: `AutoRenewal`,`ManualRenewal`. Default Value: `ManualRenewal`.
        :param str status: The Status of Instance.
        """
        pulumi.set(__self__, "create_time", create_time)
        pulumi.set(__self__, "end_time", end_time)
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "payment_type", payment_type)
        pulumi.set(__self__, "renewal_duration_unit", renewal_duration_unit)
        pulumi.set(__self__, "renewal_status", renewal_status)
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        The Creation time of the resource.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> str:
        """
        The end time of the resource..
        """
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The ID of the Instance.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> str:
        """
        The first ID of the resource.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="paymentType")
    def payment_type(self) -> str:
        """
        The payment type of the resource. Valid values: `Subscription`.
        """
        return pulumi.get(self, "payment_type")

    @property
    @pulumi.getter(name="renewalDurationUnit")
    def renewal_duration_unit(self) -> str:
        """
        Automatic renewal period unit. Valid values: `Month`,`Year`.
        """
        return pulumi.get(self, "renewal_duration_unit")

    @property
    @pulumi.getter(name="renewalStatus")
    def renewal_status(self) -> str:
        """
        Automatic renewal status. Valid values: `AutoRenewal`,`ManualRenewal`. Default Value: `ManualRenewal`.
        """
        return pulumi.get(self, "renewal_status")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        The Status of Instance.
        """
        return pulumi.get(self, "status")


