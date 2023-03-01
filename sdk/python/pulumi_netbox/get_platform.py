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
    'GetPlatformResult',
    'AwaitableGetPlatformResult',
    'get_platform',
    'get_platform_output',
]

@pulumi.output_type
class GetPlatformResult:
    """
    A collection of values returned by getPlatform.
    """
    def __init__(__self__, id=None, name=None, slug=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if slug and not isinstance(slug, str):
            raise TypeError("Expected argument 'slug' to be a str")
        pulumi.set(__self__, "slug", slug)

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
    @pulumi.getter
    def slug(self) -> str:
        return pulumi.get(self, "slug")


class AwaitableGetPlatformResult(GetPlatformResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPlatformResult(
            id=self.id,
            name=self.name,
            slug=self.slug)


def get_platform(name: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPlatformResult:
    """
    ## Example Usage

    ```python
    import pulumi
    import pulumi_netbox as netbox

    p_anos = netbox.get_platform(name="PANOS")
    ```
    """
    __args__ = dict()
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('netbox:index/getPlatform:getPlatform', __args__, opts=opts, typ=GetPlatformResult).value

    return AwaitableGetPlatformResult(
        id=__ret__.id,
        name=__ret__.name,
        slug=__ret__.slug)


@_utilities.lift_output_func(get_platform)
def get_platform_output(name: Optional[pulumi.Input[str]] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetPlatformResult]:
    """
    ## Example Usage

    ```python
    import pulumi
    import pulumi_netbox as netbox

    p_anos = netbox.get_platform(name="PANOS")
    ```
    """
    ...