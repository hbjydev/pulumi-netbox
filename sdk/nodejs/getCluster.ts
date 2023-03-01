// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as netbox from "@pulumi/netbox";
 *
 * const vmwCluster01 = pulumi.output(netbox.getCluster({
 *     name: "vmw-cluster-01",
 * }));
 * ```
 */
export function getCluster(args: GetClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetClusterResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("netbox:index/getCluster:getCluster", {
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getCluster.
 */
export interface GetClusterArgs {
    name: string;
}

/**
 * A collection of values returned by getCluster.
 */
export interface GetClusterResult {
    readonly clusterId: number;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
}

export function getClusterOutput(args: GetClusterOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetClusterResult> {
    return pulumi.output(args).apply(a => getCluster(a, opts))
}

/**
 * A collection of arguments for invoking getCluster.
 */
export interface GetClusterOutputArgs {
    name: pulumi.Input<string>;
}