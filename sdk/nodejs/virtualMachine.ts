// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class VirtualMachine extends pulumi.CustomResource {
    /**
     * Get an existing VirtualMachine resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VirtualMachineState, opts?: pulumi.CustomResourceOptions): VirtualMachine {
        return new VirtualMachine(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'netbox:index/virtualMachine:VirtualMachine';

    /**
     * Returns true if the given object is an instance of VirtualMachine.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualMachine {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualMachine.__pulumiType;
    }

    public readonly clusterId!: pulumi.Output<number>;
    public readonly comments!: pulumi.Output<string | undefined>;
    public readonly customFields!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly diskSizeGb!: pulumi.Output<number | undefined>;
    public readonly memoryMb!: pulumi.Output<number | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly platformId!: pulumi.Output<number | undefined>;
    public /*out*/ readonly primaryIpv4!: pulumi.Output<number>;
    public readonly roleId!: pulumi.Output<number | undefined>;
    public /*out*/ readonly siteId!: pulumi.Output<number>;
    public readonly tags!: pulumi.Output<string[] | undefined>;
    public readonly tenantId!: pulumi.Output<number | undefined>;
    public readonly vcpus!: pulumi.Output<number | undefined>;

    /**
     * Create a VirtualMachine resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualMachineArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VirtualMachineArgs | VirtualMachineState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as VirtualMachineState | undefined;
            resourceInputs["clusterId"] = state ? state.clusterId : undefined;
            resourceInputs["comments"] = state ? state.comments : undefined;
            resourceInputs["customFields"] = state ? state.customFields : undefined;
            resourceInputs["diskSizeGb"] = state ? state.diskSizeGb : undefined;
            resourceInputs["memoryMb"] = state ? state.memoryMb : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["platformId"] = state ? state.platformId : undefined;
            resourceInputs["primaryIpv4"] = state ? state.primaryIpv4 : undefined;
            resourceInputs["roleId"] = state ? state.roleId : undefined;
            resourceInputs["siteId"] = state ? state.siteId : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["tenantId"] = state ? state.tenantId : undefined;
            resourceInputs["vcpus"] = state ? state.vcpus : undefined;
        } else {
            const args = argsOrState as VirtualMachineArgs | undefined;
            if ((!args || args.clusterId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterId'");
            }
            resourceInputs["clusterId"] = args ? args.clusterId : undefined;
            resourceInputs["comments"] = args ? args.comments : undefined;
            resourceInputs["customFields"] = args ? args.customFields : undefined;
            resourceInputs["diskSizeGb"] = args ? args.diskSizeGb : undefined;
            resourceInputs["memoryMb"] = args ? args.memoryMb : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["platformId"] = args ? args.platformId : undefined;
            resourceInputs["roleId"] = args ? args.roleId : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["tenantId"] = args ? args.tenantId : undefined;
            resourceInputs["vcpus"] = args ? args.vcpus : undefined;
            resourceInputs["primaryIpv4"] = undefined /*out*/;
            resourceInputs["siteId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(VirtualMachine.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VirtualMachine resources.
 */
export interface VirtualMachineState {
    clusterId?: pulumi.Input<number>;
    comments?: pulumi.Input<string>;
    customFields?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    diskSizeGb?: pulumi.Input<number>;
    memoryMb?: pulumi.Input<number>;
    name?: pulumi.Input<string>;
    platformId?: pulumi.Input<number>;
    primaryIpv4?: pulumi.Input<number>;
    roleId?: pulumi.Input<number>;
    siteId?: pulumi.Input<number>;
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    tenantId?: pulumi.Input<number>;
    vcpus?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a VirtualMachine resource.
 */
export interface VirtualMachineArgs {
    clusterId: pulumi.Input<number>;
    comments?: pulumi.Input<string>;
    customFields?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    diskSizeGb?: pulumi.Input<number>;
    memoryMb?: pulumi.Input<number>;
    name?: pulumi.Input<string>;
    platformId?: pulumi.Input<number>;
    roleId?: pulumi.Input<number>;
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    tenantId?: pulumi.Input<number>;
    vcpus?: pulumi.Input<number>;
}
