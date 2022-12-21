// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AliCloud.CS
{
    public static class GetAckService
    {
        /// <summary>
        /// Using this data source can open Container Service (CS) service automatically. If the service has been opened, it will return opened.
        /// 
        /// For information about Container Service (CS) and how to use it, see [What is Container Service (CS)](https://www.alibabacloud.com/help/en/product/85222.htm).
        /// 
        /// &gt; **NOTE:** Available in v1.113.0+
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
        ///     var open = AliCloud.CS.GetAckService.Invoke(new()
        ///     {
        ///         Enable = "On",
        ///         Type = "propayasgo",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetAckServiceResult> InvokeAsync(GetAckServiceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAckServiceResult>("alicloud:cs/getAckService:getAckService", args ?? new GetAckServiceArgs(), options.WithDefaults());

        /// <summary>
        /// Using this data source can open Container Service (CS) service automatically. If the service has been opened, it will return opened.
        /// 
        /// For information about Container Service (CS) and how to use it, see [What is Container Service (CS)](https://www.alibabacloud.com/help/en/product/85222.htm).
        /// 
        /// &gt; **NOTE:** Available in v1.113.0+
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
        ///     var open = AliCloud.CS.GetAckService.Invoke(new()
        ///     {
        ///         Enable = "On",
        ///         Type = "propayasgo",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetAckServiceResult> Invoke(GetAckServiceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetAckServiceResult>("alicloud:cs/getAckService:getAckService", args ?? new GetAckServiceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAckServiceArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Setting the value to `On` to enable the service. If has been enabled, return the result. Valid values: `On` or `Off`. Default to `Off`.
        /// </summary>
        [Input("enable")]
        public string? Enable { get; set; }

        /// <summary>
        /// Types of services opened. Valid values: `propayasgo`: Container service ack Pro managed version, `edgepayasgo`: Edge container service, `gspayasgo`: Gene computing services.
        /// </summary>
        [Input("type", required: true)]
        public string Type { get; set; } = null!;

        public GetAckServiceArgs()
        {
        }
        public static new GetAckServiceArgs Empty => new GetAckServiceArgs();
    }

    public sealed class GetAckServiceInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Setting the value to `On` to enable the service. If has been enabled, return the result. Valid values: `On` or `Off`. Default to `Off`.
        /// </summary>
        [Input("enable")]
        public Input<string>? Enable { get; set; }

        /// <summary>
        /// Types of services opened. Valid values: `propayasgo`: Container service ack Pro managed version, `edgepayasgo`: Edge container service, `gspayasgo`: Gene computing services.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public GetAckServiceInvokeArgs()
        {
        }
        public static new GetAckServiceInvokeArgs Empty => new GetAckServiceInvokeArgs();
    }


    [OutputType]
    public sealed class GetAckServiceResult
    {
        public readonly string? Enable;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The current service enable status.
        /// </summary>
        public readonly string Status;
        public readonly string Type;

        [OutputConstructor]
        private GetAckServiceResult(
            string? enable,

            string id,

            string status,

            string type)
        {
            Enable = enable;
            Id = id;
            Status = status;
            Type = type;
        }
    }
}