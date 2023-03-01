# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetTenantGroupResult',
    'AwaitableGetTenantGroupResult',
    'get_tenant_group',
    'get_tenant_group_output',
]

@pulumi.output_type
class GetTenantGroupResult:
    """
    A collection of values returned by getTenantGroup.
    """
    def __init__(__self__, description=None, id=None, name=None, parent_id=None, slug=None):
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if parent_id and not isinstance(parent_id, int):
            raise TypeError("Expected argument 'parent_id' to be a int")
        pulumi.set(__self__, "parent_id", parent_id)
        if slug and not isinstance(slug, str):
            raise TypeError("Expected argument 'slug' to be a str")
        pulumi.set(__self__, "slug", slug)

    @property
    @pulumi.getter
    def description(self) -> str:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="parentId")
    def parent_id(self) -> int:
        return pulumi.get(self, "parent_id")

    @property
    @pulumi.getter
    def slug(self) -> str:
        return pulumi.get(self, "slug")


class AwaitableGetTenantGroupResult(GetTenantGroupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetTenantGroupResult(
            description=self.description,
            id=self.id,
            name=self.name,
            parent_id=self.parent_id,
            slug=self.slug)


def get_tenant_group(name: Optional[str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetTenantGroupResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('netbox:index/getTenantGroup:getTenantGroup', __args__, opts=opts, typ=GetTenantGroupResult).value

    return AwaitableGetTenantGroupResult(
        description=__ret__.description,
        id=__ret__.id,
        name=__ret__.name,
        parent_id=__ret__.parent_id,
        slug=__ret__.slug)


@_utilities.lift_output_func(get_tenant_group)
def get_tenant_group_output(name: Optional[pulumi.Input[str]] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetTenantGroupResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...