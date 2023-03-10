// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class DeviceType extends pulumi.CustomResource {
    /**
     * Get an existing DeviceType resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DeviceTypeState, opts?: pulumi.CustomResourceOptions): DeviceType {
        return new DeviceType(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'netbox:index/deviceType:DeviceType';

    /**
     * Returns true if the given object is an instance of DeviceType.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DeviceType {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DeviceType.__pulumiType;
    }

    public readonly manufacturerId!: pulumi.Output<number | undefined>;
    public readonly model!: pulumi.Output<string>;
    public readonly partNumber!: pulumi.Output<string | undefined>;
    public readonly slug!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<string[] | undefined>;

    /**
     * Create a DeviceType resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DeviceTypeArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DeviceTypeArgs | DeviceTypeState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DeviceTypeState | undefined;
            resourceInputs["manufacturerId"] = state ? state.manufacturerId : undefined;
            resourceInputs["model"] = state ? state.model : undefined;
            resourceInputs["partNumber"] = state ? state.partNumber : undefined;
            resourceInputs["slug"] = state ? state.slug : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as DeviceTypeArgs | undefined;
            if ((!args || args.model === undefined) && !opts.urn) {
                throw new Error("Missing required property 'model'");
            }
            resourceInputs["manufacturerId"] = args ? args.manufacturerId : undefined;
            resourceInputs["model"] = args ? args.model : undefined;
            resourceInputs["partNumber"] = args ? args.partNumber : undefined;
            resourceInputs["slug"] = args ? args.slug : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DeviceType.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DeviceType resources.
 */
export interface DeviceTypeState {
    manufacturerId?: pulumi.Input<number>;
    model?: pulumi.Input<string>;
    partNumber?: pulumi.Input<string>;
    slug?: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a DeviceType resource.
 */
export interface DeviceTypeArgs {
    manufacturerId?: pulumi.Input<number>;
    model: pulumi.Input<string>;
    partNumber?: pulumi.Input<string>;
    slug?: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<string>[]>;
}
