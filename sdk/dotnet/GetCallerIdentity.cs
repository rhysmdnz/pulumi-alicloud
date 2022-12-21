// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud
{
    public static class GetCallerIdentity
    {
        /// <summary>
        /// This data source provides the identity of the current user.
        /// 
        /// &gt; **NOTE:** Available in 1.65.0+.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using AliCloud = Pulumi.AliCloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var current = AliCloud.GetCallerIdentity.Invoke();
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["currentUserArn"] = current.Apply(getCallerIdentityResult =&gt; getCallerIdentityResult.Id),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetCallerIdentityResult> InvokeAsync(InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCallerIdentityResult>("alicloud:index/getCallerIdentity:getCallerIdentity", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetCallerIdentityResult
    {
        /// <summary>
        /// Account ID.
        /// </summary>
        public readonly string AccountId;
        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the user making the call.
        /// </summary>
        public readonly string Arn;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The type of the princiapal. RAMUser for users.
        /// </summary>
        public readonly string IdentityType;

        [OutputConstructor]
        private GetCallerIdentityResult(
            string accountId,

            string arn,

            string id,

            string identityType)
        {
            AccountId = accountId;
            Arn = arn;
            Id = id;
            IdentityType = identityType;
        }
    }
}