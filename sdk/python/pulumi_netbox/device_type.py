# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['DeviceTypeArgs', 'DeviceType']

@pulumi.input_type
class DeviceTypeArgs:
    def __init__(__self__, *,
                 model: pulumi.Input[str],
                 manufacturer_id: Optional[pulumi.Input[int]] = None,
                 part_number: Optional[pulumi.Input[str]] = None,
                 slug: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a DeviceType resource.
        """
        pulumi.set(__self__, "model", model)
        if manufacturer_id is not None:
            pulumi.set(__self__, "manufacturer_id", manufacturer_id)
        if part_number is not None:
            pulumi.set(__self__, "part_number", part_number)
        if slug is not None:
            pulumi.set(__self__, "slug", slug)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def model(self) -> pulumi.Input[str]:
        return pulumi.get(self, "model")

    @model.setter
    def model(self, value: pulumi.Input[str]):
        pulumi.set(self, "model", value)

    @property
    @pulumi.getter(name="manufacturerId")
    def manufacturer_id(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "manufacturer_id")

    @manufacturer_id.setter
    def manufacturer_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "manufacturer_id", value)

    @property
    @pulumi.getter(name="partNumber")
    def part_number(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "part_number")

    @part_number.setter
    def part_number(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "part_number", value)

    @property
    @pulumi.getter
    def slug(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "slug")

    @slug.setter
    def slug(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "slug", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)


@pulumi.input_type
class _DeviceTypeState:
    def __init__(__self__, *,
                 manufacturer_id: Optional[pulumi.Input[int]] = None,
                 model: Optional[pulumi.Input[str]] = None,
                 part_number: Optional[pulumi.Input[str]] = None,
                 slug: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        Input properties used for looking up and filtering DeviceType resources.
        """
        if manufacturer_id is not None:
            pulumi.set(__self__, "manufacturer_id", manufacturer_id)
        if model is not None:
            pulumi.set(__self__, "model", model)
        if part_number is not None:
            pulumi.set(__self__, "part_number", part_number)
        if slug is not None:
            pulumi.set(__self__, "slug", slug)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="manufacturerId")
    def manufacturer_id(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "manufacturer_id")

    @manufacturer_id.setter
    def manufacturer_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "manufacturer_id", value)

    @property
    @pulumi.getter
    def model(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "model")

    @model.setter
    def model(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "model", value)

    @property
    @pulumi.getter(name="partNumber")
    def part_number(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "part_number")

    @part_number.setter
    def part_number(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "part_number", value)

    @property
    @pulumi.getter
    def slug(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "slug")

    @slug.setter
    def slug(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "slug", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)


class DeviceType(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 manufacturer_id: Optional[pulumi.Input[int]] = None,
                 model: Optional[pulumi.Input[str]] = None,
                 part_number: Optional[pulumi.Input[str]] = None,
                 slug: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Create a DeviceType resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DeviceTypeArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a DeviceType resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param DeviceTypeArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DeviceTypeArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 manufacturer_id: Optional[pulumi.Input[int]] = None,
                 model: Optional[pulumi.Input[str]] = None,
                 part_number: Optional[pulumi.Input[str]] = None,
                 slug: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DeviceTypeArgs.__new__(DeviceTypeArgs)

            __props__.__dict__["manufacturer_id"] = manufacturer_id
            if model is None and not opts.urn:
                raise TypeError("Missing required property 'model'")
            __props__.__dict__["model"] = model
            __props__.__dict__["part_number"] = part_number
            __props__.__dict__["slug"] = slug
            __props__.__dict__["tags"] = tags
        super(DeviceType, __self__).__init__(
            'netbox:index/deviceType:DeviceType',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            manufacturer_id: Optional[pulumi.Input[int]] = None,
            model: Optional[pulumi.Input[str]] = None,
            part_number: Optional[pulumi.Input[str]] = None,
            slug: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None) -> 'DeviceType':
        """
        Get an existing DeviceType resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DeviceTypeState.__new__(_DeviceTypeState)

        __props__.__dict__["manufacturer_id"] = manufacturer_id
        __props__.__dict__["model"] = model
        __props__.__dict__["part_number"] = part_number
        __props__.__dict__["slug"] = slug
        __props__.__dict__["tags"] = tags
        return DeviceType(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="manufacturerId")
    def manufacturer_id(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "manufacturer_id")

    @property
    @pulumi.getter
    def model(self) -> pulumi.Output[str]:
        return pulumi.get(self, "model")

    @property
    @pulumi.getter(name="partNumber")
    def part_number(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "part_number")

    @property
    @pulumi.getter
    def slug(self) -> pulumi.Output[str]:
        return pulumi.get(self, "slug")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "tags")

