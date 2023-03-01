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
 * const custAProd = pulumi.output(netbox.getIpRange({
 *     contains: "10.0.0.1/24",
 * }));
 * ```
 */
export function getIpRange(args: GetIpRangeArgs, opts?: pulumi.InvokeOptions): Promise<GetIpRangeResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("netbox:index/getIpRange:getIpRange", {
        "contains": args.contains,
    }, opts);
}

/**
 * A collection of arguments for invoking getIpRange.
 */
export interface GetIpRangeArgs {
    contains: string;
}

/**
 * A collection of values returned by getIpRange.
 */
export interface GetIpRangeResult {
    readonly contains: string;
    /**
     * The ID of this resource.
     */
    readonly id: number;
}

export function getIpRangeOutput(args: GetIpRangeOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetIpRangeResult> {
    return pulumi.output(args).apply(a => getIpRange(a, opts))
}

/**
 * A collection of arguments for invoking getIpRange.
 */
export interface GetIpRangeOutputArgs {
    contains: pulumi.Input<string>;
}