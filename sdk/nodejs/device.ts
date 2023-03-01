// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/devices/#devices):
 *
 * > Every piece of hardware which is installed within a site or rack exists in NetBox as a device. Devices are measured in rack units (U) and can be half depth or full depth. A device may have a height of 0U: These devices do not consume vertical rack space and cannot be assigned to a particular rack unit. A common example of a 0U device is a vertically-mounted PDU.
 */
export class Device extends pulumi.CustomResource {
    /**
     * Get an existing Device resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DeviceState, opts?: pulumi.CustomResourceOptions): Device {
        return new Device(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'netbox:index/device:Device';

    /**
     * Returns true if the given object is an instance of Device.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Device {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Device.__pulumiType;
    }

    public readonly comments!: pulumi.Output<string | undefined>;
    public readonly deviceTypeId!: pulumi.Output<number>;
    public readonly name!: pulumi.Output<string>;
    public /*out*/ readonly primaryIpv4!: pulumi.Output<number>;
    public readonly roleId!: pulumi.Output<number | undefined>;
    public readonly serial!: pulumi.Output<string | undefined>;
    public readonly siteId!: pulumi.Output<number | undefined>;
    public readonly tags!: pulumi.Output<string[] | undefined>;
    public readonly tenantId!: pulumi.Output<number | undefined>;

    /**
     * Create a Device resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DeviceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DeviceArgs | DeviceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DeviceState | undefined;
            resourceInputs["comments"] = state ? state.comments : undefined;
            resourceInputs["deviceTypeId"] = state ? state.deviceTypeId : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["primaryIpv4"] = state ? state.primaryIpv4 : undefined;
            resourceInputs["roleId"] = state ? state.roleId : undefined;
            resourceInputs["serial"] = state ? state.serial : undefined;
            resourceInputs["siteId"] = state ? state.siteId : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["tenantId"] = state ? state.tenantId : undefined;
        } else {
            const args = argsOrState as DeviceArgs | undefined;
            if ((!args || args.deviceTypeId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'deviceTypeId'");
            }
            resourceInputs["comments"] = args ? args.comments : undefined;
            resourceInputs["deviceTypeId"] = args ? args.deviceTypeId : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["roleId"] = args ? args.roleId : undefined;
            resourceInputs["serial"] = args ? args.serial : undefined;
            resourceInputs["siteId"] = args ? args.siteId : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["tenantId"] = args ? args.tenantId : undefined;
            resourceInputs["primaryIpv4"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Device.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Device resources.
 */
export interface DeviceState {
    comments?: pulumi.Input<string>;
    deviceTypeId?: pulumi.Input<number>;
    name?: pulumi.Input<string>;
    primaryIpv4?: pulumi.Input<number>;
    roleId?: pulumi.Input<number>;
    serial?: pulumi.Input<string>;
    siteId?: pulumi.Input<number>;
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    tenantId?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a Device resource.
 */
export interface DeviceArgs {
    comments?: pulumi.Input<string>;
    deviceTypeId: pulumi.Input<number>;
    name?: pulumi.Input<string>;
    roleId?: pulumi.Input<number>;
    serial?: pulumi.Input<string>;
    siteId?: pulumi.Input<number>;
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    tenantId?: pulumi.Input<number>;
}