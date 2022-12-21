// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.Log.Outputs
{

    [OutputType]
    public sealed class GetStoresStoreResult
    {
        /// <summary>
        /// The ID of the store.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the store.
        /// </summary>
        public readonly string StoreName;

        [OutputConstructor]
        private GetStoresStoreResult(
            string id,

            string storeName)
        {
            Id = id;
            StoreName = storeName;
        }
    }
}