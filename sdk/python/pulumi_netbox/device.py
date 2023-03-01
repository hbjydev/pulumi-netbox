# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['DeviceArgs', 'Device']

@pulumi.input_type
class DeviceArgs:
    def __init__(__self__, *,
                 device_type_id: pulumi.Input[int],
                 comments: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 role_id: Optional[pulumi.Input[int]] = None,
                 serial: Optional[pulumi.Input[str]] = None,
                 site_id: Optional[pulumi.Input[int]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tenant_id: Optional[pulumi.Input[int]] = None):
        """
        The set of arguments for constructing a Device resource.
        """
        pulumi.set(__self__, "device_type_id", device_type_id)
        if comments is not None:
            pulumi.set(__self__, "comments", comments)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if role_id is not None:
            pulumi.set(__self__, "role_id", role_id)
        if serial is not None:
            pulumi.set(__self__, "serial", serial)
        if site_id is not None:
            pulumi.set(__self__, "site_id", site_id)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if tenant_id is not None:
            pulumi.set(__self__, "tenant_id", tenant_id)

    @property
    @pulumi.getter(name="deviceTypeId")
    def device_type_id(self) -> pulumi.Input[int]:
        return pulumi.get(self, "device_type_id")

    @device_type_id.setter
    def device_type_id(self, value: pulumi.Input[int]):
        pulumi.set(self, "device_type_id", value)

    @property
    @pulumi.getter
    def comments(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "comments")

    @comments.setter
    def comments(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "comments", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "role_id")

    @role_id.setter
    def role_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "role_id", value)

    @property
    @pulumi.getter
    def serial(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "serial")

    @serial.setter
    def serial(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "serial", value)

    @property
    @pulumi.getter(name="siteId")
    def site_id(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "site_id")

    @site_id.setter
    def site_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "site_id", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "tenant_id")

    @tenant_id.setter
    def tenant_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "tenant_id", value)


@pulumi.input_type
class _DeviceState:
    def __init__(__self__, *,
                 comments: Optional[pulumi.Input[str]] = None,
                 device_type_id: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 primary_ipv4: Optional[pulumi.Input[int]] = None,
                 role_id: Optional[pulumi.Input[int]] = None,
                 serial: Optional[pulumi.Input[str]] = None,
                 site_id: Optional[pulumi.Input[int]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tenant_id: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering Device resources.
        """
        if comments is not None:
            pulumi.set(__self__, "comments", comments)
        if device_type_id is not None:
            pulumi.set(__self__, "device_type_id", device_type_id)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if primary_ipv4 is not None:
            pulumi.set(__self__, "primary_ipv4", primary_ipv4)
        if role_id is not None:
            pulumi.set(__self__, "role_id", role_id)
        if serial is not None:
            pulumi.set(__self__, "serial", serial)
        if site_id is not None:
            pulumi.set(__self__, "site_id", site_id)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if tenant_id is not None:
            pulumi.set(__self__, "tenant_id", tenant_id)

    @property
    @pulumi.getter
    def comments(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "comments")

    @comments.setter
    def comments(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "comments", value)

    @property
    @pulumi.getter(name="deviceTypeId")
    def device_type_id(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "device_type_id")

    @device_type_id.setter
    def device_type_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "device_type_id", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="primaryIpv4")
    def primary_ipv4(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "primary_ipv4")

    @primary_ipv4.setter
    def primary_ipv4(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "primary_ipv4", value)

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "role_id")

    @role_id.setter
    def role_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "role_id", value)

    @property
    @pulumi.getter
    def serial(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "serial")

    @serial.setter
    def serial(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "serial", value)

    @property
    @pulumi.getter(name="siteId")
    def site_id(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "site_id")

    @site_id.setter
    def site_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "site_id", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "tenant_id")

    @tenant_id.setter
    def tenant_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "tenant_id", value)


class Device(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 comments: Optional[pulumi.Input[str]] = None,
                 device_type_id: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 role_id: Optional[pulumi.Input[int]] = None,
                 serial: Optional[pulumi.Input[str]] = None,
                 site_id: Optional[pulumi.Input[int]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tenant_id: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/devices/#devices):

        > Every piece of hardware which is installed within a site or rack exists in NetBox as a device. Devices are measured in rack units (U) and can be half depth or full depth. A device may have a height of 0U: These devices do not consume vertical rack space and cannot be assigned to a particular rack unit. A common example of a 0U device is a vertically-mounted PDU.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DeviceArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/devices/#devices):

        > Every piece of hardware which is installed within a site or rack exists in NetBox as a device. Devices are measured in rack units (U) and can be half depth or full depth. A device may have a height of 0U: These devices do not consume vertical rack space and cannot be assigned to a particular rack unit. A common example of a 0U device is a vertically-mounted PDU.

        :param str resource_name: The name of the resource.
        :param DeviceArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DeviceArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 comments: Optional[pulumi.Input[str]] = None,
                 device_type_id: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 role_id: Optional[pulumi.Input[int]] = None,
                 serial: Optional[pulumi.Input[str]] = None,
                 site_id: Optional[pulumi.Input[int]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tenant_id: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DeviceArgs.__new__(DeviceArgs)

            __props__.__dict__["comments"] = comments
            if device_type_id is None and not opts.urn:
                raise TypeError("Missing required property 'device_type_id'")
            __props__.__dict__["device_type_id"] = device_type_id
            __props__.__dict__["name"] = name
            __props__.__dict__["role_id"] = role_id
            __props__.__dict__["serial"] = serial
            __props__.__dict__["site_id"] = site_id
            __props__.__dict__["tags"] = tags
            __props__.__dict__["tenant_id"] = tenant_id
            __props__.__dict__["primary_ipv4"] = None
        super(Device, __self__).__init__(
            'netbox:index/device:Device',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            comments: Optional[pulumi.Input[str]] = None,
            device_type_id: Optional[pulumi.Input[int]] = None,
            name: Optional[pulumi.Input[str]] = None,
            primary_ipv4: Optional[pulumi.Input[int]] = None,
            role_id: Optional[pulumi.Input[int]] = None,
            serial: Optional[pulumi.Input[str]] = None,
            site_id: Optional[pulumi.Input[int]] = None,
            tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            tenant_id: Optional[pulumi.Input[int]] = None) -> 'Device':
        """
        Get an existing Device resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DeviceState.__new__(_DeviceState)

        __props__.__dict__["comments"] = comments
        __props__.__dict__["device_type_id"] = device_type_id
        __props__.__dict__["name"] = name
        __props__.__dict__["primary_ipv4"] = primary_ipv4
        __props__.__dict__["role_id"] = role_id
        __props__.__dict__["serial"] = serial
        __props__.__dict__["site_id"] = site_id
        __props__.__dict__["tags"] = tags
        __props__.__dict__["tenant_id"] = tenant_id
        return Device(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def comments(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "comments")

    @property
    @pulumi.getter(name="deviceTypeId")
    def device_type_id(self) -> pulumi.Output[int]:
        return pulumi.get(self, "device_type_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="primaryIpv4")
    def primary_ipv4(self) -> pulumi.Output[int]:
        return pulumi.get(self, "primary_ipv4")

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "role_id")

    @property
    @pulumi.getter
    def serial(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "serial")

    @property
    @pulumi.getter(name="siteId")
    def site_id(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "site_id")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "tenant_id")
