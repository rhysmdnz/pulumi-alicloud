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
    'GetAccessPointsPointResult',
    'GetAccessPointsPointAccessPointFeatureModelResult',
    'GetPhysicalConnectionsConnectionResult',
    'GetVirtualBorderRoutersFilterResult',
    'GetVirtualBorderRoutersRouterResult',
]

@pulumi.output_type
class GetAccessPointsPointResult(dict):
    def __init__(__self__, *,
                 access_point_feature_models: Sequence['outputs.GetAccessPointsPointAccessPointFeatureModelResult'],
                 access_point_id: str,
                 access_point_name: str,
                 attached_region_no: str,
                 description: str,
                 host_operator: str,
                 id: str,
                 location: str,
                 status: str,
                 type: str):
        """
        :param Sequence['GetAccessPointsPointAccessPointFeatureModelArgs'] access_point_feature_models: Query to the Access Point Feature Model.
        :param str access_point_id: The Access Point ID.
        :param str access_point_name: Access Point Name.
        :param str attached_region_no: The Access Point Is Located an ID.
        :param str description: The Access Point Description.
        :param str host_operator: The Access Point Belongs to the Operator.
        :param str id: The ID of the Access Point.
        :param str location: The Location of the Access Point.
        :param str status: The Physical Connection to Which the Access Point State.
        :param str type: The Physical Connection to Which the Network Type.
        """
        pulumi.set(__self__, "access_point_feature_models", access_point_feature_models)
        pulumi.set(__self__, "access_point_id", access_point_id)
        pulumi.set(__self__, "access_point_name", access_point_name)
        pulumi.set(__self__, "attached_region_no", attached_region_no)
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "host_operator", host_operator)
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "location", location)
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="accessPointFeatureModels")
    def access_point_feature_models(self) -> Sequence['outputs.GetAccessPointsPointAccessPointFeatureModelResult']:
        """
        Query to the Access Point Feature Model.
        """
        return pulumi.get(self, "access_point_feature_models")

    @property
    @pulumi.getter(name="accessPointId")
    def access_point_id(self) -> str:
        """
        The Access Point ID.
        """
        return pulumi.get(self, "access_point_id")

    @property
    @pulumi.getter(name="accessPointName")
    def access_point_name(self) -> str:
        """
        Access Point Name.
        """
        return pulumi.get(self, "access_point_name")

    @property
    @pulumi.getter(name="attachedRegionNo")
    def attached_region_no(self) -> str:
        """
        The Access Point Is Located an ID.
        """
        return pulumi.get(self, "attached_region_no")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        The Access Point Description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="hostOperator")
    def host_operator(self) -> str:
        """
        The Access Point Belongs to the Operator.
        """
        return pulumi.get(self, "host_operator")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The ID of the Access Point.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        The Location of the Access Point.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        The Physical Connection to Which the Access Point State.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The Physical Connection to Which the Network Type.
        """
        return pulumi.get(self, "type")


@pulumi.output_type
class GetAccessPointsPointAccessPointFeatureModelResult(dict):
    def __init__(__self__, *,
                 feature_key: str,
                 feature_value: str):
        """
        :param str feature_key: The Access Point Properties.
        :param str feature_value: The Access Point Characteristic Value.
        """
        pulumi.set(__self__, "feature_key", feature_key)
        pulumi.set(__self__, "feature_value", feature_value)

    @property
    @pulumi.getter(name="featureKey")
    def feature_key(self) -> str:
        """
        The Access Point Properties.
        """
        return pulumi.get(self, "feature_key")

    @property
    @pulumi.getter(name="featureValue")
    def feature_value(self) -> str:
        """
        The Access Point Characteristic Value.
        """
        return pulumi.get(self, "feature_value")


@pulumi.output_type
class GetPhysicalConnectionsConnectionResult(dict):
    def __init__(__self__, *,
                 access_point_id: str,
                 ad_location: str,
                 bandwidth: str,
                 business_status: str,
                 circuit_code: str,
                 create_time: str,
                 description: str,
                 enabled_time: str,
                 end_time: str,
                 has_reservation_data: str,
                 id: str,
                 line_operator: str,
                 loa_status: str,
                 payment_type: str,
                 peer_location: str,
                 physical_connection_id: str,
                 physical_connection_name: str,
                 port_number: str,
                 port_type: str,
                 redundant_physical_connection_id: str,
                 reservation_active_time: str,
                 reservation_internet_charge_type: str,
                 reservation_order_type: str,
                 spec: str,
                 status: str,
                 type: str):
        """
        :param str access_point_id: The Physical Leased Line Access Point ID.
        :param str ad_location: To Connect a Device Physical Location.
        :param str bandwidth: On the Bandwidth of the ECC Service and Physical Connection.
        :param str business_status: The Physical Connection to Which the Payment Status: Normal, financiallocked, securitylocked.
        :param str circuit_code: Operators for Physical Connection Circuit Provided Coding.
        :param str create_time: The Representative of the Creation Time Resources Attribute Field.
        :param str description: The Physical Connection to Which the Description.
        :param str enabled_time: The Physical Connection to Which the Activation Time.
        :param str end_time: The Expiration Time.
        :param str has_reservation_data: HasReservationData.
        :param str id: The ID of the Physical Connection.
        :param str line_operator: Provides Access to the Physical Line Operator Value CT: China Telecom, CU: China Unicom, CM: china Mobile, CO: Other Chinese, Equinix:Equinix, Other: Other Overseas.
        :param str loa_status: Loa State.
        :param str payment_type: on Behalf of the Pay-as-You-Type of Resource Attribute Field.
        :param str peer_location: and an on-Premises Data Center Location.
        :param str physical_connection_id: on Behalf of the Resource Level Id of the Resources Property Fields.
        :param str physical_connection_name: on Behalf of the Resource Name of the Resources-Attribute Field.
        :param str port_number: To Connect a Device Port: The Port Number of.
        :param str port_type: The Physical Leased Line Access Port Type Value 100Base-T: Fast Electrical Ports, 1000Base-T (the Default): gigabit Electrical Ports, 1000Base-LX: Gigabit Singlemode Optical Ports (10Km), 10GBase-T: Gigabit Electrical Port, 10GBase-LR: Gigabit Singlemode Optical Ports (10Km).
        :param str redundant_physical_connection_id: Redundant Physical Connection to Which the ID.
        :param str reservation_active_time: The Renewal of the Entry into Force of the Time.
        :param str reservation_internet_charge_type: Renewal Type.
        :param str reservation_order_type: Renewal Order Type.
        :param str spec: The Physical Connection to Which the Specifications.
        :param str status: Resources on Behalf of a State of the Resource Attribute Field.
        :param str type: Physical Private Line of Type. Default Value: VPC.
        """
        pulumi.set(__self__, "access_point_id", access_point_id)
        pulumi.set(__self__, "ad_location", ad_location)
        pulumi.set(__self__, "bandwidth", bandwidth)
        pulumi.set(__self__, "business_status", business_status)
        pulumi.set(__self__, "circuit_code", circuit_code)
        pulumi.set(__self__, "create_time", create_time)
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "enabled_time", enabled_time)
        pulumi.set(__self__, "end_time", end_time)
        pulumi.set(__self__, "has_reservation_data", has_reservation_data)
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "line_operator", line_operator)
        pulumi.set(__self__, "loa_status", loa_status)
        pulumi.set(__self__, "payment_type", payment_type)
        pulumi.set(__self__, "peer_location", peer_location)
        pulumi.set(__self__, "physical_connection_id", physical_connection_id)
        pulumi.set(__self__, "physical_connection_name", physical_connection_name)
        pulumi.set(__self__, "port_number", port_number)
        pulumi.set(__self__, "port_type", port_type)
        pulumi.set(__self__, "redundant_physical_connection_id", redundant_physical_connection_id)
        pulumi.set(__self__, "reservation_active_time", reservation_active_time)
        pulumi.set(__self__, "reservation_internet_charge_type", reservation_internet_charge_type)
        pulumi.set(__self__, "reservation_order_type", reservation_order_type)
        pulumi.set(__self__, "spec", spec)
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="accessPointId")
    def access_point_id(self) -> str:
        """
        The Physical Leased Line Access Point ID.
        """
        return pulumi.get(self, "access_point_id")

    @property
    @pulumi.getter(name="adLocation")
    def ad_location(self) -> str:
        """
        To Connect a Device Physical Location.
        """
        return pulumi.get(self, "ad_location")

    @property
    @pulumi.getter
    def bandwidth(self) -> str:
        """
        On the Bandwidth of the ECC Service and Physical Connection.
        """
        return pulumi.get(self, "bandwidth")

    @property
    @pulumi.getter(name="businessStatus")
    def business_status(self) -> str:
        """
        The Physical Connection to Which the Payment Status: Normal, financiallocked, securitylocked.
        """
        return pulumi.get(self, "business_status")

    @property
    @pulumi.getter(name="circuitCode")
    def circuit_code(self) -> str:
        """
        Operators for Physical Connection Circuit Provided Coding.
        """
        return pulumi.get(self, "circuit_code")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        The Representative of the Creation Time Resources Attribute Field.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        The Physical Connection to Which the Description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="enabledTime")
    def enabled_time(self) -> str:
        """
        The Physical Connection to Which the Activation Time.
        """
        return pulumi.get(self, "enabled_time")

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> str:
        """
        The Expiration Time.
        """
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter(name="hasReservationData")
    def has_reservation_data(self) -> str:
        """
        HasReservationData.
        """
        return pulumi.get(self, "has_reservation_data")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The ID of the Physical Connection.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="lineOperator")
    def line_operator(self) -> str:
        """
        Provides Access to the Physical Line Operator Value CT: China Telecom, CU: China Unicom, CM: china Mobile, CO: Other Chinese, Equinix:Equinix, Other: Other Overseas.
        """
        return pulumi.get(self, "line_operator")

    @property
    @pulumi.getter(name="loaStatus")
    def loa_status(self) -> str:
        """
        Loa State.
        """
        return pulumi.get(self, "loa_status")

    @property
    @pulumi.getter(name="paymentType")
    def payment_type(self) -> str:
        """
        on Behalf of the Pay-as-You-Type of Resource Attribute Field.
        """
        return pulumi.get(self, "payment_type")

    @property
    @pulumi.getter(name="peerLocation")
    def peer_location(self) -> str:
        """
        and an on-Premises Data Center Location.
        """
        return pulumi.get(self, "peer_location")

    @property
    @pulumi.getter(name="physicalConnectionId")
    def physical_connection_id(self) -> str:
        """
        on Behalf of the Resource Level Id of the Resources Property Fields.
        """
        return pulumi.get(self, "physical_connection_id")

    @property
    @pulumi.getter(name="physicalConnectionName")
    def physical_connection_name(self) -> str:
        """
        on Behalf of the Resource Name of the Resources-Attribute Field.
        """
        return pulumi.get(self, "physical_connection_name")

    @property
    @pulumi.getter(name="portNumber")
    def port_number(self) -> str:
        """
        To Connect a Device Port: The Port Number of.
        """
        return pulumi.get(self, "port_number")

    @property
    @pulumi.getter(name="portType")
    def port_type(self) -> str:
        """
        The Physical Leased Line Access Port Type Value 100Base-T: Fast Electrical Ports, 1000Base-T (the Default): gigabit Electrical Ports, 1000Base-LX: Gigabit Singlemode Optical Ports (10Km), 10GBase-T: Gigabit Electrical Port, 10GBase-LR: Gigabit Singlemode Optical Ports (10Km).
        """
        return pulumi.get(self, "port_type")

    @property
    @pulumi.getter(name="redundantPhysicalConnectionId")
    def redundant_physical_connection_id(self) -> str:
        """
        Redundant Physical Connection to Which the ID.
        """
        return pulumi.get(self, "redundant_physical_connection_id")

    @property
    @pulumi.getter(name="reservationActiveTime")
    def reservation_active_time(self) -> str:
        """
        The Renewal of the Entry into Force of the Time.
        """
        return pulumi.get(self, "reservation_active_time")

    @property
    @pulumi.getter(name="reservationInternetChargeType")
    def reservation_internet_charge_type(self) -> str:
        """
        Renewal Type.
        """
        return pulumi.get(self, "reservation_internet_charge_type")

    @property
    @pulumi.getter(name="reservationOrderType")
    def reservation_order_type(self) -> str:
        """
        Renewal Order Type.
        """
        return pulumi.get(self, "reservation_order_type")

    @property
    @pulumi.getter
    def spec(self) -> str:
        """
        The Physical Connection to Which the Specifications.
        """
        return pulumi.get(self, "spec")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Resources on Behalf of a State of the Resource Attribute Field.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Physical Private Line of Type. Default Value: VPC.
        """
        return pulumi.get(self, "type")


@pulumi.output_type
class GetVirtualBorderRoutersFilterResult(dict):
    def __init__(__self__, *,
                 key: Optional[str] = None,
                 values: Optional[Sequence[str]] = None):
        """
        :param str key: The key of the field to filter by, as defined by
               [Alibaba Cloud API](https://www.alibabacloud.com/help/en/doc-detail/124791.htm).
        :param Sequence[str] values: Set of values that are accepted for the given field.
        """
        if key is not None:
            pulumi.set(__self__, "key", key)
        if values is not None:
            pulumi.set(__self__, "values", values)

    @property
    @pulumi.getter
    def key(self) -> Optional[str]:
        """
        The key of the field to filter by, as defined by
        [Alibaba Cloud API](https://www.alibabacloud.com/help/en/doc-detail/124791.htm).
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def values(self) -> Optional[Sequence[str]]:
        """
        Set of values that are accepted for the given field.
        """
        return pulumi.get(self, "values")


@pulumi.output_type
class GetVirtualBorderRoutersRouterResult(dict):
    def __init__(__self__, *,
                 access_point_id: str,
                 activation_time: str,
                 circuit_code: str,
                 cloud_box_instance_id: str,
                 create_time: str,
                 description: str,
                 detect_multiplier: int,
                 ecc_id: str,
                 enable_ipv6: bool,
                 id: str,
                 local_gateway_ip: str,
                 local_ipv6_gateway_ip: str,
                 min_rx_interval: int,
                 min_tx_interval: int,
                 payment_vbr_expire_time: str,
                 peer_gateway_ip: str,
                 peer_ipv6_gateway_ip: str,
                 peering_ipv6_subnet_mask: str,
                 peering_subnet_mask: str,
                 physical_connection_business_status: str,
                 physical_connection_id: str,
                 physical_connection_owner_uid: str,
                 physical_connection_status: str,
                 recovery_time: str,
                 route_table_id: str,
                 status: str,
                 termination_time: str,
                 type: str,
                 virtual_border_router_id: str,
                 virtual_border_router_name: str,
                 vlan_id: int,
                 vlan_interface_id: str):
        """
        :param str access_point_id: The physical leased line access point ID.
        :param str activation_time: The first activation time of VBR.
        :param str circuit_code: Operators for physical connection circuit provided coding.
        :param str cloud_box_instance_id: Box Instance Id.
        :param str create_time: The representative of the creation time resources attribute field.
        :param str description: The description of VBR. Length is from 2 to 256 characters, must start with a letter or the Chinese at the beginning, but not at the http:// Or https:// at the beginning.
        :param int detect_multiplier: Detection time multiplier that recipient allows the sender to send a message of the maximum allowable connections for the number of packets, used to detect whether the link normal. Value: 3~10.
        :param str ecc_id: High Speed Migration Service Instance Id.
        :param bool enable_ipv6: Whether to Enable IPv6.
        :param str id: The ID of the Virtual Border Router.
        :param str local_gateway_ip: Alibaba Cloud-Connected IPv4 address.
        :param str local_ipv6_gateway_ip: Alibaba Cloud-Connected IPv6 Address.
        :param int min_rx_interval: Configure BFD packet reception interval of values include: 200~1000, unit: ms.
        :param int min_tx_interval: Configure BFD packet transmission interval maximum value: 200~1000, unit: ms.
        :param str payment_vbr_expire_time: The Billing of the Extended Time.
        :param str peer_gateway_ip: The Client-Side Interconnection IPv4 Address.
        :param str peer_ipv6_gateway_ip: The Client-Side Interconnection IPv6 Address.
        :param str peering_ipv6_subnet_mask: Alibaba Cloud-Connected IPv6 with Client-Side Interconnection IPv6 of Subnet Mask.
        :param str peering_subnet_mask: Alibaba Cloud-Connected IPv4 and Client-Side Interconnection IPv4 of Subnet Mask.
        :param str physical_connection_business_status: Physical Private Line Service Status Value Normal: Normal, financiallocked: If You Lock.
        :param str physical_connection_id: The ID of the Physical Connection to Which the ID.
        :param str physical_connection_owner_uid: Physical Private Line Where the Account ID.
        :param str physical_connection_status: Physical Private Line State.
        :param str recovery_time: The Last from a Terminated State to the Active State of the Time.
        :param str route_table_id: Route Table ID.
        :param str status: The VBR state.
        :param str termination_time: The Most Recent Was Aborted by the Time.
        :param str type: VBR Type.
        :param str virtual_border_router_id: The VBR ID.
        :param str virtual_border_router_name: The name of VBR. Length is from 2 to 128 characters, must start with a letter or the Chinese at the beginning can contain numbers, the underscore character (_) and dash (-). But do not start with http:// or https:// at the beginning.
        :param int vlan_id: The VLAN ID of the VBR. Value range: 0~2999.
        :param str vlan_interface_id: The ID of the Router Interface.
        """
        pulumi.set(__self__, "access_point_id", access_point_id)
        pulumi.set(__self__, "activation_time", activation_time)
        pulumi.set(__self__, "circuit_code", circuit_code)
        pulumi.set(__self__, "cloud_box_instance_id", cloud_box_instance_id)
        pulumi.set(__self__, "create_time", create_time)
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "detect_multiplier", detect_multiplier)
        pulumi.set(__self__, "ecc_id", ecc_id)
        pulumi.set(__self__, "enable_ipv6", enable_ipv6)
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "local_gateway_ip", local_gateway_ip)
        pulumi.set(__self__, "local_ipv6_gateway_ip", local_ipv6_gateway_ip)
        pulumi.set(__self__, "min_rx_interval", min_rx_interval)
        pulumi.set(__self__, "min_tx_interval", min_tx_interval)
        pulumi.set(__self__, "payment_vbr_expire_time", payment_vbr_expire_time)
        pulumi.set(__self__, "peer_gateway_ip", peer_gateway_ip)
        pulumi.set(__self__, "peer_ipv6_gateway_ip", peer_ipv6_gateway_ip)
        pulumi.set(__self__, "peering_ipv6_subnet_mask", peering_ipv6_subnet_mask)
        pulumi.set(__self__, "peering_subnet_mask", peering_subnet_mask)
        pulumi.set(__self__, "physical_connection_business_status", physical_connection_business_status)
        pulumi.set(__self__, "physical_connection_id", physical_connection_id)
        pulumi.set(__self__, "physical_connection_owner_uid", physical_connection_owner_uid)
        pulumi.set(__self__, "physical_connection_status", physical_connection_status)
        pulumi.set(__self__, "recovery_time", recovery_time)
        pulumi.set(__self__, "route_table_id", route_table_id)
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "termination_time", termination_time)
        pulumi.set(__self__, "type", type)
        pulumi.set(__self__, "virtual_border_router_id", virtual_border_router_id)
        pulumi.set(__self__, "virtual_border_router_name", virtual_border_router_name)
        pulumi.set(__self__, "vlan_id", vlan_id)
        pulumi.set(__self__, "vlan_interface_id", vlan_interface_id)

    @property
    @pulumi.getter(name="accessPointId")
    def access_point_id(self) -> str:
        """
        The physical leased line access point ID.
        """
        return pulumi.get(self, "access_point_id")

    @property
    @pulumi.getter(name="activationTime")
    def activation_time(self) -> str:
        """
        The first activation time of VBR.
        """
        return pulumi.get(self, "activation_time")

    @property
    @pulumi.getter(name="circuitCode")
    def circuit_code(self) -> str:
        """
        Operators for physical connection circuit provided coding.
        """
        return pulumi.get(self, "circuit_code")

    @property
    @pulumi.getter(name="cloudBoxInstanceId")
    def cloud_box_instance_id(self) -> str:
        """
        Box Instance Id.
        """
        return pulumi.get(self, "cloud_box_instance_id")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        The representative of the creation time resources attribute field.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        The description of VBR. Length is from 2 to 256 characters, must start with a letter or the Chinese at the beginning, but not at the http:// Or https:// at the beginning.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="detectMultiplier")
    def detect_multiplier(self) -> int:
        """
        Detection time multiplier that recipient allows the sender to send a message of the maximum allowable connections for the number of packets, used to detect whether the link normal. Value: 3~10.
        """
        return pulumi.get(self, "detect_multiplier")

    @property
    @pulumi.getter(name="eccId")
    def ecc_id(self) -> str:
        """
        High Speed Migration Service Instance Id.
        """
        return pulumi.get(self, "ecc_id")

    @property
    @pulumi.getter(name="enableIpv6")
    def enable_ipv6(self) -> bool:
        """
        Whether to Enable IPv6.
        """
        return pulumi.get(self, "enable_ipv6")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The ID of the Virtual Border Router.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="localGatewayIp")
    def local_gateway_ip(self) -> str:
        """
        Alibaba Cloud-Connected IPv4 address.
        """
        return pulumi.get(self, "local_gateway_ip")

    @property
    @pulumi.getter(name="localIpv6GatewayIp")
    def local_ipv6_gateway_ip(self) -> str:
        """
        Alibaba Cloud-Connected IPv6 Address.
        """
        return pulumi.get(self, "local_ipv6_gateway_ip")

    @property
    @pulumi.getter(name="minRxInterval")
    def min_rx_interval(self) -> int:
        """
        Configure BFD packet reception interval of values include: 200~1000, unit: ms.
        """
        return pulumi.get(self, "min_rx_interval")

    @property
    @pulumi.getter(name="minTxInterval")
    def min_tx_interval(self) -> int:
        """
        Configure BFD packet transmission interval maximum value: 200~1000, unit: ms.
        """
        return pulumi.get(self, "min_tx_interval")

    @property
    @pulumi.getter(name="paymentVbrExpireTime")
    def payment_vbr_expire_time(self) -> str:
        """
        The Billing of the Extended Time.
        """
        return pulumi.get(self, "payment_vbr_expire_time")

    @property
    @pulumi.getter(name="peerGatewayIp")
    def peer_gateway_ip(self) -> str:
        """
        The Client-Side Interconnection IPv4 Address.
        """
        return pulumi.get(self, "peer_gateway_ip")

    @property
    @pulumi.getter(name="peerIpv6GatewayIp")
    def peer_ipv6_gateway_ip(self) -> str:
        """
        The Client-Side Interconnection IPv6 Address.
        """
        return pulumi.get(self, "peer_ipv6_gateway_ip")

    @property
    @pulumi.getter(name="peeringIpv6SubnetMask")
    def peering_ipv6_subnet_mask(self) -> str:
        """
        Alibaba Cloud-Connected IPv6 with Client-Side Interconnection IPv6 of Subnet Mask.
        """
        return pulumi.get(self, "peering_ipv6_subnet_mask")

    @property
    @pulumi.getter(name="peeringSubnetMask")
    def peering_subnet_mask(self) -> str:
        """
        Alibaba Cloud-Connected IPv4 and Client-Side Interconnection IPv4 of Subnet Mask.
        """
        return pulumi.get(self, "peering_subnet_mask")

    @property
    @pulumi.getter(name="physicalConnectionBusinessStatus")
    def physical_connection_business_status(self) -> str:
        """
        Physical Private Line Service Status Value Normal: Normal, financiallocked: If You Lock.
        """
        return pulumi.get(self, "physical_connection_business_status")

    @property
    @pulumi.getter(name="physicalConnectionId")
    def physical_connection_id(self) -> str:
        """
        The ID of the Physical Connection to Which the ID.
        """
        return pulumi.get(self, "physical_connection_id")

    @property
    @pulumi.getter(name="physicalConnectionOwnerUid")
    def physical_connection_owner_uid(self) -> str:
        """
        Physical Private Line Where the Account ID.
        """
        return pulumi.get(self, "physical_connection_owner_uid")

    @property
    @pulumi.getter(name="physicalConnectionStatus")
    def physical_connection_status(self) -> str:
        """
        Physical Private Line State.
        """
        return pulumi.get(self, "physical_connection_status")

    @property
    @pulumi.getter(name="recoveryTime")
    def recovery_time(self) -> str:
        """
        The Last from a Terminated State to the Active State of the Time.
        """
        return pulumi.get(self, "recovery_time")

    @property
    @pulumi.getter(name="routeTableId")
    def route_table_id(self) -> str:
        """
        Route Table ID.
        """
        return pulumi.get(self, "route_table_id")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        The VBR state.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="terminationTime")
    def termination_time(self) -> str:
        """
        The Most Recent Was Aborted by the Time.
        """
        return pulumi.get(self, "termination_time")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        VBR Type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="virtualBorderRouterId")
    def virtual_border_router_id(self) -> str:
        """
        The VBR ID.
        """
        return pulumi.get(self, "virtual_border_router_id")

    @property
    @pulumi.getter(name="virtualBorderRouterName")
    def virtual_border_router_name(self) -> str:
        """
        The name of VBR. Length is from 2 to 128 characters, must start with a letter or the Chinese at the beginning can contain numbers, the underscore character (_) and dash (-). But do not start with http:// or https:// at the beginning.
        """
        return pulumi.get(self, "virtual_border_router_name")

    @property
    @pulumi.getter(name="vlanId")
    def vlan_id(self) -> int:
        """
        The VLAN ID of the VBR. Value range: 0~2999.
        """
        return pulumi.get(self, "vlan_id")

    @property
    @pulumi.getter(name="vlanInterfaceId")
    def vlan_interface_id(self) -> str:
        """
        The ID of the Router Interface.
        """
        return pulumi.get(self, "vlan_interface_id")


