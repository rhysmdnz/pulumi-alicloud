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
    'GetReposResult',
    'AwaitableGetReposResult',
    'get_repos',
    'get_repos_output',
]

@pulumi.output_type
class GetReposResult:
    """
    A collection of values returned by getRepos.
    """
    def __init__(__self__, enable_details=None, id=None, ids=None, name_regex=None, names=None, namespace=None, output_file=None, repos=None):
        if enable_details and not isinstance(enable_details, bool):
            raise TypeError("Expected argument 'enable_details' to be a bool")
        pulumi.set(__self__, "enable_details", enable_details)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ids and not isinstance(ids, list):
            raise TypeError("Expected argument 'ids' to be a list")
        pulumi.set(__self__, "ids", ids)
        if name_regex and not isinstance(name_regex, str):
            raise TypeError("Expected argument 'name_regex' to be a str")
        pulumi.set(__self__, "name_regex", name_regex)
        if names and not isinstance(names, list):
            raise TypeError("Expected argument 'names' to be a list")
        pulumi.set(__self__, "names", names)
        if namespace and not isinstance(namespace, str):
            raise TypeError("Expected argument 'namespace' to be a str")
        pulumi.set(__self__, "namespace", namespace)
        if output_file and not isinstance(output_file, str):
            raise TypeError("Expected argument 'output_file' to be a str")
        pulumi.set(__self__, "output_file", output_file)
        if repos and not isinstance(repos, list):
            raise TypeError("Expected argument 'repos' to be a list")
        pulumi.set(__self__, "repos", repos)

    @property
    @pulumi.getter(name="enableDetails")
    def enable_details(self) -> Optional[bool]:
        return pulumi.get(self, "enable_details")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def ids(self) -> Sequence[str]:
        """
        A list of matched Container Registry Repositories. Its element is set to `names`.
        """
        return pulumi.get(self, "ids")

    @property
    @pulumi.getter(name="nameRegex")
    def name_regex(self) -> Optional[str]:
        return pulumi.get(self, "name_regex")

    @property
    @pulumi.getter
    def names(self) -> Sequence[str]:
        """
        A list of repository names.
        """
        return pulumi.get(self, "names")

    @property
    @pulumi.getter
    def namespace(self) -> Optional[str]:
        """
        Name of container registry namespace where repo is located.
        """
        return pulumi.get(self, "namespace")

    @property
    @pulumi.getter(name="outputFile")
    def output_file(self) -> Optional[str]:
        return pulumi.get(self, "output_file")

    @property
    @pulumi.getter
    def repos(self) -> Sequence['outputs.GetReposRepoResult']:
        """
        A list of matched Container Registry Namespaces. Each element contains the following attributes:
        """
        return pulumi.get(self, "repos")


class AwaitableGetReposResult(GetReposResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetReposResult(
            enable_details=self.enable_details,
            id=self.id,
            ids=self.ids,
            name_regex=self.name_regex,
            names=self.names,
            namespace=self.namespace,
            output_file=self.output_file,
            repos=self.repos)


def get_repos(enable_details: Optional[bool] = None,
              name_regex: Optional[str] = None,
              namespace: Optional[str] = None,
              output_file: Optional[str] = None,
              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetReposResult:
    """
    This data source provides a list Container Registry repositories on Alibaba Cloud.

    > **NOTE:** Available in v1.35.0+

    ## Example Usage

    ```python
    import pulumi
    import pulumi_alicloud as alicloud

    my_repos = alicloud.cr.get_repos(name_regex="my-repos",
        output_file="my-repo-json")
    pulumi.export("output", my_repos.repos)
    ```


    :param bool enable_details: Boolean, false by default, only repository attributes are exported. Set to true if domain list and tags belong to this repository are needed. See `tags` in attributes.
    :param str name_regex: A regex string to filter results by repository name.
    :param str namespace: Name of container registry namespace where the repositories are located in.
    """
    __args__ = dict()
    __args__['enableDetails'] = enable_details
    __args__['nameRegex'] = name_regex
    __args__['namespace'] = namespace
    __args__['outputFile'] = output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('alicloud:cr/getRepos:getRepos', __args__, opts=opts, typ=GetReposResult).value

    return AwaitableGetReposResult(
        enable_details=__ret__.enable_details,
        id=__ret__.id,
        ids=__ret__.ids,
        name_regex=__ret__.name_regex,
        names=__ret__.names,
        namespace=__ret__.namespace,
        output_file=__ret__.output_file,
        repos=__ret__.repos)


@_utilities.lift_output_func(get_repos)
def get_repos_output(enable_details: Optional[pulumi.Input[Optional[bool]]] = None,
                     name_regex: Optional[pulumi.Input[Optional[str]]] = None,
                     namespace: Optional[pulumi.Input[Optional[str]]] = None,
                     output_file: Optional[pulumi.Input[Optional[str]]] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetReposResult]:
    """
    This data source provides a list Container Registry repositories on Alibaba Cloud.

    > **NOTE:** Available in v1.35.0+

    ## Example Usage

    ```python
    import pulumi
    import pulumi_alicloud as alicloud

    my_repos = alicloud.cr.get_repos(name_regex="my-repos",
        output_file="my-repo-json")
    pulumi.export("output", my_repos.repos)
    ```


    :param bool enable_details: Boolean, false by default, only repository attributes are exported. Set to true if domain list and tags belong to this repository are needed. See `tags` in attributes.
    :param str name_regex: A regex string to filter results by repository name.
    :param str namespace: Name of container registry namespace where the repositories are located in.
    """
    ...