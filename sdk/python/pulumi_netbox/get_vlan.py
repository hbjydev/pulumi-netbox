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
    'GetVlanResult',
    'AwaitableGetVlanResult',
    'get_vlan',
    'get_vlan_output',
]

@pulumi.output_type
class GetVlanResult:
    """
    A collection of values returned by getVlan.
    """
    def __init__(__self__, description=None, id=None, name=None, role=None, site=None, status=None, tenant=None, vid=None):
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if role and not isinstance(role, int):
            raise TypeError("Expected argument 'role' to be a int")
        pulumi.set(__self__, "role", role)
        if site and not isinstance(site, int):
            raise TypeError("Expected argument 'site' to be a int")
        pulumi.set(__self__, "site", site)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if tenant and not isinstance(tenant, int):
            raise TypeError("Expected argument 'tenant' to be a int")
        pulumi.set(__self__, "tenant", tenant)
        if vid and not isinstance(vid, int):
            raise TypeError("Expected argument 'vid' to be a int")
        pulumi.set(__self__, "vid", vid)

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
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def role(self) -> int:
        return pulumi.get(self, "role")

    @property
    @pulumi.getter
    def site(self) -> int:
        return pulumi.get(self, "site")

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def tenant(self) -> int:
        return pulumi.get(self, "tenant")

    @property
    @pulumi.getter
    def vid(self) -> Optional[int]:
        return pulumi.get(self, "vid")


class AwaitableGetVlanResult(GetVlanResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVlanResult(
            description=self.description,
            id=self.id,
            name=self.name,
            role=self.role,
            site=self.site,
            status=self.status,
            tenant=self.tenant,
            vid=self.vid)


def get_vlan(name: Optional[str] = None,
             vid: Optional[int] = None,
             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetVlanResult:
    """
    ## Example Usage

    ```python
    import pulumi
    import pulumi_netbox as netbox

    vlan1 = netbox.get_vlan(name="vlan-1")
    vlan2 = netbox.get_vlan(vid=1234)
    ```
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['vid'] = vid
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('netbox:index/getVlan:getVlan', __args__, opts=opts, typ=GetVlanResult).value

    return AwaitableGetVlanResult(
        description=__ret__.description,
        id=__ret__.id,
        name=__ret__.name,
        role=__ret__.role,
        site=__ret__.site,
        status=__ret__.status,
        tenant=__ret__.tenant,
        vid=__ret__.vid)


@_utilities.lift_output_func(get_vlan)
def get_vlan_output(name: Optional[pulumi.Input[Optional[str]]] = None,
                    vid: Optional[pulumi.Input[Optional[int]]] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetVlanResult]:
    """
    ## Example Usage

    ```python
    import pulumi
    import pulumi_netbox as netbox

    vlan1 = netbox.get_vlan(name="vlan-1")
    vlan2 = netbox.get_vlan(vid=1234)
    ```
    """
    ...
