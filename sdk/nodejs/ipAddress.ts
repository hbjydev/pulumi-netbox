// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * From the [official documentation](https://docs.netbox.dev/en/stable/core-functionality/ipam/#ip-addresses):
 *
 * > An IP address comprises a single host address (either IPv4 or IPv6) and its subnet mask. Its mask should match exactly how the IP address is configured on an interface in the real world.
 * > 
 * > Like a prefix, an IP address can optionally be assigned to a VRF (otherwise, it will appear in the "global" table). IP addresses are automatically arranged under parent prefixes within their respective VRFs according to the IP hierarchy.
 */
export class IpAddress extends pulumi.CustomResource {
    /**
     * Get an existing IpAddress resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IpAddressState, opts?: pulumi.CustomResourceOptions): IpAddress {
        return new IpAddress(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'netbox:index/ipAddress:IpAddress';

    /**
     * Returns true if the given object is an instance of IpAddress.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IpAddress {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IpAddress.__pulumiType;
    }

    public readonly description!: pulumi.Output<string | undefined>;
    public readonly dnsName!: pulumi.Output<string | undefined>;
    public readonly interfaceId!: pulumi.Output<number | undefined>;
    public readonly ipAddress!: pulumi.Output<string>;
    public readonly status!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<string[] | undefined>;
    public readonly tenantId!: pulumi.Output<number | undefined>;
    public readonly vrfId!: pulumi.Output<number | undefined>;

    /**
     * Create a IpAddress resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IpAddressArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: IpAddressArgs | IpAddressState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as IpAddressState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["dnsName"] = state ? state.dnsName : undefined;
            resourceInputs["interfaceId"] = state ? state.interfaceId : undefined;
            resourceInputs["ipAddress"] = state ? state.ipAddress : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["tenantId"] = state ? state.tenantId : undefined;
            resourceInputs["vrfId"] = state ? state.vrfId : undefined;
        } else {
            const args = argsOrState as IpAddressArgs | undefined;
            if ((!args || args.ipAddress === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ipAddress'");
            }
            if ((!args || args.status === undefined) && !opts.urn) {
                throw new Error("Missing required property 'status'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["dnsName"] = args ? args.dnsName : undefined;
            resourceInputs["interfaceId"] = args ? args.interfaceId : undefined;
            resourceInputs["ipAddress"] = args ? args.ipAddress : undefined;
            resourceInputs["status"] = args ? args.status : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["tenantId"] = args ? args.tenantId : undefined;
            resourceInputs["vrfId"] = args ? args.vrfId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(IpAddress.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering IpAddress resources.
 */
export interface IpAddressState {
    description?: pulumi.Input<string>;
    dnsName?: pulumi.Input<string>;
    interfaceId?: pulumi.Input<number>;
    ipAddress?: pulumi.Input<string>;
    status?: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    tenantId?: pulumi.Input<number>;
    vrfId?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a IpAddress resource.
 */
export interface IpAddressArgs {
    description?: pulumi.Input<string>;
    dnsName?: pulumi.Input<string>;
    interfaceId?: pulumi.Input<number>;
    ipAddress: pulumi.Input<string>;
    status: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    tenantId?: pulumi.Input<number>;
    vrfId?: pulumi.Input<number>;
}
