# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['IpAddressArgs', 'IpAddress']

@pulumi.input_type
class IpAddressArgs:
    def __init__(__self__, *,
                 ip_address: pulumi.Input[str],
                 status: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 dns_name: Optional[pulumi.Input[str]] = None,
                 interface_id: Optional[pulumi.Input[int]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tenant_id: Optional[pulumi.Input[int]] = None,
                 vrf_id: Optional[pulumi.Input[int]] = None):
        """
        The set of arguments for constructing a IpAddress resource.
        """
        pulumi.set(__self__, "ip_address", ip_address)
        pulumi.set(__self__, "status", status)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if dns_name is not None:
            pulumi.set(__self__, "dns_name", dns_name)
        if interface_id is not None:
            pulumi.set(__self__, "interface_id", interface_id)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if tenant_id is not None:
            pulumi.set(__self__, "tenant_id", tenant_id)
        if vrf_id is not None:
            pulumi.set(__self__, "vrf_id", vrf_id)

    @property
    @pulumi.getter(name="ipAddress")
    def ip_address(self) -> pulumi.Input[str]:
        return pulumi.get(self, "ip_address")

    @ip_address.setter
    def ip_address(self, value: pulumi.Input[str]):
        pulumi.set(self, "ip_address", value)

    @property
    @pulumi.getter
    def status(self) -> pulumi.Input[str]:
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: pulumi.Input[str]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="dnsName")
    def dns_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "dns_name")

    @dns_name.setter
    def dns_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "dns_name", value)

    @property
    @pulumi.getter(name="interfaceId")
    def interface_id(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "interface_id")

    @interface_id.setter
    def interface_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "interface_id", value)

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

    @property
    @pulumi.getter(name="vrfId")
    def vrf_id(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "vrf_id")

    @vrf_id.setter
    def vrf_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "vrf_id", value)


@pulumi.input_type
class _IpAddressState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 dns_name: Optional[pulumi.Input[str]] = None,
                 interface_id: Optional[pulumi.Input[int]] = None,
                 ip_address: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tenant_id: Optional[pulumi.Input[int]] = None,
                 vrf_id: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering IpAddress resources.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if dns_name is not None:
            pulumi.set(__self__, "dns_name", dns_name)
        if interface_id is not None:
            pulumi.set(__self__, "interface_id", interface_id)
        if ip_address is not None:
            pulumi.set(__self__, "ip_address", ip_address)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if tenant_id is not None:
            pulumi.set(__self__, "tenant_id", tenant_id)
        if vrf_id is not None:
            pulumi.set(__self__, "vrf_id", vrf_id)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="dnsName")
    def dns_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "dns_name")

    @dns_name.setter
    def dns_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "dns_name", value)

    @property
    @pulumi.getter(name="interfaceId")
    def interface_id(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "interface_id")

    @interface_id.setter
    def interface_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "interface_id", value)

    @property
    @pulumi.getter(name="ipAddress")
    def ip_address(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "ip_address")

    @ip_address.setter
    def ip_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ip_address", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

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

    @property
    @pulumi.getter(name="vrfId")
    def vrf_id(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "vrf_id")

    @vrf_id.setter
    def vrf_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "vrf_id", value)


class IpAddress(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 dns_name: Optional[pulumi.Input[str]] = None,
                 interface_id: Optional[pulumi.Input[int]] = None,
                 ip_address: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tenant_id: Optional[pulumi.Input[int]] = None,
                 vrf_id: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/ipam/#ip-addresses):

        > An IP address comprises a single host address (either IPv4 or IPv6) and its subnet mask. Its mask should match exactly how the IP address is configured on an interface in the real world.
        > 
        > Like a prefix, an IP address can optionally be assigned to a VRF (otherwise, it will appear in the "global" table). IP addresses are automatically arranged under parent prefixes within their respective VRFs according to the IP hierarchy.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: IpAddressArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/ipam/#ip-addresses):

        > An IP address comprises a single host address (either IPv4 or IPv6) and its subnet mask. Its mask should match exactly how the IP address is configured on an interface in the real world.
        > 
        > Like a prefix, an IP address can optionally be assigned to a VRF (otherwise, it will appear in the "global" table). IP addresses are automatically arranged under parent prefixes within their respective VRFs according to the IP hierarchy.

        :param str resource_name: The name of the resource.
        :param IpAddressArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(IpAddressArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 dns_name: Optional[pulumi.Input[str]] = None,
                 interface_id: Optional[pulumi.Input[int]] = None,
                 ip_address: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tenant_id: Optional[pulumi.Input[int]] = None,
                 vrf_id: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = IpAddressArgs.__new__(IpAddressArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["dns_name"] = dns_name
            __props__.__dict__["interface_id"] = interface_id
            if ip_address is None and not opts.urn:
                raise TypeError("Missing required property 'ip_address'")
            __props__.__dict__["ip_address"] = ip_address
            if status is None and not opts.urn:
                raise TypeError("Missing required property 'status'")
            __props__.__dict__["status"] = status
            __props__.__dict__["tags"] = tags
            __props__.__dict__["tenant_id"] = tenant_id
            __props__.__dict__["vrf_id"] = vrf_id
        super(IpAddress, __self__).__init__(
            'netbox:index/ipAddress:IpAddress',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            dns_name: Optional[pulumi.Input[str]] = None,
            interface_id: Optional[pulumi.Input[int]] = None,
            ip_address: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            tenant_id: Optional[pulumi.Input[int]] = None,
            vrf_id: Optional[pulumi.Input[int]] = None) -> 'IpAddress':
        """
        Get an existing IpAddress resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _IpAddressState.__new__(_IpAddressState)

        __props__.__dict__["description"] = description
        __props__.__dict__["dns_name"] = dns_name
        __props__.__dict__["interface_id"] = interface_id
        __props__.__dict__["ip_address"] = ip_address
        __props__.__dict__["status"] = status
        __props__.__dict__["tags"] = tags
        __props__.__dict__["tenant_id"] = tenant_id
        __props__.__dict__["vrf_id"] = vrf_id
        return IpAddress(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="dnsName")
    def dns_name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "dns_name")

    @property
    @pulumi.getter(name="interfaceId")
    def interface_id(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "interface_id")

    @property
    @pulumi.getter(name="ipAddress")
    def ip_address(self) -> pulumi.Output[str]:
        return pulumi.get(self, "ip_address")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter(name="vrfId")
    def vrf_id(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "vrf_id")

