// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace HBJYDev.Netbox
{
    [NetboxResourceType("netbox:index/token:Token")]
    public partial class Token : global::Pulumi.CustomResource
    {
        [Output("key")]
        public Output<string?> Key { get; private set; } = null!;

        [Output("userId")]
        public Output<int> UserId { get; private set; } = null!;


        /// <summary>
        /// Create a Token resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Token(string name, TokenArgs args, CustomResourceOptions? options = null)
            : base("netbox:index/token:Token", name, args ?? new TokenArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Token(string name, Input<string> id, TokenState? state = null, CustomResourceOptions? options = null)
            : base("netbox:index/token:Token", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Token resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Token Get(string name, Input<string> id, TokenState? state = null, CustomResourceOptions? options = null)
        {
            return new Token(name, id, state, options);
        }
    }

    public sealed class TokenArgs : global::Pulumi.ResourceArgs
    {
        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("userId", required: true)]
        public Input<int> UserId { get; set; } = null!;

        public TokenArgs()
        {
        }
        public static new TokenArgs Empty => new TokenArgs();
    }

    public sealed class TokenState : global::Pulumi.ResourceArgs
    {
        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("userId")]
        public Input<int>? UserId { get; set; }

        public TokenState()
        {
        }
        public static new TokenState Empty => new TokenState();
    }
}
