// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getRegion(args?: GetRegionArgs, opts?: pulumi.InvokeOptions): Promise<GetRegionResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("netbox:index/getRegion:getRegion", {
        "filters": args.filters,
    }, opts);
}

/**
 * A collection of arguments for invoking getRegion.
 */
export interface GetRegionArgs {
    filters?: inputs.GetRegionFilter[];
}

/**
 * A collection of values returned by getRegion.
 */
export interface GetRegionResult {
    readonly description: string;
    readonly filters?: outputs.GetRegionFilter[];
    /**
     * The ID of this resource.
     */
    readonly id: number;
    readonly name: string;
    readonly parentRegionId: number;
    readonly slug: string;
}

export function getRegionOutput(args?: GetRegionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetRegionResult> {
    return pulumi.output(args).apply(a => getRegion(a, opts))
}

/**
 * A collection of arguments for invoking getRegion.
 */
export interface GetRegionOutputArgs {
    filters?: pulumi.Input<pulumi.Input<inputs.GetRegionFilterArgs>[]>;
}
