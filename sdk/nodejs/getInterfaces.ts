// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as netbox from "@pulumi/netbox";
 *
 * const myvmEth0 = pulumi.output(netbox.Interface({
 *     filter: [{
 *         name: "name",
 *         value: "myvm",
 *     }],
 *     nameRegex: "eth0",
 * }));
 * ```
 */
export function getInterfaces(args?: GetInterfacesArgs, opts?: pulumi.InvokeOptions): Promise<GetInterfacesResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("netbox:index/getInterfaces:getInterfaces", {
        "filters": args.filters,
        "nameRegex": args.nameRegex,
    }, opts);
}

/**
 * A collection of arguments for invoking getInterfaces.
 */
export interface GetInterfacesArgs {
    filters?: inputs.GetInterfacesFilter[];
    nameRegex?: string;
}

/**
 * A collection of values returned by getInterfaces.
 */
export interface GetInterfacesResult {
    readonly filters?: outputs.GetInterfacesFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly interfaces: outputs.GetInterfacesInterface[];
    readonly nameRegex?: string;
}

export function getInterfacesOutput(args?: GetInterfacesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetInterfacesResult> {
    return pulumi.output(args).apply(a => getInterfaces(a, opts))
}

/**
 * A collection of arguments for invoking getInterfaces.
 */
export interface GetInterfacesOutputArgs {
    filters?: pulumi.Input<pulumi.Input<inputs.GetInterfacesFilterArgs>[]>;
    nameRegex?: pulumi.Input<string>;
}
