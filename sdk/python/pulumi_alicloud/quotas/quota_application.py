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

__all__ = ['QuotaApplicationArgs', 'QuotaApplication']

@pulumi.input_type
class QuotaApplicationArgs:
    def __init__(__self__, *,
                 desire_value: pulumi.Input[float],
                 product_code: pulumi.Input[str],
                 quota_action_code: pulumi.Input[str],
                 reason: pulumi.Input[str],
                 audit_mode: Optional[pulumi.Input[str]] = None,
                 dimensions: Optional[pulumi.Input[Sequence[pulumi.Input['QuotaApplicationDimensionArgs']]]] = None,
                 notice_type: Optional[pulumi.Input[int]] = None,
                 quota_category: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a QuotaApplication resource.
        :param pulumi.Input[float] desire_value: The desire value of the quota application.
        :param pulumi.Input[str] product_code: The product code.
        :param pulumi.Input[str] quota_action_code: The ID of quota action.
        :param pulumi.Input[str] reason: The reason of the quota application.
        :param pulumi.Input[str] audit_mode: The audit mode. Valid values: `Async`, `Sync`. Default to: `Async`.
        :param pulumi.Input[Sequence[pulumi.Input['QuotaApplicationDimensionArgs']]] dimensions: The quota dimensions.
        :param pulumi.Input[int] notice_type: The notice type. Valid values: `0`, `1`, `2`, `3`.
        :param pulumi.Input[str] quota_category: The quota category. Valid values: `CommonQuota`, `FlowControl`.
        """
        pulumi.set(__self__, "desire_value", desire_value)
        pulumi.set(__self__, "product_code", product_code)
        pulumi.set(__self__, "quota_action_code", quota_action_code)
        pulumi.set(__self__, "reason", reason)
        if audit_mode is not None:
            pulumi.set(__self__, "audit_mode", audit_mode)
        if dimensions is not None:
            pulumi.set(__self__, "dimensions", dimensions)
        if notice_type is not None:
            pulumi.set(__self__, "notice_type", notice_type)
        if quota_category is not None:
            pulumi.set(__self__, "quota_category", quota_category)

    @property
    @pulumi.getter(name="desireValue")
    def desire_value(self) -> pulumi.Input[float]:
        """
        The desire value of the quota application.
        """
        return pulumi.get(self, "desire_value")

    @desire_value.setter
    def desire_value(self, value: pulumi.Input[float]):
        pulumi.set(self, "desire_value", value)

    @property
    @pulumi.getter(name="productCode")
    def product_code(self) -> pulumi.Input[str]:
        """
        The product code.
        """
        return pulumi.get(self, "product_code")

    @product_code.setter
    def product_code(self, value: pulumi.Input[str]):
        pulumi.set(self, "product_code", value)

    @property
    @pulumi.getter(name="quotaActionCode")
    def quota_action_code(self) -> pulumi.Input[str]:
        """
        The ID of quota action.
        """
        return pulumi.get(self, "quota_action_code")

    @quota_action_code.setter
    def quota_action_code(self, value: pulumi.Input[str]):
        pulumi.set(self, "quota_action_code", value)

    @property
    @pulumi.getter
    def reason(self) -> pulumi.Input[str]:
        """
        The reason of the quota application.
        """
        return pulumi.get(self, "reason")

    @reason.setter
    def reason(self, value: pulumi.Input[str]):
        pulumi.set(self, "reason", value)

    @property
    @pulumi.getter(name="auditMode")
    def audit_mode(self) -> Optional[pulumi.Input[str]]:
        """
        The audit mode. Valid values: `Async`, `Sync`. Default to: `Async`.
        """
        return pulumi.get(self, "audit_mode")

    @audit_mode.setter
    def audit_mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "audit_mode", value)

    @property
    @pulumi.getter
    def dimensions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['QuotaApplicationDimensionArgs']]]]:
        """
        The quota dimensions.
        """
        return pulumi.get(self, "dimensions")

    @dimensions.setter
    def dimensions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['QuotaApplicationDimensionArgs']]]]):
        pulumi.set(self, "dimensions", value)

    @property
    @pulumi.getter(name="noticeType")
    def notice_type(self) -> Optional[pulumi.Input[int]]:
        """
        The notice type. Valid values: `0`, `1`, `2`, `3`.
        """
        return pulumi.get(self, "notice_type")

    @notice_type.setter
    def notice_type(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "notice_type", value)

    @property
    @pulumi.getter(name="quotaCategory")
    def quota_category(self) -> Optional[pulumi.Input[str]]:
        """
        The quota category. Valid values: `CommonQuota`, `FlowControl`.
        """
        return pulumi.get(self, "quota_category")

    @quota_category.setter
    def quota_category(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "quota_category", value)


@pulumi.input_type
class _QuotaApplicationState:
    def __init__(__self__, *,
                 approve_value: Optional[pulumi.Input[str]] = None,
                 audit_mode: Optional[pulumi.Input[str]] = None,
                 audit_reason: Optional[pulumi.Input[str]] = None,
                 desire_value: Optional[pulumi.Input[float]] = None,
                 dimensions: Optional[pulumi.Input[Sequence[pulumi.Input['QuotaApplicationDimensionArgs']]]] = None,
                 effective_time: Optional[pulumi.Input[str]] = None,
                 expire_time: Optional[pulumi.Input[str]] = None,
                 notice_type: Optional[pulumi.Input[int]] = None,
                 product_code: Optional[pulumi.Input[str]] = None,
                 quota_action_code: Optional[pulumi.Input[str]] = None,
                 quota_category: Optional[pulumi.Input[str]] = None,
                 quota_description: Optional[pulumi.Input[str]] = None,
                 quota_name: Optional[pulumi.Input[str]] = None,
                 quota_unit: Optional[pulumi.Input[str]] = None,
                 reason: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering QuotaApplication resources.
        :param pulumi.Input[str] approve_value: The approve value of the quota application.
        :param pulumi.Input[str] audit_mode: The audit mode. Valid values: `Async`, `Sync`. Default to: `Async`.
        :param pulumi.Input[str] audit_reason: The audit reason.
        :param pulumi.Input[float] desire_value: The desire value of the quota application.
        :param pulumi.Input[Sequence[pulumi.Input['QuotaApplicationDimensionArgs']]] dimensions: The quota dimensions.
        :param pulumi.Input[str] effective_time: The effective time of the quota application.
        :param pulumi.Input[str] expire_time: The expire time of the quota application.
        :param pulumi.Input[int] notice_type: The notice type. Valid values: `0`, `1`, `2`, `3`.
        :param pulumi.Input[str] product_code: The product code.
        :param pulumi.Input[str] quota_action_code: The ID of quota action.
        :param pulumi.Input[str] quota_category: The quota category. Valid values: `CommonQuota`, `FlowControl`.
        :param pulumi.Input[str] quota_description: The description of the quota application.
        :param pulumi.Input[str] quota_name: The name of the quota application.
        :param pulumi.Input[str] quota_unit: The unit of the quota application.
        :param pulumi.Input[str] reason: The reason of the quota application.
        :param pulumi.Input[str] status: The status of the quota application.
        """
        if approve_value is not None:
            pulumi.set(__self__, "approve_value", approve_value)
        if audit_mode is not None:
            pulumi.set(__self__, "audit_mode", audit_mode)
        if audit_reason is not None:
            pulumi.set(__self__, "audit_reason", audit_reason)
        if desire_value is not None:
            pulumi.set(__self__, "desire_value", desire_value)
        if dimensions is not None:
            pulumi.set(__self__, "dimensions", dimensions)
        if effective_time is not None:
            pulumi.set(__self__, "effective_time", effective_time)
        if expire_time is not None:
            pulumi.set(__self__, "expire_time", expire_time)
        if notice_type is not None:
            pulumi.set(__self__, "notice_type", notice_type)
        if product_code is not None:
            pulumi.set(__self__, "product_code", product_code)
        if quota_action_code is not None:
            pulumi.set(__self__, "quota_action_code", quota_action_code)
        if quota_category is not None:
            pulumi.set(__self__, "quota_category", quota_category)
        if quota_description is not None:
            pulumi.set(__self__, "quota_description", quota_description)
        if quota_name is not None:
            pulumi.set(__self__, "quota_name", quota_name)
        if quota_unit is not None:
            pulumi.set(__self__, "quota_unit", quota_unit)
        if reason is not None:
            pulumi.set(__self__, "reason", reason)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="approveValue")
    def approve_value(self) -> Optional[pulumi.Input[str]]:
        """
        The approve value of the quota application.
        """
        return pulumi.get(self, "approve_value")

    @approve_value.setter
    def approve_value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "approve_value", value)

    @property
    @pulumi.getter(name="auditMode")
    def audit_mode(self) -> Optional[pulumi.Input[str]]:
        """
        The audit mode. Valid values: `Async`, `Sync`. Default to: `Async`.
        """
        return pulumi.get(self, "audit_mode")

    @audit_mode.setter
    def audit_mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "audit_mode", value)

    @property
    @pulumi.getter(name="auditReason")
    def audit_reason(self) -> Optional[pulumi.Input[str]]:
        """
        The audit reason.
        """
        return pulumi.get(self, "audit_reason")

    @audit_reason.setter
    def audit_reason(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "audit_reason", value)

    @property
    @pulumi.getter(name="desireValue")
    def desire_value(self) -> Optional[pulumi.Input[float]]:
        """
        The desire value of the quota application.
        """
        return pulumi.get(self, "desire_value")

    @desire_value.setter
    def desire_value(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "desire_value", value)

    @property
    @pulumi.getter
    def dimensions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['QuotaApplicationDimensionArgs']]]]:
        """
        The quota dimensions.
        """
        return pulumi.get(self, "dimensions")

    @dimensions.setter
    def dimensions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['QuotaApplicationDimensionArgs']]]]):
        pulumi.set(self, "dimensions", value)

    @property
    @pulumi.getter(name="effectiveTime")
    def effective_time(self) -> Optional[pulumi.Input[str]]:
        """
        The effective time of the quota application.
        """
        return pulumi.get(self, "effective_time")

    @effective_time.setter
    def effective_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "effective_time", value)

    @property
    @pulumi.getter(name="expireTime")
    def expire_time(self) -> Optional[pulumi.Input[str]]:
        """
        The expire time of the quota application.
        """
        return pulumi.get(self, "expire_time")

    @expire_time.setter
    def expire_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "expire_time", value)

    @property
    @pulumi.getter(name="noticeType")
    def notice_type(self) -> Optional[pulumi.Input[int]]:
        """
        The notice type. Valid values: `0`, `1`, `2`, `3`.
        """
        return pulumi.get(self, "notice_type")

    @notice_type.setter
    def notice_type(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "notice_type", value)

    @property
    @pulumi.getter(name="productCode")
    def product_code(self) -> Optional[pulumi.Input[str]]:
        """
        The product code.
        """
        return pulumi.get(self, "product_code")

    @product_code.setter
    def product_code(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "product_code", value)

    @property
    @pulumi.getter(name="quotaActionCode")
    def quota_action_code(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of quota action.
        """
        return pulumi.get(self, "quota_action_code")

    @quota_action_code.setter
    def quota_action_code(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "quota_action_code", value)

    @property
    @pulumi.getter(name="quotaCategory")
    def quota_category(self) -> Optional[pulumi.Input[str]]:
        """
        The quota category. Valid values: `CommonQuota`, `FlowControl`.
        """
        return pulumi.get(self, "quota_category")

    @quota_category.setter
    def quota_category(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "quota_category", value)

    @property
    @pulumi.getter(name="quotaDescription")
    def quota_description(self) -> Optional[pulumi.Input[str]]:
        """
        The description of the quota application.
        """
        return pulumi.get(self, "quota_description")

    @quota_description.setter
    def quota_description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "quota_description", value)

    @property
    @pulumi.getter(name="quotaName")
    def quota_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the quota application.
        """
        return pulumi.get(self, "quota_name")

    @quota_name.setter
    def quota_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "quota_name", value)

    @property
    @pulumi.getter(name="quotaUnit")
    def quota_unit(self) -> Optional[pulumi.Input[str]]:
        """
        The unit of the quota application.
        """
        return pulumi.get(self, "quota_unit")

    @quota_unit.setter
    def quota_unit(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "quota_unit", value)

    @property
    @pulumi.getter
    def reason(self) -> Optional[pulumi.Input[str]]:
        """
        The reason of the quota application.
        """
        return pulumi.get(self, "reason")

    @reason.setter
    def reason(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "reason", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        The status of the quota application.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


class QuotaApplication(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 audit_mode: Optional[pulumi.Input[str]] = None,
                 desire_value: Optional[pulumi.Input[float]] = None,
                 dimensions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['QuotaApplicationDimensionArgs']]]]] = None,
                 notice_type: Optional[pulumi.Input[int]] = None,
                 product_code: Optional[pulumi.Input[str]] = None,
                 quota_action_code: Optional[pulumi.Input[str]] = None,
                 quota_category: Optional[pulumi.Input[str]] = None,
                 reason: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a Quotas Quota Application resource.

        For information about Quotas Quota Application and how to use it, see [What is Quota Application](https://help.aliyun.com/document_detail/171289.html).

        > **NOTE:** Available in v1.117.0+.

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        example = alicloud.quotas.QuotaApplication("example",
            desire_value=100,
            dimensions=[alicloud.quotas.QuotaApplicationDimensionArgs(
                key="regionId",
                value="cn-hangzhou",
            )],
            notice_type=0,
            product_code="ess",
            quota_action_code="q_db_instance",
            reason="For Terraform Test")
        ```

        ## Import

        Quotas Application Info can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:quotas/quotaApplication:QuotaApplication example <id>
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] audit_mode: The audit mode. Valid values: `Async`, `Sync`. Default to: `Async`.
        :param pulumi.Input[float] desire_value: The desire value of the quota application.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['QuotaApplicationDimensionArgs']]]] dimensions: The quota dimensions.
        :param pulumi.Input[int] notice_type: The notice type. Valid values: `0`, `1`, `2`, `3`.
        :param pulumi.Input[str] product_code: The product code.
        :param pulumi.Input[str] quota_action_code: The ID of quota action.
        :param pulumi.Input[str] quota_category: The quota category. Valid values: `CommonQuota`, `FlowControl`.
        :param pulumi.Input[str] reason: The reason of the quota application.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: QuotaApplicationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a Quotas Quota Application resource.

        For information about Quotas Quota Application and how to use it, see [What is Quota Application](https://help.aliyun.com/document_detail/171289.html).

        > **NOTE:** Available in v1.117.0+.

        ## Example Usage

        Basic Usage

        ```python
        import pulumi
        import pulumi_alicloud as alicloud

        example = alicloud.quotas.QuotaApplication("example",
            desire_value=100,
            dimensions=[alicloud.quotas.QuotaApplicationDimensionArgs(
                key="regionId",
                value="cn-hangzhou",
            )],
            notice_type=0,
            product_code="ess",
            quota_action_code="q_db_instance",
            reason="For Terraform Test")
        ```

        ## Import

        Quotas Application Info can be imported using the id, e.g.

        ```sh
         $ pulumi import alicloud:quotas/quotaApplication:QuotaApplication example <id>
        ```

        :param str resource_name: The name of the resource.
        :param QuotaApplicationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(QuotaApplicationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 audit_mode: Optional[pulumi.Input[str]] = None,
                 desire_value: Optional[pulumi.Input[float]] = None,
                 dimensions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['QuotaApplicationDimensionArgs']]]]] = None,
                 notice_type: Optional[pulumi.Input[int]] = None,
                 product_code: Optional[pulumi.Input[str]] = None,
                 quota_action_code: Optional[pulumi.Input[str]] = None,
                 quota_category: Optional[pulumi.Input[str]] = None,
                 reason: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = QuotaApplicationArgs.__new__(QuotaApplicationArgs)

            __props__.__dict__["audit_mode"] = audit_mode
            if desire_value is None and not opts.urn:
                raise TypeError("Missing required property 'desire_value'")
            __props__.__dict__["desire_value"] = desire_value
            __props__.__dict__["dimensions"] = dimensions
            __props__.__dict__["notice_type"] = notice_type
            if product_code is None and not opts.urn:
                raise TypeError("Missing required property 'product_code'")
            __props__.__dict__["product_code"] = product_code
            if quota_action_code is None and not opts.urn:
                raise TypeError("Missing required property 'quota_action_code'")
            __props__.__dict__["quota_action_code"] = quota_action_code
            __props__.__dict__["quota_category"] = quota_category
            if reason is None and not opts.urn:
                raise TypeError("Missing required property 'reason'")
            __props__.__dict__["reason"] = reason
            __props__.__dict__["approve_value"] = None
            __props__.__dict__["audit_reason"] = None
            __props__.__dict__["effective_time"] = None
            __props__.__dict__["expire_time"] = None
            __props__.__dict__["quota_description"] = None
            __props__.__dict__["quota_name"] = None
            __props__.__dict__["quota_unit"] = None
            __props__.__dict__["status"] = None
        super(QuotaApplication, __self__).__init__(
            'alicloud:quotas/quotaApplication:QuotaApplication',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            approve_value: Optional[pulumi.Input[str]] = None,
            audit_mode: Optional[pulumi.Input[str]] = None,
            audit_reason: Optional[pulumi.Input[str]] = None,
            desire_value: Optional[pulumi.Input[float]] = None,
            dimensions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['QuotaApplicationDimensionArgs']]]]] = None,
            effective_time: Optional[pulumi.Input[str]] = None,
            expire_time: Optional[pulumi.Input[str]] = None,
            notice_type: Optional[pulumi.Input[int]] = None,
            product_code: Optional[pulumi.Input[str]] = None,
            quota_action_code: Optional[pulumi.Input[str]] = None,
            quota_category: Optional[pulumi.Input[str]] = None,
            quota_description: Optional[pulumi.Input[str]] = None,
            quota_name: Optional[pulumi.Input[str]] = None,
            quota_unit: Optional[pulumi.Input[str]] = None,
            reason: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None) -> 'QuotaApplication':
        """
        Get an existing QuotaApplication resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] approve_value: The approve value of the quota application.
        :param pulumi.Input[str] audit_mode: The audit mode. Valid values: `Async`, `Sync`. Default to: `Async`.
        :param pulumi.Input[str] audit_reason: The audit reason.
        :param pulumi.Input[float] desire_value: The desire value of the quota application.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['QuotaApplicationDimensionArgs']]]] dimensions: The quota dimensions.
        :param pulumi.Input[str] effective_time: The effective time of the quota application.
        :param pulumi.Input[str] expire_time: The expire time of the quota application.
        :param pulumi.Input[int] notice_type: The notice type. Valid values: `0`, `1`, `2`, `3`.
        :param pulumi.Input[str] product_code: The product code.
        :param pulumi.Input[str] quota_action_code: The ID of quota action.
        :param pulumi.Input[str] quota_category: The quota category. Valid values: `CommonQuota`, `FlowControl`.
        :param pulumi.Input[str] quota_description: The description of the quota application.
        :param pulumi.Input[str] quota_name: The name of the quota application.
        :param pulumi.Input[str] quota_unit: The unit of the quota application.
        :param pulumi.Input[str] reason: The reason of the quota application.
        :param pulumi.Input[str] status: The status of the quota application.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _QuotaApplicationState.__new__(_QuotaApplicationState)

        __props__.__dict__["approve_value"] = approve_value
        __props__.__dict__["audit_mode"] = audit_mode
        __props__.__dict__["audit_reason"] = audit_reason
        __props__.__dict__["desire_value"] = desire_value
        __props__.__dict__["dimensions"] = dimensions
        __props__.__dict__["effective_time"] = effective_time
        __props__.__dict__["expire_time"] = expire_time
        __props__.__dict__["notice_type"] = notice_type
        __props__.__dict__["product_code"] = product_code
        __props__.__dict__["quota_action_code"] = quota_action_code
        __props__.__dict__["quota_category"] = quota_category
        __props__.__dict__["quota_description"] = quota_description
        __props__.__dict__["quota_name"] = quota_name
        __props__.__dict__["quota_unit"] = quota_unit
        __props__.__dict__["reason"] = reason
        __props__.__dict__["status"] = status
        return QuotaApplication(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="approveValue")
    def approve_value(self) -> pulumi.Output[str]:
        """
        The approve value of the quota application.
        """
        return pulumi.get(self, "approve_value")

    @property
    @pulumi.getter(name="auditMode")
    def audit_mode(self) -> pulumi.Output[Optional[str]]:
        """
        The audit mode. Valid values: `Async`, `Sync`. Default to: `Async`.
        """
        return pulumi.get(self, "audit_mode")

    @property
    @pulumi.getter(name="auditReason")
    def audit_reason(self) -> pulumi.Output[str]:
        """
        The audit reason.
        """
        return pulumi.get(self, "audit_reason")

    @property
    @pulumi.getter(name="desireValue")
    def desire_value(self) -> pulumi.Output[float]:
        """
        The desire value of the quota application.
        """
        return pulumi.get(self, "desire_value")

    @property
    @pulumi.getter
    def dimensions(self) -> pulumi.Output[Optional[Sequence['outputs.QuotaApplicationDimension']]]:
        """
        The quota dimensions.
        """
        return pulumi.get(self, "dimensions")

    @property
    @pulumi.getter(name="effectiveTime")
    def effective_time(self) -> pulumi.Output[str]:
        """
        The effective time of the quota application.
        """
        return pulumi.get(self, "effective_time")

    @property
    @pulumi.getter(name="expireTime")
    def expire_time(self) -> pulumi.Output[str]:
        """
        The expire time of the quota application.
        """
        return pulumi.get(self, "expire_time")

    @property
    @pulumi.getter(name="noticeType")
    def notice_type(self) -> pulumi.Output[Optional[int]]:
        """
        The notice type. Valid values: `0`, `1`, `2`, `3`.
        """
        return pulumi.get(self, "notice_type")

    @property
    @pulumi.getter(name="productCode")
    def product_code(self) -> pulumi.Output[str]:
        """
        The product code.
        """
        return pulumi.get(self, "product_code")

    @property
    @pulumi.getter(name="quotaActionCode")
    def quota_action_code(self) -> pulumi.Output[str]:
        """
        The ID of quota action.
        """
        return pulumi.get(self, "quota_action_code")

    @property
    @pulumi.getter(name="quotaCategory")
    def quota_category(self) -> pulumi.Output[Optional[str]]:
        """
        The quota category. Valid values: `CommonQuota`, `FlowControl`.
        """
        return pulumi.get(self, "quota_category")

    @property
    @pulumi.getter(name="quotaDescription")
    def quota_description(self) -> pulumi.Output[str]:
        """
        The description of the quota application.
        """
        return pulumi.get(self, "quota_description")

    @property
    @pulumi.getter(name="quotaName")
    def quota_name(self) -> pulumi.Output[str]:
        """
        The name of the quota application.
        """
        return pulumi.get(self, "quota_name")

    @property
    @pulumi.getter(name="quotaUnit")
    def quota_unit(self) -> pulumi.Output[str]:
        """
        The unit of the quota application.
        """
        return pulumi.get(self, "quota_unit")

    @property
    @pulumi.getter
    def reason(self) -> pulumi.Output[str]:
        """
        The reason of the quota application.
        """
        return pulumi.get(self, "reason")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        The status of the quota application.
        """
        return pulumi.get(self, "status")
